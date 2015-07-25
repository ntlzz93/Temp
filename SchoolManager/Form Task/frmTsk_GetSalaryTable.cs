using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using SchoolManager.Entity;
using BusinessLogic;

namespace SchoolManager.Form_Task
{
	public class frmTsk_GetSalaryTable
	{
		public string TeacherName{get;set;}
		public string FacultyName { get; set; }
		public decimal? Salary { get; set; }

		public void SetList(string TeacherName , string FacultyName , decimal? Saraly)
		{
			this.FacultyName = FacultyName;
			this.TeacherName = TeacherName;
			this.Salary = Saraly;
		}

	}
}
