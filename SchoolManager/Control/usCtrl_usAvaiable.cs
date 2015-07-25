using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManager.Design;

namespace SchoolManager.Control
{
	public partial class usCtrl_usAvaiable : UserControl
	{
		
		private BusinessLogic.UserBO aBO = new BusinessLogic.UserBO();
		private Login aLogin = new Login();
		public DataAccess.User DataSource = new DataAccess.User();


		public usCtrl_usAvaiable()
		{
			InitializeComponent();
		}

		protected void usCtrl_usAvaiable_Load(object sender, EventArgs e)
		{
			
		}
	}
}
