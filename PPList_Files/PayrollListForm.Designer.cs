namespace Peace_Portal_Payroll
{
    partial class PayrollListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShiftlistBox = new System.Windows.Forms.ListBox();
            this.ShiftTypetxtBox = new System.Windows.Forms.TextBox();
            this.ShiftTimetxtBox = new System.Windows.Forms.TextBox();
            this.RatetxtBox = new System.Windows.Forms.TextBox();
            this.HrsworktxtBox = new System.Windows.Forms.TextBox();
            this.DifftxtBox = new System.Windows.Forms.TextBox();
            this.TotaltxtBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Refreshbtn = new System.Windows.Forms.Button();
            this.AddShiftbtn = new System.Windows.Forms.Button();
            this._PPDataBase_MDFDataSet = new Peace_Portal_Payroll._PPDataBase_MDFDataSet();
            ((System.ComponentModel.ISupportInitialize)(this._PPDataBase_MDFDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ShiftlistBox
            // 
            this.ShiftlistBox.FormattingEnabled = true;
            this.ShiftlistBox.ItemHeight = 37;
            this.ShiftlistBox.Location = new System.Drawing.Point(684, 38);
            this.ShiftlistBox.Name = "ShiftlistBox";
            this.ShiftlistBox.Size = new System.Drawing.Size(1134, 670);
            this.ShiftlistBox.TabIndex = 0;
            // 
            // ShiftTypetxtBox
            // 
            this.ShiftTypetxtBox.Location = new System.Drawing.Point(86, 174);
            this.ShiftTypetxtBox.Name = "ShiftTypetxtBox";
            this.ShiftTypetxtBox.Size = new System.Drawing.Size(466, 44);
            this.ShiftTypetxtBox.TabIndex = 1;
            // 
            // ShiftTimetxtBox
            // 
            this.ShiftTimetxtBox.Location = new System.Drawing.Point(86, 236);
            this.ShiftTimetxtBox.Name = "ShiftTimetxtBox";
            this.ShiftTimetxtBox.Size = new System.Drawing.Size(466, 44);
            this.ShiftTimetxtBox.TabIndex = 2;
            // 
            // RatetxtBox
            // 
            this.RatetxtBox.Location = new System.Drawing.Point(86, 299);
            this.RatetxtBox.Name = "RatetxtBox";
            this.RatetxtBox.Size = new System.Drawing.Size(466, 44);
            this.RatetxtBox.TabIndex = 3;
            // 
            // HrsworktxtBox
            // 
            this.HrsworktxtBox.Location = new System.Drawing.Point(86, 361);
            this.HrsworktxtBox.Name = "HrsworktxtBox";
            this.HrsworktxtBox.Size = new System.Drawing.Size(466, 44);
            this.HrsworktxtBox.TabIndex = 4;
            // 
            // DifftxtBox
            // 
            this.DifftxtBox.Location = new System.Drawing.Point(86, 430);
            this.DifftxtBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.DifftxtBox.Name = "DifftxtBox";
            this.DifftxtBox.Size = new System.Drawing.Size(466, 44);
            this.DifftxtBox.TabIndex = 5;
            // 
            // TotaltxtBox
            // 
            this.TotaltxtBox.Location = new System.Drawing.Point(86, 504);
            this.TotaltxtBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.TotaltxtBox.Name = "TotaltxtBox";
            this.TotaltxtBox.Size = new System.Drawing.Size(466, 44);
            this.TotaltxtBox.TabIndex = 6;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(86, 102);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(466, 44);
            this.dateTimePicker.TabIndex = 8;
            // 
            // Refreshbtn
            // 
            this.Refreshbtn.Location = new System.Drawing.Point(86, 578);
            this.Refreshbtn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(238, 65);
            this.Refreshbtn.TabIndex = 0;
            this.Refreshbtn.Text = "Refresh";
            // 
            // AddShiftbtn
            // 
            this.AddShiftbtn.Location = new System.Drawing.Point(323, 578);
            this.AddShiftbtn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.AddShiftbtn.Name = "AddShiftbtn";
            this.AddShiftbtn.Size = new System.Drawing.Size(238, 65);
            this.AddShiftbtn.TabIndex = 0;
            this.AddShiftbtn.Text = "Add";
            this.AddShiftbtn.Click += new System.EventHandler(this.AddShiftbtn_Click);
            // 
            // _PPDataBase_MDFDataSet
            // 
            this._PPDataBase_MDFDataSet.DataSetName = "_PPDataBase_MDFDataSet";
            this._PPDataBase_MDFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PayrollListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1859, 720);
            this.Controls.Add(this.AddShiftbtn);
            this.Controls.Add(this.Refreshbtn);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.TotaltxtBox);
            this.Controls.Add(this.DifftxtBox);
            this.Controls.Add(this.HrsworktxtBox);
            this.Controls.Add(this.RatetxtBox);
            this.Controls.Add(this.ShiftTimetxtBox);
            this.Controls.Add(this.ShiftTypetxtBox);
            this.Controls.Add(this.ShiftlistBox);
            this.Name = "PayrollListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayrollListForm";
            ((System.ComponentModel.ISupportInitialize)(this._PPDataBase_MDFDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ShiftlistBox;
        private System.Windows.Forms.TextBox ShiftTypetxtBox;
        private System.Windows.Forms.TextBox ShiftTimetxtBox;
        private System.Windows.Forms.TextBox RatetxtBox;
        private System.Windows.Forms.TextBox HrsworktxtBox;
        private System.Windows.Forms.TextBox DifftxtBox;
        private System.Windows.Forms.TextBox TotaltxtBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button Refreshbtn;
        private System.Windows.Forms.Button AddShiftbtn;
        private _PPDataBase_MDFDataSet _PPDataBase_MDFDataSet;
    }
}