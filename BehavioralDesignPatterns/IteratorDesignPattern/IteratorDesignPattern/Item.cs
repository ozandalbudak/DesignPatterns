﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
    class Item
    {
        private string _name;
        public Item(string name)
        {
            this._name = name;
        }
        public string Name
        {
            get { return _name; }
        }
    }
}
