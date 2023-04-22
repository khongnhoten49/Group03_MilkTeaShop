namespace Group03_MilkTeaShop.UserControls
{
    partial class UC_Statistic
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.btnGeneReport = new System.Windows.Forms.Button();
            this.dataGridViewBill = new System.Windows.Forms.DataGridView();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.BtnSearchBill = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCashierName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).BeginInit();
            this.SuspendLayout();
            // 
            // endDate
            // 
            this.endDate.CalendarFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate.CustomFormat = "dd/MM/yyyy";
            this.endDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDate.Location = new System.Drawing.Point(439, 199);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(143, 27);
            this.endDate.TabIndex = 28;
            // 
            // startDate
            // 
            this.startDate.CalendarFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.CustomFormat = "dd/MM/yyyy";
            this.startDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(165, 199);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(143, 27);
            this.startDate.TabIndex = 27;
            // 
            // btnGeneReport
            // 
            this.btnGeneReport.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneReport.Location = new System.Drawing.Point(902, 610);
            this.btnGeneReport.Name = "btnGeneReport";
            this.btnGeneReport.Size = new System.Drawing.Size(264, 47);
            this.btnGeneReport.TabIndex = 26;
            this.btnGeneReport.Text = "Generate Report";
            this.btnGeneReport.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBill
            // 
            this.dataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBill.Location = new System.Drawing.Point(60, 244);
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.RowHeadersWidth = 51;
            this.dataGridViewBill.RowTemplate.Height = 24;
            this.dataGridViewBill.Size = new System.Drawing.Size(1106, 347);
            this.dataGridViewBill.TabIndex = 25;
            // 
            // btnViewAll
            // 
            this.btnViewAll.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.Location = new System.Drawing.Point(959, 145);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(207, 49);
            this.btnViewAll.TabIndex = 24;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // BtnSearchBill
            // 
            this.BtnSearchBill.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchBill.Location = new System.Drawing.Point(735, 145);
            this.BtnSearchBill.Name = "BtnSearchBill";
            this.BtnSearchBill.Size = new System.Drawing.Size(204, 49);
            this.BtnSearchBill.TabIndex = 23;
            this.BtnSearchBill.Text = "Search";
            this.BtnSearchBill.UseVisualStyleBackColor = true;
            this.BtnSearchBill.Click += new System.EventHandler(this.BtnSearchBill_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(354, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "To Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "From Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cashier Name:";
            // 
            // cbCashierName
            // 
            this.cbCashierName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCashierName.FormattingEnabled = true;
            this.cbCashierName.Location = new System.Drawing.Point(210, 151);
            this.cbCashierName.Name = "cbCashierName";
            this.cbCashierName.Size = new System.Drawing.Size(372, 30);
            this.cbCashierName.TabIndex = 19;
            this.cbCashierName.SelectedIndexChanged += new System.EventHandler(this.cbCashierName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(661, 91);
            this.label1.TabIndex = 17;
            this.label1.Text = "SALES REPORT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(51, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1139, 37);
            this.label2.TabIndex = 18;
            this.label2.Text = "__________________________________________________________________";
            // 
            // UC_Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.btnGeneReport);
            this.Controls.Add(this.dataGridViewBill);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.BtnSearchBill);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCashierName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "UC_Statistic";
            this.Size = new System.Drawing.Size(1233, 678);
            this.Load += new System.EventHandler(this.UC_Statistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Button btnGeneReport;
        private System.Windows.Forms.DataGridView dataGridViewBill;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button BtnSearchBill;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCashierName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
