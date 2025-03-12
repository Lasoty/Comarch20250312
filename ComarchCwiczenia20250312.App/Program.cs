namespace ComarchCwiczenia20250312.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KALKULATOR 1.0");
            Console.WriteLine(" 1. Dodawanie");
            Console.WriteLine(" 2. Odejmowanie");
            Console.WriteLine(" 3. Mnożenie");
            Console.WriteLine(" 4. Dzielenie");

            Console.Write("Wybierz opcję: ");
            string sWybor = Console.ReadLine();
            int wybor;
            bool czyPoprawnyWybor = int.TryParse(sWybor, out wybor);

            if (czyPoprawnyWybor)
            {
                Console.Write("Podaj X: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Podaj Y: ");
                int y = int.Parse(Console.ReadLine());


                switch (wybor)
                {
                    case 1:
                        Console.WriteLine($"Wynik dodawania {x} oraz {y} to {x + y}.");
                        //Console.WriteLine("Wynik dodawania " + x + " oraz " + y + " to " + x + y + ".");
                        //Console.WriteLine("Wynik dodawania {0} oraz {1} to {2}.", x, y, x + y);
                        //Console.WriteLine(string.Format("Wynik dodawania {0} oraz {1} to {2}.", x, y, x + y));
                        break;
                    case 2:
                        Console.WriteLine($"Wynik odejmowania {x} oraz {y} to {x - y}.");
                        break;
                    case 3:
                        Console.WriteLine($"Wynik mnożenie {x} oraz {y} to {x * y}.");
                        break;
                    case 4:
                        Console.WriteLine($"Wynik dzielenie {x} oraz {y} to {x / y}.");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Podana wartość jest spoza zakresu menu");
                        Console.ResetColor();
                        break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Podana wartość jest nieprawidłowa");
                Console.ResetColor();
            }
         }
    }
}
