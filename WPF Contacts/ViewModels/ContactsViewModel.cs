using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Contacts.Models;
using WPF_Contacts.Utility;

namespace WPF_Contacts.ViewModels
{
    public class ContactsViewModel : ObservableObject
    {
        private Contact _selectedContact;
        public Contact SelectedContact
        {
            get {return _selectedContact;}
            set {OnPropertyChanged(ref _selectedContact, value); }
        }

        public ObservableCollection<Contact> Contacts {get; private set; }

        public ContactsViewModel()
        {
        }

        public void LoadContacts(IEnumerable<Contact> contacts)
        {
            Contacts = new ObservableCollection<Contact>(contacts);
            OnPropertyChanged("Contacts");
        }
    }
}
