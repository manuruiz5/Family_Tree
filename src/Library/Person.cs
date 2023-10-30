using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Person 
    {
        public string Name {get; set}
        public int Age {get; set;}

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

    }
}