namespace SchoolManager.Form_Task {
    partial class frmTsk_PrintInforSubject {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if( disposing && ( components != null ) ) {
                components.Dispose ();
            }
            base.Dispose ( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( ) {
            DevExpress.XtraGrid.Views.Grid.GridView gridView2;
            DevExpress.XtraGrid.Views.Grid.GridView gridView3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTsk_PrintInforSubject));
            this.SubCoce1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubCredit1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubFacultyCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubSpecializationCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubCoefficient1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubMoney1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.SubCode2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubName2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubCredit2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubType2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubFacultyCode2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubSpecializationCode2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubCoefficent2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubMoney2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnPrintAll = new DevExpress.XtraEditors.SimpleButton();
            this.dgvSubject = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SubCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubFacultyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubSpecializationCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubCoefficient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubMoney = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.btnPrintFaculty = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BtnSearchFacultyCode = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearchFacultyCode = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.btnPrintSpecialization = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearchSpecializationCode = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearchSpecializationCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchFacultyCode.Properties)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchSpecializationCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SubCoce1,
            this.SubName1,
            this.SubCredit1,
            this.gridColumn1,
            this.SubFacultyCode1,
            this.SubSpecializationCode1,
            this.SubCoefficient1,
            this.SubMoney1});
            gridView2.GridControl = this.gridControl1;
            gridView2.Name = "gridView2";
            gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // SubCoce1
            // 
            this.SubCoce1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubCoce1.AppearanceCell.Options.UseFont = true;
            this.SubCoce1.AppearanceCell.Options.UseTextOptions = true;
            this.SubCoce1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubCoce1.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubCoce1.AppearanceHeader.Options.UseFont = true;
            this.SubCoce1.AppearanceHeader.Options.UseTextOptions = true;
            this.SubCoce1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubCoce1.Caption = "Mã môn";
            this.SubCoce1.Name = "SubCoce1";
            this.SubCoce1.Visible = true;
            this.SubCoce1.VisibleIndex = 0;
            // 
            // SubName1
            // 
            this.SubName1.AppearanceCell.Options.UseTextOptions = true;
            this.SubName1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubName1.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubName1.AppearanceHeader.Options.UseFont = true;
            this.SubName1.AppearanceHeader.Options.UseTextOptions = true;
            this.SubName1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubName1.Caption = "Tên môn";
            this.SubName1.Name = "SubName1";
            this.SubName1.Visible = true;
            this.SubName1.VisibleIndex = 1;
            // 
            // SubCredit1
            // 
            this.SubCredit1.AppearanceCell.Options.UseTextOptions = true;
            this.SubCredit1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubCredit1.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubCredit1.AppearanceHeader.Options.UseFont = true;
            this.SubCredit1.AppearanceHeader.Options.UseTextOptions = true;
            this.SubCredit1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubCredit1.Caption = "Số tín chỉ";
            this.SubCredit1.Name = "SubCredit1";
            this.SubCredit1.Visible = true;
            this.SubCredit1.VisibleIndex = 2;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Loại môn";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            // 
            // SubFacultyCode1
            // 
            this.SubFacultyCode1.AppearanceCell.Options.UseTextOptions = true;
            this.SubFacultyCode1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubFacultyCode1.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubFacultyCode1.AppearanceHeader.Options.UseFont = true;
            this.SubFacultyCode1.AppearanceHeader.Options.UseTextOptions = true;
            this.SubFacultyCode1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubFacultyCode1.Caption = "Mã khoa";
            this.SubFacultyCode1.Name = "SubFacultyCode1";
            this.SubFacultyCode1.Visible = true;
            this.SubFacultyCode1.VisibleIndex = 4;
            // 
            // SubSpecializationCode1
            // 
            this.SubSpecializationCode1.AppearanceCell.Options.UseTextOptions = true;
            this.SubSpecializationCode1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubSpecializationCode1.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubSpecializationCode1.AppearanceHeader.Options.UseFont = true;
            this.SubSpecializationCode1.AppearanceHeader.Options.UseTextOptions = true;
            this.SubSpecializationCode1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubSpecializationCode1.Caption = "Mã chuyên ngành";
            this.SubSpecializationCode1.Name = "SubSpecializationCode1";
            this.SubSpecializationCode1.Visible = true;
            this.SubSpecializationCode1.VisibleIndex = 5;
            // 
            // SubCoefficient1
            // 
            this.SubCoefficient1.AppearanceCell.Options.UseTextOptions = true;
            this.SubCoefficient1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubCoefficient1.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubCoefficient1.AppearanceHeader.Options.UseFont = true;
            this.SubCoefficient1.AppearanceHeader.Options.UseTextOptions = true;
            this.SubCoefficient1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubCoefficient1.Caption = "Hệ số";
            this.SubCoefficient1.Name = "SubCoefficient1";
            this.SubCoefficient1.Visible = true;
            this.SubCoefficient1.VisibleIndex = 6;
            // 
            // SubMoney1
            // 
            this.SubMoney1.AppearanceCell.Options.UseTextOptions = true;
            this.SubMoney1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubMoney1.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubMoney1.AppearanceHeader.Options.UseFont = true;
            this.SubMoney1.AppearanceHeader.Options.UseTextOptions = true;
            this.SubMoney1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubMoney1.Caption = "Số tiền";
            this.SubMoney1.Name = "SubMoney1";
            this.SubMoney1.Visible = true;
            this.SubMoney1.VisibleIndex = 7;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-1, 32);
            this.gridControl1.MainView = gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1018, 407);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            gridView2});
            // 
            // gridView3
            // 
            gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SubCode2,
            this.SubName2,
            this.SubCredit2,
            this.SubType2,
            this.SubFacultyCode2,
            this.SubSpecializationCode2,
            this.SubCoefficent2,
            this.SubMoney2});
            gridView3.GridControl = this.gridControl2;
            gridView3.Name = "gridView3";
            gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // SubCode2
            // 
            this.SubCode2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubCode2.AppearanceCell.Options.UseFont = true;
            this.SubCode2.AppearanceCell.Options.UseTextOptions = true;
            this.SubCode2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubCode2.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubCode2.AppearanceHeader.Options.UseFont = true;
            this.SubCode2.AppearanceHeader.Options.UseTextOptions = true;
            this.SubCode2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubCode2.Caption = "Mã môn";
            this.SubCode2.Name = "SubCode2";
            this.SubCode2.Visible = true;
            this.SubCode2.VisibleIndex = 0;
            // 
            // SubName2
            // 
            this.SubName2.AppearanceCell.Options.UseTextOptions = true;
            this.SubName2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubName2.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubName2.AppearanceHeader.Options.UseFont = true;
            this.SubName2.AppearanceHeader.Options.UseTextOptions = true;
            this.SubName2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubName2.Caption = "Tên môn";
            this.SubName2.Name = "SubName2";
            this.SubName2.Visible = true;
            this.SubName2.VisibleIndex = 1;
            // 
            // SubCredit2
            // 
            this.SubCredit2.AppearanceCell.Options.UseTextOptions = true;
            this.SubCredit2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubCredit2.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubCredit2.AppearanceHeader.Options.UseFont = true;
            this.SubCredit2.AppearanceHeader.Options.UseTextOptions = true;
            this.SubCredit2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubCredit2.Caption = "Số tín chỉ";
            this.SubCredit2.Name = "SubCredit2";
            this.SubCredit2.Visible = true;
            this.SubCredit2.VisibleIndex = 2;
            // 
            // SubType2
            // 
            this.SubType2.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubType2.AppearanceCell.Options.UseFont = true;
            this.SubType2.AppearanceCell.Options.UseTextOptions = true;
            this.SubType2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubType2.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubType2.AppearanceHeader.Options.UseFont = true;
            this.SubType2.AppearanceHeader.Options.UseTextOptions = true;
            this.SubType2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubType2.Caption = "Loại môn";
            this.SubType2.Name = "SubType2";
            this.SubType2.Visible = true;
            this.SubType2.VisibleIndex = 3;
            // 
            // SubFacultyCode2
            // 
            this.SubFacultyCode2.AppearanceCell.Options.UseTextOptions = true;
            this.SubFacultyCode2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubFacultyCode2.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubFacultyCode2.AppearanceHeader.Options.UseFont = true;
            this.SubFacultyCode2.AppearanceHeader.Options.UseTextOptions = true;
            this.SubFacultyCode2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubFacultyCode2.Caption = "Mã khoa";
            this.SubFacultyCode2.Name = "SubFacultyCode2";
            this.SubFacultyCode2.Visible = true;
            this.SubFacultyCode2.VisibleIndex = 4;
            // 
            // SubSpecializationCode2
            // 
            this.SubSpecializationCode2.AppearanceCell.Options.UseTextOptions = true;
            this.SubSpecializationCode2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubSpecializationCode2.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubSpecializationCode2.AppearanceHeader.Options.UseFont = true;
            this.SubSpecializationCode2.AppearanceHeader.Options.UseTextOptions = true;
            this.SubSpecializationCode2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubSpecializationCode2.Caption = "Mã chuyên ngành";
            this.SubSpecializationCode2.Name = "SubSpecializationCode2";
            this.SubSpecializationCode2.Visible = true;
            this.SubSpecializationCode2.VisibleIndex = 5;
            // 
            // SubCoefficent2
            // 
            this.SubCoefficent2.AppearanceCell.Options.UseTextOptions = true;
            this.SubCoefficent2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubCoefficent2.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubCoefficent2.AppearanceHeader.Options.UseFont = true;
            this.SubCoefficent2.AppearanceHeader.Options.UseTextOptions = true;
            this.SubCoefficent2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubCoefficent2.Caption = "Hệ số";
            this.SubCoefficent2.Name = "SubCoefficent2";
            this.SubCoefficent2.Visible = true;
            this.SubCoefficent2.VisibleIndex = 6;
            // 
            // SubMoney2
            // 
            this.SubMoney2.AppearanceCell.Options.UseTextOptions = true;
            this.SubMoney2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubMoney2.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubMoney2.AppearanceHeader.Options.UseFont = true;
            this.SubMoney2.AppearanceHeader.Options.UseTextOptions = true;
            this.SubMoney2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubMoney2.Caption = "Số tiền";
            this.SubMoney2.Name = "SubMoney2";
            this.SubMoney2.Visible = true;
            this.SubMoney2.VisibleIndex = 7;
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(-1, 33);
            this.gridControl2.MainView = gridView3;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1021, 409);
            this.gridControl2.TabIndex = 7;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            gridView3});
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 4);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1597, 707);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.btnPrintAll);
            this.xtraTabPage1.Controls.Add(this.dgvSubject);
            this.xtraTabPage1.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.Image")));
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1591, 660);
            this.xtraTabPage1.Text = "In toàn bộ";
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintAll.Image")));
            this.btnPrintAll.Location = new System.Drawing.Point(970, 3);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(27, 24);
            this.btnPrintAll.TabIndex = 2;
            // 
            // dgvSubject
            // 
            this.dgvSubject.Location = new System.Drawing.Point(-1, 30);
            this.dgvSubject.MainView = this.gridView1;
            this.dgvSubject.Name = "dgvSubject";
            this.dgvSubject.Size = new System.Drawing.Size(1019, 408);
            this.dgvSubject.TabIndex = 0;
            this.dgvSubject.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SubCode,
            this.SubName,
            this.SubCredit,
            this.SubType,
            this.SubFacultyCode,
            this.SubSpecializationCode,
            this.SubCoefficient,
            this.SubMoney});
            this.gridView1.GridControl = this.dgvSubject;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // SubCode
            // 
            this.SubCode.AppearanceCell.Options.UseTextOptions = true;
            this.SubCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubCode.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubCode.AppearanceHeader.Options.UseFont = true;
            this.SubCode.AppearanceHeader.Options.UseTextOptions = true;
            this.SubCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubCode.Caption = "Mã môn";
            this.SubCode.Name = "SubCode";
            this.SubCode.Visible = true;
            this.SubCode.VisibleIndex = 0;
            this.SubCode.Width = 89;
            // 
            // SubName
            // 
            this.SubName.AppearanceCell.Options.UseTextOptions = true;
            this.SubName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubName.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubName.AppearanceHeader.Options.UseFont = true;
            this.SubName.AppearanceHeader.Options.UseTextOptions = true;
            this.SubName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubName.Caption = "Tên môn";
            this.SubName.Name = "SubName";
            this.SubName.Visible = true;
            this.SubName.VisibleIndex = 1;
            this.SubName.Width = 189;
            // 
            // SubCredit
            // 
            this.SubCredit.AppearanceCell.Options.UseTextOptions = true;
            this.SubCredit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubCredit.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubCredit.AppearanceHeader.Options.UseFont = true;
            this.SubCredit.AppearanceHeader.Options.UseTextOptions = true;
            this.SubCredit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubCredit.Caption = "Loại môn";
            this.SubCredit.Name = "SubCredit";
            this.SubCredit.Visible = true;
            this.SubCredit.VisibleIndex = 2;
            this.SubCredit.Width = 141;
            // 
            // SubType
            // 
            this.SubType.AppearanceCell.Options.UseTextOptions = true;
            this.SubType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubType.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubType.AppearanceHeader.Options.UseFont = true;
            this.SubType.AppearanceHeader.Options.UseTextOptions = true;
            this.SubType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubType.Caption = "Số tín chỉ";
            this.SubType.Name = "SubType";
            this.SubType.Visible = true;
            this.SubType.VisibleIndex = 3;
            this.SubType.Width = 100;
            // 
            // SubFacultyCode
            // 
            this.SubFacultyCode.AppearanceCell.Options.UseTextOptions = true;
            this.SubFacultyCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubFacultyCode.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubFacultyCode.AppearanceHeader.Options.UseFont = true;
            this.SubFacultyCode.AppearanceHeader.Options.UseTextOptions = true;
            this.SubFacultyCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubFacultyCode.Caption = "Mã khoa";
            this.SubFacultyCode.Name = "SubFacultyCode";
            this.SubFacultyCode.Visible = true;
            this.SubFacultyCode.VisibleIndex = 4;
            this.SubFacultyCode.Width = 92;
            // 
            // SubSpecializationCode
            // 
            this.SubSpecializationCode.AppearanceCell.Options.UseTextOptions = true;
            this.SubSpecializationCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubSpecializationCode.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubSpecializationCode.AppearanceHeader.Options.UseFont = true;
            this.SubSpecializationCode.AppearanceHeader.Options.UseTextOptions = true;
            this.SubSpecializationCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubSpecializationCode.Caption = "Mã chuyên ngành";
            this.SubSpecializationCode.Name = "SubSpecializationCode";
            this.SubSpecializationCode.Visible = true;
            this.SubSpecializationCode.VisibleIndex = 5;
            this.SubSpecializationCode.Width = 128;
            // 
            // SubCoefficient
            // 
            this.SubCoefficient.AppearanceCell.Options.UseTextOptions = true;
            this.SubCoefficient.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubCoefficient.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubCoefficient.AppearanceHeader.Options.UseFont = true;
            this.SubCoefficient.AppearanceHeader.Options.UseTextOptions = true;
            this.SubCoefficient.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubCoefficient.Caption = "Hệ số ";
            this.SubCoefficient.Name = "SubCoefficient";
            this.SubCoefficient.Visible = true;
            this.SubCoefficient.VisibleIndex = 6;
            this.SubCoefficient.Width = 86;
            // 
            // SubMoney
            // 
            this.SubMoney.AppearanceCell.Options.UseTextOptions = true;
            this.SubMoney.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubMoney.AppearanceHeader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubMoney.AppearanceHeader.Options.UseFont = true;
            this.SubMoney.AppearanceHeader.Options.UseTextOptions = true;
            this.SubMoney.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SubMoney.Caption = "Số tiền";
            this.SubMoney.Name = "SubMoney";
            this.SubMoney.Visible = true;
            this.SubMoney.VisibleIndex = 7;
            this.SubMoney.Width = 156;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.labelControl3);
            this.xtraTabPage2.Controls.Add(this.btnPrintFaculty);
            this.xtraTabPage2.Controls.Add(this.gridControl1);
            this.xtraTabPage2.Controls.Add(this.labelControl1);
            this.xtraTabPage2.Controls.Add(this.BtnSearchFacultyCode);
            this.xtraTabPage2.Controls.Add(this.txtSearchFacultyCode);
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1591, 660);
            this.xtraTabPage2.Text = "In theo khoa";
            // 
            // btnPrintFaculty
            // 
            this.btnPrintFaculty.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintFaculty.Image")));
            this.btnPrintFaculty.Location = new System.Drawing.Point(980, 5);
            this.btnPrintFaculty.Name = "btnPrintFaculty";
            this.btnPrintFaculty.Size = new System.Drawing.Size(26, 23);
            this.btnPrintFaculty.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(4, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 15);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Nhập mã khoa:";
            // 
            // BtnSearchFacultyCode
            // 
            this.BtnSearchFacultyCode.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearchFacultyCode.Image")));
            this.BtnSearchFacultyCode.Location = new System.Drawing.Point(207, 8);
            this.BtnSearchFacultyCode.Name = "BtnSearchFacultyCode";
            this.BtnSearchFacultyCode.Size = new System.Drawing.Size(23, 20);
            this.BtnSearchFacultyCode.TabIndex = 2;
            // 
            // txtSearchFacultyCode
            // 
            this.txtSearchFacultyCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSearchFacultyCode.Location = new System.Drawing.Point(101, 8);
            this.txtSearchFacultyCode.Name = "txtSearchFacultyCode";
            this.txtSearchFacultyCode.Size = new System.Drawing.Size(100, 20);
            this.txtSearchFacultyCode.TabIndex = 1;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.labelControl5);
            this.xtraTabPage3.Controls.Add(this.btnPrintSpecialization);
            this.xtraTabPage3.Controls.Add(this.gridControl2);
            this.xtraTabPage3.Controls.Add(this.labelControl2);
            this.xtraTabPage3.Controls.Add(this.btnSearchSpecializationCode);
            this.xtraTabPage3.Controls.Add(this.txtSearchSpecializationCode);
            this.xtraTabPage3.Margin = new System.Windows.Forms.Padding(6);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1591, 660);
            this.xtraTabPage3.Text = "In theo chuyên ngành";
            // 
            // btnPrintSpecialization
            // 
            this.btnPrintSpecialization.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintSpecialization.Image")));
            this.btnPrintSpecialization.Location = new System.Drawing.Point(975, 6);
            this.btnPrintSpecialization.Name = "btnPrintSpecialization";
            this.btnPrintSpecialization.Size = new System.Drawing.Size(24, 21);
            this.btnPrintSpecialization.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(16, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(135, 15);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Nhập mã chuyên ngành:";
            // 
            // btnSearchSpecializationCode
            // 
            this.btnSearchSpecializationCode.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchSpecializationCode.Image")));
            this.btnSearchSpecializationCode.Location = new System.Drawing.Point(263, 7);
            this.btnSearchSpecializationCode.Name = "btnSearchSpecializationCode";
            this.btnSearchSpecializationCode.Size = new System.Drawing.Size(23, 20);
            this.btnSearchSpecializationCode.TabIndex = 5;
            // 
            // txtSearchSpecializationCode
            // 
            this.txtSearchSpecializationCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSearchSpecializationCode.Location = new System.Drawing.Point(157, 7);
            this.txtSearchSpecializationCode.Name = "txtSearchSpecializationCode";
            this.txtSearchSpecializationCode.Size = new System.Drawing.Size(100, 20);
            this.txtSearchSpecializationCode.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(870, 7);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(104, 19);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "In danh sạch:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(860, 8);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(104, 19);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "In danh sạch:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(865, 8);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(104, 19);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "In danh sách:";
            // 
            // frmTsk_PrintInforSubject
            // 
            this.Appearance.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 486);
            this.Controls.Add(this.xtraTabControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmTsk_PrintInforSubject";
            this.Text = "In thông tin môn học";
            ((System.ComponentModel.ISupportInitialize)(gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchFacultyCode.Properties)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchSpecializationCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.GridControl dgvSubject;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn SubCode;
        private DevExpress.XtraGrid.Columns.GridColumn SubName;
        private DevExpress.XtraGrid.Columns.GridColumn SubCredit;
        private DevExpress.XtraGrid.Columns.GridColumn SubType;
        private DevExpress.XtraGrid.Columns.GridColumn SubFacultyCode;
        private DevExpress.XtraGrid.Columns.GridColumn SubSpecializationCode;
        private DevExpress.XtraGrid.Columns.GridColumn SubCoefficient;
        private DevExpress.XtraGrid.Columns.GridColumn SubMoney;
        private DevExpress.XtraEditors.SimpleButton BtnSearchFacultyCode;
        private DevExpress.XtraEditors.TextEdit txtSearchFacultyCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Columns.GridColumn SubCoce1;
        private DevExpress.XtraGrid.Columns.GridColumn SubName1;
        private DevExpress.XtraGrid.Columns.GridColumn SubCredit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn SubFacultyCode1;
        private DevExpress.XtraGrid.Columns.GridColumn SubSpecializationCode1;
        private DevExpress.XtraGrid.Columns.GridColumn SubCoefficient1;
        private DevExpress.XtraGrid.Columns.GridColumn SubMoney1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSearchSpecializationCode;
        private DevExpress.XtraEditors.TextEdit txtSearchSpecializationCode;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Columns.GridColumn SubCode2;
        private DevExpress.XtraGrid.Columns.GridColumn SubName2;
        private DevExpress.XtraGrid.Columns.GridColumn SubCredit2;
        private DevExpress.XtraGrid.Columns.GridColumn SubType2;
        private DevExpress.XtraGrid.Columns.GridColumn SubFacultyCode2;
        private DevExpress.XtraGrid.Columns.GridColumn SubSpecializationCode2;
        private DevExpress.XtraGrid.Columns.GridColumn SubCoefficent2;
        private DevExpress.XtraGrid.Columns.GridColumn SubMoney2;
        private DevExpress.XtraEditors.SimpleButton btnPrintAll;
        private DevExpress.XtraEditors.SimpleButton btnPrintFaculty;
        private DevExpress.XtraEditors.SimpleButton btnPrintSpecialization;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}