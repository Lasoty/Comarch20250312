using ComarchCwiczenia20250312.App.Cwiczenia;

namespace ComarchCwiczenia20250312.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();

            Console.Write("Wybierz opcję: ");
            string sWybor = Console.ReadLine();
            int wybor;
            bool czyPoprawnyWybor = int.TryParse(sWybor, out wybor);

            Kalkulator kalkulator = new Kalkulator();

            if (czyPoprawnyWybor)
            {
                int x, y;

                switch (wybor)
                {
                    case 1:
                        GetXY(out x, out y);
                        Console.WriteLine($"Wynik dodawania {x} oraz {y} to {kalkulator.Add(x, y)}.");
                        //Console.WriteLine("Wynik dodawania " + x + " oraz " + y + " to " + x + y + ".");
                        //Console.WriteLine("Wynik dodawania {0} oraz {1} to {2}.", x, y, x + y);
                        //Console.WriteLine(string.Format("Wynik dodawania {0} oraz {1} to {2}.", x, y, x + y));
                        break;
                    case 2:
                        GetXY(out x, out y);
                        Console.WriteLine($"Wynik odejmowania {x} oraz {y} to {kalkulator.Subtract(x, y)}.");
                        break;
                    case 3:
                        GetXY(out x, out y);
                        Console.WriteLine($"Wynik mnożenie {x} oraz {y} to {kalkulator.Multiply(x, y)}.");
                        break;
                    case 4:
                        GetXY(out x, out y);
                        Console.WriteLine($"Wynik dzielenie {x} oraz {y} to {kalkulator.Divide(x, y)}.");
                        break;
                    case 5:
                        int[] tab = GetIntArray();
                        int[] reverseTab = kalkulator.Reverse(tab);
                        //foreach (int item in reverseTab)
                        //    Console.WriteLine(item);

                        Console.WriteLine($"[{string.Join(", ", reverseTab)}]");
                        break;
                    default:
                        ShowError("Podana wartość jest spoza zakresu menu");
                        break;
                }
            }
            else
            {
                ShowError("Podana wartość jest nieprawidłowa");
            }
        }

        private static int[] GetIntArray()
        {
            string? sLiczby = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(sLiczby))
            {
                ShowError("Nie możesz podać pustej tablicy!");
                return [];
            }

            string[] sWartosci = sLiczby.Split([' ', ',', ';'], StringSplitOptions.RemoveEmptyEntries);

            int[] wynik = new int[sWartosci.Length];

            for (int i = 0; i < wynik.Length; i++)
            {
                wynik[i] = int.Parse(sWartosci[i]);
            }

            var wynik2 = sWartosci.Select(x => int.Parse(x)).ToArray(); //LINQ

            return wynik;
        }

        private static void GetXY(out int x, out int y)
        {
            Console.Write("Podaj X: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Podaj Y: ");
            y = int.Parse(Console.ReadLine());
        }

        private static void ShowMenu()
        {
            Console.WriteLine("KALKULATOR 1.0");
            Console.WriteLine(" 1. Dodawanie");
            Console.WriteLine(" 2. Odejmowanie");
            Console.WriteLine(" 3. Mnożenie");
            Console.WriteLine(" 4. Dzielenie");
            Console.WriteLine(" 5. Odwróć tablicę");
        }

        private static void ShowError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
