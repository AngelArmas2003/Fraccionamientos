using BibliotecaClases.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fraccionamientos.Formularios
{
    public partial class FrmSeleccionFraccionamiento : Form
    {
        public FrmSeleccionFraccionamiento()
        {
            InitializeComponent();
        }

        private void FrmSeleccionFraccionamiento_Load(object sender, EventArgs e)
        {
            cFraccionamientos ofra = new cFraccionamientos();
            var liscomboBox1ta = ofra.CalalogoFraccionamiento();


            comboBox1.DataSource = liscomboBox1ta;

            comboBox1.ValueMember = "CveFraccionamiento";
            comboBox1.DisplayMember ="NombreFraccionamiento";



        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menus.Menu omenu = new Menus.Menu();
            omenu.Show();

            omenu.txtFrac.Text = comboBox1.SelectedValue.ToString();
            omenu.lblFraccionamiento.Text = comboBox1.Text.ToString().ToUpper();
            


        }
    }
}
