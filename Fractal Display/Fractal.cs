using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fractal_Display
{
    class Fractal
    {
        public int MaxIterations { get; set; }
        //-1 == in the set, else number of iteration till escape
        public int[,] grapharray;
        public double XBoundMax { get; set; }
        public double xBoundMin { get; set; }
        public double YBoundMax { get; set; }
        public double YBoundMin { get; set; }


        public Fractal()
        {
            MaxIterations = 0;
            XBoundMax = 0;
            xBoundMin = 0;
            YBoundMax = 0;
            YBoundMin = 0;
        }

        public Fractal(int inIterations, double xMax, double xMin, double yMax, double yMin)
        {
            grapharray = new int[750,500];
            MaxIterations = inIterations;
            XBoundMax = xMax;
            xBoundMin = xMin;
            YBoundMax = yMax;
            YBoundMin = yMin;
            //populate the graph array
            double xincrement = (xMax - xMin) / 750;
            double yincrement = (yMax - yMin) / 500;
            for (int i = 0; i < 750; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    Complex testValue = new Complex(xincrement*i - 2.5, yincrement*j - 1);
                    grapharray[i,j] = numberInSet(testValue);
                }
            }
        }

        public int numberInSet(Complex inputNumber)
        {
            Complex iterationNumber = new Complex(inputNumber.Real, inputNumber.Img);
            for (int i = 0; i < MaxIterations; i++)
            {
                iterationNumber = iterationNumber.Square();
                iterationNumber = iterationNumber.Add(inputNumber);
                if (iterationNumber.Real * iterationNumber.Real + iterationNumber.Img * iterationNumber.Img > 4)
                    return i;
            }
            return -1;
        }
    }
}
