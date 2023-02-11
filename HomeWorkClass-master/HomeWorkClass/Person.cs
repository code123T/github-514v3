using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkClass
{
    class Person
    {
        public Person()
        {
            this.Address = new List<string>();
            this.Phones = new List<string>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<string> Phones { get; set; }
        public List<string> Address { get; set; }
        public string Gender { get; set; }

        public void AddPhones(string new_PhoneNumber)
        {
            this.Phones.Add(new_PhoneNumber);
        }
        public void AddAddress(string new_address)
        {
            this.Address.Add(new_address);
        }

        public void WritePersonInformation()
        {
            StringBuilder info = new StringBuilder();
            info.Append("Adi" + this.Name + "\n");
            info.Append("Soyadi" +  this.Surname + "\n");
            info.Append("Ata adi" +  this.FatherName + "\n");
            info.Append("Email" +  this.Email + "\n");
            info.Append("Password" + this.Password + "\n");
            for (int i = 0; i < this.Address.Count; i++)
            {
                info.Append($"Address{i + 1}" + this.Address[i] + "\n");
            }for (int i = 0; i < this.Phones.Count; i++)
            {
                info.Append($"Phones{i + 1}" + this.Phones[i] + "\n");
            }

            Console.WriteLine(info);
            


        }
    }
}
