using System;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // While
            // 1 den başlayarak konsoldan girilen sayıya kadar sayı dahil ortalama hesaplayıp konsola yazdıran program

            Console.Write ("Bir sayı giriniz");
            int number = int.Parse (Console.ReadLine ());
            int counter = 1;
            int summary = 0;
            while (counter <= number) {
                summary += counter;
                counter++;
            }

            Console.WriteLine (summary / number);

            //a dan z ye kadar tüm harfleri yazdıralım.
            char character = 'a';

            while (character <= 'z') {
                Console.Write (character);
                character++;
            }

            //ForEach
            string[] cars = { "BMW", "Audi", "Mercedes", "Bentley", "McLaren" };
            foreach (var car in cars) {
                Console.WriteLine (car);

            }
        }
    }
}
