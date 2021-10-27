using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class VisitorAge :VisitorBase
    {
        
        public int Total {get; set;} = 0; 

        
        public override void Visit(Node node)
        {
            this.Total+=node.Person.Age;
            foreach(Node item in node.Children)
            {
                item.Accept(this);
                //Console.WriteLine($"{this.Total}");
             }
        } 
    }
}
