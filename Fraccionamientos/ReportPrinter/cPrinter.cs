using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraccionamientos.ReportPrinter
{
    class cPrinter
    {
        public string Imprimir_Historal(string Depto, string correo,string fra  )
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
                    ireport.Load(@"C:\Andaman_Terramar\Fraccionamientos\Fraccionamientos\Reportes\ReporteIndividual.rpt");
                }
                else {
                    ireport.Load(@"C:\Andaman_Terramar\Fraccionamientos\Fraccionamientos\Reportes\ReporteIndividual_Bosques.rpt");
                }

                
                SetDBLogonForReport(iConnectionInfo, ireport);



           


                Fraccionamientos.Contenedor.frmContenedor_Reportes oconte = new Fraccionamientos.Contenedor.frmContenedor_Reportes();



                oconte.crystalReportViewer1.ReportSource = ireport;
                ireport.Refresh();



                //   ireport.PrintToPrinter(1, true, 1, 1);

                //ireport.PrintToPrinter(1, true, 1, 1);
                //     ireport.PrintToPrinter(1, True, 1, 1)
                //ElseIf Valetc = False Then
                //    ireport.PrintToPrinter(1, True, 1, 1)

                Archivo = @"C:\Reportes_Andaman\" + Depto +"_" +DateTime.Now.ToShortDateString().Replace("/", "")+ ".pdf";

                ireport.ExportToDisk(ExportFormatType.PortableDocFormat, Archivo);

                //cUtilerias otily = new cUtilerias();
                //otily.Enviar_Mail_Attachments(correo, "Ticket de Pago Servicio de Pension", "Estimado Usuario se envia Ticket de Pago de Servicio de Pension", Archivo);


                //   oconte.ShowDialog();


                ireport.Close();
                return Archivo;
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }


        }
        public string Imprimir_Tarjeton(string Depto, string correo,string Tarjeton)
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






                Fraccionamientos.Contenedor.frmContenedor_Reportes oconte = new Fraccionamientos.Contenedor.frmContenedor_Reportes();



                oconte.crystalReportViewer1.ReportSource = ireport;
                ireport.Refresh();



                //   ireport.PrintToPrinter(1, true, 1, 1);

                //ireport.PrintToPrinter(1, true, 1, 1);
                //     ireport.PrintToPrinter(1, True, 1, 1)
                //ElseIf Valetc = False Then
                //    ireport.PrintToPrinter(1, True, 1, 1)

                Archivo = @"C:\Tarjetones_Andaman\" + Tarjeton + ' ' +Depto + "_" + DateTime.Now.ToShortDateString().Replace("/", "") + ".pdf";

                ireport.ExportToDisk(ExportFormatType.PortableDocFormat, Archivo);

                //cUtilerias otily = new cUtilerias();
                //otily.Enviar_Mail_Attachments(correo, "Ticket de Pago Servicio de Pension", "Estimado Usuario se envia Ticket de Pago de Servicio de Pension", Archivo);


                //   oconte.ShowDialog();


                ireport.Close();
                return Archivo;
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
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

        public string Imprimir_DeudasImdividual(string Depto, string correo, string fra )
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
                    ireport.Load(@"C:\Andaman_Terramar\Fraccionamientos\Fraccionamientos\Reportes\Reporte_Individual_Deudores.rpt");
                }
                else if (fra == "2")
                {
                    ireport.Load(@"C:\Andaman_Terramar\Fraccionamientos\Fraccionamientos\Reportes\Reporte_Individual_Deudores_Bosques.rpt");
                }

                
                SetDBLogonForReport(iConnectionInfo, ireport);






                Fraccionamientos.Contenedor.frmContenedor_Reportes oconte = new Fraccionamientos.Contenedor.frmContenedor_Reportes();



                oconte.crystalReportViewer1.ReportSource = ireport;
                ireport.Refresh();



                //   ireport.PrintToPrinter(1, true, 1, 1);

                //ireport.PrintToPrinter(1, true, 1, 1);
                //     ireport.PrintToPrinter(1, True, 1, 1)
                //ElseIf Valetc = False Then
                //    ireport.PrintToPrinter(1, True, 1, 1)

                Archivo = @"C:\Reportes_Andaman\" +"Adeudos Andaman "+   Depto + "_" + DateTime.Now.ToLongDateString().Replace("/", "") + ".pdf";

                ireport.ExportToDisk(ExportFormatType.PortableDocFormat, Archivo);

                //cUtilerias otily = new cUtilerias();
                //otily.Enviar_Mail_Attachments(correo, "Ticket de Pago Servicio de Pension", "Estimado Usuario se envia Ticket de Pago de Servicio de Pension", Archivo);


                //   oconte.ShowDialog();


                ireport.Close();
                return Archivo;
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }


        }
        public string Imprimir_Recibo_Luz(string Depto, string correo,string id)
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
                if (id == "1")

                {
                    ireport.Load(@"C:\Andaman_Terramar\Fraccionamientos\Fraccionamientos\Reportes\Reporte_ReciboLuz.rpt");
                }
                else {
                    ireport.Load(@"C:\Andaman_Terramar\Fraccionamientos\Fraccionamientos\Reportes\Reporte_ReciboLuzTecamac.rpt");

                }

                SetDBLogonForReport(iConnectionInfo, ireport);






                Fraccionamientos.Contenedor.frmContenedor_Reportes oconte = new Fraccionamientos.Contenedor.frmContenedor_Reportes();



                oconte.crystalReportViewer1.ReportSource = ireport;
                ireport.Refresh();



                //   ireport.PrintToPrinter(1, true, 1, 1);

                //ireport.PrintToPrinter(1, true, 1, 1);
                //     ireport.PrintToPrinter(1, True, 1, 1)
                //ElseIf Valetc = False Then
                //    ireport.PrintToPrinter(1, True, 1, 1)

                Archivo = @"C:\Reportes_Andaman\" + Depto + "_" + DateTime.Now.ToShortDateString().Replace("/", "") + ".pdf";

                ireport.ExportToDisk(ExportFormatType.PortableDocFormat, Archivo);

                //cUtilerias otily = new cUtilerias();
                //otily.Enviar_Mail_Attachments(correo, "Ticket de Pago Servicio de Pension", "Estimado Usuario se envia Ticket de Pago de Servicio de Pension", Archivo);


                //   oconte.ShowDialog();


                ireport.Close();
                return Archivo;
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }


        }


       

    }
}
