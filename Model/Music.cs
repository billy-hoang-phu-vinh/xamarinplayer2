using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.Model
{
    public class Music
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Url { get; set; }
        public string CoverImage { get; set; } = "https://raw.githubusercontent.com/billy-hoang-phu-vinh/xamarin-musicplayer/main/sourcefiles/900x520_piano-min.jpg";
        public bool IsRecent { get; set; }
    }
}
