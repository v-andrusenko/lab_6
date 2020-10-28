using System;
using System.Collections.Generic;
using System.Text;

namespace lab_6_2
{
    class mp3 : IRecordable
    {
        public void Record()
        {
            Console.WriteLine("Запись");
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
