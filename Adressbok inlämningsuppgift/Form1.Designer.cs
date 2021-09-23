
namespace Adressbok_inlämningsuppgift
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtnCity = new System.Windows.Forms.RadioButton();
            this.rdBtnName = new System.Windows.Forms.RadioButton();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.btnOKSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnShowContact = new System.Windows.Forms.Button();
            this.btnChangeContact = new System.Windows.Forms.Button();
            this.btnDeleteContact = new System.Windows.Forms.Button();
            this.lstBook = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChange2 = new System.Windows.Forms.Button();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPstCode = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnShowDelete = new System.Windows.Forms.Button();
            this.lblSPhone = new System.Windows.Forms.Label();
            this.lblSEmail = new System.Windows.Forms.Label();
            this.lblSCity = new System.Windows.Forms.Label();
            this.lblSPostcode = new System.Windows.Forms.Label();
            this.lblSStreet = new System.Windows.Forms.Label();
            this.lblSName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPstCode = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnCity);
            this.groupBox1.Controls.Add(this.rdBtnName);
            this.groupBox1.Controls.Add(this.btnEmpty);
            this.groupBox1.Controls.Add(this.btnOKSearch);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnShowContact);
            this.groupBox1.Controls.Add(this.btnChangeContact);
            this.groupBox1.Controls.Add(this.btnDeleteContact);
            this.groupBox1.Controls.Add(this.lstBook);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(405, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(228, 414);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adresslista";
            // 
            // rdBtnCity
            // 
            this.rdBtnCity.AutoSize = true;
            this.rdBtnCity.Location = new System.Drawing.Point(81, 64);
            this.rdBtnCity.Name = "rdBtnCity";
            this.rdBtnCity.Size = new System.Drawing.Size(64, 20);
            this.rdBtnCity.TabIndex = 11;
            this.rdBtnCity.Text = "Postort";
            this.rdBtnCity.UseVisualStyleBackColor = true;
            // 
            // rdBtnName
            // 
            this.rdBtnName.AutoSize = true;
            this.rdBtnName.Checked = true;
            this.rdBtnName.Location = new System.Drawing.Point(17, 65);
            this.rdBtnName.Name = "rdBtnName";
            this.rdBtnName.Size = new System.Drawing.Size(58, 20);
            this.rdBtnName.TabIndex = 10;
            this.rdBtnName.TabStop = true;
            this.rdBtnName.Text = "Namn";
            this.rdBtnName.UseVisualStyleBackColor = true;
            // 
            // btnEmpty
            // 
            this.btnEmpty.Font = new System.Drawing.Font("Microsoft YaHei", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEmpty.Location = new System.Drawing.Point(6, 371);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(108, 28);
            this.btnEmpty.TabIndex = 9;
            this.btnEmpty.Text = "Töm lista";
            this.btnEmpty.UseVisualStyleBackColor = true;
            this.btnEmpty.Click += new System.EventHandler(this.Btn_EmptyList);
            // 
            // btnOKSearch
            // 
            this.btnOKSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOKSearch.Location = new System.Drawing.Point(156, 36);
            this.btnOKSearch.Name = "btnOKSearch";
            this.btnOKSearch.Size = new System.Drawing.Size(66, 23);
            this.btnOKSearch.TabIndex = 8;
            this.btnOKSearch.Text = "OK";
            this.btnOKSearch.UseVisualStyleBackColor = true;
            this.btnOKSearch.Click += new System.EventHandler(this.OKbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Sök... ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 36);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(144, 22);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.Text = "Namn eller postort";
            this.txtSearch.UseWaitCursor = true;
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox_empty);
            // 
            // btnShowContact
            // 
            this.btnShowContact.Font = new System.Drawing.Font("Microsoft YaHei", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowContact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowContact.Location = new System.Drawing.Point(6, 337);
            this.btnShowContact.Name = "btnShowContact";
            this.btnShowContact.Size = new System.Drawing.Size(108, 28);
            this.btnShowContact.TabIndex = 5;
            this.btnShowContact.Text = "Visa kontakt";
            this.btnShowContact.UseVisualStyleBackColor = true;
            this.btnShowContact.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // btnChangeContact
            // 
            this.btnChangeContact.Font = new System.Drawing.Font("Microsoft YaHei", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeContact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChangeContact.Location = new System.Drawing.Point(120, 337);
            this.btnChangeContact.Name = "btnChangeContact";
            this.btnChangeContact.Size = new System.Drawing.Size(102, 28);
            this.btnChangeContact.TabIndex = 4;
            this.btnChangeContact.Text = "Redigera kontakt";
            this.btnChangeContact.UseVisualStyleBackColor = true;
            this.btnChangeContact.Click += new System.EventHandler(this.Change_Click);
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.Font = new System.Drawing.Font("Microsoft YaHei", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteContact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteContact.Location = new System.Drawing.Point(120, 371);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(102, 28);
            this.btnDeleteContact.TabIndex = 3;
            this.btnDeleteContact.Text = "Radera kontakt";
            this.btnDeleteContact.UseVisualStyleBackColor = true;
            this.btnDeleteContact.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // lstBook
            // 
            this.lstBook.FormattingEnabled = true;
            this.lstBook.ItemHeight = 16;
            this.lstBook.Location = new System.Drawing.Point(6, 96);
            this.lstBook.Name = "lstBook";
            this.lstBook.Size = new System.Drawing.Size(216, 228);
            this.lstBook.TabIndex = 0;
            this.lstBook.DoubleClick += new System.EventHandler(this.LstBook_DbClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChange2);
            this.groupBox2.Controls.Add(this.btnAddContact);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.txtCity);
            this.groupBox2.Controls.Add(this.txtPstCode);
            this.groupBox2.Controls.Add(this.txtStreet);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 257);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kontaktinformation";
            // 
            // btnChange2
            // 
            this.btnChange2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChange2.Location = new System.Drawing.Point(243, 205);
            this.btnChange2.Name = "btnChange2";
            this.btnChange2.Size = new System.Drawing.Size(104, 23);
            this.btnChange2.TabIndex = 12;
            this.btnChange2.Text = "Ändra kontakt";
            this.btnChange2.UseVisualStyleBackColor = true;
            this.btnChange2.Click += new System.EventHandler(this.BtnChange2_Click);
            // 
            // btnAddContact
            // 
            this.btnAddContact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddContact.Location = new System.Drawing.Point(126, 205);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(104, 23);
            this.btnAddContact.TabIndex = 2;
            this.btnAddContact.Text = "Lägg till kontakt";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.BtnAddContact_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(126, 175);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(221, 22);
            this.txtEmail.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(126, 144);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(221, 22);
            this.txtPhone.TabIndex = 10;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(126, 113);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(221, 22);
            this.txtCity.TabIndex = 9;
            // 
            // txtPstCode
            // 
            this.txtPstCode.Location = new System.Drawing.Point(126, 85);
            this.txtPstCode.Name = "txtPstCode";
            this.txtPstCode.Size = new System.Drawing.Size(221, 22);
            this.txtPstCode.TabIndex = 8;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(126, 56);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(221, 22);
            this.txtStreet.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(221, 22);
            this.txtName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-post: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Postort: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Postnummer: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gatuadress: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fullt namn: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnShowDelete);
            this.groupBox3.Controls.Add(this.lblSPhone);
            this.groupBox3.Controls.Add(this.lblSEmail);
            this.groupBox3.Controls.Add(this.lblSCity);
            this.groupBox3.Controls.Add(this.lblSPostcode);
            this.groupBox3.Controls.Add(this.lblSStreet);
            this.groupBox3.Controls.Add(this.lblSName);
            this.groupBox3.Controls.Add(this.lblEmail);
            this.groupBox3.Controls.Add(this.lblCity);
            this.groupBox3.Controls.Add(this.lblPhone);
            this.groupBox3.Controls.Add(this.lblPstCode);
            this.groupBox3.Controls.Add(this.lblStreet);
            this.groupBox3.Controls.Add(this.lblName);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(12, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 151);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Visa kontakt";
            // 
            // btnShowDelete
            // 
            this.btnShowDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowDelete.Location = new System.Drawing.Point(294, 122);
            this.btnShowDelete.Name = "btnShowDelete";
            this.btnShowDelete.Size = new System.Drawing.Size(75, 23);
            this.btnShowDelete.TabIndex = 12;
            this.btnShowDelete.Text = "Rensa";
            this.btnShowDelete.UseMnemonic = false;
            this.btnShowDelete.UseVisualStyleBackColor = true;
            this.btnShowDelete.Click += new System.EventHandler(this.BtnShowDelete);
            // 
            // lblSPhone
            // 
            this.lblSPhone.AutoSize = true;
            this.lblSPhone.ForeColor = System.Drawing.Color.Black;
            this.lblSPhone.Location = new System.Drawing.Point(6, 112);
            this.lblSPhone.Name = "lblSPhone";
            this.lblSPhone.Size = new System.Drawing.Size(53, 16);
            this.lblSPhone.TabIndex = 11;
            this.lblSPhone.Text = "Telefon: ";
            // 
            // lblSEmail
            // 
            this.lblSEmail.AutoSize = true;
            this.lblSEmail.ForeColor = System.Drawing.Color.Black;
            this.lblSEmail.Location = new System.Drawing.Point(6, 96);
            this.lblSEmail.Name = "lblSEmail";
            this.lblSEmail.Size = new System.Drawing.Size(48, 16);
            this.lblSEmail.TabIndex = 10;
            this.lblSEmail.Text = "E-post: ";
            // 
            // lblSCity
            // 
            this.lblSCity.AutoSize = true;
            this.lblSCity.ForeColor = System.Drawing.Color.Black;
            this.lblSCity.Location = new System.Drawing.Point(6, 74);
            this.lblSCity.Name = "lblSCity";
            this.lblSCity.Size = new System.Drawing.Size(52, 16);
            this.lblSCity.TabIndex = 9;
            this.lblSCity.Text = "Postort: ";
            // 
            // lblSPostcode
            // 
            this.lblSPostcode.AutoSize = true;
            this.lblSPostcode.ForeColor = System.Drawing.Color.Black;
            this.lblSPostcode.Location = new System.Drawing.Point(6, 58);
            this.lblSPostcode.Name = "lblSPostcode";
            this.lblSPostcode.Size = new System.Drawing.Size(81, 16);
            this.lblSPostcode.TabIndex = 8;
            this.lblSPostcode.Text = "Postnummer: ";
            // 
            // lblSStreet
            // 
            this.lblSStreet.AutoSize = true;
            this.lblSStreet.ForeColor = System.Drawing.Color.Black;
            this.lblSStreet.Location = new System.Drawing.Point(6, 42);
            this.lblSStreet.Name = "lblSStreet";
            this.lblSStreet.Size = new System.Drawing.Size(72, 16);
            this.lblSStreet.TabIndex = 7;
            this.lblSStreet.Text = "Gatuadress: ";
            // 
            // lblSName
            // 
            this.lblSName.AutoSize = true;
            this.lblSName.ForeColor = System.Drawing.Color.Black;
            this.lblSName.Location = new System.Drawing.Point(6, 26);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(46, 16);
            this.lblSName.TabIndex = 6;
            this.lblSName.Text = "Namn: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(113, 96);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 16);
            this.lblEmail.TabIndex = 5;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(113, 74);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(0, 16);
            this.lblCity.TabIndex = 4;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(113, 112);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(0, 16);
            this.lblPhone.TabIndex = 3;
            // 
            // lblPstCode
            // 
            this.lblPstCode.AutoSize = true;
            this.lblPstCode.Location = new System.Drawing.Point(113, 58);
            this.lblPstCode.Name = "lblPstCode";
            this.lblPstCode.Size = new System.Drawing.Size(0, 16);
            this.lblPstCode.TabIndex = 2;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(113, 42);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(0, 16);
            this.lblStreet.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(113, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 16);
            this.lblName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(648, 435);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Adressbok";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOKSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnShowContact;
        private System.Windows.Forms.Button btnChangeContact;
        private System.Windows.Forms.Button btnDeleteContact;
        private System.Windows.Forms.ListBox lstBook;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPstCode;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPstCode;
        public System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.Button btnChange2;
        private System.Windows.Forms.Label lblSPhone;
        private System.Windows.Forms.Label lblSEmail;
        private System.Windows.Forms.Label lblSCity;
        private System.Windows.Forms.Label lblSPostcode;
        public System.Windows.Forms.Label lblSStreet;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.RadioButton rdBtnCity;
        private System.Windows.Forms.RadioButton rdBtnName;
        private System.Windows.Forms.Button btnShowDelete;
    }
}

