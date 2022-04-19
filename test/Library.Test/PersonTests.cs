using NUnit.Framework;
using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        public string idValid;
        public Person personaVal;

        [SetUp]
        public void Setup()
        {
            string idValid = "5.334.282-7";
            personaVal = new Person("Pilar Machado", idValid);
        }

        [Test]
        public void NotValidNameTest() // Cambiá el nombre para indicar qué estás probando
        {
            Person personaTes = new Person( null , "5.334.282-7");
            Assert.AreEqual(personaTes.Name, null);
        }
        [Test]
        public void NotValidIdTest() // Cambiá el nombre para indicar qué estás probando
        {
            Person personaTes = new Person( "Pilar Machado" , "5.334.282-7");
            Assert.AreNotEqual(idValid, personaTes.ID);
        }
        [Test]
        public void ValidIdTest() // Cambiá el nombre para indicar qué estás probando
        {
            string idTes = "5.334.282-7";
            Person personaTes = new Person ("Pilar Machado", idTes);
            Assert.AreEqual(personaTes.ID, idTes);
        }
    }
}