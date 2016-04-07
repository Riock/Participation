using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation.Classes
{
    class User : Account
    {
        public string Name { get;  set; }
        public bool HasCar { get;  set; }
        public bool HasLicence { get;  set; }
        public DateTime Birthdate { get;  set; }
        public int HouseNumber { get; set; }
        public string Zipcode { get; set; }
        //public DateTime Deregistrationdate { get; private set; }
        //public List<Chat> Chats { get; private set; }
        public string Address { get;  set; }
        public string City { get;  set; }
        public string Phone { get;  set; }
        public string Picture { get;  set; }
        public string UserType { get;  set; }

        public User(int id,string username,string email,string password,string phone, string address,int houseNumber,string city,string zipCode,bool hasCar,bool hasLicence, DateTime birthdate)
            :base(id,username,email,password)
        {
            this.Phone = phone;
            this.Address = address;
            this.HouseNumber = houseNumber;
            this.City = city;
            this.Zipcode = zipCode;
            this.HasCar = hasCar;
            this.HasLicence = hasLicence;
            this.Birthdate = birthdate;
        }
        public User(string username, string email, string password, string phone, string address, int houseNumber, string city, string zipCode, bool hasCar, bool hasLicence, DateTime birthdate)
            :this(-1,username,email,password,phone,address,houseNumber,city,zipCode,hasCar,hasLicence,birthdate)
        {

        }
    }
}
