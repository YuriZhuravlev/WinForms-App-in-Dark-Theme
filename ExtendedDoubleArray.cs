using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    class ExtendedDoubleArray : CommonDoubleArray
    {
        private double FindMinimum()
        {
            double min = mArrayA[0, 0];
            foreach (double x in mArrayA)
            {
                min = (min > x ? x : min);
            }
            return min;
        }

        private double FindAverage()
        {
            double sum = 0;
            foreach (double x in mArrayP)
            {
                sum += x;
            }
            return (sum / mArrayP.Length);
        }

        public ExtendedDoubleArray(int heightA, int lengthA, int lengthP) : base(heightA, lengthA, lengthP) { }
        public ExtendedDoubleArray(double[,] arrayA, double[] arrayP) : base(arrayA, arrayP) { }

        public double MinimumA
        {
            get
            {
                return FindMinimum();
            }
        }
        public double AverageP
        {
            get
            {
                return FindAverage();
            }
        }

        //Если среднее арифметическое элементов  P больше значения Amin  минимального элемента  А, вычесть Amin из каждого элемента  P.
        public void Processing()
        {
            if (mArrayP.Length > 0 && mArrayA.Length > 0)
            {
                double minA = MinimumA;
                if (AverageP > minA)
                {
                    for (int i = 0; i < mArrayP.Length; i++)
                    {
                        mArrayP[i] -= minA;
                    }
                }
            }
        }
    }
}
