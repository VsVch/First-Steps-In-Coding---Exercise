using System;

namespace _4_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {

            int str = int.Parse(Console.ReadLine());
            int strPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int sum = str / strPerHour;
            sum = sum / days;
            Console.WriteLine(sum);






        }
    }
}
