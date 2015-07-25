namespace SchoolManager.Form_Task
{
	partial class frmTsk_DisplayInforTeacher
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
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colTea_Code = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTea_Name = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTea_DateOfBirth = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTea_HomeTown = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTea_Address = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTea_PhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTea_Religion = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTea_Ethnic = new DevExpress.XtraGrid.Columns.GridColumn();
			this.btnExport = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.Location = new System.Drawing.Point(1, 1);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(1077, 505);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTea_Code,
            this.colTea_Name,
            this.colTea_DateOfBirth,
            this.colTea_HomeTown,
            this.colTea_Address,
            this.colTea_PhoneNumber,
            this.colTea_Religion,
            this.colTea_Ethnic});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowFooter = true;
			this.gridView1.OptionsView.ShowGroupPanel = false;
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
			// btnExport
			// 
			this.btnExport.Location = new System.Drawing.Point(1, 479);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(1077, 27);
			this.btnExport.TabIndex = 1;
			this.btnExport.Text = "Export To PDF";
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// frmTsk_DisplayInforTeacher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1071, 506);
			this.Controls.Add(this.btnExport);
			this.Controls.Add(this.gridControl1);
			this.Name = "frmTsk_DisplayInforTeacher";
			this.Text = "Thông Tin Giáo Viên";
			this.Load += new System.EventHandler(this.frmTsk_DisplayInforTeacher_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colTea_Code;
		private DevExpress.XtraGrid.Columns.GridColumn colTea_Name;
		private DevExpress.XtraGrid.Columns.GridColumn colTea_DateOfBirth;
		private DevExpress.XtraGrid.Columns.GridColumn colTea_HomeTown;
		private DevExpress.XtraGrid.Columns.GridColumn colTea_Address;
		private DevExpress.XtraGrid.Columns.GridColumn colTea_PhoneNumber;
		private DevExpress.XtraGrid.Columns.GridColumn colTea_Religion;
		private DevExpress.XtraGrid.Columns.GridColumn colTea_Ethnic;
		private DevExpress.XtraEditors.SimpleButton btnExport;
	}
}