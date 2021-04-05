using System;

namespace BankSystem.Models
{
    class CardHolder : Naming, IEquatable<CardHolder>
    {
        public long MobileNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public bool Equals( CardHolder other)
        {
            if (other == null)
            {
                return false;
            }

            if (FullName.Equals(other.FullName) && DateOfBirth.Equals(other.DateOfBirth))
                return true;

            return false;
        }

        public CardHolder(string name, string surname, long mobile, DateTime dateOfBirth, string address, string city)
        {
            Name = name;
            Surname = surname;
            MobileNumber = mobile;
            DateOfBirth = dateOfBirth;
            Address = address;
            City = city;
        }

        public CardHolder(CardHolder cardHolder)
        {
            Name = cardHolder.Name;
            Surname = cardHolder.Surname;
            MobileNumber = cardHolder.MobileNumber;
            DateOfBirth = cardHolder.DateOfBirth;
            Address = cardHolder.Address;
            City = cardHolder.City;
        }

        public CardHolder() { }
    }
}
