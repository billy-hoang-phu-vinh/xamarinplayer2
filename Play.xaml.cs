using MediaManager;
using MusicApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace a02xamarinplayerapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Play : ContentPage
    {

        private Music selectedMusic;
        private ObservableCollection<Music> music_List;
        public bool isPlaying;

        public Play()
        {
            InitializeComponent();
            CrossMediaManager.Current.Init();
            CrossMediaManager.Current.Play("https://raw.githubusercontent.com/billy-hoang-phu-vinh/xamarin-musicplayer/main/sourcefiles/River-Flows-In-You-Piano-Cover-An-Coong.mp3");


        }


        public Play(Music selectedMusic, ObservableCollection<Music> musicList)
        {
            InitializeComponent();
            CrossMediaManager.Current.Init();
            CrossMediaManager.Current.Play("https://raw.githubusercontent.com/billy-hoang-phu-vinh/xamarin-musicplayer/main/sourcefiles/River-Flows-In-You-Piano-Cover-An-Coong.mp3");

            title.Text = selectedMusic.Title;
            coverimg.Source = selectedMusic.CoverImage;
            artist.Text = selectedMusic.Artist;

            this.selectedMusic = selectedMusic;
            this.music_List = musicList;
            //PlayMusic(selectedMusic);
            isPlaying = true;
        }
        
    }
}