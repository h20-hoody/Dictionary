using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> city = new MyDictionary<int, string>();

            city.Add(1,"Istanbul");
            city.Add(2, "Kocaeli");
            city.Add(3, "Eskisehir");
            city.Add(4,"Konya");
            city.Add(5, "Ankara");


            Console.WriteLine(city.Count());
            Console.WriteLine("****************************");
            Console.WriteLine(city.cityName);
            Console.WriteLine("****************************");
            Console.WriteLine(city.CityCodes);


        }
    }
}
