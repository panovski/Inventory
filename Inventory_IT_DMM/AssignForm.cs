#region Using
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Inventory_IT_DMM.Class;
#endregion

namespace Inventory_IT_DMM
{
    public partial class AssignForm : Form
    {
        #region Variables
        public DataGridViewRow dgvr = new DataGridViewRow();
        public string ItemID = "";
        public bool CreateAssignment { get; set; }
        public string ids = "";
        public bool more = false;
        public string quantity = "";
        #endregion

        #region PageLoad
        public AssignForm()
        {
            InitializeComponent();
        }

        private void AssignForm_Load(object sender, EventArgs e)
        {
            Vasko.FillCombo("SELECT Description FROM ComboDef WHERE Grupa = 3 ORDER BY Description", cbAssignToDep, "Description");
            Vasko.FillCombo("SELECT DISTINCT(AssignedTo) as AssignedTo FROM Items", cbAssignedTo, "AssignedTo");
            if (more)
                tbQuantity.Text = "1";
            else
                tbQuantity.Text = quantity;// dgvr.Cells["Quantity"].Value.ToString();

            if (tbQuantity.Text.Length < 1)
            {
                tbQuantity.Text = "1";
                quantity = "1";
            }
            if (Convert.ToInt32(tbQuantity.Text) < 2)
            {
                tbQuantity.ReadOnly = true;
                cbAssignementForm.Visible = true;
            }
        }
        #endregion

        #region HandledEvents
        private void tbAssign_Click(object sender, EventArgs e)
        {
            if (cbAssignedTo.Text.Length < 1 || cbAssignToDep.Text.Length < 1)
            {
                MessageBox.Show("You must fill all values!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                if (Convert.ToInt32(tbQuantity.Text) < 1 || Convert.ToInt32(tbQuantity.Text) > Convert.ToInt32(quantity))// dgvr.Cells["Quantity"].Value))
                {
                    MessageBox.Show("There are not enough quantity to assign this item!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (cbAssignementForm.Checked)
                        CreateAssignment = true;
                    else
                        CreateAssignment = false;

                    try
                    {
                        String SQL = "INSERT INTO History (Description,SerialNumber,DMMPropertyNum,Quantity,AssignedTo,AssignedToDep,Status,ProductGroup,IPAddress,UserName,Vreme,Serviser,AssignementId,RelatedBDA,Notes) SELECT Description,SerialNumber,DMMPropertyNum,Quantity,AssignedTo,AssignedToDep,Status,ProductGroup,IPAddress,UserName,Vreme,Serviser,AssignementId,RelatedBDA,Notes FROM Items WHERE ItemId IN (" + ids + ")";//dgvr.Cells["ItemId"].Value.ToString() ;
                        Vasko.ExecuteCommand(SQL);

                        if (Convert.ToInt32(tbQuantity.Text) >= 1 && Convert.ToInt32(quantity) > 1)
                        {
                            int Difference = Convert.ToInt32(quantity) - Convert.ToInt32(tbQuantity.Text);
                            SQL = @"UPDATE Items SET Quantity= " + Difference.ToString() + ", Notes = Notes & '- " + tbQuantity.Text + " assigned to: " + cbAssignedTo.Text + " on ' & FORMAT(Now(),'dd.MM.yyyy') & ' by:" + MyGlobals.UserName + "\r\n',Vreme= Now(), UserName='" + MyGlobals.UserName +
                                              @"' WHERE ItemId=" + dgvr.Cells["ItemId"].Value.ToString();
                        }
                        else
                            SQL = @"UPDATE Items SET Status='Assigned', AssignedTo='" + cbAssignedTo.Text + "', AssignedToDep='" + cbAssignToDep.Text + "', Vreme= Now(), UserName='" + MyGlobals.UserName +
                                              @"' WHERE ItemId IN (" + ids +  ")";//dgvr.Cells["ItemId"].Value.ToString();

                        Vasko.ExecuteCommand(SQL);
                    }
                    catch { }
                    this.Close();
                }

        }

        private void AssignForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "\r":
                    if (cbAssignToDep.Visible)
                        tbAssign_Click(sender, e);
                    else
                        btnReturn_Click(sender, e);
                    break;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (cbAssignedTo.Text.Length < 1)
            {
                MessageBox.Show("You must fill all values!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cbAssignementForm.Checked)
                    CreateAssignment = true;
                else
                    CreateAssignment = false;

                try
                {
                    String SQL = "INSERT INTO History (Description,SerialNumber,DMMPropertyNum,Quantity,AssignedTo,AssignedToDep,Status,ProductGroup,IPAddress,UserName,Vreme,Serviser,AssignementId,RelatedBDA,Notes) SELECT Description,SerialNumber,DMMPropertyNum,Quantity,AssignedTo,AssignedToDep,Status,ProductGroup,IPAddress,UserName,Vreme,Serviser,AssignementId,RelatedBDA,Notes FROM Items WHERE ItemId IN (" + ids + ")";
                    Vasko.ExecuteCommand(SQL);
                    String PreviousAssigned = Vasko.ExecuteScalar("SELECT TOP 1 AssignedTo FROM Items WHERE ItemId IN (" + ids + ")");
                    SQL = @"UPDATE Items SET Status='On Stock', AssignedTo='" + cbAssignedTo.Text + "', AssignedToDep='IT', Vreme= Now(), UserName='" + MyGlobals.UserName + "', ReturnPersonTmp='" + PreviousAssigned +
                          @"' WHERE ItemId IN (" + ids + ")";

                    Vasko.ExecuteCommand(SQL);
                }
                catch { }
                this.Close();
            }
        }
        #endregion
    }

#region Inherit_Class
    public class Assign: AssignForm
    {
        public Assign(DataGridViewRow dr)
        {
            tbAssign.Visible = true;
            btnReturn.Visible = false;
            dgvr = dr;
            ids = dgvr.Cells["ItemId"].Value.ToString();
            quantity = dgvr.Cells["Quantity"].Value.ToString();
            //cbProductGroup.Enabled = false;
        }
    }

    public class AssignMore : AssignForm
    {
        public AssignMore(String ids_in)
        {
            tbAssign.Visible = true;
            btnReturn.Visible = false;
            ids = ids_in;
            more = true;
            quantity = "1";
        }
    }

    public class Return : AssignForm
    {
        public Return(String ids_in)
        {
            tbAssign.Visible = false;
            btnReturn.Visible = true;
            ids = ids_in;
            cbAssignementForm.Text = "Create Return Form";
            cbAssignToDep.Visible = false;
            lblAssignToDep.Visible = false;
            lblAssignTo.Text = "Return to";
        }
    }
#endregion
}
