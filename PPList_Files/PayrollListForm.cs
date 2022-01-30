using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Peace_Portal_Payroll
{
    public partial class PayrollListForm : Form
    {
        List<PPModel> shift = new List<PPModel>();
        public PayrollListForm()
        {
            InitializeComponent();
            LoadPayrollList();
        }
        private void LoadPayrollList()
        {
            shift = SqliteDataAccess.LoadPPDailyTable();
            WireUpShiftlistBox();
        }
        private void WireUpShiftlistBox()
        {
            ShiftlistBox.DataSource = null;
            ShiftlistBox.DataSource = shift;

            ShiftlistBox.DisplayMember = "WorkDate";
            ShiftlistBox.DisplayMember = "ShiftType";
            ShiftlistBox.DisplayMember = "ShiftTime";
            ShiftlistBox.DisplayMember = "Rate"; 
            ShiftlistBox.DisplayMember = "HrsWork";
            ShiftlistBox.DisplayMember = "Diff";
            ShiftlistBox.DisplayMember = "Total";
        }
        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            LoadPayrollList();
        }
        private void AddShiftbtn_Click(object sender, EventArgs e)
        {
            PPModel p = new PPModel();

            p.WorkDate = DateTime.Now;
            p.ShiftType = ShiftTypetxtBox.Text;
            p.ShiftTime = ShiftTimetxtBox.Text;
            p.Rate = Convert.ToDecimal(RatetxtBox.Text);
            p.HrsWork = Convert.ToDecimal(HrsworktxtBox.Text);
            p.Diff = Convert.ToDecimal(DifftxtBox.Text);
            //p.Total = Convert.ToDecimal(TotaltxtBox);

            SqliteDataAccess.Saveshift(p);

            ShiftTypetxtBox = null;
            ShiftTimetxtBox = null;
            RatetxtBox = null;
            HrsworktxtBox = null;   
            DifftxtBox = null;

        }
    }
}
        
    
   