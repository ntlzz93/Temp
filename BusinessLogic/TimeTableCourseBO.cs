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
    public partial class TimeTableCourseBO {
        private DbDataContext db = new DbDataContext();
        
        //Select All
        public List<TimeTableCourse> Select_All () {
            try {
                return db.TimeTableCourses.OrderBy(b => b.Ter_Code).ToList<TimeTableCourse>();
            }
            catch (Exception ex) {
                throw new Exception("TimeTableCourseBO.Select_All" + ex.ToString());
            }
        }

        //Select all TimeTableCourse by TermCode 
        public List<TimeTableCourse> Select_ByTerCode (int TermCode) {
            try {
                return db.TimeTableCourses.Where(b => b.Ter_Code == TermCode).ToList<TimeTableCourse>();
            }
            catch (Exception ex) {
                throw new Exception("TimeTableCourseBO.Select_ByTerCode" + ex.ToString());
            }
        }

        //Select all TimeTableCourse by SubjectCode
        public List<TimeTableCourse> Select_BySubjectCode (string SubjectCode) {
            try {
                return db.TimeTableCourses.Where(b => b.Sub_Code == SubjectCode).ToList<TimeTableCourse>();
            }
            catch (Exception ex){
                throw new Exception("TimeTableCourseBO.Select_BySubjectCode" + ex.ToString());
            }
        }

        //Select all TimeTableCourse by TeacherCode
        public List<TimeTableCourse> Select_ByTeaCode (int TeacherCode) {
            try {
                return db.TimeTableCourses.Where(b => b.Tea_Code == TeacherCode).ToList<TimeTableCourse>();
            }
            catch (Exception ex) {
                throw new Exception("TimeTableCourseBO.Select_ByTeaCode" + ex.ToString());
            }
        }

        //Select all TimeTableCourse by Room
        public List<TimeTableCourse> Select_ByRoom (string Room) {
            try {
                return db.TimeTableCourses.Where(b => b.Ttc_Room == Room).ToList<TimeTableCourse>();
            }
            catch (Exception ex) {
                throw new Exception("TimeTableCourseBO.Select_ByRoom" + ex.ToString());
            }
        }

        //Insert new TimeTableCourse
        public bool Insert (TimeTableCourse aTimeTableCourse) {
            try {
                db.TimeTableCourses.InsertOnSubmit(aTimeTableCourse);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) {
                return false;
                throw new Exception("TimeTableCourseBO.Insert" + ex.ToString());
            }
        }

        //Update TimeTableCourse
        public bool Update (TimeTableCourse aTimeTableCourse) {
            try {
                var editObj = db.TimeTableCourses.Where(b => b.Ter_Code == aTimeTableCourse.Ter_Code).Where(b => b.Sub_Code == aTimeTableCourse.Sub_Code).FirstOrDefault();
                editObj.Tea_Code = aTimeTableCourse.Tea_Code;
                editObj.Ttc_Room = aTimeTableCourse.Ttc_Room;
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) {
                return false;
                throw new Exception("TimeTableCourseBO.Update" + ex.ToString());
            }
        }

        //Delete TimeTableCourse
        public bool Delete (int termCode, string subjectCode) {
            try {
                var deleteObj = db.TimeTableCourses.Where(b => b.Ter_Code == termCode).Where(b => b.Sub_Code == subjectCode).FirstOrDefault();
                db.TimeTableCourses.DeleteOnSubmit(deleteObj);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) {
                return false;
                throw new Exception("TimeTableCourseBO.Delete" + ex.ToString());
            }
        }
    }
}
