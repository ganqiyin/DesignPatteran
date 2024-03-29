﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.AbstractFactory.Factory
{
    public abstract class Link : Item
    {
        protected string Url;

        public Link(string caption, string url)
            : base(caption)
        {
            Url = url;
        }
    }
}
