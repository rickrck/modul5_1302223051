public class Program
{
    public static void Main(string[] args)
    {
        Penjumlahan<float> jumlah = new Penjumlahan<float>();

        jumlah.Jumlah<float>(22, 30, 51);

    }

}

public class Penjumlahan<T>
{

    public void Jumlah<T>(T angka1, T angka2, T angka3)
    {
        dynamic jumlah1 = angka1;
        dynamic jumlah2 = angka2;
        dynamic jumlah3 = angka3;

        dynamic total = jumlah1 + jumlah2 + jumlah3;

        Console.WriteLine(total);
    }
}