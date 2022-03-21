// See https://aka.ms/new-console-template for more information

try
{// hata oluşabilecek kod satırları yazılır 
Console.WriteLine("Bir sayı giriniz:");
int sayi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Girdiğiniz sayi:"+sayi);

}
catch(Exception ex)
{// hatanın yakalandığı bölüm
    Console.WriteLine("Hata yakalandı:" + ex.Message.ToString());
}
finally
{// kodun hata alsın ya da almasın çalışmasını istediğimiz satırlar yazılır
//bü bölüm olmak zorunda değil
    System.Console.WriteLine("işlem tamamlandı");
}
 try
{
    //int a = int.Parse(null);
    //int a = int.Parse("test");
    int a = int.Parse("-200000000000");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Boş değer girdiniz.");
    Console.WriteLine(ex);
}
catch(FormatException ex)
{
    Console.WriteLine("Veri tipi uygun değil.");
    Console.WriteLine(ex);
}
catch (OverflowException ex)
{
Console.WriteLine("Çok küçük yada çok büyük bir değer girdiniz.");
Console.WriteLine(ex);
}
finally
{
Console.WriteLine("İşlem başarıyla tamamlandı.");
}