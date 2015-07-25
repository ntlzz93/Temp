using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
	public class TeacherFacultyBO
	{
		private DbDataContext db = new DbDataContext();

		// Select All
		public List<TeacherFaculty> Select_All()
		{
			try
			{
				return db.TeacherFaculties.OrderBy(b => b.Tea_Code).ToList<TeacherFaculty>();
			}
			catch (Exception ex)
			{
				throw new Exception("TeacherFacultyBO.SelectAll" + ex.ToString());
			}
		}

		// Select by Teacher Code
		public List<TeacherFaculty> Select_ByIDTeacher(int idTea)
		{
			try
			{
				return db.TeacherFaculties.Where(b => b.Tea_Code == idTea).OrderByDescending(b => b.Tea_Code).ToList<TeacherFaculty>();
			}
			catch (Exception ex)
			{
				throw new Exception("TeacherFacultyBO.Select_ByIDTeacher" + ex.ToString());
			}
		}

		// Select by Faculty Code 
		public List<TeacherFaculty> Select_ByIDFaculty(int idFa)
		{
			try
			{
				return db.TeacherFaculties.Where(b => b.Fac_Code == idFa).OrderByDescending(b => b.Tea_Code).ToList<TeacherFaculty>();
			}
			catch (Exception ex)
			{
				throw new Exception("TeacherFacultyBO.Select_ByIDFaculty" + ex.ToString());
			}
		}

		// Select Both Faculty and Teacher Code
		public List<TeacherFaculty> Select_BothPrimaryKey(int idTea, int idFa)
		{
			try
			{
				return db.TeacherFaculties.Where(b => b.Fac_Code == idFa && b.Tea_Code == idTea).OrderBy(b => b.Tea_Code).ToList<TeacherFaculty>();
			}
			catch (Exception ex)
			{
				throw new Exception("TeacherFacultyBO.Select_BothPrimaryKey" + ex.ToString());
			}
		}

		// Insert
		public bool Insert(TeacherFaculty aTeacherFaculty)
		{
			try
			{
				db.TeacherFaculties.InsertOnSubmit(aTeacherFaculty);
				db.SubmitChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
				throw new Exception("TeacherFacultyBO.Insert" + ex.ToString());
			}
		}

		// Update
		public bool Update(TeacherFaculty aTeacherFaculty)
		{
			try
			{
                var editObj = db.TeacherFaculties.Where(b => b.Tea_Code == aTeacherFaculty.Tea_Code && b.Fac_Code == aTeacherFaculty.Fac_Code).FirstOrDefault();
				editObj.Tfa_Salary = aTeacherFaculty.Tfa_Salary;
				db.SubmitChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
				throw new Exception("TeacherFacultyBO.Update" + ex.ToString());
			}
		}

		// Delete
		public bool Delete(int teacherCode, int facultyCode)
		{
			try
			{
                var deleteObj = db.TeacherFaculties.Where(b => b.Tea_Code == teacherCode && b.Fac_Code == facultyCode).FirstOrDefault();
                db.TeacherFaculties.DeleteOnSubmit(deleteObj);
				db.SubmitChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
				throw new Exception("TeacherFacultyBO.Delete" + ex.ToString());
			}
		}
	}
}
