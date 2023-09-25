public class Board{
    public List<Uyeler> uyeList {get; set;}
    public List<Card> cards {get; set;}

    public Board(){
        uyeList = new List<Uyeler>(){
            new Uyeler(10,"Şevval İmre"),
            new Uyeler(20,"Zeynep Yılmaz"),
            new Uyeler(30,"Deniz Gökay"),
            new Uyeler(40,"Meryem Poşul"),
            new Uyeler(50,"Mehmet İmre"),
            new Uyeler(60,"Elif İmre"),
            new Uyeler(70,"Ali Elmacı"),
        };

        cards = new List<Card>(){
            new Card("Yazılım-1","Backend",Type.TODO, CardSize.XS,uyeList[0]),
            new Card("Yazılım-2","Frontend",Type.DONE, CardSize.M,uyeList[2])
        };
    }

    public void kartEkle(){
        bool kontrol = false;
		Console.WriteLine("*** KART EKLEME ***");
		Console.Write("Başlık Giriniz: ");
		string title = Console.ReadLine();
		Console.Write("İçerik Giriniz: ");
		string content = Console.ReadLine();
		Console.Write("Büyüklük Giriniz: ");
		int size = int.Parse(Console.ReadLine());
		Console.Write("Atama yapmak istediğiniz kişinin ID'sini giriniz: ");
		int id = int.Parse(Console.ReadLine());
        Uyeler uyeler = GetUyeler(id);

        while (!kontrol)
        {
            Console.Write("Tür Giriniz -> 1- ToDo 2- In Progress 3- Done	 : ");
			int secim = int.Parse(Console.ReadLine());
            if (secim==1)
            {
                Card card = new Card(title,content,(Type)secim,(CardSize)size,uyeler);
                cards.Add(card);
                kontrol=true;
            }
            else if (secim==2)
            {
                Card card = new Card(title,content,(Type)secim,(CardSize)size,uyeler);
                cards.Add(card);
                kontrol=true;
            }
            else if (secim==3)
            {
                Card card = new Card(title,content,(Type)secim,(CardSize)size,uyeler);
                cards.Add(card);
                kontrol=true;
            }
            else 
            { 
                Console.WriteLine("Hatalı Seçim Yaptınız"); 
            }
        }
    }

    public Uyeler GetUyeler(int id){
        return uyeList.Find(x => x.ID ==id);
    }

    public Card GetCard(string title){
        return cards.Find(x => x.Title ==title);
    }

    public void Liste(){
        Console.WriteLine("*** LİST ***");
		Console.WriteLine("TODO Line");
        ListCardByType(Type.TODO);
		Console.WriteLine("*******");
		Console.WriteLine("INPROGRESS Line");
		ListCardByType(Type.INPROGRESS);
		Console.WriteLine("*******");
		Console.WriteLine("DONE Line");
		ListCardByType(Type.DONE);
    }

    public void ListCardByType(Type type){
        int i = 1;
			foreach (var item in cards)
			{
				if (item.Type == type)
				{
					Console.WriteLine("Başlık: "+item.Title);
					Console.WriteLine("İçerik: "+item.Content);
					Console.WriteLine("Atanan Kişi: "+item.uyeler.uyeAd);
					Console.WriteLine("Size: "+item.cardSize);
					Console.WriteLine("-");
					i++;
				}
			}
    }

    public void kartSil(){
        Console.WriteLine("*** KART SİLME ***");
		Console.WriteLine("***********************");
		Console.Write("Silmek istediğiniz kartın başlığını giriniz: ");
        Card sil = GetCard(Console.ReadLine());
        if (sil !=null)
        {
            cards.Remove(sil);
            Console.WriteLine("Kart başarıyla silindi");
        }
        else 
		{ 
            Console.WriteLine("Kart Bulunamadı"); 
        }
    }

    public void kartTasima(){
        Console.WriteLine("*** KART TAŞIMA ***");
			Console.Write("Taşımak istediğiniz kartın başlığını yazınız: ");
			string title = Console.ReadLine();	
			Card tasi = GetCard(title);

            if (tasi !=null)
            {
                Console.WriteLine("Aradığınız kart bulundu");
				Console.WriteLine("Kart Bilgileri: " + 
                "Başlık: " + tasi.Title +
                "İçerik: " + tasi.Content + 
                "Atanan Kişi: " + tasi.uyeler.uyeAd +
                "Büyüklük: " + tasi.cardSize);
                Console.WriteLine("Taşımak istediğiniz Line'ı seçiniz: (1) TODO (2) INPROGRESS (3) DONE");
				int lineSecim = int.Parse(Console.ReadLine());
				if (lineSecim == 1)
				{
					tasi.Type = Type.TODO;
					Liste();
				}
				else if (lineSecim == 2)
				{
					tasi.Type = Type.INPROGRESS;
					Liste();
				}
				else if (lineSecim == 3)
				{
					tasi.Type = Type.DONE;
					Liste();
				}
			}
			else 
			{
				Console.WriteLine("Aradığınız kart bulunamadı\n" +
					"Lütfen bir seçim yapınız.\n" +
					"İşlemi sonlandırmak için : (1)\n" +
					"Yeniden denemek için     : (2)");
				int secim = int.Parse(Console.ReadLine());
				if (secim == 1)
				{
					
				}
				else if (secim == 2)
				{
					kartTasima();
				}
				else 
				{
					Console.WriteLine("Hatalı seçim yaptınız");
				}
			}  
    }
}