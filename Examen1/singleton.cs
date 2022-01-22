using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1
{
    class singleton
    {
        private static singleton Creacion;
        public int Televisor1 { get; set; }

        //Constructor Privado
        private singleton() { }

        //Creamos un metodos para crear la clase
        public static singleton GetCreacion()
        {
            //Comprueba si la clase esta creada o no : Si se encuentrada creada devolverá la clase creada , si no ha sido creada
            //Se creara una nueva
            if (Creacion == null)
            {
                Creacion = new singleton();
            }
            return Creacion;
        }
        //Creamos un metodos para Ingresar el dinero
        public void IngresarTelevisor(int caja_cerveza)
        {
            this.Televisor1 += Televisor1;
        }
    }
}
