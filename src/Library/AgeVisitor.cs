using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;

namespace Library
{
    public  class AgeVisitor:Visitor
    {
        public int Age {get;private set;}
        public AgeVisitor()
        {
            Age=0;
        }
        public override void Visit(Node node) //Visita el nodo y suma la edad de la persona en ese nodo
        {
            if (node.Person!=null)
            {
                Age+=node.Person.Age;
            }
            foreach (var child in node.Children)
            {
                child.Accept(this);
            }
        }
        public override void Visit(Person person) //Visita a la persona
        {
            Age+=person.Age;
        }
    }
}