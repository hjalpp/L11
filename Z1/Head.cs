using System;
using System.Collections.Generic;
using System.Text;

namespace Z1
{
    internal class Head
    {
        public string name;

        public Head(string name) => this.name = name;
        public override string ToString()
        {
            return $"Head: {name}";
        }
    }
}
