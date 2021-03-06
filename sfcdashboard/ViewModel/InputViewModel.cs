using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Input;
using sfcdashboard.Model;

namespace sfcdashboard.ViewModel
{
    public class InputViewModel : INotifyPropertyChanged
    {
        //private CollectionViewSource HomeItemsCollection;
        //public ICollectionView HomeSourceCollection => HomeItemsCollection.View;
        //enables xaml code to set commonly used collectionview props
        private CollectionViewSource InputItemsCollection;

        //enables collections to have functionalities of current record management,
        //custom sorting, filtering, grouping etc
        public ICollectionView SourceCollection => InputItemsCollection.View;


        public InputViewModel()
        {
            ObservableCollection<UrlItem> homeItems = new ObservableCollection<UrlItem>()
            {
                new UrlItem { url="https://www.porsche.de" },
                new UrlItem { url="https://www.fanuc.eu" },
                new UrlItem { url="https://www.daimler.de" },
                new UrlItem { url="https://www.h4tfg9bzh.de" },
                new UrlItem { url="https://www.youtube.com" },

            };

            InputItemsCollection = new CollectionViewSource { Source = homeItems };

            //HomeItemsCollection = new CollectionViewSource { Source = homeItems };
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
