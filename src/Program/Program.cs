using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
          
      
            Person p1 = new Person("Abraham", 80);
            Person p2 = new Person("Mona", 82);
            Person p3 = new Person("Homero", 42);
            Person p4 = new Person("Jackie",78);
            Person p5 = new Person("Clancy",77);
            Person p6 = new Person("Marge",41);
            Person p7 = new Person("Bart",10);
            Person p8 = new Person("Lisa",9);

            Node n1 = new Node(1,new Person("Abraham", 80));
            Node n2 = new Node(2,new Person("Mona", 82));
            Node n3 = new Node(3,new Person("Homero", 42));
            Node n4 = new Node(4,new Person("Jackie",78));
            Node n5 = new Node(5,new Person("Clancy",77));
            Node n6 = new Node(6,new Person("Marge",41));
            Node n7 = new Node(7,new Person("Bart",10));
            Node n8 = new Node(8,new Person("Lisa",9));

         
            n1.AddChildren(n3);
            n2.AddChildren(n3);

            n4.AddChildren(n6);
            n5.AddChildren(n6);

            n3.AddChildren(n7);
            n3.AddChildren(n8);

            n6.AddChildren(n7);
            n6.AddChildren(n8);

            //Console.WriteLine(Convert.ToString(p1.GetAgeTotal()));
            // visitar el árbol aquí
            VisitorAge agetotal = new VisitorAge();
            agetotal.Visit(n1);
            Console.WriteLine($"Agetotal of all Nodes: {agetotal.Total}");

            VisitorNameLength longestName = new VisitorNameLength();
            longestName.Visit(n1);
            Console.WriteLine($"LongestName of all Nodes: {longestName.LongestName.Name}");
        }
    }
}
