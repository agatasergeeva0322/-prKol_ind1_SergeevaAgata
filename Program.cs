using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace console_z1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string volwes = "АУОИЭЫЯЮЕЁауоиэыяюеё";
            if (File.Exists("con_z1_2.txt"))
            {
                Console.WriteLine("Задание 1.2");
                Stack<char> letters = new Stack<char>();
                string f_text = File.ReadAllText("con_z1_2.txt");
                if (!string.IsNullOrEmpty(f_text))
                {
                    foreach (char letter in f_text)
                    {
                        if (volwes.Contains(letter))
                        {
                            letters.Push(letter);
                        }
                    }
                    foreach (char a in letters)
                    {
                        Console.Write($"{a}   ");
                    }
                }
                else Console.WriteLine("Файл 'con_z1_2' пустой! Заполните его пожалуйста и возвращайтесь!");
            }
            else Console.WriteLine("Файла 'con_z1_2' не существует");

            if (File.Exists("con_z2_3.txt"))
            {
                Console.WriteLine("\nЗадание 2.3");
                Queue<string> words_v = new Queue<string>();
                Queue<string> words_c = new Queue<string>();
                string f2_text = File.ReadAllText("con_z2_3.txt");
                if (!string.IsNullOrEmpty(f2_text))
                {
                    string[] words = f2_text.Split(new char[] { ' ', ',', '.', '!', '?', ':', ';', '@', '-' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string word in words)
                    {
                        if (volwes.Contains(word[0])) words_v.Enqueue(word);
                        else words_c.Enqueue(word);
                    }
                    Console.Write("Слова, начинающиеся на гласную букву: ");
                    while (words_v.Count > 0)
                    {
                        Console.Write($"{words_v.Dequeue()} ");
                    }
                    Console.Write("\nНа согласную: ");
                    while (words_c.Count > 0)
                    {
                        Console.Write($"{words_c.Dequeue()} ");
                    }
                }
                else Console.WriteLine("Файл 'con_z2_3' пустой! Заполните его пожалуйста и возвращайтесь!");
            }
            else Console.WriteLine("Файла 'con_z2_3' не существует");

            Console.ReadKey();
        }
    }
}
