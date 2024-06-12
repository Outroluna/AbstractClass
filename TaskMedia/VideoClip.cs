using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video.TaskMedia
{
    public class VideoClip: MediItem
    {
        
        public string Creator { get; set; }
        public string Title { get; set; }

        public VideoClip(string creator, string title)
        {
            Creator = creator;
            Title = title;
        }
        public override void Play()
        {
            Console.WriteLine($"Воспроизведение видео: Автор - {Creator}  Название - {Title}");
        }

        public override void Pause()
        {
            Console.WriteLine($"Видео на паузе: Автор - {Creator}  Название - {Title}");
        }

        public override void Stop()
        {
            Console.WriteLine($"Видео остановлено: Автор - {Creator}  Название - {Title}");
        }
    }
}
