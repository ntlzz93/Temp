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
using SchoolManager.Entity;


namespace SchoolManager.Form_Task
{
	public partial class frmTsk_UpdateTeacher : DevExpress.XtraEditors.XtraForm
	{
		private DbDataContext db = new DbDataContext();
		private TeacherBO aTeacherBO = new TeacherBO();
		private Teacher aTeacher =new Teacher();


		public frmTsk_UpdateTeacher()
		{
			InitializeComponent();
		}
		private Teacher ObTeacher(int id)
		{
			Teacher tempTeacher = new Teacher();
			foreach (var obj in db.Teachers)
			{
				if (obj.Tea_Code == id)
				{
					tempTeacher = obj;
				}
			}
			return tempTeacher;
		}
		private void btnDone_Click(object sender, EventArgs e)
		{
			try
			{
				Teacher temp = new Teacher();
				int id = int.Parse(txtCode.Text);
				temp = ObTeacher(id);

				temp.Tea_Name = txtBoxName.Text;
				temp.Tea_DateOfBirth = dateArea.Value;
				temp.Tea_HomeTown = txtHometown.Text;
				temp.Tea_Address = txtAddress.Text;
				temp.Tea_PhoneNumber = txtPhone.Text;
				temp.Tea_Address = txtAddress.Text;
				temp.Tea_Religion = txtRegilion.Text;
				temp.Tea_Ethnic = txtEthnic.Text;

				if (aTeacherBO.Update(temp))
				{
					frmTsk_UpadteTeacher_Load(sender, e);
					MessageBox.Show("Thành Công", "Thành Công", MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Thất Bại", "Thất Bại", MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

	

		public List<TeacherEN> GetTeacherList()
		{
			List<TeacherEN> aList = new List<TeacherEN>();
			foreach (var temp in aTeacherBO.Select_All())
			{
				TeacherEN aTeacherEN = new TeacherEN();
				aTeacherEN.SetValue(temp);
				aList.Add(aTeacherEN);
			}
			return aList;
		}
		private void frmTsk_UpadteTeacher_Load(object sender, EventArgs e)
		{
			gridDataTeacher.DataSource = GetTeacherList();
			gridDataTeacher.RefreshDataSource();
			gridDataTeacher.Show();
		}
		
		
		// load data into textbox when it clicked
		private void gridViewDataTeacher_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
		{
				
				txtCode.Text = gridViewDataTeacher.GetRowCellValue(gridViewDataTeacher.FocusedRowHandle, "TeacherCode").ToString();
				txtBoxName.Text = gridViewDataTeacher.GetRowCellValue(gridViewDataTeacher.FocusedRowHandle, "TeacherName").ToString();
				dateArea.Text = gridViewDataTeacher.GetRowCellValue(gridViewDataTeacher.FocusedRowHandle, "TeacherOfBirth").ToString();
				txtHometown.Text = txtHometown.Text = gridViewDataTeacher.GetRowCellValue(gridViewDataTeacher.FocusedRowHandle, "TeacherHomeTown").ToString();
				txtAddress.Text = gridViewDataTeacher.GetRowCellValue(gridViewDataTeacher.FocusedRowHandle, "TeacherAddress").ToString();
			    txtPhone.Text=gridViewDataTeacher.GetRowCellValue(gridViewDataTeacher.FocusedRowHandle, "TeacherPhoneNumber").ToString();
				txtRegilion.Text = gridViewDataTeacher.GetRowCellValue(gridViewDataTeacher.FocusedRowHandle, "TeacherReligion").ToString();
				txtEthnic.Text = gridViewDataTeacher.GetRowCellValue(gridViewDataTeacher.FocusedRowHandle, "TeacherEthnic").ToString();
				
		}
	}
}