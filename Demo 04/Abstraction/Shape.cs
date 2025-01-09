using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_04.Abstraction
{
    // Abstract Class => is a Partial Class (Not Fully Implemented Class)
    //                => is a Containter for Common Code (Fully Implemented Members, Abstract Members) among many classes
    // Can't Create Objects from abstract class (it's not fully implemented)
    abstract class Shape
    {
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }

        // Abstract Property : like virtual property but without any implementation
        public abstract decimal Perimeter { get; }

        // Abstract Method : like virtual method but without any implementation
        public abstract decimal CalcArea();

        public virtual void Print()
        {
            Console.WriteLine("I am Shape");
        }
    }

    abstract class RectBase : Shape
    {
        public override decimal CalcArea()
        {
            return Dim01 * Dim02;
        }
    }

    // Concrete Class : Fully Implemented Class
    class Rectangle : RectBase
    {
        public override decimal Perimeter 
        { 
            get { return (Dim01 + Dim02) * 2; }
        }

        public override void Print()
        {
            Console.WriteLine("I am Rectangle");
        }

    }

    // Concrete Class
    class Square : RectBase
    {
        public Square(decimal _dim)
        {
            Dim01 = Dim02 = _dim;
        }
        public override decimal Perimeter
        {
            get { return Dim01 * 4; }
        }

        public override void Print()
        {
            Console.WriteLine("I am Square");
        }

    }
}
