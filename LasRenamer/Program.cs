using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LasRenamer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=== Переименование LAS-файлов ===");
            Console.WriteLine();

            Console.WriteLine("Введите путь к папке с LAS-файлами:");

            string folderPath = (Console.ReadLine() ?? "")
                .Trim()
                .Trim('"');

            if (Directory.Exists(folderPath))
            {
                FileInfo latestFile = LasFileFinder.FindLatest(folderPath);

                if (latestFile != null)
                {
                    Console.WriteLine($"Найден файл: {latestFile.Name}");
                }
                else
                {
                    Console.WriteLine("В папке нет LAS-файлов.");
                }
            }
            else
            {
                Console.WriteLine("Указанная папка не существует.");
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для выхода.");
            Console.ReadKey();
        }

    
    }
}
