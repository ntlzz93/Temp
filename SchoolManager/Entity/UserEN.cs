using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace SchoolManager.Entity
{
	public class UserEN
	{
		public UserEN()
		{

		}
		public string UserName { get; set; }
		public string UserPassWord { get; set; }
        public string UsePersonName { get; set; }
        public DateTime? UseDateOfBirth { get; set; }
        public string UserEmail { get; set; }
        public string UserPhoneNumber { get; set; }
        public int? UserStatus { get; set; }
		public void SetValue(User aUser)
		{
			this.UserName = aUser.Use_Name;
			this.UserPassWord = aUser.Use_Password;
            this.UsePersonName = aUser.Use_PersonName;
            this.UseDateOfBirth = aUser.Use_DateOfBirth;
            this.UserEmail = aUser.Use_Email;
            this.UserPhoneNumber = aUser.Use_PhoneNumber;
            this.UserStatus = aUser.Use_Status;
		}
	}
}
