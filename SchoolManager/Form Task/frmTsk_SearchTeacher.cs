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
	public partial class frmTsk_SearchTeacher : DevExpress.XtraEditors.XtraForm
	{
		//private TeacherBO aTeacherBO = new TeacherBO();
		public frmTsk_SearchTeacher()
		{
			InitializeComponent();
		}
		private void frmTsk_SearchTeacher_Load(object sender, EventArgs e)
		{
			frmTsk_UpdateTeacher afrmTsk = new frmTsk_UpdateTeacher();
			gridControl1.DataSource = afrmTsk.GetTeacherList();
			gridControl1.Show();
		}
		private void GridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
		{
			for (int i = 0; i <= e.RowHandle; i++)
			{
				if (e.Column == gcSTT)
				{ // without " before and after yourColName
					if (e.RowHandle >= 0)
					{
						e.DisplayText = (e.RowHandle + 1).ToString();
					}
				}
				
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			try
			{
				using (DbDataContext db = new DbDataContext())
				{
					// search by code
					TeacherBO aTeacherBO = new TeacherBO();
					foreach (var temp in aTeacherBO.Select_All().ToList())
					{
						int id = int.Parse(txtSearch.Text);
						if (id == temp.Tea_Code)
						{
							gridControl1.RefreshDataSource();
							gridControl1.DataSource = GetListDataByID(id);
							gridControl1.Show();

						}
						// search by name
						if (txtSearch.Text == temp.Tea_Name)
						{
							gridControl1.RefreshDataSource();
							gridControl1.DataSource = GetListDataByName(txtSearch.Text);
							gridControl1.Show();
						}
					}
					
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.ToString());
			}
		}

		private List<TeacherEN> GetListDataByID(int id)
		{
			List<TeacherEN> aListTeacher = new List<TeacherEN>();
			TeacherBO aTeacherBO = new TeacherBO();
			foreach (var temp in aTeacherBO.Select_ById(id))
			{
				TeacherEN aTeacherEN = new TeacherEN();
				aTeacherEN.SetValue(temp);
				aListTeacher.Add(aTeacherEN);
			}
			return aListTeacher;
		}
		private List<TeacherEN> GetListDataByName(string name)
		{
			List<TeacherEN> aListTeacher = new List<TeacherEN>();
			TeacherBO aTeacherBO = new TeacherBO();
			foreach (var temp in aTeacherBO.Select_ByName(name))
			{
				TeacherEN aTeacherEN = new TeacherEN();
				aTeacherEN.SetValue(temp);
				aListTeacher.Add(aTeacherEN);
			}
			return aListTeacher;
		}
	}
}