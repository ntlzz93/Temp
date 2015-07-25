using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Entity
{
	class StudentEn : Student
	{
		public StudentEn()
		{

		}

		public string StudentCode { get; set; }

		public string StudentName { get; set; }

		public DateTime StudentDateOfBirth { get; set; }

		public string StudentHomeTown { get; set; }

		public string StudentAddress { get; set; }

		public string StudentPhone { get; set; }

		public string StudentReligion { get; set; }

		public string StudentEthnic { get; set; }

		public int? StudentStatus { get; set; }

		public void setValue(Student aStudent)
		{
			this.StudentCode = aStudent.Stu_Code;
			this.StudentName = aStudent.Stu_Name;
			this.StudentPhone = aStudent.Stu_PhoneNumber;
			this.StudentReligion = aStudent.Stu_Religion;
			this.StudentHomeTown = aStudent.Stu_HomeTown;
			this.StudentEthnic = aStudent.Stu_Ethnic;
			this.StudentDateOfBirth = aStudent.Stu_DateOfBirth;
			this.StudentAddress = aStudent.Stu_Address;
			this.StudentStatus = aStudent.Stu_StudyStatus;
		}

	}
}
