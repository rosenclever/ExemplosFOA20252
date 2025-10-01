using ConceitosBasicos.uteis;

namespace TestExemplos
{
    [TestClass]
    public sealed class TestSomaDoisNumeros
    {
        [TestMethod]
        public void TestSomar()
        {
            //cenário
            int num1 = 20, num2 = 22, result;
            SomaDoisNumeros somaDoisNumeros = new SomaDoisNumeros();

            //acao
            result = somaDoisNumeros.Somar(num1, num2);

            //verificação
            Assert.AreEqual(42, result);
        }
    }
}
