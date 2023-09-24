using BibliotecaClases.Entidades;
using Fraccionamientos.ReportPrinter;
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
    public partial class Deudas_Departamentos : Form
    {
        public Deudas_Departamentos()
        {
            InitializeComponent();
        }

        private void Deudas_Departamentos_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {

   
            this.CbPropietarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            c_Cobros_Transferencias ocobro = new c_Cobros_Transferencias();
            DeudasporDepartamento odeudas = new DeudasporDepartamento();
            odeudas.Muestra_Deuodas(dgwdeudas);
            ocobro.Catalogo_Propietarios(CbPropietarios,txtFrac.Text);


          
          
            txtImporte.Text = "0.00";
            txtimpFavor.Text = "0.00";
          
            //this.cbAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            txtObservaciones.Text = string.Empty;
            txtNombre.Text = string.Empty;
          

            btnGuardar.Text = "Guardar";
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            CbPropietarios.Focus();



            CbPropietarios.Enabled = true;
        
        
            txtImporte.Enabled = false;
            txtimpFavor.Enabled = false;
           
            txtObservaciones.Enabled = false;
           
            btnEditar.Enabled = false;
            btnCorreo.Enabled = false;
            txtTarjeton.Text = "";


        }

        private void CbPropietarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cve = CbPropietarios.Text;
            c_Cobros_Transferencias ocobro = new c_Cobros_Transferencias();
            txtNombre.Text = ocobro.Consulta_NombrePensionado(cve);

            DeudasporDepartamento odeudas = new DeudasporDepartamento();
            odeudas.Muestra_Deudas_Individual(dgwdeudas, cve);

            odeudas.Crea_Reporte_Individual_udas(cve);

            Single suma = 0;
            Single abono = 0;
            Single Total = 0;
            foreach (DataGridViewRow row in dgwdeudas.Rows)
            {

                bool pagado = Convert.ToBoolean(row.Cells[4].Value);
                if (row.Cells[5].Value != null) //1 es "Cantidad"
                    abono += Convert.ToSingle(row.Cells[5].Value);

                if (pagado)
                { 
                }
                else
                {
                    if (row.Cells[3].Value != null) //1 es "Cantidad"
                        suma += Convert.ToSingle(row.Cells[3].Value);

                }
                Total =suma -abono;






            }

            lblTotal.Text = Total.ToString();
            btnCorreo.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
            
        }

        private void btnCorreo_Click(object sender, EventArgs e)
        {
            List<AttachFiles> oFiles = new List<AttachFiles>();

            string cve = CbPropietarios.Text;
            string fra = txtFrac.Text;
            c_Cobros_Transferencias ocobro = new c_Cobros_Transferencias();
            string DatoEmail = ocobro.Consulta_CorreoPensionado(cve);
            oFiles.Add(ObtieneFilesPAth(DatoEmail, cve, fra));



            var x = EnvioMasivoEmail(DatoEmail, oFiles[0], cve, fra );

            if (x == 1)
            { MessageBox.Show("Correo Enviado"); }
            else
            { MessageBox.Show("Correo NO Enviado"); }


        }

        public AttachFiles ObtieneFilesPAth(string Emal, string ticket, string fra)
        {
            AttachFiles Files = new AttachFiles();


            cPrinter oPrinter = new cPrinter();
            Files.File1 = oPrinter.Imprimir_DeudasImdividual(ticket, Emal,fra);





            return Files;
        }
        public int EnvioMasivoEmail(string Emal, AttachFiles oFiles, string cve, string fra)
        {
            int emailAnswer = 0;
            cUtilerias outility = new cUtilerias();


            if (fra == "1")
            {
                emailAnswer = outility.Enviar_Mail_Attachments(Emal, "Reporte de  Pagos Pendientes Andaman Terramar I", "Apreciable  Vecin@.<br/> <br/>  Comparto  Reporte de Pagos pendientes   correspondientes a su  Departamento  " + cve + ". <br/> <br/> Lo invitamos de forma respetuosa  ponerse al corriente con sus pagos , ya que sus aportaciones  <br/>  son muy importantes para poder realizar Mejoras y continuar con los mantenimientos, lo que <br/>  nos ayuda a conservar nuestro fraccionamiento en condiciones que nuestras Familias y Visitantes <br/>  disfruten su estancia.  <br/> <br/>    Agradecemos su comprensión y  Apoyo. <br/> Reciba un cordial saludo. <br/><br/> Atentamente <br/> Administración.", oFiles.File1);
            }
            else
            {
                emailAnswer = outility.Enviar_Mail_Attachments(Emal, "Reporte de  Pagos Pendientes Circuito Bosques de Austria", "Apreciable  Vecin@.<br/> <br/>  Comparto  Reporte de Pagos pendientes   correspondientes a su  Vivienda  " + cve + ". <br/> <br/> Lo invitamos de forma respetuosa  ponerse al corriente con sus aportaciones , ya que sus aportaciones  <br/>  son muy importantes para poder realizar Mejoras y continuar con los mantenimientos, lo que <br/>  nos ayuda a conservar nuestro fraccionamiento en condiciones que nuestras Familias y Visitantes <br/>  disfruten su estancia.  <br/> <br/>    Agradecemos su comprensión y  Apoyo. <br/> Reciba un cordial saludo. <br/><br/> Atentamente <br/> Administración.", oFiles.File1);
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

        private void dgwdeudas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgwdeudas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                LlenarTextBox(dgwdeudas.CurrentRow.Index);
            }
            catch (Exception ex)

            {

            }
        }



        public void LlenarTextBox(int IndiceDGV)
        {
            try
            {

                txtid.Text = dgwdeudas.Rows[IndiceDGV].Cells[0].Value.ToString();


                CbPropietarios.Text = dgwdeudas.Rows[IndiceDGV].Cells[1].Value.ToString();

                txtObservaciones.Text = dgwdeudas.Rows[IndiceDGV].Cells[2].Value.ToString();

                txtImporte.Text = dgwdeudas.Rows[IndiceDGV].Cells[3].Value.ToString();

                var resp = Convert.ToBoolean(dgwdeudas.Rows[IndiceDGV].Cells[4].Value.ToString());

                txtimpFavor.Text = dgwdeudas.Rows[IndiceDGV].Cells[5].Value.ToString();


                






                //dgwEmpresa.Ro

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

        private void dgwdeudas_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                LlenarTextBox(dgwdeudas.CurrentRow.Index);
            }
            catch (Exception ex)

            {

            }
        }

        private void dgwdeudas_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                LlenarTextBox(dgwdeudas.CurrentRow.Index);
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
            txtimpFavor.Enabled = true;
            txtImporte.Enabled = true;
          
            txtObservaciones.Enabled = true;
            gbPagaod.Enabled = true;
            
            btnCorreo.Enabled = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DeudasporDepartamento odeudas = new DeudasporDepartamento();
                cTarjetones otarjetas = new cTarjetones();

             
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


                            var answer = MessageBox.Show("¿Desea Registrar el Adeudo ?", "Registra Adeudos", MessageBoxButtons.YesNo);

                            if (answer == System.Windows.Forms.DialogResult.Yes)
                            {





                            odeudas.CvePropietario = CbPropietarios.SelectedValue.ToString();
                            odeudas.Concepto_Adeudo =txtObservaciones.Text;
                            odeudas.Importe_Adeudo = Convert.ToSingle(txtImporte.Text);
                            odeudas.Afavor = Convert.ToSingle(txtimpFavor.Text);
                            odeudas.Pagado = RbActivo.Checked;
                            odeudas.CveFraccionamiento = txtFrac.Text;
                                


                          

                               
                                var x = odeudas.Registra_Adeudo(odeudas);



                            if (x == 0)
                            {
                                MessageBox.Show("Adeudo No Registrado, Verificar la información");
                            }
                            else
                            {
                                MessageBox.Show("Adeudo  Registrada");
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




                            odeudas.CvePropietario = CbPropietarios.SelectedValue.ToString();
                            odeudas.Concepto_Adeudo = txtObservaciones.Text.ToString();
                            odeudas.Importe_Adeudo = Convert.ToSingle(txtImporte.Text);
                            odeudas.Afavor = Convert.ToSingle(txtimpFavor.Text);
                            odeudas.Pagado = RbActivo.Checked;
                            odeudas.id = Convert.ToInt32(txtid.Text);
                            odeudas.CveFraccionamiento = txtFrac.Text;







                            var x = odeudas.Actualiza_Deuda(odeudas);

                            if (x == 0)
                            {
                                MessageBox.Show("Aportación NO Registrada, Verificar la información");
                            }
                            else
                            {
                                MessageBox.Show("Aportación Actualizada");
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Habilita_Editar();
        }
        public void Habilita_Editar()
        {
            btnGuardar.Text = "Actualizar";
            btnGuardar.Enabled = true;
            CbPropietarios.Focus();

            CbPropietarios.Enabled = true;
            
            
            txtImporte.Enabled = true;
            txtimpFavor.Enabled = true;
            
            txtObservaciones.Enabled = true;

            gbPagaod.Enabled = true;
            
            btnEditar.Enabled = true;
            RbActivo.Enabled = true;
            RbInactivo.Enabled = true;
            btnEditar.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formularios.Menus.Menu ome = new Menus.Menu();
            ome.Show();

            ome.txtFrac.Text = this.txtFrac.Text;
            ome.lblFraccionamiento.Text = this.lblFraccionamiento.Text;
        }
    }
}
