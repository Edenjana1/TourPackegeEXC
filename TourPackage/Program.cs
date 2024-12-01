// See https://aka.ms/new-console-template for more information
using Main;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        TourPackage[] packeges = new TourPackage[3];
        packeges[0] = new TourPackage(1, 20, 30, 15);
        packeges[1] = new TourPackage(2, 40, 60, 30);
        packeges[2] = new TourPackage(3, 60, 90, 45);

        Console.WriteLine("the amount of packeges with extra : "+ Calculate(packeges));
        Console.WriteLine("the users with extra : " + Costumers( packeges));



    }
    public static int Calculate(TourPackage[] packages)
    {
        int count = 0;
        for (int i = 0; i < packages.Length; i++)
        {
            if (packages[i].GetExtra() > 0) count++;
        }
        return count;
    }

    public static int[] Costumers(TourPackage[] packages)
    {
        int[] extraID = new int[Calculate(packages)];
        int i = 0;
        for (int k = 0; k < packages.Length; k++)
        {
            if ((packages[k].GetExtra() > 0)) extraID[i] = packages[k].GetExtra();
            i++;
            
        }
        return extraID;
    }
}