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
using System.Diagnostics;

namespace SchoolManager.Form_Task
{
	public partial class frmTsk_DisplayInforTeacher : DevExpress.XtraEditors.XtraForm
	{
		public frmTsk_DisplayInforTeacher()
		{
			InitializeComponent();
		}

		private void frmTsk_DisplayInforTeacher_Load(object sender,EventArgs e)
		{
			frmTsk_UpdateTeacher afrmTsk = new frmTsk_UpdateTeacher();
			gridControl1.DataSource = afrmTsk.GetTeacherList();
			gridControl1.Show();
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			try
			{
				DevExpress.XtraGrid.Views.Grid.GridView View = gridControl1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
				if (View != null)
				{
					View.ExportToPdf("InformationTeacher.pdf");

					Process pdfExport = new Process();
					pdfExport.StartInfo.FileName = "FoxitReader.exe";
					pdfExport.StartInfo.Arguments = "InformationTeacher.pdf";
					pdfExport.Start();
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.ToString());
			}
		}
	}
}