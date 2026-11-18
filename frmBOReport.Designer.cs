
namespace POScreen
{
    partial class frmBOReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repStart = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.repEnd = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repWarehouse = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.txtCustomer = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repBrowse = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.vwFetchBCFReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwFetchPickOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.importFWRAuditLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.aSNMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSalesorder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFWROrderId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOSQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASRStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApiResponse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApiStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStart.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEnd.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repWarehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repBrowse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFetchBCFReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFetchPickOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importFWRAuditLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSNMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barEditItem2,
            this.barEditItem3,
            this.barButtonItem4});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 16;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repWarehouse,
            this.repStart,
            this.repEnd,
            this.txtCustomer,
            this.repBrowse});
            this.ribbon.Size = new System.Drawing.Size(1364, 200);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Refresh";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.SvgImage = global::POScreen.Properties.Resources.refreshallpivottable;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Close";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.SvgImage = global::POScreen.Properties.Resources.clearheaderandfooter;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Export To Excel";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.SvgImage = global::POScreen.Properties.Resources.export;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "Start  Date ";
            this.barEditItem2.Edit = this.repStart;
            this.barEditItem2.EditWidth = 120;
            this.barEditItem2.Id = 6;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // repStart
            // 
            this.repStart.AutoHeight = false;
            this.repStart.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repStart.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repStart.Name = "repStart";
            this.repStart.EditValueChanged += new System.EventHandler(this.repStart_EditValueChanged);
            // 
            // barEditItem3
            // 
            this.barEditItem3.Caption = "End Date    ";
            this.barEditItem3.Edit = this.repEnd;
            this.barEditItem3.EditWidth = 120;
            this.barEditItem3.Id = 7;
            this.barEditItem3.Name = "barEditItem3";
            // 
            // repEnd
            // 
            this.repEnd.AutoHeight = false;
            this.repEnd.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repEnd.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repEnd.Name = "repEnd";
            this.repEnd.EditValueChanged += new System.EventHandler(this.repEnd_EditValueChanged);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = ".";
            this.barButtonItem4.Id = 13;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barEditItem2);
            this.ribbonPageGroup3.ItemLinks.Add(this.barEditItem3);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup3.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.TwoRows;
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Filters";
            // 
            // repWarehouse
            // 
            this.repWarehouse.AutoHeight = false;
            this.repWarehouse.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repWarehouse.Name = "repWarehouse";
            this.repWarehouse.EditValueChanged += new System.EventHandler(this.repWarehouse_EditValueChanged);
            // 
            // txtCustomer
            // 
            this.txtCustomer.AutoHeight = false;
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.EditValueChanged += new System.EventHandler(this.txtCustomer_EditValueChanged);
            // 
            // repBrowse
            // 
            this.repBrowse.AutoHeight = false;
            editorButtonImageOptions2.Image = global::POScreen.Properties.Resources.find_32x32;
            serializableAppearanceObject5.Options.UseImage = true;
            this.repBrowse.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repBrowse.Name = "repBrowse";
            this.repBrowse.Click += new System.EventHandler(this.repBrowse_Click);
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 680);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1364, 41);
            // 
            // vwFetchBCFReportBindingSource
            // 
            this.vwFetchBCFReportBindingSource.DataSource = typeof(POScreen.DAL.vw_FetchBCFReport);
            // 
            // vwFetchPickOrderBindingSource
            // 
            this.vwFetchPickOrderBindingSource.DataSource = typeof(POScreen.DAL.vw_FetchPickOrder);
            // 
            // importFWRAuditLogBindingSource
            // 
            this.importFWRAuditLogBindingSource.DataSource = typeof(POScreen.ImportFWRAuditLog);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.aSNMasterBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 200);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1364, 480);
            this.gridControl1.TabIndex = 20;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // aSNMasterBindingSource
            // 
            this.aSNMasterBindingSource.DataSource = typeof(POScreen.ASNMaster);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSalesorder,
            this.colLine,
            this.colFWROrderId,
            this.colStockCode,
            this.colOrderQty,
            this.colShipQty,
            this.colOSQty,
            this.colASRStatus,
            this.gridColumn2,
            this.colApiResponse,
            this.colApiStatus,
            this.colCreatedDate,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colSalesorder
            // 
            this.colSalesorder.FieldName = "Salesorder";
            this.colSalesorder.MinWidth = 30;
            this.colSalesorder.Name = "colSalesorder";
            this.colSalesorder.Visible = true;
            this.colSalesorder.VisibleIndex = 0;
            this.colSalesorder.Width = 112;
            // 
            // colLine
            // 
            this.colLine.FieldName = "Line";
            this.colLine.MinWidth = 30;
            this.colLine.Name = "colLine";
            this.colLine.Visible = true;
            this.colLine.VisibleIndex = 1;
            this.colLine.Width = 112;
            // 
            // colFWROrderId
            // 
            this.colFWROrderId.FieldName = "FWROrderId";
            this.colFWROrderId.MinWidth = 30;
            this.colFWROrderId.Name = "colFWROrderId";
            this.colFWROrderId.Visible = true;
            this.colFWROrderId.VisibleIndex = 2;
            this.colFWROrderId.Width = 112;
            // 
            // colStockCode
            // 
            this.colStockCode.FieldName = "StockCode";
            this.colStockCode.MinWidth = 30;
            this.colStockCode.Name = "colStockCode";
            this.colStockCode.Visible = true;
            this.colStockCode.VisibleIndex = 3;
            this.colStockCode.Width = 112;
            // 
            // colOrderQty
            // 
            this.colOrderQty.FieldName = "OrderQty";
            this.colOrderQty.MinWidth = 30;
            this.colOrderQty.Name = "colOrderQty";
            this.colOrderQty.Visible = true;
            this.colOrderQty.VisibleIndex = 4;
            this.colOrderQty.Width = 112;
            // 
            // colShipQty
            // 
            this.colShipQty.FieldName = "ShipQty";
            this.colShipQty.MinWidth = 30;
            this.colShipQty.Name = "colShipQty";
            this.colShipQty.Visible = true;
            this.colShipQty.VisibleIndex = 5;
            this.colShipQty.Width = 112;
            // 
            // colOSQty
            // 
            this.colOSQty.FieldName = "OSQty";
            this.colOSQty.MinWidth = 30;
            this.colOSQty.Name = "colOSQty";
            this.colOSQty.Visible = true;
            this.colOSQty.VisibleIndex = 6;
            this.colOSQty.Width = 112;
            // 
            // colASRStatus
            // 
            this.colASRStatus.FieldName = "ASRStatus";
            this.colASRStatus.MinWidth = 30;
            this.colASRStatus.Name = "colASRStatus";
            this.colASRStatus.Visible = true;
            this.colASRStatus.VisibleIndex = 7;
            this.colASRStatus.Width = 112;
            // 
            // colApiResponse
            // 
            this.colApiResponse.FieldName = "ApiResponse";
            this.colApiResponse.MinWidth = 30;
            this.colApiResponse.Name = "colApiResponse";
            this.colApiResponse.Visible = true;
            this.colApiResponse.VisibleIndex = 10;
            this.colApiResponse.Width = 112;
            // 
            // colApiStatus
            // 
            this.colApiStatus.FieldName = "ApiStatus";
            this.colApiStatus.MinWidth = 30;
            this.colApiStatus.Name = "colApiStatus";
            this.colApiStatus.Visible = true;
            this.colApiStatus.VisibleIndex = 11;
            this.colApiStatus.Width = 112;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.DisplayFormat.FormatString = "dd-MM-yyyy HH:mm";
            this.colCreatedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCreatedDate.FieldName = "CreatedDate";
            this.colCreatedDate.MinWidth = 30;
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.Visible = true;
            this.colCreatedDate.VisibleIndex = 8;
            this.colCreatedDate.Width = 112;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Source";
            this.gridColumn1.FieldName = "Source";
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 12;
            this.gridColumn1.Width = 112;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "APIRequest";
            this.gridColumn2.FieldName = "APIRequest";
            this.gridColumn2.MinWidth = 30;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 9;
            this.gridColumn2.Width = 112;
            // 
            // frmBOReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 721);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "frmBOReport";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "ASN Logs";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmBOReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStart.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEnd.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repWarehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repBrowse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFetchBCFReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFetchPickOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importFWRAuditLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSNMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repWarehouse;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repStart;
        private DevExpress.XtraBars.BarEditItem barEditItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repEnd;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtCustomer;
        private System.Windows.Forms.BindingSource vwFetchBCFReportBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repBrowse;
        private System.Windows.Forms.BindingSource vwFetchPickOrderBindingSource;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private System.Windows.Forms.BindingSource importFWRAuditLogBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource aSNMasterBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesorder;
        private DevExpress.XtraGrid.Columns.GridColumn colLine;
        private DevExpress.XtraGrid.Columns.GridColumn colFWROrderId;
        private DevExpress.XtraGrid.Columns.GridColumn colStockCode;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderQty;
        private DevExpress.XtraGrid.Columns.GridColumn colShipQty;
        private DevExpress.XtraGrid.Columns.GridColumn colOSQty;
        private DevExpress.XtraGrid.Columns.GridColumn colASRStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colApiResponse;
        private DevExpress.XtraGrid.Columns.GridColumn colApiStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}