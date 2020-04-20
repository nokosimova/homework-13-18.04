using System;

namespace CalculateMethods
{
    class Program
    {
        delegate T Operation<T>(T x, T y);
        delegate U Opperation<T,U> (T x, T y);
        static void Main(string[] args)
        {
            Operation<int> oper;
            Opperation<int, double> opper;
            int x1, x2;
            char operation;
            double result;
            
            Console.WriteLine("Enter numbers:");
            Console.Write("x1 = ");
            x1 = int.Parse(Console.ReadLine());

            Console.Write("x2 = ");
            x2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose operation: + , - , * , / ");
            operation = char.Parse(Console.ReadLine());
            switch(operation)
            {
                case '+':
                    oper = Addition<int>;
                    result = oper(x1,x2);
                    Console.WriteLine($"result = {result}");
                    break;
                
                case '-':
                    oper = Subtraction<int>;
                    result = oper(x1,x2);
                    Console.WriteLine($"result = {result}");
                    break;
                
                case '*':
                    oper = Multiplication<int>;
                    result = oper(x1,x2);
                    Console.WriteLine($"result = {result}");
                    break;
                
                case '/':
                    opper = Division<int, double>;
                    result = Math.Round(opper(x1,x2),4);
                    if (x2 == 0)
                        Console.WriteLine("На 0 делить нельзя!!!");
                    else
                        Console.WriteLine($"result = {result}");
                    break;
                
                default:
                    Console.WriteLine("Incorrect operation");
                    break;
            }
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
        public static U Division<T,U>(T x1, T x2)
        {
            if ((dynamic)x2 == 0)
            {
                return (dynamic)0;
            }
            else 
            {
                return (dynamic)x1 / (dynamic)x2;
            }
        }
    }
}
