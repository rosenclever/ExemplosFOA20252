using ConceitosBasicos.uteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExemplos
{
    [TestClass]
    public class TestMetrosMilimetros
    {
        [TestMethod]
        public void TestConverter()
        {
            //cenario
            double metros = 4, milimetros;
            
            //acao
            milimetros = MetrosMilimetros.Converter(metros);

            //verificacao
            Assert.AreEqual(4000, milimetros);
        }
    }
}
