using BibliotecaClases.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fraccionamientos.Formularios
{
    public partial class Pago_Proveedores : Form
    {
        public Pago_Proveedores()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            //
            try
            {
                cPagos_Proveedores opago = new cPagos_Proveedores();

           

                if (pbDocumento.Image == null)
                {
                    MessageBox.Show("Seleccione la imagen de la Transferencia o Deposito");

                    btnImagen.Focus();

                }
                else
                {

                    Single monto = 0;
                    if ((txtImporte.Text.Contains("$0.00") || txtImporte.Text == string.Empty))
                    {
                        monto = 0;
                    }

                    
                    else
                    {

                        monto = Convert.ToSingle(txtImporte.Text);

                    }


                    if (monto <= 0)
                    {
                        MessageBox.Show("El importe debe ser mayor a '0.0'  Pesos");

                        txtImporte.Focus();


                    }
                    else
                    {

                        if (btnGuardar.Text == "Guardar")
                        {


                            var answer = MessageBox.Show("¿Desea Registrar el Recibo de Luz?", "Recibo de Luz", MessageBoxButtons.YesNo);

                            if (answer == System.Windows.Forms.DialogResult.Yes)
                            {



                                cPagos_Proveedores orecibo = new cPagos_Proveedores();
                                MemoryStream ms = new MemoryStream();
                                pbDocumento.Image.Save(ms, ImageFormat.Jpeg);

                                
                                
                                
                                orecibo.Recibo_Imagen = ms.GetBuffer();


                                orecibo.CveProveedor = cbProveedor.SelectedValue.ToString();
                                orecibo.FechaPago =  Convert.ToDateTime(dtpFechaTransaccion.Text + " " + dtpHoraTransaccion.Text);
                                orecibo.Importe = Convert.ToSingle(txtImporte.Text);
                                orecibo.Observacones = txtObservaciones.Text;

                                orecibo.Recibo_Imagen =  ms.GetBuffer();
                                orecibo.CveFraccionamiento = txtFrac.Text;




                                var x = orecibo.Registra_PagosProveedores(orecibo);


                               

                                if (x == 0)
                                {
                                    MessageBox.Show("Pago  NO Registrado, Pago a Proveedores");
                                }
                                else
                                {
                                    MessageBox.Show("Pago  a Proveedor  Registrado");
                                   Limpiar();
                                }
                            }
                            else
                            {



                            }
                        }
                        else if (btnGuardar.Text == "Actualizar")
                        {

                            try
                            {


                       
                               

                                cPagos_Proveedores orecibo = new cPagos_Proveedores();
                                MemoryStream ms = new MemoryStream();
                                pbDocumento.Image.Save(ms, ImageFormat.Jpeg);




                                orecibo.Recibo_Imagen = ms.GetBuffer();


                                orecibo.CveProveedor = cbProveedor.SelectedValue.ToString();
                                orecibo.FechaPago = Convert.ToDateTime(dtpFechaTransaccion.Text + " " + dtpHoraTransaccion.Text);
                                orecibo.Importe = Convert.ToSingle(txtImporte.Text);
                                orecibo.Observacones = txtObservaciones.Text;
                                orecibo.id = Convert.ToInt32(txtCve.Text);

                                orecibo.Recibo_Imagen = ms.GetBuffer();
                                orecibo.CveFraccionamiento = txtFrac.Text;



                                var x = orecibo.Registra_Actualiza_PagosProveedores(orecibo);





                                if (x == 0)
                                {
                                    MessageBox.Show("Recibo NO Registrada, Verificar la información");
                                }
                                else
                                {
                                    MessageBox.Show("Pago a Proveedor Actualizado con Exito");
                                    Limpiar();
                                }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }


                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Pago_Proveedores_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            this.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      


            int year = DateTime.Now.Year - 1;
            int mes = DateTime.Now.Month; ;
            cPagos_Proveedores ocobro = new cPagos_Proveedores();
            ocobro.Catalogo_Proveedores(cbProveedor,txtFrac.Text);
            ocobro.Muestra_Cobros(dgwPagos, txtFrac.Text);

            dtpFechaTransaccion.Text = DateTime.Now.ToShortDateString();
            dtpHoraTransaccion.Text = DateTime.Now.ToShortTimeString();

            
            
            txtObservaciones.Text = string.Empty;
            pbDocumento.Image = null;

            txtImporte.Text = "0.00";
            btnGuardar.Text = "Guardar";
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
   
            txtImporte.Enabled = false;
            dtpFechaTransaccion.Enabled = false;
            dtpHoraTransaccion.Enabled = false;
            txtObservaciones.Enabled = false;
            btnImagen.Enabled = false;
            btnEditar.Enabled = false;
 
        }

        public void Habilita_Limpiar()
        {
            btnGuardar.Text = "Guardar";
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            cbProveedor.Focus();

            cbProveedor.Enabled = true;
           
            txtImporte.Enabled = true;
            dtpFechaTransaccion.Enabled = true;
            dtpHoraTransaccion.Enabled = true;
            txtObservaciones.Enabled = true;
            btnImagen.Enabled = true;
          

        }
        public void Habilita_Editar()
        {
            btnGuardar.Text = "Actualizar";
            btnGuardar.Enabled = true;
            cbProveedor.Focus();

            cbProveedor.Enabled = true;
          
            txtImporte.Enabled = true;
            dtpFechaTransaccion.Enabled = true;
            dtpHoraTransaccion.Enabled = true;
            txtObservaciones.Enabled = true;
            btnImagen.Enabled = true;

            btnImagen.Enabled = true;
            btnEditar.Enabled = true;
           
            btnEditar.Enabled = false;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilita_Limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Habilita_Editar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
            pbDocumento.Image = null;
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {


                OpenFileDialog fo = new OpenFileDialog();

                DialogResult rs = fo.ShowDialog();

                if (rs == DialogResult.OK)
                {
                    pbDocumento.Image = Image.FromFile(fo.FileName);


                }




            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public void LlenarTextBox(int IndiceDGV)
        {
            try
            {

                txtCve.Text = dgwPagos.Rows[IndiceDGV].Cells[0].Value.ToString();
                cbProveedor.SelectedValue = dgwPagos.Rows[IndiceDGV].Cells[1].Value.ToString();
                dtpFechaTransaccion.Text = dgwPagos.Rows[IndiceDGV].Cells[2].Value.ToString().Substring(0, 10);
                dtpHoraTransaccion.Text = dgwPagos.Rows[IndiceDGV].Cells[2].Value.ToString().Substring(11, 8);
                txtImporte.Text = dgwPagos.Rows[IndiceDGV].Cells[3].Value.ToString();
                txtObservaciones.Text = dgwPagos.Rows[IndiceDGV].Cells[4].Value.ToString();
 
                //dgwEmpresa.Rows[e.RowIndex].Cells[13].Value
                //}
                byte[] imageBuffer = (byte[])dgwPagos.Rows[IndiceDGV].Cells[5].Value; //almacenas la imagen de la datagrib
                System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);//
                pbDocumento.Image = Image.FromStream(ms);//le asignas al pictureBox

                //if (resp)
                //{
                //    RbActivo.Checked = true;
                //}
                //else

                //{
                //    RbInactivo.Checked = true;
                //}

                btnGuardar.Text = "Actualizar";
                btnEditar.Enabled = true;
                btnNuevo.Enabled = false;




            }
            catch (Exception ex)
            {

            }
        }

        private void dgwPagos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                LlenarTextBox(dgwPagos.CurrentRow.Index);
            }
            catch (Exception ex)

            {

            }
        }

        private void dgwPagos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                LlenarTextBox(dgwPagos.CurrentRow.Index);
            }
            catch (Exception ex)

            {

            }
        }

        private void dgwPagos_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                LlenarTextBox(dgwPagos.CurrentRow.Index);
            }
            catch (Exception ex)

            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formularios.Menus.Menu ome = new Menus.Menu();
            ome.Show(); this.Hide();
            ome.txtFrac.Text = this.txtFrac.Text;
            ome.lblFraccionamiento.Text = this.lblFraccionamiento.Text;
        }

        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cve = cbProveedor.SelectedValue.ToString();
            cPagos_Proveedores opagos = new cPagos_Proveedores();


            opagos.Muestra_Cobros_Por_Proveddor(dgwPagos, cve);
            //opagos.Crea_Reporte_Individual(cve);

            Single suma = 0;
            foreach (DataGridViewRow row in dgwPagos.Rows)
            {
                if (row.Cells[3].Value != null) //1 es "Cantidad"
                    suma += Convert.ToSingle(row.Cells[3].Value);
            }

            lblTotal.Text = suma.ToString();
           
        }
    }
}                                                                                                              
