using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C__Advanced
{
    public class user
    {
      public string FirstName {  get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public void Data()
        {
            int newPN; string fname; string lname;
            Console.Write("Enter Phone Number: ");
            newPN = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter  First name: ");
            fname = Console.ReadLine();
            Console.Write("Enter  Last name: ");
            lname = Console.ReadLine();
            this.FirstName = fname;
            this.LastName = lname;
            this.PhoneNumber = newPN;
        }
    }
}
