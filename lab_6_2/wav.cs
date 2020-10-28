using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Media;


namespace lab_6_2
{
    class wav : IMedia
    {
        public void Record()
        {
            Console.WriteLine("Записать");
        }
        public void Play(string path)
        {
            Console.WriteLine("Воспроизведение");
            SoundPlayer music = new SoundPlayer(path);
            music.Play();
            Console.ReadLine();
        }
        public void Pause()
        {
            Console.WriteLine("Пауза");
        }
        public void Stop()
        {
            Console.WriteLine("Остановить");
        }
    }
}
