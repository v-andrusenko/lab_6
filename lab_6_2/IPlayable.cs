using System;
using System.Collections.Generic;
using System.Text;

namespace lab_6_2
{
    interface IPlayable
    {
        void Play(string path);
        void Pause();
        void Stop();
    }
}
