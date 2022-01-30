
namespace Peace_Portal_Payroll
{
    partial class RatesForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RatesForm));
            this.LbBalance = new System.Windows.Forms.Label();
            this.LbStartDate = new System.Windows.Forms.Label();
            this.LbEndDate = new System.Windows.Forms.Label();
            this.pPDailyTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._PPDataBase_MDFDataSet = new Peace_Portal_Payroll._PPDataBase_MDFDataSet();
            this.pPDailyTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtExit = new System.Windows.Forms.Button();
            this.pPDailyTableTableAdapter = new Peace_Portal_Payroll._PPDataBase_MDFDataSetTableAdapters.PPDailyTableTableAdapter();
            this.tableAdapterManager = new Peace_Portal_Payroll._PPDataBase_MDFDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.Rate1 = new System.Windows.Forms.TextBox();
            this.Rate2 = new System.Windows.Forms.TextBox();
            this.Rate3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Savebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pPDailyTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._PPDataBase_MDFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPDailyTableBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbBalance
            // 
            this.LbBalance.AutoSize = true;
            this.LbBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.LbBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbBalance.Location = new System.Drawing.Point(205, 12);
            this.LbBalance.Name = "LbBalance";
            this.LbBalance.Size = new System.Drawing.Size(236, 29);
            this.LbBalance.TabIndex = 0;
            this.LbBalance.Text = "Edit  Hourly Rates :";
            this.LbBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbStartDate
            // 
            this.LbStartDate.AutoSize = true;
            this.LbStartDate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LbStartDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LbStartDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LbStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbStartDate.Location = new System.Drawing.Point(56, 75);
            this.LbStartDate.Name = "LbStartDate";
            this.LbStartDate.Size = new System.Drawing.Size(414, 31);
            this.LbStartDate.TabIndex = 2;
            this.LbStartDate.Text = "Regular Hrs - Sick Pay - Vacation :";
            // 
            // LbEndDate
            // 
            this.LbEndDate.AutoSize = true;
            this.LbEndDate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LbEndDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LbEndDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LbEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEndDate.Location = new System.Drawing.Point(183, 143);
            this.LbEndDate.Name = "LbEndDate";
            this.LbEndDate.Size = new System.Drawing.Size(287, 31);
            this.LbEndDate.TabIndex = 3;
            this.LbEndDate.Text = "Stat 1.5 - Overtime 1.5 :";
            // 
            // pPDailyTableBindingSource1
            // 
            this.pPDailyTableBindingSource1.DataMember = "PPDailyTable";
            this.pPDailyTableBindingSource1.DataSource = this._PPDataBase_MDFDataSet;
            // 
            // _PPDataBase_MDFDataSet
            // 
            this._PPDataBase_MDFDataSet.DataSetName = "_PPDataBase_MDFDataSet";
            this._PPDataBase_MDFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pPDailyTableBindingSource
            // 
            this.pPDailyTableBindingSource.DataMember = "PPDailyTable";
            // 
            // BtExit
            // 
            this.BtExit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtExit.ForeColor = System.Drawing.Color.Red;
            this.BtExit.Location = new System.Drawing.Point(531, 325);
            this.BtExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtExit.Name = "BtExit";
            this.BtExit.Size = new System.Drawing.Size(112, 49);
            this.BtExit.TabIndex = 6;
            this.BtExit.TabStop = false;
            this.BtExit.Text = "Exit";
            this.BtExit.UseVisualStyleBackColor = false;
            this.BtExit.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // pPDailyTableTableAdapter
            // 
            this.pPDailyTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PPDailyTableTableAdapter = this.pPDailyTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Peace_Portal_Payroll._PPDataBase_MDFDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Stat 2.0 - Over Time 2.0 :";
            // 
            // Rate1
            // 
            this.Rate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rate1.ForeColor = System.Drawing.Color.Red;
            this.Rate1.Location = new System.Drawing.Point(502, 76);
            this.Rate1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Rate1.Name = "Rate1";
            this.Rate1.Size = new System.Drawing.Size(118, 35);
            this.Rate1.TabIndex = 8;
            this.Rate1.TabStop = false;
            this.Rate1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Rate2
            // 
            this.Rate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rate2.ForeColor = System.Drawing.Color.Red;
            this.Rate2.Location = new System.Drawing.Point(502, 142);
            this.Rate2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Rate2.Name = "Rate2";
            this.Rate2.Size = new System.Drawing.Size(118, 35);
            this.Rate2.TabIndex = 9;
            this.Rate2.TabStop = false;
            this.Rate2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Rate3
            // 
            this.Rate3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rate3.ForeColor = System.Drawing.Color.Red;
            this.Rate3.Location = new System.Drawing.Point(502, 209);
            this.Rate3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Rate3.Name = "Rate3";
            this.Rate3.Size = new System.Drawing.Size(118, 35);
            this.Rate3.TabIndex = 10;
            this.Rate3.TabStop = false;
            this.Rate3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Savebtn);
            this.panel1.Location = new System.Drawing.Point(22, 54);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 262);
            this.panel1.TabIndex = 11;
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.ForeColor = System.Drawing.Color.Red;
            this.Savebtn.Location = new System.Drawing.Point(465, 203);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(136, 45);
            this.Savebtn.TabIndex = 12;
            this.Savebtn.Text = "Save Changes";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // RatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(666, 383);
            this.Controls.Add(this.Rate3);
            this.Controls.Add(this.Rate2);
            this.Controls.Add(this.Rate1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtExit);
            this.Controls.Add(this.LbEndDate);
            this.Controls.Add(this.LbStartDate);
            this.Controls.Add(this.LbBalance);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RatesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rates Form";
            this.Load += new System.EventHandler(this.BalanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pPDailyTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._PPDataBase_MDFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPDailyTableBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbBalance;
        private System.Windows.Forms.Label LbStartDate;
        private System.Windows.Forms.Label LbEndDate;
        private System.Windows.Forms.BindingSource pPDailyTableBindingSource;
        private System.Windows.Forms.Button BtExit;
        private _PPDataBase_MDFDataSet _PPDataBase_MDFDataSet;
        private System.Windows.Forms.BindingSource pPDailyTableBindingSource1;
        private _PPDataBase_MDFDataSetTableAdapters.PPDailyTableTableAdapter pPDailyTableTableAdapter;
        private _PPDataBase_MDFDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Rate1;
        private System.Windows.Forms.TextBox Rate2;
        private System.Windows.Forms.TextBox Rate3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Savebtn;
    }
}