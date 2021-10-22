using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class CinemaFactory : AbstractFactory //inheritance of AbstractFactory
    {
        public override Space createspace(AddItemsInProps item)
        {
            return new Cinema(item.Type);
        }
    }
}