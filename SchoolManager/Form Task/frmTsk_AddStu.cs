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
    public partial class frmTsk_AddStu : DevExpress.XtraEditors.XtraForm {

        private StudentBO aStudentBO = new StudentBO();
        private FacultyBO aFacultyBO = new FacultyBO();
        private SpecializationBO aSpecializationBO = new SpecializationBO();
        private StudentFacultyBO aStudentFacultyBO = new StudentFacultyBO();
		//StudentEn stEN = new StudentEn();

        public frmTsk_AddStu () {
            InitializeComponent();
		}

        public void LoadData () {
            LoadFaculty();
        }

		// LoiNT
		private void btnAdd_Click(object sender, EventArgs e)
		{
			SaveInforStudent();
		}

		private void SaveInforStudent()
		{
			try
			{
                Student stu = new Student();
                stu.Stu_Code = txtStuCode.Text;
                stu.Stu_Name = txtStuName.Text;
                stu.Stu_DateOfBirth = editDate.Value;
                stu.Stu_HomeTown = txtNs.Text;
                stu.Stu_Address = txtAddress.Text;
                stu.Stu_PhoneNumber = txtPhone.Text;
                stu.Stu_Ethnic = txtEth.Text;
                stu.Stu_Religion = txtReligion.Text;
                stu.Stu_StudyStatus = 1;

                // xu ly khoa va chuyen nganh
                StudentFaculty stFa = new StudentFaculty();

                stFa.Stu_Code = stu.Stu_Code;
                stFa.Fac_Code = aFacultyBO.Select_ByName(cmbFaculty.SelectedValue.ToString()).Select(b => b.Fac_Code).FirstOrDefault();
                stFa.Spe_Code = aSpecializationBO.Select_ByName(cmbSpecialization.SelectedValue.ToString()).Select(b => b.Spe_Code).FirstOrDefault();

                if (txtStuCode.Text != "" && txtStuName.Text != "" && txtAddress.Text != "") {
                    
                    if (aStudentBO.Insert(stu) && aStudentFacultyBO.Insert(stFa)) {
                        MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else {
                        MessageBox.Show("Thêm thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {

                    MessageBox.Show("Không được để trống mã, tên sinh viên và địa chỉ.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}

        private void LoadFaculty () {
            cmbFaculty.SelectedValueChanged += new EventHandler(LoadSpecialization);
            cmbFaculty.DataSource = aFacultyBO.Select_All().Select(b => b.Fac_Name).ToList<string>();
        }

        private void LoadSpecialization (object sender, EventArgs e) {
            int CurrentFaculty = aFacultyBO.Select_ByName(cmbFaculty.SelectedValue.ToString()).Select(b => b.Fac_Code).FirstOrDefault();
            cmbSpecialization.DataSource = aSpecializationBO.Select_ByFacultyCode(CurrentFaculty).Select(b => b.Spe_Name).ToList<string>();
        }
        
    }
}