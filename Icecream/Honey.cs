using System;
using System.Collections.Generic;
using System.Text;

namespace Icecream
{
    class Honey : IceCreamDecorator,IIcecream

    {
        public Honey(IIcecream icecream) : base(icecream)
        {
        }

        public void Taste()
        {
            Console.WriteLine("Honey Added");
        }

        public void AddHoney()
        {
            Console.WriteLine("Honey Added");
        }
    }
}
