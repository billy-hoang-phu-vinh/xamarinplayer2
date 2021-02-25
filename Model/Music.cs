using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MusicApp.Model
{
    public class Music : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _title; //backing field. Temporary variable
        private string _artist; //backing field. Temporary variable
        private string _url; //backing field. Temporary variable
        private string _coverimage; //backing field. Temporary variable
        private bool _isrecent; //backing field. Temporary variable
        public string Title
        {
            get { return _title; }
            set
            {
                if (_title == value)
                    return;
                _title = value; //save to value
                if (PropertyChanged != null)
                {

                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Title)));
                }
            }
        }
        public string Artist
        {
            get { return _artist; }
            set
            {
                if (_artist == value)
                    return;
                _artist = value; //save to value
                if (PropertyChanged != null)
                {

                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Artist)));
                }
            }
        }

        public string Url
        {
            get { return _url; }
            set
            {
                if (_url == value)
                    return;
                _url = value; //save to value
                if (PropertyChanged != null)
                {

                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Url)));
                }
            }
        }
        public string CoverImage
        {
            get { return _coverimage; }
            set
            {
                if (_coverimage == value)
                    return;
                _coverimage = value; //save to value
                if (PropertyChanged != null)
                {

                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(CoverImage)));
                }
            }
        }
        public bool IsRecent
        {
            get { return _isrecent; }
            set
            {
                if (_isrecent == value)
                    return;
                _isrecent = value; //save to value
                if (PropertyChanged != null)
                {

                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(IsRecent)));
                }
            }
        }
    }
}
