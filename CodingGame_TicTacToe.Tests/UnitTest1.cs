using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CodingGame_TicTacToe.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_Empty()
        {
            Mock<IConsole> mockConsole = new Mock<IConsole>();
            mockConsole.SetupSequence(e => e.ReadLine())
                .Returns("-1 -1")
                .Returns("0");
            Game game = new Game(mockConsole.Object);
            string value = game.Turn();
            Assert.AreEqual("", value);
        }

        [TestMethod]
        public void TestMethod1()
        {
            Mock<IConsole> mockConsole = new Mock<IConsole>();

            string writeLineValue = "";

            mockConsole.SetupSequence(e => e.ReadLine())
                .Returns("-1 -1")
                .Returns("1")
                .Returns("4 4");

            mockConsole.Setup(e => e.WriteLine(It.IsAny<string>()))
                .Callback<string>(parameter => writeLineValue = parameter);

            Game game = new Game(mockConsole.Object);

            string value = game.Turn();
            Assert.AreEqual("4 4", value);
            Assert.AreEqual("4 4", writeLineValue);
        }
    }
}