using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace henkilorekisreri
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a register 
            Personregister myFriends = new Personregister();

            // create a few person
            Person person1 = new Person();
            person1.Firstname = "Matti";
            person1.Lastname = "Mainio";
            person1.SocialSecurityNumber = "1234";

            Person person2 = new Person();
            person2 = new Person { Firstname = "Kirsi", Lastname = "Kernel", SocialSecurityNumber = "123456456"};

            // add person to collection
            myFriends.AddPerson(person1);

            myFriends.AddPerson(person2);

            // get one person from register
            Person person3 = myFriends.GetPerson(0);
            if (person3 != null)
            {
                Console.WriteLine(person3.ToString());
            }
            else
            {
                Console.WriteLine("Can't find person in that index");
            }

            string sotu = "123456456";
            Console.WriteLine("finding person with sotu" + sotu);
            Person person4 = myFriends.FindPerson(sotu);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            }
            else
            {
                Console.WriteLine("cant find person with that sotu");
            }
            myFriends.PrintData();
        }
    }
}
