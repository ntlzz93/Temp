using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
	public class PaymentBO
	{
		private DbDataContext db = new DbDataContext();

		// Select All
		public List<Payment> Select_All()
		{
			try
			{
				return db.Payments.OrderBy(b => b.Stu_Code).OrderBy(b => b.Ter_Code).ToList<Payment>();
			}
			catch (Exception ex)
			{
				throw new Exception("PaymentBO.Select_All" + ex.ToString());
			}
		}
		// Select by Student Code
		public List<Payment> Select_ByStuId(string id)
		{
			try
			{
				return db.Payments.Where(b => b.Stu_Code == id).ToList<Payment>();
			}
			catch (Exception ex)
			{
				throw new Exception("PaymentBO.Select_ByStuId" + ex.ToString());
			}
		}
		// Select by Teacher Code
		public List<Payment> Select_ByTeaId(int id)
		{
			try
			{
				return db.Payments.Where(b => b.Ter_Code == id).ToList<Payment>();
			}
			catch (Exception ex)
			{
				throw new Exception("PaymentBO.Select_ByTeaId" + ex.ToString());
			}
		}

		// Select by both Teacher Code and Student Code

		public List<Payment> Select_Both(string idStu, int idTea)
		{
			try
			{
				return db.Payments.Where(b => b.Stu_Code == idStu && b.Ter_Code == idTea).ToList<Payment>();
			
			}
			catch (Exception ex)
			{
				throw new Exception("PaymentBO.Select_Both" + ex.ToString());
			}
		}

		// Insert
		public bool Insert(Payment aPayment)
		{
			try
			{
				db.Payments.InsertOnSubmit(aPayment);
				db.SubmitChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
				throw new Exception("PaymentBO.Insert" + ex.ToString());
			}
		}

		// Update
		public bool Update(Payment aPayment)
		{
			try
			{
                var editObj = db.Payments.Where(b => b.Stu_Code == aPayment.Stu_Code && b.Ter_Code == aPayment.Ter_Code).FirstOrDefault();
                editObj.Pay_Money = aPayment.Pay_Money;
                editObj.Pay_Status = aPayment.Pay_Status;
				db.SubmitChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
				throw new Exception("PaymentBO.Update" + ex.ToString());
			}
		}
		// Delete
		public bool Delete(string studentCode, int termCode)
		{
			try
			{
                var deleteObj = db.Payments.Where(b => b.Stu_Code == studentCode && b.Ter_Code == termCode).FirstOrDefault();
                db.Payments.DeleteOnSubmit(deleteObj);
				db.SubmitChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
				throw new Exception("PaymentBO.Update" + ex.ToString());
			}
		}

	}
}
