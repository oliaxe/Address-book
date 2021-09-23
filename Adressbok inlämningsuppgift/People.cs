using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressbok_inlämningsuppgift
{
    public class Person
    {
        public string Namn { get; set; }
        public string Gatuadress { get; set; }
        public string Postnummer { get; set; }
        public string Postort { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
          public Person(string name, string street, string postalCode, string city, string phone, string email)
        { 
            Namn = name;
            Gatuadress = street;
            Postnummer = postalCode;
            Postort = city;
            Telefon = phone;
            Email = email; 
        }

    }
}
