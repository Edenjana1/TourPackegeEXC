// See https://aka.ms/new-console-template for more information
using Main;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

     // TourPackage[] packeges = new TourPackage[3];
    // packeges[0] = TourPackage(1, 20, 30, 15);


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