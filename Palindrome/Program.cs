using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, rev,sum = 0, temp;
            string str;
            Console.WriteLine("Enter a number");
            str = Console.ReadLine();
            num = Convert.ToInt32(str);
            temp = num;
            while (num > 0)
            {
                rev = num % 10;
                sum = (sum * 10) + rev;
                num = num / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Number is palindrome");
            }
            else
            {
                Console.WriteLine("Number is not palindrome");
            }

        }
    }
}
