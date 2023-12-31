﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private List<Node> children = new List<Node>();
        private Person person;

        public Person Person{
            get
            {
                return this.person;
            }
        }

        public ReadOnlyCollection<Node> Children {
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(Person person)
        {
            this.person =person;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public void ResetVisited()
        {
            if (this.person != null)
            {
                this.person.ResetVisited();
            }

            foreach (var child in this.children)
            {
                child.ResetVisited();
            }
        }
    }
}
