using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VDFramework.Service;

namespace VDFramwork.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var personService = new PersonService();
            var x = personService.GetUser(1);
            Assert.IsNotNull(x);

        }
    }
}
