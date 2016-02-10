/* 
 * Copyright (C)
 * 
 * This file is part of the Person register project.
 * 
 * Created: <<10.2.2016>> 
 * Authors: <<Olli Korhonen>> 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace henkilorekisreri
{
    /// <summary>
    /// This class holds person objects in a collection.
    /// </summary>
    class Personregister
    {
        /// <summary>
        /// Person List stores person objects.
        /// </summary>
        private List<Person> persons;

        /// <summary>
        /// Default constructor initializes a collection
        /// </summary>
        public Personregister()
        {
            persons = new List<Person>();
        }
        /// <summary>
        /// Add a new person to collection
        /// </summary>
        /// <param name="person">person to add</param>
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        /// <summary>
        /// Returns a person to caller application
        /// </summary>
        /// <param name="index">person index in collection</param>
        /// <returns>person object</returns>
        public Person GetPerson(int index)
        {
            if (index < persons.Count)
            {
                return persons.ElementAt(index);
            }
            else
            {
                return null;
            }
        }

        public Person FindPerson(string socialSecurityNumber)
        {
            foreach(Person person in persons)
            {
                // is sotus same...
                if (socialSecurityNumber.Equals(person.SocialSecurityNumber))
                {
                    return person; //person found with that sotu
                }
            }
            return null; // person with search sotu not found..
        }

        public void PrintData()
        {
            foreach(Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
