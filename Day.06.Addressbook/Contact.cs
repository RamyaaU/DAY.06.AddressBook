using System;
using System.Collections.Generic;
using System.Text;

namespace Day._06.Addressbook
{
    class Contact
    {
        //varialbes
        String firstName;
        String lastName;
        String address;
        String city;
        String state;
        String phoneNumber;
        String zipCode;
        String email;

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact" /> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="address">The address.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="phoneNumber">The phone number.</param>
        /// <param name="zipCode">The zip code.</param>
        /// <param name="email">The email.</param>
        
      
        public Contact(string firstName, string lastName, string address, string city, string state, string phoneNumber, int phoneNumber1, string zipCode)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.phoneNumber = phoneNumber;
            this.zipCode = zipCode;
            this.email = email;
        }

        public Contact(string firstName, string lastName, string address, string city, string state, string zipCode, string phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public override string ToString() //this method returns the string itself
        {
            return ("FirstName : " + firstName + " LastName : " + lastName + " Address : " + address + " City : " + city + "State : " + state +
            " Zip Code :" + zipCode + " Phone Number : " + phoneNumber + " Email Id : " + email);
        }
    }
}