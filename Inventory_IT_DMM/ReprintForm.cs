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
    public partial class ReprintForm : Form
    {
        #region Variables
        public string ItemID = "";
        #endregion

        #region PageLoad
        public ReprintForm()
        {
            InitializeComponent();
        }
        #endregion

        #region HandledEvents
        private void tbReprint_Click(object sender, EventArgs e)
        {
            if (tbAssignementNumber.Text.Length > 0)
            {
                PleaseWait frmPW = new PleaseWait();
                frmPW.Show();
                Application.DoEvents();

                String Selected = "";
                String SelectedAssignements = "";
                String Assigned = "";
                String OdbranTip = "";

                String AssignementId = Vasko.ExecuteScalar("SELECT AssignementId FROM Assignement WHERE AssignementNumber = '" + tbAssignementNumber.Text + "'");
                if (AssignementId != "")
                {
                    String Tip = Vasko.ExecuteScalar("SELECT [Type] FROM Assignement WHERE AssignementID=" + AssignementId);
                    if (Tip == "1") OdbranTip = "IT_Assignement_Form.dot";
                    else if (Tip == "2") OdbranTip = "IT_Temporary_Form.dot";
                    else if (Tip == "3") OdbranTip = "IT_Returning_Form.dot";

                    DataTable dt = new DataTable();
                    dt = Vasko.ReturnDataTable("SELECT ItemId FROM Assignement_Item WHERE AssignementId = " + AssignementId);

                    foreach (DataRow drow in dt.Rows)
                    {
                        if (Selected != "") Selected += ",";
                        Selected += drow[0].ToString();

                    }

                    if (SelectedAssignements != "") SelectedAssignements += ",";
                    {
                        if (!SelectedAssignements.Contains(AssignementId))
                            SelectedAssignements += AssignementId;
                    }

                    Funkcii f = new Funkcii();
                    DatabaseConn dbc = new DatabaseConn();
                    string[] AllAssignements = SelectedAssignements.Split(',');
                    foreach (string str in AllAssignements)
                    {
                        String SqlPrint = @"SELECT AssignementTo as AssignedTo, AssignementNumber, AssignedBy, Format(AssignedOnDate, 'dd.MM.yyyy') as AssignedOn FROM Assignement WHERE AssignementId=" + str + "; ";
                        String SqlPrint2 = @"SELECT ProductGroup, Description, DMMPropertyNum, SerialNumber, Quantity FROM Items WHERE ItemId IN (" + Selected + ") ";
                        f.PrintWord(dbc.TemplatePath() + @"\" + OdbranTip, SqlPrint, SqlPrint2);
                    }
                }
                else
                {
                    MessageBox.Show("There is no assignment form as the entered number!", "Not exists!", MessageBoxButtons.OK);
                }
                frmPW.Close();
            }
        }
        private void ReprintForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "\r":
                    tbReprint_Click(sender, e);
                    break;
            }
        }
        private void tbAssignementNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "\r":
                    tbReprint_Click(sender, e);
                    break;
            }
        }
        #endregion     
    }
}
