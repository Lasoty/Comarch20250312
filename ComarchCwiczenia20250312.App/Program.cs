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
                Console.Write("Podaj X: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Podaj Y: ");
                int y = int.Parse(Console.ReadLine());


                switch (wybor)
                {
                    case 1:
                        Console.WriteLine($"Wynik dodawania {x} oraz {y} to {kalkulator.Add(x, y)}.");
                        //Console.WriteLine("Wynik dodawania " + x + " oraz " + y + " to " + x + y + ".");
                        //Console.WriteLine("Wynik dodawania {0} oraz {1} to {2}.", x, y, x + y);
                        //Console.WriteLine(string.Format("Wynik dodawania {0} oraz {1} to {2}.", x, y, x + y));
                        break;
                    case 2:
                        Console.WriteLine($"Wynik odejmowania {x} oraz {y} to {kalkulator.Subtract(x, y)}.");
                        break;
                    case 3:
                        Console.WriteLine($"Wynik mnożenie {x} oraz {y} to {kalkulator.Multiply(x, y)}.");
                        break;
                    case 4:
                        Console.WriteLine($"Wynik dzielenie {x} oraz {y} to {kalkulator.Divide(x, y)}.");
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

        private static void ShowMenu()
        {
            Console.WriteLine("KALKULATOR 1.0");
            Console.WriteLine(" 1. Dodawanie");
            Console.WriteLine(" 2. Odejmowanie");
            Console.WriteLine(" 3. Mnożenie");
            Console.WriteLine(" 4. Dzielenie");
        }

        private static void ShowError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
