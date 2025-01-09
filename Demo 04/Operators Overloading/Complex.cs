using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_04.Operators_Overloading
{
    class Complex
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }

        #region Operators Overloading 
        // Overloading Operators => Must Create Pubic Class member (static) Function

        #region Binary Operators
        // Binary : + - * / %

        // 3 + 4i // Left
        // 5 + 6i // Right
        // 8 + 10i

        public static Complex operator +(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = (Left?.Real ?? 0) + (Right?.Real ?? 0),
                Imaginary = (Left?.Imaginary ?? 0) + (Right?.Imaginary ?? 0)
            };
        }
        public static Complex operator -(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = (Left?.Real ?? 0) - (Right?.Real ?? 0),
                Imaginary = (Left?.Imaginary ?? 0) - (Right?.Imaginary ?? 0)
            };
        }

        #endregion

        #region Unary Operators
        // ++ --
        public static Complex operator ++(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) + 1,
                Imaginary = (C?.Imaginary ?? 0)
            };
        }
        
        public static Complex operator --(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) - 1,
                Imaginary = (C?.Imaginary ?? 0)
            };
        }

        #endregion

        #region Comparison Operators
        // < > <= >= == !=
        // Boolean
        public static bool operator > (Complex left, Complex right)
        {
            if((left?.Real) == (right?.Real))
                return left?.Imaginary > right?.Imaginary;
            else return left?.Real > right?.Real;
        }

        public static bool operator < (Complex left, Complex right)
        {
            if((left?.Real) == (right?.Real))
                return left?.Imaginary < right?.Imaginary;
            else return left?.Real < right?.Real;
        }

        public static bool operator >= (Complex left, Complex right)
        {
            if((left?.Real) == (right?.Real))
                return left?.Imaginary >= right?.Imaginary;
            else return left?.Real >= right?.Real;
        }

        public static bool operator <= (Complex left, Complex right)
        {
            if((left?.Real) == (right?.Real))
                return left?.Imaginary <= right?.Imaginary;
            else return left?.Real <= right?.Real;
        }

        public static bool operator ==(Complex left, Complex right)
        {
            return left?.Real == right?.Real && left?.Imaginary == right?.Imaginary;
        }
        
        public static bool operator !=(Complex left, Complex right)
        {
            return left?.Real != right?.Real || left?.Imaginary != right?.Imaginary;
        }

        #endregion

        #endregion

        #region Casting Operators Overloading
        // Overloading Casting Operators => Must Create Public Class member (static) Function

        public static explicit operator int (Complex C)
        {
            return C?.Real ?? 0;
        }

        public static implicit operator string (Complex C)
        {
            return C?.ToString() ?? string.Empty;
        }

        #endregion

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }
}
