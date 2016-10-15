namespace Inventory_IT_DMM
{
    partial class AddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            this.gbInsert = new System.Windows.Forms.GroupBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.lblAssignedToDep = new System.Windows.Forms.Label();
            this.cbAssignedToDep = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.cbBarcodeScann = new System.Windows.Forms.CheckBox();
            this.gbUpdate = new System.Windows.Forms.GroupBox();
            this.cbRelatedBDA = new System.Windows.Forms.CheckBox();
            this.cbNotes = new System.Windows.Forms.CheckBox();
            this.cbAssToDep = new System.Windows.Forms.CheckBox();
            this.cbServicer = new System.Windows.Forms.CheckBox();
            this.cbIPAddr = new System.Windows.Forms.CheckBox();
            this.cbAssigned = new System.Windows.Forms.CheckBox();
            this.cbStat = new System.Windows.Forms.CheckBox();
            this.cbQuantity = new System.Windows.Forms.CheckBox();
            this.cbDescr = new System.Windows.Forms.CheckBox();
            this.cbProduct = new System.Windows.Forms.CheckBox();
            this.lblServiser = new System.Windows.Forms.Label();
            this.tbServiser = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cbDescription = new System.Windows.Forms.ComboBox();
            this.imgAddItem = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cbProductGroup = new System.Windows.Forms.ComboBox();
            this.tbRelatedBDA = new Inventory_IT_DMM.UserControls.TextBoxCaption();
            this.tbIPAddress = new Inventory_IT_DMM.UserControls.TextBoxCaption();
            this.tbAssignedTo = new Inventory_IT_DMM.UserControls.TextBoxCaption();
            this.tbQuantity = new Inventory_IT_DMM.UserControls.TextBoxCaption();
            this.tbDMMPropertyNum = new Inventory_IT_DMM.UserControls.TextBoxCaption();
            this.tbSerialNumber = new Inventory_IT_DMM.UserControls.TextBoxCaption();
            this.gbInsert.SuspendLayout();
            this.gbUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddItem)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInsert
            // 
            this.gbInsert.Controls.Add(this.tbRelatedBDA);
            this.gbInsert.Controls.Add(this.lblNotes);
            this.gbInsert.Controls.Add(this.tbNotes);
            this.gbInsert.Controls.Add(this.lblAssignedToDep);
            this.gbInsert.Controls.Add(this.cbAssignedToDep);
            this.gbInsert.Controls.Add(this.lblInfo);
            this.gbInsert.Controls.Add(this.cbBarcodeScann);
            this.gbInsert.Controls.Add(this.gbUpdate);
            this.gbInsert.Controls.Add(this.lblServiser);
            this.gbInsert.Controls.Add(this.tbServiser);
            this.gbInsert.Controls.Add(this.btnEdit);
            this.gbInsert.Controls.Add(this.btnDodadi);
            this.gbInsert.Controls.Add(this.lblDescription);
            this.gbInsert.Controls.Add(this.cbDescription);
            this.gbInsert.Controls.Add(this.imgAddItem);
            this.gbInsert.Controls.Add(this.lblStatus);
            this.gbInsert.Controls.Add(this.cbStatus);
            this.gbInsert.Controls.Add(this.lblProduct);
            this.gbInsert.Controls.Add(this.cbProductGroup);
            this.gbInsert.Controls.Add(this.tbIPAddress);
            this.gbInsert.Controls.Add(this.tbAssignedTo);
            this.gbInsert.Controls.Add(this.tbQuantity);
            this.gbInsert.Controls.Add(this.tbDMMPropertyNum);
            this.gbInsert.Controls.Add(this.tbSerialNumber);
            this.gbInsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbInsert.Location = new System.Drawing.Point(0, 0);
            this.gbInsert.Name = "gbInsert";
            this.gbInsert.Size = new System.Drawing.Size(448, 502);
            this.gbInsert.TabIndex = 0;
            this.gbInsert.TabStop = false;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNotes.Location = new System.Drawing.Point(141, 338);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(39, 15);
            this.lblNotes.TabIndex = 28;
            this.lblNotes.Text = "Notes";
            // 
            // tbNotes
            // 
            this.tbNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNotes.Location = new System.Drawing.Point(182, 337);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNotes.Size = new System.Drawing.Size(226, 81);
            this.tbNotes.TabIndex = 10;
            // 
            // lblAssignedToDep
            // 
            this.lblAssignedToDep.AutoSize = true;
            this.lblAssignedToDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAssignedToDep.Location = new System.Drawing.Point(38, 173);
            this.lblAssignedToDep.Name = "lblAssignedToDep";
            this.lblAssignedToDep.Size = new System.Drawing.Size(142, 15);
            this.lblAssignedToDep.TabIndex = 26;
            this.lblAssignedToDep.Text = "Assigned To Department";
            // 
            // cbAssignedToDep
            // 
            this.cbAssignedToDep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAssignedToDep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAssignedToDep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAssignedToDep.FormattingEnabled = true;
            this.cbAssignedToDep.Location = new System.Drawing.Point(182, 172);
            this.cbAssignedToDep.Name = "cbAssignedToDep";
            this.cbAssignedToDep.Size = new System.Drawing.Size(226, 21);
            this.cbAssignedToDep.TabIndex = 6;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInfo.Location = new System.Drawing.Point(7, 318);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 24;
            // 
            // cbBarcodeScann
            // 
            this.cbBarcodeScann.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbBarcodeScann.AutoSize = true;
            this.cbBarcodeScann.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbBarcodeScann.Location = new System.Drawing.Point(61, 460);
            this.cbBarcodeScann.Name = "cbBarcodeScann";
            this.cbBarcodeScann.Size = new System.Drawing.Size(135, 17);
            this.cbBarcodeScann.TabIndex = 12;
            this.cbBarcodeScann.Text = "From Barcode Scanner";
            this.cbBarcodeScann.UseVisualStyleBackColor = true;
            // 
            // gbUpdate
            // 
            this.gbUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbUpdate.Controls.Add(this.cbRelatedBDA);
            this.gbUpdate.Controls.Add(this.cbNotes);
            this.gbUpdate.Controls.Add(this.cbAssToDep);
            this.gbUpdate.Controls.Add(this.cbServicer);
            this.gbUpdate.Controls.Add(this.cbIPAddr);
            this.gbUpdate.Controls.Add(this.cbAssigned);
            this.gbUpdate.Controls.Add(this.cbStat);
            this.gbUpdate.Controls.Add(this.cbQuantity);
            this.gbUpdate.Controls.Add(this.cbDescr);
            this.gbUpdate.Controls.Add(this.cbProduct);
            this.gbUpdate.Location = new System.Drawing.Point(414, 12);
            this.gbUpdate.Name = "gbUpdate";
            this.gbUpdate.Size = new System.Drawing.Size(27, 447);
            this.gbUpdate.TabIndex = 22;
            this.gbUpdate.TabStop = false;
            this.gbUpdate.Visible = false;
            // 
            // cbRelatedBDA
            // 
            this.cbRelatedBDA.AutoSize = true;
            this.cbRelatedBDA.Location = new System.Drawing.Point(6, 416);
            this.cbRelatedBDA.Name = "cbRelatedBDA";
            this.cbRelatedBDA.Size = new System.Drawing.Size(15, 14);
            this.cbRelatedBDA.TabIndex = 29;
            this.cbRelatedBDA.UseVisualStyleBackColor = true;
            // 
            // cbNotes
            // 
            this.cbNotes.AutoSize = true;
            this.cbNotes.Location = new System.Drawing.Point(6, 360);
            this.cbNotes.Name = "cbNotes";
            this.cbNotes.Size = new System.Drawing.Size(15, 14);
            this.cbNotes.TabIndex = 8;
            this.cbNotes.UseVisualStyleBackColor = true;
            // 
            // cbAssToDep
            // 
            this.cbAssToDep.AutoSize = true;
            this.cbAssToDep.Location = new System.Drawing.Point(6, 164);
            this.cbAssToDep.Name = "cbAssToDep";
            this.cbAssToDep.Size = new System.Drawing.Size(15, 14);
            this.cbAssToDep.TabIndex = 4;
            this.cbAssToDep.UseVisualStyleBackColor = true;
            // 
            // cbServicer
            // 
            this.cbServicer.AutoSize = true;
            this.cbServicer.Location = new System.Drawing.Point(6, 272);
            this.cbServicer.Name = "cbServicer";
            this.cbServicer.Size = new System.Drawing.Size(15, 14);
            this.cbServicer.TabIndex = 7;
            this.cbServicer.UseVisualStyleBackColor = true;
            // 
            // cbIPAddr
            // 
            this.cbIPAddr.AutoSize = true;
            this.cbIPAddr.Location = new System.Drawing.Point(6, 213);
            this.cbIPAddr.Name = "cbIPAddr";
            this.cbIPAddr.Size = new System.Drawing.Size(15, 14);
            this.cbIPAddr.TabIndex = 6;
            this.cbIPAddr.UseVisualStyleBackColor = true;
            this.cbIPAddr.Visible = false;
            // 
            // cbAssigned
            // 
            this.cbAssigned.AutoSize = true;
            this.cbAssigned.Location = new System.Drawing.Point(6, 187);
            this.cbAssigned.Name = "cbAssigned";
            this.cbAssigned.Size = new System.Drawing.Size(15, 14);
            this.cbAssigned.TabIndex = 5;
            this.cbAssigned.UseVisualStyleBackColor = true;
            // 
            // cbStat
            // 
            this.cbStat.AutoSize = true;
            this.cbStat.Location = new System.Drawing.Point(6, 139);
            this.cbStat.Name = "cbStat";
            this.cbStat.Size = new System.Drawing.Size(15, 14);
            this.cbStat.TabIndex = 3;
            this.cbStat.UseVisualStyleBackColor = true;
            // 
            // cbQuantity
            // 
            this.cbQuantity.AutoSize = true;
            this.cbQuantity.Location = new System.Drawing.Point(6, 114);
            this.cbQuantity.Name = "cbQuantity";
            this.cbQuantity.Size = new System.Drawing.Size(15, 14);
            this.cbQuantity.TabIndex = 2;
            this.cbQuantity.UseVisualStyleBackColor = true;
            // 
            // cbDescr
            // 
            this.cbDescr.AutoSize = true;
            this.cbDescr.Location = new System.Drawing.Point(6, 35);
            this.cbDescr.Name = "cbDescr";
            this.cbDescr.Size = new System.Drawing.Size(15, 14);
            this.cbDescr.TabIndex = 1;
            this.cbDescr.UseVisualStyleBackColor = true;
            // 
            // cbProduct
            // 
            this.cbProduct.AutoSize = true;
            this.cbProduct.Location = new System.Drawing.Point(6, 10);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(15, 14);
            this.cbProduct.TabIndex = 0;
            this.cbProduct.UseVisualStyleBackColor = true;
            // 
            // lblServiser
            // 
            this.lblServiser.AutoSize = true;
            this.lblServiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblServiser.Location = new System.Drawing.Point(74, 250);
            this.lblServiser.Name = "lblServiser";
            this.lblServiser.Size = new System.Drawing.Size(106, 15);
            this.lblServiser.TabIndex = 21;
            this.lblServiser.Text = "Supplier / Servicer";
            // 
            // tbServiser
            // 
            this.tbServiser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbServiser.Location = new System.Drawing.Point(182, 250);
            this.tbServiser.Multiline = true;
            this.tbServiser.Name = "tbServiser";
            this.tbServiser.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbServiser.Size = new System.Drawing.Size(226, 81);
            this.tbServiser.TabIndex = 9;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnEdit.Location = new System.Drawing.Point(313, 465);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 25);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDodadi
            // 
            this.btnDodadi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodadi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDodadi.Image = ((System.Drawing.Image)(resources.GetObject("btnDodadi.Image")));
            this.btnDodadi.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnDodadi.Location = new System.Drawing.Point(313, 465);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(95, 25);
            this.btnDodadi.TabIndex = 10;
            this.btnDodadi.Text = "Insert";
            this.btnDodadi.UseVisualStyleBackColor = true;
            this.btnDodadi.Click += new System.EventHandler(this.btnDodadi_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescription.Location = new System.Drawing.Point(111, 45);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(69, 15);
            this.lblDescription.TabIndex = 17;
            this.lblDescription.Text = "Description";
            // 
            // cbDescription
            // 
            this.cbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDescription.FormattingEnabled = true;
            this.cbDescription.Location = new System.Drawing.Point(182, 44);
            this.cbDescription.Name = "cbDescription";
            this.cbDescription.Size = new System.Drawing.Size(226, 21);
            this.cbDescription.TabIndex = 1;
            // 
            // imgAddItem
            // 
            this.imgAddItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgAddItem.BackgroundImage")));
            this.imgAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgAddItem.Location = new System.Drawing.Point(6, 9);
            this.imgAddItem.Name = "imgAddItem";
            this.imgAddItem.Size = new System.Drawing.Size(85, 82);
            this.imgAddItem.TabIndex = 15;
            this.imgAddItem.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.Location = new System.Drawing.Point(141, 149);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 15);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(182, 147);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(226, 21);
            this.cbStatus.TabIndex = 5;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProduct.Location = new System.Drawing.Point(131, 21);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(49, 15);
            this.lblProduct.TabIndex = 12;
            this.lblProduct.Text = "Product";
            // 
            // cbProductGroup
            // 
            this.cbProductGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProductGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbProductGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProductGroup.FormattingEnabled = true;
            this.cbProductGroup.Location = new System.Drawing.Point(182, 19);
            this.cbProductGroup.Name = "cbProductGroup";
            this.cbProductGroup.Size = new System.Drawing.Size(226, 21);
            this.cbProductGroup.TabIndex = 0;
            this.cbProductGroup.SelectedIndexChanged += new System.EventHandler(this.cbProductGroup_SelectedIndexChanged);
            // 
            // tbRelatedBDA
            // 
            this.tbRelatedBDA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRelatedBDA.Caption = "Related BDA";
            this.tbRelatedBDA.IsNumber = 0;
            this.tbRelatedBDA.IsUpper = 0;
            this.tbRelatedBDA.Location = new System.Drawing.Point(105, 424);
            this.tbRelatedBDA.Name = "tbRelatedBDA";
            this.tbRelatedBDA.Size = new System.Drawing.Size(303, 20);
            this.tbRelatedBDA.TabIndex = 11;
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIPAddress.Caption = "IP Address";
            this.tbIPAddress.IsNumber = 0;
            this.tbIPAddress.IsUpper = 0;
            this.tbIPAddress.Location = new System.Drawing.Point(117, 223);
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.Size = new System.Drawing.Size(291, 20);
            this.tbIPAddress.TabIndex = 8;
            // 
            // tbAssignedTo
            // 
            this.tbAssignedTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAssignedTo.Caption = "Assigned To";
            this.tbAssignedTo.IsNumber = 0;
            this.tbAssignedTo.IsUpper = 0;
            this.tbAssignedTo.Location = new System.Drawing.Point(108, 197);
            this.tbAssignedTo.Name = "tbAssignedTo";
            this.tbAssignedTo.Size = new System.Drawing.Size(300, 20);
            this.tbAssignedTo.TabIndex = 7;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbQuantity.Caption = "Quantity";
            this.tbQuantity.IsNumber = 1;
            this.tbQuantity.IsUpper = 0;
            this.tbQuantity.Location = new System.Drawing.Point(131, 123);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(277, 20);
            this.tbQuantity.TabIndex = 4;
            // 
            // tbDMMPropertyNum
            // 
            this.tbDMMPropertyNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDMMPropertyNum.Caption = "DMM Property Number";
            this.tbDMMPropertyNum.IsNumber = 0;
            this.tbDMMPropertyNum.IsUpper = 1;
            this.tbDMMPropertyNum.Location = new System.Drawing.Point(48, 97);
            this.tbDMMPropertyNum.Name = "tbDMMPropertyNum";
            this.tbDMMPropertyNum.Size = new System.Drawing.Size(360, 20);
            this.tbDMMPropertyNum.TabIndex = 3;
            // 
            // tbSerialNumber
            // 
            this.tbSerialNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSerialNumber.Caption = "Serial Number";
            this.tbSerialNumber.IsNumber = 0;
            this.tbSerialNumber.IsUpper = 1;
            this.tbSerialNumber.Location = new System.Drawing.Point(95, 71);
            this.tbSerialNumber.Name = "tbSerialNumber";
            this.tbSerialNumber.Size = new System.Drawing.Size(313, 20);
            this.tbSerialNumber.TabIndex = 2;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 502);
            this.Controls.Add(this.gbInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "AddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddItem_KeyPress);
            this.gbInsert.ResumeLayout(false);
            this.gbInsert.PerformLayout();
            this.gbUpdate.ResumeLayout(false);
            this.gbUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAddItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInsert;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox imgAddItem;
        private System.Windows.Forms.Label lblDescription;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnDodadi;
        public UserControls.TextBoxCaption tbSerialNumber;
        public UserControls.TextBoxCaption tbIPAddress;
        public UserControls.TextBoxCaption tbAssignedTo;
        public UserControls.TextBoxCaption tbQuantity;
        public UserControls.TextBoxCaption tbDMMPropertyNum;
        public System.Windows.Forms.ComboBox cbProductGroup;
        public System.Windows.Forms.ComboBox cbStatus;
        public System.Windows.Forms.ComboBox cbDescription;
        private System.Windows.Forms.Label lblServiser;
        private System.Windows.Forms.TextBox tbServiser;
        private System.Windows.Forms.GroupBox gbUpdate;
        private System.Windows.Forms.CheckBox cbIPAddr;
        private System.Windows.Forms.CheckBox cbAssigned;
        private System.Windows.Forms.CheckBox cbStat;
        private System.Windows.Forms.CheckBox cbQuantity;
        private System.Windows.Forms.CheckBox cbDescr;
        private System.Windows.Forms.CheckBox cbProduct;
        private System.Windows.Forms.CheckBox cbServicer;
        private System.Windows.Forms.CheckBox cbBarcodeScann;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblAssignedToDep;
        public System.Windows.Forms.ComboBox cbAssignedToDep;
        private System.Windows.Forms.CheckBox cbAssToDep;
        public UserControls.TextBoxCaption tbRelatedBDA;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.CheckBox cbRelatedBDA;
        private System.Windows.Forms.CheckBox cbNotes;
    }
}