using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C__Advanced
{
    public class Contact : user
    {
        public static List<user> users = new List<user>
        {
        new user { FirstName = "Hary", LastName ="Poter"  , PhoneNumber = 2042050},
        new user { FirstName = "Sansa",  LastName ="Stark" , PhoneNumber = 2042060},
        new user { FirstName = "Charlie", LastName= "chaplin"  , PhoneNumber = 2042040 },
        new user { FirstName = "David", LastName= "Martin"  , PhoneNumber = 2042020 },
        new user { FirstName = "George", LastName= "David", PhoneNumber = 2042010 },
        new user { FirstName = "Jon", LastName = "Snow" , PhoneNumber = 2042000 },
        new user { FirstName = "Teryon", LastName= "Lansiter" , PhoneNumber = 2042030},
        new user { FirstName = "Jamy", LastName="Lansiter" , PhoneNumber =2041020}
        };

        public static void add()
        {
            user new_user = new user();
            new_user.Data();
            Contact.users.Add(new_user);
            Console.WriteLine();
            Console.WriteLine(" Contact added succesfully ");
            Console.WriteLine("===========================");
            Console.WriteLine();
        }
        public static void edit()
        {
            List<user> users = Contact.users;
            int PN;
            Console.WriteLine(" Enter The Phone Number To Be Searched : ");
            PN = Convert.ToInt32(Console.ReadLine());
            user user1 = users.Find(x => x.PhoneNumber == PN);
            if (user1 == null)
            {
                Console.WriteLine();
                Console.WriteLine($" Unvalid Phone Number ");
                Console.WriteLine("===========================");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Current Contact Details : ");
                Console.WriteLine($"  {user1.FirstName} {user1.LastName} >>  {user1.PhoneNumber} ");
                Console.Write("Is this The User (Y/N) :");
                char Check;
                Check = Convert.ToChar(Console.ReadLine());
                if (Check == 'Y')
                {
                    user1.Data();
                    Console.WriteLine();
                    Console.WriteLine("Contact Edited Succesfully");
                    Console.WriteLine("===========================");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(" Process Cancled");
                    Console.WriteLine("===========================");
                    Console.WriteLine();
                }
            }
        }
        public static void delete()
        {
            Console.WriteLine("Enter The Phone Number To Be Searched : ");
            int Remove_user_Number;
            Remove_user_Number = Convert.ToInt32(Console.ReadLine());
            user Remove_user = Contact.users.Find(x => x.PhoneNumber == Remove_user_Number);
            if (Remove_user == null)
            {
                Console.WriteLine();
                Console.WriteLine("Unvaild Contact Numnber ");
                Console.WriteLine("===========================");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Contact To be Deleted : ");
                Console.WriteLine($"  {Remove_user.FirstName} {Remove_user.LastName} >>  {Remove_user.PhoneNumber} ");
                Console.Write("Is this The User (Y/N) :");
                char Check;
                Check = Convert.ToChar(Console.ReadLine());
                if (Check == 'Y')
                {
                    Contact.users.Remove(Remove_user);
                    Console.WriteLine();
                    Console.WriteLine("Contact Removed Succefuly");
                    Console.WriteLine("===========================");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(" Process Cancled");
                    Console.WriteLine("===========================");
                    Console.WriteLine();
                }

            }
        }
        public static void Displayall()
        {
            List<user> users = Contact.users;
            foreach (user user in users)
            {
                Console.WriteLine($"  {user.FirstName} {user.LastName} >> {user.PhoneNumber} ");
            }
        }
        public static void Run_Programm()
        {
            int process = 0;
            Console.WriteLine("1 - ADD NEW Contact");
            Console.WriteLine("2 - UPDATE  Contact ");
            Console.WriteLine("3 - DELETE  Contact");
            Console.WriteLine("4 - Show All Contacts");
            Console.WriteLine("5 - Exit");
            do {
                Console.WriteLine();
                Console.Write("Enter your choice : ");
                process = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (process == 1)
                {
                    add();
                }
                else if (process == 2)
                {
                    Contact.edit();
                }
                else if (process == 3)
                {
                    delete();
                }
                else if (process == 4)
                {
                    Contact.Displayall();

                }
                else if (process == 5) { return; }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Unvalid Process Number ");
                    Console.WriteLine("===========================");
                    Console.WriteLine();
                }
            }
            while (process != 5) ;
        }
    }
} 
        
 
