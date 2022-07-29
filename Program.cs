using System;

namespace Metotlar
{
    class Program
    {
        public static void Main(string[] args)
        {
            // DateTime Metotları

            Console.WriteLine(DateTime.Now); // Günün tarihi anlık saat bilgisiyle beraber getirir.
            Console.WriteLine(DateTime.Now.Date); // Günün tarihini getirir.
            Console.WriteLine(DateTime.Now.Day); // Ayın kaçıncı günü olduğu bilgisini getirir. Değer olarak int döndürür.
            Console.WriteLine(DateTime.Now.Month); // Kaçıncı ayda olunduğunun bilgisini getirir. Değer olarak int döndürür.
            Console.WriteLine(DateTime.Now.Year); // Hangi yılda olunduğunun bilgisini getirir.
            Console.WriteLine(DateTime.Now.Hour); // Anlık saat bilgisini getirir.
            Console.WriteLine(DateTime.Now.Minute); // Anlık dakika bilgisini getirir.
            Console.WriteLine(DateTime.Now.Second); // Anlık saniye bilgisini getirir.

            Console.WriteLine(DateTime.Now.DayOfWeek); // Haftanın hangi gününde olunduğunun bilgisini yazılı olarak getirir.
            Console.WriteLine(DateTime.Now.DayOfYear); // Yılın kaçıncı gününde olunduğunun sayısal bilgisini getirir.

            Console.WriteLine(DateTime.Now.ToLongDateString()); // Tarih bilgisini uzun formatta getirir.
            Console.WriteLine(DateTime.Now.ToShortDateString()); // Tarih bilgisini kısa formatta getirir.

            Console.WriteLine(DateTime.Now.ToLongTimeString()); // Saat bilgisini saat ve dakika ile beraber saniye bilgisini de getirir.
            Console.WriteLine(DateTime.Now.ToShortTimeString()); // Saat bilgisini sadece saat ve dakika ile getirir.

            Console.WriteLine(DateTime.Now.AddDays(5)); // Mevcut güne 5 gün ekleyip saat ve tarih bilgisini getirir.
            Console.WriteLine(DateTime.Now.AddYears(2)); // Mevcut yıla 2 yıl ekleyip saat ve tarih bilgisini getirir.
            Console.WriteLine(DateTime.Now.AddMonths(3)); // Mevcut aya 3 ay ekleyip saat ve tarih bilgisini getirir.
            Console.WriteLine(DateTime.Now.AddHours(4)); // Mevcut saate 4 saat ekleyip saat ve tarih bilgisini getirir.
            Console.WriteLine(DateTime.Now.AddSeconds(30)); // Mevcut saniyeye 30 saniye ekleyip saat ve tarih bilgisini getirir.
            Console.WriteLine(DateTime.Now.AddMinutes(5)); // Mevcut dakikaya 5 dakika ekleyip saat ve tarih bilgisini getirir.

            // DateTime Formatları

            Console.WriteLine(DateTime.Now.ToString("dd")); // 29
            Console.WriteLine(DateTime.Now.ToString("ddd")); // Fri
            Console.WriteLine(DateTime.Now.ToString("dddd")); // Friday

            Console.WriteLine(DateTime.Now.ToString("MM")); // 07
            Console.WriteLine(DateTime.Now.ToString("MMM")); // Jul
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // July

            Console.WriteLine(DateTime.Now.ToString("yy")); // 22
            Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2022

            // Math Metotları

            Console.WriteLine(Math.Abs(-25)); // Sayının mutlak değerini döner.
            Console.WriteLine(Math.Sin(10));  // Sayının sin değerini getirir.
            Console.WriteLine(Math.Cos(10));  // Sayının cos değerini getirir.
            Console.WriteLine(Math.Tan(10));  // Sayının tan değerini getirir.

            Console.WriteLine(Math.Ceiling(25.3)); // Girilen sayıdan büyük en yakın tam sayının değerini verir.
            Console.WriteLine(Math.Round(25.3));  // Girilen sayıyı en yakın tam sayıya yuvarlar.
            Console.WriteLine(Math.Round(25.7)); // Girilen sayıyı en yakın tam sayıya yuvarlar.
            Console.WriteLine(Math.Floor(25.7)); // Girilen sayıyı kendisinden küçük en yakın tam sayıya yuvarlar.

            Console.WriteLine(Math.Min(2, 6)); // Girilen iki değerden küçük olanı döndürür.
            Console.WriteLine(Math.Max(2, 6)); // Girilen iki değerden büyük olanı döndürür.

            Console.WriteLine(Math.Pow(2, 5)); // Girilen ilk sayının ikinci sayı kadar karesi alınır. 2^5
            Console.WriteLine(Math.Sqrt(9)); // Girilen sayının karekökünü alır.
            Console.WriteLine(Math.Log(9)); // Girilen sayının e tabanına göre logaritması alınır.
            Console.WriteLine(Math.Exp(3)); // Girilen sayı kadar e sayının üssü alınır. e^3
            Console.WriteLine(Math.Log10(100)); // Girilen sayının 10 tabanına göre logaritması alınır.
        }
    }
}