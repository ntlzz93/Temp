namespace SchoolManager.Form_Task
{
	partial class frmTsk_SalaryTable
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
			this.gcStt = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnVnd = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gcTeacher = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gcFaculty = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gcSalary = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.Location = new System.Drawing.Point(1, -1);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(909, 475);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcStt,
            this.gridColumnVnd,
            this.gcTeacher,
            this.gcFaculty,
            this.gcSalary});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsBehavior.Editable = false;
			this.gridView1.OptionsView.ShowGroupPanel = false;
			// 
			// gcStt
			// 
			this.gcStt.Caption = "Stt";
			this.gcStt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.gcStt.Name = "gcStt";
			this.gcStt.OptionsColumn.ReadOnly = true;
			this.gcStt.Visible = true;
			this.gcStt.VisibleIndex = 0;
			// 
			// gridColumnVnd
			// 
			this.gridColumnVnd.Caption = "VND";
			this.gridColumnVnd.Name = "gridColumnVnd";
			this.gridColumnVnd.Visible = true;
			this.gridColumnVnd.VisibleIndex = 4;
			// 
			// gcTeacher
			// 
			this.gcTeacher.Caption = "Giáo Viên";
			this.gcTeacher.FieldName = "TeacherName";
			this.gcTeacher.Name = "gcTeacher";
			this.gcTeacher.OptionsColumn.AllowEdit = false;
			this.gcTeacher.Visible = true;
			this.gcTeacher.VisibleIndex = 1;
			// 
			// gcFaculty
			// 
			this.gcFaculty.Caption = "Khoa";
			this.gcFaculty.FieldName = "FacultyName";
			this.gcFaculty.Name = "gcFaculty";
			this.gcFaculty.OptionsColumn.AllowEdit = false;
			this.gcFaculty.Visible = true;
			this.gcFaculty.VisibleIndex = 2;
			// 
			// gcSalary
			// 
			this.gcSalary.Caption = "Lương";
			this.gcSalary.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.gcSalary.FieldName = "Salary";
			this.gcSalary.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.gcSalary.Name = "gcSalary";
			this.gcSalary.OptionsColumn.AllowEdit = false;
			this.gcSalary.Visible = true;
			this.gcSalary.VisibleIndex = 3;
			// 
			// frmTsk_SalaryTable
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(911, 475);
			this.Controls.Add(this.gridControl1);
			this.Name = "frmTsk_SalaryTable";
			this.Text = "Bảng Lương Giáo Viên";
			this.Load += new System.EventHandler(this.frmTsk_SalaryTable_Load);
			gridView1.OptionsBehavior.Editable = false;
			gridView1.CustomColumnDisplayText += GridView1_CustomColumnDisplayText;
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);
			
		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn gcTeacher;
		private DevExpress.XtraGrid.Columns.GridColumn gcFaculty;
		private DevExpress.XtraGrid.Columns.GridColumn gcSalary;
		private DevExpress.XtraGrid.Columns.GridColumn gcStt;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumnVnd;
	}
}