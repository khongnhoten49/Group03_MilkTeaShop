﻿namespace Group03_MilkTeaShop
{
    partial class Home
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
            this.UC_Container_Home = new System.Windows.Forms.Panel();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.StatisticBtn = new System.Windows.Forms.Button();
            this.InfoBtn = new System.Windows.Forms.Button();
            this.ProductMngBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UC_Container_Home
            // 
            this.UC_Container_Home.Location = new System.Drawing.Point(12, 79);
            this.UC_Container_Home.Name = "UC_Container_Home";
            this.UC_Container_Home.Size = new System.Drawing.Size(1233, 678);
            this.UC_Container_Home.TabIndex = 0;
            // 
            // MenuBtn
            // 
            this.MenuBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBtn.Location = new System.Drawing.Point(12, 12);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(136, 48);
            this.MenuBtn.TabIndex = 1;
            this.MenuBtn.Text = "Menu";
            this.MenuBtn.UseVisualStyleBackColor = true;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // OrderBtn
            // 
            this.OrderBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderBtn.Location = new System.Drawing.Point(154, 12);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(138, 48);
            this.OrderBtn.TabIndex = 2;
            this.OrderBtn.Text = "Order";
            this.OrderBtn.UseVisualStyleBackColor = true;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // StatisticBtn
            // 
            this.StatisticBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatisticBtn.Location = new System.Drawing.Point(298, 12);
            this.StatisticBtn.Name = "StatisticBtn";
            this.StatisticBtn.Size = new System.Drawing.Size(148, 48);
            this.StatisticBtn.TabIndex = 3;
            this.StatisticBtn.Text = "Statistic";
            this.StatisticBtn.UseVisualStyleBackColor = true;
            this.StatisticBtn.Click += new System.EventHandler(this.StatisticBtn_Click);
            // 
            // InfoBtn
            // 
            this.InfoBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoBtn.Location = new System.Drawing.Point(452, 12);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(124, 48);
            this.InfoBtn.TabIndex = 4;
            this.InfoBtn.Text = "Info";
            this.InfoBtn.UseVisualStyleBackColor = true;
            // 
            // ProductMngBtn
            // 
            this.ProductMngBtn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductMngBtn.Location = new System.Drawing.Point(582, 12);
            this.ProductMngBtn.Name = "ProductMngBtn";
            this.ProductMngBtn.Size = new System.Drawing.Size(300, 48);
            this.ProductMngBtn.TabIndex = 5;
            this.ProductMngBtn.Text = "Product Management";
            this.ProductMngBtn.UseVisualStyleBackColor = true;
            this.ProductMngBtn.Click += new System.EventHandler(this.ProductMngBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(888, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Staff Management";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1254, 815);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProductMngBtn);
            this.Controls.Add(this.UC_Container_Home);
            this.Controls.Add(this.InfoBtn);
            this.Controls.Add(this.MenuBtn);
            this.Controls.Add(this.OrderBtn);
            this.Controls.Add(this.StatisticBtn);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UC_Container_Home;
        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.Button StatisticBtn;
        private System.Windows.Forms.Button InfoBtn;
        private System.Windows.Forms.Button ProductMngBtn;
        private System.Windows.Forms.Button button1;
    }
}

