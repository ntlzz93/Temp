using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using SchoolManager.Entity;
using SchoolManager.Form_Task;
using SchoolManager.Control;
using DataAccess;
using BusinessLogic;

namespace SchoolManager.Design {
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm {
		 

		public Main( )
		{
			InitializeComponent();
			
		}
		private void LoadData(object sender , EventArgs e)
		{
			try
			{
				
				
			}
			catch (Exception ex)
			{
				throw new Exception(ex.ToString());
			}
		}
		// LoiNT 
		// Add Student button
		private void barBtnAddStudent_ItemClick(object sender, ItemClickEventArgs e)
		{
			frmTsk_AddStu frmAdd = new frmTsk_AddStu();
            frmAdd.LoadData();
			frmAdd.Show();
            
		}

        private void Main_FormClosed (object sender, FormClosedEventArgs e) {
            
        }
		// Update Student Button
        private void barBtnUpdateStu_ItemClick (object sender, ItemClickEventArgs e) {
            frmTsk_UpdStu frmUpd = new frmTsk_UpdStu();
            frmUpd.Show();
		}
		// LoiNT
		// Add Teacher Button
		private void barBtnAddTeacher_ItemClick(object sender, ItemClickEventArgs e)
		{
			frmTsk_AddTeacher aFrmTask = new frmTsk_AddTeacher();
			aFrmTask.Show();

        }

        private void barBtnPrintInforStu_ItemClick( object sender, ItemClickEventArgs e ) {

        }

        private void barBtnPrintGradeStu_ItemClick( object sender, ItemClickEventArgs e ) {

        }

        private void barBtnPrintRecieStu_ItemClick( object sender, ItemClickEventArgs e ) {

        }

        private void barBtnSearchStu_ItemClick( object sender, ItemClickEventArgs e ) {

        }
		
        private void barBtnUpdateTeacher_ItemClick( object sender, ItemClickEventArgs e) {
			frmTsk_UpdateTeacher aFrmTsk = new frmTsk_UpdateTeacher();
			aFrmTsk.Show();
			
        }

        private void barBtnPrintTeacher_ItemClick( object sender, ItemClickEventArgs e ) {
			frmTsk_DisplayInforTeacher aFrmTsk = new frmTsk_DisplayInforTeacher();
			aFrmTsk.Show();
        }

        private void barBtnExcuteSalary_ItemClick( object sender, ItemClickEventArgs e ) {
			frmTsk_SalaryTable aFrmTsk = new frmTsk_SalaryTable();
			aFrmTsk.Show();
        }

        private void barBtnSearchTeacher_ItemClick( object sender, ItemClickEventArgs e ) {

        }

        private void barBtnAddSubject_ItemClick( object sender, ItemClickEventArgs e ) {
			frmTsk_AddSubject aFrmTsk = new frmTsk_AddSubject();
			aFrmTsk.Show();
        }

        private void barBtnUpdateSubject_ItemClick( object sender, ItemClickEventArgs e ) {
			
			frmTsk_UpdateSubject aFrmTsk = new frmTsk_UpdateSubject();
			try
			{
				aFrmTsk.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

        private void barBtnPrintInforSubject_ItemClick( object sender, ItemClickEventArgs e ) {
			frmTsk_PrintInforSubject aFrmTsk = new frmTsk_PrintInforSubject();
			aFrmTsk.Show();
        }

        private void barBtnSearchSubject_ItemClick( object sender, ItemClickEventArgs e ) {

        }

        private void barBtnSearchFaculty_ItemClick( object sender, ItemClickEventArgs e ) {

        }

        private void barBtnPrintFaculty_ItemClick( object sender, ItemClickEventArgs e ) {

        }

        private void barBtnLearnRegister_ItemClick( object sender, ItemClickEventArgs e ) {

        }

        private void barBtnInsertGrade_ItemClick( object sender, ItemClickEventArgs e ) {

        }

        private void barBtnRankGrade_ItemClick( object sender, ItemClickEventArgs e ) {

        }

        private void barBtnRank_ItemClick( object sender, ItemClickEventArgs e ) {

        }

        private void barBtnStudentChallenge_ItemClick( object sender, ItemClickEventArgs e ) {

        }

        private void barBtnFeesOwe_ItemClick( object sender, ItemClickEventArgs e ) {

        }

        private void barBtnBan_ItemClick( object sender, ItemClickEventArgs e ) {

        }

        private void barBtnAverageGrade_ItemClick( object sender, ItemClickEventArgs e ) {

        }

        private void barBtnSubjectChart_ItemClick( object sender, ItemClickEventArgs e ) {

        }

        private void barBtnInforSystemUser_ItemClick( object sender, ItemClickEventArgs e ) {

		}
		
    }
}