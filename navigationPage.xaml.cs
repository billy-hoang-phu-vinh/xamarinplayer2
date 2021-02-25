using MusicApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace a02xamarinplayerapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class navigationPage : ContentPage
    {
        ObservableCollection<Music> music_list;
        public navigationPage()
        {
            InitializeComponent();
        }
        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            //test: local
            music_list= new ObservableCollection<Music>
            {
                new Music { Title = "River Flow in You (Cover)", Artist = "An Coong", Url = "https://raw.githubusercontent.com/billy-hoang-phu-vinh/xamarin-musicplayer/main/sourcefiles/River-Flows-In-You-Piano-Cover-An-Coong.mp3", CoverImage = "https://raw.githubusercontent.com/billy-hoang-phu-vinh/xamarin-musicplayer/main/sourcefiles/900x520_piano-min.jpg", IsRecent = true},
                new Music { Title = "River Flow in You (Cover)", Artist = "An Coong", Url = "https://raw.githubusercontent.com/billy-hoang-phu-vinh/xamarin-musicplayer/main/sourcefiles/River-Flows-In-You-Piano-Cover-An-Coong.mp3", CoverImage = "https://raw.githubusercontent.com/billy-hoang-phu-vinh/xamarin-musicplayer/main/sourcefiles/900x520_piano-min.jpg", IsRecent = true},
               new Music { Title = "River Flow in You (Cover)", Artist = "An Coong", Url = "https://raw.githubusercontent.com/billy-hoang-phu-vinh/xamarin-musicplayer/main/sourcefiles/River-Flows-In-You-Piano-Cover-An-Coong.mp3", CoverImage = "https://raw.githubusercontent.com/billy-hoang-phu-vinh/xamarin-musicplayer/main/sourcefiles/900x520_piano-min.jpg", IsRecent = true}
            };

            await Navigation.PushModalAsync(new MainPage(music_list));
            ///
            ///

        }
    }
}