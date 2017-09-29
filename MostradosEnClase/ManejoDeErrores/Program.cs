using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManejoDeErrores
{
    /// <summary>
    /// Original por Maximiliano Neiner
    /// Modificaciones 2017 por Federico Dávila
    /// </summary>
    class Program
    {
        public static void ArrojarExcepcion()
        {
            throw new MiClaseException("Error personalizado!!!",
                                       "Class Program.ArrojarExcepcion");
        }

        public static double Dividir(int numero1, int numero2)
        {
            double resultado=0;
            try
            {
                resultado = numero1 / numero2;
            }
            catch (DivideByZeroException ex) // 
            {
                throw new MiClaseException("Error al intentar dividir!!!",
                                           "Class Program.Dividir",
                                           ex);
                //Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("Bloque Finally");
            }

            // Si el resultado de la división es menor a 1, lanzo la excepción
            if (resultado < 1)
                throw new Exception("Resultado menor a 1");

            return resultado;
        }

        public static void Main(string[] args)
        {
            try
            {
                double res;

                //ArrojarExcepcion(); // Comentar para seguir probando

                //res = Dividir(1, 0); // Comentar para seguir probando

                res = Dividir(1, 5); // Comentar para seguir probando

                res = Dividir(1, 1);
                Console.WriteLine("Resultado: {0}", res);
            }
            catch (MiClaseException ex) //CAPTURO EXCEPCION PERSONALIZADA
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("InnerException: {0}", ex.InnerException);
            }
            catch (Exception ex) //CAPTURO CUALQUIER EXCEPCION
            {
                Console.WriteLine(ex.Message);
            }
                            
            Console.ReadLine();

        }

    }


}

