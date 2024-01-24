using System;
using System.Collections.Generic;
using System.Text;

namespace Review3
{
    public  class ContactOfAddressBook
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Address {  get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Phone {  get; set; }
        public string Email { get; set; }
        public string State {  get; set; }

        public ContactOfAddressBook(string firstName, string lastName, string email, string phone, string address, string city, string zip,  string state)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            Zip = zip;
            Phone = phone;
            Email = email;
            State = state;
        }
        public ContactOfAddressBook() { }
        public string GetDetails => $"{FirstName} {LastName} {Phone} {Email} {Address} {City} {Zip} {State} ";
    }
}
