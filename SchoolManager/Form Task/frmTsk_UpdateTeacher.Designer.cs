namespace SchoolManager.Form_Task
{
	partial class frmTsk_UpdateTeacher
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
			this.lbCode = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtCode = new System.Windows.Forms.TextBox();
			this.txtBoxName = new System.Windows.Forms.TextBox();
			this.txtHometown = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtRegilion = new System.Windows.Forms.TextBox();
			this.txtEthnic = new System.Windows.Forms.TextBox();
			this.dateArea = new System.Windows.Forms.DateTimePicker();
			this.btnDone = new DevExpress.XtraEditors.SimpleButton();
			this.gridViewDataTeacher = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colTea_Code = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTea_Name = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTea_DateOfBirth = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTea_HomeTown = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTea_Address = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTea_PhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTea_Religion = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTea_Ethnic = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridDataTeacher = new DevExpress.XtraGrid.GridControl();
			((System.ComponentModel.ISupportInitialize)(this.gridViewDataTeacher)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridDataTeacher)).BeginInit();
			this.SuspendLayout();
			// 
			// lbCode
			// 
			this.lbCode.AutoSize = true;
			this.lbCode.ForeColor = System.Drawing.Color.Black;
			this.lbCode.Location = new System.Drawing.Point(22, 25);
			this.lbCode.Name = "lbCode";
			this.lbCode.Padding = new System.Windows.Forms.Padding(10);
			this.lbCode.Size = new System.Drawing.Size(88, 33);
			this.lbCode.TabIndex = 3;
			this.lbCode.Text = "Mã Giáo Viên";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(21, 62);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(10);
			this.label2.Size = new System.Drawing.Size(92, 33);
			this.label2.TabIndex = 4;
			this.label2.Text = "Tên Giáo Viên";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(22, 95);
			this.label3.Name = "label3";
			this.label3.Padding = new System.Windows.Forms.Padding(10);
			this.label3.Size = new System.Drawing.Size(75, 33);
			this.label3.TabIndex = 5;
			this.label3.Text = "Ngày Sinh";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(22, 137);
			this.label4.Name = "label4";
			this.label4.Padding = new System.Windows.Forms.Padding(10);
			this.label4.Size = new System.Drawing.Size(65, 33);
			this.label4.TabIndex = 6;
			this.label4.Text = "Nơi Sinh";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(397, 13);
			this.label5.Name = "label5";
			this.label5.Padding = new System.Windows.Forms.Padding(10);
			this.label5.Size = new System.Drawing.Size(61, 33);
			this.label5.TabIndex = 7;
			this.label5.Text = "Địa Chỉ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(397, 58);
			this.label6.Name = "label6";
			this.label6.Padding = new System.Windows.Forms.Padding(10);
			this.label6.Size = new System.Drawing.Size(93, 33);
			this.label6.TabIndex = 8;
			this.label6.Text = "Số Điện Thoại";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(397, 98);
			this.label7.Name = "label7";
			this.label7.Padding = new System.Windows.Forms.Padding(10);
			this.label7.Size = new System.Drawing.Size(69, 33);
			this.label7.TabIndex = 9;
			this.label7.Text = "Tôn Giáo";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(400, 137);
			this.label8.Name = "label8";
			this.label8.Padding = new System.Windows.Forms.Padding(10);
			this.label8.Size = new System.Drawing.Size(66, 33);
			this.label8.TabIndex = 10;
			this.label8.Text = "Dân Tộc";
			// 
			// txtCode
			// 
			this.txtCode.Location = new System.Drawing.Point(145, 25);
			this.txtCode.Name = "txtCode";
			this.txtCode.ReadOnly = true;
			this.txtCode.Size = new System.Drawing.Size(212, 21);
			this.txtCode.TabIndex = 11;
			// 
			// txtBoxName
			// 
			this.txtBoxName.Location = new System.Drawing.Point(145, 70);
			this.txtBoxName.Name = "txtBoxName";
			this.txtBoxName.Size = new System.Drawing.Size(212, 21);
			this.txtBoxName.TabIndex = 12;
			// 
			// txtHometown
			// 
			this.txtHometown.Location = new System.Drawing.Point(145, 149);
			this.txtHometown.Name = "txtHometown";
			this.txtHometown.Size = new System.Drawing.Size(212, 21);
			this.txtHometown.TabIndex = 14;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(520, 25);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(212, 21);
			this.txtAddress.TabIndex = 15;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(520, 70);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(212, 21);
			this.txtPhone.TabIndex = 16;
			// 
			// txtRegilion
			// 
			this.txtRegilion.Location = new System.Drawing.Point(520, 110);
			this.txtRegilion.Name = "txtRegilion";
			this.txtRegilion.Size = new System.Drawing.Size(212, 21);
			this.txtRegilion.TabIndex = 17;
			// 
			// txtEthnic
			// 
			this.txtEthnic.Location = new System.Drawing.Point(520, 149);
			this.txtEthnic.Name = "txtEthnic";
			this.txtEthnic.Size = new System.Drawing.Size(212, 21);
			this.txtEthnic.TabIndex = 18;
			// 
			// dateArea
			// 
			this.dateArea.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateArea.Location = new System.Drawing.Point(145, 107);
			this.dateArea.Name = "dateArea";
			this.dateArea.Size = new System.Drawing.Size(212, 21);
			this.dateArea.TabIndex = 19;
			// 
			// btnDone
			// 
			this.btnDone.Location = new System.Drawing.Point(627, 192);
			this.btnDone.Name = "btnDone";
			this.btnDone.Size = new System.Drawing.Size(89, 23);
			this.btnDone.TabIndex = 20;
			this.btnDone.Text = "Cập Nhập";
			this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
			// 
			// gridViewDataTeacher
			// 
			this.gridViewDataTeacher.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTea_Code,
            this.colTea_Name,
            this.colTea_DateOfBirth,
            this.colTea_HomeTown,
            this.colTea_Address,
            this.colTea_PhoneNumber,
            this.colTea_Religion,
            this.colTea_Ethnic});
			this.gridViewDataTeacher.GridControl = this.gridDataTeacher;
			this.gridViewDataTeacher.Name = "gridViewDataTeacher";
			this.gridViewDataTeacher.OptionsView.ShowGroupPanel = false;
			// 
			// colTea_Code
			// 
			this.colTea_Code.Caption = "Mã Giáo Viên";
			this.colTea_Code.FieldName = "TeacherCode";
			this.colTea_Code.Name = "colTea_Code";
			this.colTea_Code.OptionsColumn.AllowEdit = false;
			this.colTea_Code.OptionsColumn.ReadOnly = true;
			this.colTea_Code.Visible = true;
			this.colTea_Code.VisibleIndex = 0;
			// 
			// colTea_Name
			// 
			this.colTea_Name.Caption = "Tên Giáo Viên";
			this.colTea_Name.FieldName = "TeacherName";
			this.colTea_Name.Name = "colTea_Name";
			this.colTea_Name.OptionsColumn.AllowEdit = false;
			this.colTea_Name.OptionsColumn.ReadOnly = true;
			this.colTea_Name.Visible = true;
			this.colTea_Name.VisibleIndex = 1;
			// 
			// colTea_DateOfBirth
			// 
			this.colTea_DateOfBirth.Caption = "Ngày Sinh";
			this.colTea_DateOfBirth.FieldName = "TeacherOfBirth";
			this.colTea_DateOfBirth.Name = "colTea_DateOfBirth";
			this.colTea_DateOfBirth.OptionsColumn.AllowEdit = false;
			this.colTea_DateOfBirth.OptionsColumn.ReadOnly = true;
			this.colTea_DateOfBirth.Visible = true;
			this.colTea_DateOfBirth.VisibleIndex = 2;
			// 
			// colTea_HomeTown
			// 
			this.colTea_HomeTown.Caption = "Nơi Sinh";
			this.colTea_HomeTown.FieldName = "TeacherHomeTown";
			this.colTea_HomeTown.Name = "colTea_HomeTown";
			this.colTea_HomeTown.OptionsColumn.AllowEdit = false;
			this.colTea_HomeTown.OptionsColumn.ReadOnly = true;
			this.colTea_HomeTown.Visible = true;
			this.colTea_HomeTown.VisibleIndex = 3;
			// 
			// colTea_Address
			// 
			this.colTea_Address.Caption = "Địa Chỉ";
			this.colTea_Address.FieldName = "TeacherAddress";
			this.colTea_Address.Name = "colTea_Address";
			this.colTea_Address.OptionsColumn.AllowEdit = false;
			this.colTea_Address.OptionsColumn.ReadOnly = true;
			this.colTea_Address.Visible = true;
			this.colTea_Address.VisibleIndex = 4;
			// 
			// colTea_PhoneNumber
			// 
			this.colTea_PhoneNumber.Caption = "Số Điện Thoại";
			this.colTea_PhoneNumber.FieldName = "TeacherPhoneNumber";
			this.colTea_PhoneNumber.Name = "colTea_PhoneNumber";
			this.colTea_PhoneNumber.OptionsColumn.AllowEdit = false;
			this.colTea_PhoneNumber.OptionsColumn.ReadOnly = true;
			this.colTea_PhoneNumber.Visible = true;
			this.colTea_PhoneNumber.VisibleIndex = 5;
			// 
			// colTea_Religion
			// 
			this.colTea_Religion.Caption = "Tôn Giáo";
			this.colTea_Religion.FieldName = "TeacherReligion";
			this.colTea_Religion.Name = "colTea_Religion";
			this.colTea_Religion.OptionsColumn.AllowEdit = false;
			this.colTea_Religion.OptionsColumn.ReadOnly = true;
			this.colTea_Religion.Visible = true;
			this.colTea_Religion.VisibleIndex = 6;
			// 
			// colTea_Ethnic
			// 
			this.colTea_Ethnic.Caption = "Dân Tộc";
			this.colTea_Ethnic.FieldName = "TeacherEthnic";
			this.colTea_Ethnic.Name = "colTea_Ethnic";
			this.colTea_Ethnic.OptionsColumn.AllowEdit = false;
			this.colTea_Ethnic.OptionsColumn.ReadOnly = true;
			this.colTea_Ethnic.Visible = true;
			this.colTea_Ethnic.VisibleIndex = 7;
			// 
			// gridDataTeacher
			// 
			this.gridDataTeacher.Location = new System.Drawing.Point(-2, 239);
			this.gridDataTeacher.MainView = this.gridViewDataTeacher;
			this.gridDataTeacher.Name = "gridDataTeacher";
			this.gridDataTeacher.Size = new System.Drawing.Size(798, 291);
			this.gridDataTeacher.TabIndex = 21;
		
			this.gridDataTeacher.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDataTeacher});
			// 
			// frmTsk_UpdateTeacher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 530);
			this.Controls.Add(this.gridDataTeacher);
			this.Controls.Add(this.btnDone);
			this.Controls.Add(this.dateArea);
			this.Controls.Add(this.txtEthnic);
			this.Controls.Add(this.txtRegilion);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtHometown);
			this.Controls.Add(this.txtBoxName);
			this.Controls.Add(this.txtCode);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lbCode);
			this.Name = "frmTsk_UpdateTeacher";
			this.Text = "Sửa Giáo Viên";
			this.Load += new System.EventHandler(this.frmTsk_UpadteTeacher_Load);
			gridViewDataTeacher.OptionsBehavior.Editable = false;
			gridViewDataTeacher.RowCellClick += gridViewDataTeacher_RowCellClick;
			((System.ComponentModel.ISupportInitialize)(this.gridViewDataTeacher)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridDataTeacher)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbCode;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtCode;
		private System.Windows.Forms.TextBox txtBoxName;
		private System.Windows.Forms.TextBox txtHometown;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.TextBox txtRegilion;
		private System.Windows.Forms.TextBox txtEthnic;
		private System.Windows.Forms.DateTimePicker dateArea;
		private DevExpress.XtraEditors.SimpleButton btnDone;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewDataTeacher;
		
		private DevExpress.XtraGrid.Columns.GridColumn colTea_Code;
		private DevExpress.XtraGrid.Columns.GridColumn colTea_Name;
		private DevExpress.XtraGrid.Columns.GridColumn colTea_DateOfBirth;
		private DevExpress.XtraGrid.Columns.GridColumn colTea_HomeTown;
		private DevExpress.XtraGrid.Columns.GridColumn colTea_Address;
		private DevExpress.XtraGrid.Columns.GridColumn colTea_PhoneNumber;
		private DevExpress.XtraGrid.Columns.GridColumn colTea_Religion;
		private DevExpress.XtraGrid.Columns.GridColumn colTea_Ethnic;
		private DevExpress.XtraGrid.GridControl gridDataTeacher;
	}
}