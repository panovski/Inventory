using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Word;
using System.Data;
using System.Data.OleDb;
using System.Security.Principal;

namespace Inventory_IT_DMM
{
    public class Funkcii
    {
        // Za printanje na Word so prv SQL da polni Bookmarks, a vtoriot da polni tabela
        public void PrintWord(String Dokument, String Sql, String Sql2="")
        {
            object missing = System.Reflection.Missing.Value;
            object oTemplate = Dokument;
            
            Microsoft.Office.Interop.Word.ApplicationClass oWordApp = new Microsoft.Office.Interop.Word.ApplicationClass();
            Microsoft.Office.Interop.Word.Document oWordDoc = oWordApp.Documents.Add(ref oTemplate, ref missing, ref missing, ref missing);

            DatabaseConn dc = new DatabaseConn();
            String strConnection = dc.AccessConnString();
            OleDbConnection MyConn = new OleDbConnection(strConnection);
            System.Data.DataTable dt = new System.Data.DataTable();
            System.Data.DataTable dt2 = new System.Data.DataTable();
            DataSet ds = new DataSet();

            OleDbDataAdapter da = new OleDbDataAdapter(Sql, MyConn);

            MyConn.Open();
            da.Fill(dt);
            MyConn.Close();
            ds.Tables.Add(dt);

            if (Sql2 != "") 
            { 
                OleDbDataAdapter da2 = new OleDbDataAdapter(Sql2, MyConn);
                MyConn.Open();
                da2.Fill(dt2);
                MyConn.Close();
                ds.Tables.Add(dt2);
            }

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                foreach (DataColumn dcol in ds.Tables[0].Columns)
                {
                    try
                    {
                        oWordDoc.Bookmarks[dcol.ColumnName].Range.Text = dr[dcol.ColumnName].ToString();
                    }
                    catch{}
                }
            }


