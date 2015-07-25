using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace SchoolManager.Entity
{
	public class TeacherFacultyEN
	{
		public TeacherFacultyEN()
		{

		}
		public int TeacherCode { get; set; }
		public int FacultyCode { get; set; }
		public decimal? TeacherFacultySalary { get; set; }

		public void SetValue(TeacherFaculty aTeacherF)
		{
			this.FacultyCode = aTeacherF.Fac_Code;
			this.TeacherCode = aTeacherF.Tea_Code;
			this.TeacherFacultySalary = aTeacherF.Tfa_Salary;
		}
	}
}
