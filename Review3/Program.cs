using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Review3
{
    public class Program
    {
        public static void swapTowNumbers(int a ,int b)
        {
            Console.WriteLine($"before swaping a = {a} and  b = {b}");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"after swaping swaping a = {a} and  b = {b}");
        }
        public static void Swaping()
        {
            Console.WriteLine("Enther the number1");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enther the number2");
            int b = Convert.ToInt32(Console.ReadLine());
            swapTowNumbers(a, b);
        }
        public static void GenericFun()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int deleteInt = 3;
            double[] arrDouble = { 1.2, 1.3, 4.2, 2.5, 3.6, 4.5 };
            double DeleteDou = 1.3;
            char[] charArr = { 'a', 'b', 'c', 'd', 'e' };
            char deletechar = 'c';

            DeleteArray ar = new DeleteArray();

            ar.DeleteMethod<int>(arr, deleteInt);
            ar.DeleteMethod<double>(arrDouble, DeleteDou);
            ar.DeleteMethod<char>(charArr, deletechar);

        }
       
        public static void EnterData(List<ContactOfAddressBook> members)
        {
            Console.WriteLine("How many members of data you want Enter ? ");
            int size = Convert.ToInt32(Console.ReadLine());

            int count = members.Count;
            for (int i = 0; i < size; i++) 
            {
                Console.WriteLine();
                Console.WriteLine($"Ether the Data of {count+1} member ");

             FirstName:
                Console.WriteLine("Enter the First Name");
                 string firstName = Console.ReadLine();
                if (!Validation.IsNameValid(firstName))
                {
                    Console.WriteLine("Invalid name. Please enter a name starting with a capital letter  And minimum 3 Letters.");
                    goto FirstName;
                }
            LastName:
                Console.WriteLine("Enter the Last Name");
                string lastName = Console.ReadLine();
                if (!Validation.IsNameValid(lastName))
                {
                    Console.WriteLine("Invalid name. Please enter a Lastname starting with a capital letter.");
                    goto LastName;
                }

            Email:
                Console.WriteLine("Enter the Emial Address");
                string email = Console.ReadLine();


                if (!Validation.IsValidEmail(email))
                {
                    Console.WriteLine("Invalid email. Please enter a valid email address.");
                    goto Email;
                }

            Phone:
                Console.WriteLine("Enter the Phone number");
                string phone = Console.ReadLine();
                if (!Validation.IsValidPhoneNumber(phone))
                {
                    Console.WriteLine("Invalid phone number. Please enter a valid phone number.");
                    goto Phone; 
                }

                Console.WriteLine("Enter the Address");
                string address = Console.ReadLine();


                Console.WriteLine("Enter the City Name");
                string city = Console.ReadLine();

            Zip:
                Console.WriteLine("Enter the Zip Code");
                string zip = Console.ReadLine();
                if (!Validation.IsValidZipCode(zip))
                {
                    Console.WriteLine("Invalid phone number. Please enter a valid Zip Code.");
                    goto Zip;
                }

            State:
                Console.WriteLine("Enter the State Name");
                string state = Console.ReadLine();
                if (!Validation.IsNameValid(state))
                {
                    Console.WriteLine("Invalid name. Please enter a State name starting with a capital letter.");
                    goto State;
                }


                ContactOfAddressBook newBook = new ContactOfAddressBook(firstName, lastName, address, city, zip, phone, email, state);
                members.Add(newBook);
                count++;
                Console.WriteLine($"Data of member {count} is Entered successfully");
            }
            Console.WriteLine();
        }
        
        public static void DispalyList(List<ContactOfAddressBook> members)
        {
            int Count = 1;
            Console.WriteLine("List of AddressBook :- ");
            foreach (var item in members)
            {
                
                Console.WriteLine($"Data of member {Count} {item.GetDetails}");
               // Console.WriteLine($"Data of member {Count} is :- {item.FirstName} {item.LastName} {item.Email} {item.Address} {item.City} {item.State} {item.Zip}");
                Count++;
            }
            Console.WriteLine();
        }
  
        public static void UpdateData(List<ContactOfAddressBook> members)
        {
            Console.WriteLine("Enter the Member Name");
            string searchName = Console.ReadLine();

            
            ContactOfAddressBook foundMember = members.Find(member => member.FirstName.ToLower() == searchName.ToLower());

            if (foundMember != null)
            {
                Console.WriteLine("Enter the new name");
                string updateName = Console.ReadLine();

                foundMember.FirstName = updateName;

                Console.WriteLine($"Name Updated successfully");
            }
            else
            {
                Console.WriteLine($"Member with name '{searchName}' not found.");
            }

            Console.WriteLine("");
        }
        public static void deleteData(List<ContactOfAddressBook> members)
        {
            Console.WriteLine("Enter the name of Member to delete: ");
            string removeName = Console.ReadLine();

            // Assuming members is a List<ContactOfAddressBook>
            ContactOfAddressBook removeMember = members.Find(member => member.FirstName.ToLower() == removeName.ToLower());

            if (removeMember != null)
            {
                members.Remove(removeMember);
                Console.WriteLine($"Member with name '{removeName}' removed successfully.");
            }
            else
            {
                Console.WriteLine($"Member with name '{removeName}' not found.");
            }
        }
        static void Main(string[] args)
        {


            //Swaping();
            //GenericFun();


            List<ContactOfAddressBook> members = new List<ContactOfAddressBook>();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Select the Option");
                Console.WriteLine("Press 1. to Insert the Data");
                Console.WriteLine("Press 2. to update the Data");
                Console.WriteLine("Press 3. to Delete the Data");
                Console.WriteLine("Press 4. to Display the Data");
                Console.WriteLine("Press 5. to Exit ");
                int choice=Convert.ToInt32( Console.ReadLine());
                Console.WriteLine();
                switch (choice)
                {
                    case 1: 
                        EnterData(members);
                        break; 
                    case 2:
                        if (members.Count == 0)
                        {
                            Console.WriteLine("The list is empty! Please enter the data");
                        }
                        else
                        {
                            UpdateData(members);
                        }
                        break;
                    case 3: 
                           Console.WriteLine();
                        if (members.Count == 0)
                        {
                            Console.WriteLine("The list is empty! Please enter the data");
                        }
                        else
                        {
                            deleteData(members);
                        }
                        
                        break;
                    case 4:
                        if (members.Count == 0)
                        {
                            Console.WriteLine("The list is empty! Please enter the data");
                        }
                        else
                        {
                            DispalyList(members);
                        }
                        
                        break;
                    case 5: Console.WriteLine();
                        Environment.Exit(0);
                        break;
                    default: 
                        Console.WriteLine("Invalid Input! , Please enter the valid Input");
                        break;

                }

            }           
            
        }    
    }
}
