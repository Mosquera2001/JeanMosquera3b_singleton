using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1
{
    class Almacen
    {
        int NTelevisor { get; set; }
        int codigo;
        //Constructor 
        public Almacen(int codigo_barra) { this.codigo = codigo_barra; }

        //Realizamos el almacenamiento del pago por el cliente y  Devolvemos la diferencia 
        public int AlmaMon(int Ntelevisor, int MontoPagar)
        {
            int Diferencia = MontoPagar - NTelevisor;
            this.NTelevisor += Diferencia;
            this.NTelevisor = +Ntelevisor;
            return Diferencia;
        }
        public void Enviaralamcen()
        {
            singleton almacentelevisor = singleton.GetCreacion();
            almacentelevisor.IngresarTelevisor(this.NTelevisor);
            this.NTelevisor = 0;
        }
    }
}
