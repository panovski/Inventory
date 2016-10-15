namespace Inventory_IT_DMM
{
    partial class AssignForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignForm));
            this.tbAssign = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblAssignToDep = new System.Windows.Forms.Label();
            this.cbAssignToDep = new System.Windows.Forms.ComboBox();
            this.lblAssignTo = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.cbAssignedTo = new System.Windows.Forms.ComboBox();
            this.cbAssignementForm = new System.Windows.Forms.CheckBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbAssign
            // 
            this.tbAssign.Image = ((System.Drawing.Image)(resources.GetObject("tbAssign.Image")));
            this.tbAssign.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tbAssign.Location = new System.Drawing.Point(214, 125);
            this.tbAssign.Name = "tbAssign";
            this.tbAssign.Size = new System.Drawing.Size(87, 29);
            this.tbAssign.TabIndex = 4;
            this.tbAssign.Text = "Assign";
            this.tbAssign.UseVisualStyleBackColor = true;
            this.tbAssign.Click += new System.EventHandler(this.tbAssign_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(87, 69);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblAssignToDep
            // 
            this.lblAssignToDep.AutoSize = true;
            this.lblAssignToDep.Location = new System.Drawing.Point(25, 16);
            this.lblAssignToDep.Name = "lblAssignToDep";
            this.lblAssignToDep.Size = new System.Drawing.Size(108, 13);
            this.lblAssignToDep.TabIndex = 15;
            this.lblAssignToDep.Text = "Assign to Department";
            // 
            // cbAssignToDep
            // 
            this.cbAssignToDep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAssignToDep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAssignToDep.FormattingEnabled = true;
            this.cbAssignToDep.Location = new System.Drawing.Point(139, 12);
            this.cbAssignToDep.Name = "cbAssignToDep";
            this.cbAssignToDep.Size = new System.Drawing.Size(162, 21);
            this.cbAssignToDep.TabIndex = 0;
            // 
            // lblAssignTo
            // 
            this.lblAssignTo.AutoSize = true;
            this.lblAssignTo.Location = new System.Drawing.Point(83, 42);
            this.lblAssignTo.Name = "lblAssignTo";
            this.lblAssignTo.Size = new System.Drawing.Size(50, 13);
            this.lblAssignTo.TabIndex = 17;
            this.lblAssignTo.Text = "Assign to";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(139, 66);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(162, 20);
            this.tbQuantity.TabIndex = 2;
            this.tbQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AssignForm_KeyPress);
            // 
            // cbAssignedTo
            // 
            this.cbAssignedTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAssignedTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAssignedTo.FormattingEnabled = true;
            this.cbAssignedTo.Location = new System.Drawing.Point(139, 39);
            this.cbAssignedTo.Name = "cbAssignedTo";
            this.cbAssignedTo.Size = new System.Drawing.Size(162, 21);
            this.cbAssignedTo.TabIndex = 1;
            // 
            // cbAssignementForm
            // 
            this.cbAssignementForm.AutoSize = true;
            this.cbAssignementForm.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbAssignementForm.Location = new System.Drawing.Point(161, 92);
            this.cbAssignementForm.Name = "cbAssignementForm";
            this.cbAssignementForm.Size = new System.Drawing.Size(140, 17);
            this.cbAssignementForm.TabIndex = 3;
            this.cbAssignementForm.Text = "Create Assignment Form";
            this.cbAssignementForm.UseVisualStyleBackColor = true;
            this.cbAssignementForm.Visible = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturn.Location = new System.Drawing.Point(214, 125);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(87, 29);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // AssignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 166);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.cbAssignementForm);
            this.Controls.Add(this.cbAssignedTo);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.lblAssignTo);
            this.Controls.Add(this.lblAssignToDep);
            this.Controls.Add(this.cbAssignToDep);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.tbAssign);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AssignForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Form";
            this.Load += new System.EventHandler(this.AssignForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AssignForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox tbQuantity;
        public System.Windows.Forms.Button tbAssign;
        public System.Windows.Forms.Button btnReturn;
        public System.Windows.Forms.CheckBox cbAssignementForm;
        public System.Windows.Forms.Label lblAssignToDep;
        public System.Windows.Forms.ComboBox cbAssignToDep;
        public System.Windows.Forms.Label lblAssignTo;
        public System.Windows.Forms.ComboBox cbAssignedTo;
    }
}