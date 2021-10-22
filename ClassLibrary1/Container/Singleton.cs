using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Container
{
    public class SingletonContainer
    {
        private static object monObjet;
        private static SingletonContainer instanceSingleton;

        public SingletonContainer()
        {

        }

        public SingletonContainer InstanceSingleton(object newObject)
        {
            if (instanceSingleton == null)
            {
                instanceSingleton = new SingletonContainer();
                monObjet = newObject;
            }
            return instanceSingleton;
        }

        public object GetInstance()
        {
            return monObjet;
        }
    }
}
