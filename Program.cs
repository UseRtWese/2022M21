using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 100, min = 0;
            Random ans = new Random();
            int ansnum = ans.Next(0,100);
            int guest;
            for (int i = 0; i <= 5; i++) {
                Console.ReadLine(Convert.ToInt32);

                if (ansnum == guest) { Console.WriteLine("答對了"); break; }
                if (ansnum > guest) { Console.WriteLine("低一點"); };
                if (ansnum < guest) { Console.WriteLine("高一點"); };


            }



            }
        }
    }
}
