using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoseleyHMK6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] random = new string[3];//declare array with data type specified
            random[0] = "apple";
            random[1] = "banana";
            random[2] = "c#";

            for (int i=0; i<random.Length; i++)
            {
                Console.WriteLine("{0}", random[i]);

            }//end of for loop

            Console.WriteLine();//blank

            int[] numbers = new int[5];//declare array with data type specified

            for(int i=0; i<numbers.Length; i++)
            {
                Console.Write("Please enter value {0}:  ", i+1);
                int userInput;
                while(int.TryParse(Console.ReadLine(), out userInput)==false || userInput<=0)
                { Console.Write("Please try again:  "); }

                numbers[i] = userInput;

            }//end of for loop

            Console.WriteLine();//blank

            int sum = 0;
            foreach (int value in numbers)
            {
                sum = sum + value;
            }

            Console.WriteLine("The sum is {0}.", sum);

            Console.ReadKey();
        }
    }
}
