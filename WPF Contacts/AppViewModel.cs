using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Contacts.Services;
using WPF_Contacts.Utility;
using WPF_Contacts.ViewModels;

namespace WPF_Contacts
{
    public class AppViewModel : ObservableObject
    {
        private object _currentView;
        public object CurrentView
        {
            get {return _currentView; }
            set {OnPropertyChanged(ref _currentView, value); }
        }

        private BookViewModel _bookVM;
        public BookViewModel BookVM
        {
            get { return _bookVM;}
            set { OnPropertyChanged(ref _bookVM, value); }
        }

        public AppViewModel()
        {
            var dataService = new MockDataService();

            BookVM = new BookViewModel(dataService);
            CurrentView = BookVM;
        }
    }
}
