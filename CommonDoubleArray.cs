using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    class CommonDoubleArray
    {
        protected double[,] mArrayA;
        protected double[] mArrayP;

        public double[,] A
        {
            get
            {
                return mArrayA;
            }
            set
            {
                mArrayA = value;
            }
        }

        public double[] P
        {
            get
            {
                return mArrayP;
            }
            set
            {
                mArrayP = value;
            }
        }

        public CommonDoubleArray(int heightA, int lengthA, int lengthP)
        {
            if (lengthA > 0)
            {
                mArrayA = new double[heightA, lengthA];
            }
            else
            {
                mArrayA = new double[0,0];
            }
            if (lengthP > 0)
            {
                mArrayP = new double[lengthP];
            }
            else
            {
                mArrayP = new double[0];
            }
        }

        public CommonDoubleArray(double[,] arrayA, double[] arrayP)
        {
            mArrayA = arrayA;
            mArrayP = arrayP;
        }
    }
}
