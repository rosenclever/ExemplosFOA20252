using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosBasicos.uteis
{
    public class Imc
    {
        public float CalculaImc(float peso, float altura)
        {
            return (float)(peso/Math.Pow(altura, 2));
        }
    }
}
