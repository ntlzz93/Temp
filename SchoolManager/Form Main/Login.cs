using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataAccess;
using BusinessLogic;
using SchoolManager.Form_Task;

namespace SchoolManager.Design {
    public partial class Login : DevExpress.XtraEditors.XtraForm {
		private DbDataContext db = new DbDataContext();
		
        public Login () {
            InitializeComponent();
        }
		
		private void btnLogin_Click(object sender, EventArgs e)
		{
			
			UserBO user = new UserBO();
			string username = txtUserName.Text;
			string password = txtPassword.Text;
			if (user.Login(username, password) == true)
			{
				Main aMain = new Main();
				aMain.Show();
				this.Visible = false;
			}
			else
			{
				MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void MatchingEnterPress (object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
				UserBO user = new UserBO();
				string username = txtUserName.Text;
				string password = txtPassword.Text;
				if (user.Login(username, password) == true)
				{
					Main aMain = new Main();
					aMain.Show();
					this.Visible = false;
				}
				else
				{
					MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				
            }
        }
    }
}