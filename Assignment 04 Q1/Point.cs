using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Q1
{
    internal class Point3D : IComparable, ICloneable
    {
        #region Properties
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; } 
        #endregion

        #region Constructors
        public Point3D(int _x, int _y, int _z) : this(_x, _y)
        {
            Z = _z;
        }
        public Point3D(int _x, int _y) : this(_x)
        {
            Y = _y;
        }
        public Point3D(int _x)
        {
            X = _x;
        } 
        #endregion

        #region Operators Overloading
        public static bool operator ==(Point3D left, Point3D right)
        {

            if (left is null || right is null)
            {
                return false;
            }

            return (left.X == right.X) && (left.Y == right.Y) && (left.Z == right.Z);
        }

        public static bool operator !=(Point3D left, Point3D right)
        {
            return !(left == right);
        }
        #endregion

        #region Methods Overriding
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            Point3D point = (Point3D)obj;
            return (X == point.X) && (Y == point.Y) && (Z == point.Z);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }

        #endregion

        #region Methods
        public static Point3D PointInput(string point)
        {
            int x, y, z;
            Console.WriteLine($"enter the coordinates of {point} : ");

            x = CoordinatesInput("X");
            y = CoordinatesInput("Y");
            z = CoordinatesInput("Z");

            return new Point3D(x, y, z);
        }

        private static int CoordinatesInput(string coordinate)
        {
            int coordianteValue;
            do
            {
                Console.Write($"{coordinate} : ");
            }
            while (!int.TryParse(Console.ReadLine(), out coordianteValue));

            return coordianteValue;
        }
        #endregion

        #region IComparable
        public int CompareTo(Object? obj)
        {
            if (obj == null) return 1;

            Point3D point3D = (Point3D)obj;

            if (X == point3D.X) return Y.CompareTo(point3D.Y);
            return X.CompareTo(point3D.X);
        }
        #endregion

        #region IClonable
        public object Clone()
        {
            return new Point3D(X, Y, Z);
        } 
        #endregion
    }
}
