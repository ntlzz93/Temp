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
    public partial class SpecializationBO {
        private DbDataContext db = new DbDataContext();

        // Select All
        public List<Specialization> Select_All () {
            try {
                return db.Specializations.OrderBy(b => b.Spe_Code).ToList<Specialization>();
            }
            catch (Exception ex) {
                throw new Exception("SpecializationBO.Select_All" + ex.ToString());
            }
        }

        // Select all Specialization by Name
        public List<Specialization> Select_ByName (string Name) {
            try {
                return db.Specializations.Where(b => b.Spe_Name == Name).ToList<Specialization>();
            }
            catch (Exception ex) {
                throw new Exception("SpecializationBO.Select_ByName" + ex.ToString());
            }
        }

        // Select all Specialization by Faculty Code
        public List<Specialization> Select_ByFacultyCode (int FacultyCode) {
            try {
                return db.Specializations.Where(b => b.Fac_Code == FacultyCode).ToList<Specialization>();
            }
            catch (Exception ex){
                throw new Exception("SpecializationBO.Select_ByFacultyCode" + ex.ToString());
            }
        }

        // Insert new Specialization
        public bool Insert (Specialization aSpecialization) {
            try {
                db.Specializations.InsertOnSubmit(aSpecialization);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) {
                return false;
                throw new Exception("SpecializationBO.Select_ByFacultyCode" + ex.ToString());
            }
        }

        // Update Specialization
        public bool Update (Specialization aSpecialization) {
            try {
                var editObj = db.Specializations.Where(b => b.Spe_Code == aSpecialization.Spe_Code).FirstOrDefault();
                editObj.Spe_Name = aSpecialization.Spe_Name;
                editObj.Fac_Code = aSpecialization.Fac_Code;
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) {
                return false;
                throw new Exception("SpecializationBO.Update" + ex.ToString());
            }
        }

        // Delete Specialization
        public bool Delete (int SpecializationCode) {
            try {
                var deleteObj = db.Specializations.Where(b => b.Spe_Code == SpecializationCode).FirstOrDefault();
                db.Specializations.DeleteOnSubmit(deleteObj);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) {
                return false;
                throw new Exception("SpecializationBO.Update" + ex.ToString());
            }
        }
    }
}
