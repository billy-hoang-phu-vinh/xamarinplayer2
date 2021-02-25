using MusicApp.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System;
using System.Collections.Generic;
using MusicApp.ViewModel;
using MusicApp;

namespace a02xamarinplayerapp
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Music> temp_musicList;
        //Music temp_music;
        public MainPage(ObservableCollection<Music> music_list)
        {
            InitializeComponent();
            temp_musicList = music_list;
            mylist.ItemsSource = music_list;
            recentMusic = music_list.Where(x => x.IsRecent == true).FirstOrDefault();

        }
        private Music recentMusic;
        public Music RecentMusic
        {
            get { return recentMusic; }
            set
            {
                recentMusic = value;
                OnPropertyChanged();
            }
        }
        private Music selectedMusic;
        public Music SelectedMusic
        {
            get { return selectedMusic; }
            set
            {
                selectedMusic = value;
                OnPropertyChanged();
            }
        }
        async void MyListSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            //await Navigation.PushModalAsync(new Play(recentMusic, temp_musicList));
            await Navigation.PushModalAsync(new Play());
        }
    }
}
