
namespace Example5_2
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
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPubName = new System.Windows.Forms.TextBox();
            this.txtPubID = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblPubZip = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblFax = new System.Windows.Forms.Label();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtPubAddress = new System.Windows.Forms.TextBox();
            this.txtPubCity = new System.Windows.Forms.TextBox();
            this.txtPubState = new System.Windows.Forms.TextBox();
            this.txtPubZip = new System.Windows.Forms.TextBox();
            this.txtPubTelephone = new System.Windows.Forms.TextBox();
            this.txtPubFAX = new System.Windows.Forms.TextBox();
            this.txtPubComments = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Publisher ID";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(0, 29);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(35, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Company Name";
            // 
            // txtPubName
            // 
            this.txtPubName.BackColor = System.Drawing.Color.White;
            this.txtPubName.Location = new System.Drawing.Point(88, 26);
            this.txtPubName.Name = "txtPubName";
            this.txtPubName.ReadOnly = true;
            this.txtPubName.Size = new System.Drawing.Size(288, 20);
            this.txtPubName.TabIndex = 1;
            this.txtPubName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInput_KeyPress);
            // 
            // txtPubID
            // 
            this.txtPubID.BackColor = System.Drawing.Color.White;
            this.txtPubID.Location = new System.Drawing.Point(88, 0);
            this.txtPubID.Name = "txtPubID";
            this.txtPubID.ReadOnly = true;
            this.txtPubID.Size = new System.Drawing.Size(100, 20);
            this.txtPubID.TabIndex = 4;
            this.txtPubID.TabStop = false;
            this.txtPubID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInput_KeyPress);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BackColor = System.Drawing.Color.White;
            this.txtCompanyName.Location = new System.Drawing.Point(88, 52);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.ReadOnly = true;
            this.txtCompanyName.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyName.TabIndex = 2;
            this.txtCompanyName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInput_KeyPress);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(95, 307);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Text = "<= Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(201, 307);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 7;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "Next =>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(74, 336);
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
            this.btnSave.Location = new System.Drawing.Point(155, 336);
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
            this.btnCancel.Location = new System.Drawing.Point(236, 336);
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
            this.btnAddNew.Location = new System.Drawing.Point(74, 365);
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
            this.btnDelete.Location = new System.Drawing.Point(155, 365);
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
            this.btnDone.Location = new System.Drawing.Point(236, 365);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 13;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "Do&ne";
            this.btnDone.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Address";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(0, 111);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 15;
            this.lblCity.Text = "City";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(0, 137);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 16;
            this.lblState.Text = "State";
            // 
            // lblPubZip
            // 
            this.lblPubZip.AutoSize = true;
            this.lblPubZip.Location = new System.Drawing.Point(0, 167);
            this.lblPubZip.Name = "lblPubZip";
            this.lblPubZip.Size = new System.Drawing.Size(22, 13);
            this.lblPubZip.TabIndex = 17;
            this.lblPubZip.Text = "Zip";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(0, 196);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(58, 13);
            this.lblTelephone.TabIndex = 18;
            this.lblTelephone.Text = "Telephone";
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(0, 226);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(27, 13);
            this.lblFax.TabIndex = 19;
            this.lblFax.Text = "FAX";
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(0, 252);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(56, 13);
            this.lblComments.TabIndex = 20;
            this.lblComments.Text = "Comments";
            // 
            // txtPubAddress
            // 
            this.txtPubAddress.BackColor = System.Drawing.Color.White;
            this.txtPubAddress.Location = new System.Drawing.Point(88, 82);
            this.txtPubAddress.Name = "txtPubAddress";
            this.txtPubAddress.ReadOnly = true;
            this.txtPubAddress.Size = new System.Drawing.Size(100, 20);
            this.txtPubAddress.TabIndex = 3;
            this.txtPubAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInput_KeyPress);
            // 
            // txtPubCity
            // 
            this.txtPubCity.BackColor = System.Drawing.Color.White;
            this.txtPubCity.Location = new System.Drawing.Point(88, 108);
            this.txtPubCity.Name = "txtPubCity";
            this.txtPubCity.ReadOnly = true;
            this.txtPubCity.Size = new System.Drawing.Size(100, 20);
            this.txtPubCity.TabIndex = 4;
            this.txtPubCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInput_KeyPress);
            // 
            // txtPubState
            // 
            this.txtPubState.BackColor = System.Drawing.Color.White;
            this.txtPubState.Location = new System.Drawing.Point(88, 134);
            this.txtPubState.Name = "txtPubState";
            this.txtPubState.ReadOnly = true;
            this.txtPubState.Size = new System.Drawing.Size(100, 20);
            this.txtPubState.TabIndex = 5;
            this.txtPubState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInput_KeyPress);
            // 
            // txtPubZip
            // 
            this.txtPubZip.BackColor = System.Drawing.Color.White;
            this.txtPubZip.Location = new System.Drawing.Point(88, 164);
            this.txtPubZip.Name = "txtPubZip";
            this.txtPubZip.ReadOnly = true;
            this.txtPubZip.Size = new System.Drawing.Size(100, 20);
            this.txtPubZip.TabIndex = 6;
            this.txtPubZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInput_KeyPress);
            // 
            // txtPubTelephone
            // 
            this.txtPubTelephone.BackColor = System.Drawing.Color.White;
            this.txtPubTelephone.Location = new System.Drawing.Point(88, 189);
            this.txtPubTelephone.Name = "txtPubTelephone";
            this.txtPubTelephone.ReadOnly = true;
            this.txtPubTelephone.Size = new System.Drawing.Size(100, 20);
            this.txtPubTelephone.TabIndex = 7;
            this.txtPubTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInput_KeyPress);
            // 
            // txtPubFAX
            // 
            this.txtPubFAX.BackColor = System.Drawing.Color.White;
            this.txtPubFAX.Location = new System.Drawing.Point(88, 219);
            this.txtPubFAX.Name = "txtPubFAX";
            this.txtPubFAX.ReadOnly = true;
            this.txtPubFAX.Size = new System.Drawing.Size(100, 20);
            this.txtPubFAX.TabIndex = 8;
            this.txtPubFAX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInput_KeyPress);
            // 
            // txtPubComments
            // 
            this.txtPubComments.BackColor = System.Drawing.Color.White;
            this.txtPubComments.Location = new System.Drawing.Point(88, 249);
            this.txtPubComments.Name = "txtPubComments";
            this.txtPubComments.ReadOnly = true;
            this.txtPubComments.Size = new System.Drawing.Size(100, 20);
            this.txtPubComments.TabIndex = 9;
            this.txtPubComments.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInput_KeyPress);
            // 
            // frmPublishers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 433);
            this.Controls.Add(this.txtPubComments);
            this.Controls.Add(this.txtPubFAX);
            this.Controls.Add(this.txtPubTelephone);
            this.Controls.Add(this.txtPubZip);
            this.Controls.Add(this.txtPubState);
            this.Controls.Add(this.txtPubCity);
            this.Controls.Add(this.txtPubAddress);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblFax);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblPubZip);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtPubID);
            this.Controls.Add(this.txtPubName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPublishers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authors";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPublishers_FormClosing);
            this.Load += new System.EventHandler(this.frmPublishers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPubName;
        private System.Windows.Forms.TextBox txtPubID;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblPubZip;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox txtPubAddress;
        private System.Windows.Forms.TextBox txtPubCity;
        private System.Windows.Forms.TextBox txtPubState;
        private System.Windows.Forms.TextBox txtPubZip;
        private System.Windows.Forms.TextBox txtPubTelephone;
        private System.Windows.Forms.TextBox txtPubFAX;
        private System.Windows.Forms.TextBox txtPubComments;
    }
}

