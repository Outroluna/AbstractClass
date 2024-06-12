using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media.TaskMedia
{
    public abstract class MediItem
    {
        public abstract void Play();
        public abstract void Pause();
        public abstract void Stop();
    }
}
