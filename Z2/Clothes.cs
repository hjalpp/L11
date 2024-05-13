using System;
using System.Collections.Generic;
using System.Text;

namespace Z2
{
    internal class Clothes
    {
        public string name;

        public Clothes(string name) => this.name = name;
        public override string ToString()
        {
            return $"clothes: {name}";
        }
    }
}
