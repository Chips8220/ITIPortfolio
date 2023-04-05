namespace Example_6_9
{
  partial class frmPublishers
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPubID = new System.Windows.Forms.TextBox();
            this.txtPubName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.hlpPublishers = new System.Windows.Forms.HelpProvider();
            this.btnHelp = new System.Windows.Forms.Button();
            this.txtPubAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPubCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPubState = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPubZip = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPubTelephone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPubFAX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPubComments = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.grpFindPublisher = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.grpFindPublisher.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Publisher ID";
            // 
            // txtPubID
            // 
            this.txtPubID.BackColor = System.Drawing.Color.White;
            this.txtPubID.Location = new System.Drawing.Point(97, 16);
            this.txtPubID.Name = "txtPubID";
            this.txtPubID.ReadOnly = true;
            this.txtPubID.Size = new System.Drawing.Size(100, 20);
            this.txtPubID.TabIndex = 0;
            this.txtPubID.TabStop = false;
            // 
            // txtPubName
            // 
            this.txtPubName.BackColor = System.Drawing.Color.White;
            this.txtPubName.Location = new System.Drawing.Point(97, 42);
            this.txtPubName.Name = "txtPubName";
            this.txtPubName.ReadOnly = true;
            this.txtPubName.Size = new System.Drawing.Size(236, 20);
            this.txtPubName.TabIndex = 1;
            this.txtPubName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BackColor = System.Drawing.Color.White;
            this.txtCompanyName.Location = new System.Drawing.Point(97, 68);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.ReadOnly = true;
            this.txtCompanyName.Size = new System.Drawing.Size(236, 20);
            this.txtCompanyName.TabIndex = 2;
            this.txtCompanyName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Company Name";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(97, 276);
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
            this.btnNext.Location = new System.Drawing.Point(178, 276);
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
            this.btnEdit.Location = new System.Drawing.Point(62, 305);
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
            this.btnSave.Location = new System.Drawing.Point(143, 305);
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
            this.btnCancel.Location = new System.Drawing.Point(224, 305);
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
            this.btnAddNew.Location = new System.Drawing.Point(62, 334);
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
            this.btnDelete.Location = new System.Drawing.Point(143, 334);
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
            this.btnDone.Location = new System.Drawing.Point(224, 334);
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
            this.btnHelp.Location = new System.Drawing.Point(224, 363);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 14;
            this.btnHelp.TabStop = false;
            this.btnHelp.Text = "&Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // txtPubAddress
            // 
            this.txtPubAddress.BackColor = System.Drawing.Color.White;
            this.txtPubAddress.Location = new System.Drawing.Point(97, 94);
            this.txtPubAddress.Name = "txtPubAddress";
            this.txtPubAddress.ReadOnly = true;
            this.txtPubAddress.Size = new System.Drawing.Size(236, 20);
            this.txtPubAddress.TabIndex = 3;
            this.txtPubAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Address";
            // 
            // txtPubCity
            // 
            this.txtPubCity.BackColor = System.Drawing.Color.White;
            this.txtPubCity.Location = new System.Drawing.Point(97, 120);
            this.txtPubCity.Name = "txtPubCity";
            this.txtPubCity.ReadOnly = true;
            this.txtPubCity.Size = new System.Drawing.Size(236, 20);
            this.txtPubCity.TabIndex = 4;
            this.txtPubCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "City";
            // 
            // txtPubState
            // 
            this.txtPubState.BackColor = System.Drawing.Color.White;
            this.txtPubState.Location = new System.Drawing.Point(97, 146);
            this.txtPubState.Name = "txtPubState";
            this.txtPubState.ReadOnly = true;
            this.txtPubState.Size = new System.Drawing.Size(132, 20);
            this.txtPubState.TabIndex = 5;
            this.txtPubState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "State";
            // 
            // txtPubZip
            // 
            this.txtPubZip.BackColor = System.Drawing.Color.White;
            this.txtPubZip.Location = new System.Drawing.Point(97, 172);
            this.txtPubZip.Name = "txtPubZip";
            this.txtPubZip.ReadOnly = true;
            this.txtPubZip.Size = new System.Drawing.Size(132, 20);
            this.txtPubZip.TabIndex = 6;
            this.txtPubZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Zip";
            // 
            // txtPubTelephone
            // 
            this.txtPubTelephone.BackColor = System.Drawing.Color.White;
            this.txtPubTelephone.Location = new System.Drawing.Point(97, 198);
            this.txtPubTelephone.Name = "txtPubTelephone";
            this.txtPubTelephone.ReadOnly = true;
            this.txtPubTelephone.Size = new System.Drawing.Size(132, 20);
            this.txtPubTelephone.TabIndex = 7;
            this.txtPubTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Telephone";
            // 
            // txtPubFAX
            // 
            this.txtPubFAX.BackColor = System.Drawing.Color.White;
            this.txtPubFAX.Location = new System.Drawing.Point(97, 224);
            this.txtPubFAX.Name = "txtPubFAX";
            this.txtPubFAX.ReadOnly = true;
            this.txtPubFAX.Size = new System.Drawing.Size(132, 20);
            this.txtPubFAX.TabIndex = 8;
            this.txtPubFAX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "FAX";
            // 
            // txtPubComments
            // 
            this.txtPubComments.BackColor = System.Drawing.Color.White;
            this.txtPubComments.Location = new System.Drawing.Point(97, 250);
            this.txtPubComments.Name = "txtPubComments";
            this.txtPubComments.ReadOnly = true;
            this.txtPubComments.Size = new System.Drawing.Size(236, 20);
            this.txtPubComments.TabIndex = 9;
            this.txtPubComments.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Comments";
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(258, 276);
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
            this.btnFirst.Location = new System.Drawing.Point(19, 276);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 30;
            this.btnFirst.TabStop = false;
            this.btnFirst.Text = "|< First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // grpFindPublisher
            // 
            this.grpFindPublisher.Controls.Add(this.btnFind);
            this.grpFindPublisher.Controls.Add(this.txtFind);
            this.grpFindPublisher.Controls.Add(this.label11);
            this.grpFindPublisher.Location = new System.Drawing.Point(14, 368);
            this.grpFindPublisher.Name = "grpFindPublisher";
            this.grpFindPublisher.Size = new System.Drawing.Size(200, 79);
            this.grpFindPublisher.TabIndex = 31;
            this.grpFindPublisher.TabStop = false;
            this.grpFindPublisher.Text = "Find Publisher";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(112, 45);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.TabStop = false;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(112, 19);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(75, 20);
            this.txtFind.TabIndex = 1;
            this.txtFind.TabStop = false;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 39);
            this.label11.TabIndex = 0;
            this.label11.Text = "Type first few letters of Publisher Name";
            // 
            // frmPublishers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 459);
            this.Controls.Add(this.grpFindPublisher);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.txtPubComments);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPubFAX);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPubTelephone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPubZip);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPubState);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPubCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPubAddress);
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
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPubName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPubID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.hlpPublishers.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.Name = "frmPublishers";
            this.hlpPublishers.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publishers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPublishers_FormClosing);
            this.Load += new System.EventHandler(this.frmPublishers_Load);
            this.grpFindPublisher.ResumeLayout(false);
            this.grpFindPublisher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtPubID;
    private System.Windows.Forms.TextBox txtPubName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtCompanyName;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnPrevious;
    private System.Windows.Forms.Button btnNext;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnAddNew;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnDone;
    private System.Windows.Forms.HelpProvider hlpPublishers;
    private System.Windows.Forms.Button btnHelp;
    private System.Windows.Forms.TextBox txtPubAddress;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtPubCity;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtPubState;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtPubZip;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txtPubTelephone;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox txtPubFAX;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox txtPubComments;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Button btnLast;
    private System.Windows.Forms.Button btnFirst;
    private System.Windows.Forms.GroupBox grpFindPublisher;
    private System.Windows.Forms.Button btnFind;
    private System.Windows.Forms.TextBox txtFind;
    private System.Windows.Forms.Label label11;
  }
}

