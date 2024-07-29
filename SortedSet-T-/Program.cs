internal class Program
{
    private static void Main(string[] args)
    {
        //SortedSet

        //Tanımlama
        var list = new SortedSet<string>();

        //Ekleme
        if (list.Add("Mehmet"))
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

        Console.WriteLine();
        Console.WriteLine("=================================================");
        Console.WriteLine();
        Console.WriteLine("Rastgele sayı üretme:");
        Console.WriteLine();

        var sayilar = new List<int>(); //liste tanımllandı
        var r = new Random(); // rastgele sayı sınıfından eleman tanımlandı
        for (int i = 0; i < 100; i++)
        {
            sayilar.Add(r.Next(0, 26)); // rastgele bir sayı üretilir ve listeye eklenir
            Console.Write($"{sayilar[i],-3}"); // ekrana yazdırılır
        }
        Console.WriteLine();
        Console.WriteLine();

        //Listedeki benzersiz sayıları bulma
        var benzersizSayiListesi = new SortedSet<int>(sayilar);
        Console.WriteLine("Benzersiz sayılar listesi:");
        foreach (var sayi in benzersizSayiListesi)
        {
            Console.Write($"{sayi,-3}");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Benzersiz sayı adedi : " + benzersizSayiListesi.Count);

        Console.WriteLine();
        Console.WriteLine("=================================================");
        Console.WriteLine();

        Console.WriteLine("SortedSet Küme İşlemleri");

        //var A = new SortedSet<int>() { 1, 2, 3, 4 };
        var A = new SortedSet<int>(RasgeleSayiUret(50));
        //var B = new SortedSet<int>() { 1, 2, 5, 6 };
        var B = new SortedSet<int>(RasgeleSayiUret(50));

        Console.WriteLine("A kümesi :");
        foreach (var sayi in A)
        {
            Console.Write($"{sayi, 5}");
        }
        Console.WriteLine();

        Console.WriteLine("B kümesi :");
        foreach (var sayi in B)
        {
            Console.Write($"{sayi, 5}");
        }
        Console.WriteLine(  );
        Console.WriteLine(  );

        //Union
        A.UnionWith(B); // kümeler A kümesi üzerinde birleşir
        Console.WriteLine("A ve B kümesinin birleşimi:");
        foreach (var e in A)
        {
            Console.Write($"{e, 5}");
        }

        Console.WriteLine();
        Console.WriteLine("Eleman sayısı : " + A.Count);
        Console.WriteLine();


        //IntersectWith
        A.IntersectWith(B); // kümeler A kümesi üzerinde birleşir
        Console.WriteLine("A ve B kümesinin kesişimi:");
        foreach (var e in A)
        {
            Console.Write($"{e, 5}");
        }

        Console.WriteLine();
        Console.WriteLine("Eleman sayısı : " + A.Count);
        Console.WriteLine();




        //SymmetricExceptWith
        A.SymmetricExceptWith(B); // kümeler A kümesi üzerinde birleşir
        Console.WriteLine("A ve B kümesinin kesişim dışındaki elemanları:");
        foreach (var e in A)
        {
            Console.Write($"{e, 5}");
        }

        Console.WriteLine();
        Console.WriteLine("Eleman sayısı : " + A.Count);
        Console.WriteLine();



        //IntersectWith
        A.ExceptWith(B);
        Console.WriteLine("A ve B kümesinin ortak olmayan A kümesi elemanları:");
        foreach (var e in A)
        {
            Console.Write($"{e, 5}");
        }

        Console.WriteLine();
        Console.WriteLine("Eleman sayısı : " + A.Count);
        Console.WriteLine();


        //IntersectWith
        B.ExceptWith(A);
        Console.WriteLine("A ve B kümesinin ortak olmayan B kümesi elemanları:");
        foreach (var e in B)
        {
            Console.Write($"{e, 5}");
        }

        Console.WriteLine();
        Console.WriteLine("Eleman sayısı : " + B.Count);
        Console.WriteLine();
        Console.WriteLine();


        static List<int> RasgeleSayiUret(int n)
        {
            var list = new List<int>();
            var r = new Random();
            for (int i = 0; i < n; i++)
            {
                list.Add(r.Next(0, 100));
            }
            return list;
        }
    }
}