using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simplex
{
    public partial class FRM_Start : Form
    {
        public FRM_Start()
        {
            InitializeComponent();
           // rb_Max.Checked = true;
        }
        public static int Variables 
          { 
              get; 
              set; 
          }
        public static int Constraints
        {
            get;
            set;
        }
        public static bool max
        { 
            get; 
            set;
        }
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (rb_Max.Checked == false && rb_Min.Checked == false)
                {
                    MessageBox.Show("Please check max or min ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Variables = int.Parse(N_Var.Text);
                    Constraints = int.Parse(N_Con.Text);
                    if (Variables > 15)
                        Variables = 15;
                    if (Constraints > 15)
                        Constraints = 15;

                    max = rb_Max.Checked;
                    Frm_Equation frm = new Frm_Equation();
                    frm.Variables = Variables;
                    frm.Constraints = Constraints;
                    frm.ShowDialog();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
