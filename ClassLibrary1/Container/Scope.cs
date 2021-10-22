using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1.Container
{
    public class Scope
    {
        private static Dictionary<Scope, object> keyValuePairs = new Dictionary<Scope, object>();
        private static object monObjet;

        public Scope()
        {

        }

        public void InstanceScope(object unObjet)
        {
            monObjet = unObjet;
            keyValuePairs.Add(this, unObjet);
        }

        public object GetInstance()
        {
            if (keyValuePairs.ContainsKey(this))
            {
                return keyValuePairs.GetValueOrDefault(this);
            }
            else
            {
                monObjet = monObjet.GetType().GetConstructors().First().Invoke(null);
                keyValuePairs.Add(this, monObjet);
                return monObjet;
            }
        }
    }
}
