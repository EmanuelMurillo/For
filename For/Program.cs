using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            //Requisitos
            //1. Preguntar el número de alumnos a calificar.
            //2. Pedir la calificación de cada alumno.
            //3. Calcular el promedio de calificaciones.
            //4. Mostrar el promedio

            byte i, alumnos;
            double cal, sumacal = 0, prom;

            Console.WriteLine("Ingrese el número de alumnos: ");
            alumnos = Convert.ToByte(Console.ReadLine());

            for (i = 1; i <= alumnos; i++)
            {
                Console.WriteLine("Ingrese la calificación del alumno: ");
                cal = Convert.ToDouble(Console.ReadLine());

                sumacal += cal;
            }

            prom = sumacal / alumnos;

            Console.WriteLine("El promedio de las calificaciones es: {0}", prom);
            

            Console.ReadKey();
        }

        
    }
}
