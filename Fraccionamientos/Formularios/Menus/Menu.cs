using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fraccionamientos.Formularios.Menus
{
    public partial class Menu : Form
    {
        private int childFormNumber = 0;

        public Menu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void aportacionesPropietariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Cobros_Transferencias ocobro = new Cobros_Transferencias();
            ocobro.txtFrac.Text = this.txtFrac.Text;
            ocobro.lblFraccionamiento.Text = this.lblFraccionamiento.Text;

            ocobro.ShowDialog();

          

        

        }

        private void adeudosPropietariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Deudas_Departamentos ocobro = new Deudas_Departamentos();
            ocobro.txtFrac.Text = this.txtFrac.Text;
            ocobro.lblFraccionamiento.Text = this.lblFraccionamiento.Text;
            ocobro.ShowDialog();
        }

        private void pagoProoveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pago_Proveedores op = new Pago_Proveedores();
            op.txtFrac.Text = this.txtFrac.Text;
            op.lblFraccionamiento.Text = this.lblFraccionamiento.Text;
            op.Show();
         
        }

        private void reciboLuzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recibos_de_Luz op = new Recibos_de_Luz();
            op.txtFrac.Text = this.txtFrac.Text;
            op.lblFraccionamiento.Text = this.lblFraccionamiento.Text;
            op.Show();
          
        }

        private void reporesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTarjetones orep = new frmTarjetones();
            orep.Show();
            orep.txtFrac.Text = this.txtFrac.Text;
            orep    .lblFraccionamiento.Text = this.lblFraccionamiento.Text;

        }

        private void txtFrac_TextChanged(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSeleccionFraccionamiento ome = new FrmSeleccionFraccionamiento();
            ome.Show();
        }
    }
}

