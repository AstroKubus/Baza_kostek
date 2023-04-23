using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Baza_kostek
{
    partial class Program
    {
        static void Powitanie()
        {
            Console.WriteLine("Ten program umożliwia zarządzanie bazą kostek");
            Console.WriteLine("Wybież odpowiedną opcję:");
            Console.WriteLine("1 - Dodanie nowej kostki do bazy ");
            Console.WriteLine("2 - Usunięcie kostki z bazy ");
            Console.WriteLine("3 - Załadowanie kostki do bazy danych ");
            Console.WriteLine("4 - Pobranie kostek z bazy danych ");
            Console.WriteLine("5 - Wyświetlenie listy wszystkich kostek w bazie danych ");
            Console.WriteLine("6 - Dodawanie nowych wyników czasowych do kostek");
            Console.WriteLine("7 - zakończenie działania programu ");
        }


        static void Main(string[] args)
        {
            Powitanie();

            List<Kostki> wszystkieKostki = new List<Kostki>();
            wszystkieKostki.Add(new Kostki("LOL", "m d s"));
            wszystkieKostki.Add(new Kostki("LOL1", "m d s"));
            wszystkieKostki.Add(new Kostki("LOL2", "m d s"));

            while (true)
            {
                Console.Write("\n Wpisz numer operacji >>> ");
                string? odp = Console.ReadLine().Trim();
                switch (odp)
                {
                    // wczytywanie danych nowej kostki
                    case "1":
                        {
                            inputData(wszystkieKostki);
                            break;
                        }

                    //  usunięcie kostki z bazy
                    case "2":
                        {
                            removeData(wszystkieKostki);
                            break;
                        }

                    //  wczytanie pliku z kostkami do bazy
                    case "3": break;
                    case "4": break;
                    case "5": break;
                    case "6": break;
                    case "7": break;
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Ta opcja nie zostałą jeszcze zaimplementowana - wybierz 1");
                            Console.WriteLine("Naciśniej Enter by kontynuować ...");
                            Console.ReadLine();
                            break;

                        }
                }
            }
        }
    }
}