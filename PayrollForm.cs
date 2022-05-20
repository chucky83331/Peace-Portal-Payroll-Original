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
        int record = 0; // Record Unique Identifier. This is hidden Column and Textbox
        decimal Currency = 0;

        public PayrollForm()
        {
            InitializeComponent();

        }
        // This Fills or Refreshes DataGridView Section
        // ============================================
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
                                 dr.GetDecimal(7),// Total
                                 dr.GetDecimal(8));// ID2
            }
            
            // Resize the master DataGridView columns to fit the newly loaded data.
            grid.AutoResizeColumns();
            // Configure the details DataGridView so that its columns automatically
            // adjust their widths when the data changes.
            grid.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells;

            CalculateRunningTotal();
            removeTicks();
            Sort();
        }
        // TODO  Checkboxes start off as selected for some reason???
        // The following removes tick from checkbox's on program startup.
        // ==============================================================
        private void removeTicks()
        {
            var total = grid.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToString(p.Cells["WorkDate"].Value) != null).Count();

            for (int i = grid.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = grid.Rows[i];
                if (Convert.ToBoolean(row.Cells["cBox"].Value) == true)
                {
                    row.Cells["cBox"].Value = false;
                }
            }
        }
        // TODO  ******** Not working. **********
        // This will create database if it does not exist
        // ==============================================
        private void Create_db() 
        {
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
        // Program Start
        // =============
        private void PayrollForm_Load(object sender, EventArgs e)
        {
            Create_db();
            data_show();
            Sort();
            CalculateRunningTotal();
            Record();
        }
        // TODO - Try to find way of using Id column as Unique identifier to avoid the following:-
        // This Method increments Unique Id2 Column Row number for new rows.
        // This is necessery to Delete selected record only with identical info
        // ====================================================================
        private void Record()
        {
            record = Convert.ToByte(grid.Rows[0].Cells[9].Value);
            for (int i = 0; i < grid.Rows.Count; i++)
                {
                if (Convert.ToByte(grid.Rows[i].Cells[9].Value) > record)
                {
                    record = Convert.ToByte(grid.Rows[i].Cells[9].Value) + 1;
                }
            }
        }
        // Calculate RunningTotal, Total Hours Total Differentials in Pay Cheque Balancing Section
        // =======================================================================================
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

                // Total Total Hours and Differential in the Checking Pay Cheque Section.
                TxbTotalHrs.Text = "0";
                for (int i = 0; i < grid.Rows.Count; i++)
                    if (grid.Rows[i].Cells[7].Value != null)
                        TxbTotalHrs.Text = Convert.ToString(double.Parse(TxbTotalHrs.Text) + double.Parse(grid.Rows[i].Cells[7].Value.ToString()));

                TxbTotalDiff.Text = "0";
                for (int i = 0; i < grid.Rows.Count; i++)
                    if (grid.Rows[i].Cells[6].Value != null)
                        TxbTotalDiff.Text = Convert.ToString(double.Parse(TxbTotalDiff.Text) + double.Parse(grid.Rows[i].Cells[6].Value.ToString()));
            }
            catch (Exception)
            {
                MessageBox.Show("Error! Calculating ");
                return;
            }
        }
        // TODO Not being used sofar. Not sure if needed???
        // =================================================
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
                MessageBox.Show("Error! Cannot format this entry???");
                return;
            }
        }
        // Sort on Date column
        // ===================
        private void Sort()
        {
            grid.Sort(grid.Columns[2], System.ComponentModel.ListSortDirection.Ascending);
            
            SendKeys.Send("{DOWN}");
        }
        // Calculates Daily Total ie. (Rate + Diff) * Hours) = Total.
        // =========================================================
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
        // Sets Rate from ShitType Selection.
        // ==================================
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
        // Select records to delete from CheckBox's Ticked.
        // ===============================================
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
                    string id = drow.Cells[9].Value.ToString();
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
                    System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand("DELETE FROM PPDailyTable WHERE ID2='" + s + "'", con);
                    int result = cmd.ExecuteNonQuery();
                }
            }
            con.Close();
            grid.Rows.Clear();
            ClearTextBoxes();
            data_show();
            CalculateRunningTotal();

        // Insert new record with Unique Id2 number.
        // ========================================
        }
        private void btnInsert2_Click(object sender, EventArgs e)
        {
            record++;
            txbId.Text = record.ToString();
           
            var con = new System.Data.SQLite.SQLiteConnection(cs);
            con.Open();
            var cmd = new System.Data.SQLite.SQLiteCommand(con);

            try
            {
                cmd.CommandText = "INSERT INTO PPDailyTable(WorkDate,ShiftType,ShiftTime,Rate,Diff,HrsWork,Total,ID2)" +
                    " VALUES(@WorkDate,@ShiftType,@shiftTime,@Rate,@Diff,@HrsWork,@Total,@ID2)";

                string WORKDATE = dateTimePicker.Text;
                string SHIFTTYPE = cbShiftType.Text;
                string SHIFTTIME = cbShiftTime.Text;
                decimal RATE = Convert.ToDecimal(txbRate.Text);
                decimal DIFF = Convert.ToDecimal(cbDiff.Text);
                decimal HRSWORK = Convert.ToDecimal(txbHrsWork.Text);
                decimal TOTAL = Convert.ToDecimal(txbTotal.Text);
                decimal ID2 = Convert.ToByte(txbId.Text);

                cmd.Parameters.AddWithValue("@WorkDate", WORKDATE);
                cmd.Parameters.AddWithValue("@ShiftType", SHIFTTYPE);
                cmd.Parameters.AddWithValue("@ShiftTime", SHIFTTIME);
                cmd.Parameters.AddWithValue("@Rate", RATE);
                cmd.Parameters.AddWithValue("@Diff", DIFF);
                cmd.Parameters.AddWithValue("@HrsWork", HRSWORK);
                cmd.Parameters.AddWithValue("@Total", TOTAL);
                cmd.Parameters.AddWithValue("@ID2", ID2);

                string[] row = new string[] { WORKDATE, SHIFTTYPE, SHIFTTIME }; // Seems to work with only theses fields???
                grid.Rows.Add(row);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Error! Cannot insert record");
                return;
            }
            grid.Rows.Clear();
            ClearTextBoxes();
            data_show();
            CalculateRunningTotal();
            Record();
        }
        // Update for changes to record in Table.
        // =====================================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txbRate.Text.Substring(0, 1) == "$") txbRate.Text.Remove(0, 1);
            if (txbTotal.Text.Substring(0, 1) == "$") txbTotal.Text.Remove(0, 1);
            if (cbDiff.Text.Substring(0, 1) == "$") cbDiff.Text.Remove(0, 1);
            var con = new System.Data.SQLite.SQLiteConnection(cs);
            con.Open();

            var cmd = new System.Data.SQLite.SQLiteCommand(con);

            try
            {
                cmd.CommandText = "UPDATE PPDailyTable Set WorkDate=@WorkDate,ShiftType=@ShiftType," +
                    "ShiftTime=@ShiftTime,Rate=@Rate,Diff=@Diff,HrsWork=@HrsWork,Total=@Total,ID2=@ID2 " +
                    "WHERE ID2=@ID2";
                //cmd.CommandText = "INSERT INTO PPDailyTable (WorkDate,ShiftType,ShiftTime,Rate,Diff,HrsWork,Total) VALUES (@WorkDate,@ShiftType,@ShiftTime,@Rate,@Diff,@HrsWork,@Total)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@WorkDate", dateTimePicker.Text);
                cmd.Parameters.AddWithValue("@ShiftType", cbShiftType.Text);
                cmd.Parameters.AddWithValue("@ShiftTime", cbShiftTime.Text);
                cmd.Parameters.AddWithValue("@Rate", txbRate.Text);
                cmd.Parameters.AddWithValue("@Diff", cbDiff.Text);
                cmd.Parameters.AddWithValue("@HrsWork", txbHrsWork.Text);
                cmd.Parameters.AddWithValue("@Total", txbTotal.Text);
                cmd.Parameters.AddWithValue("@ID2", txbId.Text);
                
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot update data ");
                return;
            }
            ClearTextBoxes();
            grid.Rows.Clear();
            con.Close();
            data_show();
            CalculateRunningTotal();
        }
        // Reset TextBoxes after Inserting or Updating records
        // ===================================================
        private void ClearTextBoxes()
        {
            dateTimePicker.Text = DateTime.Now.ToString();
            cbShiftType.Text = string.Empty;
            cbShiftTime.Text = string.Empty;
            txbRate.Text = string.Empty;
            cbDiff.Text = string.Empty;
            txbHrsWork.Text = string.Empty;
            txbTotal.Text = string.Empty;
            txbId.Text = string.Empty;
        }
        // Select or Tick a checkbox in DataGridView List.
        // ==============================================
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
                    txbId.Text = grid.Rows[e.RowIndex].Cells["ID2"].FormattedValue.ToString();

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
                MessageBox.Show("Error! Try again");
                return;
            }
        }

        // FOLLOWING IS BALANCE PAY CHEQUE SECTION
        // =======================================
        private void PPDailyTableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CalculateRunningTotal();
            //FormatCurrency();
        }
        // Set selected Dates to Balance Pay Period
        // =========================================
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
            string stm = "SELECT * FROM PPDailyTable WHERE WorkDate Between " + datestart + "AND" + dateend;
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
                                 dr.GetDecimal(7),// Total
                                 dr.GetDecimal(8));// ID2
            }0
            // Sets up display to balance Pay Cheque
            TxbDeductions.Visible = true;
            Deductionlabel.Visible = true;
            TxbTotalHrs.Visible = true;
            TotalHrslabel.Visible = true;
            TxbTotalDiff.Visible = true;
            Differentiallabel.Visible = true;
            Differentiallabel.Visible = true;
            CheckTotalLabel.Visible = true;
            
            CalculateRunningTotal();
            //FormatCurrency();
            //removeTicks();
            Sort();
            ClearTextBoxes();

        }
        // Enter Deductions from Cheque to get NET pay.
        // ===========================================
        private void TxbDeductions_KeyDown(object sender, KeyEventArgs e)
        {
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
        // Clear Start and End Dates Section.
        // ==================================
        private void BtnCancel_Click(object sender, EventArgs e)
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