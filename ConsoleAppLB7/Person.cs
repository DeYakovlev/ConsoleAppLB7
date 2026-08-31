using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLB7
{
   
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // обязательно создаем пустой конструктор для сирреализации 
        public Person() { }   

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
