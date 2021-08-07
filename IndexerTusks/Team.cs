using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerTusks
{
    class Team
    {
        Person[] person;
        public Team()
        {
            person = new Person[11];
        }
        public Person this[int index]
        {
            get
            {
                if (index >= 0 && index < person.Length)
                    return person[index];
                else
                {
                    Console.WriteLine("Ошибка!");
                    return null;
                }
            }
            set
            {
                if (index >= 0 && index < person.Length)
                    person[index] = value;
            }
        }
    }
}
