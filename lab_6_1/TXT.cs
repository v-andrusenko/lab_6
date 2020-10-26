using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace lab_6_1
{
    class TXT : AbstractHandler
    {
        string path { get; set; }
        public TXT(string path)
        {
            this.path = path;
        }
        public override void OpenFile()
        {
            using (FileStream fstream = File.OpenRead(this.path))
            {
                
                byte[] array = new byte[fstream.Length];
                
                fstream.Read(array, 0, array.Length);
                
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine($"Текст из файла: \n{textFromFile}");
            }

        }
        public override void CreateFile()
        {
            using (FileStream fstream = File.Create(this.path))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Файл по заданному пути создан\n");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        public override void EditFile()
        {
            using (FileStream fstream = new FileStream(this.path, FileMode.Append))
            {
                
                Console.WriteLine("Введите текст, который нужно дописать:");
                string text = Console.ReadLine();
                byte[] array = System.Text.Encoding.Default.GetBytes(text);

                fstream.Write(array, 0, array.Length);
                

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Текст записан в файл\n");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            File.AppendAllText(this.path, "\n");
        }
    }
}
