using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BMP_counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfBeatsPerMinute = int.Parse(Console.ReadLine());
            int countOfBeats = int.Parse(Console.ReadLine());
            double bars = countOfBeats / 4.0;
            Console.Write($"{Math.Round(bars,1)} bars - ");
            double lenghtOfSequence = (countOfBeats * 60) / countOfBeatsPerMinute;
            int minutes = (int)lenghtOfSequence/60;
            int seconds =(int)lenghtOfSequence % 60;
            Console.WriteLine($"{minutes}m {seconds}s");
        }
    }
}
