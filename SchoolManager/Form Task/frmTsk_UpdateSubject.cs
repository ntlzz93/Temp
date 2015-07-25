using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SchoolManager.Entity;
using DataAccess;
using BusinessLogic;

namespace SchoolManager.Form_Task {
    public partial class frmTsk_UpdateSubject : DevExpress.XtraEditors.XtraForm {

        private SubjectBO aSubjectBO = new SubjectBO ();
        private FacultyBO aFacultyBO = new FacultyBO ();
        private StudentFacultyBO aStudentFacultyBO = new StudentFacultyBO ();
        private SpecializationBO aSpecializationBO = new SpecializationBO ();
        private Subject aSubject = new Subject ();
        bool Click;

        public frmTsk_UpdateSubject( ) {
            InitializeComponent ();
        }

        private void simpleButton1_Click( object sender, EventArgs e ) {
            Click = false;
            try {
                if(txtUpdSubjectCode.Text != "") {

                    aSubject = aSubjectBO.Select_ById (txtUpdSubjectCode.Text).FirstOrDefault ();
                    LoadData ();  //đ

                    if(aSubject != null) { 
                        txtNameUpdSubject.Text = aSubject.Sub_Name;
                        txtUpdCreditSubject.Text = aSubject.Sub_Credits.ToString ();
                        txtUpdCoefficient.Text = aSubject.Sub_Coefficient.ToString ();

                        if(aSubject.Sub_Type == 1) {
                            
                            radioTypeUpdate1.Checked = true;
                            cmbUpdFacultyName.Text = "";
                            cmbUpdSpecializationName.Text = "";
                            cmbUpdFacultyName.Enabled = false;
                            cmbUpdSpecializationName.Enabled = false;
                        }
                        if(aSubject.Sub_Type == 2) {
                            radioTypeUpdate2.Checked = true;
                            //List<Faculty> a = aFacultyBO.Select_ById (int.Parse(aSubject.Sub_FacultyCode.ToString()));
                            //MessageBox.Show ( a[0].Fac_Name.ToString());
                            cmbUpdFacultyName.Enabled = true;
                            cmbUpdFacultyName.Text = aFacultyBO.Select_ById (aSubject.Sub_FacultyCode.Value).Select (b => b.Fac_Name).FirstOrDefault ();                          
                            cmbUpdSpecializationName.Text = "";
                            cmbUpdSpecializationName.Enabled = false;
                        }
                        if(aSubject.Sub_Type == 3) {
                            radioTypeUpdate3.Checked = true;
                            cmbUpdFacultyName.Enabled = true;
                            cmbUpdSpecializationName.Enabled = true;
                            cmbUpdFacultyName.Text = aFacultyBO.Select_ById (aSubject.Sub_FacultyCode.Value).Select (b => b.Fac_Name).FirstOrDefault ();
                            cmbUpdSpecializationName.Text = aSpecializationBO.Select_All ().Where (b => b.Spe_Code == aSubject.Sub_SpecializationCode && b.Fac_Code == aSubject.Sub_FacultyCode).Select (b => b.Spe_Name).FirstOrDefault ();
                            
                        }

                        Click = true;
                    }
                    else {
                        MessageBox.Show ("Môn này không tồn tại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    MessageBox.Show ("Hãy chắc chắn là đã nhập mã môn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch(Exception ex) {
                MessageBox.Show (ex.ToString (),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void btnUpSubject_Click( object sender, EventArgs e ) {
            Click = true;
            try {

                if(txtNameUpdSubject.Text != "" && txtUpdCreditSubject.Text != "" && txtUpdCoefficient.Text != "") {

                    if(aSubject != null) {
                        Subject sub = new Subject ();
                        sub.Sub_Code = txtUpdSubjectCode.Text;
                        sub.Sub_Code = txtUpdSubjectCode.Text;
                        sub.Sub_Name = txtNameUpdSubject.Text;
                        sub.Sub_Credits = int.Parse (txtUpdCreditSubject.Text);
                        sub.Sub_Coefficient = double.Parse (txtUpdCoefficient.Text);

                        if(radioTypeUpdate3.Checked == true) {
                            sub.Sub_Type = 3;            // môn thuộc loại chuyên ngành cơ sở
                            sub.Sub_FacultyCode = aFacultyBO.Select_ByName (cmbUpdFacultyName.Text).Select (b => b.Fac_Code).FirstOrDefault ();
                            sub.Sub_SpecializationCode = aSpecializationBO.Select_ByName (cmbUpdSpecializationName.Text).Select (b => b.Spe_Code).FirstOrDefault ();
                            if(cmbUpdFacultyName.Text == "" || cmbUpdSpecializationName.Text == "") {
                                MessageBox.Show ("Bạn chưa nhập thông tin về khoa hoặc chuyên ngành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                        if(radioTypeUpdate2.Checked == true) {
                            sub.Sub_Type = 2;            // môn thuộc loại chuyên ngành bắt buộc
                            sub.Sub_FacultyCode = aFacultyBO.Select_ByName (cmbUpdFacultyName.Text).Select (b => b.Fac_Code).FirstOrDefault ();
                            sub.Sub_SpecializationCode = null;
                            if(cmbUpdFacultyName.Text == "") {
                                MessageBox.Show ("Bạn chưa nhập tên khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                        if(radioTypeUpdate1.Checked == true) {
                            sub.Sub_Type = 1;            // môn thuộc loại đại cương
                            sub.Sub_FacultyCode = null;
                            sub.Sub_SpecializationCode = null;
                        }

                        
                        if(aSubjectBO.Update(sub)) {
                            MessageBox.Show ("Sửa thông tin môn thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else {
                            MessageBox.Show ("Thêm môn thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else {
                        MessageBox.Show ("Môn này không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else {
                    MessageBox.Show ("Thông tin chưa đầy đủ,xìn mời kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex) {
                MessageBox.Show (ex.ToString (), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        // Load tên khoa và tên chuyên ngành theo khoa
        public void LoadData( ) {
            LoadFaculty ();
        }

        private void LoadFaculty( ) {
            cmbUpdFacultyName.SelectedValueChanged += new EventHandler (LoadSpecialization);
            cmbUpdFacultyName.DataSource = aFacultyBO.Select_All ().Select (b => b.Fac_Name).ToList<String> ();
        }

        private void LoadSpecialization( object sender, EventArgs e ) {
            int CurrentFaculty = aFacultyBO.Select_ByName (cmbUpdFacultyName.SelectedValue.ToString ()).Select (b => b.Fac_Code).FirstOrDefault ();
            cmbUpdSpecializationName.DataSource = aSpecializationBO.Select_ByFacultyCode (CurrentFaculty).Select (b => b.Spe_Name).ToList<String> ();
        }

        private void cmbUpdFacultyName_SelectedIndexChanged( object sender, EventArgs e ) {
            if(radioTypeUpdate2.Checked == true && Click == true) {
                cmbUpdSpecializationName.Text = "";
            }
        }

        // radiobutton
        private void radioTypeUpdate1_CheckedChanged( object sender, EventArgs e ) {
            if(Click == true) {
                cmbUpdFacultyName.Text = "";
                cmbUpdSpecializationName.Text = "";
                cmbUpdFacultyName.Enabled = false;
                cmbUpdSpecializationName.Enabled = false;
            }
        }

        private void radioTypeUpdate2_CheckedChanged( object sender, EventArgs e ) {
            if(Click == true) {
                cmbUpdFacultyName.Enabled = true;
                cmbUpdSpecializationName.Text = "";
                cmbUpdSpecializationName.Enabled = false;
            }
        }

        private void radioTypeUpdate3_CheckedChanged( object sender, EventArgs e ) {
            if(Click == true) {
                cmbUpdFacultyName.Text = "";
                cmbUpdSpecializationName.Text = "";
                cmbUpdFacultyName.Enabled = true;
                cmbUpdSpecializationName.Enabled = true;
            }
        }

    }
}