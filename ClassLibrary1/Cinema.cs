using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Cinema : Space
    {
        public Cinema(string areaType)
        {
            //The sprite  of the Cinema
            this.Nom = "cinema";
            this.Type = "divertissement";
        }
    }
}