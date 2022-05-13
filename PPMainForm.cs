using Microsoft.Data.Sqlite;
using System;
using System.Windows.Forms;

namespace Peace_Portal_Payroll
{
    public partial class PPMainForm : Form
    {

        public PPMainForm()
        {
            InitializeComponent();
            //this.Id.Enabled = false;
        }

        private void PPMainForm_Load(Object sender, EventArgs e, object dataSource, SqliteConnection conn, SqliteConnection cnn)
        {
            {
                PayrollForm payrollForm = new PayrollForm();
                PayrollForm pf = payrollForm;
                pf.Show();
                this.Hide();
            }
        }
        private void BtClose_Click(object sender, EventArgs e) => System.Windows.Forms.Application.Exit();

        private void BtBalance_Click(object sender, EventArgs e)
        {
            RatesForm b2 = new RatesForm();
            b2.Show();
            this.Hide();
        }
        private void PPMainForm_Load_1(object sender, EventArgs e)
        {

        }
        private void BtDailyInfo_Click(object sender, EventArgs e)
        {
            PayrollForm payrollForm = new PayrollForm();
            PayrollForm pf = payrollForm;
            pf.Show();
            this.Hide();
        }
    }
}
