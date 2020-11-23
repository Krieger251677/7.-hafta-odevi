using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Öğrencimisin?   (e/h)" );
            string yanıt = Console.ReadLine();
            if (yanıt=="e")
            {
                musteri ogrenci = new musteri();
                ogrenci.ad = "Hasan";
                ogrenci.soyad = "KAYA";
                ogrenci.ogr_no = 221903054;
                ogrenci.yas = 19;

                Console.WriteLine(ogrenci.ad);

            }
            else if (yanıt == "h")
            {
                musteri müsteri = new musteri();
                müsteri.ad = "Burak";
                müsteri.soyad = "YILDIRIM";
                müsteri.yas = 36;
                müsteri.meslek = "Yazılım Mühendisi";
                müsteri.maas = 5260;
            }
        }
    }
}
