using System;
using System.Collections.Generic;
using System.Text;

namespace Z2
{
    internal class Hat
    {
        public string name;

        public Hat(string name) => this.name = name;

        public override string ToString()
        {
            return $"Hat: {name}";
        }
    }
}
