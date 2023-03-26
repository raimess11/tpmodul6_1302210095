using tpmodul6_1302210095;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo meTube = new SayaTubeVideo("Tutorial Design By Contract - [RAHMA SAKTI R]");
        meTube.PrintVideoDetails();

        //SayaTubeVideo meTube1 = new SayaTubeVideo(null);
        SayaTubeVideo meTube2 = new SayaTubeVideo(new string(new char[100]));
        meTube.IncreasePlayCount(2);
        meTube.IncreasePlayCount(int.MaxValue);
        meTube.PrintVideoDetails();
    }
}