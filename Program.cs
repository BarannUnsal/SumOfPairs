Console.WriteLine("En az 2 adet sayı giriniz (boşluk bırakarak): ");
Console.WriteLine("*********************");
Console.WriteLine("Sayılar aynıyısa çarpılır, farklıysa toplanır!!");
string[] sayilar = Console.ReadLine().Split();

if (sayilar.Length > 0)
{
    int[] sayi = new int[2];
    List<int[]> list = new List<int[]>();
    for (int i = 0; i < sayilar.Length; i++)
    {
        if (sayilar[i] == " " || sayilar[i] == "  " || String.IsNullOrEmpty(sayilar[i]))
            continue;

        if (i % 2 == 0)
        {
            sayi = new int[2] { int.Parse(sayilar[i]), 0 };
            if (i == sayilar.Length - 1)
                list.Add(sayi);
        }
        else
        {
            sayi[1] = int.Parse(sayilar[i]);
            list.Add(sayi);
        }
    }
    foreach (var item in list)
    {
        if (item[0] == item[1])
        {
            Console.Write(item[0] * item[1]);
        }
        else
        {
            Console.Write((item[0] + item[1]) + " ");
        }
    }
}