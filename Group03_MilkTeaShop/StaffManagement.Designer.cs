namespace Group03_MilkTeaShop
{
    partial class StaffManagement
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
            this.UC_Container_SM = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // UC_Container_SM
            // 
            this.UC_Container_SM.Location = new System.Drawing.Point(-1, 12);
            this.UC_Container_SM.Name = "UC_Container_SM";
            this.UC_Container_SM.Size = new System.Drawing.Size(1229, 741);
            this.UC_Container_SM.TabIndex = 7;
            this.UC_Container_SM.Paint += new System.Windows.Forms.PaintEventHandler(this.UC_Container_SM_Paint);
            // 
            // StaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 755);
            this.Controls.Add(this.UC_Container_SM);
            this.Name = "StaffManagement";
            this.Text = "StaffManagement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UC_Container_SM;
    }
}