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

namespace Chapter7
{
    public partial class frmPhoneDB : Form
    {
        public frmPhoneDB()
        {
            InitializeComponent();
        }

        SqlConnection phoneConnection;
        SqlCommand phoneCommand;
        SqlDataAdapter phoneAdapter;
        DataTable phoneTable;
        CurrencyManager phoneManager;
        string myState;
        int myBookmark;


        private void frmPhoneDB_Load(object sender, EventArgs e)
        {

            phoneConnection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDBFilename=c:\\Database\\SQLPhoneDB.mdf;Integrated Security=True; Connect Timeout=30; User Instance=True");
            phoneConnection.Open();

            phoneCommand = new SqlCommand("Select * from phoneTable ORDER BY ContactName", phoneConnection);

            phoneAdapter = new SqlDataAdapter();
            phoneAdapter.SelectCommand = phoneCommand;
            phoneTable = new DataTable();
            phoneAdapter.Fill(phoneTable);

            txtID.DataBindings.Add("Text", phoneTable, "ContactID");
            txtName.DataBindings.Add("Text", phoneTable, "ContactName");
            txtNumber.DataBindings.Add("Text", phoneTable, "ContactNumber");

            phoneManager = (CurrencyManager)this.BindingContext[phoneTable];
            SetState("View");
        }

        private void frmPhoneDB_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

                SqlCommandBuilder phoneAdapterCommands = new SqlCommandBuilder(phoneAdapter);
                phoneAdapter.Update(phoneTable);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error saving database to file:\r\n" + ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            phoneConnection.Close();
            phoneConnection.Dispose();
            phoneCommand.Dispose();
            phoneAdapter.Dispose();
            phoneTable.Dispose();
        }


        private void btnFirst_Click(object sender, EventArgs e)
        {
            phoneManager.Position = 0;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            phoneManager.Position--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            phoneManager.Position++;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            phoneManager.Position = phoneManager.Count - 1;
        }

        private void SetState(string appState)
        {
            myState = appState;
            switch (appState)
            {
                case "View":
                    btnFirst.Enabled = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                    btnEdit.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    txtID.BackColor = Color.White;
                    txtID.ForeColor = Color.Black;
                    txtName.ReadOnly = true;
                    txtNumber.ReadOnly = true;
                    break;
                default: // "Edit" mode, "Add" mode
                    btnFirst.Enabled = false;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnAdd.Enabled = false;
                    btnDelete.Enabled = false;
                    txtID.BackColor = Color.Red;
                    txtID.ForeColor = Color.White;
                    txtName.ReadOnly = false;
                    txtNumber.ReadOnly = false;
                    break;

            }
            txtName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetState("Edit");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            phoneManager.EndCurrentEdit();
            phoneTable.DefaultView.Sort = "ContactName";
            SetState("View");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            phoneManager.CancelCurrentEdit();
            if (myState.Equals("Add"))
            {
                phoneManager.Position = myBookmark;
            }
            SetState("View");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            myBookmark = phoneManager.Position;
            SetState("Add");
            phoneManager.AddNew();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this record?","Delete Record",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                phoneManager.RemoveAt(phoneManager.Position);
            }
            SetState("View");
        }
    }



}

