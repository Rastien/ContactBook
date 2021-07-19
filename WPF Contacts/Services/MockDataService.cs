using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Contacts.Models;

namespace WPF_Contacts.Services
{
    public class MockDataService : IContactDataService
    {

        private IEnumerable<Contact> _contacts;

        public MockDataService()
        {
            _contacts = new List<Contact>()
            {
                new Contact
                {
                    Name = "Bill Baily",
                    PhoneNumbers = new string[]
                    {
                        "555-666-777-111",
                        "123-456-123-444"
                    },
                    Emails = new string[]
                    {
                        "gg@ll.com",
                        "bb@cc.com"
                    },
                    Locations = new string[]
                    {
                        "crooks",
                        "dooks"
                    }
                },

                new Contact
                {
                    Name = "HH Baily",
                    PhoneNumbers = new string[]
                    {
                        "22-666-77227-111",
                        "123-222-12223-444"
                    },
                    Emails = new string[]
                    {
                        "gg@222ll.com",
                        "bb@c222c.com"
                    },
                    Locations = new string[]
                    {
                        "cr22ooks",
                        "do22oks"
                    }
                }

            };
        }

        public IEnumerable<Contact> GetContacts()
        {
           return _contacts;
        }

        public void Save(IEnumerable<Contact> contacts)
        {
            _contacts = contacts;
        }
    }
}
