using System;
using System.Globalization;

namespace Estudo
{
    class media2
    {
        static void Main(string[] args)
        {

           double A, B, C, media;

            A = Double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
            B = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((A * 2) + (B * 3) + (C * 5)) / 10;
            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
