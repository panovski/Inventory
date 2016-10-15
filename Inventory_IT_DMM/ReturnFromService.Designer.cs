namespace Inventory_IT_DMM
{
    partial class ReturnFromService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnFromService));
            this.tbSerialNumber = new System.Windows.Forms.TextBox();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.imgService = new System.Windows.Forms.PictureBox();
            this.lblSentBy = new System.Windows.Forms.Label();
            this.tbReturnedBy = new System.Windows.Forms.TextBox();
            this.lblReturnedOnDate = new System.Windows.Forms.Label();
            this.calReturnedOn = new System.Windows.Forms.DateTimePicker();
            this.lblReturnInfo = new System.Windows.Forms.Label();
            this.tbReturnInfo = new System.Windows.Forms.TextBox();
            this.btnReturnFromService = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgService)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSerialNumber
            // 
            this.tbSerialNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSerialNumber.Location = new System.Drawing.Point(165, 14);
            this.tbSerialNumber.Name = "tbSerialNumber";
            this.tbSerialNumber.ReadOnly = true;
            this.tbSerialNumber.Size = new System.Drawing.Size(184, 20);
            this.tbSerialNumber.TabIndex = 30;
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSerialNumber.Location = new System.Drawing.Point(72, 15);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(87, 15);
            this.lblSerialNumber.TabIndex = 29;
            this.lblSerialNumber.Text = "Serial Number";
            // 
            // imgService
            // 
            this.imgService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgService.Image = ((System.Drawing.Image)(resources.GetObject("imgService.Image")));
            this.imgService.Location = new System.Drawing.Point(22, 15);
            this.imgService.Name = "imgService";
            this.imgService.Size = new System.Drawing.Size(29, 30);
            this.imgService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgService.TabIndex = 28;
            this.imgService.TabStop = false;
            // 
            // lblSentBy
            // 
            this.lblSentBy.AutoSize = true;
            this.lblSentBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSentBy.Location = new System.Drawing.Point(85, 154);
            this.lblSentBy.Name = "lblSentBy";
            this.lblSentBy.Size = new System.Drawing.Size(74, 15);
            this.lblSentBy.TabIndex = 36;
            this.lblSentBy.Text = "Returned By";
            // 
            // tbReturnedBy
            // 
            this.tbReturnedBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReturnedBy.Location = new System.Drawing.Point(165, 153);
            this.tbReturnedBy.Name = "tbReturnedBy";
            this.tbReturnedBy.Size = new System.Drawing.Size(184, 20);
            this.tbReturnedBy.TabIndex = 35;
            // 
            // lblReturnedOnDate
            // 
            this.lblReturnedOnDate.AutoSize = true;
            this.lblReturnedOnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReturnedOnDate.Location = new System.Drawing.Point(57, 44);
            this.lblReturnedOnDate.Name = "lblReturnedOnDate";
            this.lblReturnedOnDate.Size = new System.Drawing.Size(104, 15);
            this.lblReturnedOnDate.TabIndex = 34;
            this.lblReturnedOnDate.Text = "Returned on Date";
            // 
            // calReturnedOn
            // 
            this.calReturnedOn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calReturnedOn.Checked = false;
            this.calReturnedOn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calReturnedOn.Location = new System.Drawing.Point(165, 40);
            this.calReturnedOn.MinDate = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
            this.calReturnedOn.Name = "calReturnedOn";
            this.calReturnedOn.Size = new System.Drawing.Size(184, 20);
            this.calReturnedOn.TabIndex = 33;
            this.calReturnedOn.Value = new System.DateTime(2014, 12, 14, 0, 0, 0, 0);
            // 
            // lblReturnInfo
            // 
            this.lblReturnInfo.AutoSize = true;
            this.lblReturnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReturnInfo.Location = new System.Drawing.Point(50, 67);
            this.lblReturnInfo.Name = "lblReturnInfo";
            this.lblReturnInfo.Size = new System.Drawing.Size(109, 15);
            this.lblReturnInfo.TabIndex = 32;
            this.lblReturnInfo.Text = "Return information";
            // 
            // tbReturnInfo
            // 
            this.tbReturnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReturnInfo.Location = new System.Drawing.Point(165, 66);
            this.tbReturnInfo.Multiline = true;
            this.tbReturnInfo.Name = "tbReturnInfo";
            this.tbReturnInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbReturnInfo.Size = new System.Drawing.Size(184, 81);
            this.tbReturnInfo.TabIndex = 31;
            // 
            // btnReturnFromService
            // 
            this.btnReturnFromService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnFromService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReturnFromService.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnFromService.Image")));
            this.btnReturnFromService.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnReturnFromService.Location = new System.Drawing.Point(227, 181);
            this.btnReturnFromService.Name = "btnReturnFromService";
            this.btnReturnFromService.Size = new System.Drawing.Size(122, 25);
            this.btnReturnFromService.TabIndex = 37;
            this.btnReturnFromService.Text = "Return the item";
            this.btnReturnFromService.UseVisualStyleBackColor = true;
            this.btnReturnFromService.Click += new System.EventHandler(this.btnReturnFromService_Click);
            // 
            // ReturnFromService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 218);
            this.Controls.Add(this.btnReturnFromService);
            this.Controls.Add(this.lblSentBy);
            this.Controls.Add(this.tbReturnedBy);
            this.Controls.Add(this.lblReturnedOnDate);
            this.Controls.Add(this.calReturnedOn);
            this.Controls.Add(this.lblReturnInfo);
            this.Controls.Add(this.tbReturnInfo);
            this.Controls.Add(this.tbSerialNumber);
            this.Controls.Add(this.lblSerialNumber);
            this.Controls.Add(this.imgService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReturnFromService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return from Service";
            this.Load += new System.EventHandler(this.ReturnFromService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSerialNumber;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.PictureBox imgService;
        private System.Windows.Forms.Label lblSentBy;
        private System.Windows.Forms.TextBox tbReturnedBy;
        private System.Windows.Forms.Label lblReturnedOnDate;
        private System.Windows.Forms.DateTimePicker calReturnedOn;
        private System.Windows.Forms.Label lblReturnInfo;
        private System.Windows.Forms.TextBox tbReturnInfo;
        public System.Windows.Forms.Button btnReturnFromService;
    }
}