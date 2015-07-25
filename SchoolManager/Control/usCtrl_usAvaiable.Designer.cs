namespace SchoolManager.Control
{
	partial class usCtrl_usAvaiable
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usCtrl_usAvaiable));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lbName = new DevExpress.XtraEditors.LabelControl();
			this.lbPhone = new DevExpress.XtraEditors.LabelControl();
			this.lbEmail = new DevExpress.XtraEditors.LabelControl();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.lbEmail, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.lbPhone, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lbName, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 143);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.59091F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.40909F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(196, 118);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(33, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(163, 134);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// lbName
			// 
			this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbName.Location = new System.Drawing.Point(3, 20);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(75, 13);
			this.lbName.TabIndex = 0;
			this.lbName.Text = "Tên Đăng Nhập";
			// 
			// lbPhone
			// 
			this.lbPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbPhone.Location = new System.Drawing.Point(3, 62);
			this.lbPhone.Name = "lbPhone";
			this.lbPhone.Size = new System.Drawing.Size(66, 13);
			this.lbPhone.TabIndex = 1;
			this.lbPhone.Text = "Số Điện Thoại";
			// 
			// lbEmail
			// 
			this.lbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbEmail.Location = new System.Drawing.Point(3, 102);
			this.lbEmail.Name = "lbEmail";
			this.lbEmail.Size = new System.Drawing.Size(24, 13);
			this.lbEmail.TabIndex = 2;
			this.lbEmail.Text = "Email";
			// 
			// usCtrl_usAvaiable
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "usCtrl_usAvaiable";
			this.Size = new System.Drawing.Size(196, 360);
			this.Load += new System.EventHandler(this.usCtrl_usAvaiable_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private DevExpress.XtraEditors.LabelControl lbEmail;
		private DevExpress.XtraEditors.LabelControl lbPhone;
		private DevExpress.XtraEditors.LabelControl lbName;
		private System.Windows.Forms.PictureBox pictureBox1;

	}
}
