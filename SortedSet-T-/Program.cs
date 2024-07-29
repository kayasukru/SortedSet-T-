internal class Program
{
    private static void Main(string[] args)
    {
        //SortedSet

        //Tanımlama
        var list = new SortedSet<string>();

        //Ekleme
        if(list.Add("Mehmet"))
        {
            Console.WriteLine("Mehmet eklendi");
        }
        else
        {
            Console.WriteLine("Mehmet ekleme başarısız");
        }

        //ekleme
        Console.WriteLine("{0}", list.Add("Ahmet") == true ? "Ahmet eklendi" : "Ekleme başarısız");

        // ekleme  başarısız olur. Mehmet daha önce eklenmiş
        if (list.Add("Mehmet"))
        {
            Console.WriteLine("Mehmet eklendi");
        }
        else
        {
            Console.WriteLine("Mehmet ekleme başarısız");
        }

        list.Add("Şule");
        list.Add("Betül");
        list.Add("Bilge");
        list.Add("Şükrü");
        list.Add("Ali");

        Console.WriteLine("----------------------");
        Console.WriteLine("İsimler listesi:");
        Console.WriteLine();

        foreach (var isim in list)
        {
            Console.WriteLine(isim);
        }

        Console.WriteLine("-----------------------------");
        Console.WriteLine("İsmin içinde ü geçenleri sil");

        list.RemoveWhere(deger => deger.Contains("ü"));

        Console.WriteLine();
        Console.WriteLine("Yeni İsimler listesi:");
        Console.WriteLine();

        foreach (var isim in list)
        {
            Console.WriteLine(isim);
        }


        Console.WriteLine("--------------------------------");
        Console.WriteLine("İsmin içinde A ile başlayanları sil");

        list.RemoveWhere(deger => deger.StartsWith("A"));

        Console.WriteLine();
        Console.WriteLine("Yeni İsimler listesi:");
        Console.WriteLine();

        foreach (var isim in list)
        {
            Console.WriteLine(isim);
        }
        Console.WriteLine();
        Console.WriteLine("Eleman sayısı : " + list.Count);


        Console.WriteLine("----------------------------");
        Console.WriteLine("Mehmet İsmini sil");

        list.Remove("Mehmet");

        Console.WriteLine();
        Console.WriteLine("Yeni İsimler listesi:");
        Console.WriteLine();

        foreach (var isim in list)
        {
            Console.WriteLine(isim);
        }
        Console.WriteLine();
        Console.WriteLine("Eleman sayısı : " + list.Count);


    }
}