﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddresBook
{
    public  class Contactdetails
    {
        public string firstName;
        public string lastName;
        public string email;
        public string phone;
        public string address;
        public string city;
        public string state;
        public string zip;
        public Contactdetails(string firstName , string lastName ,  string email, string phone , string address , string city , string state , string zip)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;

            
        }

        
    }
}
