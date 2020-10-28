using System;
using System.Collections.Generic;
using System.Text;

namespace lab_6_2
{
    class mkv : IPlayable
    {
        public void Play(string path) 
        {
            Console.WriteLine("Воспроизведение");
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
