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
    public partial class PayrollForm : Form
    {
        public PayrollForm()
        {
            InitializeComponent();
        }

        private void PPDailyTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pPDailyTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._PPDataBase_MDFDataSet);
            this.pPDailyTableTableAdapter.Fill(this._PPDataBase_MDFDataSet.PPDailyTable);
        }

        private void PayrollForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_PPDataBase_MDFDataSet.PPDailyTable' table. You can move, or remove it, as needed.
            this.pPDailyTableTableAdapter.Fill(this._PPDataBase_MDFDataSet.PPDailyTable);

        }
        // This code Calculates Running Total for Textbox TxbRunningTotal.Text 
        void CalGridView()
        {
            double cal = 0;
            for (int i = 0; i < pPDailyTableDataGridView.Rows.Count; i++)
            {
                try
                {
                    cal = cal + double.Parse(pPDailyTableDataGridView.Rows[i].Cells[7].Value.ToString());
                }
                catch
                {

                }
                // Show Calculation in TextBox
                TxbRunningTotal.Text = cal.ToString();
            }
        }
        private void ShiftTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            if (CbShiftType.SelectedItem != null)
            {
                string curItem = CbShiftType.SelectedItem.ToString();
                if (curItem == "Regular Hours" || curItem == "Sick Day" || curItem == "Vacation Pay" || curItem == "Stat")
                {
                    TxbRate.Text = "25.33";
                }
                else if (curItem == "Stat 1.5" || curItem == "Over Time 1.5")
                {
                    TxbRate.Text = "37.995";
                }
                else if (curItem == "Stat 2.0" || curItem == "Over Time 2.0")
                {
                    TxbRate.Text = "50.66";
                }
            }
        }   
        private void TxbHour_TextChanged(object sender, EventArgs e)
        {
            // Text Boxes must have Decimal value.
            if (TxbHour.Text == "")
            {
                TxbHour.Text = "0";
            }
            if (CbDiff.Text == "")
            {
                CbDiff.Text = "0.00";
            }
            if (TxbRate.Text == "")
            {
                TxbRate.Text = "0.00";
            }
            decimal input1 = Convert.ToDecimal(TxbRate.Text);
            decimal input2 = Convert.ToDecimal(TxbHour.Text);
            input1 += Convert.ToDecimal(CbDiff.Text);  // Add Differential to input1
            decimal DailyTotal = input1 * input2;
            TxbTotal.Text = Convert.ToString(DailyTotal);
            TxbTotal.Text = string.Format("{0:c}", TxbTotal.Text);
        }
        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            workDateDateTimePicker.Focus();
        }

        private void PPDailyTableDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            CalGridView();
        }
        private void PPDailyTableDataGridView_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            CalGridView();
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            PPMainForm m2 = new PPMainForm();
            m2.Show();
            this.Hide();
        }

        private void BindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            workDateDateTimePicker.Focus();
        }
    }
}
