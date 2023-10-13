
namespace CartoonManagementWinApp_DoHoangAnh
{
    partial class frmCartoonDetails
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
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.txtProducer = new System.Windows.Forms.TextBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtShortDescription = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtCartoonName = new System.Windows.Forms.TextBox();
            this.lbCartoonName = new System.Windows.Forms.Label();
            this.txtCartoonID = new System.Windows.Forms.TextBox();
            this.lbCartoonID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(124, 261);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(184, 23);
            this.txtCountry.TabIndex = 23;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(20, 264);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(50, 15);
            this.lbCountry.TabIndex = 22;
            this.lbCountry.Text = "Producer";
            // 
            // txtProducer
            // 
            this.txtProducer.Location = new System.Drawing.Point(124, 220);
            this.txtProducer.Name = "txtProducer";
            this.txtProducer.Size = new System.Drawing.Size(184, 23);
            this.txtProducer.TabIndex = 21;
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(20, 223);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(28, 15);
            this.lbCity.TabIndex = 20;
            this.lbCity.Text = "Producer";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(124, 140);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(184, 23);
            this.txtPassword.TabIndex = 18;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(20, 143);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(57, 15);
            this.lbPassword.TabIndex = 18;
            this.lbPassword.Text = "Password";
            // 
            // txtShortDescription
            // 
            this.txtShortDescription.Location = new System.Drawing.Point(124, 97);
            this.txtShortDescription.Name = "txtShortDescription";
            this.txtShortDescription.Size = new System.Drawing.Size(184, 23);
            this.txtShortDescription.TabIndex = 17;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(20, 100);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(36, 15);
            this.lbEmail.TabIndex = 16;
            this.lbEmail.Text = "Email";
            // 
            // txtCartoonName
            // 
            this.txtCartoonName.Location = new System.Drawing.Point(124, 56);
            this.txtCartoonName.Name = "txtCartoonName";
            this.txtCartoonName.Size = new System.Drawing.Size(184, 23);
            this.txtCartoonName.TabIndex = 15;
            // 
            // lbCartoonName
            // 
            this.lbCartoonName.AutoSize = true;
            this.lbCartoonName.Location = new System.Drawing.Point(20, 59);
            this.lbCartoonName.Name = "lbCartoonName";
            this.lbCartoonName.Size = new System.Drawing.Size(87, 15);
            this.lbCartoonName.TabIndex = 14;
            this.lbCartoonName.Text = "Cartoon Name";
            // 
            // txtCartoonID
            // 
            this.txtCartoonID.Location = new System.Drawing.Point(124, 15);
            this.txtCartoonID.Name = "txtCartoonID";
            this.txtCartoonID.Size = new System.Drawing.Size(184, 23);
            this.txtCartoonID.TabIndex = 13;
            // 
            // lbCartoonID
            // 
            this.lbCartoonID.AutoSize = true;
            this.lbCartoonID.Location = new System.Drawing.Point(20, 18);
            this.lbCartoonID.Name = "lbCartoonID";
            this.lbCartoonID.Size = new System.Drawing.Size(66, 15);
            this.lbCartoonID.TabIndex = 12;
            this.lbCartoonID.Text = "Cartoon ID";
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(32, 319);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 23);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUpdate.Location = new System.Drawing.Point(32, 319);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 23);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(194, 319);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbConfirm
            // 
            this.lbConfirm.AutoSize = true;
            this.lbConfirm.Location = new System.Drawing.Point(20, 182);
            this.lbConfirm.Name = "lbConfirm";
            this.lbConfirm.Size = new System.Drawing.Size(51, 15);
            this.lbConfirm.TabIndex = 18;
            this.lbConfirm.Text = "Confirm";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(124, 179);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '*';
            this.txtConfirm.Size = new System.Drawing.Size(184, 23);
            this.txtConfirm.TabIndex = 19;
            // 
            // frmCartoonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 355);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.txtProducer);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.lbConfirm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtShortDescription);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.txtCartoonName);
            this.Controls.Add(this.lbCartoonName);
            this.Controls.Add(this.txtCartoonID);
            this.Controls.Add(this.lbCartoonID);
            this.Name = "frmCartoonDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCartoonDetails";
            this.Load += new System.EventHandler(this.frmCartoonDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.TextBox txtProducer;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtShortDescription;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtCartoonName;
        private System.Windows.Forms.Label lbCartoonName;
        private System.Windows.Forms.TextBox txtCartoonID;
        private System.Windows.Forms.Label lbCartoonID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
    }
}