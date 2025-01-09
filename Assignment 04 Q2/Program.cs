namespace Assignment_04_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Maths.Add(1, 2));
            Console.WriteLine(Maths.Subtract(1, 2));
            Console.WriteLine(Maths.Multiply(1, 2));
            try
            {
                Console.WriteLine(Maths.Divide(1, 2));
                Console.WriteLine(Maths.Divide(1, 0));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
