using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace SchoolManager.Entity
{
	public class CourseEN
	{
		public CourseEN()
		{

		}
		public string StudentCode { get; set; }
		public string SubjectCode { get; set; }
		public int TeacherCode { get; set; }
		public double? CourseProcess { get; set; }
		public double? CourseExam { get; set; }
		public double? CourseScore { get; set; }
		public int CourseStatus { get; set; }

		public void SetValue(Course aCourse)
		{
			this.StudentCode = aCourse.Stu_Code;
			this.SubjectCode = aCourse.Sub_Code;
			this.TeacherCode = aCourse.Ter_Code;
			this.CourseExam = aCourse.Cou_Exam;
			this.CourseProcess = aCourse.Cou_Process;
			this.CourseScore = aCourse.Cou_Score;
			this.CourseStatus = aCourse.Cou_Status;
		}
	}
}
