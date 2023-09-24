using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaClases.Entidades
{
    public class Class_Cobros_Transferencias
    {
        public int id { get; set; }
        public string Cve_Propietario { get; set; }
        public string CveConcepto { get; set; }
        public string Mes { get; set; }
        public string Año { get; set; }
        public DateTime Fecha_Transaccion { get; set; }
        public decimal Importe { get; set; }
        public byte[] Imagen_Comprobante { get; set; }

        public DateTime FechaRegistro { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaActualizacion { get; set; }


        public bool activo {get;set;}

        public int RegistraCobro(Class_Cobros_Transferencias cobro)
        {
            int reg = 0;

            return reg;



        }

        public Class_Cobros_Transferencias BuscarTransferencias(string CveDepto)

        {
            Class_Cobros_Transferencias Cobro = new Class_Cobros_Transferencias();


            return Cobro;

        }


    }
}
