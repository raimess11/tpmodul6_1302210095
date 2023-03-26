using tpmodul6_1302210095;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo meTube = new SayaTubeVideo("Tutorial Design By Contract - [RAHMA SAKTI R]");
        meTube.PrintVideoDetails();

        try { SayaTubeVideo meTube1 = new SayaTubeVideo(null); }
        catch { Console.WriteLine("judul lagu tidak boleh null"); }
        try { SayaTubeVideo meTube2 = new SayaTubeVideo(new string(new char[100] + "a")); }
        catch { Console.WriteLine("karakter maksimum pada judul adalah 100 karakter"); }
        try { meTube.IncreasePlayCount(3); }
        catch { Console.WriteLine("batas penambahan play count adalah 10.000.000"); }
        try { meTube.IncreasePlayCount(int.MaxValue); }
        catch { Console.WriteLine("batas penambahan play count adalah 10.000.000"); }
        meTube.PrintVideoDetails();
    }
}