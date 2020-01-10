using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechachrome_Registration_App
{
    public class Person
    {
        private string name;
        private string surname;
        private string dob;
        private string address;
        private string postcode;
        private string phone;
        //private string joindate;

        Person(string name, string surname, string dob, string address, string postcode, string phone /*, string joindate*/)
        {
            this.name = name;
            this.surname = surname;
            this.dob = dob;
            this.address = address;
            this.postcode = postcode;
            this.phone = phone;
            //this.joindate = joindate;
        }

        public string GetName()
        {
            return name;
        }
        public string GetSurname()
        {
            return surname;
        }
        public string GetDob()
        {
            return dob;
        }
        public string GetAddress()
        {
            return address;
        }
        public string GetPostcode()
        {
            return postcode;
        }

        public string GetPhone()
        {
            return phone;
        }
    }
}
