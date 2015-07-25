using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace SchoolManager.Entity {
    class PaymentEN : Payment{

        public PaymentEN( ) {
        
        }

        public string PaymentStu_Code { get; set; }

        public int PaymentTer_Code { get; set; }

        public string PaymentMoney { get; set; }

        public int? PaymentStatus { get; set; }

        public void setValue( Payment aPayment ) {

            this.PaymentStu_Code = aPayment.Stu_Code;
            this.PaymentTer_Code = aPayment.Ter_Code;
            this.PaymentMoney = aPayment.Pay_Money;
            this.PaymentStatus = aPayment.Pay_Status;
        }

    }
}
