using System.Numerics;
using Demo_04.Abstraction;
using Demo_04.Mapping;
using Demo_04.Operators_Overloading;
using Demo_04.Partial;
using Demo_04.Static;
using Complex = Demo_04.Operators_Overloading.Complex;

namespace Demo_04
{
    #region Revision
    // 1. Class
    // 2. Struct
    // 3. enum 
    // 4. interface 
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Revision
            // Revision
            // Interfaces : Reference Type => Code Contract
            // Shallow Copy VS Deep Copy
            // Built-in Interfaces 
            #endregion

            #region Abstraction
            ////// 4. Abstraction : 
            ////// abstract : C# Keyword [Classes - methods - properties]
            ////// abstract class
            ////// abstract method
            ////// abstract property

            ////// 2D Shape

            //////Shape shape = new Shape(); // Invalid => Can't Create an Object from an abstract class
            //////shape.CalcArea();

            //Rectangle rectangle = new Rectangle() { Dim01 = 10, Dim02 = 20 };
            //rectangle.Print();
            //Console.WriteLine($"Rectangle Area = {rectangle.CalcArea()}");
            //Console.WriteLine($"Rectangle Perimeter = {rectangle.Perimeter}");

            //Square square = new Square(5);
            //square.Print();
            //Console.WriteLine($"Square Area = {square.CalcArea()}");
            //Console.WriteLine($"Square Perimeter = {square.Perimeter}"); 
            #endregion

            #region Interface Abstract

            #endregion

            #region Operators Overloading
            //Complex C01 = new Complex() { Real = 2, Imaginary = 7 };
            //Complex C02 = new Complex() { Real = 3, Imaginary = 6 };

            #region Binary Operators

            //Complex C03 = C01 + C02;

            //Console.WriteLine($"C01 = {C01}");
            //Console.WriteLine($"C02 = {C02}");
            //Console.WriteLine("============");
            //Console.WriteLine($"C03 = {C03}");

            #endregion

            #region Unary Operators
            //Console.WriteLine($"C01 = {C01}");

            //Complex C03 = C01++;

            //Console.WriteLine("After ++");

            //Console.WriteLine($"C01 = {C01}");
            //Console.WriteLine($"C03 = {C03}");
            #endregion

            #region Relational Operators
            //if(C01 > C02)
            //    Console.WriteLine("C01 is greater than C02"); 
            //else if (C01 < C02)
            //    Console.WriteLine("C01 is less than C02");
            //else Console.WriteLine("C01 equals C02"); 
            #endregion
            #endregion

            #region Casting Operator Overloading
            #region Explicit int casting
            //////object obj = 5;
            //////int X = (int) obj;
            ////// (int) => Casting Operator

            ////Complex C = new Complex() { Real = 2, Imaginary = 6 };

            ////int Y = (int)C;
            ////Console.WriteLine(Y);

            ////int Z = (int)new Complex { Real = 3, Imaginary = 7 };
            #endregion

            #region Implicit string casting 

            //Complex C = new Complex() { Real = 2, Imaginary = 6 };
            //string Y = /*(string)*/C;
            //Console.WriteLine(Y);

            #endregion
            #endregion

            #region Manual Mapping
            //////// Mapping => Convert From Datatype to Datatype
            //////// Code First , DB First
            //////// User [Id, Name , Email, Password, UserName, PhoneNumber, CardNumber, ExpireDate ]
            //////// UserViewModel , UserDTO [Name, Email, PhoneNumber]


            //User user = new User(); // From DB
            //// Manual Mapping
            //UserDto userDto = new UserDto()
            //{
            //    Email = user.Email,
            //    Name = user.Name,
            //    Password = user.Password,
            //};

            //// Automapper : Automatic Mapping
            #endregion

            #region Static
            //// static : C# Keyword [Class - method - property - constructor - attributes]
            //// static class
            //// static method
            //// static property
            //// static contructor
            //// static attribute

            ////Utilities U01 = new Utilities();
            ////Utilities U02 = new Utilities();
            ////Utilities U03 = new Utilities();

            ////Console.WriteLine(U01.CmToInch(254)); // 100
            ////Console.WriteLine(U02.CmToInch(254)); // 100
            ////Console.WriteLine(U03.CmToInch(254)); // 100

            //Console.WriteLine(Utilities.CmToInch(254)); // 100

            ////Console.WriteLine(U01.PI); // 3.14
            ////Console.WriteLine(U02.PI); // 3.14
            ////Console.WriteLine(U03.PI); // 3.14

            //Console.WriteLine(Utilities.PI);

            //////Utilities U1 = new Utilities(); // Invalid => Can't create objects from a static class 
            #endregion

            #region Sealed
            // Sealed => C# Keyword [class - method - property] 
            #endregion

            #region Partial

            //Employee employee = new Employee();
            //employee.Name = "Mr Morale";
            //employee.Id = 1;

            #endregion
        }
    }
}
