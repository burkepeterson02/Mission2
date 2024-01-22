using Mission2;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        
        input ip = new input();
        int amount = ip.GetCount();

        int[] results = new int[11];

        for (int i = 0; i < 11; i++)
        {
            results[i] = 0;
        }

        for (int i = 0; i < amount; i++) 
        {
            int answer = Program.getnum() + Program.getnum();

            if (answer == 2) { results[0]++; }
            if (answer == 3) { results[1]++; }
            if (answer == 4) { results[2]++; }
            if (answer == 5) { results[3]++; }
            if (answer == 6) { results[4]++; }
            if (answer == 7) { results[5]++; }
            if (answer == 8) { results[6]++; }
            if (answer == 9) { results[7]++; }
            if (answer == 10) { results[8]++; }
            if (answer == 11) { results[9]++; }
            if (answer == 12) { results[10]++; }

        }

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS\nEach \"*\" represents 1% of the total number of rolls.\r\n");
        Console.WriteLine("Total number of rolls = " + amount + ".\n");

        for (int i = 0; i < 11; i++)
        {
            int occ = results[i];
            double value = ((double)occ / amount * 100);
            int rounded = (int)Math.Round(value);

            string ast = "";
            for (int j = 0; j < rounded; j++)
            {
                ast += "*";
            }

            int num = i + 2;

            Console.WriteLine(num + ": " + ast);
        }
            
    }
    public static int getnum()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 7);

        return randomNumber;
    }
}
