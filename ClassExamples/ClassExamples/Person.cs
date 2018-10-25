using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples
{
    class Person
    {
        private string firstName;
        private string lastName;


        public string PlaceOfBirth { get; set; }


        private string currentPlace;
        public string CurrentPlace 
        {
            get
            {
                return this.currentPlace;
            }
            set
            {
                this.currentPlace = value;
            }
        }

        public string GetFirstName()
        {
            return this.firstName;
        }

        public void SetFirstName(string newName)
        {
            this.firstName = newName;
        }

        public string GetLastName()
        {
            return this.lastName;
        }

        public void SetLastName(string newName)
        {
            this.lastName = newName;
        }

        public string GetFullName()
        {
            //return this.GetFirstName() + " " + this.GetLastName();


            return Utils.ToUpperCase(this.GetFirstName()) + " " + Utils.ToLowerCase(this.GetLastName());
        }

        public string GetDetails()
        {
            return this.GetFullName() + " / " + this.PlaceOfBirth + " / " + this.CurrentPlace;
        }
 
    }
}
