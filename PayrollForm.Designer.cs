
using System.Windows.Forms;

namespace Peace_Portal_Payroll
{
    partial class PayrollForm
    {
        // <summary>
        // Required designer variable.
        // </summary>
        private System.ComponentModel.IContainer components = null;

        // <summary>
        // Clean up any resources being used.
        // </summary>
        // <param name = "disposing" > true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // <summary>
        // Required method for Designer support - do not modify
        // the contents of this method with the code editor.
        // </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label workDateLabel;
            System.Windows.Forms.Label shiftTypeLabel;
            System.Windows.Forms.Label shiftTimeLabel;
            System.Windows.Forms.Label rateLabel;
            System.Windows.Forms.Label hrsWorkLabel;
            System.Windows.Forms.Label diffLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label runningTotalLabel;
            System.Windows.Forms.Label LbHrsWork;
            System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayrollForm));
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cbShiftType = new System.Windows.Forms.ComboBox();
            this.cbShiftTime = new System.Windows.Forms.ComboBox();
            this.txbRate = new System.Windows.Forms.TextBox();
            this.txbHrsWork = new System.Windows.Forms.TextBox();
            this.cbDiff = new System.Windows.Forms.ComboBox();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.TxbRunningTotal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DateRangebtn = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StartDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.EndDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.BtnExit = new System.Windows.Forms.Button();
            this.TxbDeductions = new System.Windows.Forms.TextBox();
            this.Deductionlabel = new System.Windows.Forms.Label();
            this.TotalHrslabel = new System.Windows.Forms.Label();
            this.Differentiallabel = new System.Windows.Forms.Label();
            this.TxbTotalHrs = new System.Windows.Forms.TextBox();
            this.TxbTotalDiff = new System.Windows.Forms.TextBox();
            this.CheckTotalLabel = new System.Windows.Forms.Label();
            this.CopyRightlabel = new System.Windows.Forms.Label();
            this.BtnDel = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.WorkDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiftType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiftTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HrsWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnInsert2 = new System.Windows.Forms.Button();
            workDateLabel = new System.Windows.Forms.Label();
            shiftTypeLabel = new System.Windows.Forms.Label();
            shiftTimeLabel = new System.Windows.Forms.Label();
            rateLabel = new System.Windows.Forms.Label();
            hrsWorkLabel = new System.Windows.Forms.Label();
            diffLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            runningTotalLabel = new System.Windows.Forms.Label();
            LbHrsWork = new System.Windows.Forms.Label();
            bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // workDateLabel
            // 
            workDateLabel.AutoSize = true;
            workDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            workDateLabel.Location = new System.Drawing.Point(10, 17);
            workDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            workDateLabel.Name = "workDateLabel";
            workDateLabel.Size = new System.Drawing.Size(99, 20);
            workDateLabel.TabIndex = 3;
            workDateLabel.Text = "Work Date:";
            workDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shiftTypeLabel
            // 
            shiftTypeLabel.AutoSize = true;
            shiftTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            shiftTypeLabel.Location = new System.Drawing.Point(13, 49);
            shiftTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            shiftTypeLabel.Name = "shiftTypeLabel";
            shiftTypeLabel.Size = new System.Drawing.Size(95, 20);
            shiftTypeLabel.TabIndex = 5;
            shiftTypeLabel.Text = "Shift Type:";
            shiftTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shiftTimeLabel
            // 
            shiftTimeLabel.AutoSize = true;
            shiftTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            shiftTimeLabel.Location = new System.Drawing.Point(13, 85);
            shiftTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            shiftTimeLabel.Name = "shiftTimeLabel";
            shiftTimeLabel.Size = new System.Drawing.Size(95, 20);
            shiftTimeLabel.TabIndex = 7;
            shiftTimeLabel.Text = "Shift Time:";
            shiftTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rateLabel
            // 
            rateLabel.AutoSize = true;
            rateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rateLabel.Location = new System.Drawing.Point(302, 13);
            rateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            rateLabel.Name = "rateLabel";
            rateLabel.Size = new System.Drawing.Size(53, 20);
            rateLabel.TabIndex = 9;
            rateLabel.Text = "Rate:";
            rateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hrsWorkLabel
            // 
            hrsWorkLabel.AutoSize = true;
            hrsWorkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            hrsWorkLabel.Location = new System.Drawing.Point(208, 56);
            hrsWorkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            hrsWorkLabel.Name = "hrsWorkLabel";
            hrsWorkLabel.Size = new System.Drawing.Size(0, 20);
            hrsWorkLabel.TabIndex = 11;
            // 
            // diffLabel
            // 
            diffLabel.AutoSize = true;
            diffLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            diffLabel.Location = new System.Drawing.Point(253, 46);
            diffLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            diffLabel.Name = "diffLabel";
            diffLabel.Size = new System.Drawing.Size(103, 20);
            diffLabel.TabIndex = 13;
            diffLabel.Text = "Differential:";
            diffLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            totalLabel.Location = new System.Drawing.Point(295, 111);
            totalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(54, 20);
            totalLabel.TabIndex = 15;
            totalLabel.Text = "Total:";
            totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // runningTotalLabel
            // 
            runningTotalLabel.AutoSize = true;
            runningTotalLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            runningTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            runningTotalLabel.Location = new System.Drawing.Point(476, 410);
            runningTotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            runningTotalLabel.Name = "runningTotalLabel";
            runningTotalLabel.Size = new System.Drawing.Size(120, 17);
            runningTotalLabel.TabIndex = 17;
            runningTotalLabel.Text = "Running Total :";
            runningTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbHrsWork
            // 
            LbHrsWork.AutoSize = true;
            LbHrsWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            LbHrsWork.Location = new System.Drawing.Point(291, 77);
            LbHrsWork.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            LbHrsWork.Name = "LbHrsWork";
            LbHrsWork.Size = new System.Drawing.Size(67, 20);
            LbHrsWork.TabIndex = 12;
            LbHrsWork.Text = "Hours :";
            LbHrsWork.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bindingNavigatorMoveNextItem
            // 
            bindingNavigatorMoveNextItem.AutoSize = false;
            bindingNavigatorMoveNextItem.BackColor = System.Drawing.Color.Red;
            bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(134, 124);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.Window;
            this.dateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(106, 13);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(150, 26);
            this.dateTimePicker.TabIndex = 1;
            // 
            // cbShiftType
            // 
            this.cbShiftType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbShiftType.FormattingEnabled = true;
            this.cbShiftType.Items.AddRange(new object[] {
            "Regular Hours",
            "Stat 1.5",
            "Stat 2.0",
            "Over Time 1.5",
            "Over Time 2.0",
            "Sick Day",
            "Vacation Pay"});
            this.cbShiftType.Location = new System.Drawing.Point(106, 45);
            this.cbShiftType.Margin = new System.Windows.Forms.Padding(2);
            this.cbShiftType.Name = "cbShiftType";
            this.cbShiftType.Size = new System.Drawing.Size(150, 28);
            this.cbShiftType.TabIndex = 2;
            this.cbShiftType.SelectedIndexChanged += new System.EventHandler(this.ShiftTypeComboBox_SelectedIndexChanged);
            // 
            // cbShiftTime
            // 
            this.cbShiftTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbShiftTime.FormattingEnabled = true;
            this.cbShiftTime.Items.AddRange(new object[] {
            "Morning",
            "Evening",
            "Night"});
            this.cbShiftTime.Location = new System.Drawing.Point(106, 81);
            this.cbShiftTime.Margin = new System.Windows.Forms.Padding(2);
            this.cbShiftTime.Name = "cbShiftTime";
            this.cbShiftTime.Size = new System.Drawing.Size(150, 28);
            this.cbShiftTime.TabIndex = 3;
            // 
            // txbRate
            // 
            this.txbRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbRate.Location = new System.Drawing.Point(383, 10);
            this.txbRate.Margin = new System.Windows.Forms.Padding(2);
            this.txbRate.Name = "txbRate";
            this.txbRate.Size = new System.Drawing.Size(91, 26);
            this.txbRate.TabIndex = 4;
            this.txbRate.TabStop = false;
            this.txbRate.Text = "0.00";
            this.txbRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbHrsWork
            // 
            this.txbHrsWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbHrsWork.Location = new System.Drawing.Point(383, 75);
            this.txbHrsWork.Margin = new System.Windows.Forms.Padding(2);
            this.txbHrsWork.Name = "txbHrsWork";
            this.txbHrsWork.Size = new System.Drawing.Size(91, 26);
            this.txbHrsWork.TabIndex = 6;
            this.txbHrsWork.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbHrsWork.Leave += new System.EventHandler(this.TxbHour_TextChanged);
            // 
            // cbDiff
            // 
            this.cbDiff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbDiff.FormatString = "C2";
            this.cbDiff.FormattingEnabled = true;
            this.cbDiff.Items.AddRange(new object[] {
            "0.50",
            "0.75",
            "0.00"});
            this.cbDiff.Location = new System.Drawing.Point(400, 41);
            this.cbDiff.Margin = new System.Windows.Forms.Padding(2);
            this.cbDiff.Name = "cbDiff";
            this.cbDiff.Size = new System.Drawing.Size(72, 28);
            this.cbDiff.TabIndex = 5;
            this.cbDiff.Text = "0.00";
            // 
            // txbTotal
            // 
            this.txbTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbTotal.Location = new System.Drawing.Point(353, 107);
            this.txbTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(121, 26);
            this.txbTotal.TabIndex = 7;
            this.txbTotal.Text = "0.00";
            this.txbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxbRunningTotal
            // 
            this.TxbRunningTotal.BackColor = System.Drawing.SystemColors.Control;
            this.TxbRunningTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxbRunningTotal.ForeColor = System.Drawing.Color.Red;
            this.TxbRunningTotal.Location = new System.Drawing.Point(600, 407);
            this.TxbRunningTotal.Margin = new System.Windows.Forms.Padding(2);
            this.TxbRunningTotal.Name = "TxbRunningTotal";
            this.TxbRunningTotal.Size = new System.Drawing.Size(91, 23);
            this.TxbRunningTotal.TabIndex = 27;
            this.TxbRunningTotal.TabStop = false;
            this.TxbRunningTotal.Text = "0.00";
            this.TxbRunningTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.BurlyWood;
            this.groupBox1.Controls.Add(hrsWorkLabel);
            this.groupBox1.Controls.Add(diffLabel);
            this.groupBox1.Controls.Add(this.txbTotal);
            this.groupBox1.Controls.Add(totalLabel);
            this.groupBox1.Controls.Add(this.cbDiff);
            this.groupBox1.Controls.Add(this.txbRate);
            this.groupBox1.Controls.Add(rateLabel);
            this.groupBox1.Controls.Add(this.cbShiftTime);
            this.groupBox1.Controls.Add(shiftTimeLabel);
            this.groupBox1.Controls.Add(this.cbShiftType);
            this.groupBox1.Controls.Add(shiftTypeLabel);
            this.groupBox1.Controls.Add(this.txbHrsWork);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(LbHrsWork);
            this.groupBox1.Controls.Add(workDateLabel);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(230, 434);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(491, 141);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Controls.Add(this.DateRangebtn);
            this.groupBox2.Controls.Add(this.BtnCancel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.StartDateTimePicker1);
            this.groupBox2.Controls.Add(this.EndDateTimePicker2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(35, 426);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(196, 149);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // DateRangebtn
            // 
            this.DateRangebtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DateRangebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateRangebtn.ForeColor = System.Drawing.Color.Red;
            this.DateRangebtn.Location = new System.Drawing.Point(10, 110);
            this.DateRangebtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DateRangebtn.Name = "DateRangebtn";
            this.DateRangebtn.Size = new System.Drawing.Size(73, 30);
            this.DateRangebtn.TabIndex = 24;
            this.DateRangebtn.TabStop = false;
            this.DateRangebtn.Text = "Select";
            this.DateRangebtn.UseVisualStyleBackColor = false;
            this.DateRangebtn.Click += new System.EventHandler(this.DateRangebtn_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.ForeColor = System.Drawing.Color.Red;
            this.BtnCancel.Location = new System.Drawing.Point(111, 110);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(73, 30);
            this.BtnCancel.TabIndex = 26;
            this.BtnCancel.TabStop = false;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(25, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "To :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "SELECT DATE RANGE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "From :";
            // 
            // StartDateTimePicker1
            // 
            this.StartDateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDateTimePicker1.Location = new System.Drawing.Point(71, 47);
            this.StartDateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StartDateTimePicker1.Name = "StartDateTimePicker1";
            this.StartDateTimePicker1.Size = new System.Drawing.Size(115, 26);
            this.StartDateTimePicker1.TabIndex = 20;
            // 
            // EndDateTimePicker2
            // 
            this.EndDateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EndDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDateTimePicker2.Location = new System.Drawing.Point(71, 80);
            this.EndDateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EndDateTimePicker2.Name = "EndDateTimePicker2";
            this.EndDateTimePicker2.Size = new System.Drawing.Size(115, 26);
            this.EndDateTimePicker2.TabIndex = 21;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExit.ForeColor = System.Drawing.Color.Black;
            this.BtnExit.Location = new System.Drawing.Point(567, 604);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(107, 45);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.TabStop = false;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // TxbDeductions
            // 
            this.TxbDeductions.BackColor = System.Drawing.SystemColors.Control;
            this.TxbDeductions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxbDeductions.ForeColor = System.Drawing.Color.Red;
            this.TxbDeductions.Location = new System.Drawing.Point(603, 579);
            this.TxbDeductions.Margin = new System.Windows.Forms.Padding(2);
            this.TxbDeductions.Name = "TxbDeductions";
            this.TxbDeductions.Size = new System.Drawing.Size(91, 23);
            this.TxbDeductions.TabIndex = 26;
            this.TxbDeductions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxbDeductions.Visible = false;
            this.TxbDeductions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxbDeductions_KeyDown);
            // 
            // Deductionlabel
            // 
            this.Deductionlabel.AutoSize = true;
            this.Deductionlabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Deductionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Deductionlabel.Location = new System.Drawing.Point(503, 579);
            this.Deductionlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Deductionlabel.Name = "Deductionlabel";
            this.Deductionlabel.Size = new System.Drawing.Size(99, 17);
            this.Deductionlabel.TabIndex = 28;
            this.Deductionlabel.Text = "Deductions :";
            this.Deductionlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Deductionlabel.Visible = false;
            // 
            // TotalHrslabel
            // 
            this.TotalHrslabel.AutoSize = true;
            this.TotalHrslabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TotalHrslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalHrslabel.Location = new System.Drawing.Point(65, 406);
            this.TotalHrslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalHrslabel.Name = "TotalHrslabel";
            this.TotalHrslabel.Size = new System.Drawing.Size(96, 16);
            this.TotalHrslabel.TabIndex = 29;
            this.TotalHrslabel.Text = "Total Hours :";
            this.TotalHrslabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TotalHrslabel.Visible = false;
            // 
            // Differentiallabel
            // 
            this.Differentiallabel.AutoSize = true;
            this.Differentiallabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Differentiallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Differentiallabel.Location = new System.Drawing.Point(296, 409);
            this.Differentiallabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Differentiallabel.Name = "Differentiallabel";
            this.Differentiallabel.Size = new System.Drawing.Size(78, 16);
            this.Differentiallabel.TabIndex = 30;
            this.Differentiallabel.Text = "Total Diff :";
            this.Differentiallabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Differentiallabel.Visible = false;
            // 
            // TxbTotalHrs
            // 
            this.TxbTotalHrs.BackColor = System.Drawing.SystemColors.Control;
            this.TxbTotalHrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxbTotalHrs.ForeColor = System.Drawing.Color.Red;
            this.TxbTotalHrs.Location = new System.Drawing.Point(169, 404);
            this.TxbTotalHrs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxbTotalHrs.Name = "TxbTotalHrs";
            this.TxbTotalHrs.Size = new System.Drawing.Size(76, 22);
            this.TxbTotalHrs.TabIndex = 31;
            this.TxbTotalHrs.TabStop = false;
            this.TxbTotalHrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxbTotalHrs.Visible = false;
            // 
            // TxbTotalDiff
            // 
            this.TxbTotalDiff.BackColor = System.Drawing.SystemColors.Control;
            this.TxbTotalDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxbTotalDiff.ForeColor = System.Drawing.Color.Red;
            this.TxbTotalDiff.Location = new System.Drawing.Point(382, 405);
            this.TxbTotalDiff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxbTotalDiff.Name = "TxbTotalDiff";
            this.TxbTotalDiff.Size = new System.Drawing.Size(76, 22);
            this.TxbTotalDiff.TabIndex = 32;
            this.TxbTotalDiff.TabStop = false;
            this.TxbTotalDiff.Text = "0.00";
            this.TxbTotalDiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxbTotalDiff.Visible = false;
            // 
            // CheckTotalLabel
            // 
            this.CheckTotalLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CheckTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckTotalLabel.Location = new System.Drawing.Point(479, 408);
            this.CheckTotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CheckTotalLabel.Name = "CheckTotalLabel";
            this.CheckTotalLabel.Size = new System.Drawing.Size(117, 21);
            this.CheckTotalLabel.TabIndex = 33;
            this.CheckTotalLabel.Text = "Net Total :";
            this.CheckTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckTotalLabel.Visible = false;
            // 
            // CopyRightlabel
            // 
            this.CopyRightlabel.AutoSize = true;
            this.CopyRightlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CopyRightlabel.Location = new System.Drawing.Point(597, 652);
            this.CopyRightlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CopyRightlabel.Name = "CopyRightlabel";
            this.CopyRightlabel.Size = new System.Drawing.Size(77, 9);
            this.CopyRightlabel.TabIndex = 35;
            this.CopyRightlabel.Text = "(c) C.E.Maybury";
            // 
            // BtnDel
            // 
            this.BtnDel.BackColor = System.Drawing.Color.Red;
            this.BtnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDel.ForeColor = System.Drawing.Color.Black;
            this.BtnDel.Location = new System.Drawing.Point(419, 605);
            this.BtnDel.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.BtnDel.Size = new System.Drawing.Size(115, 43);
            this.BtnDel.TabIndex = 36;
            this.BtnDel.TabStop = false;
            this.BtnDel.Text = "Delete";
            this.BtnDel.UseVisualStyleBackColor = false;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid.CausesValidation = false;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.cBox,
            this.WorkDate,
            this.ShiftType,
            this.ShiftTime,
            this.Rate,
            this.Diff,
            this.HrsWork,
            this.Total,
            this.ConvDate});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle12;
            this.grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Location = new System.Drawing.Point(66, 18);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidth = 123;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grid.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.grid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grid.RowTemplate.Height = 25;
            this.grid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.ShowCellToolTips = false;
            this.grid.ShowRowErrors = false;
            this.grid.Size = new System.Drawing.Size(624, 385);
            this.grid.StandardTab = true;
            this.grid.TabIndex = 37;
            this.grid.TabStop = false;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 30;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 30;
            // 
            // cBox
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.NullValue = "false";
            this.cBox.DefaultCellStyle = dataGridViewCellStyle3;
            this.cBox.DividerWidth = 3;
            this.cBox.FalseValue = "false";
            this.cBox.HeaderText = "Del";
            this.cBox.MinimumWidth = 20;
            this.cBox.Name = "cBox";
            this.cBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cBox.TrueValue = "true";
            this.cBox.Width = 41;
            // 
            // WorkDate
            // 
            this.WorkDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WorkDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.WorkDate.DividerWidth = 3;
            this.WorkDate.HeaderText = "Date";
            this.WorkDate.MinimumWidth = 90;
            this.WorkDate.Name = "WorkDate";
            this.WorkDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.WorkDate.Width = 90;
            // 
            // ShiftType
            // 
            this.ShiftType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShiftType.DefaultCellStyle = dataGridViewCellStyle5;
            this.ShiftType.DividerWidth = 3;
            this.ShiftType.HeaderText = "Shift Type";
            this.ShiftType.MinimumWidth = 100;
            this.ShiftType.Name = "ShiftType";
            this.ShiftType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ShiftTime
            // 
            this.ShiftTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShiftTime.DefaultCellStyle = dataGridViewCellStyle6;
            this.ShiftTime.DividerWidth = 3;
            this.ShiftTime.HeaderText = "Shift Time";
            this.ShiftTime.MinimumWidth = 90;
            this.ShiftTime.Name = "ShiftTime";
            this.ShiftTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ShiftTime.Width = 90;
            // 
            // Rate
            // 
            this.Rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.Rate.DefaultCellStyle = dataGridViewCellStyle7;
            this.Rate.DividerWidth = 3;
            this.Rate.HeaderText = "Rate";
            this.Rate.MinimumWidth = 50;
            this.Rate.Name = "Rate";
            this.Rate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Rate.Width = 50;
            // 
            // Diff
            // 
            this.Diff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.Diff.DefaultCellStyle = dataGridViewCellStyle8;
            this.Diff.DividerWidth = 3;
            this.Diff.HeaderText = "Diff";
            this.Diff.MinimumWidth = 50;
            this.Diff.Name = "Diff";
            this.Diff.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Diff.Width = 50;
            // 
            // HrsWork
            // 
            this.HrsWork.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HrsWork.DefaultCellStyle = dataGridViewCellStyle9;
            this.HrsWork.DividerWidth = 3;
            this.HrsWork.HeaderText = "Hrs";
            this.HrsWork.MinimumWidth = 40;
            this.HrsWork.Name = "HrsWork";
            this.HrsWork.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.HrsWork.Width = 40;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle10;
            this.Total.DividerWidth = 3;
            this.Total.HeaderText = "Daily Total";
            this.Total.MinimumWidth = 90;
            this.Total.Name = "Total";
            this.Total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Total.Width = 90;
            // 
            // ConvDate
            // 
            dataGridViewCellStyle11.Format = "d";
            dataGridViewCellStyle11.NullValue = null;
            this.ConvDate.DefaultCellStyle = dataGridViewCellStyle11;
            this.ConvDate.HeaderText = "CDate";
            this.ConvDate.Name = "ConvDate";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(263, 605);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnUpdate.Size = new System.Drawing.Size(123, 43);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.DarkGray;
            this.btnInsert.Enabled = false;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInsert.ForeColor = System.Drawing.Color.Black;
            this.btnInsert.Location = new System.Drawing.Point(600, 900);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(0);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnInsert.Size = new System.Drawing.Size(192, 49);
            this.btnInsert.TabIndex = 39;
            this.btnInsert.TabStop = false;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert2_Click);
            // 
            // btnInsert2
            // 
            this.btnInsert2.BackColor = System.Drawing.Color.DarkGray;
            this.btnInsert2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsert2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInsert2.ForeColor = System.Drawing.Color.Black;
            this.btnInsert2.Location = new System.Drawing.Point(108, 606);
            this.btnInsert2.Margin = new System.Windows.Forms.Padding(0);
            this.btnInsert2.Name = "btnInsert2";
            this.btnInsert2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnInsert2.Size = new System.Drawing.Size(123, 45);
            this.btnInsert2.TabIndex = 39;
            this.btnInsert2.TabStop = false;
            this.btnInsert2.Text = "Insert";
            this.btnInsert2.UseVisualStyleBackColor = false;
            this.btnInsert2.Click += new System.EventHandler(this.btnInsert2_Click);
            // 
            // PayrollForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(757, 665);
            this.Controls.Add(this.btnInsert2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.CopyRightlabel);
            this.Controls.Add(this.CheckTotalLabel);
            this.Controls.Add(this.TxbTotalDiff);
            this.Controls.Add(this.TxbDeductions);
            this.Controls.Add(this.Deductionlabel);
            this.Controls.Add(this.TxbTotalHrs);
            this.Controls.Add(this.Differentiallabel);
            this.Controls.Add(this.TotalHrslabel);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(runningTotalLabel);
            this.Controls.Add(this.TxbRunningTotal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PayrollForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PayrollForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox cbShiftType;
        private System.Windows.Forms.ComboBox cbShiftTime;
        private System.Windows.Forms.TextBox txbRate;
        private System.Windows.Forms.TextBox txbHrsWork;
        private System.Windows.Forms.ComboBox cbDiff;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.TextBox TxbRunningTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker1;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DateRangebtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxbDeductions;
        private System.Windows.Forms.Label Deductionlabel;
        private System.Windows.Forms.Label TotalHrslabel;
        private System.Windows.Forms.Label Differentiallabel;
        private System.Windows.Forms.TextBox TxbTotalHrs;
        private System.Windows.Forms.TextBox TxbTotalDiff;
        private System.Windows.Forms.Label CheckTotalLabel;
        private System.Windows.Forms.Label CopyRightlabel;
        private System.Windows.Forms.Button BtnDel;
#pragma warning disable CS0169 // The field 'PayrollForm.RunningTotal' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn RunningTotal;
#pragma warning restore CS0169 // The field 'PayrollForm.RunningTotal' is never used
        private Button btnUpdate;
        private Button btnInsert;
        private DataGridView grid;
        private Button btnInsert2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewCheckBoxColumn cBox;
        private DataGridViewTextBoxColumn WorkDate;
        private DataGridViewTextBoxColumn ShiftType;
        private DataGridViewTextBoxColumn ShiftTime;
        private DataGridViewTextBoxColumn Rate;
        private DataGridViewTextBoxColumn Diff;
        private DataGridViewTextBoxColumn HrsWork;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn ConvDate;
    }
}