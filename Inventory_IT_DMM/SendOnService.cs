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
    public partial class SendOnService : Form
    {
        #region Variables
        public Boolean PrintReverse = false;
        public Boolean PrintAddress = false;
        public String NewId = "";
        #endregion

        #region Load
        public SendOnService()
        {
            InitializeComponent();
        }

        private void SendOnService_Load(object sender, EventArgs e)
        {
            Vasko.FillCombo("SELECT DISTINCT(SerialNumber) as SerialNumber FROM Items", cbSerialNumber, "SerialNumber");
            Vasko.FillCombo("SELECT DISTINCT(DMMPropertyNum) as DMMPropertyNum FROM Items", cbDMMNumber, "DMMPropertyNum");
            Vasko.FillCombo("SELECT DISTINCT(Servicer) as Servicer FROM Service", cbServicer, "Servicer");
            Vasko.FillCombo("SELECT DISTINCT(CostCenter) as CostCenter FROM Service", cbCostCenter, "CostCenter");
        }
        #endregion

        #region Functions
        #endregion

        #region HandledEvents
        private void cbSerialNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSerialNumber.Text != "")
            {
                cbDMMNumber.Text = Vasko.ExecuteScalar("SELECT TOP 1 DMMPropertyNum FROM Items WHERE SerialNumber = '" + cbSerialNumber.Text.Replace("'", "''") + "'");
                pbRequiredSerial.Visible = false;
            }
        }

        private void cbDMMNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDMMNumber.Text != "")
                cbSerialNumber.Text = Vasko.ExecuteScalar("SELECT TOP 1 SerialNumber FROM Items WHERE DMMPropertyNum = '" + cbDMMNumber.Text.Replace("'", "''") + "'");
        }

        private void cbServicer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbServicer.Text != "")
                tbServicerContact.Text = Vasko.ExecuteScalar("SELECT TOP 1 ServicerContact FROM Service WHERE Servicer = '" + cbServicer.Text.Replace("'","''") + "'");
        }

        private void btnSendOnService_Click(object sender, EventArgs e)
        {
            if (cbSerialNumber.Text != "")
            {
                if (Convert.ToInt32(Vasko.ExecuteScalar("SELECT COUNT(*) FROM Items WHERE SerialNumber ='" + cbSerialNumber.Text + "'")) > 0)
                {
                    String ItemID = Vasko.ExecuteScalar("SELECT ItemID FROM Items WHERE SerialNumber = '" + cbSerialNumber.Text + "'");
                    String SQL = "INSERT INTO History (Description,SerialNumber,DMMPropertyNum,Quantity,AssignedTo,AssignedToDep,Status,ProductGroup,IPAddress,UserName,Vreme,Serviser,AssignementId,RelatedBDA,Notes) SELECT Description,SerialNumber,DMMPropertyNum,Quantity,AssignedTo,AssignedToDep,Status,ProductGroup,IPAddress,UserName,Vreme,Serviser,AssignementId,RelatedBDA,Notes FROM Items WHERE ItemId=" + ItemID;
                    Vasko.ExecuteCommand(SQL);
                    SQL = @"UPDATE Items SET Status='On Service', Vreme= Now(), UserName='" + MyGlobals.UserName +
                          @"',Serviser='" + cbServicer.Text + "' WHERE ItemId=" + ItemID;
                    Vasko.ExecuteCommand(SQL);
                    SQL = "INSERT INTO Service (ItemId, SentOnDate, Problem, SentBy, Servicer, ServicerContact, ProcessedBy, ProcessedOnDate, RelatedBDAService, CostCenter) VALUES (" +
                          ItemID + @", '" + calSentOn.Text + "', '" + tbProblem.Text.Replace("'", "''") + "', '" + tbSentBy.Text.Replace("'", "''") + "', '" + cbServicer.Text + "', '" + tbServicerContact.Text.Replace("'", "''") + "', '" + MyGlobals.UserName + "', Now(), '"+tbRelatedBDA.Text+"','"+cbCostCenter.Text+"')";
                    Vasko.ExecuteCommand(SQL);
                    NewId = Vasko.ExecuteScalar("SELECT MAX(ServiceId) as ServiceId FROM Service");
                    PrintReverse = cbReverseForm.Checked;
                    PrintAddress = cbAddress.Checked;
                    this.Close();
                }
                else
                    MessageBox.Show("The inserted Serial Number is not correct!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                pbRequiredSerial.Visible = true;
        }
        #endregion
    }
}
