using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Components
{
    class Contact
    {
        private int Id;
        public string Name;
        public string Surname;
        private string PhoneNumber;
        private string ContactInformation;

        public string contactInformation
        {
            get { return ContactInformation; }
            set
            {
                if (value.Length > 9)
                {
                    Console.WriteLine("To loong phone number");
                }
                ContactInformation = value;
            }
        }
        public Contact(string name, string surname, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            SetPhoneNumber(phoneNumber);
        }
        public string GetPhoneNumber() => PhoneNumber;
        public int GetId() => Id;
        public void SetPhoneNumber(string newNumber)
        {
            PhoneNumber = newNumber;
        }



    }



}
