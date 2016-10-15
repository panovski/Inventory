namespace Inventory_IT_DMM
{
    partial class Service
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Service));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.cbStillOnService = new System.Windows.Forms.CheckBox();
            this.lblServicer = new System.Windows.Forms.Label();
            this.tbServicer = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblDMMProp = new System.Windows.Forms.Label();
            this.tbDMMProperty = new System.Windows.Forms.TextBox();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.tbSerialNumber = new System.Windows.Forms.TextBox();
            this.gbCommands = new System.Windows.Forms.GroupBox();
            this.btnReturnService = new System.Windows.Forms.Button();
            this.btnSendService = new System.Windows.Forms.Button();
            this.lblSelectedRows = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblNoRows = new System.Windows.Forms.Label();
            this.Spliter = new System.Windows.Forms.GroupBox();
            this.gbPreview = new System.Windows.Forms.GroupBox();
            this.outlookGrid1 = new OutlookStyleControls.OutlookGrid();
            this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPreview = new System.Windows.Forms.DataGridView();
            this.cmsPrint = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miExportTable = new System.Windows.Forms.ToolStripMenuItem();
            this.miPrintReverseForm = new System.Windows.Forms.ToolStripMenuItem();
            this.miPrintAddress = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbCommands.SuspendLayout();
            this.gbPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outlookGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPreview)).BeginInit();
            this.cmsPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.cbStillOnService);
            this.gbFilter.Controls.Add(this.lblServicer);
            this.gbFilter.Controls.Add(this.tbServicer);
            this.gbFilter.Controls.Add(this.lblDescription);
            this.gbFilter.Controls.Add(this.tbDescription);
            this.gbFilter.Controls.Add(this.pictureBox1);
            this.gbFilter.Controls.Add(this.btnSearch);
            this.gbFilter.Controls.Add(this.lblDMMProp);
            this.gbFilter.Controls.Add(this.tbDMMProperty);
            this.gbFilter.Controls.Add(this.lblSerialNumber);
            this.gbFilter.Controls.Add(this.tbSerialNumber);
            this.gbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFilter.Location = new System.Drawing.Point(0, 0);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(789, 114);
            this.gbFilter.TabIndex = 5;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filters";
            // 
            // cbStillOnService
            // 
            this.cbStillOnService.AutoSize = true;
            this.cbStillOnService.Location = new System.Drawing.Point(201, 84);
            this.cbStillOnService.Name = "cbStillOnService";
            this.cbStillOnService.Size = new System.Drawing.Size(96, 17);
            this.cbStillOnService.TabIndex = 4;
            this.cbStillOnService.Text = "Still on Service";
            this.cbStillOnService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbStillOnService.UseVisualStyleBackColor = true;
            this.cbStillOnService.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Service_KeyPress);
            // 
            // lblServicer
            // 
            this.lblServicer.AutoSize = true;
            this.lblServicer.Location = new System.Drawing.Point(155, 64);
            this.lblServicer.Name = "lblServicer";
            this.lblServicer.Size = new System.Drawing.Size(46, 13);
            this.lblServicer.TabIndex = 24;
            this.lblServicer.Text = "Servicer";
            // 
            // tbServicer
            // 
            this.tbServicer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbServicer.Location = new System.Drawing.Point(201, 61);
            this.tbServicer.Name = "tbServicer";
            this.tbServicer.Size = new System.Drawing.Size(492, 20);
            this.tbServicer.TabIndex = 3;
            this.tbServicer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Service_KeyPress);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(141, 20);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 22;
            this.lblDescription.Text = "Description";
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.Location = new System.Drawing.Point(201, 17);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(492, 20);
            this.tbDescription.TabIndex = 0;
            this.tbDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Service_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSearch.Location = new System.Drawing.Point(700, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 25);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblDMMProp
            // 
            this.lblDMMProp.AutoSize = true;
            this.lblDMMProp.Location = new System.Drawing.Point(381, 42);
            this.lblDMMProp.Name = "lblDMMProp";
            this.lblDMMProp.Size = new System.Drawing.Size(89, 13);
            this.lblDMMProp.TabIndex = 5;
            this.lblDMMProp.Text = "DMM Prop. Num.";
            // 
            // tbDMMProperty
            // 
            this.tbDMMProperty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDMMProperty.Location = new System.Drawing.Point(476, 39);
            this.tbDMMProperty.Name = "tbDMMProperty";
            this.tbDMMProperty.Size = new System.Drawing.Size(217, 20);
            this.tbDMMProperty.TabIndex = 2;
            this.tbDMMProperty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Service_KeyPress);
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.Location = new System.Drawing.Point(128, 42);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(73, 13);
            this.lblSerialNumber.TabIndex = 3;
            this.lblSerialNumber.Text = "Serial Number";
            // 
            // tbSerialNumber
            // 
            this.tbSerialNumber.Location = new System.Drawing.Point(201, 39);
            this.tbSerialNumber.Name = "tbSerialNumber";
            this.tbSerialNumber.Size = new System.Drawing.Size(162, 20);
            this.tbSerialNumber.TabIndex = 1;
            this.tbSerialNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Service_KeyPress);
            // 
            // gbCommands
            // 
            this.gbCommands.Controls.Add(this.btnDeleteService);
            this.gbCommands.Controls.Add(this.btnReturnService);
            this.gbCommands.Controls.Add(this.btnSendService);
            this.gbCommands.Controls.Add(this.lblSelectedRows);
            this.gbCommands.Controls.Add(this.btnPrint);
            this.gbCommands.Controls.Add(this.lblNoRows);
            this.gbCommands.Controls.Add(this.Spliter);
            this.gbCommands.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbCommands.Location = new System.Drawing.Point(0, 428);
            this.gbCommands.Name = "gbCommands";
            this.gbCommands.Size = new System.Drawing.Size(789, 75);
            this.gbCommands.TabIndex = 7;
            this.gbCommands.TabStop = false;
            // 
            // btnReturnService
            // 
            this.btnReturnService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReturnService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReturnService.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnService.Image")));
            this.btnReturnService.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturnService.Location = new System.Drawing.Point(136, 35);
            this.btnReturnService.Name = "btnReturnService";
            this.btnReturnService.Size = new System.Drawing.Size(132, 31);
            this.btnReturnService.TabIndex = 1;
            this.btnReturnService.Text = "Return from service";
            this.btnReturnService.UseVisualStyleBackColor = true;
            this.btnReturnService.Click += new System.EventHandler(this.btnReturnService_Click);
            // 
            // btnSendService
            // 
            this.btnSendService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSendService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSendService.Image = ((System.Drawing.Image)(resources.GetObject("btnSendService.Image")));
            this.btnSendService.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendService.Location = new System.Drawing.Point(9, 35);
            this.btnSendService.Name = "btnSendService";
            this.btnSendService.Size = new System.Drawing.Size(121, 31);
            this.btnSendService.TabIndex = 0;
            this.btnSendService.Text = "Send on service";
            this.btnSendService.UseVisualStyleBackColor = true;
            this.btnSendService.Click += new System.EventHandler(this.btnSendService_Click);
            // 
            // lblSelectedRows
            // 
            this.lblSelectedRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectedRows.AutoSize = true;
            this.lblSelectedRows.Location = new System.Drawing.Point(656, 10);
            this.lblSelectedRows.Name = "lblSelectedRows";
            this.lblSelectedRows.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedRows.TabIndex = 24;
            this.lblSelectedRows.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.Location = new System.Drawing.Point(274, 35);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(86, 31);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // lblNoRows
            // 
            this.lblNoRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoRows.AutoSize = true;
            this.lblNoRows.Location = new System.Drawing.Point(574, 9);
            this.lblNoRows.Name = "lblNoRows";
            this.lblNoRows.Size = new System.Drawing.Size(0, 13);
            this.lblNoRows.TabIndex = 13;
            this.lblNoRows.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Spliter
            // 
            this.Spliter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Spliter.Location = new System.Drawing.Point(4, 19);
            this.Spliter.Name = "Spliter";
            this.Spliter.Size = new System.Drawing.Size(782, 10);
            this.Spliter.TabIndex = 12;
            this.Spliter.TabStop = false;
            // 
            // gbPreview
            // 
            this.gbPreview.Controls.Add(this.outlookGrid1);
            this.gbPreview.Controls.Add(this.gvPreview);
            this.gbPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPreview.Location = new System.Drawing.Point(0, 114);
            this.gbPreview.Name = "gbPreview";
            this.gbPreview.Size = new System.Drawing.Size(789, 314);
            this.gbPreview.TabIndex = 8;
            this.gbPreview.TabStop = false;
            // 
            // outlookGrid1
            // 
            this.outlookGrid1.AllowUserToAddRows = false;
            this.outlookGrid1.AllowUserToDeleteRows = false;
            this.outlookGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outlookGrid1.CollapseIcon = ((System.Drawing.Image)(resources.GetObject("outlookGrid1.CollapseIcon")));
            this.outlookGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemId});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.outlookGrid1.DefaultCellStyle = dataGridViewCellStyle1;
            this.outlookGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outlookGrid1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.outlookGrid1.ExpandIcon = ((System.Drawing.Image)(resources.GetObject("outlookGrid1.ExpandIcon")));
            this.outlookGrid1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.outlookGrid1.Location = new System.Drawing.Point(3, 16);
            this.outlookGrid1.Name = "outlookGrid1";
            this.outlookGrid1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.outlookGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.outlookGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.outlookGrid1.Size = new System.Drawing.Size(783, 295);
            this.outlookGrid1.TabIndex = 0;
            // 
            // ItemId
            // 
            this.ItemId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ItemId.DataPropertyName = "ItemId";
            this.ItemId.HeaderText = "ItemId";
            this.ItemId.Name = "ItemId";
            this.ItemId.ReadOnly = true;
            this.ItemId.Visible = false;
            // 
            // gvPreview
            // 
            this.gvPreview.AllowUserToAddRows = false;
            this.gvPreview.AllowUserToDeleteRows = false;
            this.gvPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvPreview.Location = new System.Drawing.Point(3, 16);
            this.gvPreview.Name = "gvPreview";
            this.gvPreview.ReadOnly = true;
            this.gvPreview.Size = new System.Drawing.Size(783, 295);
            this.gvPreview.TabIndex = 0;
            // 
            // cmsPrint
            // 
            this.cmsPrint.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miExportTable,
            this.miPrintReverseForm,
            this.miPrintAddress});
            this.cmsPrint.Name = "cmsItemAction";
            this.cmsPrint.Size = new System.Drawing.Size(174, 70);
            // 
            // miExportTable
            // 
            this.miExportTable.Image = ((System.Drawing.Image)(resources.GetObject("miExportTable.Image")));
            this.miExportTable.Name = "miExportTable";
            this.miExportTable.Size = new System.Drawing.Size(173, 22);
            this.miExportTable.Text = "Export Table";
            this.miExportTable.Click += new System.EventHandler(this.miExportTable_Click);
            // 
            // miPrintReverseForm
            // 
            this.miPrintReverseForm.Image = ((System.Drawing.Image)(resources.GetObject("miPrintReverseForm.Image")));
            this.miPrintReverseForm.Name = "miPrintReverseForm";
            this.miPrintReverseForm.Size = new System.Drawing.Size(173, 22);
            this.miPrintReverseForm.Text = "Print Reverse Form";
            this.miPrintReverseForm.Click += new System.EventHandler(this.miPrintReverseForm_Click);
            // 
            // miPrintAddress
            // 
            this.miPrintAddress.Image = ((System.Drawing.Image)(resources.GetObject("miPrintAddress.Image")));
            this.miPrintAddress.Name = "miPrintAddress";
            this.miPrintAddress.Size = new System.Drawing.Size(173, 22);
            this.miPrintAddress.Text = "Print Address";
            this.miPrintAddress.Click += new System.EventHandler(this.miPrintAddress_Click);
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteService.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteService.Image")));
            this.btnDeleteService.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteService.Location = new System.Drawing.Point(697, 35);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(86, 31);
            this.btnDeleteService.TabIndex = 26;
            this.btnDeleteService.Text = "Delete";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 503);
            this.Controls.Add(this.gbPreview);
            this.Controls.Add(this.gbCommands);
            this.Controls.Add(this.gbFilter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Service";
            this.Text = "Service Preview";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Service_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Service_KeyPress);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbCommands.ResumeLayout(false);
            this.gbCommands.PerformLayout();
            this.gbPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outlookGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPreview)).EndInit();
            this.cmsPrint.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblDMMProp;
        private System.Windows.Forms.TextBox tbDMMProperty;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.TextBox tbSerialNumber;
        private System.Windows.Forms.Label lblServicer;
        private System.Windows.Forms.TextBox tbServicer;
        private System.Windows.Forms.CheckBox cbStillOnService;
        private System.Windows.Forms.GroupBox gbCommands;
        private System.Windows.Forms.Button btnReturnService;
        private System.Windows.Forms.Button btnSendService;
        private System.Windows.Forms.Label lblSelectedRows;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblNoRows;
        private System.Windows.Forms.GroupBox Spliter;
        private System.Windows.Forms.GroupBox gbPreview;
        private OutlookStyleControls.OutlookGrid outlookGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
        private System.Windows.Forms.DataGridView gvPreview;
        private System.Windows.Forms.ContextMenuStrip cmsPrint;
        private System.Windows.Forms.ToolStripMenuItem miExportTable;
        private System.Windows.Forms.ToolStripMenuItem miPrintReverseForm;
        private System.Windows.Forms.ToolStripMenuItem miPrintAddress;
        private System.Windows.Forms.Button btnDeleteService;
    }
}