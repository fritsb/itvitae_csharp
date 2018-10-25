using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            person.SetFirstName("Bill");
            person.SetLastName("Gates");
            person.CurrentPlace = "Amsterdam";

            Console.WriteLine(person.GetDetails() );

            RandomClass rc = new RandomClass(person);
            rc.DoSomethingWithPerson();
            person = rc.GetUpdatedPerson();

            Console.WriteLine(person.GetDetails());

            Console.ReadLine();
        }
    }
}
