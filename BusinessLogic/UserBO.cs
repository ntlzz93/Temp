using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using DataAccess;


namespace BusinessLogic
{
	public class UserBO 
	{
		private DbDataContext db = new DbDataContext();
		
		// Select By All
		public List<User> Select_ByAll()
		{
			try
			{
				return db.Users.OrderByDescending(b => b.Use_Name).ToList<User>();
			}
			catch (Exception ex)
			{
				throw new Exception("UserBO.Select_ByAll" + ex.ToString());
			}
		}
		// Select By Name
		public List<User> Select_ByName(string name)
		{

			try
			{
				return db.Users.Where(b => b.Use_Name == name).ToList<User>();
			}
			catch (Exception ex)
			{
				throw new Exception("UserBO.Select_ByName" + ex.ToString());
			}
		}
		//Select By Name and Password
		public List<User> Select_ByNameAndPass(string name,string pass)
		{
			try
			{
                return db.Users.Where(b => b.Use_Name == name).Where(b => b.Use_Password == ToSHA1(pass)).ToList<User>();
			}
			catch (Exception ex)
			{
				throw new Exception("UserBO.Select_ByNameAndPass" + ex.ToString());
			}
		}
		
		// Insert -- Register
        public bool Insert (User aUser)
		{
			try
			{
				// encrypt password 
                aUser.Use_Password = ToSHA1(aUser.Use_Password);
				db.Users.InsertOnSubmit(aUser);
				db.SubmitChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
				throw new Exception("UserBO.Insert" + ex.ToString());
			}
		}
		// Login
		public bool Login(string name, string password)
		{
			try
			{
			
				string passSHA1;
				passSHA1 = ToSHA1(password);
				var user = db.Users.Where(b => b.Use_Name == name).Where(b => b.Use_Password == passSHA1).ToList<User>();
				if (user.Any())
				{
					
					return true;
				}
				else
				{
					return false;
				}

			}
			catch (Exception ex)
			{

				throw new Exception("UserBO.Login" + ex.ToString());
			}
		}
        // Update
        public bool Update (User aUser) {
            try {
                var editObj = db.Users.Where(b => b.Use_Name == aUser.Use_Name).FirstOrDefault();
                editObj.Use_Password = ToSHA1(aUser.Use_Password);
                editObj.Use_PersonName = aUser.Use_PersonName;
                editObj.Use_DateOfBirth = aUser.Use_DateOfBirth;
                editObj.Use_Email = aUser.Use_Email;
                editObj.Use_PhoneNumber = aUser.Use_PhoneNumber;
                editObj.Use_Status = aUser.Use_Status;
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) {
                return false;
                throw new Exception("UserBO.Update" + ex.ToString());
            }
        }

        // Delete
        public bool Delete (string userName) {
            try {
                var deleteObj = db.Users.Where(b => b.Use_Name == userName).FirstOrDefault();
                db.Users.DeleteOnSubmit(deleteObj);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) {
                return false;
                throw new Exception("UserBO.Delete" + ex.ToString());
            }
        }

        // SHA1
        private string ToSHA1 (string pass) {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(pass);
            bs = sha1.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs) {
                s.Append(b.ToString("x1").ToLower());
            }
            pass = s.ToString();
            return pass;
        }
		
		
	}
}
