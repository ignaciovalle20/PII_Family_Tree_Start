using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class VisitorNameLength :VisitorBase
    {
        
        public int MaxLength {get; set;} = 0; 

        public Person LongestName {get; set;}
        public override void Visit(Node node)
        {
            if (this.MaxLength <= node.Person.Name.Length)
            {    
                this.LongestName=node.Person;
                this.MaxLength=node.Person.Name.Length;
            }
            foreach(Node item in node.Children)
            {
                item.Accept(this);
                //Console.WriteLine($"{this.Total}");
             }
        } 
    }
}
