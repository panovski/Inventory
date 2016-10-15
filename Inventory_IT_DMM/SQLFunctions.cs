using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;
using System.Security.Principal;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Xml;
using Inventory_IT_DMM;
using System.Threading;

namespace Inventory_IT_DMM
{
    public class SQLGlobals
    {
        public bool CheckExistingSQL(String SQL)
        {
            DatabaseConn dc = new DatabaseConn();
            String strConnection = dc.AccessConnString();
            OleDbConnection MyConnection = new OleDbConnection(strConnection);
            String SelectCount = SQL;
            OleDbCommand cmd = new OleDbCommand(SelectCount, MyConnection);
            MyConnection.Open();
            int Broj = Convert.ToInt32(cmd.ExecuteScalar());
            MyConnection.Close();
            if (Broj > 0) return true;
            else return false;
        }
        
        public OleDbCommand CreatedCommand(String str, OleDbConnection MyC)
        {

            DatabaseConn dc = new DatabaseConn();
            String strConnection = dc.AccessConnString();
            OleDbCommand cmd = new OleDbCommand(str, MyC);
            return cmd;
        }
    }
}
