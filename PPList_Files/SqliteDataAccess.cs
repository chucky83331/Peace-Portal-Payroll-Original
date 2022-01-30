using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;





// ADDED JANUARY 17TH 2022 FROM TIM CORREY UTUBE "USING SQLITE IN C#"

namespace Peace_Portal_Payroll
{
    public class SqliteDataAccess
    {
        public static List<PPModel> LoadPPDailyTable()
        {
            // NOTE: using 'using' at the beginning of the next line makes sure the connection closes.
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PPModel>("select * from PPDailyTable", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void Saveshift(PPModel pPModel)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into PPDailyTable (WorkDate, ShiftType, ShiftTime, Rate," +
                    " HrsWork, Diff, Total) values (@WorkDate, @ShiftType, @ShiftTime," +
                    " @Rate, @HrsWork, @Diff, @Total)", pPModel);
            }
        }
        private static string LoadConnectionString(string id = "SqliteCon")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
