using Fraccionamientos.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fraccionamientos
{
    static class Program                                                                                       
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Recibos_de_Luz());
            //Application.Run(new Cobros_Transferencias());
            //Application.Run(new Pago_Proveedores());
            //Application.Run(new frmTarjetones());
            //Application.Run(new Deudas_Departamentos());
            //Application.Run(new Formularios.Menus.Menu());
            Application.Run(new FrmSeleccionFraccionamiento());
            //Application.Run(new WhatsUp.prueba_whats());


            //Application.Run(new Form1());
        }

    }
}
