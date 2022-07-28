using MusicPlayer.Infrastructure.Commands;
using MusicPlayer.MVVM.Views;
using MusicPlayer.MVVM.ViewsModels.Base;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using MusicPlayer.MVVM.Views;
using MusicPlayer.Infrastructure.MusicCommand;
using NAudio.Wave;

namespace MusicPlayer.MVVM.ViewsModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _NameTrack = "Music";

        private MusicPlayerCommand _playerCommand { get; set; }

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

        #region Close command
        public ICommand CloseApplicationCommand { get; }
        private void OnCloseApplicationCommandExecute(object p)
        {
            Application.Current.Shutdown();
        }
        private bool CanCloseApplicationCommandExecute(object p)
        {
            return true;
        }
        #endregion

        #region Collapse command
        public ICommand CollapseApplicationCommand { get; }
        private void OnCollapseApplicationCommandExecute(object p)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
        private bool CanCollapseApplocatioCommandExecute(object p)
        {
            return true;
        }
        #endregion

        #region Open big main window command
        public ICommand OpenBigMainWindowCommand { get; }
        private void OnOpenBigMainWindowCommandExecute(object p)
        {
            BigMainWindow bigMain = new BigMainWindow();
            bigMain.Show();
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
        private bool CanOpenBigMainWindowCommandExecute(object p)
        {
            return true;
        }
        #endregion

        public ICommand PlayMusicCommand{ get; }
        private void OnPlayMusicCommandExecute(object p)
        {
            _playerCommand.IsPaused = false;
            _playerCommand.IsPlaying = true;
            _playerCommand.PlayMusic();
            


        }
        private bool CanPlayMusicCommandExecute(object p)
        {
            return true;
        }

        public MainWindowViewModel()
        {
            _playerCommand = new MusicPlayerCommand(@"C:\Users\79266\OneDrive\Documents\програмирование\C#\Портфолио\MusicPlayer\MusicPlayer\bin\Debug\net6.0-windows\TestMusic\slipknot_-_before_i_forget.mp3");

            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecute, CanCloseApplicationCommandExecute);
            CollapseApplicationCommand = new LambdaCommand(OnCollapseApplicationCommandExecute, CanCollapseApplocatioCommandExecute);
            OpenBigMainWindowCommand = new LambdaCommand(OnOpenBigMainWindowCommandExecute, CanOpenBigMainWindowCommandExecute);
            PlayMusicCommand = new LambdaCommand(OnPlayMusicCommandExecute,CanPlayMusicCommandExecute);
        }

    }
}
