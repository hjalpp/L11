using System;

namespace Z1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();

            human.Display();

            human.SetBody("Muskularne ciało");

            human.SetHead("Owalna");

            human.Display();

            human = null;

            //Console.WriteLine(human.GetHead());
        }
    }
}
