using NUnit.Framework;
using RTrimApp;

namespace RTrim
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RTrimWithRigthSpace()
        {
            
            Program program = new Program();
            string rightTrimTest = "Hola ";

            Assert.That(() => program.RTrim(rightTrimTest), Is.EqualTo("Hola"));

        }

        public void RTrimWithSpacesBothSides()
        {
            
            Program program = new Program();
            string rightTrimTest = " Hola ";

            Assert.That(() => program.RTrim(rightTrimTest), Is.EqualTo(" Hola"));

        }

        public void RTrimWithSentence()
        {
            
            Program program = new Program();
            string rightTrimTest = "Hola Amigo ";

            Assert.That(() => program.RTrim(rightTrimTest), Is.EqualTo("Hola Amigo"));

        }

        public void RTrimWithNullValues()
        {
            
            Program program = new Program();

            Assert.That(() => program.RTrim(null), Is.EqualTo(""));

        }

    }
}