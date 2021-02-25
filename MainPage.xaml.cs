using MusicApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace a02xamarinplayerapp
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Music> temp_musicList;

        public MainPage(System.Collections.ObjectModel.ObservableCollection<MusicApp.Model.Music> music_list)
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

        async void mylist_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {

            await Navigation.PushModalAsync(new Play());
        }
    }
}
