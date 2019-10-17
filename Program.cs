using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarDeManeraInversa14Numeros
{
    class Program
    {
        static void Main(string[] args)
        {           
            //arreglo con números desordenados
            int[] numeros = { 12, 15, 18, 24, 69, 27, 25, 8, 10, 95, 101, 323, 658, 14 };
            /*la siguiente instrucción ordena el arreglo numeros demenor a mayor
                                                su sintaxis es array.Sort(nombredelarreglo); */
            
            Array.Sort(numeros);
            /*la siguiente sintaxis invierte el orden del arreglo,ahora estará de mayor a menor
                                                su sintaxis es array.Reverse(nombredelarreglo);*/
            Array.Reverse(numeros);
            Console.WriteLine("arreglo ordenado de mayor a menor");
            //se imprime en pantalla el arreglo con un ciclo for
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i].ToString());
            }
            Console.ReadLine();//se detiene pantalla
        }
    }
}


