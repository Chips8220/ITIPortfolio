using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace Example_6_9
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
        SqlCommand publishersCommand;
        SqlDataAdapter publishersAdapter;
        DataTable publishersTable;
        ComboBox[] authorsCombo = new ComboBox[4];
        SqlCommand authorsCommand;
        SqlDataAdapter authorsAdapter;
        DataTable[] authorsTable = new DataTable[4];
        SqlCommand ISBNAuthorsCommand;
        SqlDataAdapter ISBNAuthorsAdapter;
        DataTable ISBNAuthorsTable;

        string myState;
        int myBookmark;

        private void frmTitles_Load(object sender, EventArgs e)
        {
            try
            {
                // point to help file
                hlpBooks.HelpNamespace = Application.StartupPath + "\\books.chm";
                // connect to books database
                booksConnection = new SqlConnection("Data Source=.\\SQLEXPRESS; AttachDbFilename=C:\\Database\\SQLBooksDB.mdf; Integrated Security=True; Connect Timeout=30; User Instance=True;");
                booksConnection.Open();
                // establish command object
                titlesCommand = new SqlCommand("SELECT * FROM Titles ORDER BY Title", booksConnection);
                // establish data adapter/data table
                titlesAdapter = new SqlDataAdapter();
                titlesAdapter.SelectCommand = titlesCommand;
                titlesTable = new DataTable();
                titlesAdapter.Fill(titlesTable);
                // bind controls to data table
                txtTitle.DataBindings.Add("Text", titlesTable, "Title");
                txtYear.DataBindings.Add("Text", titlesTable, "Year_Published");
                txtISBN.DataBindings.Add("Text", titlesTable, "ISBN");
                txtDescription.DataBindings.Add("Text", titlesTable, "Description");
                txtNotes.DataBindings.Add("Text", titlesTable, "Notes");
                txtSubject.DataBindings.Add("Text", titlesTable, "Subject");
                txtComments.DataBindings.Add("Text", titlesTable, "Comments");
                // establish currency manager
                titlesManager = (CurrencyManager)this.BindingContext[titlesTable];
                // establish publisher table/combo box to pick publisher
                publishersCommand = new SqlCommand("Select * from Publishers ORDER BY Name", booksConnection);
                publishersAdapter = new SqlDataAdapter();
                publishersAdapter.SelectCommand = publishersCommand;
                publishersTable = new DataTable();
                publishersAdapter.Fill(publishersTable);
                cboPublisher.DataSource = publishersTable;
                cboPublisher.DisplayMember = "Name";
                cboPublisher.ValueMember = "PubID";
                cboPublisher.DataBindings.Add("SelectedValue", titlesTable, "PubID");
                // set up combo box array
                authorsCombo[0] = cboAuthor1;
                authorsCombo[1] = cboAuthor2;
                authorsCombo[2] = cboAuthor3;
                authorsCombo[3] = cboAuthor4;
                authorsCommand = new SqlCommand("Select * from Authors ORDER BY Author", booksConnection);
                authorsAdapter = new SqlDataAdapter();
                authorsAdapter.SelectCommand = authorsCommand;
                for (int i = 0; i < 4; i++)
                {
                    // establish author table/combo boxes to pick author
                    authorsTable[i] = new DataTable();
                    authorsAdapter.Fill(authorsTable[i]);
                    authorsCombo[i].DataSource = authorsTable[i]; ;
                    authorsCombo[i].DisplayMember = "Author";
                    authorsCombo[i].ValueMember = "Au_ID";
                    // set all to no selection
                    authorsCombo[i].SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error establishing Titles table.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Show();
            SetState("View");
            SetText();
            GetAuthors();
        }

        private void frmTitles_FormClosing(object sender, FormClosingEventArgs e)
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
                    // save changes to database
                    SqlCommandBuilder titlesAdapterCommands = new SqlCommandBuilder(titlesAdapter);
                    titlesAdapter.Update(titlesTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving database to file: \r\n" + ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // close the connection
                booksConnection.Close();
                // dispose of the objects
                booksConnection.Dispose();
                titlesCommand.Dispose();
                titlesAdapter.Dispose();
                titlesTable.Dispose();
                publishersCommand.Dispose();
                publishersAdapter.Dispose();
                publishersTable.Dispose();
                authorsCommand.Dispose();
                authorsAdapter.Dispose();
                authorsTable[0].Dispose();
                authorsTable[1].Dispose();
                authorsTable[2].Dispose();
                authorsTable[3].Dispose();
                ISBNAuthorsCommand.Dispose();
                ISBNAuthorsAdapter.Dispose();
                ISBNAuthorsTable.Dispose();
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
            GetAuthors();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (titlesManager.Position == titlesManager.Count - 1)
            {
                Console.Beep();
            }
            titlesManager.Position++;
            SetText();
            GetAuthors();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }
            string savedName = txtTitle.Text;
            int savedRow;
            try
            {
                titlesManager.EndCurrentEdit();
                SqlCommandBuilder ISBNCommandUpdate = new SqlCommandBuilder(ISBNAuthorsAdapter);
                // delete all rows of data table then repopulate
                if (ISBNAuthorsTable.Rows.Count != 0)
                {
                    for (int i = 0; i < ISBNAuthorsTable.Rows.Count; i++)
                    {
                        ISBNAuthorsTable.Rows[i].Delete();
                    }
                    ISBNAuthorsAdapter.Update(ISBNAuthorsTable);
                }
                for (int i = 0; i < 4; i++)
                {
                    if (authorsCombo[i].SelectedIndex != -1)
                    {
                        ISBNAuthorsTable.Rows.Add();
                        ISBNAuthorsTable.Rows[ISBNAuthorsTable.Rows.Count - 1]["ISBN"] = txtISBN.Text;
                        ISBNAuthorsTable.Rows[ISBNAuthorsTable.Rows.Count - 1]["Au_ID"] = authorsCombo[i].SelectedValue;
                    }
                }
                ISBNAuthorsAdapter.Update(ISBNAuthorsTable);

                titlesTable.DefaultView.Sort = "Title";
                savedRow = titlesTable.DefaultView.Find(savedName);
                titlesManager.Position = savedRow;
                MessageBox.Show("Record saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetState("View");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SetText();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult response;
            response = MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (response == DialogResult.No)
            {
                return;
            }
            try
            {
                titlesManager.RemoveAt(titlesManager.Position);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SetText();
            GetAuthors();
        }

        private void SetState(string appState)
        {
            myState = appState;
            switch (appState)
            {
                case "View":
                    txtTitle.ReadOnly = true;
                    txtYear.ReadOnly = true;
                    txtISBN.ReadOnly = true;
                    txtISBN.BackColor = Color.White;
                    txtISBN.ForeColor = Color.Black;
                    cboAuthor1.Enabled = false;
                    cboAuthor2.Enabled = false;
                    cboAuthor3.Enabled = false;
                    cboAuthor4.Enabled = false;
                    cboPublisher.Enabled = false;
                    btnXAuthor1.Enabled = false;
                    btnXAuthor2.Enabled = false;
                    btnXAuthor3.Enabled = false;
                    btnXAuthor4.Enabled = false;
                    txtDescription.ReadOnly = true;
                    txtNotes.ReadOnly = true;
                    txtSubject.ReadOnly = true;
                    txtComments.ReadOnly = true;
                    btnFirst.Enabled = true;
                    btnPrevious.Enabled = true;
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                    btnAddNew.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnDone.Enabled = true;
                    grpFindTitle.Enabled = true;
                    txtTitle.Focus();
                    break;
                default: // Add or Edit if not View
                    txtTitle.ReadOnly = false;
                    txtYear.ReadOnly = false;
                    txtISBN.ReadOnly = false;
                    if (myState.Equals("Edit"))
                    {
                        txtISBN.BackColor = Color.Red;
                        txtISBN.ForeColor = Color.White;
                        txtISBN.ReadOnly = true;
                        txtISBN.TabStop = false;
                    }
                    else
                    {
                        txtISBN.TabStop = true;
                    }
                    cboAuthor1.Enabled = true;
                    cboAuthor2.Enabled = true;
                    cboAuthor3.Enabled = true;
                    cboAuthor4.Enabled = true;
                    btnXAuthor1.Enabled = true;
                    btnXAuthor2.Enabled = true;
                    btnXAuthor3.Enabled = true;
                    btnXAuthor4.Enabled = true;
                    cboPublisher.Enabled = true;
                    txtDescription.ReadOnly = false;
                    txtNotes.ReadOnly = false;
                    txtSubject.ReadOnly = false;
                    txtComments.ReadOnly = false;
                    btnFirst.Enabled = false;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;
                    btnAddNew.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnDone.Enabled = false;
                    grpFindTitle.Enabled = false;
                    txtTitle.Focus();
                    break;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            cboAuthor1.SelectedIndex = -1;
            cboAuthor2.SelectedIndex = -1;
            cboAuthor3.SelectedIndex = -1;
            cboAuthor4.SelectedIndex = -1;
            try
            {
                myBookmark = titlesManager.Position;
                titlesManager.AddNew();
                SetState("Add");
            }
            catch (Exception ex)
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
            GetAuthors();
        }

        private bool ValidateData()
        {
            string message = "";
            bool allOK = true;
            if (txtTitle.Text.Equals(""))
            {
                message = "You must input a Title.\r\n";
                txtTitle.Focus();
                allOK = false;
            }
            int inputYear, currentYear;
            // Check length and range on Year Published
            if (!txtYear.Text.Trim().Equals(""))
            {
                inputYear = Convert.ToInt32(txtYear.Text);
                currentYear = DateTime.Now.Year;
                if (inputYear > currentYear || inputYear < currentYear - 150)
                {
                    message += "Year published must be between " + (currentYear - 150).ToString() + " and " + currentYear.ToString() + "\r\n";
                    txtYear.Focus();
                    allOK = false;
                }
            }
            if (!(txtISBN.Text.Length == 13))
            {
                message += "Incomplete ISBN entry.\r\n";
                txtISBN.Focus();
                allOK = false;
            }
            if (cboPublisher.Text.Equals(""))
            {
                message += "You must select a Publisher.";
                cboPublisher.Focus();
                allOK = false;
            }
            if (!allOK)
            {
                MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return (allOK);
        }


        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpBooks.HelpNamespace);
        }


        private void btnFirst_Click(object sender, EventArgs e)
        {
            titlesManager.Position = 0;
            SetText();
            GetAuthors();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            titlesManager.Position = titlesManager.Count - 1;
            SetText();
            GetAuthors();
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
            foundRows = titlesTable.Select("Title LIKE '" + txtFind.Text + "*'");
            if (foundRows.Length == 0)
            {
                titlesManager.Position = savedRow;
            }
            else
            {
                titlesManager.Position = titlesTable.DefaultView.Find(foundRows[0]["Title"]);
            }
            SetText();
            GetAuthors();
        }

        private void SetText()
        {
            this.Text = "Titles - Record " + (titlesManager.Position + 1).ToString() + " of " + titlesManager.Count.ToString() + " Records";
        }

        private void btnPublishers_Click(object sender, EventArgs e)
        {
            frmPublishers pubForm = new frmPublishers();
            string pubSave = cboPublisher.Text;
            pubForm.ShowDialog();
            pubForm.Dispose();
            // need to regenerate publishers data
            booksConnection.Close();
            booksConnection = new SqlConnection("Data Source=.\\SQLEXPRESS; AttachDbFilename=C:\\Database\\SQLBooksDB.mdf; Integrated Security=True; Connect Timeout=30; User Instance=True");
            booksConnection.Open();
            publishersAdapter.SelectCommand = publishersCommand;
            publishersTable = new DataTable();
            publishersAdapter.Fill(publishersTable);
            cboPublisher.DataSource = publishersTable;
            cboPublisher.Text = pubSave;
        }

        private void btnXAuthor_Click(object sender, EventArgs e)
        {
            Button whichButton = (Button)sender;
            switch (whichButton.Name)
            {
                case "btnXAuthor1":
                    cboAuthor1.SelectedIndex = -1;
                    break;
                case "btnXAuthor2":
                    cboAuthor2.SelectedIndex = -1;
                    break;
                case "btnXAuthor3":
                    cboAuthor3.SelectedIndex = -1;
                    break;
                case "btnXAuthor4":
                    cboAuthor4.SelectedIndex = -1;
                    break;
            }
        }

        private void GetAuthors()
        {
            string SQLStatement = "SELECT Title_Author.* FROM Title_Author WHERE Title_Author.ISBN = '" + txtISBN.Text + "'";
            for (int i = 0; i < 4; i++)
            {
                authorsCombo[i].SelectedIndex = -1;
            }
            // establish author table/combo boxes to pick author
            ISBNAuthorsCommand = new SqlCommand(SQLStatement, booksConnection);
            ISBNAuthorsAdapter = new SqlDataAdapter();
            ISBNAuthorsAdapter.SelectCommand = ISBNAuthorsCommand;
            ISBNAuthorsTable = new DataTable();
            ISBNAuthorsAdapter.Fill(ISBNAuthorsTable);
            if (ISBNAuthorsTable.Rows.Count == 0)
            {
                return;
            }
            for (int i = 0; i < ISBNAuthorsTable.Rows.Count; i++)
            {
                authorsCombo[i].SelectedValue = ISBNAuthorsTable.Rows[i]["Au_ID"].ToString();
            }
        }

        private void btnAuthors_Click(object sender, EventArgs e)
        {
            frmAuthors authorsForm = new frmAuthors();
            string[] authorsSave = new string[4];
            authorsSave[0] = authorsCombo[0].Text;
            authorsSave[1] = authorsCombo[1].Text;
            authorsSave[2] = authorsCombo[2].Text;
            authorsSave[3] = authorsCombo[3].Text;
            authorsForm.ShowDialog();
            authorsForm.Dispose();
            // need to regenerate authors data
            booksConnection.Close();
            booksConnection = new SqlConnection("Data Source=.\\SQLEXPRESS; AttachDbFilename=C:\\Database\\SQLBooksDB.mdf; Integrated Security=True; Connect Timeout=30; User Instance=True");
            booksConnection.Open();
            authorsAdapter.SelectCommand = authorsCommand;
            for (int i = 0; i < 4; i++)
            {
                authorsTable[i] = new DataTable();
                authorsAdapter.Fill(authorsTable[i]);
                authorsCombo[i].DataSource = authorsTable[i];
                if (!authorsSave[i].Equals(""))
                {
                    authorsCombo[i].Text = authorsSave[i];
                }
                else
                {
                    authorsCombo[i].SelectedIndex = -1;
                }
            }
        }

        private void cboPublisher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
            {
                txtDescription.Focus();
            }
        }

        private void cboAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComboBox whichComboBox = (ComboBox)sender;
            switch (whichComboBox.Name)
            {
                case "cboAuthor1":
                    cboAuthor2.Focus();
                    break;
                case "cboAuthor2":
                    cboAuthor3.Focus();
                    break;
                case "cboAuthor3":
                    cboAuthor4.Focus();
                    break;
                case "cboAuthor4":
                    cboPublisher.Focus();
                    break;
            }
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox whichTextBox = (TextBox)sender;
            if ((int)e.KeyChar == 13)
            {
                switch (whichTextBox.Name)
                {
                    case "txtTitle":
                        txtYear.Focus();
                        break;
                    case "txtYear":
                        if (myState.Equals("Add"))
                        {
                            txtISBN.Focus();
                        }
                        else
                        {
                            cboAuthor1.Focus();
                        }
                        break;
                    case "txtISBN":
                        cboAuthor1.Focus();
                        break;
                    case "txtDescription":
                        txtNotes.Focus();
                        break;
                    case "txtNotes":
                        txtSubject.Focus();
                        break;
                    case "txtSubject":
                        txtComments.Focus();
                        break;
                    case "txtComments":
                        txtTitle.Focus();
                        break;
                }
            }
            if (whichTextBox.Name.Equals("txtYear"))
            {
                if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (int)e.KeyChar == 8)
                {
                    e.Handled = false;
                }
                else
                {
                    Console.Beep();
                    e.Handled = true;
                }
            }

        }

        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
            {
                cboAuthor1.Focus();
            }
        }

        private void btnPrintRecord_Click(object sender, EventArgs e)
        {
            // Declare the Document
            PrintDocument recordDocument;
            //Create the document and name it
            recordDocument = new PrintDocument();
            recordDocument.DocumentName = "Titles Record";
            // Add code handler
            recordDocument.PrintPage += new
 PrintPageEventHandler(this.PrintRecordPage);
            // Print document
            recordDocument.Print();
            // DIspose of document when done printing
            recordDocument.Dispose();

        }
        private void PrintRecordPage(object sender, PrintPageEventArgs e)
        {
            //print graphic and heading (1 inch in height)
            Pen myPen = new Pen(Color.Black, 3);
            e.Graphics.DrawRectangle(myPen, e.MarginBounds.Left + 10, e.MarginBounds.Top + 10, 80, 80);
            // print heading
            String s = "BOOKS DATABASE";
            Font myFont = new Font("Arial", 24, FontStyle.Bold);
            SizeF sSize = e.Graphics.MeasureString(s, myFont);
            e.Graphics.DrawString(s, myFont, Brushes.Black, e.MarginBounds.Left + 100 + Convert.ToInt32(0.5 * (e.MarginBounds.Width - 100 - sSize.Width)), e.MarginBounds.Top + Convert.ToInt32(0.5 * (100 - sSize.Height)));
            myFont = new Font("Arial", 12, FontStyle.Regular);
            int y = 300;
            int dy = Convert.ToInt32(e.Graphics.MeasureString("S", myFont).Height);
            //print Title
            e.Graphics.DrawString("Title: " + txtTitle.Text, myFont, Brushes.Black, e.MarginBounds.Left, y);
            // print authors
            y += 2 * dy;
            e.Graphics.DrawString("Author(s): ", myFont, Brushes.Black, e.MarginBounds.Left, y);
            int x = e.MarginBounds.Left + Convert.ToInt32(e.Graphics.MeasureString("Authors(s): ", myFont).Width);
            if (ISBNAuthorsTable.Rows.Count != 0)
            {
                for (int i = 0; i < ISBNAuthorsTable.Rows.Count; i++)
                {
                    e.Graphics.DrawString(authorsCombo[i].Text, myFont, Brushes.Black, x, y);
                    y += dy;
                }
            }
            else
            {
                e.Graphics.DrawString("None", myFont, Brushes.Black, x, y);
                y += dy;
            }
            x = e.MarginBounds.Left;
            y += dy;
            // Print other fields
            e.Graphics.DrawString("ISBN: " + txtISBN.Text, myFont, Brushes.Black, x, y);
            y += 2 * dy;
            e.Graphics.DrawString("Year Published: " + txtYear.Text, myFont, Brushes.Black, x, y);
            y += 2 * dy;
            e.Graphics.DrawString("Publisher: " + cboPublisher.Text, myFont, Brushes.Black, x, y);
            y += 2 * dy;
            e.Graphics.DrawString("Description: " + txtDescription.Text, myFont, Brushes.Black, x, y);
            y += 2 * dy; 
            e.Graphics.DrawString("Notes: " + txtNotes.Text, myFont, Brushes.Black, x, y);
            y += 2 * dy; 
            e.Graphics.DrawString("Subject: " + txtSubject.Text, myFont, Brushes.Black, x, y);
            y += 2 * dy; 
            e.Graphics.DrawString("Comments: " + txtComments.Text, myFont, Brushes.Black, x, y);
            e.HasMorePages = false;





        }
    }
}