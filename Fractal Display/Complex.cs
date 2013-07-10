using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fractal_Display
{
    class Complex
    {
        public double Real { get; set; }
        public double Img { get; set; }

        public Complex()
        {
            Real = 0;
            Img = 0;
        }

        public Complex(double inReal, double inImg)
        {
            Real = inReal;
            Img = inImg;
        }

        public Complex Add(Complex addTo)
        {
            Complex retnumber = new Complex(this.Real + addTo.Real, this.Img + addTo.Img);
            return retnumber;
        }

        public Complex Square()
        {
            Complex numberreturn = new Complex();
            numberreturn.Real = this.Real * this.Real - (this.Img * this.Img);
            numberreturn.Img = (this.Real * this.Img) * 2;
            return numberreturn;
        }

        public override string ToString()
        {
            return this.Real + "+" + this.Img + "i";
        }

    }
}
