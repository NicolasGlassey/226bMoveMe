using NUnit.Framework;
using MoveMe;


namespace TestMoveMe
{
    public class TestPerson
    {
        [Test]
        public void Eat_NominalCase_Success()
        {
            //given
            string expectedMessage = "Je mange";
            string actualMessage = "";
            Person person = new Person();

            //when
            actualMessage = person.Eat();

            //then
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void Drink_NominalCase_Success()
        {
            //given
            string expectedMessage = "Je bois";
            string actualMessage = "";
            Person person = new Person();

            //when
            actualMessage = person.Drink();

            //then
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void Sleep_NominalCase_Success()
        {
            //given
            string expectedMessage = "Je dors";
            string actualMessage = "";
            Person person = new Person();

            //when
            actualMessage = person.Sleep();

            //then
            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}