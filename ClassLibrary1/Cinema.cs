using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Cinema : Space
    {
        public Cinema(string Type)
        {
            this.Nom = "cinema";
            this.Type = "divertissement";
        }
    }
}