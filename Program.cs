using System;

namespace ReverseNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int  line, und,dec, ax;
            Console.Write("Enter U Number: ");
            line = Convert.ToInt32(Console.ReadLine());
            dec = line / 10;
            und = line % 10;
            ax = (und * 10) + dec;
            Console.Write("Ur Number Is:" + ax);
        }
    }
}
