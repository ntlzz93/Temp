using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic {
    class TermBO {

        private DbDataContext db = new DbDataContext ( );

        // select all Term from DB

        public List<Term> Select_All( ) {
            try {
                return db.Terms.OrderBy ( b => b.Ter_Code ).ToList<Term> ( );
            }
            catch(Exception ex) {
                throw new Exception ( "TermBO.Select_All" + ex.ToString ( ) );
            }
        }

        // select Term by ID

        public List<Term> Select_ByID( int id ) {

            try {
                return db.Terms.OrderByDescending ( b => b.Ter_Code == id ).ToList<Term> ( );
            }

            catch ( Exception ex ) {
                throw new Exception ( "TermBO.Select_ByID" + ex.ToString ( ) );
            }
        }

        // select Term by Name

        public List<Term> Select_ByName( string name ) {

            try {
                return db.Terms.OrderByDescending ( b => b.Ter_Name == name ).ToList<Term> ( );
            }

            catch ( Exception ex ) {
                throw new Exception ( "TermBO.Select_ByName" + ex.ToString ( ) );
            }
        }


        // select Term by Group

        public List<Term> Select_ByGroup( String group ) {

            try {
                return db.Terms.OrderByDescending ( b => b.Ter_Group == group ).ToList<Term> ( );
            }

            catch ( Exception ex ) {
                throw new Exception ( "TermBO.Select_ByGroup" + ex.ToString ( ) );
            }
        }

        // select Term by YearStart and YearEnd

        public List<Term> Select_ByStartEnd( DateTime yearstart, DateTime yearend ) {

            try {
                return db.Terms.OrderByDescending ( b => b.Ter_YearStart == yearstart && b.Ter_YearEnd == yearend ).ToList<Term> ( );
            }

            catch ( Exception ex ) {
                throw new Exception ( "TermBO.Select_ByStartEnd" + ex.ToString ( ) );
            }
        }


        // Insert

        public bool Insert( Term aTerm ) {

            try {
                db.Terms.InsertOnSubmit ( aTerm );
                db.SubmitChanges ( );
                return true;
            }
            catch ( Exception ex ) {

                return false;
                throw new Exception ( "TermBO.Insert" + ex.ToString ( ) );
            }
        }

        // update

        public bool Updata( Term aTerm ) {

            try {
                var editObj = db.Terms.Where(b=>b.Ter_Code == aTerm.Ter_Code).FirstOrDefault();
                editObj.Ter_Name = aTerm.Ter_Name;
                editObj.Ter_Group = aTerm.Ter_Group;
                editObj.Ter_YearStart = aTerm.Ter_YearStart;
                editObj.Ter_YearEnd = aTerm.Ter_YearEnd;
                db.SubmitChanges ( );
                return true;
            }

            catch ( Exception ex ) {
                return false;
                throw new Exception ( "TermOB_Updata" + ex.ToString ( ) );
            }
        }

        // Delete

        public bool Delete( int termCode ) {

            try {
                var deleteObj = db.Terms.Where(b => b.Ter_Code == termCode).FirstOrDefault();
                db.Terms.DeleteOnSubmit ( deleteObj );
                db.SubmitChanges ( );
                return true;
            }
            catch ( Exception ex ) {
                return false;
                throw new Exception ( "TermOB_Delete" + ex.ToString ( ) );
            }
        }
    }
}
