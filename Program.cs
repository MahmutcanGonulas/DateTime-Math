using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Günün Tarihi
            Console.WriteLine("DateTime.Now "+DateTime.Now);
            //Gün ay yIL
            Console.WriteLine("DateTime.Now.Date "+DateTime.Now.Date);
            //GÜN
            Console.WriteLine("DateTime.Now.Day "+DateTime.Now.Day);
            //AY
            Console.WriteLine("DateTime.Now.Month "+DateTime.Now.Month);
            //YIL
            Console.WriteLine("DateTime.Now.Year "+DateTime.Now.Year);
            //SAAT
            Console.WriteLine("DateTime.Now.Hour "+DateTime.Now.Hour);
            Console.WriteLine("DateTime.Now.Minute "+DateTime.Now.Minute);
            Console.WriteLine("DateTime.Now.Second "+DateTime.Now.Second);

            Console.WriteLine("DateTime.Now.DayOfWeek "+DateTime.Now.DayOfWeek);
            Console.WriteLine("DateTime.Now.DayOfYear "+DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            // DateTime Format

            //int karşılığı gelir  ayın günü
            Console.WriteLine(DateTime.Now.ToString("dd"));
            //string karşılığı gelir 3 karakter olarak 
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            //Olduğı gibi getirir
            Console.WriteLine(DateTime.Now.ToString("dddd"));

            //09
            Console.WriteLine(DateTime.Now.ToString("MM"));
            //Ayı üç karakterli getirir
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            //Ayı olduğu gibi getirir
            Console.WriteLine(DateTime.Now.ToString("MMMM"));

            //22
            Console.WriteLine(DateTime.Now.ToString("yy"));
            //2022
            Console.WriteLine(DateTime.Now.ToString("yyyy"));


            //Math Kütüphanesi

            //MUTLAK DEGER
            Console.WriteLine(Math.Abs(-2));
            //Sinus alma işlemi
            Console.WriteLine(Math.Sin(10));
            //Cos alma
            Console.WriteLine(Math.Cos(10));
            //Tan alma
            Console.WriteLine(Math.Tan(10));

            //DOUBLE VE FLOAT GİBİ DEGİSKENLER İÇİN
            //22.3büyük en küçük tam sayı gelir
            Console.WriteLine(Math.Ceiling(22.3));
            //22.3 hangi tam sayıya yakınsa
            Console.WriteLine(Math.Round(22.3));
            Console.WriteLine(Math.Round(22.7)); 
            //22.7 den küçük en büyük tam sayı
            Console.WriteLine(Math.Floor(22.7));

            //KÜÇÜK-BÜYÜK
            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6));

            //üs alma
            Console.WriteLine(Math.Pow(3,4));

            //karekok alma
            Console.WriteLine(Math.Sqrt(9));
            
            //Logaritma
            Console.WriteLine(Math.Log(9));

            //e üzeri 3'ü verir
            Console.WriteLine(Math.Exp(4));

            

        }
    }
}