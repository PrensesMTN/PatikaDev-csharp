// See https://aka.ms/new-console-template for more information
//dotnet new console --framework net5.0
for( int i = 0; i <=10 ; i++){
    Console.WriteLine($"{i}.Hello, World!");
}
/*for (;;){
    Console.WriteLine("merhaba");

}*/


//Ekrana girilen sayıya kadar olan tek sayıları ekrana yazdır.

Console.WriteLine ("Bir sayı giriniz.");
int sayac = int.Parse (Console.ReadLine ());

for (int i = 1; i <= sayac; i++) {

    if (i % 2 == 1) {
        Console.WriteLine (i);
    }
}
//1 ile 1000 arasındaki tek ve çift sayıların toplamını ekrana yazdır.
int oddSum = 0;
int evenSum = 0;
for (var i = 1; i <= 1000; i++) {
    if (i % 2 == 1) {
        oddSum += i;
        } else {
            evenSum += i;
            }
}

Console.WriteLine ("Tek Toplam: " + oddSum);
Console.WriteLine ("Çift Toplam: " + evenSum);

//break, continue
for (int i = 1; i <= 10; i++) {
    if (i == 4)
        break;
    Console.WriteLine (i);
}

for (int i = 1; i <= 10; i++) {
    if (i == 4)
    continue;
    Console.WriteLine (i);
}