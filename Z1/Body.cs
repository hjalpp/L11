using System;
using System.Collections.Generic;
using System.Text;

namespace Z1
{
    internal class Body
    {
        public string name;

        public Body(string name) => this.name = name;
        public override string ToString()
        {
            return $"Body: {name}";
        }
    }
}
