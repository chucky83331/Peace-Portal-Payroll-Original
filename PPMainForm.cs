using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Peace_Portal_Payroll
{
        public partial class PPMainForm : Form
    {

        private static string dbCommand = "";
        private static BindingSource bindingSrc;

        private static string dbPath = Application.StartupPath + "\\" + "PPDatabase.db";
        private static string conString = "Data Source=" + dbPath + "Version=3;New=False;Compress=True;";

        private static SQLiteConnection connection = new SQLiteConnection(conString);
        private static SQLiteCommand command = new SQLiteCommand("", connection);

        private static string sql;


        public PPMainForm()
        {
            InitializeComponent();
            //this.Id.Enabled = false;
        }

        private void PPMainForm_Load(Object sender, EventArgs e)
        {

            openConnection();

            closeConnection();
        }

        private void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("The connection is: " + connection.State.ToString());
            }
        }

        private void openConnection()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
                MessageBox.Show("The connection is: " + connection.State.ToString());
            }
        }

        private void BtDailyInfo_Click(object sender, EventArgs e)
        {
            PayrollForm payrollForm = new PayrollForm();
            PayrollForm f2 = payrollForm;
               f2.Show();
               this.Hide();
        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtBalance_Click(object sender, EventArgs e)
        {
            RatesForm b2 = new RatesForm();
            b2.Show();
            this.Hide();
        }
    }
}
