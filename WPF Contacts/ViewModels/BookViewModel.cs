using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_Contacts.Services;
using WPF_Contacts.Utility;

namespace WPF_Contacts.ViewModels
{
    public class BookViewModel : ObservableObject
    {
        private IContactDataService _service;

        private ContactsViewModel _contactsVM;
        public ContactsViewModel ContactsVM
        {
            get {return _contactsVM;}
            set {OnPropertyChanged(ref _contactsVM, value); }
        }

        public ICommand LoadContactsCommand {get; private set; }
        public ICommand LoadFaouvirtesCommand {get; private set; }

        public BookViewModel(IContactDataService service)
        {
            ContactsVM = new ContactsViewModel();

            _service = service;

            LoadContactsCommand = new RelayCommand(LoadContacts);
            LoadFaouvirtesCommand = new RelayCommand(LoadFavourites);
        }

        private void LoadContacts()
        {
            ContactsVM.LoadContacts(_service.GetContacts());
        }

        private void LoadFavourites()
        {
            var favourites = _service.GetContacts().Where(c => c.IsFavourite);
            ContactsVM.LoadContacts(favourites);
        }

    }
}
