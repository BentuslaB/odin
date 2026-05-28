using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {       
                Console.WriteLine("Введите путь к текстовому файлу:");

              
                string filePath = Console.ReadLine();

                try
                {                   
                    string text = File.ReadAllText(filePath);
                    string[] words = text.ToLower().Split(new char[] { ' ', '\n', '\r', '\t', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                    HashSet<string> uniqueWords = new HashSet<string>(words);                  
                    List<string> sortedWords = new List<string>(uniqueWords);
                    sortedWords.Sort();

                 
                    Console.WriteLine("Слова в алфавитном порядке:");
                    foreach (string word in sortedWords)
                    {
                        Console.WriteLine(word);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine($"Произошла ошибка: ");
                }
            }
        }
    }
    

