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

namespace MidtermLab
{
    public partial class frmStudents : Form
    {
        public frmStudents()
        {
            InitializeComponent();
        }
        SqlConnection StudentsConnection;
        SqlCommand StudentsCommand;
        SqlDataAdapter StudentsAdapter;
        DataTable StudentsTable;
        CurrencyManager StudentsManager;

        private void frmStudents_Load(object sender, EventArgs e)
        {
            // connect to the Students Database
            StudentsConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename=H:\\Term6\\Database Development\\InClass\\MIdterm\\Students.mdf; Integrated Security=true; Connect Timeout=30;");
            // open the connecton
            StudentsConnection.Open();

            //Establish command object
            StudentsCommand = new SqlCommand("Select * FROM Students", StudentsConnection);
            //establish data adapter/data table
            
            StudentsAdapter = new SqlDataAdapter();
            StudentsAdapter.SelectCommand = StudentsCommand;

            StudentsTable = new DataTable();
            StudentsAdapter.Fill(StudentsTable);
            // bind controls to data table
            txtFName.DataBindings.Add("Text", StudentsTable, "FirstName");
            txtLName.DataBindings.Add("Text", StudentsTable, "LastName");
            txtBirthdate.DataBindings.Add("Text", StudentsTable, "Birthdate");
            txtGPA.DataBindings.Add("Text", StudentsTable, "GPA");
            txtTerm.DataBindings.Add("Text", StudentsTable, "Term");
            // establish currency manager
            StudentsManager = (CurrencyManager)BindingContext[StudentsTable];
            // Close connections
            StudentsConnection.Close();
            //dipose of the connection object
            StudentsConnection.Dispose();
            StudentsCommand.Dispose();
            StudentsAdapter.Dispose();
            StudentsTable.Dispose();
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            StudentsManager.Position = 0;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            StudentsManager.Position--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            StudentsManager.Position++;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            StudentsManager.Position = StudentsManager.Count - 1;
        }
    }
}
