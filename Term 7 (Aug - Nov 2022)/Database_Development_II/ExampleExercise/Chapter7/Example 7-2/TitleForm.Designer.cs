namespace Example_6_9
{
  partial class frmTitles
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTitles));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.hlpBooks = new System.Windows.Forms.HelpProvider();
            this.btnHelp = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.grpFindTitle = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboPublisher = new System.Windows.Forms.ComboBox();
            this.btnPublishers = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cboAuthor1 = new System.Windows.Forms.ComboBox();
            this.cboAuthor2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboAuthor3 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboAuthor4 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnXAuthor1 = new System.Windows.Forms.Button();
            this.btnXAuthor2 = new System.Windows.Forms.Button();
            this.btnXAuthor3 = new System.Windows.Forms.Button();
            this.btnXAuthor4 = new System.Windows.Forms.Button();
            this.btnAuthors = new System.Windows.Forms.Button();
            this.txtISBN = new System.Windows.Forms.MaskedTextBox();
            this.btnPrintRecord = new System.Windows.Forms.Button();
            this.picBooks = new System.Windows.Forms.PictureBox();
            this.btnPrintTitles = new System.Windows.Forms.Button();
            this.dlgPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.grpFindTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(97, 16);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(353, 20);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.White;
            this.txtYear.Location = new System.Drawing.Point(97, 42);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(105, 20);
            this.txtYear.TabIndex = 1;
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Year Published";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ISBN";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(233, 253);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Text = "< Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(314, 253);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 7;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(232, 282);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(313, 282);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(394, 282);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(232, 311);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 11;
            this.btnAddNew.TabStop = false;
            this.btnAddNew.Text = "&Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(313, 311);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(394, 311);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 13;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "D&one";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(394, 340);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 14;
            this.btnHelp.TabStop = false;
            this.btnHelp.Text = "&Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(97, 150);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(353, 20);
            this.txtDescription.TabIndex = 8;
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Description";
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.White;
            this.txtNotes.Location = new System.Drawing.Point(97, 176);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ReadOnly = true;
            this.txtNotes.Size = new System.Drawing.Size(353, 20);
            this.txtNotes.TabIndex = 9;
            this.txtNotes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Notes";
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.Color.White;
            this.txtSubject.Location = new System.Drawing.Point(97, 202);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.ReadOnly = true;
            this.txtSubject.Size = new System.Drawing.Size(353, 20);
            this.txtSubject.TabIndex = 10;
            this.txtSubject.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Subject";
            // 
            // txtComments
            // 
            this.txtComments.BackColor = System.Drawing.Color.White;
            this.txtComments.Location = new System.Drawing.Point(98, 228);
            this.txtComments.Name = "txtComments";
            this.txtComments.ReadOnly = true;
            this.txtComments.Size = new System.Drawing.Size(353, 20);
            this.txtComments.TabIndex = 11;
            this.txtComments.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Comments";
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(394, 253);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 29;
            this.btnLast.TabStop = false;
            this.btnLast.Text = "Last >|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(155, 253);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 30;
            this.btnFirst.TabStop = false;
            this.btnFirst.Text = "|< First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // grpFindTitle
            // 
            this.grpFindTitle.Controls.Add(this.btnFind);
            this.grpFindTitle.Controls.Add(this.txtFind);
            this.grpFindTitle.Controls.Add(this.label8);
            this.grpFindTitle.Location = new System.Drawing.Point(12, 254);
            this.grpFindTitle.Name = "grpFindTitle";
            this.grpFindTitle.Size = new System.Drawing.Size(111, 109);
            this.grpFindTitle.TabIndex = 31;
            this.grpFindTitle.TabStop = false;
            this.grpFindTitle.Text = "Find Title";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(19, 71);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(72, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.TabStop = false;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(19, 45);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(72, 20);
            this.txtFind.TabIndex = 1;
            this.txtFind.TabStop = false;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 36);
            this.label8.TabIndex = 0;
            this.label8.Text = "Type first few letters of Title";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Publisher";
            // 
            // cboPublisher
            // 
            this.cboPublisher.BackColor = System.Drawing.Color.White;
            this.cboPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPublisher.FormattingEnabled = true;
            this.cboPublisher.Location = new System.Drawing.Point(98, 123);
            this.cboPublisher.Name = "cboPublisher";
            this.cboPublisher.Size = new System.Drawing.Size(353, 21);
            this.cboPublisher.TabIndex = 7;
            this.cboPublisher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboPublisher_KeyPress);
            // 
            // btnPublishers
            // 
            this.btnPublishers.Location = new System.Drawing.Point(314, 340);
            this.btnPublishers.Name = "btnPublishers";
            this.btnPublishers.Size = new System.Drawing.Size(75, 23);
            this.btnPublishers.TabIndex = 34;
            this.btnPublishers.TabStop = false;
            this.btnPublishers.Text = "&Publishers";
            this.btnPublishers.UseVisualStyleBackColor = true;
            this.btnPublishers.Click += new System.EventHandler(this.btnPublishers_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Author 1";
            // 
            // cboAuthor1
            // 
            this.cboAuthor1.BackColor = System.Drawing.Color.White;
            this.cboAuthor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthor1.FormattingEnabled = true;
            this.cboAuthor1.Location = new System.Drawing.Point(67, 69);
            this.cboAuthor1.Name = "cboAuthor1";
            this.cboAuthor1.Size = new System.Drawing.Size(135, 21);
            this.cboAuthor1.TabIndex = 3;
            this.cboAuthor1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboAuthor_KeyPress);
            // 
            // cboAuthor2
            // 
            this.cboAuthor2.BackColor = System.Drawing.Color.White;
            this.cboAuthor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthor2.FormattingEnabled = true;
            this.cboAuthor2.Location = new System.Drawing.Point(67, 96);
            this.cboAuthor2.Name = "cboAuthor2";
            this.cboAuthor2.Size = new System.Drawing.Size(135, 21);
            this.cboAuthor2.TabIndex = 4;
            this.cboAuthor2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboAuthor_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Author 2";
            // 
            // cboAuthor3
            // 
            this.cboAuthor3.BackColor = System.Drawing.Color.White;
            this.cboAuthor3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthor3.FormattingEnabled = true;
            this.cboAuthor3.Location = new System.Drawing.Point(294, 69);
            this.cboAuthor3.Name = "cboAuthor3";
            this.cboAuthor3.Size = new System.Drawing.Size(135, 21);
            this.cboAuthor3.TabIndex = 5;
            this.cboAuthor3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboAuthor_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(241, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Author 3";
            // 
            // cboAuthor4
            // 
            this.cboAuthor4.BackColor = System.Drawing.Color.White;
            this.cboAuthor4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthor4.FormattingEnabled = true;
            this.cboAuthor4.Location = new System.Drawing.Point(294, 96);
            this.cboAuthor4.Name = "cboAuthor4";
            this.cboAuthor4.Size = new System.Drawing.Size(135, 21);
            this.cboAuthor4.TabIndex = 6;
            this.cboAuthor4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboAuthor_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(241, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Author 4";
            // 
            // btnXAuthor1
            // 
            this.btnXAuthor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXAuthor1.Location = new System.Drawing.Point(204, 69);
            this.btnXAuthor1.Name = "btnXAuthor1";
            this.btnXAuthor1.Size = new System.Drawing.Size(21, 21);
            this.btnXAuthor1.TabIndex = 43;
            this.btnXAuthor1.TabStop = false;
            this.btnXAuthor1.Text = "X";
            this.btnXAuthor1.UseVisualStyleBackColor = true;
            this.btnXAuthor1.Click += new System.EventHandler(this.btnXAuthor_Click);
            // 
            // btnXAuthor2
            // 
            this.btnXAuthor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXAuthor2.Location = new System.Drawing.Point(204, 95);
            this.btnXAuthor2.Name = "btnXAuthor2";
            this.btnXAuthor2.Size = new System.Drawing.Size(21, 21);
            this.btnXAuthor2.TabIndex = 44;
            this.btnXAuthor2.TabStop = false;
            this.btnXAuthor2.Text = "X";
            this.btnXAuthor2.UseVisualStyleBackColor = true;
            this.btnXAuthor2.Click += new System.EventHandler(this.btnXAuthor_Click);
            // 
            // btnXAuthor3
            // 
            this.btnXAuthor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXAuthor3.Location = new System.Drawing.Point(430, 69);
            this.btnXAuthor3.Name = "btnXAuthor3";
            this.btnXAuthor3.Size = new System.Drawing.Size(21, 21);
            this.btnXAuthor3.TabIndex = 45;
            this.btnXAuthor3.TabStop = false;
            this.btnXAuthor3.Text = "X";
            this.btnXAuthor3.UseVisualStyleBackColor = true;
            this.btnXAuthor3.Click += new System.EventHandler(this.btnXAuthor_Click);
            // 
            // btnXAuthor4
            // 
            this.btnXAuthor4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXAuthor4.Location = new System.Drawing.Point(430, 96);
            this.btnXAuthor4.Name = "btnXAuthor4";
            this.btnXAuthor4.Size = new System.Drawing.Size(21, 21);
            this.btnXAuthor4.TabIndex = 46;
            this.btnXAuthor4.TabStop = false;
            this.btnXAuthor4.Text = "X";
            this.btnXAuthor4.UseVisualStyleBackColor = true;
            this.btnXAuthor4.Click += new System.EventHandler(this.btnXAuthor_Click);
            // 
            // btnAuthors
            // 
            this.btnAuthors.Location = new System.Drawing.Point(233, 339);
            this.btnAuthors.Name = "btnAuthors";
            this.btnAuthors.Size = new System.Drawing.Size(75, 23);
            this.btnAuthors.TabIndex = 47;
            this.btnAuthors.TabStop = false;
            this.btnAuthors.Text = "A&uthors";
            this.btnAuthors.UseVisualStyleBackColor = true;
            this.btnAuthors.Click += new System.EventHandler(this.btnAuthors_Click);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(250, 42);
            this.txtISBN.Mask = ">A-AAAAAAA-A-A";
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(200, 20);
            this.txtISBN.TabIndex = 2;
            this.txtISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtISBN_KeyPress);
            // 
            // btnPrintRecord
            // 
            this.btnPrintRecord.Location = new System.Drawing.Point(314, 369);
            this.btnPrintRecord.Name = "btnPrintRecord";
            this.btnPrintRecord.Size = new System.Drawing.Size(75, 23);
            this.btnPrintRecord.TabIndex = 48;
            this.btnPrintRecord.Text = "Print &Record";
            this.btnPrintRecord.UseVisualStyleBackColor = true;
            this.btnPrintRecord.Click += new System.EventHandler(this.btnPrintRecord_Click);
            // 
            // picBooks
            // 
            this.picBooks.Image = global::Example_6_9.Properties.Resources.Books;
            this.picBooks.Location = new System.Drawing.Point(394, 369);
            this.picBooks.Name = "picBooks";
            this.picBooks.Size = new System.Drawing.Size(81, 36);
            this.picBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBooks.TabIndex = 49;
            this.picBooks.TabStop = false;
            this.picBooks.Visible = false;
            // 
            // btnPrintTitles
            // 
            this.btnPrintTitles.Location = new System.Drawing.Point(233, 368);
            this.btnPrintTitles.Name = "btnPrintTitles";
            this.btnPrintTitles.Size = new System.Drawing.Size(75, 23);
            this.btnPrintTitles.TabIndex = 50;
            this.btnPrintTitles.Text = "Print &Titles";
            this.btnPrintTitles.UseVisualStyleBackColor = true;
            this.btnPrintTitles.Click += new System.EventHandler(this.btnPrintTitles_Click);
            // 
            // dlgPreview
            // 
            this.dlgPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.dlgPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.dlgPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.dlgPreview.Enabled = true;
            this.dlgPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("dlgPreview.Icon")));
            this.dlgPreview.Name = "dlgPreview";
            this.dlgPreview.Visible = false;
            // 
            // frmTitles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 425);
            this.Controls.Add(this.btnPrintTitles);
            this.Controls.Add(this.picBooks);
            this.Controls.Add(this.btnPrintRecord);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.btnAuthors);
            this.Controls.Add(this.btnXAuthor4);
            this.Controls.Add(this.btnXAuthor3);
            this.Controls.Add(this.btnXAuthor2);
            this.Controls.Add(this.btnXAuthor1);
            this.Controls.Add(this.cboAuthor4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cboAuthor3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboAuthor2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboAuthor1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnPublishers);
            this.Controls.Add(this.cboPublisher);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grpFindTitle);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.hlpBooks.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.Name = "frmTitles";
            this.hlpBooks.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Titles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTitles_FormClosing);
            this.Load += new System.EventHandler(this.frmTitles_Load);
            this.grpFindTitle.ResumeLayout(false);
            this.grpFindTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtTitle;
    private System.Windows.Forms.TextBox txtYear;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnPrevious;
    private System.Windows.Forms.Button btnNext;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnAddNew;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnDone;
    private System.Windows.Forms.HelpProvider hlpBooks;
    private System.Windows.Forms.Button btnHelp;
    private System.Windows.Forms.TextBox txtDescription;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtNotes;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtSubject;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtComments;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button btnLast;
    private System.Windows.Forms.Button btnFirst;
    private System.Windows.Forms.GroupBox grpFindTitle;
    private System.Windows.Forms.TextBox txtFind;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Button btnFind;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.ComboBox cboPublisher;
    private System.Windows.Forms.Button btnPublishers;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.ComboBox cboAuthor1;
    private System.Windows.Forms.ComboBox cboAuthor2;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.ComboBox cboAuthor3;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.ComboBox cboAuthor4;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Button btnXAuthor1;
    private System.Windows.Forms.Button btnXAuthor2;
    private System.Windows.Forms.Button btnXAuthor3;
    private System.Windows.Forms.Button btnXAuthor4;
    private System.Windows.Forms.Button btnAuthors;
    private System.Windows.Forms.MaskedTextBox txtISBN;
        private System.Windows.Forms.Button btnPrintRecord;
        private System.Windows.Forms.PictureBox picBooks;
        private System.Windows.Forms.Button btnPrintTitles;
        private System.Windows.Forms.PrintPreviewDialog dlgPreview;
    }
}

