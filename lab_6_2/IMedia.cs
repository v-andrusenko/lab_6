using System;
using System.Collections.Generic;
using System.Text;

namespace lab_6_2
{
    interface IMedia : IPlayable, IRecordable
    {
        new void Pause();
        new void Stop();
    }
}
