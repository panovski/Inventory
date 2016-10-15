using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventory_IT_DMM.Class
{
    class Vasko
    {
        #region Custom_Classes
        public static Boolean ExecuteCommand(String SQL)
        {
            OleDbConnection connection = new OleDbConnection(MyGlobals.ConnectionStr);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connection;
            try
            {
                connection.Open();
                cmd.CommandText = SQL;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
            finally
            { connection.Close(); }
        }

        public static string ExecuteScalar(String SQL)
        {
            try
            {
                OleDbConnection connection = new OleDbConnection(MyGlobals.ConnectionStr);
                OleDbCommand cmd = new OleDbCommand(SQL,connection);
                connection.Open();

                string tPom = cmd.ExecuteScalar().ToString();
                connection.Close();
                return tPom;
            }
            catch { return ""; }
        }

        public static String[] ReadIntoArray(String SQL, int NumberOfColumns)
        {
            String[] Array = new String[NumberOfColumns];

            OleDbConnection connection = new OleDbConnection(MyGlobals.ConnectionStr);
            OleDbCommand cmd = new OleDbCommand(SQL, connection);
            try
            {
                connection.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    for (int Br = 0; Br < NumberOfColumns; Br++)
                        Array[Br] = reader[Br].ToString();
                }
                reader.Close();
                connection.Close();
                return Array;
            }
            catch (Exception err) { String[] Empty = new String[0]; return Empty; }
            finally
            {
                connection.Close();
            }
        }

        public static OleDbCommand ReturnCommand(String SQL)
        {
            OleDbConnection connection = new OleDbConnection(MyGlobals.ConnectionStr);
            OleDbCommand cmd = new OleDbCommand(SQL, connection);
            return cmd;
        }

        public static DataTable ReturnDataTable(String SQL)
        {
            try
            {
                OleDbConnection connection = new OleDbConnection(MyGlobals.ConnectionStr);
                OleDbCommand cmd = new OleDbCommand(SQL, connection);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                connection.Open();
                da.Fill(dt);
                return dt;
            }
            catch { DataTable Empty = new DataTable(); return Empty; }
        }

        public static void FillCombo(String pSQL, ComboBox Control, String DisplayMember)
        {
            DataTable dt = new DataTable();
            dt = ReturnDataTable(pSQL);

            DataSet MyDS = new DataSet();
            MyDS.Tables.Add(dt);
            Control.DataSource = MyDS.Tables[0].DefaultView;
            Control.DisplayMember = DisplayMember;
        }

        #endregion
    }
}
