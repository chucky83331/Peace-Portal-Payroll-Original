using System;
using System.Windows.Forms;

namespace Peace_Portal_Payroll
{
    public partial class RatesForm : Form
    {
        public RatesForm()
        {
            InitializeComponent();

        }
        private void BalanceForm_Load(object sender, EventArgs e)
        {
            Rate1.Text = Peace_Portal_Payroll.Properties.Settings.Default.Rate1;
            Rate2.Text = Peace_Portal_Payroll.Properties.Settings.Default.Rate2;
            Rate3.Text = Peace_Portal_Payroll.Properties.Settings.Default.Rate3;
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            PPMainForm f1 = new PPMainForm();
            f1.Show();
            this.Hide();
        }
        private void Savebtn_Click(object sender, EventArgs e)
        {
            Peace_Portal_Payroll.Properties.Settings.Default.Rate1 = Rate1.Text;
            Peace_Portal_Payroll.Properties.Settings.Default.Rate2 = Rate2.Text;
            Peace_Portal_Payroll.Properties.Settings.Default.Rate3 = Rate3.Text;
            Peace_Portal_Payroll.Properties.Settings.Default.Save();
        
            string message = $"Your new Rates have been saved." + Environment.NewLine + "Click <OK> to continue.";
            MessageBox.Show(message, "Changes Made.", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
} 
  