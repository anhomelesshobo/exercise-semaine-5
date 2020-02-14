using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpfsem5exer1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Game Currentgame0 { get; set; }
        public Game Currentgame1 { get; set; }
        public Game Currentgame2 { get; set; }
        public Game Currentgame3 { get; set; }

        double currentscroll;
        public Game Gameshown { get; set; }
        public MainWindow()
        {
           
            Currentgame0 = new Game()
            {
                Titre = "Battlefield 4",
                Editeur = "EA DICE",
                Console = "Playstation",
                Annee = 2016,
                Description = "Amazing game!",
                Rating = 8,
                PicturePath = "images/bf4.png"

            };
           

            Currentgame1 = new Game()
            {
                Titre = "Need for speed Payback",
                Editeur = "Electronic Arts",
                Console = "Playstation",
                Annee = 2017,
                Description = "Just like real life!",
                Rating = 10,
                PicturePath = "images/nfspayback.png"

            };

            Currentgame2 = new Game()
            {
                Titre = "Farcry 5",
                Editeur = "Ubisoft",
                Console = "Playstation",
                Annee = 2018,
                Description = "Insane Graphics!",
                Rating = 7,
                PicturePath = "images/Farcry_5.png"

            };

            Currentgame3 = new Game()
            {
                Titre = "Bioshock infinite",
                Editeur = " 2K Games",
                Console = "Playstation",
                Annee = 2013,
                Description = "Just Wow!",
                Rating = 9,
                PicturePath = "images/bioshock-infinite.png"

            };

            Gameshown = new Game()
            {
                Titre = "Battlefield 4",
                Editeur = "EA DICE",
                Console = "Playstation",
                Annee = 2016,
                Description = "Amazing game!",
                Rating = 8,
                PicturePath = "images/bf4.png"
                
            };

           
            InitializeComponent();
        }
        
         void gameScroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {
            
            if(scrollgame.Value == 0)
            {
                Gameshown.Titre = Currentgame0.Titre;
                Gameshown.Rating = Currentgame0.Rating;
                Gameshown.Editeur = Currentgame0.Editeur;
                Gameshown.Description = Currentgame0.Description;
                Gameshown.Annee = Currentgame0.Annee;
                Gameshown.PicturePath = Currentgame0.PicturePath;
                
            }

            Currentgame0.Rating = Gameshown.Rating;

            if (scrollgame.Value == 1)
            {
                Gameshown.Titre = Currentgame1.Titre;
                Gameshown.Rating = Currentgame1.Rating;
                Gameshown.Editeur = Currentgame1.Editeur;
                Gameshown.Description = Currentgame1.Description;
                Gameshown.Annee = Currentgame1.Annee;
                Gameshown.PicturePath = Currentgame1.PicturePath;
               
            }

            
            if (scrollgame.Value == 2)
            {
                Gameshown.Titre = Currentgame2.Titre;
                Gameshown.Rating = Currentgame2.Rating;
                Gameshown.Editeur = Currentgame2.Editeur;
                Gameshown.Description = Currentgame2.Description;
                Gameshown.Annee = Currentgame2.Annee;
                Gameshown.PicturePath = Currentgame2.PicturePath;
                
            }
           
            if (scrollgame.Value == 3)
            {
                Gameshown.Titre = Currentgame3.Titre;
                Gameshown.Rating = Currentgame3.Rating;
                Gameshown.Editeur = Currentgame3.Editeur;
                Gameshown.Description = Currentgame3.Description;
                Gameshown.Annee = Currentgame3.Annee;
                Gameshown.PicturePath = Currentgame3.PicturePath;
                
            }
            
            
        }

        private void Ratingchanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           
                if(scrollgame.Value == 0)
                {
                    Currentgame0.Rating = Gameshown.Rating;
                }

                if (scrollgame.Value == 1)
                {
                    Currentgame1.Rating = Gameshown.Rating;
                }

                if (scrollgame.Value == 2)
                {
                    Currentgame2.Rating = Gameshown.Rating;
                }

                if (scrollgame.Value == 3)
                {
                    Currentgame3.Rating = Gameshown.Rating;
                }


            
        }

        

        
    }
    public class Game : INotifyPropertyChanged
    {
        private string titre;

        private string editeur;

        private string console;

        private string description;
        private string picturePath;
        private int annee;
        private int rating;

        public string Titre 
        { get => titre;
            set
            {
                titre = value;
                OnPropertyChanged("Titre");
            }
        }

        public string Console
        {
            get => console;
            set
            {
               console = value;
                OnPropertyChanged("Console");
            }
        }

        public string Editeur {
            get => editeur;
            set
            {
                editeur = value;
                OnPropertyChanged("Editeur");
            }
        }

        public string Description
        {
            get => description;
            set
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }

        public string PicturePath
        {
            get => picturePath;
            set
            {
               picturePath = value;
                OnPropertyChanged("PicturePath");
            }
        }

        public int Annee
        {
            get => annee;
            set
            {
               annee = value;
                OnPropertyChanged("Annee");
            }
        }

        public int Rating
        {
            get => rating;
            set
            {
                rating = value;
                OnPropertyChanged("Rating");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

       

        private void OnPropertyChanged([CallerMemberName] string propertyName="")
        {


            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            
        }
        
    }
   
}
