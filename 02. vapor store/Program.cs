using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.vapor_store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double initialBallance = currentBalance;
            string currentGame = Console.ReadLine();
            
            
            while (currentGame!= "Game Time"&& currentBalance>0)
            {
                double currentPrice = 0.00;
                string title = string.Empty;
                switch (currentGame)
                {
                    case "OutFall 4":currentPrice = 39.99;
                        title = "OutFall 4";
                        break;
                        
                    case "CS:OG":
                        currentPrice = 15.99;
                        title= "CS:OG";
                        break;
                    case "Zplinter Zell":
                        currentPrice = 19.99;
                        title = "Zplinter Zell";
                        break;

                    case "Honored 2":
                        currentPrice = 59.99;
                        title = "Honored 2";
                        break;

                    case "RoverWatch":
                        currentPrice= 29.99;
                        title = "RoverWatch";
                        break;
                        
                    case "RoverWatch Origins Edition":
                        title = "RoverWatch Origins Edition";
                        currentPrice = 39.99;
                        break;
                                      
                    default:
                        Console.WriteLine("Not Found");
                        title = "Not Found";
                        break;

                }

                if (currentPrice>currentBalance)
                {
                    Console.WriteLine("Too Expensive");
                }
                else if (currentPrice<=currentBalance&&title!="Not Found")
                {
                    Console.WriteLine($"Bought {title}");
                    currentBalance -= currentPrice;
                }
                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                }

                currentGame = Console.ReadLine();
            }

            if (currentBalance!=0)
            {
                Console.WriteLine($"Total spent: ${(initialBallance - currentBalance):f2}. Remaining: ${currentBalance:f2}");
            }
                
            
            
               
                    
                                  

            
        }
    }
}
