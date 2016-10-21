namespace MapMonitor
{
    partial class frmMonitor
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonitor));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ttMsg = new System.Windows.Forms.ToolTip(this.components);
            this.tipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.tmrDelay = new System.Windows.Forms.Timer(this.components);
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.pnlCase = new System.Windows.Forms.Panel();
            this.pnlList = new DevExpress.XtraEditors.PanelControl();
            this.lstTree = new DevExpress.XtraTreeList.TreeList();
            this.colTree = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colKey = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colLevel = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.pnlSearch = new DevExpress.XtraEditors.PanelControl();
            this.txtSearch = new DevExpress.XtraEditors.SearchControl();
            this.lblSearch = new DevExpress.XtraEditors.LabelControl();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.pnlTitle = new DevExpress.XtraEditors.PanelControl();
            this.picTitle = new DevExpress.XtraEditors.PictureEdit();
            this.mnuBusInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuItemSendAudio = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSpBus = new System.Windows.Forms.ToolStripSeparator();
            this.mnuItemRemoveBus = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAll = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuItemShowAllUp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemHideAllUp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemShowAllDown = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemHideAllDown = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSpAll = new System.Windows.Forms.ToolStripSeparator();
            this.mnuItemSendAudio1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSpAll2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuItemAddGrp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLineInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuItemShowUpLine = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemHideUpLine = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemShowDownLine = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemHideDownLine = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemShowLineInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSpLine = new System.Windows.Forms.ToolStripSeparator();
            this.mnuItemSendAudio2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSpLine2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuItemEditGrp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemDelGrp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAddBus = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.xtraScrollableControl1.SuspendLayout();
            this.pnlCase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlList)).BeginInit();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitle)).BeginInit();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle.Properties)).BeginInit();
            this.mnuBusInfo.SuspendLayout();
            this.mnuAll.SuspendLayout();
            this.mnuLineInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "项目2.ico");
            this.imageList1.Images.SetKeyName(1, "Bus.png");
            this.imageList1.Images.SetKeyName(2, "Bus1.png");
            this.imageList1.Images.SetKeyName(3, "Bus2.png");
            this.imageList1.Images.SetKeyName(4, "Bus3.png");
            this.imageList1.Images.SetKeyName(5, "透明.png");
            // 
            // tmrDelay
            // 
            this.tmrDelay.Interval = 5000;
            this.tmrDelay.Tick += new System.EventHandler(this.tmrDelay_Tick);
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xtraScrollableControl1.Appearance.Options.UseBorderColor = true;
            this.xtraScrollableControl1.Controls.Add(this.pnlCase);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(944, 561);
            this.xtraScrollableControl1.TabIndex = 3;
            // 
            // pnlCase
            // 
            this.pnlCase.Controls.Add(this.pnlList);
            this.pnlCase.Controls.Add(this.pnlSearch);
            this.pnlCase.Controls.Add(this.gmap);
            this.pnlCase.Controls.Add(this.pnlTitle);
            this.pnlCase.Location = new System.Drawing.Point(0, 0);
            this.pnlCase.Name = "pnlCase";
            this.pnlCase.Size = new System.Drawing.Size(944, 561);
            this.pnlCase.TabIndex = 14;
            // 
            // pnlList
            // 
            this.pnlList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlList.Appearance.BackColor = System.Drawing.Color.White;
            this.pnlList.Appearance.Options.UseBackColor = true;
            this.pnlList.Controls.Add(this.panel1);
            this.pnlList.Location = new System.Drawing.Point(752, 56);
            this.pnlList.LookAndFeel.SkinName = "Office 2013";
            this.pnlList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(180, 450);
            this.pnlList.TabIndex = 15;
            // 
            // lstTree
            // 
            this.lstTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTree.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.Highlight;
            this.lstTree.Appearance.FocusedCell.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTree.Appearance.FocusedCell.Options.UseBackColor = true;
            this.lstTree.Appearance.FocusedCell.Options.UseFont = true;
            this.lstTree.Appearance.FocusedRow.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTree.Appearance.FocusedRow.Options.UseFont = true;
            this.lstTree.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.lstTree.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.lstTree.Appearance.Row.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTree.Appearance.Row.Options.UseFont = true;
            this.lstTree.Appearance.SelectedRow.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTree.Appearance.SelectedRow.Options.UseFont = true;
            this.lstTree.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lstTree.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colTree,
            this.colKey,
            this.colLevel});
            this.lstTree.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstTree.Location = new System.Drawing.Point(0, -21);
            this.lstTree.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lstTree.Name = "lstTree";
            this.lstTree.OptionsBehavior.Editable = false;
            this.lstTree.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.None;
            this.lstTree.OptionsView.ShowCheckBoxes = true;
            this.lstTree.OptionsView.ShowHorzLines = false;
            this.lstTree.OptionsView.ShowIndicator = false;
            this.lstTree.OptionsView.ShowVertLines = false;
            this.lstTree.Size = new System.Drawing.Size(174, 465);
            this.lstTree.StateImageList = this.imageList1;
            this.lstTree.TabIndex = 13;
            this.lstTree.BeforeCheckNode += new DevExpress.XtraTreeList.CheckNodeEventHandler(this.lstTree_BeforeCheckNode);
            this.lstTree.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.lstTree_AfterCheckNode);
            this.lstTree.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.lstTree_CustomDrawNodeCell);
            this.lstTree.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstTree_MouseDoubleClick);
            this.lstTree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstTree_MouseDown);
            // 
            // colTree
            // 
            this.colTree.AppearanceHeader.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTree.AppearanceHeader.Options.UseFont = true;
            this.colTree.Caption = "车辆";
            this.colTree.FieldName = "BUSNUMBER";
            this.colTree.MinWidth = 52;
            this.colTree.Name = "colTree";
            this.colTree.Visible = true;
            this.colTree.VisibleIndex = 0;
            // 
            // colKey
            // 
            this.colKey.Caption = "ID";
            this.colKey.FieldName = "Key";
            this.colKey.Name = "colKey";
            // 
            // colLevel
            // 
            this.colLevel.Caption = "Level";
            this.colLevel.FieldName = "Level";
            this.colLevel.Name = "colLevel";
            // 
            // pnlSearch
            // 
            this.pnlSearch.Appearance.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Appearance.Options.UseBackColor = true;
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Location = new System.Drawing.Point(8, 56);
            this.pnlSearch.LookAndFeel.SkinName = "Office 2013";
            this.pnlSearch.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(300, 60);
            this.pnlSearch.TabIndex = 14;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(82, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Properties.Appearance.Options.UseFont = true;
            this.txtSearch.Properties.AppearanceDropDown.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Properties.AppearanceDropDown.Options.UseFont = true;
            this.txtSearch.Properties.AppearanceFocused.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.txtSearch.Properties.LookAndFeel.SkinName = "VS2010";
            this.txtSearch.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtSearch.Size = new System.Drawing.Size(200, 24);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // lblSearch
            // 
            this.lblSearch.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(16, 24);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(60, 17);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "快速定位：";
            // 
            // gmap
            // 
            this.gmap.BackColor = System.Drawing.Color.SteelBlue;
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(0, 48);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 6;
            this.gmap.MinZoom = 6;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(944, 513);
            this.gmap.TabIndex = 2;
            this.gmap.Zoom = 0D;
            this.gmap.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.gmap_OnMapZoomChanged);
            // 
            // pnlTitle
            // 
            this.pnlTitle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.pnlTitle.Appearance.Options.UseBackColor = true;
            this.pnlTitle.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlTitle.Controls.Add(this.picTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(944, 48);
            this.pnlTitle.TabIndex = 13;
            // 
            // picTitle
            // 
            this.picTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.picTitle.EditValue = ((object)(resources.GetObject("picTitle.EditValue")));
            this.picTitle.Location = new System.Drawing.Point(12, 12);
            this.picTitle.Name = "picTitle";
            this.picTitle.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picTitle.Properties.Appearance.Options.UseBackColor = true;
            this.picTitle.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picTitle.Properties.ZoomAccelerationFactor = 1D;
            this.picTitle.Size = new System.Drawing.Size(304, 27);
            this.picTitle.TabIndex = 0;
            // 
            // mnuBusInfo
            // 
            this.mnuBusInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemSendAudio,
            this.toolStripSpBus,
            this.mnuItemRemoveBus});
            this.mnuBusInfo.Name = "contextMenuStripBusInfo";
            this.mnuBusInfo.Size = new System.Drawing.Size(185, 54);
            // 
            // mnuItemSendAudio
            // 
            this.mnuItemSendAudio.Name = "mnuItemSendAudio";
            this.mnuItemSendAudio.Size = new System.Drawing.Size(184, 22);
            this.mnuItemSendAudio.Text = "语音下发（单辆车）";
            this.mnuItemSendAudio.Click += new System.EventHandler(this.mnuItemSendAudio_Click);
            // 
            // toolStripSpBus
            // 
            this.toolStripSpBus.Name = "toolStripSpBus";
            this.toolStripSpBus.Size = new System.Drawing.Size(181, 6);
            // 
            // mnuItemRemoveBus
            // 
            this.mnuItemRemoveBus.Name = "mnuItemRemoveBus";
            this.mnuItemRemoveBus.Size = new System.Drawing.Size(184, 22);
            this.mnuItemRemoveBus.Text = "移除车辆";
            this.mnuItemRemoveBus.Click += new System.EventHandler(this.mnuItemRemoveBus_Click);
            // 
            // mnuAll
            // 
            this.mnuAll.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemShowAllUp,
            this.mnuItemHideAllUp,
            this.mnuItemShowAllDown,
            this.mnuItemHideAllDown,
            this.toolStripSpAll,
            this.mnuItemSendAudio1,
            this.toolStripSpAll2,
            this.mnuItemAddGrp});
            this.mnuAll.Name = "contextMenuStripAll";
            this.mnuAll.Size = new System.Drawing.Size(197, 148);
            // 
            // mnuItemShowAllUp
            // 
            this.mnuItemShowAllUp.Name = "mnuItemShowAllUp";
            this.mnuItemShowAllUp.Size = new System.Drawing.Size(196, 22);
            this.mnuItemShowAllUp.Text = "显示所有上行线路";
            this.mnuItemShowAllUp.Click += new System.EventHandler(this.mnuItemShowAllUp_Click);
            // 
            // mnuItemHideAllUp
            // 
            this.mnuItemHideAllUp.Name = "mnuItemHideAllUp";
            this.mnuItemHideAllUp.Size = new System.Drawing.Size(196, 22);
            this.mnuItemHideAllUp.Text = "隐藏所有上行线路";
            this.mnuItemHideAllUp.Click += new System.EventHandler(this.mnuItemHideAllUp_Click);
            // 
            // mnuItemShowAllDown
            // 
            this.mnuItemShowAllDown.Name = "mnuItemShowAllDown";
            this.mnuItemShowAllDown.Size = new System.Drawing.Size(196, 22);
            this.mnuItemShowAllDown.Text = "显示所有下行线路";
            this.mnuItemShowAllDown.Click += new System.EventHandler(this.mnuItemShowAllDown_Click);
            // 
            // mnuItemHideAllDown
            // 
            this.mnuItemHideAllDown.Name = "mnuItemHideAllDown";
            this.mnuItemHideAllDown.Size = new System.Drawing.Size(196, 22);
            this.mnuItemHideAllDown.Text = "隐藏所有下行线路";
            this.mnuItemHideAllDown.Click += new System.EventHandler(this.mnuItemHideAllDown_Click);
            // 
            // toolStripSpAll
            // 
            this.toolStripSpAll.Name = "toolStripSpAll";
            this.toolStripSpAll.Size = new System.Drawing.Size(193, 6);
            // 
            // mnuItemSendAudio1
            // 
            this.mnuItemSendAudio1.Name = "mnuItemSendAudio1";
            this.mnuItemSendAudio1.Size = new System.Drawing.Size(196, 22);
            this.mnuItemSendAudio1.Text = "语音下发（选择车辆）";
            this.mnuItemSendAudio1.Click += new System.EventHandler(this.mnuItemSendAudio1_Click);
            // 
            // toolStripSpAll2
            // 
            this.toolStripSpAll2.Name = "toolStripSpAll2";
            this.toolStripSpAll2.Size = new System.Drawing.Size(193, 6);
            // 
            // mnuItemAddGrp
            // 
            this.mnuItemAddGrp.Name = "mnuItemAddGrp";
            this.mnuItemAddGrp.Size = new System.Drawing.Size(196, 22);
            this.mnuItemAddGrp.Text = "添加分组";
            this.mnuItemAddGrp.Click += new System.EventHandler(this.mnuItemAddGrp_Click);
            // 
            // mnuLineInfo
            // 
            this.mnuLineInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemShowUpLine,
            this.mnuItemHideUpLine,
            this.mnuItemShowDownLine,
            this.mnuItemHideDownLine,
            this.mnuItemShowLineInfo,
            this.toolStripSpLine,
            this.mnuItemSendAudio2,
            this.toolStripSpLine2,
            this.mnuItemEditGrp,
            this.mnuItemDelGrp,
            this.mnuItemAddBus});
            this.mnuLineInfo.Name = "contextMenuStripLineInfo";
            this.mnuLineInfo.Size = new System.Drawing.Size(197, 214);
            // 
            // mnuItemShowUpLine
            // 
            this.mnuItemShowUpLine.Name = "mnuItemShowUpLine";
            this.mnuItemShowUpLine.Size = new System.Drawing.Size(196, 22);
            this.mnuItemShowUpLine.Text = "显示上行线路";
            this.mnuItemShowUpLine.Click += new System.EventHandler(this.mnuItemShowUpLine_Click);
            // 
            // mnuItemHideUpLine
            // 
            this.mnuItemHideUpLine.Name = "mnuItemHideUpLine";
            this.mnuItemHideUpLine.Size = new System.Drawing.Size(196, 22);
            this.mnuItemHideUpLine.Text = "隐藏上行线路";
            this.mnuItemHideUpLine.Click += new System.EventHandler(this.mnuItemHideUpLine_Click);
            // 
            // mnuItemShowDownLine
            // 
            this.mnuItemShowDownLine.Name = "mnuItemShowDownLine";
            this.mnuItemShowDownLine.Size = new System.Drawing.Size(196, 22);
            this.mnuItemShowDownLine.Text = "显示下行线路";
            this.mnuItemShowDownLine.Click += new System.EventHandler(this.mnuItemShowDownLine_Click);
            // 
            // mnuItemHideDownLine
            // 
            this.mnuItemHideDownLine.Name = "mnuItemHideDownLine";
            this.mnuItemHideDownLine.Size = new System.Drawing.Size(196, 22);
            this.mnuItemHideDownLine.Text = "隐藏下行线路";
            this.mnuItemHideDownLine.Click += new System.EventHandler(this.mnuItemHideDownLine_Click);
            // 
            // mnuItemShowLineInfo
            // 
            this.mnuItemShowLineInfo.Name = "mnuItemShowLineInfo";
            this.mnuItemShowLineInfo.Size = new System.Drawing.Size(196, 22);
            this.mnuItemShowLineInfo.Text = "线路信息";
            // 
            // toolStripSpLine
            // 
            this.toolStripSpLine.Name = "toolStripSpLine";
            this.toolStripSpLine.Size = new System.Drawing.Size(193, 6);
            // 
            // mnuItemSendAudio2
            // 
            this.mnuItemSendAudio2.Name = "mnuItemSendAudio2";
            this.mnuItemSendAudio2.Size = new System.Drawing.Size(196, 22);
            this.mnuItemSendAudio2.Text = "语音下发（线路车辆）";
            this.mnuItemSendAudio2.Click += new System.EventHandler(this.mnuItemSendAudio2_Click);
            // 
            // toolStripSpLine2
            // 
            this.toolStripSpLine2.Name = "toolStripSpLine2";
            this.toolStripSpLine2.Size = new System.Drawing.Size(193, 6);
            // 
            // mnuItemEditGrp
            // 
            this.mnuItemEditGrp.Name = "mnuItemEditGrp";
            this.mnuItemEditGrp.Size = new System.Drawing.Size(196, 22);
            this.mnuItemEditGrp.Text = "编辑分组";
            this.mnuItemEditGrp.Click += new System.EventHandler(this.mnuItemEditGrp_Click);
            // 
            // mnuItemDelGrp
            // 
            this.mnuItemDelGrp.Name = "mnuItemDelGrp";
            this.mnuItemDelGrp.Size = new System.Drawing.Size(196, 22);
            this.mnuItemDelGrp.Text = "删除分组";
            this.mnuItemDelGrp.Click += new System.EventHandler(this.mnuItemDelGrp_Click);
            // 
            // mnuItemAddBus
            // 
            this.mnuItemAddBus.Name = "mnuItemAddBus";
            this.mnuItemAddBus.Size = new System.Drawing.Size(196, 22);
            this.mnuItemAddBus.Text = "添加车辆";
            this.mnuItemAddBus.Click += new System.EventHandler(this.mnuItemAddBus_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstTree);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 446);
            this.panel1.TabIndex = 16;
            // 
            // frmMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "frmMonitor";
            this.Text = "地图监控";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMonitor_FormClosing);
            this.Load += new System.EventHandler(this.frmMonitor_Load);
            this.SizeChanged += new System.EventHandler(this.frmMonitor_SizeChanged);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.pnlCase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlList)).EndInit();
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSearch)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitle)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTitle.Properties)).EndInit();
            this.mnuBusInfo.ResumeLayout(false);
            this.mnuAll.ResumeLayout(false);
            this.mnuLineInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip ttMsg;
        private System.Windows.Forms.ToolTip tipInfo;
        private System.Windows.Forms.Timer tmrDelay;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private System.Windows.Forms.ContextMenuStrip mnuBusInfo;
        private System.Windows.Forms.ToolStripMenuItem mnuItemSendAudio;
        private System.Windows.Forms.ToolStripSeparator toolStripSpBus;
        private System.Windows.Forms.ToolStripMenuItem mnuItemRemoveBus;
        private System.Windows.Forms.ContextMenuStrip mnuAll;
        private System.Windows.Forms.ToolStripMenuItem mnuItemShowAllUp;
        private System.Windows.Forms.ToolStripMenuItem mnuItemShowAllDown;
        private System.Windows.Forms.ToolStripMenuItem mnuItemHideAllUp;
        private System.Windows.Forms.ToolStripMenuItem mnuItemHideAllDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSpAll;
        private System.Windows.Forms.ToolStripMenuItem mnuItemSendAudio1;
        private System.Windows.Forms.ToolStripSeparator toolStripSpAll2;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAddGrp;
        private System.Windows.Forms.ContextMenuStrip mnuLineInfo;
        private System.Windows.Forms.ToolStripMenuItem mnuItemShowUpLine;
        private System.Windows.Forms.ToolStripMenuItem mnuItemHideUpLine;
        private System.Windows.Forms.ToolStripMenuItem mnuItemShowDownLine;
        private System.Windows.Forms.ToolStripMenuItem mnuItemHideDownLine;
        private System.Windows.Forms.ToolStripMenuItem mnuItemShowLineInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSpLine;
        private System.Windows.Forms.ToolStripMenuItem mnuItemSendAudio2;
        private System.Windows.Forms.ToolStripSeparator toolStripSpLine2;
        private System.Windows.Forms.ToolStripMenuItem mnuItemEditGrp;
        private System.Windows.Forms.ToolStripMenuItem mnuItemDelGrp;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAddBus;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private DevExpress.XtraEditors.PanelControl pnlTitle;
        private DevExpress.XtraEditors.PictureEdit picTitle;
        private System.Windows.Forms.Panel pnlCase;
        private DevExpress.XtraEditors.PanelControl pnlSearch;
        private DevExpress.XtraEditors.SearchControl txtSearch;
        private DevExpress.XtraEditors.LabelControl lblSearch;
        private DevExpress.XtraEditors.PanelControl pnlList;
        private DevExpress.XtraTreeList.TreeList lstTree;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colTree;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colKey;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colLevel;
        private System.Windows.Forms.Panel panel1;
    }
}

