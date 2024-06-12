using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.TaskMedia
{
    public class MusicTrack: MediItem
    {
        public string Artist { get; set; }
        public string Title { get; set; }

        public MusicTrack(string artist, string title) 
        {
            Artist = artist;
            Title = title;
        }

        public override void Play()
        {
            Console.WriteLine($"Воспроизведение музыки: Исполнитель - {Artist}  Название - {Title}");
        }

        public override void Pause()
        {
            Console.WriteLine($"Музыка на паузе:  Исполнитель - {Artist}  Название - {Title}");
        }

        public override void Stop()
        {
            Console.WriteLine($"Музыка остановлена:  Исполнитель - {Artist}  Название - {Title}");
        }
    }
}
