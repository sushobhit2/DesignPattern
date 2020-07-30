using System;
using System.Collections.Generic;
using System.Text;

namespace Icecream
{
   abstract class IceCreamDecorator
    {
        protected IIcecream _icecream;
        public IceCreamDecorator(IIcecream icecream)
        {
            this._icecream = icecream;
        }

        public string Taste()
        {
            return _icecream.Taste();
        }
    }
}
