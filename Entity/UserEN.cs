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
		public void SetValue(User aUser)
		{
			this.UserName = aUser.Use_Name;
			this.UserPassWord = aUser.Use_Password;
		}
	}
}
