using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
 
namespace LinkedLists
{
    class Person
    {
        public string Name;
        public int Age;
        public string Sex;  
        public int Height;
        public int Weight;
        public string HairColor;
        public string EyeColor;
        public string SkinColor;

        public Person next;
    }

    class PersonList
    {
        private int size;

        public PersonList()
        {
            size = 0;
        }

        public int Count
        {
            get { return size; }
        }

        public Person head;

        public int Add(Person new_person)
        {
            Person sample = new Person();

            sample = new_person;
            sample.next = head;
            head = sample;
            return size++;
        }

        public Person Get(int Position)
        {
            Person current = head;

            for (int i = 0; i < Position && current != null; i++)
                current = current.next;
            return current; 
        }
    }




}

   
