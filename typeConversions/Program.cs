using System;

namespace typeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Bir değişkenin kendinden daha yüksek kapasiteli bir değişkene atanmasıdır. 
            int p = 4; 
            Console.WriteLine(p);
            short s = 5;
            p = s; //implicit
            p = (int)s;
            //b = a;   //Explicit
            Console.WriteLine(s);
            Console.Write(p);

            //Implicit Conversion (Bilinçsiz Dönüşüm)
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h: " + h);

            float i = h;
            Console.WriteLine("i: " + i);

            string e = "prenses";
            char f = 'M';
            object obj = e + f + d;
            Console.WriteLine("obj:" + obj);

            //Explicit Conversion(Bilinçli Dönüşüm)

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t: " + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);

            //ToString Metodu
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: " + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz: " + zz);

            //System.Covert Sınıfı
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;
            Console.WriteLine("toplam: " + toplam);

            //Parse Metodu
            ParseMethod();
        }

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            Console.WriteLine("rakam1: " + rakam1);

            double1 = Double.Parse(metin2);
            Console.WriteLine("double1: " + double1);
        
        }
    }
}