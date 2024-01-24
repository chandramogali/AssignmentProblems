using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Review2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CheckVowels();
            //  DeletePostion();

            //AddZeroEnd();

            //Positive();
           List<DataAnnotationPro> book= new List<DataAnnotationPro>();
            DataAnnotationPro person = new DataAnnotationPro();

        FirstName:
            Console.WriteLine("Enter First Name");
            string firstName=Console.ReadLine();

            var result = Regex.IsMatch(firstName, @"^[A-Z][a-zA-Z0-9]{3,15}$");
            if (!result)
            {
                Console.WriteLine("Invalid Firstname starting with Capital letter  " );
                goto FirstName;

            }
            else
            {
                person.FirstName = firstName;
            }

            LastName:
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            result = Regex.IsMatch(lastName, @"^[A-Z][a-zA-Z0-9]{3,15}$");
            if (!result)
            {
                Console.WriteLine("Invalid Lastname starting with Capital letter ");
                goto LastName;

            }
            else
            {
                person.LastName = lastName;
            }
        Email:
            Console.WriteLine("Enter Email");
            string email = Console .ReadLine();
            result = Regex.IsMatch(email, @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$");
            if (!result)
            {
                Console.WriteLine("Invalid Email ");
                goto Email;

            }
            else
            {
                person.Email = email;
            }
        Phone:
            Console.WriteLine("Enter phone number");
            string phone = Console.ReadLine();
            result = Regex.IsMatch(phone, @"^\d{10}$");
            if (!result)
            {
                Console.WriteLine("Invalid phone Number shoubld be 10 digits");
                goto Phone;

            }
            else
            {
                person.Phone = phone;
            }

            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            person.Address = address;

            Console.WriteLine("Enter City Name");
            string city = Console.ReadLine();
            person.City = city;

        Zip:
            Console.WriteLine("Enter zip code ");
            string zip = Console.ReadLine();
            
            result = Regex.IsMatch(phone, @"^\d{10}$");
            if (!result)
            {
                Console.WriteLine("Invalid phone ");
                goto Zip;

            }
            else
            {
                person.Zip = zip;
            }

            Console.WriteLine("Enter State Name");
            string state = Console.ReadLine();
            person.State = state;
            //DataAnnotationPro person = new DataAnnotationPro(firstName, lastName, address, city, zip, phone, email, state);



            book.Add(person);
            Console.WriteLine("Detail of person ");
           foreach(var item in book)
            {
                Console.WriteLine(item.GetDetails);
            }
        }

        public static void CheckVowels()
        {
            int Vowels = 0;
            string ans = "";
            int consonants = 0;
            string res = "";
            string str = Console.ReadLine();
           
             for (int i = 0; i< str.Length;i++ ){
                if (str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U' || str[i] == 'a' || str[i] == 'e' ||
                    str[i] == 'i' ||  str[i] == 'o' || str[i] == 'u') {
                    Vowels++;
                    ans += str[i];

                }
                else
                {
                    res += str[i];
                    consonants++;
                }
            }
             Console.WriteLine(str);
            Console.WriteLine($"number of vowels in str ( {ans} ) = {Vowels}");
            Console.WriteLine($"number of consonants in str ( {res} ) = {consonants}");
        }


        public static void DeletePostion()
        {
            Console.WriteLine("enter the size of arrey");
            int size=Convert.ToInt32( Console.ReadLine() );

            int[] arr = new int[size];  
            for(int i = 0;i< size;i++)
            {
                arr[i]= Convert.ToInt32( Console.ReadLine()) ;
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("enter the position ");
           int pos=Convert.ToInt32( Console.ReadLine() );

           for(int i=pos-1;i<arr.Length -1;i++)
            { 
                arr[i] = arr[i+1];
            }

            for (int i = 0; i < arr.Length - (pos-1);i++)
            {
                Console.WriteLine($"{i}:{arr[i]}");
            }
        }

        public static void AddZeroEnd()
        {
            int[] arr = { 10, 0, 12, 15, 20, 0, 7, 0, 2, 0 };
            int count = 0;

            int size=arr.Length;

            for(int i = 0;i< arr.Length;i++)
            {
                if (arr[i] != 0)
                {
                    arr[count++] = arr[i];

                }
            }

            for(int i = count; i < size; i++)
            {
                arr[count] = 0;
                count++;
            }


            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public static void Positive()
        {

            List<int> lst = new List<int>
            {
                -2,2,-1,1,4,5,-5,-6,6,7,8,-9
            };

            var positive= from i in lst
                          where i>0
                          where i %2 == 0
                          
                          select i;

            Console.WriteLine("positive number");

            foreach (var num in positive)
            {
                Console.Write($"  {num}");
            }

        }
    }

    
}
