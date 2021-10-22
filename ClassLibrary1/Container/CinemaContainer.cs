using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Container
{
    public class CinemaContainer
    {
        public int nbFilms;
        public string nom;
        public string adresse;

        public CinemaContainer()
        {
            nbFilms = 6;
            nom = "ciné du coin";
            adresse = "avenue du ciné";
        }
    }
}
