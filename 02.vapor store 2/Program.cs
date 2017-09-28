using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.vapor_store_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            string currentGame = string.Empty;
            double spentMoney = 0.0;
            while (currentGame!="Game Time")
            {
                currentGame = Console.ReadLine();
                if (currentGame=="OutFall 4"|| currentGame == "RoverWatch Origins Edition")
                {
                    currentBalance -= 39.99;
                    spentMoney += 39.99;
                   
                }
                 else if (currentGame == "CS:OG")
                {
                    currentBalance -= 15.99;
                    spentMoney += 15.99;
                    
                }
                 else if (currentGame == "Zplinter Zell")
                {
                    currentBalance -= 19.99;
                    spentMoney += 19.99;


                }
                else if (currentGame == "Honored 2")
                {
                    currentBalance -= 59.99;
                    spentMoney += 59.99;
                }
                               
                 else if (currentGame == "RoverWatch")
                {
                    currentBalance -= 29.99;
                    spentMoney += 29.99;
                }
                
                else
                {
                    Console.WriteLine("Not Found");
                }
                if (currentBalance<0)
                {
                    Console.WriteLine("Too ExpenSive");

                }
                else
                {
                    Console.WriteLine($"Bought {currentGame}");
                    
                }
                
            }
            Console.WriteLine("Out of money!");

        }
    }
}
