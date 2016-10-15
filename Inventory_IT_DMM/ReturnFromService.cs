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
    public partial class ReturnFromService : Form
    {
        #region Variables
        public string inSerialNumber = "";
        public string itemId = "";
        public string serviceId = "";
        #endregion

        #region Load
        public ReturnFromService()
        {
            InitializeComponent();
        }

        private void ReturnFromService_Load(object sender, EventArgs e)
        {
            tbSerialNumber.Text = inSerialNumber;
        }
        #endregion

        #region Functions
        #endregion

        #region HandledEvents
        private void btnReturnFromService_Click(object sender, EventArgs e)
        {
            String SQL = "INSERT INTO History (Description,SerialNumber,DMMPropertyNum,Quantity,AssignedTo,AssignedToDep,Status,ProductGroup,IPAddress,UserName,Vreme,Serviser,AssignementId,RelatedBDA,Notes) SELECT Description,SerialNumber,DMMPropertyNum,Quantity,AssignedTo,AssignedToDep,Status,ProductGroup,IPAddress,UserName,Vreme,Serviser,AssignementId,RelatedBDA,Notes FROM Items WHERE ItemId=" + itemId;
            Vasko.ExecuteCommand(SQL);
            SQL = @"UPDATE Items SET Status='On Stock', Vreme= Now(), UserName='" + MyGlobals.UserName +
                  @"' WHERE ItemId=" + itemId;
            Vasko.ExecuteCommand(SQL);
            SQL = "UPDATE Service SET ReturnedOnDate = '"+calReturnedOn.Text+"', ReturnedBy='"+tbReturnedBy.Text+"', ReturnInformation ='"+tbReturnInfo.Text+"', ProcessedBy= '"+ MyGlobals.UserName +"', ProcessedOnDate=Now() WHERE ServiceId = " + serviceId ;
            Vasko.ExecuteCommand(SQL);
            this.Close();
        }
        #endregion
    }
}
