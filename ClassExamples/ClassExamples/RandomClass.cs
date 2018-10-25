using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples
{
    class RandomClass
    {
        private Person randomPerson;

        public RandomClass(Person newPerson)
        {
            this.randomPerson = newPerson;
        }

        public void DoSomethingWithPerson()
        {
            this.randomPerson.CurrentPlace = "";
        }

        public Person GetUpdatedPerson()
        {
            return this.randomPerson;
        }
    }
}
