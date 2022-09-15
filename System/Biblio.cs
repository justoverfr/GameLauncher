using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TheGameLauncher
{
    class Biblio : INotifyPropertyChanged
    {


        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public Biblio()
        {
            gameName = new string[] { "bl", "b1", "b2" };
            //Initialize();
        }


        public void Initialize()
        {
            
        }


        #endregion

        private bool isMyLibraryLaunch;

        public bool IsMyLibraryLaunch
        {
            get
            {
                return isMyLibraryLaunch;
            }
            set
            {
                isMyLibraryLaunch = value;
                OnPropertyChanged();
            }
        }
        public string[] gameName;

        public string[] GameName
        {
            get
            {
                return gameName;
            }
            set
            {
                gameName = value;
                OnPropertyChanged();
            }
        }

        //1150
    }
}
