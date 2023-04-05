using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Example5_2
{
    public partial class frmAuthors : Form
    {
        SqlConnection booksConnection;
        SqlCommand authorsCommand;
        SqlDataAdapter authorsAdapter;
        DataTable authorsTable;
        CurrencyManager authorsManager;

        public frmAuthors()
        {
            InitializeComponent();
        }

        private void frmAuthors_Load(object sender, EventArgs e)
        {
            //connect to books database
            booksConnection = new SqlConnection("Data Source=.\\SQLEXPRESS; AttachDbFilename=C:\\Databases\\SQLBooksDB.mdf; Integrated Security=True; Connect Timeout=30; USer Instance=True;");
            booksConnection.Open();
            // establish command object
            authorsCommand = new SqlCommand("Select * from Authors ORDER BY Author", booksConnection);
            //establish data adapter/data table
            authorsAdapter = new SqlDataAdapter();
            authorsAdapter.SelectCommand = authorsCommand;
            authorsTable = new DataTable();
            authorsAdapter.Fill(authorsTable);
            //bind controls to data table
            txtAuthorID.DataBindings.Add("Text", authorsTable, "Au_ID");
            txtAuthorName.DataBindings.Add("Text", authorsTable, "Author");
            txtYearBorn.DataBindings.Add("Text", authorsTable, "Year_Born");
            // establish currency manager
            authorsManager = (CurrencyManager)this.BindingContext[authorsTable];
        }

        private void frmAuthors_FormClosing(object sender, FormClosingEventArgs e)
        {
            //close the connection
            booksConnection.Close();
            // dispose of the objects
            booksConnection.Dispose();
            authorsCommand.Dispose();
            authorsAdapter.Dispose();
            authorsTable.Dispose();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            authorsManager.Position--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            authorsManager.Position++;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Record saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult response;
            response = MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (response == DialogResult.No)
            {
                return;
            }
        }
    }
}
