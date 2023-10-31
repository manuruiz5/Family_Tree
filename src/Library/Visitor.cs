using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public abstract class Visitor
    {
        public string Content
        {
            get 
            {
                return this.ContenBuilder.ToString()
            }
        }

        protected StringBuilder ContentBuilder;
        public abstract void Visit(Person person);
        public abstract void Visit(Node node);
    }
}