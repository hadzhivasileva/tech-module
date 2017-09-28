using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.x
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char x = 'x';
            char blankSpace = ' ';
            int upperandDownRows = (n - 1) / 2;
            int middlePart = n - 2;
            int rightPart = 0;
            for (int i = 1; i <=upperandDownRows; i++)
            {
                Console.WriteLine("{0}x{1}x",new string(blankSpace,rightPart) ,new string(blankSpace,middlePart));
                middlePart -= 2;
                rightPart++;
            }
            Console.WriteLine("{0}x",new string(blankSpace,rightPart));
            middlePart += 2;
            rightPart--;
            for (int i = 1; i <=upperandDownRows; i++)
            {
                Console.WriteLine("{0}x{1}x", new string(blankSpace, rightPart), new string(blankSpace, middlePart));
                middlePart += 2;
                rightPart--;
            }
        }
    }
}
