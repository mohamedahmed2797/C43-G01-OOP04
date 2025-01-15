using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_oop_3
{
    internal class ComplexNumber
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }
    
        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber()
            {
                Real = (a?.Real?? 0) + (b?.Real?? 0),
                Imaginary = (a?.Imaginary?? 0) + (b?.Imaginary?? 0)
            };
        }
        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber()
            {
                Real = (a?.Real ?? 0) - (b?.Real ?? 0),
                Imaginary = (a?.Imaginary ?? 0) - (b?.Imaginary ?? 0)
            };
        }
        public override string ToString()
        {
           return ($"{Real} + {Imaginary}i");
        }
    }
}
