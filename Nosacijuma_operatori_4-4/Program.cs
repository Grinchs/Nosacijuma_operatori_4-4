using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1 - Kvadrāta perimetrs");
        Console.WriteLine("2 - Kvadrāta laukums");
        Console.WriteLine("3 - Kvadrāta diagonāle");

        double a;

        Console.WriteLine("Ievadiet kvadrāta malu a:");
        if (double.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Izvēlieties darbību:");
          
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        double perimetrs = 4 * a;
                        Console.WriteLine("Kvadrāta perimetrs: " + perimetrs);
                        break;
                    case 2:
                        double laukums = a * a;
                        Console.WriteLine("Kvadrāta laukums: " + laukums);
                        break;
                    case 3:
                        double diagonale = Math.Sqrt(2) * a;
                        Console.WriteLine("Kvadrāta diagonāle: " + Math.Round(diagonale,3));
                        break;
                    default:
                        Console.WriteLine("Tādas darbības nav!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Tādas darbības nav!");
            }
        }
        else
        {
            Console.WriteLine("Ievadi skaitli kvadrāta malas garumam!");
        }
    }
}
