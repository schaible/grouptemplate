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
            Assert.AreEqual(temp.text, "Hi ya");
        }

        [TestMethod]
        public void Replace_Hi_With_See()
        {
            TemplateClass temp = new TemplateClass("Hi ya");
            string result = temp.WordSwap();
            Assert.AreEqual(result, "See ya");
        }

        [TestMethod]
        public void Replace_All_Hi_With_See()
        {
            TemplateClass temp = new TemplateClass("Hi ya, Hi ya, Hi ya");
            string result = temp.WordSwap();
            Assert.AreEqual(result, "See ya, See ya, See ya");
        }

        [TestMethod]
        public void Use_Index_To_Find_Curly_Brace_Position()
        {
            TemplateClass temp = new TemplateClass("Hi ya, {Hi ya, Hi ya");
            int result = temp.text.IndexOf("{");
            Assert.AreEqual(result, 7 );
        }

        [TestMethod]
        public void Use_Index_To_Find_Open_Close_Position()
        {
            TemplateClass temp = new TemplateClass("Hi ya, {Hi} ya, Hi ya");
            int result1 = temp.text.IndexOf("{");
            int result2 = temp.text.IndexOf("}");
            Assert.AreEqual(result1 + result2, 17);
        }

        [TestMethod]
        public void Use_Index_To_Find_First_Word()
        {
            TemplateClass temp = new TemplateClass("Hi ya, {Hi} ya, Hi ya");
            string result = temp.WordFind();
            Assert.AreEqual(result, "{Hi}");
        }
    }
}

