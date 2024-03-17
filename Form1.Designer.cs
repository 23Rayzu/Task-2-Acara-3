
namespace Working_with_DotSpatial_Symbology_and_Attribute_Table
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomExtentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splcMapLegend = new System.Windows.Forms.SplitContainer();
            this.legend1 = new DotSpatial.Controls.Legend();
            this.Map1 = new DotSpatial.Controls.DatelineCrossingMap();
            this.splcDataOperation = new System.Windows.Forms.SplitContainer();
            this.gbOperations = new System.Windows.Forms.GroupBox();
            this.lblPopulation = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtPopulation = new System.Windows.Forms.TextBox();
            this.btnFilterByPopulation = new System.Windows.Forms.Button();
            this.btnViewAttributes = new System.Windows.Forms.Button();
            this.btnRandomColors = new System.Windows.Forms.Button();
            this.btnFilterByPopState = new System.Windows.Forms.Button();
            this.btnFilterByStateName = new System.Windows.Forms.Button();
            this.btnDisplayStateName = new System.Windows.Forms.Button();
            this.dgvAttributeTable = new System.Windows.Forms.DataGridView();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splcMapLegend)).BeginInit();
            this.splcMapLegend.Panel1.SuspendLayout();
            this.splcMapLegend.Panel2.SuspendLayout();
            this.splcMapLegend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splcDataOperation)).BeginInit();
            this.splcDataOperation.Panel1.SuspendLayout();
            this.splcDataOperation.Panel2.SuspendLayout();
            this.splcDataOperation.SuspendLayout();
            this.gbOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttributeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.mapOperationsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMapToolStripMenuItem,
            this.clearMapToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "&File";
            this.fIleToolStripMenuItem.Click += new System.EventHandler(this.fIleToolStripMenuItem_Click);
            // 
            // loadMapToolStripMenuItem
            // 
            this.loadMapToolStripMenuItem.Name = "loadMapToolStripMenuItem";
            this.loadMapToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.loadMapToolStripMenuItem.Text = "&Load Map Ctrl+L";
            this.loadMapToolStripMenuItem.Click += new System.EventHandler(this.loadMapToolStripMenuItem_Click);
            // 
            // clearMapToolStripMenuItem
            // 
            this.clearMapToolStripMenuItem.Name = "clearMapToolStripMenuItem";
            this.clearMapToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.clearMapToolStripMenuItem.Text = "&Clear Map Ctrl+C";
            this.clearMapToolStripMenuItem.Click += new System.EventHandler(this.clearMapToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.exitToolStripMenuItem.Text = "&Exit Ctrl+E";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mapOperationsToolStripMenuItem
            // 
            this.mapOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.zoomExtentToolStripMenuItem});
            this.mapOperationsToolStripMenuItem.Name = "mapOperationsToolStripMenuItem";
            this.mapOperationsToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.mapOperationsToolStripMenuItem.Text = "&Map Operations";
            this.mapOperationsToolStripMenuItem.Click += new System.EventHandler(this.mapOperationsToolStripMenuItem_Click);
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.zoomInToolStripMenuItem.Text = "&Zoom In Ctrl+Up";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.zoomOutToolStripMenuItem.Text = "&Zoom Out Ctrl+Down";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // zoomExtentToolStripMenuItem
            // 
            this.zoomExtentToolStripMenuItem.Name = "zoomExtentToolStripMenuItem";
            this.zoomExtentToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.zoomExtentToolStripMenuItem.Text = "&Zoom Extent Ctrl+Z";
            this.zoomExtentToolStripMenuItem.Click += new System.EventHandler(this.zoomExtentToolStripMenuItem_Click);
            // 
            // splcMapLegend
            // 
            this.splcMapLegend.Dock = System.Windows.Forms.DockStyle.Top;
            this.splcMapLegend.Location = new System.Drawing.Point(0, 48);
            this.splcMapLegend.Name = "splcMapLegend";
            // 
            // splcMapLegend.Panel1
            // 
            this.splcMapLegend.Panel1.Controls.Add(this.legend1);
            // 
            // splcMapLegend.Panel2
            // 
            this.splcMapLegend.Panel2.Controls.Add(this.Map1);
            this.splcMapLegend.Size = new System.Drawing.Size(800, 235);
            this.splcMapLegend.SplitterDistance = 266;
            this.splcMapLegend.TabIndex = 2;
            // 
            // legend1
            // 
            this.legend1.BackColor = System.Drawing.Color.White;
            this.legend1.ControlRectangle = new System.Drawing.Rectangle(0, 0, 266, 235);
            this.legend1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.legend1.DocumentRectangle = new System.Drawing.Rectangle(0, 0, 187, 428);
            this.legend1.HorizontalScrollEnabled = true;
            this.legend1.Indentation = 30;
            this.legend1.IsInitialized = false;
            this.legend1.Location = new System.Drawing.Point(0, 0);
            this.legend1.MinimumSize = new System.Drawing.Size(5, 5);
            this.legend1.Name = "legend1";
            this.legend1.ProgressHandler = null;
            this.legend1.ResetOnResize = false;
            this.legend1.SelectionFontColor = System.Drawing.Color.Black;
            this.legend1.SelectionHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.legend1.Size = new System.Drawing.Size(266, 235);
            this.legend1.TabIndex = 0;
            this.legend1.Text = "legend1";
            this.legend1.UseLegendForSelection = true;
            this.legend1.VerticalScrollEnabled = true;
            // 
            // Map1
            // 
            this.Map1.AllowDrop = true;
            this.Map1.BackColor = System.Drawing.Color.White;
            this.Map1.CollisionDetection = false;
            this.Map1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Map1.ExtendBuffer = false;
            this.Map1.FunctionMode = DotSpatial.Controls.FunctionMode.Pan;
            this.Map1.IsBusy = false;
            this.Map1.IsZoomedToMaxExtent = false;
            this.Map1.Legend = this.legend1;
            this.Map1.Location = new System.Drawing.Point(0, 0);
            this.Map1.Name = "Map1";
            this.Map1.ProgressHandler = null;
            this.Map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.Map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.Map1.RedrawLayersWhileResizing = false;
            this.Map1.SelectionEnabled = true;
            this.Map1.Size = new System.Drawing.Size(530, 235);
            this.Map1.TabIndex = 0;
            this.Map1.ZoomOutFartherThanMaxExtent = false;
            // 
            // splcDataOperation
            // 
            this.splcDataOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splcDataOperation.Location = new System.Drawing.Point(0, 283);
            this.splcDataOperation.Name = "splcDataOperation";
            this.splcDataOperation.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splcDataOperation.Panel1
            // 
            this.splcDataOperation.Panel1.Controls.Add(this.gbOperations);
            // 
            // splcDataOperation.Panel2
            // 
            this.splcDataOperation.Panel2.Controls.Add(this.dgvAttributeTable);
            this.splcDataOperation.Size = new System.Drawing.Size(800, 182);
            this.splcDataOperation.SplitterDistance = 88;
            this.splcDataOperation.TabIndex = 3;
            // 
            // gbOperations
            // 
            this.gbOperations.Controls.Add(this.lblPopulation);
            this.gbOperations.Controls.Add(this.lblTitle);
            this.gbOperations.Controls.Add(this.txtPopulation);
            this.gbOperations.Controls.Add(this.btnFilterByPopulation);
            this.gbOperations.Controls.Add(this.btnViewAttributes);
            this.gbOperations.Controls.Add(this.btnRandomColors);
            this.gbOperations.Controls.Add(this.btnFilterByPopState);
            this.gbOperations.Controls.Add(this.btnFilterByStateName);
            this.gbOperations.Controls.Add(this.btnDisplayStateName);
            this.gbOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOperations.Location = new System.Drawing.Point(0, 0);
            this.gbOperations.Name = "gbOperations";
            this.gbOperations.Size = new System.Drawing.Size(800, 88);
            this.gbOperations.TabIndex = 0;
            this.gbOperations.TabStop = false;
            this.gbOperations.Text = "Operations";
            // 
            // lblPopulation
            // 
            this.lblPopulation.AutoSize = true;
            this.lblPopulation.Location = new System.Drawing.Point(436, 19);
            this.lblPopulation.Name = "lblPopulation";
            this.lblPopulation.Size = new System.Drawing.Size(190, 13);
            this.lblPopulation.TabIndex = 7;
            this.lblPopulation.Text = "Enter the amount of population in 1990";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(6, 72);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(101, 13);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Attribution Table";
            // 
            // txtPopulation
            // 
            this.txtPopulation.Location = new System.Drawing.Point(632, 16);
            this.txtPopulation.Name = "txtPopulation";
            this.txtPopulation.Size = new System.Drawing.Size(156, 20);
            this.txtPopulation.TabIndex = 6;
            // 
            // btnFilterByPopulation
            // 
            this.btnFilterByPopulation.Location = new System.Drawing.Point(628, 48);
            this.btnFilterByPopulation.Name = "btnFilterByPopulation";
            this.btnFilterByPopulation.Size = new System.Drawing.Size(160, 23);
            this.btnFilterByPopulation.TabIndex = 5;
            this.btnFilterByPopulation.Text = "Filter by amount of &population";
            this.btnFilterByPopulation.UseVisualStyleBackColor = true;
            // 
            // btnViewAttributes
            // 
            this.btnViewAttributes.Location = new System.Drawing.Point(529, 48);
            this.btnViewAttributes.Name = "btnViewAttributes";
            this.btnViewAttributes.Size = new System.Drawing.Size(93, 23);
            this.btnViewAttributes.TabIndex = 4;
            this.btnViewAttributes.Text = "View &Attributes";
            this.btnViewAttributes.UseVisualStyleBackColor = true;
            this.btnViewAttributes.Click += new System.EventHandler(this.btnViewAttributes_Click);
            // 
            // btnRandomColors
            // 
            this.btnRandomColors.Location = new System.Drawing.Point(328, 48);
            this.btnRandomColors.Name = "btnRandomColors";
            this.btnRandomColors.Size = new System.Drawing.Size(195, 23);
            this.btnRandomColors.TabIndex = 3;
            this.btnRandomColors.Text = "&Random colors based on State Name";
            this.btnRandomColors.UseVisualStyleBackColor = true;
            // 
            // btnFilterByPopState
            // 
            this.btnFilterByPopState.Location = new System.Drawing.Point(261, 16);
            this.btnFilterByPopState.Name = "btnFilterByPopState";
            this.btnFilterByPopState.Size = new System.Drawing.Size(169, 23);
            this.btnFilterByPopState.TabIndex = 2;
            this.btnFilterByPopState.Text = "Filter by &Population State Name";
            this.btnFilterByPopState.UseVisualStyleBackColor = true;
            this.btnFilterByPopState.Click += new System.EventHandler(this.btnFilterByPopState_Click);
            // 
            // btnFilterByStateName
            // 
            this.btnFilterByStateName.Location = new System.Drawing.Point(199, 48);
            this.btnFilterByStateName.Name = "btnFilterByStateName";
            this.btnFilterByStateName.Size = new System.Drawing.Size(123, 23);
            this.btnFilterByStateName.TabIndex = 1;
            this.btnFilterByStateName.Text = "Filter by &State Name";
            this.btnFilterByStateName.UseVisualStyleBackColor = true;
            // 
            // btnDisplayStateName
            // 
            this.btnDisplayStateName.Location = new System.Drawing.Point(142, 16);
            this.btnDisplayStateName.Name = "btnDisplayStateName";
            this.btnDisplayStateName.Size = new System.Drawing.Size(113, 23);
            this.btnDisplayStateName.TabIndex = 0;
            this.btnDisplayStateName.Text = "&Display State Name";
            this.btnDisplayStateName.UseVisualStyleBackColor = true;
            this.btnDisplayStateName.Click += new System.EventHandler(this.btnDisplayStateName_Click);
            // 
            // dgvAttributeTable
            // 
            this.dgvAttributeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttributeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAttributeTable.Location = new System.Drawing.Point(0, 0);
            this.dgvAttributeTable.Name = "dgvAttributeTable";
            this.dgvAttributeTable.Size = new System.Drawing.Size(800, 90);
            this.dgvAttributeTable.TabIndex = 0;
            this.dgvAttributeTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttributeTable_CellContentClick);
            this.dgvAttributeTable.SelectionChanged += new System.EventHandler(this.dgvAttributeTable_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.splcDataOperation);
            this.Controls.Add(this.splcMapLegend);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.splcMapLegend.Panel1.ResumeLayout(false);
            this.splcMapLegend.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splcMapLegend)).EndInit();
            this.splcMapLegend.ResumeLayout(false);
            this.splcDataOperation.Panel1.ResumeLayout(false);
            this.splcDataOperation.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splcDataOperation)).EndInit();
            this.splcDataOperation.ResumeLayout(false);
            this.gbOperations.ResumeLayout(false);
            this.gbOperations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttributeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomExtentToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splcMapLegend;
        private DotSpatial.Controls.Legend legend1;
        private DotSpatial.Controls.DatelineCrossingMap Map1;
        private System.Windows.Forms.SplitContainer splcDataOperation;
        private System.Windows.Forms.GroupBox gbOperations;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtPopulation;
        private System.Windows.Forms.Button btnFilterByPopulation;
        private System.Windows.Forms.Button btnViewAttributes;
        private System.Windows.Forms.Button btnRandomColors;
        private System.Windows.Forms.Button btnFilterByPopState;
        private System.Windows.Forms.Button btnFilterByStateName;
        private System.Windows.Forms.Button btnDisplayStateName;
        private System.Windows.Forms.DataGridView dgvAttributeTable;
        private System.Windows.Forms.Label lblPopulation;
    }
}

