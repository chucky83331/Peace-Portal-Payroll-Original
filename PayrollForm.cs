using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace Peace_Portal_Payroll
{
    public partial class PayrollForm : Form
    {
        string path = "PPDatabase.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\PPDatabase.db";

        System.Data.SQLite.SQLiteConnection con;
        System.Data.SQLite.SQLiteCommand cmd;
        SQLiteDataReader dr;

        public PayrollForm()
        {
            InitializeComponent();

        }
        public void data_show() // Was private I changed to public???
        {
            var con = new System.Data.SQLite.SQLiteConnection(cs);
            con.Open();
            string stm = "SELECT * FROM PPDailyTable";
            var cmd = new System.Data.SQLite.SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                grid.Rows.Insert(0,

                    dr.GetFieldType(0),

                                 dr.GetInt32(0),   // Id
                                 dr.GetString(1),  // WorkDate
                                 dr.GetString(2),  // ShiftType
                                 dr.GetString(3),  // ShiftTime
                                 dr.GetDecimal(4), // Rate
                                 dr.GetDecimal(5), // Diff
                                 dr.GetDecimal(6), // HrsWork
                                 dr.GetDecimal(7));// Total
            }
            // Resize the master DataGridView columns to fit the newly loaded data.
            grid.AutoResizeColumns();
            // Configure the details DataGridView so that its columns automatically
            // adjust their widths when the data changes.
            grid.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells;

            CalculateRunningTotal();
            removeticks();
            Sort();
        }

        private void removeticks()
        {
            // The following removes tick from checkbox on program startup.
            var total = grid.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToString(p.Cells["WorkDate"].Value) != null).Count();

            for (int i = grid.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = grid.Rows[i];
                if (Convert.ToBoolean(row.Cells["cBox"].Value) == true)
                {
                    row.Cells["cBox"].Value = false;
                }
                if (total > 0)
                {
                    row.Cells["ConvDate"].Value = ("'" + (Convert.ToDateTime(row.Cells["WorkDate"].Value) + "'"));
                    total = total - 1;
                    //MessageBox.Show("ConvDate Is :" + row.Cells["ConvDate"].Value);
                }
            }
        }
        private void Create_db()
        {
            // TODO         ******** Not working.
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
                {
                    sqlite.Open();
                    string sql = "create table PPDailyTable(WorkDate varchar(20),ShiftType varchar (30),ShiftTime varchar (30))";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                Console.WriteLine("Cannot create Database");
                Console.ReadLine();
                return;
            }
        }
        decimal Currency = 0;
        private void PayrollForm_Load(object sender, EventArgs e)
        {
            Create_db();
            data_show();
            Sort();
            CalculateRunningTotal();
        }
        private void CalculateRunningTotal()
        {
            try
            {
                // Calculate RunningTotal
                TxbRunningTotal.Text = "0";
                for (int i = 0; i < grid.Rows.Count; i++)
                    if (grid.Rows[i].Cells[7].Value != null)
                        TxbRunningTotal.Text = Convert.ToString(double.Parse(TxbRunningTotal.Text) + double.Parse(grid.Rows[i].Cells[8].Value.ToString()));
                Currency = Convert.ToDecimal(TxbRunningTotal.Text);
                TxbRunningTotal.Text = Currency.ToString("C");

                TxbTotalHrs.Text = "0";
                for (int i = 0; i < grid.Rows.Count; i++)
                    if (grid.Rows[i].Cells[7].Value != null)
                        TxbTotalHrs.Text = Convert.ToString(double.Parse(TxbTotalHrs.Text) + double.Parse(grid.Rows[i].Cells[7].Value.ToString()));

                // Total Differential in the Checking Pay Cheque Section.
                TxbTotalDiff.Text = "0";
                for (int i = 0; i < grid.Rows.Count; i++)
                    if (grid.Rows[i].Cells[6].Value != null)
                        TxbTotalDiff.Text = Convert.ToString(double.Parse(TxbTotalDiff.Text) + double.Parse(grid.Rows[i].Cells[6].Value.ToString()));
            }
            catch (Exception)
            {
                //Errorlabel.Text = (e.Message);
            }
        }

        private void FormatCurrency()  // To add $ to Currency amounts in Text Boxes.
        {
            try
            {
                Currency = Convert.ToDecimal(txbTotal.Text);
                txbTotal.Text = Currency.ToString("C");
                Currency = Convert.ToDecimal(txbRate.Text);
                txbRate.Text = Currency.ToString("C");
                //Currency = Convert.ToDecimal(cbDiff.Text);    // $ not needed for Diff
                //cbDiff.Text = Currency.ToString("C");
                if (TxbTotalDiff.Text.Substring(0, 1) == "$") TxbTotalDiff.Text = TxbTotalDiff.Text.Remove(0, 1);
                Currency = Convert.ToDecimal(TxbTotalDiff.Text);
                TxbTotalDiff.Text = Currency.ToString("C");
                Currency = Convert.ToDecimal(TxbRunningTotal.Text);
                TxbRunningTotal.Text = Currency.ToString("C");
            }
            catch (Exception)
            {
                return;
            }
        }
        private void Sort()
        {
            // Goto last record in GridView and Sorts by Date. 
            if (grid.Rows.Count > 0)
            {
                //grid.CurrentCell = grid.Rows[grid.Rows.Count - 1].Cells[1];
                grid.Sort(grid.Columns[9], System.ComponentModel.ListSortDirection.Ascending);
            }
            SendKeys.Send("{DOWN}");
            CalculateRunningTotal();
        }
        private void TxbHour_TextChanged(object sender, EventArgs e)
        {
            // Text Boxes must have Decimal value.
            if (txbHrsWork.Text == "") txbHrsWork.Text = "0";
            if (cbDiff.Text == "") cbDiff.Text = "0.00";
            if (txbRate.Text == "") txbRate.Text = "0.00";
            if (txbRate.Text.Substring(0, 1) == "$") txbRate.Text = txbRate.Text.Remove(0, 1);
            if (cbDiff.Text.Substring(0, 1) == "$") cbDiff.Text = cbDiff.Text.Remove(0, 1);
            decimal input1 = Convert.ToDecimal(txbRate.Text);
            decimal input2 = Convert.ToDecimal(txbHrsWork.Text);
            input1 += Convert.ToDecimal(cbDiff.Text);  // Add Differential to input1
            decimal DailyTotal = input1 * input2;
            txbTotal.Text = Convert.ToString(DailyTotal);
            Currency = Convert.ToDecimal(txbTotal.Text);
        }
        private void ShiftTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the Rate for the Shift Type Selected and enter in the Rate Text Box.
            if (cbShiftType.SelectedItem != null)
            {
                txbRate.Text = Peace_Portal_Payroll.Properties.Settings.Default.Rate1;
                string curItem = cbShiftType.SelectedItem.ToString();
                if (curItem == "Regular Hours" || curItem == "Sick Day" || curItem == "Vacation Pay" || curItem == "Stat")
                {
                    txbRate.Text = Peace_Portal_Payroll.Properties.Settings.Default.Rate1;
                }
                else if (curItem == "Stat 1.5" || curItem == "Over Time 1.5")
                {
                    txbRate.Text = Peace_Portal_Payroll.Properties.Settings.Default.Rate2;
                }
                else if (curItem == "Stat 2.0" || curItem == "Over Time 2.0")
                {
                    txbRate.Text = Peace_Portal_Payroll.Properties.Settings.Default.Rate3;
                }
            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            PPMainForm m2 = new PPMainForm();
            m2.Show();
            this.Hide();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            int total = 0;
            var con = new System.Data.SQLite.SQLiteConnection(cs);
            con.Open();

            List<string> selectedItem = new List<string>();
            DataGridViewRow drow = new DataGridViewRow();
            for (int i = 0; i <= grid.Rows.Count - 1; i++)
            {
                drow = grid.Rows[i];
                if (Convert.ToBoolean(drow.Cells["cBox"].Value) == true)    // Checking if checked or not.
                {
                    string id = drow.Cells[4].Value.ToString();
                    selectedItem.Add(id); //If checked adding it to the list
                    total++;
                }
            }
            string message = $"Are you sure you want to delete {total} row?";
            if (total > 0)
                message = $"Are you sure you want to delete {total} rows?";
            if (MessageBox.Show(message, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (string s in selectedItem) //Using foreach loop to delete the records stored in list.  
                {
                    System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand("DELETE FROM PPDailyTable WHERE ShiftTime='" + s + "'", con);
                    int result = cmd.ExecuteNonQuery();
                }
            }
            con.Close();
            grid.Rows.Clear();
            ClearTextBoxes();
            data_show();
            CalculateRunningTotal();

        }
        private void btnInsert2_Click(object sender, EventArgs e)
        {
            var con = new System.Data.SQLite.SQLiteConnection(cs);
            con.Open();
            var cmd = new System.Data.SQLite.SQLiteCommand(con);

            try
            {
                cmd.CommandText = "INSERT INTO PPDailyTable(WorkDate,ShiftType,ShiftTime,Rate,Diff,HrsWork,Total) VALUES(@WorkDate,@ShiftType,@shiftTime,@Rate,@Diff,@HrsWork,@Total)";

                string WORKDATE = dateTimePicker.Text;
                string SHIFTTYPE = cbShiftType.Text;
                string SHIFTTIME = cbShiftTime.Text;
                decimal RATE = Convert.ToDecimal(txbRate.Text);
                decimal DIFF = Convert.ToDecimal(cbDiff.Text);
                decimal HRSWORK = Convert.ToDecimal(txbHrsWork.Text);
                decimal TOTAL = Convert.ToDecimal(txbTotal.Text);

                cmd.Parameters.AddWithValue("@WorkDate", WORKDATE);
                cmd.Parameters.AddWithValue("@ShiftType", SHIFTTYPE);
                cmd.Parameters.AddWithValue("@ShiftTime", SHIFTTIME);
                cmd.Parameters.AddWithValue("@Rate", RATE);
                cmd.Parameters.AddWithValue("@Diff", DIFF);
                cmd.Parameters.AddWithValue("@HrsWork", HRSWORK);
                cmd.Parameters.AddWithValue("@Total", TOTAL);

                string[] row = new string[] { WORKDATE, SHIFTTYPE, SHIFTTIME };   //, Convert.ToString(RATE), Convert.ToString(DIFF), Convert.ToString(HRSWORK), Convert.ToString(TOTAL) };

                grid.Rows.Add(row);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Error! Cannot insert data");
                return;
            }
            grid.Rows.Clear();
            ClearTextBoxes();
            data_show();
            CalculateRunningTotal();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var con = new System.Data.SQLite.SQLiteConnection(cs);
            con.Open();

            var cmd = new System.Data.SQLite.SQLiteCommand(con);

            try
            {
                cmd.CommandText = "UPDATE PPDailyTable Set WorkDate=@WorkDate,ShiftType=@ShiftType," +
                    "ShiftTime=@ShiftTime,Rate=@Rate,Diff=@Diff,HrsWork=@HrsWork,Total=@Total " +
                    "WHERE WorkDate=@WorkDate";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@WorkDate", dateTimePicker.Text);
                cmd.Parameters.AddWithValue("@ShiftType", cbShiftType.Text);
                cmd.Parameters.AddWithValue("@ShiftTime", cbShiftTime.Text);
                cmd.Parameters.AddWithValue("@Rate", txbRate.Text);
                cmd.Parameters.AddWithValue("@Diff", cbDiff.Text);
                cmd.Parameters.AddWithValue("@HrsWork", txbHrsWork.Text);
                cmd.Parameters.AddWithValue("@Total", txbTotal.Text);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot update data");
                return;
            }
            ClearTextBoxes();
            grid.Rows.Clear();
            con.Close();
            data_show();
            CalculateRunningTotal();
        }
        private void ClearTextBoxes()
        {
            dateTimePicker.Text = DateTime.Now.ToString();
            cbShiftType.Text = string.Empty;
            cbShiftTime.Text = string.Empty;
            txbRate.Text = string.Empty;
            cbDiff.Text = string.Empty;
            txbHrsWork.Text = string.Empty;
            txbTotal.Text = string.Empty;
        }
        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    grid.CurrentCell.ReadOnly = true;
                    dateTimePicker.Text = grid.Rows[e.RowIndex].Cells["WorkDate"].FormattedValue.ToString();
                    cbShiftType.Text = grid.Rows[e.RowIndex].Cells["ShiftType"].FormattedValue.ToString();
                    cbShiftTime.Text = grid.Rows[e.RowIndex].Cells["ShiftTime"].FormattedValue.ToString();
                    txbRate.Text = grid.Rows[e.RowIndex].Cells["Rate"].FormattedValue.ToString();
                    cbDiff.Text = grid.Rows[e.RowIndex].Cells["Diff"].FormattedValue.ToString();
                    txbHrsWork.Text = grid.Rows[e.RowIndex].Cells["HrsWork"].FormattedValue.ToString();
                    txbTotal.Text = grid.Rows[e.RowIndex].Cells["Total"].FormattedValue.ToString();

                    DataGridViewRow row = grid.Rows[e.RowIndex];
                    if (grid.CurrentCell.GetType() == typeof(DataGridViewCheckBoxCell))
                        if (Convert.ToBoolean(row.Cells["cBox"].Value) == true)
                        {
                            row.Cells["cBox"].Value = false;
                            return;
                        }
                        else
                        {
                            row.Cells["cBox"].Value = true;
                            return;
                        }
                }

            }
            catch
            {
                //MessageBox.Show("Index out of range");
                return;
            }
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

            string datestart = "'" + StartDateTimePicker1.Text + "'";   // SQLite has to have single quotes in Dates.
            string dateend = "'" + EndDateTimePicker2.Text + "'";
            grid.Rows.Clear();
            grid.Refresh();

            var con = new System.Data.SQLite.SQLiteConnection(cs);
            con.Open();
            string stm = "SELECT * FROM PPDailyTable WHERE WorkDate Between " + datestart + "AND" + dateend + "ORDER BY WorkDate";
            var cmd = new System.Data.SQLite.SQLiteCommand(stm, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                grid.Rows.Insert(0,

                    dr.GetFieldType(0),

                                 dr.GetInt32(0),   // Id
                                 dr.GetString(1),  // WorkDate
                                 dr.GetString(2),  // ShiftType
                                 dr.GetString(3),  // ShiftTime
                                 dr.GetDecimal(4), // Rate
                                 dr.GetDecimal(5), // Diff
                                 dr.GetDecimal(6), // HrsWork
                                 dr.GetDecimal(7));// Total
            }
            removeticks();

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
            Sort();
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
            }

            if (e.KeyCode != Keys.Enter)
            {
                TxbDeductions.Focus();
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)  // Clear Date Range Section
        {
            grid.Rows.Clear();
            grid.Refresh();
            data_show();
            TxbRunningTotal.Text = "0.00";
            Currency = Convert.ToDecimal(TxbRunningTotal.Text);
            //TxbRunningTotal.Text = Currency.ToString("C"); FormatCurrency();
            TxbDeductions.Visible = false;
            Deductionlabel.Visible = false;
            TxbTotalHrs.Visible = false;
            TotalHrslabel.Visible = false;
            TxbTotalDiff.Visible = false;
            Differentiallabel.Visible = false;
            CheckTotalLabel.Visible = false;
            CalculateRunningTotal();
        }
    }
}