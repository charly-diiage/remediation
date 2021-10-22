using ClassLibrary1.Container;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1
{
    [TestClass]
    public class ContainerTests
    {
        [TestMethod]
        public void TestInjectionContainer()
        {
            CinemaContainer cinema = new CinemaContainer();
            SingletonContainer s1 = new SingletonContainer();
            SingletonContainer s2 = new SingletonContainer();
            Assert.AreEqual(null, s1.GetInstance());
            s1.InstanceSingleton(cinema);
            Assert.AreEqual(cinema, s1.GetInstance());
            Assert.AreEqual(cinema, s2.GetInstance());
        }

        [TestMethod]
        public void TestInjectionScope()
        {
            CinemaContainer cinema = new CinemaContainer();
            Scope sc = new Scope();
            sc.InstanceScope(cinema);
            Assert.AreEqual(cinema, sc.GetInstance());
            Scope sc2 = new Scope();
            Assert.AreNotEqual(null, sc2.GetInstance());
            Assert.AreNotEqual(cinema, sc2.GetInstance());
        }

        [TestMethod]
        public void TestInjectionTransient()
        {
            CinemaContainer cinema = new CinemaContainer();
            Transient t = new Transient();
            t.InstanceTransient(cinema);
            Assert.AreNotEqual(null, t.GetInstance());
            Assert.AreNotEqual(cinema, t.GetInstance());
        }
    }
}
