namespace Inventory_IT_DMM
{
    partial class Default
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Default));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exiitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPreview = new System.Windows.Forms.Label();
            this.lblAddItem = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.ilListaSliki = new System.Windows.Forms.ImageList(this.components);
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.mynotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.imgService = new System.Windows.Forms.PictureBox();
            this.imgAddItem = new System.Windows.Forms.PictureBox();
            this.imgPreview = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(576, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newItemToolStripMenuItem,
            this.previewItemsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exiitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newItemToolStripMenuItem
            // 
            this.newItemToolStripMenuItem.Name = "newItemToolStripMenuItem";
            this.newItemToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.newItemToolStripMenuItem.Text = "New item";
            this.newItemToolStripMenuItem.Click += new System.EventHandler(this.newItemToolStripMenuItem_Click);
            // 
            // previewItemsToolStripMenuItem
            // 
            this.previewItemsToolStripMenuItem.Name = "previewItemsToolStripMenuItem";
            this.previewItemsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.previewItemsToolStripMenuItem.Text = "Preview items";
            this.previewItemsToolStripMenuItem.Click += new System.EventHandler(this.previewItemsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // exiitToolStripMenuItem
            // 
            this.exiitToolStripMenuItem.Name = "exiitToolStripMenuItem";
            this.exiitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exiitToolStripMenuItem.Text = "Exit";
            this.exiitToolStripMenuItem.Click += new System.EventHandler(this.exiitToolStripMenuItem_Click);
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(68, 360);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(45, 13);
            this.lblPreview.TabIndex = 1;
            this.lblPreview.Text = "Preview";
            // 
            // lblAddItem
            // 
            this.lblAddItem.AutoSize = true;
            this.lblAddItem.BackColor = System.Drawing.Color.Transparent;
            this.lblAddItem.Location = new System.Drawing.Point(270, 361);
            this.lblAddItem.Name = "lblAddItem";
            this.lblAddItem.Size = new System.Drawing.Size(49, 13);
            this.lblAddItem.TabIndex = 2;
            this.lblAddItem.Text = "Add Item";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblUser.Location = new System.Drawing.Point(9, 381);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 13);
            this.lblUser.TabIndex = 6;
            // 
            // ilListaSliki
            // 
            this.ilListaSliki.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilListaSliki.ImageStream")));
            this.ilListaSliki.TransparentColor = System.Drawing.Color.Transparent;
            this.ilListaSliki.Images.SetKeyName(0, "Remove_Item.png");
            this.ilListaSliki.Images.SetKeyName(1, "Add_Item.png");
            this.ilListaSliki.Images.SetKeyName(2, "Inventory-Icon.png");
            this.ilListaSliki.Images.SetKeyName(3, "Inventory-Icon_Hover.png");
            this.ilListaSliki.Images.SetKeyName(4, "Service.png");
            this.ilListaSliki.Images.SetKeyName(5, "Service_Hover.png");
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVersion.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblVersion.Location = new System.Drawing.Point(530, 381);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(34, 13);
            this.lblVersion.TabIndex = 7;
            this.lblVersion.Text = "v. 2.3";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.BackColor = System.Drawing.Color.Transparent;
            this.lblService.Location = new System.Drawing.Point(462, 361);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(43, 13);
            this.lblService.TabIndex = 3;
            this.lblService.Text = "Service";
            // 
            // mynotifyIcon
            // 
            this.mynotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("mynotifyIcon.Icon")));
            this.mynotifyIcon.Text = "Inventory DMM";
            this.mynotifyIcon.Visible = true;
            this.mynotifyIcon.DoubleClick += new System.EventHandler(this.mynotifyIcon_DoubleClick);
            // 
            // imgService
            // 
            this.imgService.Image = ((System.Drawing.Image)(resources.GetObject("imgService.Image")));
            this.imgService.Location = new System.Drawing.Point(420, 226);
            this.imgService.Name = "imgService";
            this.imgService.Size = new System.Drawing.Size(130, 134);
            this.imgService.TabIndex = 8;
            this.imgService.TabStop = false;
            this.imgService.Click += new System.EventHandler(this.imgService_Click);
            this.imgService.MouseEnter += new System.EventHandler(this.imgService_MouseEnter);
            this.imgService.MouseLeave += new System.EventHandler(this.imgService_MouseLeave);
            // 
            // imgAddItem
            // 
            this.imgAddItem.Image = ((System.Drawing.Image)(resources.GetObject("imgAddItem.Image")));
            this.imgAddItem.Location = new System.Drawing.Point(228, 226);
            this.imgAddItem.Name = "imgAddItem";
            this.imgAddItem.Size = new System.Drawing.Size(130, 134);
            this.imgAddItem.TabIndex = 4;
            this.imgAddItem.TabStop = false;
            this.imgAddItem.Click += new System.EventHandler(this.imgAddItem_Click);
            this.imgAddItem.MouseEnter += new System.EventHandler(this.imgAddItem_MouseEnter);
            this.imgAddItem.MouseLeave += new System.EventHandler(this.imgAddItem_MouseLeave);
            // 
            // imgPreview
            // 
            this.imgPreview.Image = ((System.Drawing.Image)(resources.GetObject("imgPreview.Image")));
            this.imgPreview.Location = new System.Drawing.Point(29, 226);
            this.imgPreview.Name = "imgPreview";
            this.imgPreview.Size = new System.Drawing.Size(130, 134);
            this.imgPreview.TabIndex = 2;
            this.imgPreview.TabStop = false;
            this.imgPreview.Click += new System.EventHandler(this.imgPreview_Click);
            this.imgPreview.MouseEnter += new System.EventHandler(this.imgPreview_MouseEnter);
            this.imgPreview.MouseLeave += new System.EventHandler(this.imgPreview_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Default
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(576, 405);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.imgService);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblAddItem);
            this.Controls.Add(this.imgAddItem);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.imgPreview);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Default";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory - IT_DMM";
            this.Resize += new System.EventHandler(this.Default_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exiitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imgPreview;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Label lblAddItem;
        private System.Windows.Forms.PictureBox imgAddItem;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ImageList ilListaSliki;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.PictureBox imgService;
        private System.Windows.Forms.NotifyIcon mynotifyIcon;
    }
}