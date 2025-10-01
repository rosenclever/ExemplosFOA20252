using ConceitosBasicos.uteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExemplos
{
    [TestClass]
    public class TestFibonacci
    {
        [TestMethod]
        public void TestValorEmPosicaoDaSequenciaDeFibonacci()
        {
            //cenario
            int posicao = 6;
            int valorEsperado = 8;
            int valorObtido;
            Fibonacci fibonacci = new Fibonacci();

            //acao
            valorObtido = fibonacci.ValorNaPosicao(posicao);

            //verificação
            Assert.AreEqual(valorEsperado, valorObtido);
        }
    }
}
