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
using DataAccess;
using BusinessLogic;

namespace SchoolManager.Form_Task
{
	public partial class frmTsk_AddTeacher : DevExpress.XtraEditors.XtraForm
	{
		private DbDataContext db = new DbDataContext();
		private TeacherBO aTeacherBO = new TeacherBO();
		private Teacher aTeacher;

		public frmTsk_AddTeacher()
		{
			InitializeComponent();
		}
		// LoiNT
		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				aTeacher = new Teacher();
				aTeacher.Tea_Name = txtName.Text;
				aTeacher.Tea_Address = txtAddress.Text;
				aTeacher.Tea_DateOfBirth = dtdate.Value;
				aTeacher.Tea_Ethnic = txtEthnic.Text;
				aTeacher.Tea_Religion = txtReligion.Text;
				aTeacher.Tea_PhoneNumber = txtPhone.Text;
				aTeacher.Tea_HomeTown = txtHometown.Text;
				// Check phone number and name to don't repeat record
				Teacher checkphone = aTeacherBO.Select_ByPhoneNumber(txtPhone.Text).FirstOrDefault();
				Teacher checkname = aTeacherBO.Select_ByName(txtName.Text).FirstOrDefault();
				if (txtName.Text != "" && txtPhone.Text != "" && txtAddress.Text != "" && txtHometown.Text != "")
				{
					if (checkphone == null || checkname == null)
					{
						if (aTeacherBO.Insert(aTeacher))
						{
							MessageBox.Show("Thành Công", "Thành Công", MessageBoxButtons.OK);
						}
						else
						{
							MessageBox.Show("Thất Bại", "Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					else
					{
						MessageBox.Show("Giáo Viên Đã Tồn Tại", "Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBox.Show("Bạn chưa điền đầy đủ thông tin yêu cầu", "Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btnAdd_Enter(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				try
				{
					aTeacher = new Teacher();
					aTeacher.Tea_Name = txtName.Text;
					aTeacher.Tea_Address = txtAddress.Text;
					aTeacher.Tea_DateOfBirth = dtdate.Value;
					aTeacher.Tea_Ethnic = txtEthnic.Text;
					aTeacher.Tea_Religion = txtReligion.Text;
					aTeacher.Tea_PhoneNumber = txtPhone.Text;
					aTeacher.Tea_HomeTown = txtHometown.Text;
					// Check phone number and name to don't repeat record
					Teacher checkphone = aTeacherBO.Select_ByPhoneNumber(txtPhone.Text).FirstOrDefault();
					Teacher checkname = aTeacherBO.Select_ByName(txtName.Text).FirstOrDefault();
					if (txtName.Text != "" && txtPhone.Text != "" && txtAddress.Text != "" && txtHometown.Text != "")
					{
						if (checkphone == null || checkname == null)
						{
							if (aTeacherBO.Insert(aTeacher))
							{
								MessageBox.Show("Thành Công", "Thành Công", MessageBoxButtons.OK);
							}
							else
							{
								MessageBox.Show("Thất Bại", "Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
						else
						{
							MessageBox.Show("Giáo Viên Đã Tồn Tại", "Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					else
					{
						MessageBox.Show("Bạn chưa điền đầy đủ thông tin yêu cầu", "Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

	}
}