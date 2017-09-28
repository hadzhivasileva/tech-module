using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPhoto = int.Parse(Console.ReadLine());
            int dayOfPhoto = int.Parse(Console.ReadLine());
            int monthOfPhoto = int.Parse(Console.ReadLine());
            int yearOfPhoto = int.Parse(Console.ReadLine());
            int hoursOfPhoto = int.Parse(Console.ReadLine());
            int minutesOfPhoto = int.Parse(Console.ReadLine());
            int sizeOfPhoto = int.Parse(Console.ReadLine());
            int widthOfPhotoInPixels = int.Parse(Console.ReadLine());
            int heightOfPhotoInPixels = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: DSC_{numOfPhoto:d4}.jpg");
            Console.WriteLine($"Date Taken: {dayOfPhoto:d2}/{monthOfPhoto:d2}/{yearOfPhoto} {hoursOfPhoto:d2}:{minutesOfPhoto:d2}");
            if (sizeOfPhoto<1000)
            {
                Console.WriteLine($"Size: {sizeOfPhoto}B");
            }
            else if (sizeOfPhoto>=1000&&sizeOfPhoto<1000000)
            {
                Console.WriteLine($"Size: {sizeOfPhoto/1000.0}KB");
            }
            else if (sizeOfPhoto>=1000000)
            {
                Console.WriteLine($"Size: {sizeOfPhoto / 1000000.0}MB");
            }
            string orientationOfPhoto = string.Empty;
            if (widthOfPhotoInPixels>heightOfPhotoInPixels)
            {
                orientationOfPhoto = "landscape";
                
            }
            else if (widthOfPhotoInPixels < heightOfPhotoInPixels)
            {
                orientationOfPhoto = "portrait";
            }
            else if (widthOfPhotoInPixels == heightOfPhotoInPixels)
            {
                orientationOfPhoto = "square";
            }
            Console.WriteLine($"Resolution: {widthOfPhotoInPixels}x{heightOfPhotoInPixels} ({orientationOfPhoto})");

        }
    }
}
