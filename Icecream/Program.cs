using System;

namespace Icecream
{
    class Program
    {
        static void Main(string[] args)
        {
            IIcecream iceCream = new VanillaIceCream();
            iceCream = new Honey(iceCream);
            iceCream.AddHoney();
        }
    }
}
