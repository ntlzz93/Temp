using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic {
    public partial class CourseBO {
        private DbDataContext db = new DbDataContext();

        // Select All
        public List<Course> Select_All () {
            try {
                return db.Courses.OrderBy(b => b.Stu_Code).ToList<Course>();
            }
            catch (Exception ex) {
                throw new Exception("CourseBO.Select_All" + ex.ToString());
            }
        }

        //Select all Cource by Student Code
        public List<Course> Select_ByStudentCode (string StudentCode) {
            try {
                return db.Courses.Where(b => b.Stu_Code == StudentCode).ToList<Course>();
            }
            catch (Exception ex) {
                throw new Exception("CourseBO.Select_ByStudentCode" + ex.ToString());
            }
        }

        //Select all Cource by Subject Code
        public List<Course> Select_BySubjectCode (string SubjectCode) {
            try {
                return db.Courses.Where(b => b.Stu_Code == SubjectCode).ToList<Course>();
            }
            catch (Exception ex) {
                throw new Exception("CourseBO.Select_BySubjectCode" + ex.ToString());
            }
        }

        //Select all Cource by Term Code
        public List<Course> Select_ByTermCode (string TermCode) {
            try {
                return db.Courses.Where(b => b.Stu_Code == TermCode).ToList<Course>();
            }
            catch (Exception ex) {
                throw new Exception("CourseBO.Select_ByTermCode" + ex.ToString());
            }
        }

        // Insert new Course
        public bool Insert (Course aCourse) {
            try {
                db.Courses.InsertOnSubmit(aCourse);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) {
                return false;
                throw new Exception("CourseBO.Insert" + ex.ToString());
            }
        }

        // Update Course
        public bool Update (Course aCourse) {
            try {
                var editObj = db.Courses.Where(b => b.Stu_Code == aCourse.Stu_Code && b.Sub_Code == aCourse.Sub_Code && b.Ter_Code == aCourse.Ter_Code).FirstOrDefault();
                editObj.Cou_Process = aCourse.Cou_Process;
                editObj.Cou_Exam = aCourse.Cou_Exam;
                editObj.Cou_Score = aCourse.Cou_Score;
                editObj.Cou_Status = aCourse.Cou_Status;
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) {
                return false;
                throw new Exception("CourseBO.Update" + ex.ToString());
            }
        }

        // Delete Course
        public bool Delete (string StudentCode, string SubjectCode, int TermCode) {
            try {
                var deleteObj = db.Courses.Where(b => b.Stu_Code == StudentCode && b.Sub_Code == SubjectCode && b.Ter_Code == TermCode).FirstOrDefault();
                db.Courses.DeleteOnSubmit(deleteObj);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) {
                return false;
                throw new Exception("CourseBO.Delete" + ex.ToString());
            }
        }
    }
}
