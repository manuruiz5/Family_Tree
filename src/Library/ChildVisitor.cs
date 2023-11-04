using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;

namespace Library
{
    public class ChildVisitor:Visitor
    {
        public Person Child{get;private set;}
        public int MaxAge{get;private set;}=int.MinValue;

        public override void Visit(Node node)
        {
            foreach (var child in node.Children)
            {
                child.Accept(this);
            }
        }
        public override void Visit(Person person)
        {
            if (person.Age > MaxAge)
            {
                Child=person;
                MaxAge=person.Age;
            }
        }
    }
} 

