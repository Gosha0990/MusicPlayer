using MusicPlayer.MVVM.ViewsModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.MVVM.ViewsModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _NameTrack = "Music";

        #region Name of the music track

        /// <summary>
        /// Свойство имяни музыкального трека
        /// </summary>
        public string NameTrack 
        {
            get => _NameTrack;
            set
            {
                if(Equals(_NameTrack, value))
                    return;
                _NameTrack = value;
                OnPropertyChenged();
            }
        }
        #endregion



    }
}
