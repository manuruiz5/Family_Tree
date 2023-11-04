using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;
using System.Net.Security;

namespace Library
{
    public class NameVisitor:Visitor
    {
        public string LongestName{get;private set;}
        public int NameLength{get; private set;}=0;

        public override void Visit(Node node)
        {
            foreach (var child in node.Children)
            {
                child.Accept(this);
            }
        }
        public override void Visit(Person person)
        {
            if (person.Name.Length>NameLength)
            {
                LongestName=person.Name;
                NameLength=person.Name.Length;
            }
        }
    }
}