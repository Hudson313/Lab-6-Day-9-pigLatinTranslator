using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_6_Day_9_pigLatinTranslator;

namespace TranslatorTest
{
    [TestClass]
    public class PigLatinTranslatorTest
    {
        [TestMethod]
        public void TestThatAppleTranslatesToAppleway()
        {
            string toTranslate = "apple";
            Translator brad = new Translator();
            string translatedString = brad.Translate(toTranslate);
            Assert.AreEqual("appleway", translatedString);
        }
        //laptop red scrap
       [TestMethod]
       public void TestThatLaptopTranslatestoAptopay()
        
        { 
            string toTranslate = "laptop";
            Translator chris = new Translator();
            string translatedString = chris.Translate(toTranslate);
            Assert.AreEqual("aptoplay", translatedString);
        }
        [TestMethod]
        public void TestThatBreadTranslatestoEadbray()
        {
            string toTranslate = "bread";
            Translator nikki = new Translator();
            string translatedString = nikki.Translate(toTranslate);
            Assert.AreEqual("eadbray", translatedString);
        }

        [TestMethod]
        public void TestThatScrapTranslatestoApscray()
        {
            string toTranslate = "scrap";
            Translator Gabe = new Translator();
            string translatedString = Gabe.Translate(toTranslate);
            Assert.AreEqual("apscray", translatedString);             
        }

    }
}
