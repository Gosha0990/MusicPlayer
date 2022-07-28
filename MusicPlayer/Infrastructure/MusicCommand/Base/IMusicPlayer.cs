using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Infrastructure.MusicCommand.Base
{
    internal interface IMusicPlayer
    {
        bool IsPlaying { get; set; }
        bool IsPaused { get; set; }

        void PlayMusic();
        void PauseMusic();
        void NextMusic();
        void PreviousMusic();
    }
}