            Int32 tTableForPrint = 0;
            if (ds.Tables.Count>1)
            {
                try
                {
                    for(int brTabeli = 1; brTabeli <= ds.Tables.Count-1; brTabeli++)
                    {
                        int BrRedovi = 1;
                        Boolean tPostoi = false;
                        Boolean tKreiranaTabela = false;
                        int rows = ds.Tables[brTabeli].Rows.Count;
                        int columns = ds.Tables[brTabeli].Columns.Count;

                        if (brTabeli <= oWordDoc.Tables.Count)
                        {
                            tTableForPrint += 1;
                            for (int tBrPostoecki = 1; tBrPostoecki <= oWordDoc.Tables.Count; tBrPostoecki++)
                            {
                                if(oWordDoc.Bookmarks["Table"+brTabeli].Range.Start >= oWordDoc.Tables[tBrPostoecki].Range.Start)
                                {
                                     if( (oWordDoc.Bookmarks["Table"+brTabeli].Range.Start >= oWordDoc.Tables[tBrPostoecki].Range.Start && 
                                         oWordDoc.Bookmarks["Table"+brTabeli].Range.Start <= oWordDoc.Tables[tBrPostoecki].Range.End ) ||
                                         (oWordDoc.Bookmarks["Table"+brTabeli].Range.End >= oWordDoc.Tables[tBrPostoecki].Range.Start &&
                                         oWordDoc.Bookmarks["Table"+brTabeli].Range.End >= oWordDoc.Tables[tBrPostoecki].Range.End ))
                                         //ako ima iskreirano tabeli vo template-ot:
                                     {
                                        BrRedovi = 1; tPostoi = true; tTableForPrint = tBrPostoecki;
                                        for(int tPostoeckiRows=1; tPostoeckiRows<= oWordDoc.Tables[tBrPostoecki].Rows.Count; tPostoeckiRows++)
                                        {
                                            for (int tPostoeckiColumns = 1; tPostoeckiColumns <= oWordDoc.Tables[tBrPostoecki].Columns.Count; tPostoeckiColumns++ )
                                            {
                                                if (oWordDoc.Tables[tBrPostoecki].Cell(tPostoeckiRows, tPostoeckiColumns).Range.Text.Length > 2)
                                                {
                                                    BrRedovi += 1;
                                                }
                                            }
                                            cont:;
                                        }

                                        if (tBrPostoecki > 1)
                                        {
                                            for (int tBr = 0; tBr <= rows - 2; tBr++)
                                            {
                                                oWordDoc.Tables[tBrPostoecki].Rows.Add();
                                            }
                                            goto cont1;
                                        }
                                     }
                                     else
                                     {
                                        tPostoi = false; tTableForPrint = tBrPostoecki;
                                     }
                                }
                            cont1:;
                            }
                        }
                        else tPostoi = false;

                        if (tPostoi ==false)
                        {
                            Range r = oWordDoc.Bookmarks["Table"+brTabeli].Range;
                            oWordDoc.Tables.Add(r,rows+1,columns);
                            BrRedovi=2;
                            tTableForPrint+=1;

                            int j = 1;
                            foreach(DataColumn dcc in ds.Tables[brTabeli].Columns)
                            {
                                oWordDoc.Tables[tTableForPrint].Cell(1,j).Range.InsertAfter(dcc.ColumnName);
                                j++;
                            }
                        }

                        int i = 2; // BrRedovi;
                        Boolean Insertiran = false;
                        foreach(DataRow drr in ds.Tables[brTabeli].Rows)
                        {
                            Insertiran = false;
                            for (int m = 2; m <=ds.Tables[brTabeli].Rows.Count; m++)
                            {
                                string pomTekst = oWordDoc.Tables[tTableForPrint].Cell(m, 1).Range.Text;
                                string pomTekst1 = oWordDoc.Tables[tTableForPrint].Cell(m, 2).Range.Text;
                                string pomTekst2 = oWordDoc.Tables[tTableForPrint].Cell(m, 5).Range.Text;
                                pomTekst2 = pomTekst2.Substring(0, pomTekst2.Length - 2);
                                if (drr[0].ToString() == pomTekst.Substring(0, pomTekst.Length - 2) && drr[1].ToString() == pomTekst1.Substring(0, pomTekst1.Length - 2))
                                {
                                    oWordDoc.Tables[tTableForPrint].Cell(m, 3).Range.InsertAfter("\n" + drr[2].ToString());
                                    oWordDoc.Tables[tTableForPrint].Cell(m, 4).Range.InsertAfter("\n" + drr[3].ToString());
                                    oWordDoc.Tables[tTableForPrint].Cell(m, 5).Range.Text = (Convert.ToInt32(pomTekst2) + Convert.ToInt32(drr[4])).ToString();
                                    Insertiran = true;
                                }
                            }
                            int j = 1;
                            if (!Insertiran)
                            {
                                foreach (DataColumn dc2 in ds.Tables[brTabeli].Columns)
                                {
                                    oWordDoc.Tables[tTableForPrint].Cell(i, j).Range.InsertAfter(drr[dc2.ColumnName].ToString());
                                    j++;
                                }
                            }
                            i++;
                        }

                    }
                }
                catch{}
            }

            if (ds.Tables.Count > 1)
            {
                for (int m = 2; m <= ds.Tables[1].Rows.Count; m++)
                {
                    if (oWordDoc.Tables[tTableForPrint].Cell(m, 1).Range.Text.Length == 2)
                    {
                        oWordDoc.Tables[tTableForPrint].Cell(m, 1).Row.Delete();
                    }
                }
            }
            oWordDoc.Activate();
            oWordDoc.Application.Visible = true;
            oWordDoc.Application.WindowState = Microsoft.Office.Interop.Word.WdWindowState.wdWindowStateMaximize; 

        }
    }

    public class MyGlobals
    {
        public static string UserName = "";
        public static string LoggedUser = WindowsIdentity.GetCurrent().Name;
        public static string[] liUser = LoggedUser.Split('\\');
        public static DatabaseConn dc = new DatabaseConn();
        public static string ConnectionStr = dc.AccessConnString();
        
        public void SetirajUserName()
        {
            if (liUser.Length > 1) UserName = liUser[1];
            else UserName = liUser[0];
        }
    }
}
