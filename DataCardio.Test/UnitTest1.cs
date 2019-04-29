using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsDetermined()
        {
            int età = 20;
            double battiti = 120;

            bool risposta = false;
            bool risultato = false;

            risposta=CardioAnalisiLibrary.Class1.IsDetermined(età, battiti);

            Assert.AreEqual(risposta, risultato);


        }

        [TestMethod]
        public void Bradicardia()
        {
            
            double battiti = 50;
            string risultato = "Bradicardia";
            string risposta = "";

            risposta = CardioAnalisiLibrary.Class1.IsDetermined1(battiti);

            Assert.AreEqual(risposta, risultato);


        }

        [TestMethod]
        public void Tachicardia()
        {

            double battiti = 150;
            string risultato = "Tachicardia";
            string risposta = "";

            risposta = CardioAnalisiLibrary.Class1.IsDetermined1(battiti);

            Assert.AreEqual(risposta, risultato);


        }

        [TestMethod]
        public void calcolocalorie()
        {

            string sesso = "F";
            double età = 25;
            double peso = 70;
            double minuti = 30;
            double frequenza = 85;

            int risposta = 0;
            int risultato = 203;

            risposta = CardioAnalisiLibrary.Class1.IsDetermined2(sesso, età, peso, minuti, frequenza);

            Assert.AreEqual(risposta, risultato);


        }

        [TestMethod]
        public void calcoloSpesaEnergetica()
        {

            string andatura = "Camminata";
            double peso = 60;
            double Km = 3;
           

            int risposta = 0;
            int risultato = 90;

            risposta = CardioAnalisiLibrary.Class1.IsDetermined3(andatura, peso, Km);

            Assert.AreEqual(risposta, risultato);


        }

        [TestMethod]
        public void calcoli()
        {

            double battito1 = 85;
            double battito2 = 90;
            double battito3 = 88;

            string risposta = "";
            string risultato = "88 Normale 5 85 88 90";

            risposta = CardioAnalisiLibrary.Class1.IsDetermined4(battito1, battito2, battito3);

            Assert.AreEqual(risposta, risultato);


        }

        [TestMethod]
        public void calcoli2()
        {

            double battito1 = 60;
            double battito2 = 75;
            double battito3 = 42;

            string risposta = "";
            string risultato = "59 Bradicardia 33 42 60 75";

            risposta = CardioAnalisiLibrary.Class1.IsDetermined4(battito1, battito2, battito3);

            Assert.AreEqual(risposta, risultato);


        }

        [TestMethod]
        public void Bradicardia1()
        {

            double battiti = 56;
            string risultato = "Bradicardia Lieve";
            string risposta = "";

            risposta = CardioAnalisiLibrary.Class1.IsDetermined2(battiti);

            Assert.AreEqual(risposta, risultato);


        }
    }

    
}
