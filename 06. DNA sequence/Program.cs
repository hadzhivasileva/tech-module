using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DNA_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int numToCompare = int.Parse(Console.ReadLine());
            string base1 = string.Empty;
            string base2 = string.Empty;
            string base3 = string.Empty;
            int counter = 0;
            for (int a = 1; a <=4; a++)
            {
                for (int c = 1; c <=4; c++)
                {
                    for (int g = 1; g <= 4; g++)
                    {
                        
                        counter++;
                        
                        if (a==1)
                        {
                            base1 = "A";
                        }
                        else if (a==2)
                        {
                            base1 = "C";
                        }
                        else if (a == 3)
                        {
                            base1 = "G";
                        }
                        else if (a == 4)
                        {
                            base1 = "T";
                        }
                        if (c == 1)
                        {
                            base2 = "A";
                        }
                        else if (c == 2)
                        {
                            base2 = "C";
                        }
                        else if (c == 3)
                        {
                            base2 = "G";
                        }
                        else if (c == 4)
                        {
                            base2 = "T";
                        }
                        if (g == 1)
                        {
                            base3 = "A";
                        }
                        else if (g == 2)
                        {
                            base3 = "C";
                        }
                        else if (g == 3)
                        {
                            base3 = "G";
                        }
                        else if (g == 4)
                        {
                            base3 = "T";
                        }
                        int sum = a + c + g;
                        if (sum>=numToCompare)
                        {
                            Console.Write($"O{base1}{base2}{base3}O ");
                        }
                        else
                        {
                            Console.Write($"X{base1}{base2}{base3}X ");
                        }
                        if (counter%4==0)
                        {
                            Console.WriteLine();
                        }
                        
                        
                    }
                    
                    

                }
            }
        }
    }
}
