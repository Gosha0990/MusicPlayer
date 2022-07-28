using MusicPlayer.Infrastructure.MusicCommand.Base;
using System;
using System.Media;
using NAudio;
using System.Threading.Tasks;
using NAudio.Wave;

namespace MusicPlayer.Infrastructure.MusicCommand
{
    internal class MusicPlayerCommand : IMusicPlayer
    {
        public bool IsPlaying { get; set; }
        public bool IsPaused { get; set; }

        private string _path;
        public MusicPlayerCommand(string path)
        {
            _path = path;
        }
        public void NextMusic()
        {
            
        }

        public void PauseMusic()
        {
            
        }

        
        public void PlayMusic()
        {
            if (!string.IsNullOrEmpty(_path))
            {
                if (IsPlaying && !IsPaused)
                {
                    IWavePlayer waveOutDevice = new WaveOut();
                    AudioFileReader audioFileReader = new AudioFileReader(_path);

                    waveOutDevice.Init(audioFileReader);
                    waveOutDevice.Play();
                }
            }
        }

        public void PreviousMusic()
        {
        }
    }
}
