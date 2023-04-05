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

namespace Chapter3_Exercise3_1
{
    public partial class frmTitles : Form
    {
        public frmTitles()
        {
            InitializeComponent();
        }
        SqlConnection booksConnection;
        SqlCommand titlesCommand;
        SqlDataAdapter titlesAdapter;
        DataTable titlesTable;
        CurrencyManager titlesManager;

        private void frmTitles_Load(object sender, EventArgs e)
        {
            // connect to books database
            booksConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename=H:\\Term6\\Database Development\\InClass\\MIdterm\\Students.mdf; Integrated Security=true; Connect Timeout=30;");
            //open the connection
            booksConnection.Open();
            //display state
            
            //establish command object
            titlesCommand = new SqlCommand("Select * from Titles", booksConnection);
            //establish data adapter/data table
            titlesAdapter = new SqlDataAdapter();
            titlesAdapter.SelectCommand = titlesCommand;
            titlesTable = new DataTable();
            titlesAdapter.Fill(titlesTable);
            //bind controls to data table
            txtTitle.DataBindings.Add("Text", titlesTable, "Title");
            txtYearPublished.DataBindings.Add("Text", titlesTable, "Year_Published");
            txtISBN.DataBindings.Add("Text", titlesTable, "ISBN");
            txtPubID.DataBindings.Add("Text", titlesTable, "PubID");
            //establish currency manager
            titlesManager = (CurrencyManager)BindingContext[titlesTable];
            //close connection
            booksConnection.Close();
            //display state
            
            //dispose of the connection object
            booksConnection.Dispose();
            titlesCommand.Dispose();
            titlesAdapter.Dispose();
            titlesTable.Dispose();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            titlesManager.Position = 0;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            titlesManager.Position--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            titlesManager.Position++;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            titlesManager.Position = titlesManager.Count - 1;
        }
    }
}
