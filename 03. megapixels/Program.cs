using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            decimal imagePixels = (width * height) / 1000000.0m;
            Console.WriteLine($"{width}x{height} => {Math.Round(imagePixels,1)}MP");
        }
    }
}
