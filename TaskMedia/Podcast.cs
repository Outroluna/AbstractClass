using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcasts.TaskMedia
{
    public class Podcast: MediItem
    {
        public string Creator { get; set; }
        public string Title { get; set; }

        public Podcast(string creator, string title)
        {
            Creator = creator;
            Title = title;
        }
        public override void Play()
        {
            Console.WriteLine($"Воспроизведение подкаста: Автор - {Creator}  Название - {Title}");
        }

        public override void Pause()
        {
            Console.WriteLine($"Подкаст на паузе: Автор - {Creator}  Название - {Title}");
        }

        public override void Stop()
        {
            Console.WriteLine($"Подкаст остановлен: Автор - {Creator}  Название - {Title}");
        }
    }
}
