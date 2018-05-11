using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05JordanBurdick
{
    class Program
    {
        static void Main(string[] args)
        {

            int SpeedLimit = 35;
            int Speed = 42;
            if (Speed > SpeedLimit)
            {
                Console.WriteLine("SLOW NOW");
            }

            Console.Clear();
            bool isTrue = true;

            if (isTrue == false)
            {
                Console.WriteLine("It is False!");
            }
            else
            {
                Console.WriteLine("It is True!");
            }

            int i = 0;
            while (i < 10)
            {
                i++;
                Console.WriteLine(i);
            }

            int j = 61;
            while (j > 20)
            {
                j--;
                Console.WriteLine(j);
            }

            int k = 9;
            while (k < 20)
            {
                k++;
                Console.WriteLine(k);
            }

            double UserInput;
            Console.Clear();
            Console.WriteLine("Please enter the temperature to be converted");
            UserInput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("the temperature '{0}' in Celsius  is {1}.", UserInput, (UserInput - 32) * 5 / 9);
            double UserInputHold = (UserInput - 32) * 5 / 9;
            if ( UserInputHold < 40 )
                {
                Console.WriteLine("It is cold");
            }
            else if (UserInputHold > 90)
            {
                Console.WriteLine("It is hot");
            }


            //pls
        }
    }
}
