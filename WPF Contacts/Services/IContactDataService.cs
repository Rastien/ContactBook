using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Contacts.Models;

namespace WPF_Contacts.Services
{
    public interface IContactDataService
    {

        IEnumerable<Contact> GetContacts();

        void Save(IEnumerable<Contact> contacts);

    }
}
