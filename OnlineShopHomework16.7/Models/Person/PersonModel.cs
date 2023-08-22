using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopHomework16._7.Models.Person
{
    public class PersonModel
    {
        private string firstname = "";
        public string Firstname 
        { 
            get { return this.firstname; } 
            set
            {
                if (this.firstname != value)
                {
                    this.firstname = value;
                }
            }
        }

        private string surname = "";
        public string Surname 
        {
            get { return this.surname; }
            set
            {
                if (this.surname != value)
                {
                    this.surname = value;
                }
            }
        }

        private string lastname = "";
        public string Lastname
        {
            get { return this.lastname; }
            set
            {
                if (this.lastname != value)
                {
                    this.lastname = value;
                }
            }
        }

        public PersonModel(string firstName, string surname, string lastname)
        {
            this.Firstname = firstname;
            this.Surname = surname;
            this.Lastname = lastname;
        }
    }
}
