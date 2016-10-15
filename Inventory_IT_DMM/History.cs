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
    public partial class History : Form
    {
        #region Variables
        public String Id = "";
        DataSet MyDs = new DataSet();
        private BindingSource bindingSource1 = new BindingSource();
        #endregion

        #region PageLoad
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            ExecuteSearch();
        }
        #endregion

        #region Functions
        private void ExecuteSearch()
        {
            PleaseWait frmPW = new PleaseWait();
            frmPW.Show();
            Application.DoEvents();

            MyDs.Tables.Clear();
            gvHistory.Rows.Clear();

            DataTable dt = new DataTable();
            String SQL = @"SELECT ItemId, ProductGroup, Description, SerialNumber as [Serial Number], DMMPropertyNum as [DMM Property Number],
                           Status, AssignedToDep as [Assigned To Department], AssignedTo as [Assigned To], Quantity, IPAddress as [IP Address], Vreme as [Date of change], UserName as [Changed by], Serviser as [Supplier/Servicer], AssignementNumber as [Assignment Form], i.AssignementId, RelatedBDA as [Related BDA], Notes FROM History i LEFT OUTER JOIN Assignement as a on a.AssignementId = i.AssignementID WHERE SerialNumber = '" + Id + "' ORDER BY Vreme DESC";
            dt = Vasko.ReturnDataTable(SQL);

            bindingSource1.DataSource = dt;
            gvHistory.DataSource = bindingSource1;
            gvHistory.Columns[0].Visible = false;
            gvHistory.Columns[14].Visible = false;
            frmPW.Close();
        }
        #endregion
    }

    #region Inherit classes
    public class History_Open : History
    {
        public History_Open(String ItemID)
        {
            Id = ItemID;
        }
    }
    #endregion
}
