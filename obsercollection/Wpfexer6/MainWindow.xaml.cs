using Model_used;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Wpfexer6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private games currentGame;
        public ObservableCollection<games> Game { get; private set; }
        private int maxIndex;
        public games CurrentGame
        {
            get => currentGame;
            set
            {
                currentGame = value;
                OnPropertyChanged();
            }
        }

        public int MaxIndex { get => maxIndex; set => maxIndex = value; }

        public MainWindow()
        {
            Game = new ObservableCollection<games>()
            {
                new games() { Titre="Battlefield 4", Annee=2016, Console="Playsation", Description="Amazing game!", Editeur="EA DICE", Rating=10, Imagepath="image/bf4.png"},
                new games() { Titre="Farcry 5", Annee=2018, Console="Playsation", Description="Just wow!", Editeur="Ubisoft", Rating=7, Imagepath="image/Farcry_5.png"},
                 new games() { Titre="Bioshock infinite", Annee=2013, Console="Playsation", Description="Incredible game!", Editeur="2K Games", Rating=3, Imagepath="image/bioshock-infinite.png"},
                  new games() { Titre="Need for speed", Annee=2018, Console="Playsation", Description="INSANE!", Editeur="EA Games", Rating=4, Imagepath="image/nfspayback.png"}
            };

            CurrentGame = Game[0];
            MaxIndex = Game.Count - 1;

            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
      

       

        private void selected(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (Bf4.IsFocused)
            {
                CurrentGame = Game[0];
                Scrollbar.Value = 0;
            }

            if (Bioshock.IsFocused)
            {
                CurrentGame = Game[2];
                Scrollbar.Value = 1;
            }

            if (Farcry_5.IsFocused)
            {
                CurrentGame = Game[1];
                Scrollbar.Value = 2;
            }

            if (Need_for_speed.IsFocused)
            {
                CurrentGame = Game[3];
                Scrollbar.Value = 3;
            }

        }

        private void Slider_value(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            currentGame.Rating = e.NewValue;
        }

        private void scrollgame(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {



            if (Scrollbar.Value ==0)
            {
                CurrentGame = Game[0];
                Bf4.IsSelected = true;
            }

            if (Scrollbar.Value == 0)
            {
                CurrentGame = Game[2];
                Bioshock.IsSelected = true;
            }

            if (Scrollbar.Value == 0)
            {
                CurrentGame = Game[1];
                Farcry_5.IsSelected = true;
            }

            if (Scrollbar.Value == 0)
            {
                CurrentGame = Game[3];
                Need_for_speed.IsSelected = true;
            }






        }
    }
}
