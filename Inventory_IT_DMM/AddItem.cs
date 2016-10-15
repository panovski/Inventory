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
    public partial class AddItem : Form
    {
        #region Variables
        Boolean FirstLoad = false;
        public DataGridViewRow dgvr = new DataGridViewRow();
        public DataGridViewRow dgvrMulti = new DataGridViewRow();
        public String IdsForUpdate = "";
        Timer timer = new Timer();
        #endregion

        #region Load
        public AddItem()
        {
            InitializeComponent(); 
        }
        private void AddItem_Load(object sender, EventArgs e)
        {
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = (1000) * (2);
            timer.Enabled = true;

            Vasko.FillCombo("SELECT Description FROM ComboDef WHERE Grupa = 1 ORDER BY Description", cbProductGroup, "Description");
            Vasko.FillCombo("SELECT Description FROM ComboDef WHERE Grupa = 2 ORDER BY Description", cbStatus, "Description");
            Vasko.FillCombo("SELECT Description FROM ComboDef WHERE Grupa = 3 ORDER BY Description", cbAssignedToDep, "Description");

            FirstLoad = true;

            cbProductGroup.SelectedIndex = -1;
            cbDescription.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;

            SetirajZaEditForma();
            SetirajZaEditMultiForma();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            timer.Stop();
        }
        #endregion

        #region Functions
        private void SetirajZaEditForma()
        {
            if (dgvr.Cells.Count > 0)
            {
                cbProductGroup.Text = dgvr.Cells["ProductGroup"].Value.ToString();
                cbDescription.Text = dgvr.Cells["Description"].Value.ToString();
                tbSerialNumber.TextBox.Text = dgvr.Cells["Serial Number"].Value.ToString();
                tbDMMPropertyNum.TextBox.Text = dgvr.Cells["DMM Property Number"].Value.ToString();
                tbQuantity.TextBox.Text = dgvr.Cells["Quantity"].Value.ToString();
                cbStatus.Text = dgvr.Cells["Status"].Value.ToString();
                cbAssignedToDep.Text = dgvr.Cells["Assigned To Department"].Value.ToString(); 
                tbAssignedTo.TextBox.Text = dgvr.Cells["Assigned To"].Value.ToString();
                tbIPAddress.TextBox.Text = dgvr.Cells["IP Address"].Value.ToString();
                tbServiser.Text = dgvr.Cells["Supplier/Servicer"].Value.ToString();
                tbNotes.Text = dgvr.Cells["Notes"].Value.ToString();
                tbRelatedBDA.TextBox.Text = dgvr.Cells["Related BDA"].Value.ToString();
                cbBarcodeScann.Visible = false;
                lblInfo.Visible = false;
            }
        }
        private void SetirajZaEditMultiForma()
        {
            if (dgvrMulti.Cells.Count > 0)
            {
                cbProductGroup.Text = dgvrMulti.Cells["ProductGroup"].Value.ToString();
                cbDescription.Text = dgvrMulti.Cells["Description"].Value.ToString();
                tbSerialNumber.TextBox.ReadOnly = true;
                tbDMMPropertyNum.TextBox.ReadOnly = true;
                tbQuantity.TextBox.Text = dgvrMulti.Cells["Quantity"].Value.ToString();
                cbStatus.Text = dgvrMulti.Cells["Status"].Value.ToString();
                cbAssignedToDep.Text = dgvrMulti.Cells["Assigned To Department"].Value.ToString(); 
                tbAssignedTo.TextBox.Text = dgvrMulti.Cells["Assigned To"].Value.ToString();
                tbIPAddress.TextBox.Text = dgvrMulti.Cells["IP Address"].Value.ToString();
                tbServiser.Text = dgvrMulti.Cells["Supplier/Servicer"].Value.ToString();
                tbNotes.Text = dgvrMulti.Cells["Notes"].Value.ToString();
                tbRelatedBDA.TextBox.Text = dgvrMulti.Cells["Related BDA"].Value.ToString();
                gbUpdate.Visible = true;
                cbBarcodeScann.Visible = false;
                lblInfo.Visible = false;
            }
        }

        private void InsertComboStavka(ComboBox ComboVlez, Int32 vGrupa)
        {
            if (ComboVlez.Text.Length > 0)
            {
                String SelectCount = "SELECT COUNT(*) FROM ComboDef WHERE Grupa = " + vGrupa.ToString() + " AND Description = '" + ComboVlez.Text + "'";
                int Broj = Convert.ToInt32(Vasko.ExecuteScalar(SelectCount));
                if (Broj <= 0)
                {
                    String SQL = @"INSERT INTO ComboDef (Description, Grupa) VALUES ('" + ComboVlez.Text.Replace("'", "''") + "', " + vGrupa.ToString() + ")";
                    Vasko.ExecuteCommand(SQL);
                }
            }
        }

        #endregion

        #region Handled Events
        private void cbProductGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FirstLoad)
            if (cbProductGroup.Text != "System.Data.DataRowView")
            {
                Vasko.FillCombo("SELECT DISTINCT(Description) FROM Items WHERE ProductGroup = '" + cbProductGroup.Text.Trim() + "'", cbDescription, "Description");
            }

        }
        private void btnDodadi_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbQuantity.TextBox.Text.Length < 1) tbQuantity.TextBox.Text = "1";
                
                String SelectCount = "SELECT COUNT(*) FROM Items WHERE SerialNumber = '" + tbSerialNumber.TextBox.Text + "'";
                if (tbIPAddress.TextBox.Text.Length > 0)
                    SelectCount += " OR IPAddress='" + tbIPAddress.TextBox.Text + "'";
                
                int Broj = Convert.ToInt32(Vasko.ExecuteScalar(SelectCount));
                
                String dodatok = "";
                if(tbIPAddress.TextBox.Text.Length>0)
                    dodatok = " or with IP Address: " + tbIPAddress.TextBox.Text;
                String MessageInfo = "Already exists item with serial number: " + tbSerialNumber.TextBox.Text + dodatok + "! Can not be inserted another one!";

                if (Broj > 0) MessageBox.Show(MessageInfo, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String SQL = @"INSERT INTO Items (Description, SerialNumber, DMMPropertyNum, Quantity, AssignedToDep, AssignedTo, Status, 
                                ProductGroup, IPAddress, Vreme, UserName, Serviser, RelatedBDA, Notes) VALUES ('" + cbDescription.Text + "','" + tbSerialNumber.TextBox.Text +
                                    @"','" + tbDMMPropertyNum.TextBox.Text + "','" + tbQuantity.TextBox.Text + "','" + cbAssignedToDep.Text + "','" + tbAssignedTo.TextBox.Text +
                                    @"','" + cbStatus.Text + "','" + cbProductGroup.Text + "','" + tbIPAddress.TextBox.Text + "', Now(),'" + MyGlobals.UserName + "','" + tbServiser.Text + "','" + tbRelatedBDA.TextBox.Text + "','" + tbNotes.Text + "')";

                    Vasko.ExecuteCommand(SQL);

                    InsertComboStavka(cbProductGroup, 1);
                    InsertComboStavka(cbStatus, 2);
                    InsertComboStavka(cbAssignedToDep, 3);

                    if (!cbBarcodeScann.Checked)
                        MessageBox.Show("Successfully added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        lblInfo.Text = "Item inserted with barcode scanner!";
                        tbSerialNumber.TextBox.SelectAll();
                        tbSerialNumber.TextBox.Focus();
                        timer.Start();
                    }
                }
            }
            catch { MessageBox.Show("The record was not added!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbQuantity.TextBox.Text == "") tbQuantity.TextBox.Text = "1";
                
                if (dgvr.Cells.Count > 0)
                {
                    Boolean CanWrite = true;
                    if (dgvr.Cells["IP Address"].Value.ToString() != tbIPAddress.TextBox.Text)
                    {
                        String SelectCount = "SELECT COUNT(*) FROM Items WHERE IPAddress='" + tbIPAddress.TextBox.Text + "'";
                        int Broj = Convert.ToInt32(Vasko.ExecuteScalar(SelectCount));

                        String MessageInfo = "Already exists item with IP Address: " + tbIPAddress.TextBox.Text + "! Can not be inserted another one!";
                        if (Broj > 0)
                        {
                            MessageBox.Show(MessageInfo, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            CanWrite = false;
                            goto error1;
                        }
                        else
                        {
                            CanWrite = true;
                        }
                    }
                    else CanWrite = true;

                    if (dgvr.Cells["Serial Number"].Value.ToString() != tbSerialNumber.TextBox.Text)
                    {
                        String SelectCount = "SELECT COUNT(*) FROM Items WHERE SerialNumber='" + tbSerialNumber.TextBox.Text + "'";
                        int Broj = Convert.ToInt32(Vasko.ExecuteScalar(SelectCount));

                        String MessageInfo = "Already exists item with Serial Number: " + tbSerialNumber.TextBox.Text + "! Can not be inserted another one!";
                        if (Broj > 0)
                        {
                            MessageBox.Show(MessageInfo, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            CanWrite = false;
                            goto error1;
                        }
                        else
                        {
                            CanWrite = true;
                        }
                    }
                    else CanWrite = true;


                    if (CanWrite)
                    {
                        String SQL = "INSERT INTO History (Description,SerialNumber,DMMPropertyNum,Quantity,AssignedTo,AssignedToDep,Status,ProductGroup,IPAddress,UserName,Vreme,Serviser,AssignementId,RelatedBDA,Notes) SELECT Description,SerialNumber,DMMPropertyNum,Quantity,AssignedTo,AssignedToDep,Status,ProductGroup,IPAddress,UserName,Vreme,Serviser,AssignementId,RelatedBDA,Notes FROM Items WHERE ItemId=" + dgvr.Cells["ItemId"].Value.ToString();
                        Vasko.ExecuteCommand(SQL);
                        SQL = @"UPDATE Items SET Description='" + cbDescription.Text + "',SerialNumber='" + tbSerialNumber.TextBox.Text +
                                        @"',DMMPropertyNum='" + tbDMMPropertyNum.TextBox.Text + "',Quantity='" + tbQuantity.TextBox.Text + "',AssignedTo='" + tbAssignedTo.TextBox.Text + "',AssignedToDep='" + cbAssignedToDep.Text +
                                        @"',Status='" + cbStatus.Text + "',ProductGroup='" + cbProductGroup.Text + "',IPAddress='" + tbIPAddress.TextBox.Text + "',Vreme= Now(), UserName='" + MyGlobals.UserName +
                                        @"',Serviser='" + tbServiser.Text + "',RelatedBDA='" + tbRelatedBDA.TextBox.Text + "', Notes='" + tbNotes.Text +
                                        @"' WHERE ItemId=" + dgvr.Cells["ItemId"].Value.ToString();
                        Vasko.ExecuteCommand(SQL);
                    }
                    
                }
                else if (dgvrMulti.Cells.Count > 0)
                {
                    String SQL = @"UPDATE Items SET " ;
                    String SQL_ADDED = "";
                    if(cbProduct.Checked) SQL_ADDED += " ProductGroup='" + cbProductGroup.Text + "'";
                    if(cbDescr.Checked) { if(SQL_ADDED!="") SQL_ADDED += ","; SQL_ADDED += " Description='" + cbDescription.Text + "'";}
                    if(cbQuantity.Checked) { if(SQL_ADDED!="") SQL_ADDED += ","; SQL_ADDED += " Quantity='" + tbQuantity.TextBox.Text + "'";}
                    if(cbStat.Checked) { if(SQL_ADDED!="") SQL_ADDED += ","; SQL_ADDED += " Status='" + cbStatus.Text + "'";}
                    if(cbAssToDep.Checked) { if(SQL_ADDED!="") SQL_ADDED += ","; SQL_ADDED += " AssignedToDep='" + cbAssignedToDep.Text + "'";}
                    if(cbAssigned.Checked) { if(SQL_ADDED!="") SQL_ADDED += ","; SQL_ADDED += " AssignedTo='" + tbAssignedTo.TextBox.Text + "'";}
                    if(cbIPAddr.Checked) { if(SQL_ADDED!="") SQL_ADDED += ","; SQL_ADDED += " IPAddress='" + tbIPAddress.TextBox.Text + "'";}
                    if(cbServicer.Checked) { if(SQL_ADDED!="") SQL_ADDED += ","; SQL_ADDED += " Serviser='" + tbServiser.Text + "'";}
                    if (cbNotes.Checked) { if (SQL_ADDED != "") SQL_ADDED += ","; SQL_ADDED += " Notes='" + tbNotes.Text + "'"; }
                    if (cbRelatedBDA.Checked) { if (SQL_ADDED != "") SQL_ADDED += ","; SQL_ADDED += " RelatedBDA='" + tbRelatedBDA.TextBox.Text + "'"; }
                    
                    if(SQL_ADDED!="") SQL_ADDED += ", Vreme= Now(), UserName='" + MyGlobals.UserName + "' WHERE ItemId IN (" + IdsForUpdate + ")";

                    if (SQL_ADDED != "")
                    {
                        String SQL_History = "INSERT INTO History (Description,SerialNumber,DMMPropertyNum,Quantity,AssignedTo,AssignedToDep,Status,ProductGroup,IPAddress,UserName,Vreme,Serviser,AssignementId,RelatedBDA,Notes) SELECT Description,SerialNumber,DMMPropertyNum,Quantity,AssignedTo,AssignedToDep,Status,ProductGroup,IPAddress,UserName,Vreme,Serviser,AssignementId,RelatedBDA,Notes FROM Items WHERE ItemId IN (" + IdsForUpdate + ") ; ";
                        Vasko.ExecuteCommand(SQL_History);
                        Vasko.ExecuteCommand(SQL + SQL_ADDED);
                    }
                }

                InsertComboStavka(cbProductGroup, 1);
                InsertComboStavka(cbStatus, 2);
                InsertComboStavka(cbAssignedToDep, 3);

                    MessageBox.Show("Successfully added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                
            }
            catch { MessageBox.Show("The record was not added!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error); }
        error1: ;
        }

        private void AddItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "\r":
                    if (btnEdit.Visible) btnEdit_Click(null, null);
                    else if (btnDodadi.Visible) btnDodadi_Click(null, null);

                    break;
            }
        }
        #endregion
    }

    #region Inherit classes
    public class AddItem_Insert : AddItem
    { 
        public AddItem_Insert()
        {
            btnDodadi.Visible = true;
            btnEdit.Visible = false;
        }
    }

    public class AddItem_Edit : AddItem
    {
        public AddItem_Edit(DataGridViewRow dr)
        {
            dgvr = dr;
            btnDodadi.Visible = false;
            btnEdit.Visible = true;
            //cbProductGroup.Enabled = false;
            
        }
    }
    public class AddItem_MultiEdit : AddItem
    {
        public AddItem_MultiEdit(DataGridViewRow dr, String ids)
        {
            dgvrMulti = dr;
            btnDodadi.Visible = false;
            btnEdit.Visible = true;
            IdsForUpdate = ids;
        }
    }
#endregion
}
