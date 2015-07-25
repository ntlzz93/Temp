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
	public partial class frmTsk_SalaryTable : DevExpress.XtraEditors.XtraForm
	{
		private DbDataContext db = new DbDataContext();
		TeacherBO aTeacherBO = new TeacherBO();
		FacultyBO aFacultyBO = new FacultyBO();
		TeacherFacultyBO aTeacherFacultyBO = new TeacherFacultyBO();
		Teacher aTeacher = new Teacher();
		Faculty aFaculty = new Faculty();
		TeacherFaculty aTeacherFculty = new TeacherFaculty();
		List<frmTsk_GetSalaryTable> aList = new List<frmTsk_GetSalaryTable>();
			
		public frmTsk_SalaryTable()
		{
			InitializeComponent();
			
		}

		public  void frmTsk_SalaryTable_Load(object sender, EventArgs e)
		{
			gridControl1.DataSource = GetList();
			gridControl1.Show();
		}
		public List<frmTsk_GetSalaryTable> GetList()
		{
			
			for(int i = 0 ;i<aTeacherFacultyBO.Select_All().Count;i++)
			{
				frmTsk_GetSalaryTable aFrmTsk = new frmTsk_GetSalaryTable();
				// get id giao vien va id khoa tu id giao vien va id khoa cua bang teacherfacultyBO
				int idTeacher = aTeacherFacultyBO.Select_All()[i].Tea_Code;
				int idFaculty = aTeacherFacultyBO.Select_All()[i].Fac_Code ;
				decimal? salary = aTeacherFacultyBO.Select_All()[i].Tfa_Salary;
				
				// lay ten giao vien va ten khoa tu id giao vien va i khoa trung voi id giao vien va id khoa trong bang teacherfacultyBO
				string nameTeacher = aTeacherBO.Select_ById(idTeacher).First().Tea_Name.ToString();
				
				string nameFaculty = aFacultyBO.Select_ById(idFaculty).First().Fac_Name.ToString();

				aFrmTsk.SetList(nameTeacher, nameFaculty, salary);
				aList.Add(aFrmTsk);
			}
			return aList;
		}
		private void GridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
		{
			for (int i = 0; i < aList.Count; i++)
			{
				if (e.Column == gcStt)
				{ // without " before and after yourColName
					if (e.RowHandle >= 0)
					{
						e.DisplayText = (e.RowHandle + 1).ToString();
					}
				}
				if (e.Column == gridColumnVnd)
				{
					e.DisplayText = "VND";
				}
			}	
		}
	}
}