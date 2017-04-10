namespace Simplex
{
    partial class Frm_Equation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Equation));
            this.P1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.P_Z = new System.Windows.Forms.Panel();
            this.P_C = new System.Windows.Forms.Panel();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Calculate = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Back = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.P1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // P1
            // 
            this.P1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.P1.Controls.Add(this.label1);
            this.P1.Dock = System.Windows.Forms.DockStyle.Top;
            this.P1.Location = new System.Drawing.Point(0, 0);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(869, 93);
            this.P1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22F);
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "DECISION SUPPORT PROJECT\r\n           Simplex Method";
            // 
            // P_Z
            // 
            this.P_Z.AutoScroll = true;
            this.P_Z.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.P_Z.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_Z.Font = new System.Drawing.Font("Tahoma", 14F);
            this.P_Z.Location = new System.Drawing.Point(0, 93);
            this.P_Z.Name = "P_Z";
            this.P_Z.Size = new System.Drawing.Size(869, 105);
            this.P_Z.TabIndex = 3;
            // 
            // P_C
            // 
            this.P_C.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P_C.AutoScroll = true;
            this.P_C.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.P_C.Font = new System.Drawing.Font("Tahoma", 14F);
            this.P_C.Location = new System.Drawing.Point(0, 198);
            this.P_C.Name = "P_C";
            this.P_C.Size = new System.Drawing.Size(869, 105);
            this.P_C.TabIndex = 4;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btn_Exit.Appearance.Options.UseFont = true;
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_Exit.Location = new System.Drawing.Point(42, 16);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(114, 37);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "Exit";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btn_Calculate.Appearance.Options.UseFont = true;
            this.btn_Calculate.Image = ((System.Drawing.Image)(resources.GetObject("btn_Calculate.Image")));
            this.btn_Calculate.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_Calculate.Location = new System.Drawing.Point(680, 16);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(147, 37);
            this.btn_Calculate.TabIndex = 6;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btn_Back.Appearance.Options.UseFont = true;
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_Back.Location = new System.Drawing.Point(345, 16);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(147, 37);
            this.btn_Back.TabIndex = 8;
            this.btn_Back.Text = "Back";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Controls.Add(this.btn_Calculate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.panel1.Location = new System.Drawing.Point(0, 303);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 72);
            this.panel1.TabIndex = 9;
            // 
            // Frm_Equation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 375);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.P_C);
            this.Controls.Add(this.P_Z);
            this.Controls.Add(this.P1);
            this.Name = "Frm_Equation";
            this.Text = "Simplex Method";
            this.P1.ResumeLayout(false);
            this.P1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel P_Z;
        private System.Windows.Forms.Panel P_C;
        private DevExpress.XtraEditors.SimpleButton btn_Exit;
        private DevExpress.XtraEditors.SimpleButton btn_Calculate;
        private DevExpress.XtraEditors.SimpleButton btn_Back;
        private System.Windows.Forms.Panel panel1;
    }
}