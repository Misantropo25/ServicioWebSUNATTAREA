using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWindowsCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Llamar al servicio
        private static ServiceReference1.WebService1SoapClient servicio;
        // Colores
        private Color colorAzul1 = Color.FromArgb(51, 122, 183);


        private void Form1_Load(object sender, EventArgs e)
        {
            // Diseño
            lblTitle1.BackColor = colorAzul1;
            lblTitle2.BackColor = colorAzul1;
            btnBuscar.BackColor = colorAzul1;

            ocultarPanelResultados();
        }

        // Metodos de Diseño
        private void paCriteriosBusqueda_Paint(object sender, PaintEventArgs e)     {ControlPaint.DrawBorder(e.Graphics, this.paCriteriosBusqueda.ClientRectangle, colorAzul1, ButtonBorderStyle.Solid);}
        private void paResultadosBusqueda_Paint(object sender, PaintEventArgs e)    {ControlPaint.DrawBorder(e.Graphics, this.paResultadosBusqueda.ClientRectangle, colorAzul1, ButtonBorderStyle.Solid);}
        
        
        // Botones
        private void btnVolver_Click(object sender, EventArgs e)
        {
            ocultarPanelResultados();
            tbRUC.Text = string.Empty;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Leer las cajas de texto
            string RUC = tbRUC.Text.Trim();
            // Servicio y obtener la respuesta del mismo
            servicio = new ServiceReference1.WebService1SoapClient();
            string[] rsta = servicio.buscarEmpresa(RUC);
            if (rsta[0] == "0")
            {
                mostrarPanelResultados();

                string[] datos = servicio.obtenerDatosEmpresa(RUC);
                lblNroRUC.Text = datos[0];
                lblRazonSocial.Text = datos[1];
                lblTipoContribuyente.Text = datos[2];
                lblNombreComercial.Text = datos[3];
                lblFechaInscripcion.Text = datos[4];
                lblFechaInicioActividades.Text = datos[5];
                lblEstadoContribuyente.Text = datos[6];
                lblCondicionContribuyente.Text = datos[7];
                lblDomicilioFiscal.Text = datos[8];
                lblSistemaEmisionComprobante.Text = datos[9];
                lblActividadComercioExterior.Text = datos[10];
                lblSistemaContabilidad.Text = datos[11];
                lblActividadEconomica.Text = datos[12];
                lblSistemaEmisionElectronica.Text = datos[13];
                lblFechaEmisionElectronico.Text = datos[14];
                lblComprobanteElectronico.Text = datos[15];
                lblFechaAfiliacionPLE.Text = datos[16];
                lblPadrones.Text = datos[17];
            }
            else
            {
                MessageBox.Show(rsta[1], "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metodos
        public void ocultarPanelResultados()
        {
            paResultadosBusqueda.Hide();
            paCriteriosBusqueda.Show();
            Size = new Size(1200, 250);

            paResultadosBusqueda.Left = 12;
            paResultadosBusqueda.Top = 209;
        }
        public void mostrarPanelResultados()
        {
            paResultadosBusqueda.Show();
            paCriteriosBusqueda.Hide();
            Size = new Size(1200, 600);

            paResultadosBusqueda.Left = 12;
            paResultadosBusqueda.Top = 53;
        }

        private void lblTitle1_Click(object sender, EventArgs e)
        {

        }
    }
}
