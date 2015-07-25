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
    public partial class frmTsk_AddSubject : DevExpress.XtraEditors.XtraForm {
        // AnhTuan - 22/7/2015

        private SubjectBO aSubjectBO = new SubjectBO ();
        private FacultyBO aFacultyBO = new FacultyBO ();
        private StudentFacultyBO aStudentFacultyBO = new StudentFacultyBO ();
        private SpecializationBO aSpecializationBO = new SpecializationBO ();
        private Subject aSubject = new Subject ();

        public frmTsk_AddSubject( ) {
            InitializeComponent ();
        }

        private void BtnAddSubject_Click( object sender, EventArgs e ) {
            SaveInforSubject ();
        }

        private void SaveInforSubject( ) {

            try {

                if(txtCodeSubject.Text != "" && txtNameSubject.Text != "" && txtCreditSubject.Text != "" && txtCoefficient.Text != "") {

                    aSubject = aSubjectBO.Select_ById (txtCodeSubject.Text).FirstOrDefault ();
                    if(aSubject == null) {
                        Subject sub = new Subject ();

                        sub.Sub_Code = txtCodeSubject.Text;
                        sub.Sub_Name = txtNameSubject.Text;
                        sub.Sub_Credits = int.Parse(txtCreditSubject.Text);
                        sub.Sub_Coefficient = double.Parse(txtCoefficient.Text);

                        if(radioType3.Checked == true) {
                            sub.Sub_Type = 3;            // môn thuộc loại chuyên ngành cơ sở
                            sub.Sub_FacultyCode = aFacultyBO.Select_ByName (cmbFacultyName.Text).Select (b => b.Fac_Code).FirstOrDefault ();
                            sub.Sub_SpecializationCode = aSpecializationBO.Select_ByName (cmbSpecializationName.Text).Select (b => b.Spe_Code).FirstOrDefault ();
                            if(cmbFacultyName.Text == "" || cmbSpecializationName.Text == "") {
                                MessageBox.Show ("Bạn chưa nhập thông tin về khoa hoặc chuyên ngành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                        if(radioType2.Checked == true) {
                            sub.Sub_Type = 2;            // môn thuộc loại chuyên ngành bắt buộc
                            sub.Sub_FacultyCode = aFacultyBO.Select_ByName (cmbFacultyName.Text).Select (b => b.Fac_Code).FirstOrDefault ();
                            sub.Sub_SpecializationCode = null;
                            if(cmbFacultyName.Text == "") {
                                MessageBox.Show ("Bạn chưa nhập tên khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                        if(radioType1.Checked == true) {
                            sub.Sub_Type = 1;            // môn thuộc loại đại cương
                            sub.Sub_FacultyCode = null;
                            sub.Sub_SpecializationCode = null;
                        }

                       
                        if(aSubjectBO.Insert (sub)) {
                            MessageBox.Show ("Thêm môn thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else {
                            MessageBox.Show ("Thêm môn thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else {
                        MessageBox.Show ("Môn này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void LoadData( ) {
            LoadFaculty ();
            cmbFacultyName.Text = "";
            cmbSpecializationName.Text = "";
            cmbFacultyName.Enabled = false;
            cmbSpecializationName.Enabled = false;
        }

        private void LoadFaculty( ) {
            cmbFacultyName.SelectedValueChanged += new EventHandler (LoadSpecialization);
            cmbFacultyName.DataSource = aFacultyBO.Select_All ().Select (b => b.Fac_Name).ToList<String> ();
        }

        private void LoadSpecialization( object sender, EventArgs e ) {
            int CurrentFaculty = aFacultyBO.Select_ByName (cmbFacultyName.SelectedValue.ToString ()).Select (b => b.Fac_Code).FirstOrDefault ();
            cmbSpecializationName.DataSource = aSpecializationBO.Select_ByFacultyCode (CurrentFaculty).Select (b => b.Spe_Name).ToList<String> ();
        }

        private void radioType1_CheckedChanged( object sender, EventArgs e ) {
            cmbFacultyName.Text = "";
            cmbSpecializationName.Text = "";
            cmbFacultyName.Enabled = false;
            cmbSpecializationName.Enabled = false;
        }

        private void radioType2_CheckedChanged( object sender, EventArgs e ) {
            cmbFacultyName.Enabled = true;
            cmbSpecializationName.Text = ""; 
            cmbSpecializationName.Enabled = false;
        }

        private void radioType3_CheckedChanged( object sender, EventArgs e ) {
            cmbFacultyName.Text = "";
            cmbSpecializationName.Text = "";
            cmbFacultyName.Enabled = true;
            cmbSpecializationName.Enabled = true;
        }

        private void cmbFacultyName_SelectedIndexChanged( object sender, EventArgs e ) {
            if(radioType2.Checked == true) {
                cmbSpecializationName.Text = "";
            }
        }

    }
}