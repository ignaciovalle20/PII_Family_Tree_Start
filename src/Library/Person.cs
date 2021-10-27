﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Person
    {
        private string name;

        private int age;


        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name{get; set;}
        public int Age{get; set;}    
                
    }
}