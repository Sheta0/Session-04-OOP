using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_04.Sealed
{
    internal sealed class TypeC : TypeB
    {
        public int C { get; set; }

        //public override int A { get => base.A; set => base.A = value; } // Invalid => can't override a sealed property
        //public override void MyFun() // Invalid => can't override a sealed method
        //{
        //    base.MyFun();
        //}
    }
}
