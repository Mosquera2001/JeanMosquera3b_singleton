using System;
using System.Collections.Generic;
using System.Threading;

namespace Examen1
{
    class Program
    {
        static void Main(string[] args)
        {
            singleton Bodega_de_cerveza = singleton.GetCreacion();

            //Creamos una lista para guarda Todos los televisores en el almacen
            List<Almacen> listaalmacen = new List<Almacen>();

            //Creamos Varias secciones
            Almacen seccion1 = new Almacen(1);
            Almacen seccion2 = new Almacen(2);
          
            //Agregamos  los cajero a la lista
            listaalmacen.Add(seccion1);
            listaalmacen.Add(seccion2);
            
            //Variable
            bool Exit = true;
            int opcion = 0;
            int opcion2 = 0;

            //Variable usada en opcion de pagar cajero
            int cantidad;
            int televisor;

            //Comeinzo del programa de cajero
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese la opción que desea");
                Console.WriteLine("1-Ingresar televisores al almacen");
                Console.WriteLine("2-Ver el total televisores en almacen");
                Console.WriteLine("3-Finalizar Programa");
                opcion = Opcion(3);

                //Opcion Pagar Cajero
                if (opcion == 1)
                {
                    Console.Clear();

                    
                    for (int contado = 0; contado < listaalmacen.Count; contado++)
                    {
                        Console.WriteLine("Almacen " + (contado + 1));
                    }
                    Console.WriteLine("***********************************");
                    Console.WriteLine("En que seccion desea guardar los televisores :");
                    opcion2 = Opcion(listaalmacen.Count);
                    Console.WriteLine("***********************************");
                    Console.WriteLine("Ingrese la cantidad de televisores que va a guardar :");
                    cantidad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Reenconfirme la cantidad  :");
                    televisor = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Se a registrado exitosamente  :");

                    listaalmacen[opcion2].AlmaMon(televisor, cantidad);
                    listaalmacen[opcion2].Enviaralamcen();
                   
                    Thread.Sleep(1000);
                    
                }

                //Opcion Ver dinero De Bovedad
                if (opcion == 2)
                {
                    Console.Clear();
                    Console.WriteLine("El numero de televisores en el almacen es : " + Bodega_de_cerveza.Televisor1);
                    Console.WriteLine("Ingrese un numero para salir");
                    opcion2 = Convert.ToInt32(Console.ReadLine());
                }

                //Opción Finalizar Programa
                if (opcion == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Finalizando Programa");
                    Thread.Sleep(100);
                    Exit = false;
                }



            } while (Exit);
        }
            public static int Opcion(int ParametroLimite)
            {
                int opcion = 0;
                do
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                    if (opcion <= 0 || opcion > ParametroLimite)
                    {
                        Console.WriteLine("Opcion no permitida , ingrese de nuevo la opción");
                    }
                } while (opcion <= 0 || opcion > ParametroLimite);
                return opcion;

            
        }
    }
}
