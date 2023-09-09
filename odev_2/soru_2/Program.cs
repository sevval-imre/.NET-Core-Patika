internal class Program
{
    private static void Main(string[] args)
    {
        int[] sayilar = new int[20];
        int[] enBuyuk = new int[3];
        int[] enKucuk = new int[3];

        Console.WriteLine("Sayıları Giriniz: ");
        for(int i =0; i< sayilar.Length; i++){
            int n= Convert.ToInt32(Console.ReadLine());
            sayilar[i] = n;
        }

        int totalEk=0, totalEb=0;
        Array.Sort(sayilar);
        for(int j=0;j<3; j++){
            enKucuk[j] = sayilar[j];
            totalEk += enKucuk[j];
        }

        Array.Reverse(sayilar);
        for(int k=0; k<3; k++){
            enBuyuk[k] = sayilar[k];
            totalEb += enBuyuk[k];
        }

        int ortalamaEk = totalEk/enKucuk.Length;
         Console.WriteLine("En küçük 3 sayı : " + enKucuk[0] + ", " + enKucuk[1] + ", " + enKucuk[2] + "\n Sayıların toplamları = " + totalEk 
         + "\n ortalamları = " + ortalamaEk);
         Console.WriteLine();
        int ortalamaEb = totalEb/enBuyuk.Length;
         Console.WriteLine("En büyük 3 sayı : " + enBuyuk[0] + ", " + enBuyuk[1] + ", " + enBuyuk[2] + "\n Sayıların toplamları = " + totalEb 
         + "\n ortalamları = " + ortalamaEb);
        Console.WriteLine();
        Console.WriteLine("Ortalama toplamları = " + (ortalamaEk + ortalamaEb));
        Console.ReadKey();
    }
}