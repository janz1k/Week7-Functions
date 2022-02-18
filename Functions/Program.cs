using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("sisesta esimest arvu:");
            int userNumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sisesta teist arvu:");
            int userNumberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("vali tehe (sisesta '+', '-', '*' või '/')");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch (userOperator)
            {
                case '+':
                    AddTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '/':
                    DivideTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '*':
                    DoublingTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '-':
                    SubtractionTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                default:
                    Console.WriteLine("Vale tehte märk sisestatud, Kena päeva!");
                    break;
            }

        }


        private static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine(result);
        }
        private static void DivideTwoNumbers(int x, int y)
        {
            double result = x / y;
            Console.WriteLine(result) ;
        }

        private static void DoublingTwoNumbers(int x, int y)
        {
            int result = x * y;
            Console.WriteLine(result);
        }

        private static void SubtractionTwoNumbers(int x, int y)
        {
            int result = x - y;
            Console.WriteLine(result);
        }

        //lahutamine

        //korrutamine
    }
}
