using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplex
{
    public partial class Frm_Equation : Form
    {
        public int Variables
        {
            get;
            set;
        }
        public int Constraints
        {
            get;
            set;
        }

        public static bool mode;
        public NumericUpDown[] objFunction;//refer to Z Equation
        public NumericUpDown[][] constraintFunction;//refer to Constrain Equations
        public ComboBox[] constraintSigns;// refer to > | < | =
        public NumericUpDown[] constraintFunctionRight;// refer to the constrain right side
        private Label l1;
        public string[] signs = { "<=", "=", ">=" };


        //=========================================
        private static DualSimplex ds;
        private static double[] targetCoefficients;
        private static DConstraint[] constraints;
        private static int status;
        public Frm_Equation()
        {
            InitializeComponent();
            Variables = FRM_Start.Variables;
            Constraints = FRM_Start.Constraints;
            CreateObjFunctionTextFields();
            CreateConstraintFunctionTextFields();
            CreateConstraintFunctionSigns();
            mode = FRM_Start.max;
        }
        
        //for create Z Equation 
        private void CreateObjFunctionTextFields()
        {
            // create array of NumericUpDown of length of number of Variables
            objFunction = new NumericUpDown[Variables];
            
            //=====================================
            l1 = new Label();
            l1.Text = "Variable";
            l1.SetBounds(20, 5, 80, 25);
            l1.BackColor = Color.Yellow;
            P_Z.Controls.Add(l1);
            //-------------------------------
            l1 = new Label();
            l1.Text = "Z = ";
            l1.SetBounds(0, 40, 60, 25);
            l1.BackColor = Color.Yellow;
            P_Z.Controls.Add(l1);
            //--------------------------------
            
            l1 = new Label();
            l1.Text = "Factor";
            l1.SetBounds(20, 70, 80, 25);
            l1.BackColor = Color.Yellow;
            P_Z.Controls.Add(l1);

            //============================================
            // Create NumericUpDownfor each variables
            for (int i = 0; i < Variables; i++)
            {
                l1 = new Label();
                l1.SetBounds((130 + (60 * i)), 5, 40, 25);
                l1.Text = "X" + (i).ToString();
                l1.BackColor = Color.Yellow;
                P_Z.Controls.Add(l1);
             //------------------------------------------------
                NumericUpDown num = new NumericUpDown();
                num = new NumericUpDown();             
                num.SetBounds((130 + (60 * i)), 70, 50, 25);                
                num.Minimum = -99;
                num.Maximum = 99;
                num.Value = 0;
                objFunction[i] = num;
                P_Z.Controls.Add(num);

            }
        }
  

        // for constraint functions
        
        private void CreateConstraintFunctionTextFields()
        {
            int c = 1;
            constraintFunction = new NumericUpDown[Constraints][];
            
            //========================
            for (int i = 0; i < Constraints; i++)
            {
                // Create new array in our array, it represents number of fields in our row
                constraintFunction[i] = new NumericUpDown[Variables];
                // Create each textbox for variable in our row
                l1 = new Label();
                l1.Text = "Variable";
                l1.SetBounds(20, 5+110*i, 80, 25);
                l1.BackColor = Color.Yellow;
                P_C.Controls.Add(l1);
                //-------------------------------
                l1 = new Label();
                l1.Text = "C" + c + " = ";
                l1.SetBounds(0, 40+110*i, 60, 25);
                l1.BackColor = Color.Yellow;
                P_C.Controls.Add(l1);
                //--------------------------------

                l1 = new Label();
                l1.Text = "Factor";
                l1.SetBounds(20, 70+110*i, 80, 25);
                l1.BackColor = Color.Yellow;
                P_C.Controls.Add(l1);
                for (int j = 0; j < Variables; j++)
                {

                    l1 = new Label();
                    l1.SetBounds((130 + (60 * j)), 5+110*(i), 40, 25);
                    l1.Text = "X" + (j).ToString();
                    l1.BackColor = Color.Yellow;
                    P_C.Controls.Add(l1);

                    // create textbox for one variable
                    NumericUpDown num = new NumericUpDown();
                    num.Maximum = 1000;
                    num.Minimum = -1000;
                    num.Value = 0;
                    // Locate textbox
                    num.SetBounds((130 + (60 * j)), 70+110*(i) , 50, 30);
                    // Set created text to array with respective indexes
                    constraintFunction[i][j] = num;
                    // Show it
                    P_C.Controls.Add(num);
                    
                }
                c++;
            }

        }


        private void CreateConstraintFunctionSigns()
        {
            // number of signs equals to number of constraints, create combobox, that stores <=, >=, = sighns
            constraintSigns = new ComboBox[Constraints];
            // Right side of constraint functions
            constraintFunctionRight = new NumericUpDown[Constraints];

            for (int i = 0; i < Constraints; i++)
            {
                // Create combobox in each row
                ComboBox comboxBox = new ComboBox();
                // Add =>, <=, =
                comboxBox.Items.AddRange(signs);
                // Locate it
                comboxBox.SetBounds(150+50 * Variables , i * 100 + 40, 60, 30);
                // Set default selected index to '='
                comboxBox.SelectedIndex = 1;
                // Add to array
                constraintSigns[i] = comboxBox;
                // show it
                P_C.Controls.Add(comboxBox);

                // Create textbox for right side of function
                NumericUpDown txtBox = new NumericUpDown();
                txtBox.Maximum = 99;
                txtBox.Minimum = -99;
                txtBox.Value = 0;
                // Locate it
                txtBox.SetBounds(230 + Variables*50, i * 100 + 40, 60, 30);
                constraintFunctionRight[i] = txtBox;
                P_C.Controls.Add(txtBox);
            }
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            targetCoefficients = new double[Variables];
            //Here we store coefficients of constraints
            constraints = new DConstraint[Constraints];

            for (int i = 0; i < Variables; i++)
            {
                // Parse fields stored in objFunction array to double and it to another array
                targetCoefficients[i] = double.Parse(objFunction[i].Text);
            }
            // Loop through constraints
            for (int i = 0; i < Constraints; i++)
            {
                // Stores constraint values at given index
                double[] consValues = new double[Variables];
                // Take right side of constraint
                double right = double.Parse(constraintFunctionRight[i].Text);

                // Take all fields and parse to double
                for (int j = 0; j < Variables; j++)
                {
                    consValues[j] = double.Parse(constraintFunction[i][j].Text);
                }
                // Represents sign of constraint
                int bound = 0;
                if (constraintSigns[i].SelectedIndex == 0) bound = PrimalSimplex.LESS_THAN;
                else if (constraintSigns[i].SelectedIndex == 1) bound = PrimalSimplex.EQUAL_TO;
                else bound = PrimalSimplex.GREATER_THAN;

                // Create object of DContraint passing arguments of variables, sign and right side, and store it to array
                constraints[i] = new DConstraint(consValues, bound, right);
            }

            // Initilize Dual Simplex
            initDualSimplex();
            // Solve given problem
            solve();
            // Show result
            assertResult();
        }

        private void initDualSimplex()
        {
            // Create object of DualSimplex
            ds = new DualSimplex();
            // Set objective function, also we pass mode of Simplex
            ds.setObjective(targetCoefficients, mode);
            // Init array of constrains
            double[][] constraintArray = new double[constraints.Length][];
            for (int i = 0; i < constraints.Length; i++)
            {
                constraintArray[i] = new double[targetCoefficients.Length];
            }
            int[] equations = new int[constraints.Length];
            // Array of right sides of constraints
            double[] rhs = new double[constraints.Length];
            for (int i = 0; i < constraints.Length; ++i)
            {
                constraintArray[i] = constraints[i].getCoefficients();
                equations[i] = constraints[i].getEquations();
                rhs[i] = constraints[i].getRHS();
            }
            // Set parameters of dual simplex and initialize it
            ds.setConstraints(constraintArray, equations, rhs);
            ds.init();
        }

        public void solve()
        {
            // We iterate while we don't have right solution
            while ((status = ds.iterate()) == DualSimplex.CONTINUE) { }
        }

        // Show result
        private void assertResult()
        {
            // Get coefficients of objective function from simplex
            double[] targetCoefficientValues = ds.getCoefficients();
            // Get answer function
            string res = "Z = " + ds.getObjectiveResult() + "\n";
            // We do some formatting data here
            for (int i = 0; i < targetCoefficients.Length; ++i)
            {
                res = res + " X" + i + " : " + targetCoefficientValues[i] + "\n";
            }
            // Show ResultForm with our result
             MessageBox.Show( res);
            //resultForm.ShowResult();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}