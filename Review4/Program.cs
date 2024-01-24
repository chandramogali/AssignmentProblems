using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
namespace Review4
{
    public class Que1
    {
        public static void FileOperation()
        {
            string fPath = @"D:\File\Review5.txt";
            try
            {
                Console.WriteLine("Entet the data to add into file");
                string data = Console.ReadLine();

                if (!File.Exists(data))
                {
                    File.AppendAllText(fPath, data);
                    Console.WriteLine("data added to file successfully");
                }
                else
                {
                    File.AppendAllText(fPath, data);
                    Console.WriteLine("data added to file successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
    public class Ques2
    {
        public string FirstName { get; set; }
        public string Email { get; set; }

        public string  getDetails => $"{FirstName} {Email}";
        
        public static void Validation()
        {
            Ques2 p = new Ques2();
        FName:
            Console.WriteLine("Enter the First Name");
            string fName=Console.ReadLine();
            string pattern = @"^[A-Z][a-zA-Z0-9]{2}";
            var result = Regex.IsMatch(fName, pattern);
            if (!result)
            {
                Console.WriteLine("Invalid Firstname starting with Capital letter  minimum 3 or more letters ");
                goto FName;

            }
            else
            {
                p.FirstName = fName;
            }

        Email:
            Console.WriteLine("Enter the Email");
            string email=Console.ReadLine();
            pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z.-]{2,6}$";

            result = Regex.IsMatch(email, pattern);
            if (!result)
            {
                Console.WriteLine("Invalid Email  ");
                goto Email;

            }
            else
            {
                p.Email = email;
            }

            Console.WriteLine($" Details of Person {p.getDetails}"); 
            Console.WriteLine();
        }
    }
    
    public class Product
    {
        public string ProName { get; set; }
        public string ProDesc { get; set; }
        public double ProRating { get; set; }
        public int ProPrice { get; set; }
       
        public Product(string name, string disc ,double rating , int price) {
            this.ProName = name;
            this.ProDesc = disc;        
            this.ProRating = rating;
            this.ProPrice = price;
        }

        public string getDetails => $" name: {ProName} Desc: { ProDesc } Rating : {ProRating} Price {ProPrice } ";
        public  Product() { }
    }
    public class que3
    {
        public static void ProductManagement()
        {

            List<Product> products = new List<Product>();

            while (true)
            {
                Console.WriteLine("Press 1. to Insert Product data");
                Console.WriteLine("Press 2. to fetch the  product By name");
                Console.WriteLine("Press 3. to Fetch  Product by rating");
                Console.WriteLine("Press 4. to Fetch the product by Price");
                Console.WriteLine("Press 5. to Display product");
                Console.WriteLine("Press 6. to exit");
                Console.WriteLine("Enter the choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine();
                        InsertData(products);
                        break;
                    case 2:
                        Console.WriteLine();
                        ProductByName(products);
                        break;
                    case 3:
                        Console.WriteLine();
                        ProductbyRating(products);
                        break;
                    case 4:
                        Console.WriteLine();
                        ProductbyPrice(products);
                        break;
                    case 5:
                        Console.WriteLine();
                        DisplayProduct(products);
                        break;

                    case 6:
                        Console.WriteLine();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input ");
                        break;
                }

            }
        }

        public static void InsertData(List<Product> products)
        {
            Console.WriteLine("Enter the How many product you want insert");
            int size = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {

                Console.WriteLine("Enter the name of product ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Desc of product ");
                string disc = Console.ReadLine();
                Console.WriteLine("Enter the rating of product ");
                double rating = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Price of product ");
                int price = Convert.ToInt32(Console.ReadLine());

                Product p1 = new Product(name, disc, rating, price);
                products.Add(p1);
            }
        }

        public static void ProductByName(List<Product> products)
        {
            if (products == null || products.Count == 0)
            {
                Console.WriteLine("List is Empty add some data");
                return;
            }

            Console.WriteLine("Enter the product name You want fetch details");
            string Name = Console.ReadLine();
            

            foreach (Product product in products)
            {
                if (product.ProName.ToLower().Contains(Name))
                {
                    Console.WriteLine(product.getDetails);

                }
                else
                {
                    Console.WriteLine("No Name found");
                    return;
                }
                
            }
        }

        public static void ProductbyRating(List<Product> products)
        {
            if (products == null || products.Count == 0)
            {
                Console.WriteLine("List is Empty add some data");
                return;
            }


            var pro = products.Max(p=>p.ProRating);

            foreach (Product product in products)
            {
                if (product.ProRating.Equals(pro))
                {
                    Console.WriteLine(product.getDetails);
                    Console.WriteLine();
                }
                
            }
        }


        public static void ProductbyPrice(List<Product> products)
        {
            if (products == null || products.Count == 0)
            {
                Console.WriteLine("List is Empty add some data");
                return;
            }

            var pro = from i in products
                      where i.ProPrice >= 2000 && i.ProPrice <= 5000
                      select i;


            if(pro.Count()==0)
            {
                Console.WriteLine("No product with range from 2000 to 5000");
            }

            foreach (var item in pro)
            {
                Console.WriteLine($" {item.getDetails}");
            }
        }
   
        public static void DisplayProduct(List<Product> products)
        {
            if (products == null || products.Count == 0)
            {
                Console.WriteLine("List is Empty add some data");
                return;
            }

            foreach (var item in products)
            {
                Console.WriteLine(item.getDetails);
                Console.WriteLine();
            }

        }
    }
    public  class Program
    {
        static void Main(string[] args)
        {

            while(true)
            {
                Console.WriteLine("press 1 for Que1");
                Console.WriteLine("press 2 for Que2");
                Console.WriteLine("press 3 for Que3");
                Console.WriteLine("prees 4 to exit");
                Console.WriteLine("Which question you want to check");
                int Check=Convert.ToInt32(Console.ReadLine());
                switch(Check)
                {
                    case 1: Console.WriteLine();
                        Que1.FileOperation();
                        break; 
                case 2: Console.WriteLine();
                        Ques2.Validation();
                        break;
                case 3: Console.WriteLine();
                        que3.ProductManagement();
                        break;
                case 4  : Console.WriteLine();
                        Environment.Exit(0);
                        break;
                default: Console.WriteLine();
                        break;
                }
            }
            
            
        }
    }

}
