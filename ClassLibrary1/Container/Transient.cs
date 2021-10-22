using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1.Container
{
    public class Transient
    {
        private static object monObjet;

        public Transient()
        {

        }

        public void InstanceTransient(object unObjet)
        {     
            monObjet = unObjet;

        }

        public object GetInstance()
        {
            return monObjet = monObjet.GetType().GetConstructors().First().Invoke(null);

        }
    }
}
