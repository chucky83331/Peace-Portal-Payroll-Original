using Microsoft.Data.Sqlite;
using System;
using System.Data;
using System.Data.SQLite;

namespace Peace_Portal_Payroll
{
    internal class SQLiteDataAdapter
    {
        private string conn;
        //private SqliteConnection sql;
        //private string v;
        //private SQLiteConnection conn1;
                
        public SQLiteDataAdapter(string conn, SQLiteConnection sQLite)
        {
            this.conn = conn;
            //this. = ;
        }

        internal void Fill(DataSet dset, string conn)
        {
            
        }
    }
}