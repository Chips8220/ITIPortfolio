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
    public partial class frmTitles : Form
    {
        SqlConnection booksConnection;
        SqlCommand titlesCommand;
        SqlDataAdapter titlesAdapter;
        DataTable titlesTable;
        CurrencyManager titlesManager;
        string myState;
        int myBookmark;

        public frmTitles()
        {
            InitializeComponent();
        }

        private void frmTitles_Load(object sender, EventArgs e)
        {
           

            try
            {
                //connect to books database
                booksConnection = new SqlConnection("Data Source=.\\SQLEXPRESS; AttachDbFilename=C:\\Database\\SQLBooksDB.mdf; Integrated Security=True; Connect Timeout=30; User Instance=True;");
                booksConnection.Open();
                // establish command object
                titlesCommand = new SqlCommand("SELECT * FROM Titles ORDER BY Title", booksConnection);
                //establish data adapter/data table
                titlesAdapter = new SqlDataAdapter();
                titlesAdapter.SelectCommand = titlesCommand;
                titlesTable = new DataTable();
                titlesAdapter.Fill(titlesTable);
                //bind controls to data table
                txtTitle.DataBindings.Add("Text",
 titlesTable, "Title");
                txtYear.DataBindings.Add("Text",
                titlesTable, "Year_Published");
                txtISBN.DataBindings.Add("Text",
                titlesTable, "ISBN");
                txtDescription.DataBindings.Add("Text",
 titlesTable, "Description");
                txtNotes.DataBindings.Add("Text",
                titlesTable, "Notes");
                txtSubject.DataBindings.Add("Text",
                titlesTable, "Subject");
                txtComments.DataBindings.Add("Text",
                titlesTable, "Comments");

                // establish currency manager
                titlesManager = (CurrencyManager)this.BindingContext[titlesTable];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error establishign Authors table.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Show();
            SetState("View");
            
            SetText();
        }

        private void frmPublishers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (myState.Equals("Edit") || myState.Equals("Add"))
            {
                MessageBox.Show("You must finish the current edit before stopping the application.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
            else
            {
                try
                {
                    //save chagnes to database
                    SqlCommandBuilder publisherAdapterCommands = new SqlCommandBuilder(titlesAdapter);
                    titlesAdapter.Update(titlesTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving database to file: \r\n" + ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //close the connection
                booksConnection.Close();
                // dispose of the objects
                booksConnection.Dispose();
                titlesCommand.Dispose();
                titlesAdapter.Dispose();
                titlesTable.Dispose();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (titlesManager.Position == 0)
            {
                Console.Beep();
            }
            titlesManager.Position--;
            SetText();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (titlesManager.Position == titlesManager.Count - 1)
            {
                Console.Beep();
            }
            titlesManager.Position++;
            SetText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (!ValidateData())
            {
                return;
            }
            string savedName = txtYear.Text;
            int savedRow;
            try
            {
                titlesManager.EndCurrentEdit();
                titlesTable.DefaultView.Sort = "Name";
                savedRow =
                titlesTable.DefaultView.Find(savedName);
                titlesManager.Position = savedRow;
                MessageBox.Show("Record Saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetState("View");
            }
            catch (Exception)
            {
                MessageBox.Show("Error saving record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SetText();
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
            try
            {
                titlesManager.RemoveAt(titlesManager.Position);
            }
            catch
            {
                MessageBox.Show("Error deleting record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SetText();
        }
        private void SetState(string appState)
        {
            myState = appState;
            switch (appState)
            {
                case "View":
                    txtTitle.BackColor = Color.White;
                    txtTitle.ForeColor = Color.Black;
                    txtYear.ReadOnly = true;
                    txtISBN.ReadOnly = true;
                    txtDescription.ReadOnly = true;
                    txtNotes.ReadOnly = true;
                    txtSubject.ReadOnly = true;
                    txtComments.ReadOnly = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnAddNew.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnDone.Enabled = true;
                    txtYear.Enabled = true;
                    btnFirst.Enabled = true;
                    btnLast.Enabled = true;
                    btnFind.Enabled = true;
                    txtTitle.Focus();
                    break;
                default: // Add or Edit of not View
                    txtTitle.ReadOnly = false;
                    txtYear.ReadOnly = false;
                    if (myState.Equals("Edit"))
                    {
                        txtTitle.BackColor = Color.Red;
                        txtTitle.ForeColor = Color.White;
                        txtISBN.ReadOnly = true;
                        txtISBN.TabStop = false;
                    }
                    else
                    {
                        txtISBN.TabStop = true;
                    }
                    txtDescription.ReadOnly = false;
                    txtNotes.ReadOnly = false;
                    txtSubject.ReadOnly = false;
                    txtComments.ReadOnly = false;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnAddNew.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnDone.Enabled = false;
                    btnFirst.Enabled = false;
                    btnLast.Enabled = false;
                    btnFind.Enabled = false;
                    txtTitle.Focus();
                    break;



            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                myBookmark = titlesManager.Position;
                titlesManager.AddNew();
                SetState("Add");
            }
            catch (Exception)
            {
                MessageBox.Show("Error adding record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SetText();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetState("Edit");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            titlesManager.CancelCurrentEdit();
            if (myState.Equals("Add"))
            {
                titlesManager.Position = myBookmark;
            }
            SetState("View");
            SetText();
        }

        private bool ValidateData()
        {
            string message = "";
            bool allOK = true;
            return (allOK);

        }
        private void TxtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            titlesManager.Position = 0;
            SetText();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            titlesManager.Position = titlesManager.Count - 1;
            SetText();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtFind.Text.Equals(""))
            {
                return;
            }
            int savedRow = titlesManager.Position;
            DataRow[] foundRows;
            titlesTable.DefaultView.Sort = "Title";
            foundRows = titlesTable.Select("Title LIKE '" +
            txtFind.Text + "*'");
            if (foundRows.Length == 0)
            {
                titlesManager.Position = savedRow;
            }
            else
            {
                titlesManager.Position =
                titlesTable.DefaultView.Find(foundRows[0]["Title"]);
            }
            SetText();
        }
        private void SetText()
        {
            this.Text = "Titles - Record " +
            (titlesManager.Position
            + 1).ToString() + " of " +
            titlesManager.Count.ToString()
            + " Records";
        }



    }
}
