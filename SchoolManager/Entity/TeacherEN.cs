using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace SchoolManager.Entity
{
	public class TeacherEN
	{
		public int TeacherCode { get; set; }
		public string TeacherName { get; set; }
		public DateTime TeacherOfBirth { get; set; }
		public string TeacherHomeTown { get; set; }
		public string TeacherAddress { get; set; }
		public string TeacherPhoneNumber { get; set; }
		public string TeacherReligion { get; set; }
		public string TeacherEthnic { get; set; }
		public void SetValue(Teacher aTeacher)
		{
			this.TeacherCode = aTeacher.Tea_Code;
			this.TeacherName = aTeacher.Tea_Name;
			this.TeacherHomeTown = aTeacher.Tea_HomeTown;
			this.TeacherOfBirth = aTeacher.Tea_DateOfBirth;
			this.TeacherAddress = aTeacher.Tea_Address;
			this.TeacherPhoneNumber = aTeacher.Tea_PhoneNumber;
			this.TeacherReligion = aTeacher.Tea_Religion;
			this.TeacherEthnic = aTeacher.Tea_Ethnic;

		}
	}
}
