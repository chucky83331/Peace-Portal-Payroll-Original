
namespace Peace_Portal_Payroll
{
    partial class PPMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PPMainForm));
            this.Headerlabel = new System.Windows.Forms.Label();
            this.BtDailyInfo = new System.Windows.Forms.Button();
            this.BtBalance = new System.Windows.Forms.Button();
            this.BtClose = new System.Windows.Forms.Button();
            this.CopyWrightlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Headerlabel
            // 
            this.Headerlabel.AutoSize = true;
            this.Headerlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Headerlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Headerlabel.ForeColor = System.Drawing.Color.Black;
            this.Headerlabel.Location = new System.Drawing.Point(37, 13);
            this.Headerlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Headerlabel.Name = "Headerlabel";
            this.Headerlabel.Size = new System.Drawing.Size(284, 17);
            this.Headerlabel.TabIndex = 2;
            this.Headerlabel.Text = "PEACE PORTAL PAYROLL PROGRAM";
            this.Headerlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtDailyInfo
            // 
            this.BtDailyInfo.BackColor = System.Drawing.Color.DarkGray;
            this.BtDailyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDailyInfo.Location = new System.Drawing.Point(17, 42);
            this.BtDailyInfo.Margin = new System.Windows.Forms.Padding(2);
            this.BtDailyInfo.Name = "BtDailyInfo";
            this.BtDailyInfo.Size = new System.Drawing.Size(319, 29);
            this.BtDailyInfo.TabIndex = 3;
            this.BtDailyInfo.Text = "Enter Daily Information";
            this.BtDailyInfo.UseVisualStyleBackColor = false;
            this.BtDailyInfo.Click += new System.EventHandler(this.BtDailyInfo_Click);
            // 
            // BtBalance
            // 
            this.BtBalance.BackColor = System.Drawing.Color.DarkGray;
            this.BtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtBalance.Location = new System.Drawing.Point(17, 79);
            this.BtBalance.Margin = new System.Windows.Forms.Padding(2);
            this.BtBalance.Name = "BtBalance";
            this.BtBalance.Size = new System.Drawing.Size(319, 29);
            this.BtBalance.TabIndex = 4;
            this.BtBalance.Text = "Update Hourly Rates";
            this.BtBalance.UseVisualStyleBackColor = false;
            this.BtBalance.Click += new System.EventHandler(this.BtBalance_Click);
            // 
            // BtClose
            // 
            this.BtClose.BackColor = System.Drawing.Color.DarkGray;
            this.BtClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtClose.ForeColor = System.Drawing.Color.Red;
            this.BtClose.Location = new System.Drawing.Point(263, 112);
            this.BtClose.Margin = new System.Windows.Forms.Padding(2);
            this.BtClose.Name = "BtClose";
            this.BtClose.Size = new System.Drawing.Size(73, 27);
            this.BtClose.TabIndex = 5;
            this.BtClose.Text = "Close";
            this.BtClose.UseVisualStyleBackColor = false;
            this.BtClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // CopyWrightlabel
            // 
            this.CopyWrightlabel.AutoSize = true;
            this.CopyWrightlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyWrightlabel.Location = new System.Drawing.Point(21, 130);
            this.CopyWrightlabel.Name = "CopyWrightlabel";
            this.CopyWrightlabel.Size = new System.Drawing.Size(77, 9);
            this.CopyWrightlabel.TabIndex = 6;
            this.CopyWrightlabel.Text = "(c) C.E.Maybury";
            // 
            // PPMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(353, 147);
            this.Controls.Add(this.CopyWrightlabel);
            this.Controls.Add(this.BtClose);
            this.Controls.Add(this.BtBalance);
            this.Controls.Add(this.BtDailyInfo);
            this.Controls.Add(this.Headerlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PPMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peace Portal Payroll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Headerlabel;
        private System.Windows.Forms.Button BtDailyInfo;
        private System.Windows.Forms.Button BtBalance;
        private System.Windows.Forms.Button BtClose;
        private System.Windows.Forms.Label CopyWrightlabel;
    }
}