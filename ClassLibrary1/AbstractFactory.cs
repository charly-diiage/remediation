using System;
using System.Collections.Generic;
using System.Drawing;

namespace ClassLibrary1
{
    public abstract class AbstractFactory
    {
        public abstract Space createspace(AddItemsInProps item);
    }
}

