using System;

namespace operatörler // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //atama ve işlemli atama
            int x = 3;
            int y = 3;
            y = y+2;
            Console.WriteLine(y);
            y +=2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *=2;
            Console.WriteLine(x);
            
            //mantıksal operatörler
            // ||, &&,!

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted){
                Console.WriteLine("önermeler doğru değil");
            }

            else if(isSuccess || isCompleted){
                Console.WriteLine("iki önermeden biri doğru");
            }
            else if(isSuccess && !isCompleted){
                Console.WriteLine("iki önerme de doğru");
            }

            //karşılaştırma operatörleri
            // <,>,>=,<=,==,!=

            int a = 3;
            int b = 4;

            bool sonuc = a<b;
            Console.WriteLine(sonuc);

            sonuc = a==b;
            Console.WriteLine(sonuc);

            sonuc = a<=b;
            Console.WriteLine(sonuc);

            sonuc = a<=b;
            Console.WriteLine(sonuc);

            sonuc = a!=b;
            Console.WriteLine(sonuc);

            // artimetiksel operatörler
            //*,/,-,+,++,--,

            int s1 = 30;
            int s2 =5;

            Console.WriteLine(s1*s2);
            Console.WriteLine(s1+s2);
            Console.WriteLine(s1/s2);
            Console.WriteLine(s1-s2);
            int i = s1++;
            Console.WriteLine(i);
            Console.WriteLine(s2++);
            //mod alma
            Console.WriteLine(30%3);







        }
    }
}