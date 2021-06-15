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

            Assert.That(() => Program.RTrim(rightTrimTest), Is.EqualTo("Hola"));

        }

        [Test]
        public void RTrimWithSpacesBothSides()
        {
            
            Program program = new Program();
            string rightTrimTest = " Hola ";

            Assert.That(() => Program.RTrim(rightTrimTest), Is.EqualTo(" Hola"));

        }

        [Test]
        public void RTrimWithSentence()
        {
            
            string rightTrimTest = "Hola Amigo ";

            Assert.That(() => Program.RTrim(rightTrimTest), Is.EqualTo("Hola Amigo"));

        }

        [Test]
        public void RTrimWithNullValues()
        {
            
            Assert.That(() => Program.RTrim(null), Is.EqualTo(""));

        }

    }
}