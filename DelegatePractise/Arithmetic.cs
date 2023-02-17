using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DelegatePractise
{
    public delegate bool ArtihDel(int number);
    class Arithmetic
    {
        public int number;

        public Arithmetic(int number)
        {
            this.number = number;
        }
        public void Print() => Console.WriteLine(number);
        public static bool IsEven(int number)
        {
            if (EvenOddComparer(number) == true)
            {
                Console.WriteLine(number + " is even!");
                return true;
            }
            else
            {
                Console.WriteLine(number + " is not even!");
                return false;
            }
        }
        public static bool IsOdd(int number)
        {
            if (EvenOddComparer(number) == false)
            {
                Console.WriteLine(number + " is odd!");
                return true;
            }
            else
            {
                Console.WriteLine(number + " is not odd!");
                return false;
            }
        }
        public static bool IsSimple(int number) {

            if (number > 1 && number % 1 == 0 && number % 2 != 0 && number % 3 != 0 && number % 5 != 0)
            {
                Console.WriteLine(number + " is simple");
                return true;
            }
            else
            {
                Console.WriteLine(number + " is not simple");
                return false;
            }

        }
        public static bool IsFibonacci(int number) {
            int f1 = 1, f2 = 1, it = 2;

            while (f2 < number)
            {
                int tmp = f2;
                f2 += f1;
                f1 = tmp;
                it++;
            }
            if (f2 == number)
            {
                Console.WriteLine(number + " is Fibonacci!");
                return true;
            }
            Console.WriteLine(number + " is not Fibonacci!");
            return false;
        }

        static public bool EvenOddComparer(int number)
        {
            if(number % 2 == 0) return true;
            else return false;
        }

        public static void Func(int number,ArtihDel del)
        {
            del(number);
        }
      



    }
}
