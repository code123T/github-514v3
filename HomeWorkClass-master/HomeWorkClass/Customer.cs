using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkClass
{
    class Customer : Person
    {

        public DateTime DateOfBirthday { get; set; }
        public string Phone { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

    }
}
