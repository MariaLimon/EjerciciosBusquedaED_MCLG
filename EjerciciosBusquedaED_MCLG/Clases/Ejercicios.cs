using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBusquedaED_MCLG.Clases
{
    internal class Ejercicios
    {

        //tarea para el 17-10-23
        //
        //forma lineal
        public void EncontrarElemento()
        {
            int[] A = {-8, 4, 5, 9, 12, 25, 40, 60};
            int encontrado = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 40)
                {
                    encontrado = i;
                    break;
                }
                else
                {
                    encontrado = -1;
                }
            }
            if (encontrado != -1)
            {
                Console.WriteLine($"numero encontrado en la posicion {encontrado}");
            }
            else
            {
                Console.WriteLine("numero no encontrado");
            }
        }
    }
}
