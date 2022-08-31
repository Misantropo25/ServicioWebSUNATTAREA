using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteWebCSharp
{
    public partial class ConsultaRUC : System.Web.UI.Page
    {
        private static ServiceReference1.WebService1SoapClient servicio = new ServiceReference1.WebService1SoapClient();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            agregarFila("Número de RUC:", "-");
            agregarFila("Razón Social:", "-");
            agregarFila("Tipo Contribuyente:", "-");
            agregarFila("Nombre Comercial:", "-");
            agregarFila("Fecha de Inscripción:", "-");
            agregarFila("Fecha de Inicio de Actividades:", "-");
            agregarFila("Estado del Contribuyente:", "-");
            agregarFila("Condición del Contribuyente:", "-");
            agregarFila("Domicilio Fiscal:", "-");
            agregarFila("Sistema Emisión de Comprobante:", "-");
            agregarFila("Actividad Comercio Exterior:", "-");
            agregarFila("Sistema Contabilidad:", "-");
            agregarFila("Actividad Económica:", "-");
            agregarFila("Sistema de Emisión Electrónica:", "-");
            agregarFila("Emisor electrónico desde:", "-");
            agregarFila("Comprobantes Electrónicos:", "-");
            agregarFila("Afiliado al PLE desde:", "-");
            agregarFila("Padrones:", "-");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string RUC = tbRUC.Text.Trim();
            string[] rpta = servicio.buscarEmpresa(RUC);
            if (rpta[0] == "0")
            {
                string[] datos = servicio.obtenerDatosEmpresa(RUC);

                while (tableResultados.Rows.Count > 0) tableResultados.Rows.RemoveAt(0);

                agregarFila("Número de RUC:", datos[0]);
                agregarFila("Razón Social:", datos[1]);
                agregarFila("Tipo Contribuyente:", datos[2]);
                agregarFila("Nombre Comercial:", datos[3]);
                agregarFila("Fecha de Inscripción:", datos[4]);
                agregarFila("Fecha de Inicio de Actividades:", datos[5]);
                agregarFila("Estado del Contribuyente:", datos[6]);
                agregarFila("Condición del Contribuyente:", datos[7]);
                agregarFila("Domicilio Fiscal:", datos[8]);
                agregarFila("Sistema Emisión de Comprobante:", datos[9]);
                agregarFila("Actividad Comercio Exterior:", datos[10]);
                agregarFila("Sistema Contabilidad:", datos[11]);
                agregarFila("Actividad Económica:", datos[12]);
                agregarFila("Sistema de Emisión Electrónica:", datos[13]);
                agregarFila("Emisor electrónico desde:", datos[14]);
                agregarFila("Comprobantes Electrónicos:", datos[15]);
                agregarFila("Afiliado al PLE desde:", datos[16]);
                agregarFila("Padrones:", datos[17]);
            }
            else Response.Write("<script>alert('RUC incorrecto.');</script>");
        }

        public void agregarFila(String cell1Text, String cell2Text) {
            TableRow row = new TableRow();
            TableCell cell1 = new TableCell();
            TableCell cell2 = new TableCell();
            cell1.Text = cell1Text;
            cell2.Text = cell2Text;
            row.Cells.Add(cell1);
            row.Cells.Add(cell2);
            tableResultados.Rows.Add(row);
        }
    }
}