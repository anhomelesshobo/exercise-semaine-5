using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Model_used
{
    public class games : INotifyPropertyChanged
    {
        private double rating;
        public string Titre { get; set; }
        public string Console { get; set; }
        public int Age { get; set; }

        public double Rating
        {
            get => rating;
            set
            {
                rating = value;
                OnPropertyChanged();
            }
        }

        public string Editeur { get; set; }

        public string Description { get; set; }
        public int Annee { get; set; }
        public string Imagepath { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
