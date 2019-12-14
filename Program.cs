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



            }
            while (x != 8);

        }
    }
}
