using Exercice_9_1.Dll;
using Exercice_9_1.Fake;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Exercice_9_1.UnitTests
{
    [TestClass]
    public class MainTests
    {
        #region TestCreation

        /// <summary>
        /// Test de creation d'un objet pierre
        /// </summary>
        [TestMethod]
        public void Test_Creation_Pierre()
        {
            //TODO: corrrect !
            Mock<IConsole> mockConsole = new Mock<IConsole>();
            var mockRandom = new Mock<IRandom>();
            Game g = new Game(mockConsole.Object, mockRandom.Object);

            mockConsole.Setup(x => x.ReadLine()).Returns("0");
            Assert.IsTrue(g.RecupererValeurJoueur() == ChiFouMi.Pierre);
        }

        /// <summary>
        /// Test de creation d'un objet feuille
        /// </summary>
        [TestMethod]
        public void Test_Creation_Feuille()
        {
            Mock<IConsole> mockConsole = new Mock<IConsole>();
            Mock<IRandom> mockRandom = new Mock<IRandom>();
            Game g = new Game(mockConsole.Object, mockRandom.Object);

            mockConsole.Setup(x => x.ReadLine()).Returns("1");
            Assert.IsTrue(g.RecupererValeurJoueur() == ChiFouMi.Feuille);
        }

        /// <summary>
        /// Test de creation d'un objet ciseau
        /// </summary>
        [TestMethod]
        public void Test_Creation_Ciseaux()
        {
            var mockConsole = new Mock<IConsole>();
            var mockRandom = new Mock<IRandom>();
            Game g = new Game(mockConsole.Object, mockRandom.Object);
            mockConsole.Setup(x => x.ReadLine()).Returns("2");
            Assert.IsTrue(g.RecupererValeurJoueur() == ChiFouMi.Ciseaux);
        }

        /// <summary>
        /// Test de creation d'un objet puit
        /// </summary>
        [TestMethod]
        public void Test_Creation_Puit()
        {
            var mockConsole = new Mock<IConsole>();
            var mockRandom = new Mock<IRandom>();
            Game g = new Game(mockConsole.Object, mockRandom.Object);

            mockConsole.Setup(x => x.ReadLine()).Returns("3");

            Assert.IsTrue(g.RecupererValeurJoueur() == ChiFouMi.Puit);
        }

        #endregion TestCreation

        #region Test Victoire

        /// <summary>
        /// test de victoire de la pierre
        /// </summary>
        [TestMethod]
        public void Test_Victoire_Pierre()
        {
            Pierre p = new Pierre();
            Assert.IsTrue(p.Bat(ChiFouMi.Ciseaux));
        }

        /// <summary>
        /// test de victoire de la Feuille
        /// </summary>
        [TestMethod]
        public void Test_Victoire_Feuille()
        {
            Feuille f = new Feuille();
            Assert.IsTrue(f.Bat(ChiFouMi.Pierre) && f.Bat(ChiFouMi.Puit));
        }

        /// <summary>
        /// test de victoire du Ciseau
        /// </summary>
        [TestMethod]
        public void Test_Victoire_Ciseaux()
        {
            Ciseaux c = new Ciseaux();
            Assert.IsTrue(c.Bat(ChiFouMi.Feuille));
        }

        /// <summary>
        /// test de victoire du puit
        /// </summary>
        [TestMethod]
        public void Test_Victoire_Puit()
        {
            Puit p = new Puit();
            Assert.IsTrue(p.Bat(ChiFouMi.Ciseaux) && p.Bat(ChiFouMi.Pierre));
        }

        #endregion Test Victoire

        #region Test Get Value

        /// <summary>
        /// test de recuperation de la valeur de pierre
        /// </summary>
        [TestMethod]
        public void Test_Get_Value_Pierre()
        {
            Pierre p = new Pierre();
            Assert.IsTrue(p.Value == ChiFouMi.Pierre);
        }

        /// <summary>
        /// test de recuperation de la valeur du ciseau
        /// </summary>
        [TestMethod]
        public void Test_Get_Value_Ciseaux()
        {
            Ciseaux c = new Ciseaux();
            Assert.IsTrue(c.Value == ChiFouMi.Ciseaux);
        }

        /// <summary>
        /// test de recuperation de la valeur de la feuille
        /// </summary>
        [TestMethod]
        public void Test_Get_Value_Feuille()
        {
            Feuille f = new Feuille();
            Assert.IsTrue(f.Value == ChiFouMi.Feuille);
        }

        /// <summary>
        /// test de recuperation de la valeur du puit
        /// </summary>
        [TestMethod]
        public void Test_Get_Value_Puit()
        {
            Puit p = new Puit();
            Assert.IsTrue(p.Value == ChiFouMi.Puit);
        }

        #endregion Test Get Value

        #region test victoire

        /// <summary>
        /// test de l'egalité
        /// </summary>
        [TestMethod]
        public void Test_Gagant_Egalite()
        {
            Game g = new Game(new FakeConsole(), new FakeRandom());
            string returnValue = g.TestGagant(ChiFouMi.Ciseaux, new Ciseaux());

            Assert.IsTrue(returnValue == "Ega");
        }

        /// <summary>
        /// test du gagnant
        /// </summary>
        [TestMethod]
        public void Test_Gagant_Joueur()
        {
            Game g = new Game(new FakeConsole(), new FakeRandom());
            string returnValue = g.TestGagant(ChiFouMi.Pierre, new Ciseaux());

            Assert.IsTrue(returnValue == "Joueur");
        }

        /// <summary>
        /// test du perdant
        /// </summary>
        [TestMethod]
        public void Test_Gagant_Bot()
        {
            Game g = new Game(new FakeConsole(), new FakeRandom());
            string returnValue = g.TestGagant(ChiFouMi.Ciseaux, new Pierre());

            Assert.IsTrue(returnValue == "Ordi");
        }

        #endregion test victoire

        #region Test Bot

        /// <summary>
        /// test recuperation valeur bot pierre
        /// </summary>
        [TestMethod]
        public void Test_Recuperation_Application_Piere()
        {
            var mockRandom = new Mock<IRandom>();
            var mockConsole = new Mock<IConsole>();
            Game g = new Game(mockConsole.Object, mockRandom.Object);

            mockRandom.Setup(x => x.Next(0, 4)).Returns(0).ToString();
            Assert.IsTrue(g.RecupererValeurApplication().Value == ChiFouMi.Pierre);
        }

        /// <summary>
        /// test recuperation valeur bot feuille
        /// </summary>
        [TestMethod]
        public void Test_Recuperation_Application_Feuille()
        {
            var mockRandom = new Mock<IRandom>();
            var mockConsole = new Mock<IConsole>();
            Game g = new Game(mockConsole.Object, mockRandom.Object);

            mockRandom.Setup(x => x.Next(0, 4)).Returns(1).ToString();
            Assert.IsTrue(g.RecupererValeurApplication().Value == ChiFouMi.Feuille);
        }

        /// <summary>
        /// test recuperation valeur bot Ciseau
        /// </summary>
        [TestMethod]
        public void Test_Recuperation_Application_Ciseau()
        {
            var mockRandom = new Mock<IRandom>();
            var mockConsole = new Mock<IConsole>();
            Game g = new Game(mockConsole.Object, mockRandom.Object);

            mockRandom.Setup(x => x.Next(0, 4)).Returns(2).ToString();
            Assert.IsTrue(g.RecupererValeurApplication().Value == ChiFouMi.Ciseaux);
        }

        /// <summary>
        /// test recuperation valeur bot puit
        /// </summary>
        [TestMethod]
        public void Test_Recuperation_Application_Puit()
        {
            var mockRandom = new Mock<IRandom>();
            var mockConsole = new Mock<IConsole>();
            Game g = new Game(mockConsole.Object, mockRandom.Object);

            mockRandom.Setup(x => x.Next(0, 4)).Returns(3).ToString();
            Assert.IsTrue(g.RecupererValeurApplication().Value == ChiFouMi.Puit);
        }

        [TestMethod]
        public void Test_Recuperation_Application_null()
        {
            var mockRandom = new Mock<IRandom>();
            var mockConsole = new Mock<IConsole>();
            Game g = new Game(mockConsole.Object, mockRandom.Object);

            mockRandom.Setup(x => x.Next(0, 4)).Returns(4).ToString();
            Assert.IsTrue(g.RecupererValeurApplication() == null);
        }

        #endregion Test Bot

        /// <summary>
        /// test de l'input d'une chaine alatoire
        /// </summary>
      /*  [TestMethod]
        public void Test_Creation_Chaine_Caractere_Random()
        {
            var mockRandom = new Mock<IRandom>();
            var mockConsole = new Mock<IConsole>();
            mockConsole.Setup(x => x.ReadLine()).Returns("Foo");
            Game g = new Game(mockConsole.Object, mockRandom.Object);

            Assert.IsTrue(g.RecupererValeurJoueur() == ChiFouMi.Puit);
        }*/
    }
}