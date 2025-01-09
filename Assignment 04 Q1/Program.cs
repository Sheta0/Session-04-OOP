namespace Assignment_04_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //Point3D point1 = new Point3D(1);
            //Point3D point2 = new Point3D(1, 1);
            //Point3D point3 = new Point3D(1, 1, 1);

            #endregion
            #region Q2
            //Point3D P = new Point3D(10, 10, 10);
            //Console.WriteLine(P.ToString()); 
            #endregion

            #region Q3
            //Point3D P1 = Point3D.PointInput("P1");
            //Point3D P2 = Point3D.PointInput("P2");

            //Console.WriteLine($"P1 = {P1}");
            //Console.WriteLine($"P2 = {P2}"); 
            #endregion

            #region Q4
            //////bool flag = P1 == P2;
            //////// doesn't work properly always gives false (which is the default for boolean)
            //////// because "==" can't compare between objects from user defined classes
            //////// We have to overload it with a new behavior 

            //Point3D point01 = new Point3D(1, 2, 3);
            //Point3D point02 = new Point3D(1, 2, 3);

            //bool Correctflag = point01 == point02;
            //Console.WriteLine(Correctflag);
            #endregion

            #region Q5
            //Point3D[] pointArr =
            //{
            //    new Point3D (4, 9, 4),
            //    new Point3D (4, 2, 9),
            //    new Point3D (3, 9, 21)
            //};

            //Array.Sort(pointArr);
            //foreach (var point in pointArr)
            //{
            //    Console.WriteLine(point);
            //}
            #endregion

            #region Q6
            //Point3D P01 = new Point3D(1, 1, 1);
            //Point3D P02 = (Point3D)P01.Clone();

            //Console.WriteLine(P01);
            //Console.WriteLine(P02);

            //// HashCodes are the same because of the overriding to GetHashCode Method
            #endregion
        }
    }
}
