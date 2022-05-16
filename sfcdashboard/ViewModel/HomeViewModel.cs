using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Input;
using sfcdashboard.Model;
namespace sfcdashboard.ViewModel
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        //private CollectionViewSource HomeItemsCollection;
        //public ICollectionView HomeSourceCollection => HomeItemsCollection.View;

        public HomeViewModel()
        {
           // ObservableCollection<HomeItems> homeItems = new ObservableCollection<HomeItems>
            //{
            //    new HomeItems { HomeName = "This PC", HomeImage = @"Assets/connection_icon.png" },
            //};

            //HomeItemsCollection = new CollectionViewSource { Source = homeItems };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
