using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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

namespace TheGameLauncher
{
    //Ceci est un commentaire

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        # region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        /// <summary>
        /// 


        #region Property
        private int gameID = 0;

        private bool IsButton1Stop = false;
        private bool IsButton2Stop = false;

        Biblio Gestionnary_Biblio { get; set; }
        #endregion
        /// </summary>

        public MainWindow()
        {
            InitializeComponent();
            CompositionTarget.Rendering += RefreshView;
            Gestionnary_Biblio = new Biblio();
        }

        //TODO Rajouter des Label avec le même nom, (00 à 10) 
        //TODO  Mettre de façon jolie la grille
        //TODO Mettre en place le binding qui est dans la description dans le nom du jeux
        //TODO Mettre en place une table de GameName 
        // -- Faire le binding vas bien

        // Binding path GameName[0]
        // Binding path GameName[1]
        // Binding path GameName[2]
        // Binding path GameName[3
        // Faire un int à 0
        // Quand tu appuie sur le bouton int de 1
        // Bouton supprimer tu le décrémente, sois tu le met à 0

        public void RefreshView(object sender, EventArgs e)
        {
            if (IsButton1Stop == true && IsButton2Stop == true)
            {
                Biblio.IsEnabled = false;
            }
            UIRefreshBinding();
            //TODO Faire un Enum du statut actuel du launcher
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (Button1.Background == Brushes.Green)
            {
                Button1.Background = Brushes.Red;
                IsButton1Stop = true;
            }

            else
            {
                Button1.Background = Brushes.Green;
                IsButton1Stop = false;

            }
            UIRefreshBinding();
            Gestionnary_Biblio.GameName[0] = gameNameTb.Text.ToString();
            Gestionnary_Biblio.GameName[1] = gameNameTb.Text.ToString();
            Gestionnary_Biblio.GameName[2] = gameNameTb.Text.ToString();
            Console.WriteLine(Gestionnary_Biblio.gameName[0]);
            Console.WriteLine(Gestionnary_Biblio.gameName[1]);
            Console.WriteLine(Gestionnary_Biblio.gameName[2]);

            UIRefreshBinding();

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (Button2.Background == Brushes.Green)
            {
                Button2.Background = Brushes.Red;
                IsButton2Stop = true;
            }
            else
            {
                Button2.Background = Brushes.Green;
                IsButton2Stop = false;


            }
        }

        private void UIRefreshBinding()
        {
            gameInfoGrid.DataContext = Gestionnary_Biblio;
            Biblio.DataContext = Gestionnary_Biblio;
        }

    }
}
