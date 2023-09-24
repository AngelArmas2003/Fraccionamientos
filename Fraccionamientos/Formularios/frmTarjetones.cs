using BibliotecaClases.Entidades;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
    public partial class frmTarjetones : Form
    {
        public frmTarjetones()
        {
            InitializeComponent();
        }

        private void frmTarjetones_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbManto.Checked)
            {
                gbBimestre.Visible = false;

            }
            //if (rbManto.Checked)
            //{
            //   /* gbTarjeton.Location = new Point(927, 5)*/;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formularios.Menus.Menu ome = new Menus.Menu();
            ome.Show();
            ome.txtFrac.Text = this.txtFrac.Text;
            ome.lblFraccionamiento.Text = this.lblFraccionamiento.Text;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            crystalReportViewer2.ReportSource = null;
            Reportes_Totales orep = new Reportes_Totales();
            cPrinter or = new cPrinter();
          

            string mes = cbMes.Text;
            string AÑO = cbAño.Text;


            if (rbManto.Checked)
            {
                orep.Reporte_Deudoresmantenimiento(mes, AÑO,txtFrac.Text);

                Imprimir_Deudoresmantenimiento(mes, AÑO, txtFrac.Text);
            }

            if (rbLuz.Checked)
            {
             

                string bimestre = cbBimestre.SelectedValue.ToString();
                orep.Reporte_DeudoresLuz(AÑO, bimestre, txtFrac.Text);

                Imprimir_DeudoresLuz( AÑO,bimestre,txtFrac.Text);
           
            }


            if (rbpizarron.Checked)
            {



                Imprimir_ReportePizarron(txtFrac.Text);

            }

            if (rbTarjeton.Checked)
            {



                Imprimir_UltimoTarjeton();

            }











        }

        public void Imprimir_Deudoresmantenimiento(string mes,string año,string fra)
        //IMPRESION DIRECTA DEL BOLETO.
        {
            try
            {
                string Archivo = string.Empty;

                ReportDocument ireport = new ReportDocument();

                ConnectionInfo iConnectionInfo = new ConnectionInfo();

                iConnectionInfo.DatabaseName = "Andaman_Terramar";
                iConnectionInfo.UserID = "sa";
                iConnectionInfo.Password = "Dayuya012307";
                iConnectionInfo.ServerName = @".\SICGA_SQLSERVER";





                iConnectionInfo.Type = ConnectionInfoType.SQL;


                if (fra == "1")
                {
                    ireport.Load(@"C:\Andaman_Terramar\Fraccionamientos\Fraccionamientos\Reportes\rDeudores.rpt");
                }
                else if (fra == "2")
                {
                    ireport.Load(@"C:\Andaman_Terramar\Fraccionamientos\Fraccionamientos\Reportes\rDeudoresBosques.rpt");
                }



                
                SetDBLogonForReport(iConnectionInfo, ireport);






                //Fraccionamientos.Formularios.frmTarjetones oconte = new Fraccionamientos.Formularios.frmTarjetones();



                crystalReportViewer2.ReportSource = ireport;
                crystalReportViewer2.Zoom(75);

                ireport.Refresh();
              


                //ireport.Refresh();



                //   ireport.PrintToPrinter(1, true, 1, 1);

                //ireport.PrintToPrinter(1, true, 1, 1);
                //     ireport.PrintToPrinter(1, True, 1, 1)
                //ElseIf Valetc = False Then
                //    ireport.PrintToPrinter(1, True, 1, 1)

                Archivo = @"C:\Deudores Mantenimiento\Deudores_" + mes + "_"+año+"_"+ DateTime.Now.ToShortDateString().Replace("/", "") + ".pdf";

                ireport.ExportToDisk(ExportFormatType.PortableDocFormat, Archivo);
                
                //cUtilerias otily = new cUtilerias();
                //otily.Enviar_Mail_Attachments(correo, "Ticket de Pago Servicio de Pension", "Estimado Usuario se envia Ticket de Pago de Servicio de Pension", Archivo);

                ireport.Close();
                //oconte.ShowDialog();


                //ireport.Close();
                //return Archivo;
            }
            catch (Exception ex)
            {

            }


        }
        public void Imprimir_DeudoresLuz( string año,string bimestre, string fra)
        //IMPRESION DIRECTA DEL BOLETO.
        {
            try
            {
                string Archivo = string.Empty;

                ReportDocument ireport = new ReportDocument();

                ConnectionInfo iConnectionInfo = new ConnectionInfo();

                iConnectionInfo.DatabaseName = "Andaman_Terramar";
                iConnectionInfo.UserID = "sa";
                iConnectionInfo.Password = "Dayuya012307";
                iConnectionInfo.ServerName = @".\SICGA_SQLSERVER";





                iConnectionInfo.Type = ConnectionInfoType.SQL;




                if (fra == "1")
                {
                    ireport.Load(@"C:\Andaman_Terramar\Fraccionamientos\Fraccionamientos\Reportes\rDeudoresLuz.rpt");
                }
                else if (fra == "2")
                {
                    ireport.Load(@"C:\Andaman_Terramar\Fraccionamientos\Fraccionamientos\Reportes\rDeudoresLuz_Bosques.rpt");
                }


              
                SetDBLogonForReport(iConnectionInfo, ireport);






                //Fraccionamientos.Formularios.frmTarjetones oconte = new Fraccionamientos.Formularios.frmTarjetones();


              
                crystalReportViewer2.ReportSource = ireport;
                crystalReportViewer2.Zoom(75);

                ireport.Refresh();



                //ireport.Refresh();



                //   ireport.PrintToPrinter(1, true, 1, 1);

                //ireport.PrintToPrinter(1, true, 1, 1);
                //     ireport.PrintToPrinter(1, True, 1, 1)
                //ElseIf Valetc = False Then
                //    ireport.PrintToPrinter(1, True, 1, 1)

                Archivo = @"C:\Deudores Mantenimiento\Deudores_Luz Bimestre " + bimestre +  "_" + año + "_" + DateTime.Now.ToShortDateString().Replace("/", "") + ".pdf";

                ireport.ExportToDisk(ExportFormatType.PortableDocFormat, Archivo);

                //cUtilerias otily = new cUtilerias();
                //otily.Enviar_Mail_Attachments(correo, "Ticket de Pago Servicio de Pension", "Estimado Usuario se envia Ticket de Pago de Servicio de Pension", Archivo);

                ireport.Close();
                //oconte.ShowDialog();


                //ireport.Close();
                //return Archivo;
            }
            catch (Exception ex)
            {

            }


        }
        public void SetDBLogonForReport(ConnectionInfo myConnectionInfo, ReportDocument myReportDocument)

        {
            try
            {
                Tables myTables = myReportDocument.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table myTable in myTables)
                {
                    TableLogOnInfo myTableLogonInfo = myTable.LogOnInfo;
                    myTableLogonInfo.ConnectionInfo = myConnectionInfo;
                    myTable.ApplyLogOnInfo(myTableLogonInfo);

                }

            }
            catch (Exception ex)
            {


            }
        }

        private void rbLuz_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLuz.Checked)
            {
                c_Cobros_Transferencias ocobro = new c_Cobros_Transferencias();
                ocobro.Catalogo_Bimestres(cbBimestre);
                gbBimestre.Visible = true;

            }


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


        public void Imprimir_ReportePizarron(string fra)
        //IMPRESION DIRECTA DEL BOLETO.
        {
            try
            {
                string Archivo = string.Empty;

                ReportDocument ireport = new ReportDocument();

                ConnectionInfo iConnectionInfo = new ConnectionInfo();

                iConnectionInfo.DatabaseName = "Andaman_Terramar";
                iConnectionInfo.UserID = "sa";
                iConnectionInfo.Password = "Dayuya012307";
                iConnectionInfo.ServerName = @".\SICGA_SQLSERVER";





                iConnectionInfo.Type = ConnectionInfoType.SQL;

                if (fra == "1")
                {
                    ireport.Load(@"C:\Andaman_Terramar\Fraccionamientos\Fraccionamientos\Reportes\rDeudoresPizarra.rpt");
                }
                else
                {
                    ireport.Load(@"C:\Andaman_Terramar\Fraccionamientos\Fraccionamientos\Reportes\rDeudoresPizarra_Bosques.rpt");
                }

                
                SetDBLogonForReport(iConnectionInfo, ireport);






                //Fraccionamientos.Formularios.frmTarjetones oconte = new Fraccionamientos.Formularios.frmTarjetones();



                crystalReportViewer2.ReportSource = ireport;
                crystalReportViewer2.Zoom(75);

                ireport.Refresh();



                //ireport.Refresh();



                //   ireport.PrintToPrinter(1, true, 1, 1);

                //ireport.PrintToPrinter(1, true, 1, 1);
                //     ireport.PrintToPrinter(1, True, 1, 1)
                //ElseIf Valetc = False Then
                //    ireport.PrintToPrinter(1, True, 1, 1)

                //Archivo = @"C:\Deudores Mantenimiento\Deudores_Luz Bimestre " + bimestre + "_" + año + "_" + DateTime.Now.ToShortDateString().Replace("/", "") + ".pdf";

                //ireport.ExportToDisk(ExportFormatType.PortableDocFormat, Archivo);

                //cUtilerias otily = new cUtilerias();
                //otily.Enviar_Mail_Attachments(correo, "Ticket de Pago Servicio de Pension", "Estimado Usuario se envia Ticket de Pago de Servicio de Pension", Archivo);

                ireport.Close();
                //oconte.ShowDialog();


                //ireport.Close();
                //return Archivo;
            }
            catch (Exception ex)
            {

            }


        }
        public void Imprimir_UltimoTarjeton()
        //IMPRESION DIRECTA DEL BOLETO.
        {
            try
            {
                string Archivo = string.Empty;

                ReportDocument ireport = new ReportDocument();

                ConnectionInfo iConnectionInfo = new ConnectionInfo();

                iConnectionInfo.DatabaseName = "Andaman_Terramar";
                iConnectionInfo.UserID = "sa";
                iConnectionInfo.Password = "Dayuya012307";
                iConnectionInfo.ServerName = @".\SICGA_SQLSERVER";





                iConnectionInfo.Type = ConnectionInfoType.SQL;

                ireport.Load(@"C:\Andaman_Terramar\Fraccionamientos\Fraccionamientos\Reportes\rTarjeton.rpt");
                SetDBLogonForReport(iConnectionInfo, ireport);






                //Fraccionamientos.Formularios.frmTarjetones oconte = new Fraccionamientos.Formularios.frmTarjetones();



                crystalReportViewer2.ReportSource = ireport;
                crystalReportViewer2.Zoom(75);

                ireport.Refresh();



                //ireport.Refresh();



                //   ireport.PrintToPrinter(1, true, 1, 1);

                //ireport.PrintToPrinter(1, true, 1, 1);
                //     ireport.PrintToPrinter(1, True, 1, 1)
                //ElseIf Valetc = False Then
                //    ireport.PrintToPrinter(1, True, 1, 1)

                //Archivo = @"C:\Deudores Mantenimiento\Deudores_Luz Bimestre " + bimestre + "_" + año + "_" + DateTime.Now.ToShortDateString().Replace("/", "") + ".pdf";

                //ireport.ExportToDisk(ExportFormatType.PortableDocFormat, Archivo);

                //cUtilerias otily = new cUtilerias();
                //otily.Enviar_Mail_Attachments(correo, "Ticket de Pago Servicio de Pension", "Estimado Usuario se envia Ticket de Pago de Servicio de Pension", Archivo);

                ireport.Close();
                //oconte.ShowDialog();


                //ireport.Close();
                //return Archivo;
            }
            catch (Exception ex)
            {

            }


        }
    }
}
