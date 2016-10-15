namespace Inventory_IT_DMM
{
    partial class SendOnService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendOnService));
            this.imgAddItem = new System.Windows.Forms.PictureBox();
            this.lblDMMNumber = new System.Windows.Forms.Label();
            this.cbDMMNumber = new System.Windows.Forms.ComboBox();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.cbSerialNumber = new System.Windows.Forms.ComboBox();
            this.tbProblem = new System.Windows.Forms.TextBox();
            this.lblProblem = new System.Windows.Forms.Label();
            this.calSentOn = new System.Windows.Forms.DateTimePicker();
            this.lblSentOnDate = new System.Windows.Forms.Label();
            this.tbSentBy = new System.Windows.Forms.TextBox();
            this.lblSentBy = new System.Windows.Forms.Label();
            this.lblServicer = new System.Windows.Forms.Label();
            this.cbServicer = new System.Windows.Forms.ComboBox();
            this.lblServicerContact = new System.Windows.Forms.Label();
            this.tbServicerContact = new System.Windows.Forms.TextBox();
            this.btnSendOnService = new System.Windows.Forms.Button();
            this.pbRequiredSerial = new System.Windows.Forms.PictureBox();
            this.lblCostCenter = new System.Windows.Forms.Label();
            this.cbCostCenter = new System.Windows.Forms.ComboBox();
            this.lblRelatedBDA = new System.Windows.Forms.Label();
            this.tbRelatedBDA = new System.Windows.Forms.TextBox();
            this.cbReverseForm = new System.Windows.Forms.CheckBox();
            this.cbAddress = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRequiredSerial)).BeginInit();
            this.SuspendLayout();
            // 
            // imgAddItem
            // 
            this.imgAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgAddItem.Image = ((System.Drawing.Image)(resources.GetObject("imgAddItem.Image")));
            this.imgAddItem.Location = new System.Drawing.Point(2, 2);
            this.imgAddItem.Name = "imgAddItem";
            this.imgAddItem.Size = new System.Drawing.Size(85, 82);
            this.imgAddItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAddItem.TabIndex = 16;
            this.imgAddItem.TabStop = false;
            // 
            // lblDMMNumber
            // 
            this.lblDMMNumber.AutoSize = true;
            this.lblDMMNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDMMNumber.Location = new System.Drawing.Point(101, 38);
            this.lblDMMNumber.Name = "lblDMMNumber";
            this.lblDMMNumber.Size = new System.Drawing.Size(86, 15);
            this.lblDMMNumber.TabIndex = 21;
            this.lblDMMNumber.Text = "DMM Number";
            // 
            // cbDMMNumber
            // 
            this.cbDMMNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDMMNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDMMNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDMMNumber.FormattingEnabled = true;
            this.cbDMMNumber.Location = new System.Drawing.Point(193, 37);
            this.cbDMMNumber.Name = "cbDMMNumber";
            this.cbDMMNumber.Size = new System.Drawing.Size(218, 21);
            this.cbDMMNumber.TabIndex = 1;
            this.cbDMMNumber.SelectedIndexChanged += new System.EventHandler(this.cbDMMNumber_SelectedIndexChanged);
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSerialNumber.Location = new System.Drawing.Point(100, 13);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(87, 15);
            this.lblSerialNumber.TabIndex = 20;
            this.lblSerialNumber.Text = "Serial Number";
            // 
            // cbSerialNumber
            // 
            this.cbSerialNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSerialNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSerialNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSerialNumber.FormattingEnabled = true;
            this.cbSerialNumber.Location = new System.Drawing.Point(193, 12);
            this.cbSerialNumber.Name = "cbSerialNumber";
            this.cbSerialNumber.Size = new System.Drawing.Size(218, 21);
            this.cbSerialNumber.TabIndex = 0;
            this.cbSerialNumber.SelectedIndexChanged += new System.EventHandler(this.cbSerialNumber_SelectedIndexChanged);
            // 
            // tbProblem
            // 
            this.tbProblem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProblem.Location = new System.Drawing.Point(193, 64);
            this.tbProblem.Multiline = true;
            this.tbProblem.Name = "tbProblem";
            this.tbProblem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbProblem.Size = new System.Drawing.Size(218, 81);
            this.tbProblem.TabIndex = 2;
            // 
            // lblProblem
            // 
            this.lblProblem.AutoSize = true;
            this.lblProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProblem.Location = new System.Drawing.Point(133, 65);
            this.lblProblem.Name = "lblProblem";
            this.lblProblem.Size = new System.Drawing.Size(54, 15);
            this.lblProblem.TabIndex = 23;
            this.lblProblem.Text = "Problem";
            // 
            // calSentOn
            // 
            this.calSentOn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calSentOn.Checked = false;
            this.calSentOn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calSentOn.Location = new System.Drawing.Point(193, 151);
            this.calSentOn.MinDate = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
            this.calSentOn.Name = "calSentOn";
            this.calSentOn.Size = new System.Drawing.Size(218, 20);
            this.calSentOn.TabIndex = 3;
            this.calSentOn.Value = new System.DateTime(2014, 12, 14, 0, 0, 0, 0);
            // 
            // lblSentOnDate
            // 
            this.lblSentOnDate.AutoSize = true;
            this.lblSentOnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSentOnDate.Location = new System.Drawing.Point(109, 155);
            this.lblSentOnDate.Name = "lblSentOnDate";
            this.lblSentOnDate.Size = new System.Drawing.Size(78, 15);
            this.lblSentOnDate.TabIndex = 26;
            this.lblSentOnDate.Text = "Sent on Date";
            // 
            // tbSentBy
            // 
            this.tbSentBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSentBy.Location = new System.Drawing.Point(193, 177);
            this.tbSentBy.Name = "tbSentBy";
            this.tbSentBy.Size = new System.Drawing.Size(218, 20);
            this.tbSentBy.TabIndex = 4;
            // 
            // lblSentBy
            // 
            this.lblSentBy.AutoSize = true;
            this.lblSentBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSentBy.Location = new System.Drawing.Point(139, 178);
            this.lblSentBy.Name = "lblSentBy";
            this.lblSentBy.Size = new System.Drawing.Size(48, 15);
            this.lblSentBy.TabIndex = 28;
            this.lblSentBy.Text = "Sent By";
            // 
            // lblServicer
            // 
            this.lblServicer.AutoSize = true;
            this.lblServicer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblServicer.Location = new System.Drawing.Point(136, 204);
            this.lblServicer.Name = "lblServicer";
            this.lblServicer.Size = new System.Drawing.Size(51, 15);
            this.lblServicer.TabIndex = 30;
            this.lblServicer.Text = "Servicer";
            // 
            // cbServicer
            // 
            this.cbServicer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbServicer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbServicer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbServicer.FormattingEnabled = true;
            this.cbServicer.Location = new System.Drawing.Point(193, 203);
            this.cbServicer.Name = "cbServicer";
            this.cbServicer.Size = new System.Drawing.Size(218, 21);
            this.cbServicer.TabIndex = 5;
            this.cbServicer.SelectedIndexChanged += new System.EventHandler(this.cbServicer_SelectedIndexChanged);
            // 
            // lblServicerContact
            // 
            this.lblServicerContact.AutoSize = true;
            this.lblServicerContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblServicerContact.Location = new System.Drawing.Point(92, 231);
            this.lblServicerContact.Name = "lblServicerContact";
            this.lblServicerContact.Size = new System.Drawing.Size(95, 15);
            this.lblServicerContact.TabIndex = 32;
            this.lblServicerContact.Text = "Servicer Contact";
            // 
            // tbServicerContact
            // 
            this.tbServicerContact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbServicerContact.Location = new System.Drawing.Point(193, 230);
            this.tbServicerContact.Multiline = true;
            this.tbServicerContact.Name = "tbServicerContact";
            this.tbServicerContact.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbServicerContact.Size = new System.Drawing.Size(218, 81);
            this.tbServicerContact.TabIndex = 6;
            // 
            // btnSendOnService
            // 
            this.btnSendOnService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendOnService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSendOnService.Image = ((System.Drawing.Image)(resources.GetObject("btnSendOnService.Image")));
            this.btnSendOnService.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSendOnService.Location = new System.Drawing.Point(316, 405);
            this.btnSendOnService.Name = "btnSendOnService";
            this.btnSendOnService.Size = new System.Drawing.Size(95, 25);
            this.btnSendOnService.TabIndex = 11;
            this.btnSendOnService.Text = "Send";
            this.btnSendOnService.UseVisualStyleBackColor = true;
            this.btnSendOnService.Click += new System.EventHandler(this.btnSendOnService_Click);
            // 
            // pbRequiredSerial
            // 
            this.pbRequiredSerial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRequiredSerial.Image = ((System.Drawing.Image)(resources.GetObject("pbRequiredSerial.Image")));
            this.pbRequiredSerial.Location = new System.Drawing.Point(416, 15);
            this.pbRequiredSerial.Name = "pbRequiredSerial";
            this.pbRequiredSerial.Size = new System.Drawing.Size(15, 15);
            this.pbRequiredSerial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRequiredSerial.TabIndex = 34;
            this.pbRequiredSerial.TabStop = false;
            this.pbRequiredSerial.Visible = false;
            // 
            // lblCostCenter
            // 
            this.lblCostCenter.AutoSize = true;
            this.lblCostCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCostCenter.Location = new System.Drawing.Point(117, 318);
            this.lblCostCenter.Name = "lblCostCenter";
            this.lblCostCenter.Size = new System.Drawing.Size(70, 15);
            this.lblCostCenter.TabIndex = 38;
            this.lblCostCenter.Text = "Cost Center";
            // 
            // cbCostCenter
            // 
            this.cbCostCenter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCostCenter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCostCenter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCostCenter.FormattingEnabled = true;
            this.cbCostCenter.Location = new System.Drawing.Point(193, 317);
            this.cbCostCenter.Name = "cbCostCenter";
            this.cbCostCenter.Size = new System.Drawing.Size(218, 21);
            this.cbCostCenter.TabIndex = 7;
            // 
            // lblRelatedBDA
            // 
            this.lblRelatedBDA.AutoSize = true;
            this.lblRelatedBDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRelatedBDA.Location = new System.Drawing.Point(110, 345);
            this.lblRelatedBDA.Name = "lblRelatedBDA";
            this.lblRelatedBDA.Size = new System.Drawing.Size(77, 15);
            this.lblRelatedBDA.TabIndex = 36;
            this.lblRelatedBDA.Text = "Related BDA";
            // 
            // tbRelatedBDA
            // 
            this.tbRelatedBDA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRelatedBDA.Location = new System.Drawing.Point(193, 344);
            this.tbRelatedBDA.Name = "tbRelatedBDA";
            this.tbRelatedBDA.Size = new System.Drawing.Size(218, 20);
            this.tbRelatedBDA.TabIndex = 8;
            // 
            // cbReverseForm
            // 
            this.cbReverseForm.AutoSize = true;
            this.cbReverseForm.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbReverseForm.Checked = true;
            this.cbReverseForm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbReverseForm.Location = new System.Drawing.Point(91, 372);
            this.cbReverseForm.Name = "cbReverseForm";
            this.cbReverseForm.Size = new System.Drawing.Size(116, 17);
            this.cbReverseForm.TabIndex = 9;
            this.cbReverseForm.Text = "Print Reverse Form";
            this.cbReverseForm.UseVisualStyleBackColor = true;
            // 
            // cbAddress
            // 
            this.cbAddress.AutoSize = true;
            this.cbAddress.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbAddress.Checked = true;
            this.cbAddress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAddress.Location = new System.Drawing.Point(323, 372);
            this.cbAddress.Name = "cbAddress";
            this.cbAddress.Size = new System.Drawing.Size(88, 17);
            this.cbAddress.TabIndex = 10;
            this.cbAddress.Text = "Print Address";
            this.cbAddress.UseVisualStyleBackColor = true;
            // 
            // SendOnService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 442);
            this.Controls.Add(this.cbAddress);
            this.Controls.Add(this.cbReverseForm);
            this.Controls.Add(this.lblCostCenter);
            this.Controls.Add(this.cbCostCenter);
            this.Controls.Add(this.lblRelatedBDA);
            this.Controls.Add(this.tbRelatedBDA);
            this.Controls.Add(this.pbRequiredSerial);
            this.Controls.Add(this.btnSendOnService);
            this.Controls.Add(this.lblServicerContact);
            this.Controls.Add(this.tbServicerContact);
            this.Controls.Add(this.lblServicer);
            this.Controls.Add(this.cbServicer);
            this.Controls.Add(this.lblSentBy);
            this.Controls.Add(this.tbSentBy);
            this.Controls.Add(this.lblSentOnDate);
            this.Controls.Add(this.calSentOn);
            this.Controls.Add(this.lblProblem);
            this.Controls.Add(this.tbProblem);
            this.Controls.Add(this.lblDMMNumber);
            this.Controls.Add(this.cbDMMNumber);
            this.Controls.Add(this.lblSerialNumber);
            this.Controls.Add(this.cbSerialNumber);
            this.Controls.Add(this.imgAddItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SendOnService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send on Service";
            this.Load += new System.EventHandler(this.SendOnService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgAddItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRequiredSerial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgAddItem;
        private System.Windows.Forms.Label lblDMMNumber;
        public System.Windows.Forms.ComboBox cbDMMNumber;
        private System.Windows.Forms.Label lblSerialNumber;
        public System.Windows.Forms.ComboBox cbSerialNumber;
        private System.Windows.Forms.TextBox tbProblem;
        private System.Windows.Forms.Label lblProblem;
        private System.Windows.Forms.DateTimePicker calSentOn;
        private System.Windows.Forms.Label lblSentOnDate;
        private System.Windows.Forms.TextBox tbSentBy;
        private System.Windows.Forms.Label lblSentBy;
        private System.Windows.Forms.Label lblServicer;
        public System.Windows.Forms.ComboBox cbServicer;
        private System.Windows.Forms.Label lblServicerContact;
        private System.Windows.Forms.TextBox tbServicerContact;
        public System.Windows.Forms.Button btnSendOnService;
        private System.Windows.Forms.PictureBox pbRequiredSerial;
        private System.Windows.Forms.Label lblCostCenter;
        public System.Windows.Forms.ComboBox cbCostCenter;
        private System.Windows.Forms.Label lblRelatedBDA;
        private System.Windows.Forms.TextBox tbRelatedBDA;
        public System.Windows.Forms.CheckBox cbReverseForm;
        public System.Windows.Forms.CheckBox cbAddress;
    }
}