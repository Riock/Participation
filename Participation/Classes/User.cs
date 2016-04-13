using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation.Classes
{
    public class User : Account
    {
        public bool HasCar { get; private set; }
        public bool HasLicence { get; private set; }
        public DateTime Birthdate { get; private set; }
        public DateTime Deregistrationdate { get; private set; }
        public List<Chat> Chats { get; private set; }
        public int HouseNumber { get; private set; }
        public string Address { get; private set; }
        public string City { get; private set; }
        public string Name { get; private set; }
        public string Phone { get; private set; }
        public string Picture { get; private set; }
        public string Zipcode { get; private set; }

        public User(int id, string username, string email, string password, string name, string phone, string address, int houseNumber, string city, string zipCode, bool hasCar, bool hasLicence, DateTime birthdate, string picture, string userType)
            : base(id, username, email, password)
        {

            this.Name = name;
            this.Phone = phone;
            this.Address = address;
            this.HouseNumber = houseNumber;
            this.City = city;
            this.Zipcode = zipCode;
            this.HasCar = hasCar;
            this.HasLicence = hasLicence;
            this.Birthdate = birthdate;
            //this.Picture = picture;
            //this.UserType = userType;
        }
       
    }
}
