using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBusquedaED_MCLG.Clases
{
    internal class Ejercicios
    {

        //tarea CUADERNO para el 17-10-23
        //
        //forma lineal
        public void EncontrarElemento()
        {
            int[] A = { -8, 4, 5, 9, 12, 25, 40, 60 };
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
            MostrarPocicion(encontrado);
        }

        //mostrar las pociciones de los elementos buscados en un array
        private void MostrarPocicion(int encontrado)
        {

            if (encontrado != -1)
            {
                Console.WriteLine($"encontrado en la posicion {encontrado}");
            }
            else
            {
                Console.WriteLine("NO encontrado");
            }
        }

        //Escribe un programa en C# que realice una búsqueda lineal para encontrar un número en una lista de enteros. 
        //El programa debe pedir al usuario un número a buscar y luego buscarlo en la matriz. Si el número está en la matriz, 
        //el programa debe imprimir su posición, de lo contrario, debe indicar que el número no se encuentra en la matriz.
        public void Ejercicio1(int numero)
        {
            int[] numerosArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int encontrado = 0;
            if (numero > 0 && numero < 10)
            {
                for (int i = 0; i < numerosArray.Length; i++)
                {
                    if (numero == numerosArray[i])
                    {
                        encontrado = i;
                        break;
                    }
                    else
                    {
                        encontrado = -1;
                    }

                }
                MostrarPocicion(encontrado);
            }
            else
            {
                Console.WriteLine("el numero no es valido");
            }
        }
        //Crea un programa en C# que realice una búsqueda lineal para encontrar una cadena en un arreglo 
        //de cadenas. El programa debe solicitar al usuario una cadena y buscarla en una matriz. 
        //Si la cadena se encuentra en la matriz, se debe mostrar su índice; de lo contrario, se debe 
        //indicar que la cadena no está presente.
        public void Ejercicio2(string color)
        {
            color = color.ToLower();
            string[,] matrizColores = { {"rojo","amarillo" },{ "morado","azul"} };
            int[] encontrado = new int[] {-1, -1 };
            
                for (int i = 0; i < matrizColores.GetLength(0); i++)
                {
                    
                    
                        for (int j = 0; j < matrizColores.GetLength(1); j++)
                        {
                            if (color == matrizColores[i, j])
                            {
                                encontrado[0] = i;
                                encontrado[1] = j;
                                break;
                            }
                            
                        }
                        if (encontrado[0] != -1 && encontrado[1] != -1 )
                        {
                            Console.WriteLine($"color encontrado en la posicion ({encontrado[0]}, {encontrado[1]})");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("No encontrado");
                        }
                    
                }
            
            
        }

        //Escribe un programa en C# que realice una búsqueda lineal para encontrar un 
        //número par en un arreglo de números enteros. El programa debe imprimir la 
        //primera posición en la que se encuentra un número par en el arreglo.
        public void Ejercicio3()
        {
            int[] numerosEnteros = {1, 5, 3,10,2 };
            for (int i = 0; i < numerosEnteros.Length; i++)
            {
                if (numerosEnteros[i]%2 == 0)
                {
                    Console.WriteLine($"Hay un número par en la posición {i}: {numerosEnteros[i]}");
                    
                    break;
                }
               
            }
        }

        //Escribe un programa en C# que realice una búsqueda lineal para encontrar todos
        //los números pares en una matriz de números enteros. El programa debe 
        //imprimir todas las posiciones en las que se encuentran los números pares en 
        //la matriz.

        public void Ejercicio4()
        {
            int[,] numerosEnteros = { { 1, 5, }, { 3, 10 }, { 2, 6} };
            for (int i = 0; i < numerosEnteros.GetLength(0); i++)
            {
                for(int j = 0; j< numerosEnteros.GetLength(1); j++)
                {
                    if (numerosEnteros[i,j] % 2 == 0)
                    {
                        Console.WriteLine($"Hay un número par en la posición ({i},{j}): {numerosEnteros[i,j]}");

                       
                    }
                }
                

            }
        }
    }

    
}
