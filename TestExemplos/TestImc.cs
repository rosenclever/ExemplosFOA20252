using ConceitosBasicos.uteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExemplos
{
    [TestClass]
    public class TestImc
    {
        [TestMethod]
        public void TestCalculaImc()
        {
            //cenario
            float peso = 80;
            float altura = 1.79f;
            float imcCalculado;
            Imc imc = new Imc();

            //acao
            imcCalculado = imc.CalculaImc(peso, altura);

            //verificacao
            Assert.AreEqual(Math.Round(24.97, 2), Math.Round(imcCalculado, 2));
        }
    }
}
