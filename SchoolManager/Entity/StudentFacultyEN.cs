using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace SchoolManager.Entity {
    class StudentFacultyEN : StudentFaculty {

        public string StudentFacultyStu_Code { get; set; }

        public int StudentFacultyFac_Code { get; set; }

        public int StudentFacultySpe_Code { get; set; }

        public void setValue( StudentFaculty aStudentFaculty ) {
            this.StudentFacultyStu_Code = aStudentFaculty.Stu_Code;
            this.StudentFacultyFac_Code = aStudentFaculty.Fac_Code;
            this.StudentFacultySpe_Code = aStudentFaculty.Spe_Code;
        }
    }
}
