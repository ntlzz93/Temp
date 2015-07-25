using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Entity
{
	class FacultyEN
	{
		public FacultyEN()
		{

		}
		public int FacultyCode { set; get; }
		public string FacultyName { set; get; }
		public void SetValueFaculty(Faculty faculty)
		{
			this.FacultyCode = faculty.Fac_Code;
			this.FacultyName = faculty.Fac_Name;
		}
	}
}
