using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
	public class TeacherBO
	{
		private DbDataContext db = new DbDataContext();


		// Select All
		public List<Teacher> Select_All()
		{
			try
			{
				return db.Teachers.OrderBy(b => b.Tea_Code).ToList<Teacher>();
			}
			catch (Exception ex)
			{
				throw new Exception("TeacherBO.Select_All" + ex.ToString());
			}
		}

		// Select by ID
		public List<Teacher> Select_ById(int id)
		{
			try
			{
				return db.Teachers.Where(b => b.Tea_Code == id).ToList<Teacher>();
			}
			catch (Exception ex)
			{
				throw new Exception("TeacherBO.Select_ByID" + ex.ToString());
			}
		}

		// Select by Name
		public List<Teacher> Select_ByName(string name)
		{
			try
			{
				return  db.Teachers.Where(b => b.Tea_Name == name).ToList<Teacher>();
			}
			catch (Exception ex)
			{
				throw new Exception("TeacherBO.Select_ByName" + ex.ToString());
			}
		}
		// Select by Phone Number
		public List<Teacher> Select_ByPhoneNumber(string phonenumber)
		{
			try
			{
				return db.Teachers.Where(b => b.Tea_PhoneNumber == phonenumber).ToList<Teacher>();
			}
			catch (Exception ex)
			{
				throw new Exception("TeacherBO.Select_ByPhoneNumber" + ex.ToString());
			}
		}
		// Insert
		public bool Insert(Teacher aTeacher)
		{
			try
			{
				db.Teachers.InsertOnSubmit(aTeacher);
				db.SubmitChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
				throw new Exception("TeacherBO.Insert" + ex.ToString());
			}
		} 
		// Update
		public bool Update(Teacher aTeacher)
		{
			try
			{
				var editObj = db.Teachers.Where(b=>b.Tea_Code == aTeacher.Tea_Code).FirstOrDefault();
				editObj.Tea_Name = aTeacher.Tea_Name;
				editObj.Tea_Address = aTeacher.Tea_Address;
				editObj.Tea_DateOfBirth = aTeacher.Tea_DateOfBirth;
				editObj.Tea_Ethnic = aTeacher.Tea_Ethnic;
				editObj.Tea_HomeTown = aTeacher.Tea_HomeTown;
				editObj.Tea_PhoneNumber = aTeacher.Tea_PhoneNumber;
				editObj.Tea_Religion = aTeacher.Tea_Religion;
				db.SubmitChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
				throw new Exception("TeacherBO.Update" + ex.ToString());
			}
		}
		// Delete
		public bool Delete(int teacherCode)
		{
			try
			{
                var deleteObj = db.Teachers.Where(b => b.Tea_Code == teacherCode).FirstOrDefault();
				db.Teachers.DeleteOnSubmit(deleteObj);
				db.SubmitChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
				throw new Exception("TeacherBO.Delete" + ex.ToString());
			}
		}



	}
}
