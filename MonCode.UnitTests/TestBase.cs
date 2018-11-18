using Moq;
namespace MonCode.UnitTests
{
    public class TestBase
    {
        public int Test(string valuerATest)
        {
            Mock<IConsole> consoleMock = new Mock<IConsole>();

            consoleMock.Setup(e => e.ReadLine()).Returns(valuerATest);

            Compteur monCompter = new Compteur(consoleMock.Object);
            monCompter.Text = valuerATest;
            return monCompter.CompteNombreA();
        }
    }
}