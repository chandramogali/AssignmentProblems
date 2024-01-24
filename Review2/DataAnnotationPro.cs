using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Review2
{
    public  class DataAnnotationPro
    {

        [Required(ErrorMessage = "First Name is required")]
        [RegularExpression(@"^[A_Z][a-zA-Z0-9]{4-20}$", ErrorMessage = "Firstname staring with capital letters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Zip Code is required")]
        [RegularExpression(@"^\d{}(-\d{4})?$", ErrorMessage = "Invalid Zip Code")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Invalid Phone Number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [RegularExpression(@"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$", ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "State is required")]
        [RegularExpression(@"^[A_Z][a-zA-Z0-9]{3-20}$", ErrorMessage = "Firstname staring with capital letters")]

        public string State { get; set; }

        public DataAnnotationPro(string firstName, string lastName, string email, string phone, string address, string city, string zip, string state)
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
        public DataAnnotationPro() { }
        public string GetDetails => $"{FirstName} {LastName} {Phone} {Email} {Address} {City} {Zip} {State} ";
    }
}
