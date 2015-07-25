namespace SchoolManager.Form_Task
{
	partial class frmTsk_AddTeacher
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTsk_AddTeacher));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtHometown = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
			this.dtdate = new System.Windows.Forms.DateTimePicker();
			this.txtReligion = new System.Windows.Forms.TextBox();
			this.txtEthnic = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 80);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(10);
			this.label1.Size = new System.Drawing.Size(64, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Họ Tên ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 123);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(10);
			this.label2.Size = new System.Drawing.Size(75, 33);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ngày Sinh";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 169);
			this.label3.Name = "label3";
			this.label3.Padding = new System.Windows.Forms.Padding(10);
			this.label3.Size = new System.Drawing.Size(76, 33);
			this.label3.TabIndex = 2;
			this.label3.Text = "Quê Quán";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 267);
			this.label5.Name = "label5";
			this.label5.Padding = new System.Windows.Forms.Padding(10);
			this.label5.Size = new System.Drawing.Size(93, 33);
			this.label5.TabIndex = 4;
			this.label5.Text = "Số Điện Thoại";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 317);
			this.label6.Name = "label6";
			this.label6.Padding = new System.Windows.Forms.Padding(10);
			this.label6.Size = new System.Drawing.Size(69, 33);
			this.label6.TabIndex = 5;
			this.label6.Text = "Tôn Giáo";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(13, 362);
			this.label7.Name = "label7";
			this.label7.Padding = new System.Windows.Forms.Padding(10);
			this.label7.Size = new System.Drawing.Size(66, 33);
			this.label7.TabIndex = 6;
			this.label7.Text = "Dân Tộc";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(143, 92);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(265, 21);
			this.txtName.TabIndex = 7;
			// 
			// txtHometown
			// 
			this.txtHometown.Location = new System.Drawing.Point(143, 181);
			this.txtHometown.Name = "txtHometown";
			this.txtHometown.Size = new System.Drawing.Size(265, 21);
			this.txtHometown.TabIndex = 9;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(143, 230);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(265, 21);
			this.txtAddress.TabIndex = 10;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(143, 279);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(265, 21);
			this.txtPhone.TabIndex = 11;
			// 
			// btnAdd
			// 
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.Location = new System.Drawing.Point(421, 407);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(88, 33);
			this.btnAdd.TabIndex = 17;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// dtdate
			// 
			this.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtdate.Location = new System.Drawing.Point(143, 135);
			this.dtdate.Name = "dtdate";
			this.dtdate.Size = new System.Drawing.Size(265, 21);
			this.dtdate.TabIndex = 18;
			// 
			// txtReligion
			// 
			this.txtReligion.Location = new System.Drawing.Point(143, 324);
			this.txtReligion.Name = "txtReligion";
			this.txtReligion.Size = new System.Drawing.Size(265, 21);
			this.txtReligion.TabIndex = 19;
			// 
			// txtEthnic
			// 
			this.txtEthnic.Location = new System.Drawing.Point(143, 369);
			this.txtEthnic.Name = "txtEthnic";
			this.txtEthnic.Size = new System.Drawing.Size(265, 21);
			this.txtEthnic.TabIndex = 20;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.Color.Red;
			this.label8.Location = new System.Drawing.Point(64, 92);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(13, 13);
			this.label8.TabIndex = 21;
			this.label8.Text = "*";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 218);
			this.label4.Name = "label4";
			this.label4.Padding = new System.Windows.Forms.Padding(10);
			this.label4.Size = new System.Drawing.Size(61, 33);
			this.label4.TabIndex = 3;
			this.label4.Text = "Địa Chỉ";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.ForeColor = System.Drawing.Color.Red;
			this.label9.Location = new System.Drawing.Point(75, 135);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(13, 13);
			this.label9.TabIndex = 22;
			this.label9.Text = "*";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.ForeColor = System.Drawing.Color.Red;
			this.label10.Location = new System.Drawing.Point(75, 179);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(13, 13);
			this.label10.TabIndex = 23;
			this.label10.Text = "*";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.ForeColor = System.Drawing.Color.Red;
			this.label11.Location = new System.Drawing.Point(64, 230);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(13, 13);
			this.label11.TabIndex = 24;
			this.label11.Text = "*";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.ForeColor = System.Drawing.Color.Red;
			this.label12.Location = new System.Drawing.Point(92, 279);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(13, 13);
			this.label12.TabIndex = 25;
			this.label12.Text = "*";
			// 
			// frmTsk_AddTeacher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(521, 462);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtEthnic);
			this.Controls.Add(this.txtReligion);
			this.Controls.Add(this.dtdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtHometown);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmTsk_AddTeacher";
			this.Text = "Thêm Giáo Viên";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtHometown;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtPhone;
		private DevExpress.XtraEditors.SimpleButton btnAdd;
		private System.Windows.Forms.DateTimePicker dtdate;
		private System.Windows.Forms.TextBox txtReligion;
		private System.Windows.Forms.TextBox txtEthnic;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
	}
}