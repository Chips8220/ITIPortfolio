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
        SqlCommandBuilder s;
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
        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetState("Edit");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // save changes to program
                StudentsManager.EndCurrentEdit();

                StudentsAdapter.UpdateCommand = s.GetUpdateCommand();
                StudentsAdapter.Update(StudentsTable);
                MessageBox.Show("Record Saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetState("View");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetState("View");
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNewStudent s = new AddNewStudent();
            DialogResult dialogResult = s.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                StudentsManager.AddNew();
                txtFName.Text = s.Fname;
                txtLName.Text = s.Lname;
                txtBirthdate.Text = s.BDate;
                txtGPA.Text = s.GPA;
                txtTerm.Text = s.Term;
                StudentsManager.EndCurrentEdit();
                StudentsAdapter.Update(StudentsTable);
            }
        }




        private void SetState(string appState)
        {
            switch (appState)
            {
                case "View":
                    txtFName.ReadOnly = true;
                    txtLName.ReadOnly = true;
                    txtBirthdate.ReadOnly = true;
                    txtGPA.ReadOnly = true;
                    txtTerm.ReadOnly = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnEdit.Enabled = true;
                    btnSave.Visible = false;
                    btnCancel.Visible = false;
                    btnDelete.Visible = false;
                    btnAddNew.Visible = false;
                    break;

                default: //Edit if not View
                    txtFName.ReadOnly = false;
                    txtLName.ReadOnly = false;
                    txtBirthdate.ReadOnly = false;
                    txtGPA.ReadOnly = false;
                    txtTerm.ReadOnly = false;
                    btnSave.Visible = true;
                    btnDelete.Visible = true;
                    btnCancel.Visible = true;
                    btnAddNew.Visible = true;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnEdit.Enabled = false;
                    break;
            }
        }

    }
}
