//// See https://aka.ms/new-console-template for more information

Random rastgele = new Random();
int diziBoyutu = rastgele.Next(10, 21);
int[] sayilarDizisi = new int[diziBoyutu];
int sayi;

for (int i = 0; i < diziBoyutu; i++) 
{
    do
    {
        sayi = rastgele.Next(0, 101); // 0 ile 100 arasında rastgele bir sayı üretiyoruz.
    }
    while (Array.Exists(sayilarDizisi, element => element == sayi)); 
  //dizide aynı sayı varsa, döngüyü tekrar başa döndörüyoruz ve yeni bir sayı üretiyoruz                                                         .
// Array.Exists = dizideki her bir elemanın sayi ile eşit olup olmadığını kontrol ediyoruz.
 // Eğer dizide sayi ile aynı değere sahip bir eleman varsa ifade true döner.Eğer yoksa false döner.
 // wihle (Arry.Exists = koşul true ise (yani dizide aynı sayı varsa), döngü tekrar başa döner ve yeni bir rastgele sayı üretmeye devam eder.


    sayilarDizisi[i] = sayi; //rastgele sayıyı diziye ekliyoruz.
}

Console.WriteLine($"Dizi Boyutu: {diziBoyutu}");
Console.WriteLine("Dizi Elemanları: " + string.Join(", ", sayilarDizisi)); //dizideki tüm elemanları  ekrana yazdırıyoruz.

int enKucuk = sayilarDizisi[0];
int enBuyuk = sayilarDizisi[0];
for (int i = 1; i < sayilarDizisi.Length; i++)
{
    if (sayilarDizisi[i] < enKucuk)
    {
        enKucuk = sayilarDizisi[i];
    }                                                                              
     //Bulunan en küçük sayıdan (enKucuk) daha küçük olup olmadığını kontrol eder.
    // Eğer bu koşul doğruysa(yani sayilarDizisi[i], enKucuk'tan küçükse), enKucuk değeri güncellenir.


    if (sayilarDizisi[i] > enBuyuk)
    {
        enBuyuk = sayilarDizisi[i];
    }
    // iki if ifadesi dizinin her bir elemanı üzerinde dönerken en küçük ve en büyük değerleri bulmak için kullanılır.
}


Console.WriteLine($"En Küçük Sayı: {enKucuk}");
Console.WriteLine($"En Büyük Sayı: {enBuyuk}");
    
Console.ReadKey();