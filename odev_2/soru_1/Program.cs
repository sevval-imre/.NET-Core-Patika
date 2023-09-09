internal class Program
{
    private static void Main(string[] args)
    {
        int sayi = 20;
        List<int> asal = new List<int> { };
        List<int> asalOlmayan = new List<int> { };
        List<int> list = new List<int> { };

        try
        {
            Console.WriteLine("Sayı Giriniz: ");
            for (int i = 0; i < sayi; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number < 0)
                {
                    Console.WriteLine("Lütfen Pozitif bir sayı giriniz: ");
                    number = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    list.Add(number);
                }
            }
        }
        catch(Exception){
            Console.WriteLine("Hatalı Giriş!!!");
        }

        foreach (var item in list)
       {
           int n = 0;
           for (int i = 2; i < item; i++)
           {
       
               if (item % i == 0)
               {
                   n++;
               }
               else
               {
                   continue;
               }
           }
           if (n == 0)
           {
               asal.Add(item);
           }
           else
           {
               asalOlmayan.Add(item);
           }
        }

    

        asal.Sort();
        asal.Reverse();
        Console.Write("Asal sayılar : ");
        for(int j =0; j<asal.Count; j++){
            Console.Write(asal[j] + " ");
        }
        asalOlmayan.Sort();
        asal.Reverse();
        Console.Write("Asal olmayan sayılar : ");
        for(int m=0; m<asalOlmayan.Count; m++){
            Console.Write(asalOlmayan[m] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Listedeki asal sayıların sayısı = " + asal.Count);
        Console.WriteLine("Listedeki asal olmayan sayıların sayısı = " + asalOlmayan.Count);

        int totalAsal=0;
        for(int v = 0; v<asal.Count; v++){
            totalAsal += asal[v];
        }

        int totalAsalOlmayan = 0;
        for(int t=0; t<asalOlmayan.Count; t++){
            totalAsalOlmayan += asalOlmayan[t];
        }

        Console.WriteLine("Asal sayıların ortalaması = " + (totalAsal/asal.Count));
        Console.WriteLine("Asal olmayan sayıların ortalaması = " + (totalAsalOlmayan/asalOlmayan.Count));
        Console.ReadKey();
    }
}