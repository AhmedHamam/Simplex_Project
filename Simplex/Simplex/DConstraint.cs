using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simplex
{
    class DConstraint
    {
        // store here coefficients of contraint
        private double[] coefficients;
        // sign of constraint
        private int equations;
        // right side
        private double rhs;

        // Constructor
        public DConstraint(double[] coefficients, int equations, double rhs)
        {
            this.coefficients = coefficients;
            this.equations = equations;
            this.rhs = rhs;
        }
        public double[] getCoefficients()
        {
            return coefficients;
        }
        // sign of constraint
        public int getEquations()
        {
            return equations;
        }

        public double getRHS()
        {
            return rhs;
        }
    }
}
