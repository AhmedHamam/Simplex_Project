using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplex
{
    public abstract class AbstractSimplex
    {

        public static int LESS_THAN = 0;
        public static int GREATER_THAN = 1;
        public static int EQUAL_TO = 2;
        ///*
        //public final static int GREATER_EQUAL = 3;
        //public final static int LESS_EQUAL = 4;
        //*/

        public static int CONTINUE = 0;
        public static int OPTIMAL = 1;
        public static int UNBOUNDED = 2;

        protected bool minimize;
        protected double[] objective;
        protected double[][] constraints;
        protected int[] equations;
        protected double[] rhs;

        protected double[][] m;
        protected int[] basisVariable;
        protected int[] nonBasisVariable;
        protected int[] slackVariable;
        protected bool[] locked;

        public void init()
        {
            this.m = new double[constraints.Length + 1][];
            for (int i = 0; i < constraints.Length + 1; i++)
            {
                this.m[i] = new double[objective.Length + constraints.Length + 1];
            }

            for (int i = 0; i < constraints.Length; ++i)
            {
                for (int j = 0; j < constraints[i].Length; ++j)
                {
                    m[i][j] = constraints[i][j] * (equations[i] == GREATER_THAN ? -1 : 1);
                }
                m[i][objective.Length + i] = 1;
                m[i][m[i].Length - 1] = rhs[i] * (equations[i] == GREATER_THAN ? -1 : 1);
            }
            for (int i = 0; i < objective.Length; ++i)
            {
                m[m.Length - 1][i] = objective[i] * (minimize ? 1 : -1);
            }
            this.nonBasisVariable = new int[objective.Length + constraints.Length];
            this.slackVariable = new int[constraints.Length];
            for (int i = 0; i < this.nonBasisVariable.Length; ++i)
            {
                this.nonBasisVariable[i] = i;
                if (i >= objective.Length)
                {
                    slackVariable[i - objective.Length] = i;
                }
            }
            this.basisVariable = new int[constraints.Length];
            for (int i = 0; i < this.basisVariable.Length; ++i)
            {
                basisVariable[i] = slackVariable[i];
            }
            this.locked = new bool[basisVariable.Length];
        }

        public void setObjective(double[] objective, bool minimize)
        {
            this.objective = objective;
            this.minimize = minimize;
        }

        public void setConstraints(double[][] constraints, int[] equations, double[] rhs)
        {
            this.constraints = constraints;
            this.equations = equations;
            this.rhs = rhs;
        }

        protected void pivot(int pivotRow, int pivotColumn)
        {
            double quotient = m[pivotRow][pivotColumn];
            for (int i = 0; i < m[pivotRow].Length; ++i)
            {
                m[pivotRow][i] = m[pivotRow][i] / quotient;
            }
            for (int i = 0; i < m.Length; ++i)
            {
                if (m[i][pivotColumn] != 0 && i != pivotRow)
                {

                    quotient = m[i][pivotColumn] / m[pivotRow][pivotColumn];

                    for (int j = 0; j < m[i].Length; ++j)
                    {
                        m[i][j] = m[i][j] - quotient * m[pivotRow][j];
                    }
                }
            }
            basisVariable[pivotRow] = nonBasisVariable[pivotColumn];
        }

        public double getObjectiveResult()
        {
            return m[m.Length - 1][m[m.Length - 1].Length - 1] * (minimize ? -1 : 1);
        }

        public double[] getCoefficients()
        {
            double[] result = new double[objective.Length];

            for (int i = 0; i < result.Length; ++i)
            {
                for (int j = 0; j < basisVariable.Length; ++j)
                {
                    if (i == basisVariable[j])
                    {
                        result[i] = m[j][m[j].Length - 1];
                    }
                }
            }
            return result;
        }
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append('\t');
            for (int i = 0; i < nonBasisVariable.Length; ++i)
            {
                if (i < (nonBasisVariable.Length - basisVariable.Length))
                {
                    s.Append('x');
                    s.Append(nonBasisVariable[i] + 1);
                }
                else
                {
                    s.Append('s');
                    s.Append(nonBasisVariable[i] - (nonBasisVariable.Length - basisVariable.Length) + 1);
                }
                s.Append('\t');
            }
            s.Append('\n');

            for (int i = 0; i < m.Length - 1; ++i)
            {
                if (basisVariable[i] < (nonBasisVariable.Length - basisVariable.Length))
                {
                    s.Append('x');
                    s.Append(basisVariable[i] + 1);
                }
                else
                {
                    s.Append('s');
                    s.Append(basisVariable[i] - (nonBasisVariable.Length - basisVariable.Length) + 1);
                }
                s.Append('\t');
                for (int j = 0; j < m[i].Length; ++j)
                {
                    s.Append(m[i][j]);
                    s.Append('\t');
                }
                s.Append('\n');
            }

            s.Append('Z');
            s.Append('\t');
            for (int i = 0; i < m[m.Length - 1].Length; ++i)
            {
                s.Append(m[m.Length - 1][i]);
                s.Append('\t');
            }
            s.Append('\n');

            return s.ToString();
        }
    }
}
