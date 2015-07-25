using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace SchoolManager.Entity
{
	public class TermEN
	{
		public TermEN()
		{

		}
		public int TermCode { get; set; }
		public string TermName { get; set; }
		public string TermGroup { get; set; }
		public DateTime TermStart { get; set; }
		public DateTime TermEnd { get; set; }
		public void SetValue(Term aTerm)
		{
			this.TermCode = aTerm.Ter_Code;
			this.TermName = aTerm.Ter_Name;
			this.TermGroup = aTerm.Ter_Group;
			this.TermStart = aTerm.Ter_YearStart;
			this.TermEnd = aTerm.Ter_YearEnd;
		}
	}
}
