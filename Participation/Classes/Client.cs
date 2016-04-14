using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation.Classes
{
    public class Client : User
    {
        public bool OvPossibility { get; private set; }
        public List<Request> Requests { get; private set; }
        //public int ID { get; private set; }
        public string Handicap { get; private set; }

        public Client(int id, string username, string email, string name, string password, string phone, string address, int houseNumber,
            string city, string zipCode, bool hasCar, bool hasLicence, DateTime birthdate, string picture, string userType, bool ovPossibility, string handicap)
            : base(id, username, email, name, password, phone, address, houseNumber, city, zipCode, hasCar, hasLicence, birthdate, picture, userType)
        {
            this.OvPossibility = ovPossibility;
            this.Handicap = handicap;
        }
    }
}
