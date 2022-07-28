using MusicPlayer.Infrastructure.Commands;
using MusicPlayer.MVVM.ViewsModels.Base;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

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

        public ICommand CloseApplicationCommand { get; }
        private void OnCloseApplicationCommandExecute(object p)
        {
            Application.Current.Shutdown();
        }
        private bool CanCloseApplicationCommandExecute(object p)
        {
            return true;
        }



        public MainWindowViewModel()
        {
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecute, CanCloseApplicationCommandExecute);
            
        }

    }
}
