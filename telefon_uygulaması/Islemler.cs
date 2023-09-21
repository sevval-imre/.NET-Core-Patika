public class Islemler{
    List<Person> Kisiler = new List<Person>();

    public Islemler(){
        Kisiler.Add(new Person("Şevval","İmre","05442223311"));
        Kisiler.Add(new Person("Zeynep","Yılmaz","05558773625"));
        Kisiler.Add(new Person("Deniz","Gökay","0542553744"));
        Kisiler.Add(new Person("Meryem","Poşul","05054526637"));
        Kisiler.Add(new Person("Mehmet","İmre","05377407211"));
    }

    public void Ekle(){
        Console.WriteLine("Lütfen isim giriniz : ");
        string ad = Console.ReadLine().ToLower();

        Console.WriteLine("Lütfen soyisim giriniz : ");
        string soyad = Console.ReadLine().ToLower();

        Console.WriteLine("Lütfen numara giriniz : ");
        string numara = Console.ReadLine();

        Person yeniKisi = new Person(ad, soyad,numara);
        Kisiler.Add(yeniKisi);
        Console.WriteLine(ad+ " " + soyad + " isimli kişi rehbere eklenmiştir.");
  
    }

    public void Sil(){
        Console.Write("Lütfen silmek istediğiniz kişinin adını veya soyadını giriniz : ");
        string silinecekAd = Console.ReadLine();
        bool kontrol = false;

        while(!kontrol){
            foreach (Person person in Kisiler)
            {
                if (person.Ad.ToLower() == silinecekAd)
                {
                    Console.Write(person.Ad + " isimli kişiyi silmek istedğinizden emin misiniz ? (y/N)");
                    char cevap = char.Parse(Console.ReadLine());
                    if (cevap == 'y')
                    {
                        Kisiler.Remove(person);
                        Console.WriteLine(person.Ad + " kişisi silindi");
                        kontrol = true;
                        break;
                    }
                    else{
                        kontrol = true;
                    }
                }

                else if (person.Soyad.ToLower() == silinecekAd)
                {
                    Console.Write(person.Soyad + " isimli kişiyi silmek istedğinizden emin misiniz ? (y/N)");
                    char cevap = char.Parse(Console.ReadLine());
                    if (cevap == 'y')
                    {
                        Kisiler.Remove(person);
                        Console.WriteLine(person.Soyad + " kişisi silindi");
                        kontrol = true;
                        break;
                    }
                    else{
                        kontrol = true;
                    }
                }
            }
            if (!kontrol)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("Yeniden denemek için      : (2)");
                int girdi = int.Parse(Console.ReadLine());

                if (girdi ==1)
                {
                    kontrol = true;
                }
                else if(girdi ==2){
                    kontrol=false;
                    Console.WriteLine("Silmek istediğiniz kişinin adını veya soyadını giriniz : ");
                    silinecekAd = Console.ReadLine().ToLower();
                }
            }
        }
    }

    public void Guncelle(){
        Console.WriteLine("Lütfen güncellenecek numaraya ait kişinin adını veya soyadını giriniz : ");
        string guncellenecekAd = Console.ReadLine();
        bool kontrol = false;

        while(!kontrol){
            foreach (Person person in Kisiler)
            {
                if (person.Ad.ToLower() == guncellenecekAd)
                {
                    Console.Write("Mevcut numaranızı giriniz " + person.Ad + " : ");
                    string number = Console.ReadLine();
                    person.Numara = number;
                    kontrol = true;
                    break;
                }
                else if (person.Soyad.ToLower() == guncellenecekAd)
                {
                    Console.Write("Mevcut numaranızı giriniz " + person.Soyad + " : ");
                    string number = Console.ReadLine();
                    person.Numara = number;
                    kontrol = true;
                    break;
                }
            }

            if (!kontrol)
            {
                 Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("Yeniden denemek için      : (2)");
                int girdi = int.Parse(Console.ReadLine());

                if (girdi ==1)
                {
                    kontrol = true;
                }
                else if(girdi ==2){
                    kontrol=false;
                    Console.WriteLine("Silmek istediğiniz kişinin adını veya soyadını giriniz : ");
                    guncellenecekAd = Console.ReadLine().ToLower();
                }
            }
        }
    }

    public void Listele(){
        foreach (Person person in Kisiler)
        {
            Console.WriteLine("Ad : " + person.Ad);
            Console.WriteLine("Soyad : " + person.Soyad);
            Console.WriteLine("Numara : " + person.Numara);
        }
    }

    public void Arama(){
         Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
         Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
         Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
         int girdi = int.Parse(Console.ReadLine());

         if (girdi == 1)
         {
            Console.WriteLine("Lütfen aramak istediğiniz kişinin adını veya soyadını giriniz : ");
            string aranacakAd = Console.ReadLine();
            foreach (Person person in Kisiler)
            {
                if (person.Ad.ToLower() == aranacakAd)
                {
                     Console.WriteLine("Ad : " + person.Ad);
                     Console.WriteLine("Soyad : " + person.Soyad);
                     Console.WriteLine("Numara : " + person.Numara);
                     break;
                }
                else if (person.Soyad.ToLower() == aranacakAd)
                {
                     Console.WriteLine("Ad : " + person.Ad);
                     Console.WriteLine("Soyad : " + person.Soyad);
                     Console.WriteLine("Numara : " + person.Numara);
                     break;
                }
            }
         }
         else if (girdi == 2)
         {
             Console.WriteLine("Lütfen aranacak numarayı giriniz : ");
            string aranacakNumara = Console.ReadLine();
            foreach (Person person in Kisiler)
            {
                if (person.Numara == aranacakNumara)
                {
                     Console.WriteLine("Ad : " + person.Ad);
                     Console.WriteLine("Soyad : " + person.Soyad);
                     Console.WriteLine("Numara : " + person.Numara);
                     break;
                }
           }
        }
    }
}