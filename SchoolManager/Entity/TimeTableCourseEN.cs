using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace SchoolManager.Entity
{
	public	class TimeTableCourseEN
	{
		public TimeTableCourseEN()
		{

		}
		public int TermCode { get; set; }
		public string SubjectCode { get; set; }
		public int? TeacherCode { get; set; }
		public string TimeTableCourseRoom { get; set; }
		public void SetValue(TimeTableCourse aTimeTC)
		{
			this.SubjectCode = aTimeTC.Sub_Code;
			this.TeacherCode = aTimeTC.Tea_Code;
			this.TermCode = aTimeTC.Ter_Code;
			this.TimeTableCourseRoom = aTimeTC.Ttc_Room;
		}
	}
}
