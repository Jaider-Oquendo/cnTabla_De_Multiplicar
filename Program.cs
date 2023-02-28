using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnTabla_De_Multiplicar
{
    /// <summary>
    /// 22/02/2023
    /// Jaider Andres Oquendo Zapata
    /// Programa que permite ingresar valores enteros por teclado. 
    ///  y nos muestre la tabla de multiplicar de dicho valor. para Finalizar el programa se debe ingresar el -1.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa para una tabla de multiplicar.");
            //Instancia la clase, para invocar los metodos.
            Program Tabla_Multiplicar = new Program();
            Tabla_Multiplicar.IngresarValor();
            Console.ReadKey();

        }
        //Metodos
        //Metodo para ingresar los valores enteros por teclado.
        public void IngresarValor()
        {
            int valor;
            do
            {
                Console.WriteLine("Ingrese un valor para calcular su tabla de multiplicar, o ingrese -1 para finalizar ");
                valor = Convert.ToInt16(Console.ReadLine());
                if (valor!=-1)
                {
                    Console.WriteLine("la tabla del: " + valor + " es la siguente: ");
                    //invoca el metodo el cual muestra y calcula la tabla de multiplicar del valor
                    CalcularTabla(valor);
                }
               
                //Finaliza el programa al ingresar el -1.
            } while ( valor != -1 );

        }
        //metodo para calcular y que nos muestre la tabla de multiplicar del valor ingresado
        public void CalcularTabla(int valor)
        {
            
            //f  es el factor por el cual se multiplica el valor ingresado
            //inicia de 0 a 10 y que 10 es el factor mayor por el cual decidi multiplicar el valor.
            for (int f = 1; f <= 10; f++)
            {
                Console.WriteLine( Convert.ToString(valor +"*"+f+"="+(valor*f)) );

            }
             
        }
    }
}
