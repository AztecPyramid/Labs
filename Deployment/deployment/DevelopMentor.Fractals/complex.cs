#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

using Complex = Neocranium.Fractals.ComplexDouble;

#endregion

namespace Neocranium.Fractals
{
    [Serializable]
    public struct ComplexDouble 
    {
        public double real;
        public double imaginary;

        public ComplexDouble(double real, double imaginary)
        {
            this.real = real; this.imaginary = imaginary;
        }

        public override string ToString()
        {
            return String.Format("({0},{1})", real.ToString(), imaginary.ToString());
        }


        public override bool Equals(object obj)
        {
            ComplexDouble d = (ComplexDouble)obj;
            return (real == d.real && imaginary == d.imaginary);
        }

        public static bool operator ==(ComplexDouble a, ComplexDouble b)
        {
            return (a.real.Equals(b.real)) && (a.imaginary.Equals(b.imaginary));
        }

        public static bool operator !=(ComplexDouble a, ComplexDouble b)
        {
            return (!a.real.Equals(b.real)) || (!a.imaginary.Equals(b.imaginary));
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //This is a shortcut for z->z^2+c - implementing it as a
        //standalone function SHOULD be faster than calling one function
        //to square the number and a second one to do the add.
        public void SquareAndAdd(ComplexDouble c)
        {
            //(a + bi)(a + bi) + (c+di) =(a^2 - b^2 + c) + (2ab + d)i;

            double r = (real * real) - (imaginary * imaginary) + c.real;
            double i = (2.0 * real * imaginary) + c.imaginary;

            this.real = r;
            this.imaginary = i;

        }
        public double GetSquaredModulus()
        {
            double x = this.real;
            double y = this.imaginary;
            return (double)(x * x + y * y);
        }
        
        public static double GetSquaredDistance(ComplexDouble a, ComplexDouble b)
        {
            double dr = a.real - b.real;
            double di = a.imaginary - b.imaginary;
            return dr * dr + di * di;
        }

        public static ComplexDouble operator+(ComplexDouble a, ComplexDouble b) {
            return new ComplexDouble(a.real + b.real, a.imaginary + b.imaginary);
         }

        public static ComplexDouble operator-(ComplexDouble a, ComplexDouble b)
        {
            return new ComplexDouble(a.real - b.real, a.imaginary - b.imaginary);
        }

        public static ComplexDouble operator*(ComplexDouble a, ComplexDouble b)
        {
            return new ComplexDouble(a.real * b.real - a.imaginary * b.imaginary,
                                      a.imaginary * b.real + a.real * b.imaginary);
        }

        public static ComplexDouble operator/(ComplexDouble a, ComplexDouble b)
        {
            ComplexDouble ret;
            double divisor = b.real * b.real + b.imaginary * b.imaginary;
            ret.real = (a.real * b.real + a.imaginary * b.imaginary) / divisor;
            ret.imaginary = (a.imaginary * b.real - a.real * b.imaginary) / divisor;
            return ret;
        }
     }
}

