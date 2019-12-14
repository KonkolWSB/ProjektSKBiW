using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        { int x;
            

            do
            {
                System.Console.WriteLine("1 - pobierz plik z internetu");
                System.Console.WriteLine("2 - zlicz liczbę liter z pliku");
                System.Console.WriteLine("3 - zlicz liczbę wyrazów z pliku");
                System.Console.WriteLine("4 - zlicz liczbe znaków interpunkcyjnych");
                System.Console.WriteLine("5 - zlicz liczbe zdan w pliku");
                System.Console.WriteLine("6 - wygeneruj raport o uzyciu liter");
                System.Console.WriteLine("7 - zapisz statystyku");
                System.Console.WriteLine("8 - wyjdz z programu");
                x = Convert.ToInt32(Console.ReadLine());

                if (x == 2)
                {
                    try
                    {
                        
                        string text = System.IO.File.ReadAllText(@"5.txt");
                        if (text != null)
                        {
                            if (text == null)
                            {
                                Console.WriteLine("Brak pliku ");
                                break;
                            }
                            int count = 0;
                            foreach (char y in text)
                            {
                                string n = Convert.ToString(y);
                                if (n != "," && n != "." && n != ";" && n != "'" && n != "?" && n != "!" && n != "-" && n != ":")
                                {
                                    count++;

                                }

                            }
                            Console.WriteLine("Ilość liter w pliku : " + count);
                        }

                    }


            }
            while (x != 8);

        }
    }
}
