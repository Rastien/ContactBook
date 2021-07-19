using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Contacts.Utility;
namespace WPF_Contacts.Models

{
    public class Contact : ObservableObject
    {
        private string _name;
        public string Name
        {
            get {return _name;}
            set {OnPropertyChanged(ref _name, value); }
        }

        private string [] _phoneNumbers;
        public string [] PhoneNumbers
        {
            get {return _phoneNumbers;}
            set {OnPropertyChanged(ref _phoneNumbers, value); }
        }

        private string [] _emails;
        public string [] Emails
        {
            get {return _emails;}
            set {OnPropertyChanged(ref _emails, value); }
        }

        private string [] _locations;
        public string [] Locations
        {
            get {return _locations;}
            set {OnPropertyChanged(ref _locations, value); }
        }

        private bool _isFavourite;
        public bool IsFavourite
        {
            get {return _isFavourite;}
            set {OnPropertyChanged(ref _isFavourite, value); }
        }

        private string _imagePath;
        public string ImagePath
        {
            get {return _name;}
            set {OnPropertyChanged(ref _imagePath, value); }
        }

    }

}
