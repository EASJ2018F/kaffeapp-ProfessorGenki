using Microsoft.VisualStudio.TestTools.UnitTesting;
using kaffe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe.Tests
{
    [TestClass()]
    public class FlatWhiteTests
    {
        [TestMethod()]
        public void MlMælkTest()
        {
            //Arrange
            var kaffe = new FlatWhite();
            //Act
            int mlMælk = kaffe.MlMælk();
            //Assert
            Assert.AreEqual(160, mlMælk);
        }

        [TestMethod()]
        public void PrisTest()
        {
            //Arrange
            var kaffe = new FlatWhite();
            //Act
            int pris = kaffe.Pris();
            //Assert
            Assert.AreEqual(45, pris);
        }

        [TestMethod()]
        public void StyrkeTest()
        {
            //Arrange
            var kaffe = new FlatWhite();
            //Act
            string styrke = kaffe.Styrke();
            //Assert
            Assert.AreEqual("mild", styrke);
        }
    }
}