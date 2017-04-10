namespace Simplex
{
    partial class FRM_Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Start));
            this.P1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Ok = new DevExpress.XtraEditors.SimpleButton();
            this.N_Var = new System.Windows.Forms.NumericUpDown();
            this.N_Con = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Panel();
            this.rb_Min = new System.Windows.Forms.RadioButton();
            this.rb_Max = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.P1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N_Var)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_Con)).BeginInit();
            this.p2.SuspendLayout();
            this.SuspendLayout();
            // 
            // P1
            // 
            this.P1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.P1.Controls.Add(this.label1);
            this.P1.Dock = System.Windows.Forms.DockStyle.Top;
            this.P1.Location = new System.Drawing.Point(0, 0);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(714, 86);
            this.P1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22F);
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "DECISION SUPPORT PROJECT\r\n           Simplex Method";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.btn_Ok);
            this.panel1.Controls.Add(this.N_Var);
            this.panel1.Controls.Add(this.N_Con);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 177);
            this.panel1.TabIndex = 1;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btn_Exit.Appearance.Options.UseFont = true;
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_Exit.Location = new System.Drawing.Point(536, 90);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(81, 37);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.btn_Ok.Appearance.Options.UseFont = true;
            this.btn_Ok.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ok.Image")));
            this.btn_Ok.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btn_Ok.Location = new System.Drawing.Point(536, 34);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(81, 37);
            this.btn_Ok.TabIndex = 4;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // N_Var
            // 
            this.N_Var.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.N_Var.Font = new System.Drawing.Font("Tahoma", 16F);
            this.N_Var.Location = new System.Drawing.Point(353, 94);
            this.N_Var.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.N_Var.Name = "N_Var";
            this.N_Var.Size = new System.Drawing.Size(97, 33);
            this.N_Var.TabIndex = 3;
            this.N_Var.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // N_Con
            // 
            this.N_Con.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.N_Con.Font = new System.Drawing.Font("Tahoma", 16F);
            this.N_Con.Location = new System.Drawing.Point(353, 34);
            this.N_Con.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.N_Con.Name = "N_Con";
            this.N_Con.Size = new System.Drawing.Size(97, 33);
            this.N_Con.TabIndex = 2;
            this.N_Con.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Tahoma", 22F);
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "Number of Constrain";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 22F);
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of Variable  ";
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.p2.Controls.Add(this.rb_Min);
            this.p2.Controls.Add(this.rb_Max);
            this.p2.Controls.Add(this.label4);
            this.p2.Dock = System.Windows.Forms.DockStyle.Top;
            this.p2.Location = new System.Drawing.Point(0, 86);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(714, 93);
            this.p2.TabIndex = 3;
            // 
            // rb_Min
            // 
            this.rb_Min.AutoSize = true;
            this.rb_Min.BackColor = System.Drawing.Color.Lime;
            this.rb_Min.Font = new System.Drawing.Font("Tahoma", 18F);
            this.rb_Min.Location = new System.Drawing.Point(636, 18);
            this.rb_Min.Name = "rb_Min";
            this.rb_Min.Size = new System.Drawing.Size(68, 33);
            this.rb_Min.TabIndex = 3;
            this.rb_Min.TabStop = true;
            this.rb_Min.Text = "Min";
            this.rb_Min.UseVisualStyleBackColor = false;
            // 
            // rb_Max
            // 
            this.rb_Max.AutoSize = true;
            this.rb_Max.BackColor = System.Drawing.Color.Red;
            this.rb_Max.Font = new System.Drawing.Font("Tahoma", 18F);
            this.rb_Max.Location = new System.Drawing.Point(520, 18);
            this.rb_Max.Name = "rb_Max";
            this.rb_Max.Size = new System.Drawing.Size(75, 33);
            this.rb_Max.TabIndex = 2;
            this.rb_Max.TabStop = true;
            this.rb_Max.Text = "Max";
            this.rb_Max.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Tahoma", 22F);
            this.label4.Location = new System.Drawing.Point(22, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(474, 36);
            this.label4.TabIndex = 1;
            this.label4.Text = "Enter Objection Function Variables";
            // 
            // FRM_Start
            // 
            this.AcceptButton = this.btn_Ok;
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 357);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.P1);
            this.MaximizeBox = false;
            this.Name = "FRM_Start";
            this.Text = "Simplex";
            this.P1.ResumeLayout(false);
            this.P1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N_Var)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_Con)).EndInit();
            this.p2.ResumeLayout(false);
            this.p2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown N_Var;
        private System.Windows.Forms.NumericUpDown N_Con;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btn_Ok;
        private DevExpress.XtraEditors.SimpleButton btn_Exit;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.RadioButton rb_Min;
        private System.Windows.Forms.RadioButton rb_Max;
        private System.Windows.Forms.Label label4;

    }
}

