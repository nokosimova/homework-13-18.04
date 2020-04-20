using System;

namespace CalculateMethods
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public static T Addition<T>(T x1, T x2)
        {
            return (dynamic)x1 + (dynamic)x2;
        }
        public static T Subtraction<T>(T x1, T x2)
        {
            return (dynamic)x1 + (dynamic)x2;
        }
        public static T Multiplication<T>(T x1, T x2)
        {
            return (dynamic)x1 * (dynamic)x2;
        }
        public static T Division<T>(T x1, T x2)
        {
            if ((dynamic)x2 == 0)
            {
                Console.WriteLine("На 0 делить нельзя!!!");
                return (dynamic)0;
            }
            else 
            {
                return (dynamic)x1 / (dynamic)x2;
            }
        }
    }
}
