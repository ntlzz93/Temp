namespace SchoolManager.Design {
    partial class Login {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.txtPassword = new DevExpress.XtraEditors.TextEdit();
			this.txtUserName = new DevExpress.XtraEditors.TextEdit();
			this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
			this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
			this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
			this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// txtPassword
			// 
			this.txtPassword.EditValue = "";
			this.txtPassword.Location = new System.Drawing.Point(279, 121);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
			this.txtPassword.Properties.NullValuePrompt = "******";
			this.txtPassword.Properties.NullValuePromptShowForEmptyValue = true;
			this.txtPassword.Properties.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(198, 20);
			this.txtPassword.TabIndex = 10;
			this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MatchingEnterPress);
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(279, 87);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Properties.Appearance.BackColor = System.Drawing.Color.White;
			this.txtUserName.Properties.Appearance.Options.UseBackColor = true;
			this.txtUserName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
			this.txtUserName.Size = new System.Drawing.Size(198, 20);
			this.txtUserName.TabIndex = 9;
			// 
			// pictureEdit1
			// 
			this.pictureEdit1.EditValue = global::SchoolManager.Properties.Resources.thanglong;
			this.pictureEdit1.Location = new System.Drawing.Point(68, 20);
			this.pictureEdit1.Name = "pictureEdit1";
			this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
			this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEdit1.Size = new System.Drawing.Size(99, 165);
			this.pictureEdit1.TabIndex = 14;
			// 
			// pictureEdit3
			// 
			this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
			this.pictureEdit3.Location = new System.Drawing.Point(230, 117);
			this.pictureEdit3.Name = "pictureEdit3";
			this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.pictureEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
			this.pictureEdit3.Properties.Appearance.Options.UseForeColor = true;
			this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pictureEdit3.Size = new System.Drawing.Size(33, 33);
			this.pictureEdit3.TabIndex = 13;
			// 
			// pictureEdit2
			// 
			this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
			this.pictureEdit2.Location = new System.Drawing.Point(230, 79);
			this.pictureEdit2.Name = "pictureEdit2";
			this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.pictureEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
			this.pictureEdit2.Properties.Appearance.Options.UseForeColor = true;
			this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pictureEdit2.Size = new System.Drawing.Size(33, 33);
			this.pictureEdit2.TabIndex = 12;
			// 
			// btnLogin
			// 
			this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
			this.btnLogin.Location = new System.Drawing.Point(353, 159);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(124, 26);
			this.btnLogin.TabIndex = 11;
			this.btnLogin.Text = "Đăng nhập";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(504, 261);
			this.Controls.Add(this.pictureEdit1);
			this.Controls.Add(this.pictureEdit3);
			this.Controls.Add(this.pictureEdit2);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUserName);
			this.Name = "Login";
			this.Text = "School Manager";
			this.Enter += new System.EventHandler(this.btnLogin_Click);
			((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtUserName;
		private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}