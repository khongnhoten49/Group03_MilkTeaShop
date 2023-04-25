namespace Group03_MilkTeaShop
{
    partial class Order
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewBillOrder = new System.Windows.Forms.DataGridView();
            this.BtnDeleteOrder = new System.Windows.Forms.Button();
            this.BtnCheckout = new System.Windows.Forms.Button();
            this.BtnNewOrder = new System.Windows.Forms.Button();
            this.comboBoxListBillOrder = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBillOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "ORDERS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(21, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(561, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "________________________________";
            // 
            // dataGridViewBillOrder
            // 
            this.dataGridViewBillOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBillOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBillOrder.Location = new System.Drawing.Point(27, 188);
            this.dataGridViewBillOrder.Name = "dataGridViewBillOrder";
            this.dataGridViewBillOrder.RowHeadersWidth = 51;
            this.dataGridViewBillOrder.RowTemplate.Height = 24;
            this.dataGridViewBillOrder.Size = new System.Drawing.Size(805, 534);
            this.dataGridViewBillOrder.TabIndex = 2;
            // 
            // BtnDeleteOrder
            // 
            this.BtnDeleteOrder.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteOrder.Location = new System.Drawing.Point(854, 367);
            this.BtnDeleteOrder.Name = "BtnDeleteOrder";
            this.BtnDeleteOrder.Size = new System.Drawing.Size(174, 51);
            this.BtnDeleteOrder.TabIndex = 6;
            this.BtnDeleteOrder.Text = "Delete";
            this.BtnDeleteOrder.UseVisualStyleBackColor = true;
            // 
            // BtnCheckout
            // 
            this.BtnCheckout.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheckout.Location = new System.Drawing.Point(854, 446);
            this.BtnCheckout.Name = "BtnCheckout";
            this.BtnCheckout.Size = new System.Drawing.Size(174, 51);
            this.BtnCheckout.TabIndex = 7;
            this.BtnCheckout.Text = "Check Out";
            this.BtnCheckout.UseVisualStyleBackColor = true;
            // 
            // BtnNewOrder
            // 
            this.BtnNewOrder.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewOrder.Location = new System.Drawing.Point(854, 282);
            this.BtnNewOrder.Name = "BtnNewOrder";
            this.BtnNewOrder.Size = new System.Drawing.Size(174, 51);
            this.BtnNewOrder.TabIndex = 8;
            this.BtnNewOrder.Text = "New Order";
            this.BtnNewOrder.UseVisualStyleBackColor = true;
            this.BtnNewOrder.Click += new System.EventHandler(this.BtnNewOrder_Click);
            // 
            // comboBoxListBillOrder
            // 
            this.comboBoxListBillOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxListBillOrder.FormattingEnabled = true;
            this.comboBoxListBillOrder.Location = new System.Drawing.Point(656, 141);
            this.comboBoxListBillOrder.Name = "comboBoxListBillOrder";
            this.comboBoxListBillOrder.Size = new System.Drawing.Size(176, 30);
            this.comboBoxListBillOrder.TabIndex = 18;
            this.comboBoxListBillOrder.SelectedIndexChanged += new System.EventHandler(this.comboBoxListBillOrder_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(588, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Bill:";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 762);
            this.Controls.Add(this.comboBoxListBillOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnNewOrder);
            this.Controls.Add(this.BtnCheckout);
            this.Controls.Add(this.BtnDeleteOrder);
            this.Controls.Add(this.dataGridViewBillOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBillOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewBillOrder;
        private System.Windows.Forms.Button BtnDeleteOrder;
        private System.Windows.Forms.Button BtnCheckout;
        private System.Windows.Forms.Button BtnNewOrder;
        private System.Windows.Forms.ComboBox comboBoxListBillOrder;
        private System.Windows.Forms.Label label4;
    }
}