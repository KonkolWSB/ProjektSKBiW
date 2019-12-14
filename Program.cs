using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

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


                if (x == 1)
                {
                    WebClient webClient = new WebClient();
                    try
                    {
                        webClient.DownloadFile("https://s3.zylowski.net/public/input/5.txt", "@5.txt");
                    }
                    finally
                    {

                    }

                }
                if (x == 3)
                {
                    Console.Clear();
                    try
                    {
                        string text = System.IO.File.ReadAllText("@5.txt");
                        if (text != null)
                        {
                            if (text == null)
                            {
                                Console.WriteLine("Blad");
                                break;
                            }
                            int words = 0;
                            foreach (char znak in text)
                            {
                                string a = Convert.ToString(znak);
                                if (a == " ")
                                {
                                    words++;
                                }
                            }
                            Console.WriteLine("Ilosc slow: " + words);
                        }
                    }
                    finally
                    {

                    }
                    if (x == 8)
                    {
                        System.Environment.Exit(0);
                    }
                        
                }
            }
            while (x != 8);

        }
    }
}