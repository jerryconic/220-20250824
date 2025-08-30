﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ap07
{
    internal class Person
    {
        private string _id, _name;
        public void Display()
        {
            Console.WriteLine($"Id:{_id}, Name:{_name}");
        }
        public Person(string id, string name)
        {
            this._id = id;
            this._name = name;
        }
    }
}
