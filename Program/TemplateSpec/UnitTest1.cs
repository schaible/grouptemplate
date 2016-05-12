using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemplateClassNameSpace;
namespace TemplateSpec
{
    [TestClass]
    public class TemplateClassTest
    {
        [TestMethod]
        public void True_Is_True()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Text_Returns_Text()
        {
            TemplateClass temp = new TemplateClass("Hi ya");
            Assert.AreEqual(temp.text,"Hi ya");
        }

        [TestMethod]
        public void Replace_Hi_With_See()
        {
            TemplateClass temp = new TemplateClass("Hi ya");
            string result = temp.WordSwap();
            Assert.AreEqual(result, "See ya");
        }
    }
}

