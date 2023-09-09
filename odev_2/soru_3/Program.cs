internal class Program
{
    private static void Main(string[] args)
    {
        char[] sesliHarfler = { 'a', 'e', 'u', 'ü', 'ı', 'i', 'o', 'ö' };
        Console.WriteLine("Cümle giriniz: ");
        string cumle = Console.ReadLine();
        List<char> list = new List<char>(){ };
        foreach(char karakter in cumle){
            foreach(char item in sesliHarfler){
                if(karakter == item){
                    list.Add(karakter);
                }
            }
        }
        foreach (var item in list)
        {
            Console.Write(item);
        } 
        Console.ReadKey();      
    }
}