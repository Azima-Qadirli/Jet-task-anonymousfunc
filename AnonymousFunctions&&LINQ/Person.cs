using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousFunctions__LINQ
{
    public   class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public static List<Person> person = new();
        public Person(int age,string name)
        {
            Age = age;
            person.Add(this);
            Name = name;
        }
        public static  List<Person> GetPeople()
        {
            return person;
        }
    }
}
