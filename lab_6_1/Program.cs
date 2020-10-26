using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace lab_6_1
{
    class Program
    {
        static string FileExtansion(string path)
        {
            char[] temp = path.ToCharArray();
            Array.Reverse(temp);
            string extansion = "";
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == '.') break;
                else
                {
                    extansion = extansion.Insert(0, temp[i].ToString());
                }
            }
            return extansion;
        }
        static void Main(string[] args)
        {
            //string path = @"C:\Users\vandr\Desktop\text.doc";
            Console.Write("Выберите номер действия, которое Вам нужно:\n1. Создать файл\n2. Дописать текст в файл\n" +
                "3. Вывести содержимое файла\n4. Все предыдущие вместе\n-> ");
            int actionNumber;
            do
            {
                actionNumber = int.Parse(Console.ReadLine());
                if (actionNumber != 1 && actionNumber != 2 && actionNumber != 3 && actionNumber != 4)
                {
                    Console.Write("Пожалуйста, введите номер из списка\n-> ");
                }
                
            }
            while (actionNumber != 1 && actionNumber != 2 && actionNumber != 3 && actionNumber != 4);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Примечание: если вы ввели только название файла, то он сохранится в папке этого приложения");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("Введите путь к файлу: ");

            string path = Console.ReadLine();

            Console.WriteLine($"Расширение Вашего файла: {FileExtansion(path)}");
            switch (FileExtansion(path))
            {
                case "txt":
                     TXT newtxt = new TXT(path);
                     switch (actionNumber)
                     {
                         case 1: 
                            newtxt.CreateFile(); break;
                         case 2: 
                            newtxt.EditFile(); 
                            newtxt.OpenFile();
                            break;
                         case 3: 
                            newtxt.OpenFile(); break;
                         case 4:
                            newtxt.CreateFile();
                            newtxt.EditFile();
                            newtxt.OpenFile();
                            break;
                        default: break;
                     }
                     break;

                case "doc":
                    DOC newdoc = new DOC(path);
                    switch (actionNumber)
                    {
                        case 1:
                            newdoc.CreateFile(); break;
                        case 2:
                            newdoc.EditFile();
                            newdoc.OpenFile();
                            break;
                        case 3:
                            newdoc.OpenFile(); break;
                        case 4:
                            newdoc.CreateFile();
                            newdoc.EditFile();
                            newdoc.OpenFile();
                            break;
                        default: break;
                    }
                    break;

                case "dat":
                    DAT newdat = new DAT(path);
                    switch (actionNumber)
                    {
                        case 1:
                            newdat.CreateFile(); break;
                        case 2:
                            newdat.EditFile();
                            newdat.OpenFile();
                            break;
                        case 3:
                            newdat.OpenFile(); break;
                        case 4:
                            newdat.CreateFile();
                            newdat.EditFile();
                            newdat.OpenFile();
                            break;
                        default: break;
                    }
                    break;

                default: 
                    Console.WriteLine($"\nК сожалению, {FileExtansion(path)} не поддерживается"); 
                    break;
            }
        }
    }
}

