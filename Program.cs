using System;

namespace CalculateMethods
{
    class Program
    {
        delegate U Operation<T, U>(T x, T y);
        static void Main(string[] args)
        {
            Operation<int,double> oper;
            int x1, x2;
            char operation;
            
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
                    oper = Addition<int, double>;
                    break;
                case '-':
                    oper = Subtraction<int, double>;
                    break;
                case '*':
                    oper = Multiplication<int, double>;
                    break;
                case '/':
                    oper = Division<int, double>;
                    break;
                default:
                    Console.WriteLine("Incorrect operation");
                    break;
            }


        }
        public static U Addition<T,U>(T x1, T x2)
        {
            return (dynamic)x1 + (dynamic)x2;
        }
        public static U Subtraction<T,U>(T x1, T x2)
        {
            return (dynamic)x1 + (dynamic)x2;
        }
        public static U Multiplication<T,U>(T x1, T x2)
        {
            return (dynamic)x1 * (dynamic)x2;
        }
        public static U Division<T,U>(T x1, T x2)
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
