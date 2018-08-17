using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Estáticos
{
    class matematicas
    {

        public static int Potencia(int numeroBase, int exponente)
        {
            int resultado = 1;
            for(int i=0; i < exponente; i++)
            {
                resultado = resultado * numeroBase;
            }
            return (resultado);
        }

    }
}
