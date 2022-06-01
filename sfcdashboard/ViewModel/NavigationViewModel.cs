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
    class NavigationViewModel : INotifyPropertyChanged
    {
        //enables xaml code to set commonly used collectionview props
        private CollectionViewSource MenuItemsCollection;

        //enables collections to have functionalities of current record management,
        //custom sorting, filtering, grouping etc
        public ICollectionView SourceCollection => MenuItemsCollection.View;

        public NavigationViewModel()
        {
            //represents dynamic data collection that provides notification when items get added, removed or updated
            ObservableCollection<MenuItems> menuItems = new ObservableCollection<MenuItems>
            {
                new MenuItems{MenuName="Input", MenuImage= @"Assets/homeIcon.png"},
                new MenuItems{MenuName="Info", MenuImage= @"Assets/fileIcon.png"},
                new MenuItems{MenuName="Runs", MenuImage= @"Assets/dataIcon.png"},
                new MenuItems{MenuName="Builds", MenuImage= @"Assets/reportsIcon.png"},
                new MenuItems{MenuName="Tasks", MenuImage= @"Assets/connectionIcon.png"},
                new MenuItems{MenuName="Issues", MenuImage= @"Assets/settingsIcon.png"},
            };

            MenuItemsCollection = new CollectionViewSource { Source = menuItems };
            MenuItemsCollection.Filter += MenuItems_Filter;

            SelectedViewModel = new InputViewModel();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        private string filterText;
     
        public string FilterText
        {
            get => filterText;
            set
            {
                filterText = value;
                MenuItemsCollection.View.Refresh();
                OnPropertyChanged("FilterText");
            }
        }
        
        private void MenuItems_Filter(object sender, FilterEventArgs e)
        {
            if (string.IsNullOrEmpty(FilterText))
            {
                e.Accepted = true;
                return;
            }

            MenuItems _item = e.Item as MenuItems;
            if (_item.MenuName.ToUpper().Contains(FilterText.ToUpper()))
            {
                e.Accepted = true;
            }
            else
            {
                e.Accepted = false;
            }
        }
        
        private object _selectedViewModel;
        public object SelectedViewModel
        {
            get => _selectedViewModel;
            set { _selectedViewModel = value; OnPropertyChanged("SelectedViewModel"); }
        }

        public void SwitchViews(object parameter)
        {
            Console.WriteLine(parameter.ToString());
            switch (parameter)
            {
                case "Input":
                    SelectedViewModel = new InputViewModel();
                    break;
                case "Info":
                    SelectedViewModel = new InfoViewModel();
                    break;
                case "Issues":
                    SelectedViewModel = new IssuesViewModel();
                    break;


            }
        }

        private ICommand _menuCommand;
        public ICommand MenuCommand
        {
            get
            {
                if(_menuCommand == null)
                {
                    _menuCommand = new RelayCommand(param => SwitchViews(param));
                }
                return _menuCommand;
            }
        }

        private void ShowHome()
        {
            SelectedViewModel = new InfoViewModel();
        }

        private ICommand _backHomeCommand;
        public ICommand BackHomeCommand
        {
            get
            {
                if(_backHomeCommand == null)
                {
                    _backHomeCommand = new RelayCommand(p => ShowHome());
                }
                return _backHomeCommand;
            }
        }

        public void CloseApp(object obj)
        {
            //check ongoing processes
           System.Windows.Application.Current.Shutdown();
        }

        private ICommand _closeCommand;
        public ICommand CloseAppCommand
        {
            get
            {
                if(_closeCommand == null)
                {
                    _closeCommand = new RelayCommand(p => CloseApp(p));
                }
                return _closeCommand;
            }
        }
    }
}
