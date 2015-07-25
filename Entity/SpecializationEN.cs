using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace SchoolManager.Entity {
    class SpecializationEN : Specialization {

        public int SpecializationCode { get; set; }

        public string SpecializatioName { get; set; }

        public int SpecializationFac_Code { get; set; }

        public void setValue( Specialization aSpecialization ) {

            this.SpecializationCode = aSpecialization.Spe_Code;
            this.SpecializatioName = aSpecialization.Spe_Name;
            this.SpecializationFac_Code = aSpecialization.Fac_Code;
        }
    }
}
