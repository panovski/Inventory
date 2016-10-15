using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Inventory_IT_DMM
{
    public class DatabaseConn
    {
        // Vrakja pateka za SQL string zemena od Config File-ot
        public string ReturnConnString()
        {
            var data = File
           .ReadAllLines("DatabaseConfig.txt")
           .Select(x => x.Split('='))
           .Where(x => x.Length > 1)
           .ToDictionary(x => x[0].Trim(), x => x[1]);

            return @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + data["path"] + @"\InventoryDB.mdf;Connect Timeout=100;Integrated Security=True;User Instance=True;";
        }

        // Vrakja pateka za MS Access string zemena od Config File-ot
        public string AccessConnString()
        {
            var data = File
           .ReadAllLines("DatabaseConfig.txt")
           .Select(x => x.Split('='))
           .Where(x => x.Length > 1)
           .ToDictionary(x => x[0].Trim(), x => x[1]);

            //Jet OLEDB:Database Password=password";

            return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+data["path"]+@"\InventoryDB.accdb;";
        }

        // Vrakja patekata od Config File-ot za Template-ite (Word)
        public string TemplatePath()
        {
            var data = File
           .ReadAllLines("DatabaseConfig.txt")
           .Select(x => x.Split('='))
           .Where(x => x.Length > 1)
           .ToDictionary(x => x[0].Trim(), x => x[1]);

           return data["TemplatePath"] ;
        }
    }
}
