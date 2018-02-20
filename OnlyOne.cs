using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            i = Convert.ToInt32(Console.ReadLine());
            while (i != 1)
            {
                Console.WriteLine("Enter Again");
                i = Convert.ToInt32(Console.ReadLine());

            }
                Console.WriteLine("Good Job");
                Console.ReadKey();

        }
    }
}
