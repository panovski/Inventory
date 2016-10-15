namespace Inventory_IT_DMM
{
    partial class ReprintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReprintForm));
            this.tbReprint = new System.Windows.Forms.Button();
            this.tbAssignementNumber = new System.Windows.Forms.TextBox();
            this.lblAssignementNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbReprint
            // 
            this.tbReprint.Image = ((System.Drawing.Image)(resources.GetObject("tbReprint.Image")));
            this.tbReprint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tbReprint.Location = new System.Drawing.Point(214, 48);
            this.tbReprint.Name = "tbReprint";
            this.tbReprint.Size = new System.Drawing.Size(87, 29);
            this.tbReprint.TabIndex = 4;
            this.tbReprint.Text = "Reprint";
            this.tbReprint.UseVisualStyleBackColor = true;
            this.tbReprint.Click += new System.EventHandler(this.tbReprint_Click);
            // 
            // tbAssignementNumber
            // 
            this.tbAssignementNumber.Location = new System.Drawing.Point(125, 22);
            this.tbAssignementNumber.Name = "tbAssignementNumber";
            this.tbAssignementNumber.Size = new System.Drawing.Size(176, 20);
            this.tbAssignementNumber.TabIndex = 20;
            this.tbAssignementNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReprintForm_KeyPress);
            // 
            // lblAssignementNumber
            // 
            this.lblAssignementNumber.AutoSize = true;
            this.lblAssignementNumber.Location = new System.Drawing.Point(18, 25);
            this.lblAssignementNumber.Name = "lblAssignementNumber";
            this.lblAssignementNumber.Size = new System.Drawing.Size(101, 13);
            this.lblAssignementNumber.TabIndex = 19;
            this.lblAssignementNumber.Text = "Assignment Number";
            // 
            // ReprintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 91);
            this.Controls.Add(this.tbAssignementNumber);
            this.Controls.Add(this.lblAssignementNumber);
            this.Controls.Add(this.tbReprint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReprintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reprint Form";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReprintForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbReprint;
        private System.Windows.Forms.TextBox tbAssignementNumber;
        private System.Windows.Forms.Label lblAssignementNumber;
    }
}