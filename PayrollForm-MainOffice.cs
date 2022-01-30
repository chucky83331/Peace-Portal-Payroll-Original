using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Peace_Portal_Payroll
{
    public partial class PayrollForm : Form
    {
        public PayrollForm()
        {
            InitializeComponent();
        }
        decimal Currency = 0;
        private void PayrollForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_PPDataBase_MDFDataSet.PPDailyTable' table. You can move, or remove it, as needed.
            this.pPDailyTableTableAdapter.Fill(this._PPDataBase_MDFDataSet.PPDailyTable);
            pPDailyTableDataGridView.Sort(pPDailyTableDataGridView.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
            pPDailyTableDataGridView.CurrentCell = pPDailyTableDataGridView.Rows[pPDailyTableDataGridView.Rows.Count - 1].Cells[1];
        }

        private void CalculateRunningTotal()
        {
            try
            {
                TxbRunningTotal.Text = "0";
                for (int i = 0; i < pPDailyTableDataGridView.Rows.Count; i++)
                    if (pPDailyTableDataGridView.Rows[i].Cells[7].Value != null)
                        TxbRunningTotal.Text = Convert.ToString(double.Parse(TxbRunningTotal.Text) + double.Parse(pPDailyTableDataGridView.Rows[i].Cells[7].Value.ToString()));
                Currency = Convert.ToDecimal(TxbRunningTotal.Text);
                TxbRunningTotal.Text = Currency.ToString("C");
               
                TxbTotalHrs.Text = "0";
                for (int i = 0; i < pPDailyTableDataGridView.Rows.Count; i++)
                    if (pPDailyTableDataGridView.Rows[i].Cells[6].Value != null)
                        TxbTotalHrs.Text = Convert.ToString(double.Parse(TxbTotalHrs.Text) + double.Parse(pPDailyTableDataGridView.Rows[i].Cells[6].Value.ToString()));
                
                // Total Differential in the Checking Pay Cheque Section.
                TxbTotalDiff.Text = "0";
                for (int i = 0; i < pPDailyTableDataGridView.Rows.Count; i++)
                    if (pPDailyTableDataGridView.Rows[i].Cells[6].Value != null)
                        TxbTotalDiff.Text = Convert.ToString(double.Parse(TxbTotalDiff.Text) + double.Parse(pPDailyTableDataGridView.Rows[i].Cells[5].Value.ToString()));

                // Total Differential * Hours in the Checking Pay Cheque Section.
                foreach (DataGridViewRow item in pPDailyTableDataGridView.Rows)
                {
                    int n = item.Index;
                    if (pPDailyTableDataGridView.Rows[n].Cells[5].Value != null)
                    {
                        pPDailyTableDataGridView.Rows[n].Cells[8].Value =
                        (Double.Parse(pPDailyTableDataGridView.Rows[n].Cells[5].Value.ToString()) *
                        Double.Parse(pPDailyTableDataGridView.Rows[n].Cells[6].Value.ToString())).ToString();
                    }
                }
                TxbTotalDiff.Text = "0";
                foreach (DataGridViewRow item in pPDailyTableDataGridView.Rows)
                {
                    int n = item.Index;
                    if (pPDailyTableDataGridView.Rows[n].Cells[5].Value != null)
                    {
                        TxbTotalDiff.Text = (Double.Parse(TxbTotalDiff.Text.ToString())
                        + Double.Parse(pPDailyTableDataGridView.Rows[n].Cells[8].Value.ToString())).ToString();
                    }
                }
            }
            catch (Exception)
            {
                //Errorlabel.Text = (e.Message);
            }
            FormatCurrency();
        }
        private void FormatCurrency()  // To add $ to Currency amounts in Text Boxes.
        {
            try
            {
                Currency = Convert.ToDecimal(TxbTotal.Text);
                TxbTotal.Text = Currency.ToString("C");
                Currency = Convert.ToDecimal(TxbRate.Text);
                TxbRate.Text = Currency.ToString("C");
                Currency = Convert.ToDecimal(CbDiff.Text);
                CbDiff.Text = Currency.ToString("C");
                if (TxbTotalDiff.Text.Substring(0, 1) == "$") TxbTotalDiff.Text = TxbTotalDiff.Text.Remove(0, 1);
                Currency = Convert.ToDecimal(TxbTotalDiff.Text);
                TxbTotalDiff.Text = Currency.ToString("C");
                Currency = Convert.ToDecimal(TxbRunningTotal.Text);
                TxbRunningTotal.Text = Currency.ToString("C");
            }
            catch (Exception)
            {
                //Errorlabel.Text = (e.Message);
            }
        }
        private void GoLast()
        {
            // Goto last record in GridView. 
            if (pPDailyTableDataGridView.Rows.Count > 0)
            {
                pPDailyTableDataGridView.CurrentCell = pPDailyTableDataGridView.Rows[pPDailyTableDataGridView.Rows.Count - 1].Cells[1];
            }
            pPDailyTableDataGridView.Sort(pPDailyTableDataGridView.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
            SendKeys.Send("{DOWN}");
            CalculateRunningTotal();
            FormatCurrency();
        }

        private void PPDailyTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pPDailyTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._PPDataBase_MDFDataSet);
            this.pPDailyTableTableAdapter.Fill(this._PPDataBase_MDFDataSet.PPDailyTable);
            GoLast();  // Goto last record in GridView.
        }
        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            // This line will go to first Row in DataGridView to avoid
            // Blank Date Column when duplicating the same Date on last Row.
            // This only happens when cursor on last Row ???
            pPDailyTableDataGridView.CurrentCell = pPDailyTableDataGridView.Rows[pPDailyTableDataGridView.Rows.Count - pPDailyTableDataGridView.Rows.Count].Cells[1];
        }
        private void TxbHour_TextChanged(object sender, EventArgs e)
        {
            // Text Boxes must have Decimal value.
            if (TxbHour.Text == "") TxbHour.Text = "0";
            if (CbDiff.Text == "") CbDiff.Text = "0.00";
            if (TxbRate.Text == "") TxbRate.Text = "0.00";
            if (TxbRate.Text.Substring(0, 1) == "$") TxbRate.Text = TxbRate.Text.Remove(0, 1);
            if (CbDiff.Text.Substring(0, 1) == "$") CbDiff.Text = CbDiff.Text.Remove(0, 1);
            decimal input1 = Convert.ToDecimal(TxbRate.Text);
            decimal input2 = Convert.ToDecimal(TxbHour.Text);
            input1 += Convert.ToDecimal(CbDiff.Text);  // Add Differential to input1
            decimal DailyTotal = input1 * input2;
            TxbTotal.Text = Convert.ToString(DailyTotal);
            Currency = Convert.ToDecimal(TxbTotal.Text);
            TxbTotal.Text = Currency.ToString("C");
        }
        private void ShiftTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the Rate for the Shift Type Selected and enter in the Rate Text Box.
            if (CbShiftType.SelectedItem != null)
            {
                TxbRate.Text = Peace_Portal_Payroll.Properties.Settings.Default.Rate1;
                string curItem = CbShiftType.SelectedItem.ToString();
                if (curItem == "Regular Hours" || curItem == "Sick Day" || curItem == "Vacation Pay" || curItem == "Stat")
                {
                    TxbRate.Text = Peace_Portal_Payroll.Properties.Settings.Default.Rate1;
                }
                else if (curItem == "Stat 1.5" || curItem == "Over Time 1.5")
                {
                    TxbRate.Text = Peace_Portal_Payroll.Properties.Settings.Default.Rate2;
                }
                else if (curItem == "Stat 2.0" || curItem == "Over Time 2.0")
                {
                    TxbRate.Text = Peace_Portal_Payroll.Properties.Settings.Default.Rate3;
                }
            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            PPMainForm m2 = new PPMainForm();
            m2.Show();
            this.Hide();
        }
        private void BindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            CalculateRunningTotal();
            FormatCurrency();
        }
        private void BindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            CalculateRunningTotal();
            FormatCurrency();
        }
        private void BindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            CalculateRunningTotal();
            FormatCurrency();
        }
        private void BindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            CalculateRunningTotal();
            FormatCurrency();
        }
        private void BtnDel_Click(object sender, EventArgs e)
        {
            int total = pPDailyTableDataGridView.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells["Delete"].Value) == true).Count();
            if (total > 0)
            {
                string message = $"Are you sure you want to delete {total} row?";
                if (total > 1)
                    message = $"Are you sure you want to delete {total} rows?";
                if (MessageBox.Show(message, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = pPDailyTableDataGridView.RowCount - 1; i >= 0; i--)
                    {
                        DataGridViewRow row = pPDailyTableDataGridView.Rows[i];
                        if (Convert.ToBoolean(row.Cells["Delete"].Value) == true)
                        {
                            pPDailyTableBindingSource.RemoveAt(row.Index);
                        }
                    }
                }
            }
            this.Validate();
            this.pPDailyTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._PPDataBase_MDFDataSet);
            this.pPDailyTableTableAdapter.Fill(this._PPDataBase_MDFDataSet.PPDailyTable);
            pPDailyTableDataGridView.CurrentCell = pPDailyTableDataGridView.Rows[pPDailyTableDataGridView.Rows.Count - 1].Cells[1];
            FormatCurrency();
        }
        // FOLLOWING IS BALANCE PAY CHEQUE SECTION
        // =======================================
        private void PPDailyTableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CalculateRunningTotal();
            FormatCurrency();
        }
        // Load selected Dates to Balance Pay Period
        private void DateRangebtn_Click(object sender, EventArgs e)
        {
            TxbDeductions.Focus();
            TxbDeductions.Text = "";
            this.pPDailyTableTableAdapter.FillByDates(this._PPDataBase_MDFDataSet.PPDailyTable, StartDateTimePicker1.Text, EndDateTimePicker2.Text);
            TxbDeductions.Visible = true;
            Deductionlabel.Visible = true;
            TxbTotalHrs.Visible = true;
            TotalHrslabel.Visible = true;
            TxbTotalDiff.Visible = true;
            Differentiallabel.Visible = true;
            Differentiallabel.Visible = true;
            CheckTotalLabel.Visible = true;
            CalculateRunningTotal();
            FormatCurrency();
            GoLast();
        }
        private void TxbDeductions_KeyDown(object sender, KeyEventArgs e)
        {
            // Balance Pay Cheque.
            if (e.KeyCode == Keys.Enter)
            {
                TxbRunningTotal.Focus();
                e.SuppressKeyPress = true;

                if (TxbRunningTotal.Text.Substring(0, 1) == "$") TxbRunningTotal.Text = TxbRunningTotal.Text.Remove(0, 1);
                if (TxbDeductions.Text == "") TxbDeductions.Text = "0.00";
                if (TxbDeductions.Text.Substring(0, 1) == "$") TxbDeductions.Text = TxbDeductions.Text.Remove(0, 1);
                double.TryParse(TxbRunningTotal.Text, out double in1);
                double.TryParse(TxbDeductions.Text, out double in2);
                in1 -= in2;
                if (in1 > 0) TxbRunningTotal.Text = in1.ToString("C"); TxbDeductions.Text = in2.ToString("C");
                BtnCancel.Focus();
                Errorlabel.Visible = false;
            }

            if (e.KeyCode != Keys.Enter)
            {
                Errorlabel.Visible = true;
                TxbDeductions.Focus();
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)  // Clear Date Range Section
        {
            this.pPDailyTableTableAdapter.Fill(this._PPDataBase_MDFDataSet.PPDailyTable);
            TxbRunningTotal.Text = "0.00";
            Currency = Convert.ToDecimal(TxbRunningTotal.Text);
            TxbRunningTotal.Text = Currency.ToString("C"); FormatCurrency();
            TxbDeductions.Visible = false;
            Deductionlabel.Visible = false;
            TxbTotalHrs.Visible = false;
            TotalHrslabel.Visible = false;
            TxbTotalDiff.Visible = false;
            Differentiallabel.Visible = false;
            CheckTotalLabel.Visible = false;
            CalculateRunningTotal();
            GoLast();
        }
     }
}
