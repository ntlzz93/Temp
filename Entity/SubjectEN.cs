using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace SchoolManager.Entity {
    class SubjectEN : Subject {

        public String SubjectCode { get; set; }

        public String SubjectName { get; set; }

        public int SubjectCredits { get; set; }

        public bool SubjectType { get; set; }

        public int? SubjectFacultyCode { get; set; }

        public int? SubjectSpecializationCode { get; set; }

        public double SubjectCoefficient { get; set; }

        public void setValue( Subject aSubject ) {

            this.SubjectCode = aSubject.Sub_Code;
            this.SubjectName = aSubject.Sub_Name;
            this.SubjectCredits = aSubject.Sub_Credits;
            this.SubjectType = aSubject.Sub_Type;
            this.SubjectFacultyCode = aSubject.Sub_FacultyCode;
            this.SubjectSpecializationCode = aSubject.Sub_SpecializationCode;
            this.SubjectCoefficient = aSubject.Sub_Coefficient;
        }

    }
}
