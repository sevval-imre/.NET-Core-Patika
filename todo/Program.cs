public class Program{
    public static void Menu(){
        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
		Console.WriteLine("******************");
		Console.WriteLine(""
			+ "1- Board Listeleme \n"
			+ "2- Board'a Kart Ekleme \n"
			+ "3- Board'dan Kart Silme \n"
			+ "4- Kart Taşıma \n"
            + "0- Çıkış \n"
			);
		Console.WriteLine("******************");
    }

    static void Main(string[] args){
        Board board = new Board();
        Menu();
        int input;
        while ((!int.TryParse(Console.ReadLine(), out input)) || input < 0 || input > 4)
		{
			Menu();
		}
        bool kontrol = true;

        while(kontrol){
            switch (input)
               {
                   case 1:
                       board.Liste();
                       break;
                   case 2:
                       board.kartEkle();
                       break;
                   case 3:
                       board.kartSil();
                       break;
                   case 4:
                       board.kartTasima();
                       break;

                    case 0:
                       kontrol = false;
                       break;
                   default:
                       Console.WriteLine("Hatalı seçim yaptınız!");
	    		    break;
               }
                if (kontrol)
                {
                    Console.Write("Başka bir işlem yapmak için numara seçiniz: ");
                    input = int.Parse(Console.ReadLine());
                    Console.WriteLine("**********************");
                }
        }
   
        Console.ReadKey();
    }
}
