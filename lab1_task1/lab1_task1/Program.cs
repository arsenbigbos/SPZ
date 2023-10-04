using System;
using System.IO;
using System.Net;

//Відкрийте VisualStudio і напишіть консольну програму (проект C#/Console Application), яка
//завантажує і зберігає в локальну файлову систему текстовий файл за повною URL-адресою
//https://mail.univ.net.ua/forum/forum.html, після чого створює його "полегшену" версію
//Forum - LIGHT.txt.В цій полегшеній версії будь-який рядок, що містить слово «youtu.be» \
//у будьякому регістрі на довільній позиції, замінюється рядком, переданим як аргумент командного
//рядка.

class Program
{
    static void Main(string[] args)
    {
        string url = "https://mail.univ.net.ua/forum/forum.html";
        string originalFileName = "forum.txt";
        string lightweightFileName = "Forum-LIGHT.txt";

        // Download the original file
        using (WebClient client = new WebClient())
        {
            client.DownloadFile(url, originalFileName);
        }

        // Check if an argument was provided
        if (args.Length > 0)
        {
            string wordToRemove = args[0].ToLower();

            // Read the original file and create the lightweight version
            using (StreamReader reader = new StreamReader(originalFileName))
            using (StreamWriter writer = new StreamWriter(lightweightFileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Check if the line contains the word to remove (case-insensitive)
                    if (!line.ToLower().Contains(wordToRemove))
                    {
                        // If it doesn't, write it to the lightweight file
                        writer.WriteLine(line);
                    }
                }
            }

            Console.WriteLine($"Lightweight file '{lightweightFileName}' created.");
        }
        else
        {
            Console.WriteLine("Usage: Program.exe <word_to_remove>");
        }
    }
}
