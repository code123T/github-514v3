using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkClass
{
    class ManagePerson
    {
        public void PersonManager()
        {

            Person person1 = new Person();
            Console.WriteLine("Musterinin adini giriniz : ");
            person1.Name = Console.ReadLine();
            Console.WriteLine("Musterinin soyadini giriniz : ");
            person1.Surname = Console.ReadLine();
            Console.WriteLine("Musterinin ata adini giriniz : ");
            person1.FatherName = Console.ReadLine();
            Console.WriteLine("Musterinin cinsiyyetini daxil edin (male/female) : ");
            person1.Gender = Console.ReadLine();


            Console.WriteLine("Musterinin email giriniz : ");
            person1.Email = Console.ReadLine();

            Console.WriteLine("Musterinin password giriniz: ");
            person1.Password = Console.ReadLine();

            Console.WriteLine("Musterinin telefonunu daxil edin : ");
            string response = string.Empty;
            do
            {
                string telefon = Console.ReadLine();
                person1.AddPhones(telefon);
                Console.WriteLine("Yeni telefon nomresi varmi (he/yox) : ");
                response = Console.ReadLine();

            } while (response == "he");

            Console.WriteLine("Musterinin addresini daxil edin : ");
            string responseAdress = Console.ReadLine();
            do
            {
                string Address = Console.ReadLine();
                person1.AddAddress(Address);
                Console.WriteLine("Yeni address varmi (he/yox) : ");
                responseAdress = Console.ReadLine();


            } while (responseAdress == "he");

            person1.WritePersonInformation();

        }
    }
    }

