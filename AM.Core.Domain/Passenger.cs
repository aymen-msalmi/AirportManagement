using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public string PassportNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int age { get; private set; } 
        public string TelNumber { get; set; }
        public IList<Flight> Flights { get; set; }
        public override string ToString()
        {
            return "BirthDate:" + BirthDate
                + "PassportNumber:" + PassportNumber
                + "EmailAddress:" + EmailAddress
                + "FirstName:" + FirstName
                + "LastName:" + LastName
                + "TelNumber:" + TelNumber
               ;
        }
        public Boolean CheckProfile(string nom, string prenom)
        {
            return nom == FirstName && prenom == LastName;
        }
        //public Boolean CheckProfile(string nom, string prenom, string email)
        //{
        //    return nom == FirstName && prenom == LastName && email == EmailAddress;
        //}
        public Boolean CheckProfile(string nom, string prenom, string email = null)
        {
            if (email == null)
                return nom == FirstName && prenom == LastName;

            return nom == FirstName && prenom == LastName && email == EmailAddress;
        }
        public virtual string GetPassengerType()
        {
            return "I am a passenger";
        }
        public void GetAge(DateTime birthDate, int calcultedAge =0)
        {
            calcultedAge = DateTime.Now.Year - birthDate.Year;
            age = calcultedAge;

        }
        public void GetAge(Passenger aPassenger)
        {

            aPassenger.GetAge(aPassenger.BirthDate, age);

        }

    }
}
