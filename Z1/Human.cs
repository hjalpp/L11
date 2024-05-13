using System;
using System.Collections.Generic;
using System.Text;

namespace Z1
{
    internal class Human
    {
        private Head glowa;
        private Body cialo;

        public void SetHead(string head)
        {
            glowa = new Head(head);
        }
        public void SetBody(string body)
        {
            cialo = new Body(body);
        }
        public void Display()
        {
            string informacja = $"Human: ({glowa}, {cialo})";
            Console.WriteLine(informacja);
        }
        public Head GetHead()
        {
            return glowa;
        }
        public Body GetBody()
        {
            return cialo;
        }
    }
}
