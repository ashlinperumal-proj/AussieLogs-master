using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POScreen.DAL;
using DevExpress.XtraEditors;
using System.Globalization;

namespace POScreen
{
    public partial class frmBOReport : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmBOReport()
        {
            InitializeComponent();
        }

        private void frmBOReport_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
           
            filldata();
        }
        private void filldata()
        {
            AppUtility.UI.Notification.ShowWaitForm(this, "Please wait");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            List<ASNMaster> listvw_FetchCusSorMaster;
            using (var context = new AussieTravellerCompanyNEntities())
            {
                //  var porLst = context.Logins.ToList();
                listvw_FetchCusSorMaster = new List<ASNMaster>();
                // listvw_FetchCusSorMaster = context.ImportFWRAuditLogs.ToList();

                if (startdate.Year != 1 && enddate.Year != 1)
                {
                    enddate = enddate.AddHours(23);
                    listvw_FetchCusSorMaster = context.ASNMasters.Where(c => c.CreatedDate >= startdate && c.CreatedDate <= enddate).ToList();
                }
                
                aSNMasterBindingSource.DataSource = listvw_FetchCusSorMaster;
            }
            watch.Stop();
            LogWriter.LogWrite("Fetching Data From " + startdate + " To " + enddate, "Time taken: " + watch.Elapsed.TotalSeconds + " s", "");
            AppUtility.UI.Notification.CloseWaitForm();
        }
        private void bindWarehouse()
        {
            
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                
                    gridView1.ExportToXlsx(folderBrowserDialog.SelectedPath + "/ASNLogs.xlsx");
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            filldata();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }
        string warehouse = "40";
        string customer = "";
        DateTime startdate;
        DateTime enddate;
        private void repWarehouse_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void repStart_EditValueChanged(object sender, EventArgs e)
        {
            DateEdit rep = (DateEdit)sender;
            if (rep.EditValue != null)
                startdate = (DateTime)rep.EditValue;
            //bindWarehouse();
            filldata();
        }

        private void repEnd_EditValueChanged(object sender, EventArgs e)
        {
            DateEdit rep = (DateEdit)sender;
            enddate = (DateTime)rep.EditValue;
           // bindWarehouse();
            filldata();
        }

        private void txtCustomer_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void barEditItem4_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void repBrowse_Click(object sender, EventArgs e)
        {
            
        }

        private void barCheckItem1_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            
        }

        private void chkShip_CheckedChanged(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void repExclude_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }
    }
}