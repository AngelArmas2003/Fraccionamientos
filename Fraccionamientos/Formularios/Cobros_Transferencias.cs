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

using BibliotecaClases.Entidades;
using Fraccionamientos.ReportPrinter;

namespace Fraccionamientos.Formularios
{
    public partial class Cobros_Transferencias : Form
    {

        public Cobros_Transferencias()
        {
            InitializeComponent();
        }

        public void Pagos_Load(object sender, EventArgs e)
        {
           
          
            limpiar();
            




        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cve = CbPropietarios.Text;
            c_Cobros_Transferencias ocobro = new c_Cobros_Transferencias();
            txtNombre.Text = ocobro.Consulta_NombrePensionado(cve);
            string frac= txtFrac.Text;

            ocobro.Muestra_Cobros_Individual(dgwCobros, cve, frac);



        }

        private void button2_Click(object sender, EventArgs e)
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                c_Cobros_Transferencias oBiblioteca = new c_Cobros_Transferencias();
                cTarjetones otarjetas = new cTarjetones();

                if (pbDocumento.Image == null)
                {
                    MessageBox.Show("Seleccione la imagen de la Transferencia o Deposito");
                    
                    btnImagen.Focus();

                }
                else
                {

                    Single monto = 0;
                    if (txtImporte.Text.Contains("$0.00") || txtImporte.Text == string.Empty)
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


                            var answer = MessageBox.Show("¿Desea Registrar la Aportación ?", "Cobro Aportaciones", MessageBoxButtons.YesNo);

                            if (answer == System.Windows.Forms.DialogResult.Yes)
                            {


                                string Concepto = cbMovimiento.SelectedValue.ToString();

                                if (Concepto.Contains("02") || Concepto.Contains("04") || Concepto.Contains("05"))
                                {

                                    oBiblioteca.Bimestre = cbBimestre.SelectedValue.ToString();

                                }
                                else
                                {
                                    oBiblioteca.Bimestre = "0";
                                }



                                MemoryStream ms = new MemoryStream();
                                pbDocumento.Image.Save(ms, ImageFormat.Jpeg);


                                oBiblioteca.Cve_Propietario = CbPropietarios.SelectedValue.ToString();
                                oBiblioteca.CveConcepto = cbMovimiento.SelectedValue.ToString();
                                oBiblioteca.Mes = cbMes.Text;
                                oBiblioteca.Año = cbAño.Text;
                                oBiblioteca.Fecha_Transaccion = Convert.ToDateTime(dtpFechaTransaccion.Text + " " + dtpHoraTransaccion.Text);
                                oBiblioteca.Importe = Convert.ToDecimal(txtImporte.Text);
                                oBiblioteca.Imagen_Comprobante = ms.GetBuffer();
                                oBiblioteca.FechaRegistro = DateTime.Now;
                                oBiblioteca.Observaciones = txtObservaciones.Text;
                                oBiblioteca.Fraccionamiento = txtFrac.Text;




                                if (oBiblioteca.CveConcepto.Contains("01") || oBiblioteca.CveConcepto.Contains("05") || oBiblioteca.CveConcepto.Contains("07") || oBiblioteca.CveConcepto.Contains("09"))


                                {
                                    //Asi obtenemos el primer dia del mes actual
                                    DateTime oPrimerDiaDelMes = new DateTime(Convert.ToInt32(oBiblioteca.Año), cbMes.SelectedIndex + 1, 1);



                                    otarjetas.Numero_Tarjeton = otarjetas.Obtiene_Folio_Boleto(); ;
                                    otarjetas.CvePropietario = CbPropietarios.SelectedValue.ToString();
                                    otarjetas.Mes = cbMes.Text;
                                    otarjetas.Año = cbAño.Text;
                                    otarjetas.Vigencia_Inicio = oPrimerDiaDelMes;
                                    otarjetas.Vigencia_Final = oPrimerDiaDelMes.AddMonths(1).AddDays(-1) ;
                                    otarjetas.Vigencia_Final = otarjetas.Vigencia_Final.AddDays(10);
                                    otarjetas.Fecha_Emision = DateTime.Now;

                                    otarjetas.Registra_tarjeton(otarjetas);
                                    oBiblioteca.Tarjeton = otarjetas.Numero_Tarjeton;
                                    oBiblioteca.Fraccionamiento = txtFrac.Text;
                                }
                                if (oBiblioteca.Tarjeton == "" || oBiblioteca.Tarjeton == null)
                                {
                                    oBiblioteca.Tarjeton = "S/T";
                                }

                                var x = oBiblioteca.Registra_Cobro(oBiblioteca);



                                if (x == 0)
                                {
                                    MessageBox.Show("Aportación NO Registrada, Verificar la información");
                                }
                                else
                                {
                                    MessageBox.Show("Aportación Registrada");
                                    string pro = CbPropietarios.SelectedValue.ToString();
                                    limpiar();
                                    CbPropietarios.Text = otarjetas.CvePropietario;
                                    c_Cobros_Transferencias ocobro = new c_Cobros_Transferencias();
                                    txtNombre.Text = ocobro.Consulta_NombrePensionado(pro);
                                    string fracc = txtFrac.Text;

                                    ocobro.Muestra_Cobros_Individual(dgwCobros, pro, fracc);
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


                                string Concepto = cbMovimiento.SelectedValue.ToString();

                                if (Concepto.Contains("02") || Concepto.Contains("04") || Concepto.Contains("05"))
                                {

                                    oBiblioteca.Bimestre = cbBimestre.SelectedValue.ToString();

                                }
                                else
                                {
                                    oBiblioteca.Bimestre = "0";
                                }




                                MemoryStream ms = new MemoryStream();
                                pbDocumento.Image.Save(ms, ImageFormat.Jpeg);


                                oBiblioteca.Cve_Propietario = CbPropietarios.SelectedValue.ToString();
                                oBiblioteca.CveConcepto = cbMovimiento.SelectedValue.ToString();
                                oBiblioteca.Mes = cbMes.Text;
                                oBiblioteca.Año = cbAño.Text;
                                oBiblioteca.Fecha_Transaccion = Convert.ToDateTime(dtpFechaTransaccion.Text + " " + dtpHoraTransaccion.Text);
                                oBiblioteca.Importe = Convert.ToDecimal(txtImporte.Text);
                                oBiblioteca.Imagen_Comprobante = ms.GetBuffer();
                                oBiblioteca.FechaRegistro = DateTime.Now;
                                oBiblioteca.Observaciones = txtObservaciones.Text;
                                oBiblioteca.id = Convert.ToInt32(txtCve.Text);
                                oBiblioteca.Activo = RbActivo.Checked;
                                oBiblioteca.Fraccionamiento = txtFrac.Text;





                                var x = oBiblioteca.Actualiza_Cobro(oBiblioteca);

                                if (x == 0)
                                {
                                    MessageBox.Show("Aportación NO Registrada, Verificar la información");
                                }
                                else
                                {
                                    MessageBox.Show("Aportación Actualizada");
                                    limpiar();
                                    string pro = CbPropietarios.SelectedValue.ToString();
                                    limpiar();
                                    CbPropietarios.Text = otarjetas.CvePropietario;
                                    c_Cobros_Transferencias ocobro = new c_Cobros_Transferencias();
                                    txtNombre.Text = ocobro.Consulta_NombrePensionado(pro);
                                    string fracc = txtFrac.Text;

                                    ocobro.Muestra_Cobros_Individual(dgwCobros, pro, fracc);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {

            Habilita_Editar();
            //try
            //{
            //    c_Cobros_Transferencias oBiblioteca = new c_Cobros_Transferencias();

            //    MemoryStream ms = new MemoryStream();
            //    pbDocumento.Image.Save(ms, ImageFormat.Jpeg);


            //    oBiblioteca.Cve_Propietario = CbPropietarios.SelectedValue.ToString();
            //    oBiblioteca.CveConcepto = cbMovimiento.Text;
            //    oBiblioteca.Mes = cbMes.Text;
            //    oBiblioteca.Año = cbAño.Text;
            //    oBiblioteca.Fecha_Transaccion = Convert.ToDateTime(dtpFechaTransaccion.Text + " " + dtpHoraTransaccion.Text);
            //    oBiblioteca.Importe = Convert.ToDecimal(txtImporte.Text);
            //    oBiblioteca.Imagen_Comprobante = ms.GetBuffer();
            //    oBiblioteca.FechaRegistro = DateTime.Now;
            //    oBiblioteca.Observaciones = txtObservaciones.Text;


            //    oBiblioteca.Registra_Cobro(oBiblioteca);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        public void limpiar()


        {
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPropietarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbAño.DataSource = null;

            int year = DateTime.Now.Year-3 ;
            int mes = DateTime.Now.Month; ;
            c_Cobros_Transferencias ocobro = new c_Cobros_Transferencias();
            ocobro.Muestra_Cobros(dgwCobros);
            ocobro.Catalogo_Movimientos(cbMovimiento);
            ocobro.Catalogo_Propietarios(CbPropietarios,txtFrac.Text);
            ocobro.Catalogo_Bimestres(cbBimestre);
            dtpFechaTransaccion.Text = DateTime.Now.ToShortDateString();
            dtpHoraTransaccion.Text = DateTime.Now.ToShortTimeString();
            string año = DateTime.Now.Year.ToString();
            cbAño.Text = año;
            txtImporte.Text = "0.00";
            cbAño.Items.Clear();
            for (int i =0; i<=10;i++)

            {
                
                cbAño.Items.Add(year);
                year = year + 1;



            }
            //this.cbAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            txtObservaciones.Text = string.Empty;
            txtNombre.Text = string.Empty;
            cbMes.SelectedIndex = mes-1;
            pbDocumento.Image = null;

            btnGuardar.Text = "Guardar";
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false  ;
            CbPropietarios.Focus();

          

            CbPropietarios.Enabled = true;
            cbMovimiento.Enabled = false;
            cbAño.Enabled = false;
            cbMes.Enabled = false;
            txtImporte.Enabled = false;
            dtpFechaTransaccion.Enabled = false;
            dtpHoraTransaccion.Enabled = false;
            txtObservaciones.Enabled = false;
            btnImagen.Enabled = false;
            btnEditar.Enabled = false;
            btnCorreo.Enabled = false;
            txtTarjeton.Text = "";
            gbBimestre.Enabled = false;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            limpiar();
            pbDocumento.Image = null;
            txtTarjeton.Enabled = false;
        }

        private void CbPropietarios_SelectedValueChanged(object sender, EventArgs e)
        {
            string cve = CbPropietarios.Text;
            c_Cobros_Transferencias ocobro = new c_Cobros_Transferencias();
            txtNombre.Text = ocobro.Consulta_NombrePensionado(cve);
            string fracc = txtFrac.Text;

            ocobro.Muestra_Cobros_Individual(dgwCobros, cve, fracc);
            ocobro.Crea_Reporte_Individual(cve);

            Single suma = 0;
            foreach (DataGridViewRow row in dgwCobros.Rows)
            {
                if (row.Cells[6].Value != null) //1 es "Cantidad"
                    suma += Convert.ToSingle(row.Cells[6].Value);
            }

            lblTotal.Text = suma.ToString();
            btnCorreo.Enabled = true;


        }

        private void cbAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        public void LlenarTextBox(int IndiceDGV)
        {
            try
            {

                txtCve.Text = dgwCobros.Rows[IndiceDGV].Cells[0].Value.ToString();
                CbPropietarios.Text = dgwCobros.Rows[IndiceDGV].Cells[1].Value.ToString();
               
                cbMovimiento.SelectedValue = dgwCobros.Rows[IndiceDGV].Cells[2].Value;

                cbMes.Text = dgwCobros.Rows[IndiceDGV].Cells[3].Value.ToString();
                cbAño.Text = dgwCobros.Rows[IndiceDGV].Cells[4].Value.ToString();
                dtpFechaTransaccion.Text = dgwCobros.Rows[IndiceDGV].Cells[5].Value.ToString().Substring(0,10);
                dtpHoraTransaccion.Text = dgwCobros.Rows[IndiceDGV].Cells[5].Value.ToString().Substring(11, 8);
                txtImporte.Text = dgwCobros.Rows[IndiceDGV].Cells[6].Value.ToString();
                
                //dtpFechaTransaccion.Text = dgwCobros.Rows[IndiceDGV].Cells[8].Value.ToString();
                txtObservaciones.Text = dgwCobros.Rows[IndiceDGV].Cells[9].Value.ToString();
                //txtcp.Text = dgwCobros.Rows[IndiceDGV].Cells[10].Value.ToString();
                var resp = Convert.ToBoolean(dgwCobros.Rows[IndiceDGV].Cells[11].Value.ToString());
                txtTarjeton.Text = Convert.ToString(dgwCobros.Rows[IndiceDGV].Cells[12].Value.ToString());

             cbBimestre.SelectedValue = Convert.ToString(dgwCobros.Rows[IndiceDGV].Cells[13].Value.ToString());

                string cvePro = CbPropietarios.Text;

                c_Cobros_Transferencias oco = new c_Cobros_Transferencias();
                var valor =oco.TieneAdeudos(cvePro);





                if (txtTarjeton.Text == string.Empty || txtTarjeton.Text == "S/T" || txtTarjeton.Text =="")
                {
                    btnTarjeton.Enabled = false;
                }
                else if (txtTarjeton.Text != string.Empty && valor ==0)
                {
                    btnTarjeton.Enabled = true;
                }
                

                //dgwEmpresa.Rows[e.RowIndex].Cells[13].Value
                //}
                byte[] imageBuffer = (byte[])dgwCobros.Rows[IndiceDGV].Cells[7].Value; //almacenas la imagen de la datagrib
                System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);//
                pbDocumento.Image = Image.FromStream(ms);//le asignas al pictureBox

                if (resp)
                {
                    RbActivo.Checked = true;
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

        private void dgwCobros_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                LlenarTextBox(dgwCobros.CurrentRow.Index);
            }
            catch (Exception ex)

            {

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilita_Limpiar();
        }
        public void Habilita_Limpiar()
        {
            btnGuardar.Text = "Guardar";
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            CbPropietarios.Focus();
            
            CbPropietarios.Enabled = true;
            cbMovimiento.Enabled = true;
            cbAño.Enabled = true;
            cbMes.Enabled = true;
            txtImporte.Enabled = true;
            dtpFechaTransaccion.Enabled = true;
            dtpHoraTransaccion.Enabled = true;
            txtObservaciones.Enabled = true;
            btnImagen.Enabled = true;
            btnCorreo.Enabled = false;
            gbBimestre.Enabled = true;

        }
        public void Habilita_Editar()
        {
            btnGuardar.Text = "Actualizar";
            btnGuardar.Enabled = true;
            CbPropietarios.Focus();

            CbPropietarios.Enabled = true;
            cbMovimiento.Enabled = true;
            cbAño.Enabled = true;
            cbMes.Enabled = true;
            txtImporte.Enabled = true;
            dtpFechaTransaccion.Enabled = true;
            dtpHoraTransaccion.Enabled = true;
            txtObservaciones.Enabled = true;
            btnImagen.Enabled = true;

            btnImagen.Enabled = true;
            btnEditar.Enabled = true;
            RbActivo.Enabled = true;
            RbInactivo.Enabled = true;
            btnEditar.Enabled = false;
            gbBimestre.Enabled = true;

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgwCobros_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                LlenarTextBox(dgwCobros.CurrentRow.Index);
            }
            catch (Exception ex)

            {

            }
        }

        private void dgwCobros_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                LlenarTextBox(dgwCobros.CurrentRow.Index);
            }
            catch (Exception ex)

            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Formularios.Menus.Menu ome = new Menus.Menu();
            ome.Show();


            ome.txtFrac.Text = this.txtFrac.Text;
            ome.lblFraccionamiento.Text = this.lblFraccionamiento.Text;




        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<AttachFiles> oFiles = new List<AttachFiles>();
       
            string cve = CbPropietarios.Text;
            c_Cobros_Transferencias ocobro = new c_Cobros_Transferencias();
            string DatoEmail = ocobro.Consulta_CorreoPensionado(cve);
            oFiles.Add(ObtieneFilesPAth(DatoEmail, cve, txtFrac.Text));

            

          var x=  EnvioMasivoEmail(DatoEmail, oFiles[0], cve, txtFrac.Text);

            if (x == 1)
            { MessageBox.Show("Correo Enviado"); }
            else
            { MessageBox.Show("Correo NO Enviado"); }



        }
        public AttachFiles ObtieneFilesPAth(string Emal, string ticket,string fra)
        {
            AttachFiles Files = new AttachFiles();


            cPrinter oPrinter = new cPrinter();
            Files.File1 = oPrinter.Imprimir_Historal(ticket, Emal, fra);
      




            return Files;
        }
        public AttachFiles ObtieneFilesPAthTarjeton(string Emal, string ticket,string tarjeton)
        {
            AttachFiles Files = new AttachFiles();


            cPrinter oPrinter = new cPrinter();
            Files.File1 = oPrinter.Imprimir_Tarjeton(ticket, Emal, tarjeton );





            return Files;
        }
        public int EnvioMasivoEmail(string Emal, AttachFiles oFiles, string cve, string fra)
        {
            int emailAnswer = 0;
            cUtilerias outility = new cUtilerias();


            if (fra == "1")
            {
                emailAnswer = outility.Enviar_Mail_Attachments(Emal, "Historial de Aportaciones Andaman Terramar I", "Apreciable  Vecino.<br/> <br/>  Comparto el Reporte  Historial de Aportanciones correspondiente a su  Departamento  " + cve + ". <br/> <br/> Agradezco su Apoyo. <br/> Reciba un cordial saludo. <br/><br/> Atentamente <br/> Administración.", oFiles.File1);
            }
            else
            {
                emailAnswer = outility.Enviar_Mail_Attachments(Emal, "Historial de Aportaciones Circuito Bosques de Austria", "Apreciable  Vecino.<br/> <br/>  Comparto el Reporte  Historial de Aportanciones correspondiente a su  casa  " + cve + ". <br/> <br/> Agradezco su Apoyo. <br/> Reciba un cordial saludo. <br/><br/> Atentamente <br/> Administración.", oFiles.File1);

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
        public int EnvioTarjetonl(string Emal, AttachFiles oFiles, string cve,string Periodo)
        {
            int emailAnswer = 0;
            cUtilerias outility = new cUtilerias();


            emailAnswer = outility.Enviar_Mail_Attachments(Emal, "Entrega de Tarjetón de Acceso al Fraccionamiento Terramar", "Apreciable  Vecino.<br/> <br/>  Comparto el Tarjetón Correspondiente   a su  Departamento  " + cve + ". <br/> <br/> El Tarjetón corresponde al Periodo " + Periodo +". <br/> <br/>  Agradezco su Apoyo. <br/> Reciba un cordial saludo. <br/><br/> Atentamente <br/> Administración.", oFiles.File1);

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

        private void dgwCobros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string tarj = txtTarjeton.Text;

            if (tarj == string.Empty)
            {

                MessageBox.Show("Seleccione Un Cobro que contenga un tarjeton ");

            }
            else {
                cTarjetones otarje = new cTarjetones();
                otarje.Crea_Tarjeton(tarj);






                List<AttachFiles> oFiles = new List<AttachFiles>();

                string cve = CbPropietarios.Text;
                string tarjeton = txtTarjeton.Text;
                c_Cobros_Transferencias ocobro = new c_Cobros_Transferencias();
                string DatoEmail = ocobro.Consulta_CorreoPensionado(cve);
                oFiles.Add(ObtieneFilesPAthTarjeton(DatoEmail, cve, tarjeton));


                string Periodo = cbMes.Text + ' ' + cbAño.Text;
                var x = EnvioTarjetonl(DatoEmail, oFiles[0], cve, Periodo);

                if (x == 1)
                { MessageBox.Show("Correo Enviado"); }
                else
                { MessageBox.Show("Correo NO Enviado"); }


            }


        }

        private void cbMovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                string Concepto = cbMovimiento.SelectedValue.ToString();

                if (Concepto.Contains("02") || Concepto.Contains("04") || Concepto.Contains("05"))
                {
                    gbBimestre.Visible = true;


                }
                else
                {
                    gbBimestre.Visible = false;
                }

                txtObservaciones.Text = "Pago " + cbMovimiento.Text + " " + cbMes.SelectedItem + " " + cbAño.Text;

            }
            catch (Exception es)
            {
                gbBimestre.Visible = false;
            }

        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtObservaciones.Text = "Pago " + cbMovimiento.Text + " " + cbMes.SelectedItem + " " + cbAño.Text;
        }

        private void CbPropietarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
