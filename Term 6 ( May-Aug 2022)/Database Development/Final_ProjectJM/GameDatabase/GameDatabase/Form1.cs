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

namespace GameDatabase
{
    public partial class frmGameDB : Form
    {
        SqlConnection gamedbConnection;
        SqlCommand gamedbCommand;
        SqlDataAdapter gamedbAdapter;
        DataTable gamedbTable;
        CurrencyManager gamedbManager;
        public frmGameDB()
        {
            InitializeComponent();
        }

        private void frmGameDB_Load(object sender, EventArgs e)
        {
            try
            {
                //connection to Game Database
                gamedbConnection = new SqlConnection("Data Source =.\\SQLEXPRESS; AttachDbFilename = C:\\Final_ProjectJM\\GameDbSQL\\GamedbSQL.mdf; Database=GameDbSQL; Integrated Security = True; Connect Timeout = 30");
                gamedbConnection.Open();
                //Command object/Create command
                gamedbCommand = new SqlCommand("Select * FROM Player", gamedbConnection);
                //Data Adapter and Data Table
                gamedbAdapter = new SqlDataAdapter();
                gamedbAdapter.SelectCommand = gamedbCommand;
                gamedbTable = new DataTable();
                gamedbAdapter.Fill(gamedbTable);
                //bind controls to data table
                txtPName.DataBindings.Add("Text", gamedbTable, "Player_Name");
                txtHP.DataBindings.Add("Text", gamedbTable, "Hit_Points");
                txtMP.DataBindings.Add("Text", gamedbTable, "Mana_Points");
                txtLDamage.DataBindings.Add("Text", gamedbTable, "Lower_Damage");
                txtHDamage.DataBindings.Add("Text", gamedbTable, "Higher_Damage");
                //Currency Manager
                gamedbManager = (CurrencyManager)this.BindingContext[gamedbTable];
                SetState("View");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error establishing table.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmGameDB_FormClosing(object sender, FormClosingEventArgs e)
        {
            //close the connection
            gamedbConnection.Close();
            //dispose of the objects
            gamedbConnection.Dispose();
            gamedbCommand.Dispose();
            gamedbAdapter.Dispose();
            gamedbTable.Dispose();
        }

        private void SetState(string appState)
        {
            switch (appState)
            {
                case "View":
                    txtPName.ReadOnly = true;
                    txtHP.ReadOnly = true;
                    txtMP.ReadOnly = true;
                    txtLDamage.ReadOnly = true;
                    txtHDamage.ReadOnly = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnAddNew.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnDone.Enabled = true;
                    break;

                default: //Edit if not View
                    txtPName.ReadOnly = false;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnAddNew.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnDone.Enabled = false;
                    //

                    break;
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetState("Edit");
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetState("View");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (!ValidateData())
            {
                return;
            }
            try
            {
                // save changes to program
                gamedbManager.EndCurrentEdit();
                

                SqlCommandBuilder b = new SqlCommandBuilder(gamedbAdapter);
                gamedbAdapter.UpdateCommand = b.GetUpdateCommand();
                gamedbAdapter.Update(gamedbTable);
                MessageBox.Show("Record Saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetState("View");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateData()
        {
            string message = "";
            bool allOK = true;
            // Check for name
            if (txtPName.Text.Trim().Equals(""))
            {
                message = "You must enter an Player Name." + "\r\n";
                txtPName.Focus();
                allOK = false;
            }
            if (!allOK)
            {
                MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return (allOK);

        }

        private void txtPName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txtPName.Text.Length > 20 || !Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }
    }
}


