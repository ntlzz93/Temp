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
    public partial class StudentBO {

        private DbDataContext db = new DbDataContext();
        
        // Select all Student from DB 
        public List<Student> Select_All () {
            try {
                return db.Students.OrderBy(b => b.Stu_Code).ToList<Student>();
            }
            catch (Exception ex){
                throw new Exception("StudentBO.Select_All:" + ex.ToString());
            }
        }

        // Select all Student by Student Code
        public List<Student> Select_ById (string studentCode) {
            try {
                return db.Students.Where(b => b.Stu_Code == studentCode).ToList<Student>();
            }
            catch (Exception ex){
                throw new Exception("StudentBO.Select_ById:" + ex.ToString());
            }
        }

        // Select all Student by Student Name
        public List<Student> Select_ByName (string studentName) {
            try {
                return db.Students.Where(b => b.Stu_Name == studentName).ToList<Student>();
            }
            catch (Exception ex){
                throw new Exception("StudentBO.Select_ByName:" + ex.ToString());
            }
        }

        // Select all Student by Religion
        public List<Student> Select_ByReligion (string studentReligion) {
            try {
                return db.Students.Where(b => b.Stu_Religion == studentReligion).ToList<Student>();
            }
            catch (Exception ex){
                throw new Exception("StudentBO.Select_ByReligion:" + ex.ToString());
            }
        }

        // Select all Student by Ethnic
        public List<Student> Select_ByEthnic (string studentEthnic) {
            try {
                return db.Students.Where(b => b.Stu_Ethnic == studentEthnic).ToList<Student>();
            }
            catch (Exception ex) {
                throw new Exception("StudentBO.Select_ByEthnic:" + ex.ToString());
            }
        }

        // Insert new Student
        public bool Insert (Student aStudent) {
            try {
                db.Students.InsertOnSubmit(aStudent);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) {
                return false;
                throw new Exception("StudentBO.Insert:" + ex.ToString());
            }
        }

        // Update Student
        public bool Update (Student aStudent) {
            try {
                var editObj = db.Students.Where(b => b.Stu_Code == aStudent.Stu_Code).FirstOrDefault();
                editObj.Stu_Name = aStudent.Stu_Name;
                editObj.Stu_DateOfBirth = aStudent.Stu_DateOfBirth;
                editObj.Stu_HomeTown = aStudent.Stu_HomeTown;
                editObj.Stu_Address = aStudent.Stu_Address;
                editObj.Stu_PhoneNumber = aStudent.Stu_PhoneNumber;
                editObj.Stu_Religion = aStudent.Stu_Religion;
                editObj.Stu_Ethnic = aStudent.Stu_Ethnic;
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) {
                return false;
                throw new Exception("StudentBO.Update:" + ex.ToString());
            }
        }

        // Delete Student
        public bool Delete (string studentCode) {
            try {
                var deleteObj = db.Students.Where(b => b.Stu_Code == studentCode).FirstOrDefault();
                db.Students.DeleteOnSubmit(deleteObj);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) {
                return false;
                throw new Exception("StudentBO.Delete:" + ex.ToString());
            }
        }
    }
}
