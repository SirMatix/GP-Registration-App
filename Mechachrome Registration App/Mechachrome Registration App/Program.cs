using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mechachrome_Registration_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Person matt = new Person("Mateusz",
                                     "Utracki-Janeta",
                                     "01/01/0001",
                                     "54 Gap Year",
                                     "CV5 5GP",
                                     "7568493923");
            Console.Write(matt.GetName());

        }
    }
}
