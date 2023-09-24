using BibliotecaClases.Entidades;
using Fraccionamientos.ReportPrinter;
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
    public partial class Recibos_de_Luz : Form
    {
        public Recibos_de_Luz()
        {
            InitializeComponent();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Recibos_de_Luz_Load(object sender, EventArgs e)
        {
            Limpiar();
            //Habilita_Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           

            //
            try
            {
                c_Cobros_Transferencias oBiblioteca = new c_Cobros_Transferencias();

                if (pbDocumento.Image == null)
                {
                    MessageBox.Show("Seleccione la imagen de la Transferencia o Deposito");

                    btnImagen.Focus();

                }
                else
                {

                    Single monto = 0;
                    if ((txtImporteRecibo.Text.Contains("$0.00") || txtImporteRecibo.Text == string.Empty))
                    {
                        monto = 0;
                    }

                     if (txtImpo_depto.Text.Contains("0.00") || txtImpo_depto.Text == string.Empty)
                            {

                        monto = 0;

                    }
                    else
                    {

                        monto = Convert.ToSingle(txtImporteRecibo.Text);

                    }


                    if (monto <= 0)
                    {
                        MessageBox.Show("El importe debe ser mayor a '0.0'  Pesos");

                        txtImporteRecibo.Focus();


                    }
                    else
                    {

                        if (btnGuardar.Text == "Guardar")
                        {


                            var answer = MessageBox.Show("¿Desea Registrar el Recibo de Luz?", "Recibo de Luz", MessageBoxButtons.YesNo);

                            if (answer == System.Windows.Forms.DialogResult.Yes)
                            {


                            
                                cRecibo_Luz orecibo = new cRecibo_Luz();
                                MemoryStream ms = new MemoryStream();
                                pbDocumento.Image.Save(ms, ImageFormat.Jpeg);

                                orecibo.Recibo_Imagen = ms.GetBuffer();
                                orecibo.Importe = Convert.ToSingle(txtImporteRecibo.Text);
                                orecibo.FechaLimetePago = Convert.ToDateTime(dtpFechaLimite.Text);
                                orecibo.PeriodoInicio = Convert.ToDateTime(dtpInicio.Text);
                                orecibo.PerioroFinal = Convert.ToDateTime(dtpFechaLimite.Text);

                                orecibo.Pagado = RbPagado.Checked;
                                orecibo.Total_Departamentos = Convert.ToInt32(txtDeptos.Text);
                                orecibo.Importe_Departamento = Convert.ToSingle(txtImpo_depto.Text.Replace("$",""));
                                orecibo.CveFraccionamiento = txtFrac.Text;


                                orecibo.Registra_Recibo(orecibo);


                                var x = oBiblioteca.Registra_Cobro(oBiblioteca);

                                if (x == 1)
                                {
                                    MessageBox.Show("Aportación NO Registrada, Verificar la información");
                                }
                                else
                                {
                                    MessageBox.Show("Aportación Registrada");
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


                                cRecibo_Luz orecibo = new cRecibo_Luz();
                                MemoryStream ms = new MemoryStream();
                                pbDocumento.Image.Save(ms, ImageFormat.Jpeg);

                                orecibo.id = Convert.ToInt32(txtid.Text);
                                orecibo.Recibo_Imagen = ms.GetBuffer();
                                orecibo.Importe = Convert.ToSingle(txtImporteRecibo.Text);
                                orecibo.FechaLimetePago = Convert.ToDateTime(dtpFechaLimite.Text);
                                orecibo.PeriodoInicio = Convert.ToDateTime(dtpInicio.Text);
                                orecibo.PerioroFinal = Convert.ToDateTime(dtpfinal.Text);

                                orecibo.Pagado = RbPagado.Checked;
                                orecibo.Total_Departamentos = Convert.ToInt32(txtDeptos.Text);
                                orecibo.Importe_Departamento = Convert.ToSingle(txtImpo_depto.Text);
                                orecibo.CveFraccionamiento = txtFrac.Text;


                                var x = orecibo.Actualiza_Cobro(orecibo);





                                if (x == 0)
                                {
                                    MessageBox.Show("Recibo NO Registrada, Verificar la información");
                                }
                                else
                                {
                                    MessageBox.Show("recibo  Actualizado con exito");
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
        public void Limpiar()
        {
            cRecibo_Luz orecibo = new cRecibo_Luz();
            orecibo.Muestra_Cobros(dgwRecibos, txtFrac.Text);



            dtpInicio.Text = DateTime.Now.ToShortDateString();
            dtpfinal.Text = DateTime.Now.ToShortTimeString();
            dtpFechaLimite.Text = DateTime.Now.ToShortTimeString();


            txtImpo_depto.Text = "0.00";
            txtImporteRecibo.Text = "0.00";

            
            //this.cbAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            txtid.Text = string.Empty;
            dtpFechaLimite.Text = string.Empty;
            dtpfinal.Text = string.Empty;
            dtpInicio.Text = string.Empty;
            pbDocumento.Image = null;
            txtDeptos.Enabled = false;
            txtDeptos.Text ="0";

            btnGuardar.Text = "Guardar";
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
      


            txtid.Enabled = true;
            dtpFechaLimite.Enabled = false;
            dtpInicio.Enabled = false;
            dtpfinal.Enabled = false;
            txtImporteRecibo.Enabled = false;
            txtImpo_depto.Enabled = false;
            gbPagado.Enabled = false;
            RbPagado.Checked = false;
            btnImagen.Enabled = false;
            btnEditar.Enabled = false;
   
        }

        private void dgwRecibos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                LlenarTextBox(dgwRecibos.CurrentRow.Index);
            }
            catch (Exception ex)

            {

            }
        }
        public void LlenarTextBox(int IndiceDGV)
        {
            try
            {

                txtid.Text = dgwRecibos.Rows[IndiceDGV].Cells[0].Value.ToString();

                byte[] imageBuffer = (byte[])dgwRecibos.Rows[IndiceDGV].Cells[1].Value; //almacenas la imagen de la datagrib
                System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);//
                pbDocumento.Image = Image.FromStream(ms);//le asignas al pictureBox

                txtImporteRecibo.Text = dgwRecibos.Rows[IndiceDGV].Cells[2].Value.ToString();

                dtpFechaLimite.Text = dgwRecibos.Rows[IndiceDGV].Cells[3].Value.ToString().Substring(0, 10);

                dtpInicio.Text = dgwRecibos.Rows[IndiceDGV].Cells[4].Value.ToString().Substring(0, 10);
                

                dtpfinal.Text= dgwRecibos.Rows[IndiceDGV].Cells[5].Value.ToString().Substring(0, 10);

                var resp = Convert.ToBoolean(dgwRecibos.Rows[IndiceDGV].Cells[6].Value.ToString());



                txtDeptos.Text = dgwRecibos.Rows[IndiceDGV].Cells[7].Value.ToString();


                txtImpo_depto.Text = dgwRecibos.Rows[IndiceDGV].Cells[8].Value.ToString();
               



                //dgwEmpresa.Ro

                if (resp)
                {
                    RbPagado.Checked = true;
                }
                else

                {
                    RbInactivo.Checked = true;
                }

                btnGuardar.Text = "Actualizar";
                btnEditar.Enabled = true;
                btnNuevo.Enabled = false;




            }
            catch (Exception ex)
            {

            }
        }
        public void Habilita_Limpiar()
        {
            btnGuardar.Text = "Guardar";
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnImagen.Focus();
            btnImagen.Enabled = true;
            txtid.Enabled = true;
            dtpFechaLimite.Enabled = true;
            dtpInicio.Enabled = true;
            dtpfinal.Enabled = true;
            txtImporteRecibo.Enabled = true;
            txtDeptos.Enabled = false;
            txtImpo_depto.Enabled = false;
            gbPagado.Enabled = true;
           ;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cRecibo_Luz orecibo = new cRecibo_Luz();
            Habilita_Limpiar();

            string NumDeptos =orecibo.Consulta_Numero_Depto(txtFrac.Text);
            txtDeptos.Text = NumDeptos;
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Habilita_Editar();
        }

        public void Habilita_Editar()
        {
            btnGuardar.Text = "Actualizar";
            btnGuardar.Enabled = true;
            btnImagen.Focus();

            dtpFechaLimite.Enabled = true;
            dtpfinal.Enabled = true;
            dtpInicio.Enabled = true;
            txtDeptos.Enabled = false;
            txtImporteRecibo.Enabled = true;
            txtImpo_depto.Enabled = false;
            gbPagado.Enabled = true;
            
            btnImagen.Enabled = true;

            btnEditar.Enabled = true;
            
            RbInactivo.Enabled = true;
            btnEditar.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
            pbDocumento.Image = null;
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formularios.Menus.Menu ome = new Menus.Menu();
            ome.Show();
            ome.txtFrac.Text = this.txtFrac.Text;
            ome.lblFraccionamiento.Text = this.lblFraccionamiento.Text;
        }

        private void dgwRecibos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                LlenarTextBox(dgwRecibos.CurrentRow.Index);
            }
            catch (Exception ex)

            {

            }
        }

        private void dgwRecibos_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                LlenarTextBox(dgwRecibos.CurrentRow.Index);
            }
            catch (Exception ex)

            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string frac = txtFrac.Text;

            cPropietarios opro = new cPropietarios();
            var lista = opro.CalalogoPropietarios(frac); ;

            string id = txtid.Text;

            if (lista.Count >0)
            {

            

                var answer = MessageBox.Show("¿Desea confirmar el Inicio   del  Envio   Masivos de Recibos de Luz " , "Propietarios ?", MessageBoxButtons.YesNo);

                if (answer == System.Windows.Forms.DialogResult.Yes)
                {
                    string Inicio = dtpInicio.Text;
                    string Final = dtpfinal.Text;



                    cRecibo_Luz orec = new cRecibo_Luz() ;

                    foreach (var op in lista)
                    {

                        // pbGif1.Visible = true;

                        string DatoEmail = "";
                        List<AttachFiles> oFiles = new List<AttachFiles>();

                        DatoEmail = op.Correo_Propietario;

                        orec.Crea_Reporte_Recibo_Luz(id);
                        oFiles.Add(ObtieneFilesPAth(DatoEmail, id + '-'+op.Cve_Propietario, frac));
                        

                        var x = EnvioMasivoEmail(DatoEmail, oFiles[0], id + '-' + op.Cve_Propietario, Inicio, Final, frac);

                        if (x == 1)
                        {  }
                        else
                        {  }



                    }

                    MessageBox.Show("Proceso Concluido");

                }

                else
                {


                }

            }
        }
        public AttachFiles ObtieneFilesPAth(string Emal, string ticket,string id)
        {
            AttachFiles Files = new AttachFiles();


            cPrinter oPrinter = new cPrinter();
            Files.File1 = oPrinter.Imprimir_Recibo_Luz(ticket, Emal, id);





            return Files;
        }
        public int EnvioMasivoEmail(string Emal, AttachFiles oFiles, string cve, string Incio, string final, string frac)
        {
            int emailAnswer = 0;
            cUtilerias outility = new cUtilerias();

            if (frac =="1")
            {
                emailAnswer = outility.Enviar_Mail_Attachments(Emal, "Recibo de Luz Andaman Terramar I", "Apreciable  Vecino.<br/> <br/>  Comparto el Recibo de Luz el cual muestra el Detalle de lo que se debe de aportar por departamento <br/> del Periodo " + Incio + " al " + final + ". <br/> <br/> Si Usted ya realizo esta aportación, favor de hacer caso omiso a este correo  <br/> <br/> Agradezco su Apoyo. <br/> Reciba un cordial saludo. <br/><br/> Atentamente <br/> Administración.", oFiles.File1);
            }
            else if( frac == "2")
            {
                emailAnswer = outility.Enviar_Mail_Attachments(Emal, "Recibo de Luz Circuito Bosques de Austria ", "Apreciable  Vecino.<br/> <br/>  Comparto el Recibo de Luz el cual muestra el Detalle de lo que se debe de aportar por departamento <br/> del Periodo " + Incio + " al " + final + ". <br/> <br/> Si Usted ya realizo esta aportación, favor de hacer caso omiso a este correo  <br/> <br/> Agradezco su Apoyo. <br/> Reciba un cordial saludo. <br/><br/> Atentamente <br/> Administración.", oFiles.File1);
            }

            

            if (emailAnswer == 1)
            {

                //MessageBox.Show("Se Envio Ticket de Pago y Tarjeton al Email de Usuario ");

            }
            else if (emailAnswer == 2)
            {

                //MessageBox.Show("No se logro el  envio del  Ticket de Pago y Tarjeton ");

            }

            return emailAnswer;


        }

      

        private void txtImporteRecibo_KeyPress(object sender, KeyPressEventArgs e)
      {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {

                decimal Monto = 0;
                int Depto = 0;

                Depto = Convert.ToInt32(txtDeptos.Text);
                Monto = Convert.ToDecimal(txtImporteRecibo.Text);
                decimal ImporteTotal = Monto / Depto;

                ImporteTotal =decimal.Round(ImporteTotal, 2);



                txtImpo_depto.Text = "$" + ImporteTotal.ToString();




            }

        }

        private void dgwRecibos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgwRecibos_CellToolTipTextChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
