using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnitTests
{

    [TestFixture]
    class XML_U_Test
    {
        [Test]
        public void PositiveTest()
        {
            int x = 2;
            int y = 2;
            Assert.Equals(x,y);


        }
        [Test]
        public void NegitiveTest()
        {
            int x = 2;
            int y = 3;
            Assert.Equals(x, y);


        }
    }
}
