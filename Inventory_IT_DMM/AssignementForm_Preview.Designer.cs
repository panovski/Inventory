namespace Inventory_IT_DMM
{
    partial class AssignementForm_Preview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignementForm_Preview));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.lblAssignementNumber = new System.Windows.Forms.Label();
            this.tbAssignementNumber = new System.Windows.Forms.TextBox();
            this.tbAssignedToDep = new System.Windows.Forms.TextBox();
            this.cbAssignedToDep = new System.Windows.Forms.ComboBox();
            this.lblAssignedToDep = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblAssignedTo = new System.Windows.Forms.Label();
            this.tbAssignedTo = new System.Windows.Forms.TextBox();
            this.lblDMMProp = new System.Windows.Forms.Label();
            this.tbDMMProperty = new System.Windows.Forms.TextBox();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.tbSerialNumber = new System.Windows.Forms.TextBox();
            this.gbCommands = new System.Windows.Forms.GroupBox();
            this.btnDeleteAssignment = new System.Windows.Forms.Button();
            this.lblSelectedRows = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblNoRows = new System.Windows.Forms.Label();
            this.Spliter = new System.Windows.Forms.GroupBox();
            this.gbPreview = new System.Windows.Forms.GroupBox();
            this.outlookGrid1 = new OutlookStyleControls.OutlookGrid();
            this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPreview = new System.Windows.Forms.DataGridView();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbCommands.SuspendLayout();
            this.gbPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outlookGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.lblAssignementNumber);
            this.gbFilter.Controls.Add(this.tbAssignementNumber);
            this.gbFilter.Controls.Add(this.tbAssignedToDep);
            this.gbFilter.Controls.Add(this.cbAssignedToDep);
            this.gbFilter.Controls.Add(this.lblAssignedToDep);
            this.gbFilter.Controls.Add(this.pictureBox1);
            this.gbFilter.Controls.Add(this.btnSearch);
            this.gbFilter.Controls.Add(this.lblAssignedTo);
            this.gbFilter.Controls.Add(this.tbAssignedTo);
            this.gbFilter.Controls.Add(this.lblDMMProp);
            this.gbFilter.Controls.Add(this.tbDMMProperty);
            this.gbFilter.Controls.Add(this.lblSerialNumber);
            this.gbFilter.Controls.Add(this.tbSerialNumber);
            this.gbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFilter.Location = new System.Drawing.Point(0, 0);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(774, 91);
            this.gbFilter.TabIndex = 3;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filters";
            // 
            // lblAssignementNumber
            // 
            this.lblAssignementNumber.AutoSize = true;
            this.lblAssignementNumber.Location = new System.Drawing.Point(94, 20);
            this.lblAssignementNumber.Name = "lblAssignementNumber";
            this.lblAssignementNumber.Size = new System.Drawing.Size(101, 13);
            this.lblAssignementNumber.TabIndex = 22;
            this.lblAssignementNumber.Text = "Assignment Number";
            // 
            // tbAssignementNumber
            // 
            this.tbAssignementNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAssignementNumber.Location = new System.Drawing.Point(201, 17);
            this.tbAssignementNumber.Name = "tbAssignementNumber";
            this.tbAssignementNumber.Size = new System.Drawing.Size(477, 20);
            this.tbAssignementNumber.TabIndex = 0;
            this.tbAssignementNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AssignementForm_Preview_KeyPress);
            // 
            // tbAssignedToDep
            // 
            this.tbAssignedToDep.Location = new System.Drawing.Point(201, 61);
            this.tbAssignedToDep.Name = "tbAssignedToDep";
            this.tbAssignedToDep.Size = new System.Drawing.Size(145, 20);
            this.tbAssignedToDep.TabIndex = 3;
            this.tbAssignedToDep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AssignementForm_Preview_KeyPress);
            // 
            // cbAssignedToDep
            // 
            this.cbAssignedToDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAssignedToDep.FormattingEnabled = true;
            this.cbAssignedToDep.Location = new System.Drawing.Point(201, 61);
            this.cbAssignedToDep.Name = "cbAssignedToDep";
            this.cbAssignedToDep.Size = new System.Drawing.Size(162, 21);
            this.cbAssignedToDep.TabIndex = 20;
            this.cbAssignedToDep.SelectedIndexChanged += new System.EventHandler(this.cbAssignedToDep_SelectedIndexChanged);
            // 
            // lblAssignedToDep
            // 
            this.lblAssignedToDep.AutoSize = true;
            this.lblAssignedToDep.Location = new System.Drawing.Point(79, 64);
            this.lblAssignedToDep.Name = "lblAssignedToDep";
            this.lblAssignedToDep.Size = new System.Drawing.Size(124, 13);
            this.lblAssignedToDep.TabIndex = 18;
            this.lblAssignedToDep.Text = "Assigned To Department";
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
            this.btnSearch.Location = new System.Drawing.Point(685, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 25);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblAssignedTo
            // 
            this.lblAssignedTo.AutoSize = true;
            this.lblAssignedTo.Location = new System.Drawing.Point(404, 64);
            this.lblAssignedTo.Name = "lblAssignedTo";
            this.lblAssignedTo.Size = new System.Drawing.Size(66, 13);
            this.lblAssignedTo.TabIndex = 7;
            this.lblAssignedTo.Text = "Assigned To";
            // 
            // tbAssignedTo
            // 
            this.tbAssignedTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAssignedTo.Location = new System.Drawing.Point(476, 61);
            this.tbAssignedTo.Name = "tbAssignedTo";
            this.tbAssignedTo.Size = new System.Drawing.Size(202, 20);
            this.tbAssignedTo.TabIndex = 4;
            this.tbAssignedTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AssignementForm_Preview_KeyPress);
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
            this.tbDMMProperty.Size = new System.Drawing.Size(202, 20);
            this.tbDMMProperty.TabIndex = 2;
            this.tbDMMProperty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AssignementForm_Preview_KeyPress);
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
            this.tbSerialNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AssignementForm_Preview_KeyPress);
            // 
            // gbCommands
            // 
            this.gbCommands.Controls.Add(this.btnDeleteAssignment);
            this.gbCommands.Controls.Add(this.lblSelectedRows);
            this.gbCommands.Controls.Add(this.btnPrint);
            this.gbCommands.Controls.Add(this.lblNoRows);
            this.gbCommands.Controls.Add(this.Spliter);
            this.gbCommands.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbCommands.Location = new System.Drawing.Point(0, 431);
            this.gbCommands.Name = "gbCommands";
            this.gbCommands.Size = new System.Drawing.Size(774, 75);
            this.gbCommands.TabIndex = 7;
            this.gbCommands.TabStop = false;
            // 
            // btnDeleteAssignment
            // 
            this.btnDeleteAssignment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteAssignment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteAssignment.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAssignment.Image")));
            this.btnDeleteAssignment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAssignment.Location = new System.Drawing.Point(6, 35);
            this.btnDeleteAssignment.Name = "btnDeleteAssignment";
            this.btnDeleteAssignment.Size = new System.Drawing.Size(86, 31);
            this.btnDeleteAssignment.TabIndex = 25;
            this.btnDeleteAssignment.Text = "Delete";
            this.btnDeleteAssignment.UseVisualStyleBackColor = true;
            this.btnDeleteAssignment.Click += new System.EventHandler(this.btnDeleteAssignment_Click);
            // 
            // lblSelectedRows
            // 
            this.lblSelectedRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectedRows.AutoSize = true;
            this.lblSelectedRows.Location = new System.Drawing.Point(641, 10);
            this.lblSelectedRows.Name = "lblSelectedRows";
            this.lblSelectedRows.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedRows.TabIndex = 24;
            this.lblSelectedRows.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.Location = new System.Drawing.Point(680, 35);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(86, 31);
            this.btnPrint.TabIndex = 22;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblNoRows
            // 
            this.lblNoRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoRows.AutoSize = true;
            this.lblNoRows.Location = new System.Drawing.Point(559, 9);
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
            this.Spliter.Size = new System.Drawing.Size(767, 10);
            this.Spliter.TabIndex = 12;
            this.Spliter.TabStop = false;
            // 
            // gbPreview
            // 
            this.gbPreview.Controls.Add(this.outlookGrid1);
            this.gbPreview.Controls.Add(this.gvPreview);
            this.gbPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPreview.Location = new System.Drawing.Point(0, 91);
            this.gbPreview.Name = "gbPreview";
            this.gbPreview.Size = new System.Drawing.Size(774, 340);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.outlookGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.outlookGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outlookGrid1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.outlookGrid1.ExpandIcon = ((System.Drawing.Image)(resources.GetObject("outlookGrid1.ExpandIcon")));
            this.outlookGrid1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.outlookGrid1.Location = new System.Drawing.Point(3, 16);
            this.outlookGrid1.Name = "outlookGrid1";
            this.outlookGrid1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.outlookGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.outlookGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.outlookGrid1.Size = new System.Drawing.Size(768, 321);
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
            this.gvPreview.Size = new System.Drawing.Size(768, 321);
            this.gvPreview.TabIndex = 0;
            // 
            // AssignementForm_Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 506);
            this.Controls.Add(this.gbPreview);
            this.Controls.Add(this.gbCommands);
            this.Controls.Add(this.gbFilter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AssignementForm_Preview";
            this.Text = "Assignment Forms - Preview";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AssignementForm_Preview_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AssignementForm_Preview_KeyPress);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbCommands.ResumeLayout(false);
            this.gbCommands.PerformLayout();
            this.gbPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outlookGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label lblAssignementNumber;
        private System.Windows.Forms.TextBox tbAssignementNumber;
        private System.Windows.Forms.TextBox tbAssignedToDep;
        private System.Windows.Forms.ComboBox cbAssignedToDep;
        private System.Windows.Forms.Label lblAssignedToDep;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblAssignedTo;
        private System.Windows.Forms.TextBox tbAssignedTo;
        private System.Windows.Forms.Label lblDMMProp;
        private System.Windows.Forms.TextBox tbDMMProperty;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.TextBox tbSerialNumber;
        private System.Windows.Forms.GroupBox gbCommands;
        private System.Windows.Forms.Label lblSelectedRows;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblNoRows;
        private System.Windows.Forms.GroupBox Spliter;
        private System.Windows.Forms.GroupBox gbPreview;
        private OutlookStyleControls.OutlookGrid outlookGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
        private System.Windows.Forms.DataGridView gvPreview;
        private System.Windows.Forms.Button btnDeleteAssignment;
    }
}