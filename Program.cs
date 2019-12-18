using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int punctuationmarks = 0;
            int sentences = 0;
            int characters = 0;
            int count = 0;
            int vowels = 0;
            int consonants = 0;
            int words = 0;
            do
            {
                System.Console.WriteLine("1 - pobierz plik z internetu");
                System.Console.WriteLine("2 - zlicz liczbę liter z pliku");
                System.Console.WriteLine("3 - zlicz liczbę wyrazów z pliku");
                System.Console.WriteLine("4 - zlicz liczbe znaków interpunkcyjnych");
                System.Console.WriteLine("5 - zlicz liczbe zdan w pliku");
                System.Console.WriteLine("6 - wygeneruj raport o uzyciu liter");
                System.Console.WriteLine("7 - zapisz statystyke");
                System.Console.WriteLine("8 - wyjdz z programu");
                x = Convert.ToInt32(Console.ReadLine());

                if (x == 1)
                {
                    WebClient webClient = new WebClient();
                    try
                    {
                        webClient.DownloadFile("https://s3.zylowski.net/public/input/5.txt", "5.txt");
                    }
                    finally { }
                }
                if (x == 2)
                {
                    Console.Clear();
                    try
                    {
                        string text = System.IO.File.ReadAllText("5.txt");
                        if (text != null)
                        {
                            if (text == null)
                            {
                                Console.WriteLine("Brak pliku ");
                                break;
                            }     
                            foreach (char znak in text)
                            {
                                if (char.IsLetter(znak) && (znak == 'a' || znak == 'e' || znak == 'i' || znak == 'o' || znak == 'u'))
                                {
                                    vowels++;
                                }
                                else
                                {
                                    consonants++;
                                }
                            }
                            Console.WriteLine("Samogloski = {0}\n" + "Spolgloski = {1}\n",vowels,consonants);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("error");
                    }
                }
                if (x == 3)
                {
                    Console.Clear();
                    try
                    {
                        string text = System.IO.File.ReadAllText("5.txt");
                        if (text != null)
                        {
                            if (text == null)
                            {
                                Console.WriteLine("Blad");
                                break;
                            }
                            string pattern = "[^\\w]";
                            string[] words = null;
                            int i = 0;
                            words = Regex.Split(text, pattern, RegexOptions.IgnoreCase);
                            for (i = words.GetLowerBound(0); i <= words.GetUpperBound(0); i++)
                            {
                                if (words[i].ToString() == string.Empty || words[i].Length <= 1)
                                    count = count - 1;
                                count = count + 1;
                            }
                            Console.WriteLine("Count of words longer than one char: " + count.ToString());
                        }
                    }
                    catch
                    {
                        Console.WriteLine("error");
                    }
                }
                if (x == 4)
                {
                    Console.Clear();
                    try
                    {
                        string text = System.IO.File.ReadAllText("5.txt");
                        if (text != null)
                        {
                            if (text == null)
                            {
                                Console.WriteLine("Brak pliku ");
                                break;
                            }
                            foreach (char znak in text)
                            {
                                string a = Convert.ToString(znak);

                                      if (a == "?" || a == ".")

                                if (char.IsLetter(znak) != true && a!= " ")
                                {
                                    punctuationmarks++;
                                }
                            }
                            Console.WriteLine("Ilość znakow interpunkcyjnych = " + punctuationmarks);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("error");
                    }
                }
                if (x == 5)
                {
                    Console.Clear();
                    try
                    {
                        string text = System.IO.File.ReadAllText("5.txt");
                        if (text != null)
                        {
                            if (text == null)
                            {
                                Console.WriteLine("Blad");
                                break;
                            }
                            foreach (char znak in text)
                            {
                                string a = Convert.ToString(znak);
                                if (a == ".")
                                {
                                    sentences++;
                                }
                            }
                            Console.WriteLine("Ilosc zdan: " + sentences);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("error");
                    }
                }
                if (x == 6)
                {
                    Console.Clear();
                    try
                    {
                        string text = System.IO.File.ReadAllText("5.txt");
                        if (text != null)
                        {
                            int[] character = new int[(int)char.MaxValue];
                            foreach (char tp in text)
                            {
                                character[(int)tp]++;
                            }
                            for (int i = 0; i < (int)char.MaxValue; i++)
                            {
                                if (character[i] > 0 && char.IsLetter((char)i))
                                {
                                    Console.WriteLine("{0}-{1}", (char)i, character[i]);
                                }
                            }
                        }

           }
                    catch
                    {
                        Console.WriteLine("error");
                    }
                }
                if (x == 7)
                {
                    string[] lines = { "Litery: " + characters.ToString(), "Count of words longer than one char: " + count.ToString(), "Znaki interpunkcyjne: " + punctuationmarks.ToString(), "Zdania: " + sentences.ToString() };

                 }
                 catch
                 {
                    Console.WriteLine("error");
                 }
              }
              if (x == 7)
              {
                    string[] lines = {"Słowa: " + words.ToString(), "Znaki interpunkcyjne: " + punctuationmarks.ToString(), "Zdania: " + sentences.ToString()};
                    System.IO.File.WriteAllLines("statystyki.txt", lines);
                }
                if (x == 8)
              {
                    System.IO.File.Delete("statystyki.txt");
                    System.IO.File.Delete("5.txt");
                    System.Environment.Exit(0);
              } 
            }
            while (x != 8);
        }
    }
}