using System;
namespace gruppuppgift
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random tal = new Random();
            string senasteVinnaren = "";
            string menyVal = "0";
            while (menyVal != "4")
            {
                // Skriv ut menyval
                Console.WriteLine("Välkommen till gissa talet!");
                Console.WriteLine("1. Starta spelet");
                Console.WriteLine("2. Visa senaste vinnaren");
                Console.WriteLine("3. Spelets regler");
                Console.WriteLine("4. Avsluta spelet");
                menyVal = Console.ReadLine();

                switch (menyVal)
                {
                    case "1": // Användaren spelar spelet
                        Console.Write("Gissa ett tal mellan 1-10: ");
                        int num = int.Parse(Console.ReadLine());
                        int minVärde = 1;
                        int maxVärde = 10;
                        int rättTal = tal.Next(minVärde, maxVärde);

                        if (num == rättTal) // Användaren gissar rätt
                        {
                            Console.WriteLine("Du gissade rätt!");
                            Console.WriteLine("Skriv in ditt namn: ");
                            senasteVinnaren = Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Tyvärr, du gissade fel!");
                        }
                        break;
                       

                    case "2":
                        Console.WriteLine($"Den senaste vinnaren är: {senasteVinnaren}");
                        break;

                    case "3":
                        Console.WriteLine("Du gissar ett tal tills du gissat rätt!");
                        break;

                    case "4":
                        break;

                    default:
                        Console.WriteLine("Du gjorde inte ett giltigt val.");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}

