using System;
using System.Collections.Generic;
using System.IO;

namespace lab_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Файлы папки Media: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            
            string[] files = Directory.GetFiles("Media");
            PlayerItem[] Files = new PlayerItem[files.Length];

            for (int i=0;i<files.Length;i++)
            {
                Console.WriteLine($"{i}. {files[i]}");
                Files[i] = new PlayerItem(files[i]);
                string player = Files[i].FileExtansion();
                switch (player)
                {
                    case "wav":
                        Files[i].playrecorder = new wav();
                        Files[i].posibilities = "1 - Записать, 2 - Воспроизвести, 3 - Пауза, 4 - Остановить";
                        break;
                    case "mkv":
                        Files[i].player = new mkv();
                        Files[i].posibilities = "1 - Воспроизвести, 2 - Пауза, 3 - Остановить";
                        break;
                    case "mp3":
                        Files[i].recorder = new mp3();
                        Files[i].posibilities = "1 - Записать, 2 - Пауза, 3 - Остановить";
                        break;
                    default:
                        break;
                }
            }
            int fileNumber;
            int actionNumber;
            do
            {
                Console.Write("\nВведите номер файла для просмотра возможностей (-1 для выхода): ");
                fileNumber = int.Parse(Console.ReadLine());
                if (fileNumber == -1) { Console.WriteLine("Выключаюсь..."); }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(Files[fileNumber].posibilities);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Введите номер действия (-1 для выхода): ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        actionNumber = int.Parse(Console.ReadLine());
                        switch (Files[fileNumber].FileExtansion())
                        {
                            case "wav": 
                                switch(actionNumber)
                                {
                                    case 1: 
                                        Files[fileNumber].playrecorder.Record();
                                        break;
                                    case 2:
                                        Files[fileNumber].playrecorder.Play(Files[fileNumber].path);
                                        break;
                                    case 3:
                                        Files[fileNumber].playrecorder.Pause();
                                        break;
                                    case 4: 
                                        Files[fileNumber].playrecorder.Stop();
                                        break;
                                    case -1:
                                        Console.WriteLine("Выхожу...");
                                        break;
                                    default:
                                        Console.WriteLine("Неизвестная операция");
                                        break;
                                }
                                break;
                            case "mp3":
                                switch (actionNumber)
                                {
                                    case 1:
                                        Files[fileNumber].recorder.Record();
                                        break;
                                    case 2:
                                        Files[fileNumber].recorder.Pause();
                                        break;
                                    case 3:
                                        Files[fileNumber].recorder.Stop();
                                        break;
                                    case -1:
                                        Console.WriteLine("Выхожу...");
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case "mkv":
                                switch (actionNumber)
                                {
                                    case 1:
                                        Files[fileNumber].player.Play(Files[fileNumber].path);
                                        break;
                                    case 2:
                                        Files[fileNumber].player.Pause();
                                        break;
                                    case 3:
                                        Files[fileNumber].player.Stop();
                                        break;
                                    case -1:
                                        Console.WriteLine("Выхожу...");
                                        break;
                                    default:
                                        Console.WriteLine("Неизвестная операция");
                                        break;
                                }
                                break;
                            default:
                                Console.WriteLine("Неизвестная операция");
                                break;
                        }
                    }
                    while (actionNumber != -1);
                }
            }
            while (fileNumber != -1);
        }
    }
}
