using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz ");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak﻿");
            Console.WriteLine("(0) Çıkış");
            Console.WriteLine("**********************");
            
            int islem = int.Parse(Console.ReadLine());
            Console.WriteLine("**********************");
            Islemler islemler = new Islemler();

            bool kontrol = true;
            while (kontrol)
            {
                switch (islem)
                {
                    case 1:
                        islemler.Ekle();
                        Console.WriteLine("------------------------------");
                        break;
                    
                    case 2:
                        islemler.Sil();
                        Console.WriteLine("------------------------------");
                        break;
                    
                    case 3:
                        islemler.Guncelle();
                        Console.WriteLine("------------------------------");
                        break;

                    case 4:
                        islemler.Listele();
                        Console.WriteLine("------------------------------");
                        break;

                    case 5:
                        islemler.Arama();
                        Console.WriteLine("------------------------------");
                        break;

                    case 0:
                        kontrol = false;
                        break;

                    default:
                        Console.WriteLine("Lütfen geçerli bir numara giriniz!");
                        break;
                }


                if (kontrol)
                {
                    Console.Write("Başka bir işlem yapmak için numara seçiniz: ");
                    islem = int.Parse(Console.ReadLine());
                    Console.WriteLine("**********************");
                }
            }

            Console.ReadKey();
        }
    }
}
