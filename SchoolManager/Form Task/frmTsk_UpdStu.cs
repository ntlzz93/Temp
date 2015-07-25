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
    public partial class frmTsk_UpdStu : DevExpress.XtraEditors.XtraForm {
        private StudentBO aStudentBO = new StudentBO();
        private Student aStudent = new Student();

        public frmTsk_UpdStu( ) {
            InitializeComponent ( );
        }

        private void btnSearch_Click( object sender, EventArgs e ) {
            aStudent = aStudentBO.Select_ById(txtCode.Text).First();
            if (aStudent != null) {
                txtName.Text = aStudent.Stu_Name;
                editDate.Text = aStudent.Stu_DateOfBirth.ToString();
                txtHomeTown.Text = aStudent.Stu_HomeTown;
                txtAddress.Text = aStudent.Stu_Address;
                txtPhone.Text = aStudent.Stu_PhoneNumber;
                txtEthnic.Text = aStudent.Stu_Ethnic;
                txtReligion.Text = aStudent.Stu_Religion;

            } else {
                MessageBox.Show("Không tìm thấy thông tin.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpd_Click( object sender, EventArgs e ) {
            SaveInforStudent ( );
        }

        private void SaveInforStudent( ) {
            try {
                aStudent.Stu_Name = txtName.Text;
                aStudent.Stu_DateOfBirth = editDate.Value;
                aStudent.Stu_HomeTown = txtHomeTown.Text;
                aStudent.Stu_Address = txtAddress.Text;
                aStudent.Stu_PhoneNumber = txtPhone.Text;
                aStudent.Stu_Ethnic = txtEthnic.Text;
                aStudent.Stu_Religion = txtReligion.Text;
                if (aStudentBO.Update(aStudent))
				{
                    MessageBox.Show ( "Sửa thông tin thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    this.Visible = false;
                } else {
                    MessageBox.Show ( "Không thể sửa được thông tin.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }
            catch ( Exception ex ) {
                MessageBox.Show ( ex.ToString ( ), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
    }
}