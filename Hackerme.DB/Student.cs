using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerme.DB
{
    public class Student
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public int AmountToPay { get; set; }
        public int AmountPayed { get; set; }

        public Student(string id, string firstName, string lastName, DateTime dateOfBirth, string email, string city, int amountToPay, int amountPayed)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Email = email;
            City = city;
            AmountToPay = amountToPay;
            AmountPayed = amountPayed;
        }
    }
}
