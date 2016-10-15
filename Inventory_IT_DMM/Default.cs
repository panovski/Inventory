#region Using
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Principal;
#endregion

namespace Inventory_IT_DMM
{
    public partial class Default : Form
    {
        #region Load
        public Default()
        {
            InitializeComponent();
            imgPreview.Image = ilListaSliki.Images[2];
            imgAddItem.Image = ilListaSliki.Images[1];
            imgService.Image = ilListaSliki.Images[4];

            MyGlobals fGlobalni = new MyGlobals();
            fGlobalni.SetirajUserName();
            lblUser.Text = MyGlobals.UserName;
        }
        
        #endregion

        #region Handled Events
        private void imgPreview_Click(object sender, EventArgs e)
        {
            //DatabaseConn dc = new DatabaseConn();
            //String conn = dc.ReturnConnString();

            Cursor.Current = Cursors.WaitCursor;
            Preview pw = new Preview();
            pw.Show();
            Cursor.Current = Cursors.Default;
        }

        private void exiitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();

        }

        private void imgAddItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            AddItem_Insert ai = new AddItem_Insert();
            ai.Show();
            Cursor.Current = Cursors.Default;
        }

        private void newItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgAddItem_Click(null, null);
        }

        private void previewItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgPreview_Click(null, null);
        }

        private void imgAddItem_MouseEnter(object sender, EventArgs e)
        {
            imgAddItem.Image = ilListaSliki.Images[0];
        }

        private void imgAddItem_MouseLeave(object sender, EventArgs e)
        {
            imgAddItem.Image = ilListaSliki.Images[1];
        }

        private void imgPreview_MouseEnter(object sender, EventArgs e)
        {
            imgPreview.Image = ilListaSliki.Images[3];
        }

        private void imgPreview_MouseLeave(object sender, EventArgs e)
        {
            imgPreview.Image = ilListaSliki.Images[2];
        }

        private void imgService_MouseEnter(object sender, EventArgs e)
        {
            imgService.Image = ilListaSliki.Images[5];
        }

        private void imgService_MouseLeave(object sender, EventArgs e)
        {
            imgService.Image = ilListaSliki.Images[4];
        }
        
        private void imgService_Click(object sender, EventArgs e)
        {
            Service s = new Service();
            s.Show();
        }

        private void Default_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                mynotifyIcon.Visible = true;
                mynotifyIcon.ShowBalloonTip(500, "Information", "Inventory DMM was minimized, but not closed! You can restore it by double-click!", ToolTipIcon.Info);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                mynotifyIcon.Visible = false;
            }
        }

        private void mynotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
        #endregion
    }
}
