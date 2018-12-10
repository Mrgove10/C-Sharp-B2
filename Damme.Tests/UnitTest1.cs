using Damme.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Damme.Tests
{
    [TestClass]
    public class UnitTest1
    {
        #region Tests Pions

        [TestMethod]
        public void Test_Creation_Pion()
        {
            Pion P = new Pion(1, 2, 'b');
            Assert.IsTrue(P.PlayerSign == 'b');
        }

        [TestMethod]
        public void Test_Creation_Pion_X()
        {
            Pion P = new Pion(1, 2, 'b');
            Assert.IsTrue(P.X == 1);
        }

        [TestMethod]
        public void Test_Creation_Pion_Y()
        {
            Pion P = new Pion(1, 2, 'b');
            Assert.IsTrue(P.Y == 2);
        }

        #endregion Tests Pions

        #region Tests PlayingField

        [TestMethod]
        public void Test_Creation_Playing_Field_100()
        {
            PlayfieldGenerator pg = new PlayfieldGenerator();
            var f = pg.GeneratePlayField(10);
            Assert.IsTrue(f.Length == 100);
        }

        [TestMethod]
        public void Test_Creation_Playing_Field_0()
        {
            PlayfieldGenerator pg = new PlayfieldGenerator();
            var f = pg.GeneratePlayField(0);
            Assert.IsTrue(f.Length == 0);
        }

        #endregion Tests PlayingField

        #region Tests Utils

        [TestMethod]
        public void Test_Split_2()
        {
            Utils U = new Utils();
            var result = U.StringSpliter("23 4");
            Assert.IsTrue(result[0] == 23 && result[1] == 4);
        }

        [TestMethod]
        public void Test_Split_3()
        {
            Utils U = new Utils();
            var result = U.StringSpliter("45 6 55");
            Assert.IsTrue(result[0] == 45 && result[1] == 6);
        }

        #endregion Tests Utils

        #region Tests Game

        [TestMethod]
        public void Test_Player_Switch_0()
        {
            Game G = new Game(new TrueConsole());
            var result = G.SwitchPlayer('0');
            Assert.IsTrue(result == '1');
        }

        [TestMethod]
        public void Test_Player_Switch_1()
        {
            Game G = new Game(new TrueConsole());
            var result = G.SwitchPlayer('1');
            Assert.IsTrue(result == '0');
        }

        [TestMethod]
        public void Test_Player_Switch_Over()
        {
            Game G = new Game(new TrueConsole());
            var result = G.SwitchPlayer('3');
            Assert.IsTrue(result == ' ');
        }

        #endregion Tests Game
    }
}