using System;
using System.Collections.Generic;
using System.Text;

namespace Z2
{
    internal class BusDriver
    {
        private Clothes clothes;
        private Hat hat;

        public void WearHat(Hat hat)
        {
            this.hat = hat;
        }
        public void WearClothes(Clothes clothes)
        {
            this.clothes = clothes;
        }
        public void Show()
        {
            Console.WriteLine($"Bus Driver: ({clothes}, {hat})");
        }

    }
}
