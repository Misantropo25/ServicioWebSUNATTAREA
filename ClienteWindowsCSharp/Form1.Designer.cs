
namespace ClienteWindowsCSharp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paCriteriosBusqueda = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbRUC = new System.Windows.Forms.TextBox();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.paResultadosBusqueda = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.tlpResultados = new System.Windows.Forms.TableLayoutPanel();
            this.lblPadrones = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.lblFechaAfiliacionPLE = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lblComprobanteElectronico = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lblFechaEmisionElectronico = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lblSistemaEmisionElectronica = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblActividadEconomica = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblSistemaContabilidad = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblActividadComercioExterior = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblSistemaEmisionComprobante = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblDomicilioFiscal = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblCondicionContribuyente = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblEstadoContribuyente = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblFechaInicioActividades = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblFechaInscripcion = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNombreComercial = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTipoContribuyente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNroRUC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.paCriteriosBusqueda.SuspendLayout();
            this.paResultadosBusqueda.SuspendLayout();
            this.tlpResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // paCriteriosBusqueda
            // 
            this.paCriteriosBusqueda.Controls.Add(this.label2);
            this.paCriteriosBusqueda.Controls.Add(this.btnBuscar);
            this.paCriteriosBusqueda.Controls.Add(this.tbRUC);
            this.paCriteriosBusqueda.Controls.Add(this.lblTitle1);
            this.paCriteriosBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paCriteriosBusqueda.Location = new System.Drawing.Point(16, 65);
            this.paCriteriosBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.paCriteriosBusqueda.Name = "paCriteriosBusqueda";
            this.paCriteriosBusqueda.Size = new System.Drawing.Size(1547, 185);
            this.paCriteriosBusqueda.TabIndex = 1;
            this.paCriteriosBusqueda.Paint += new System.Windows.Forms.PaintEventHandler(this.paCriteriosBusqueda_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(719, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese el RUC:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(707, 135);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(133, 31);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbRUC
            // 
            this.tbRUC.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRUC.Location = new System.Drawing.Point(453, 98);
            this.tbRUC.Margin = new System.Windows.Forms.Padding(4);
            this.tbRUC.Name = "tbRUC";
            this.tbRUC.Size = new System.Drawing.Size(665, 26);
            this.tbRUC.TabIndex = 1;
            // 
            // lblTitle1
            // 
            this.lblTitle1.BackColor = System.Drawing.Color.SkyBlue;
            this.lblTitle1.Font = new System.Drawing.Font("Elephant", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblTitle1.ForeColor = System.Drawing.Color.White;
            this.lblTitle1.Location = new System.Drawing.Point(0, 0);
            this.lblTitle1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(1547, 49);
            this.lblTitle1.TabIndex = 0;
            this.lblTitle1.Text = "Criterios de la Búsqueda";
            this.lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle1.Click += new System.EventHandler(this.lblTitle1_Click);
            // 
            // paResultadosBusqueda
            // 
            this.paResultadosBusqueda.Controls.Add(this.btnVolver);
            this.paResultadosBusqueda.Controls.Add(this.tlpResultados);
            this.paResultadosBusqueda.Controls.Add(this.lblTitle2);
            this.paResultadosBusqueda.Location = new System.Drawing.Point(16, 257);
            this.paResultadosBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.paResultadosBusqueda.Name = "paResultadosBusqueda";
            this.paResultadosBusqueda.Size = new System.Drawing.Size(1547, 581);
            this.paResultadosBusqueda.TabIndex = 2;
            this.paResultadosBusqueda.Paint += new System.Windows.Forms.PaintEventHandler(this.paResultadosBusqueda_Paint);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Red;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(707, 524);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(133, 31);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // tlpResultados
            // 
            this.tlpResultados.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpResultados.ColumnCount = 2;
            this.tlpResultados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpResultados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpResultados.Controls.Add(this.lblPadrones, 1, 17);
            this.tlpResultados.Controls.Add(this.label35, 0, 17);
            this.tlpResultados.Controls.Add(this.lblFechaAfiliacionPLE, 1, 16);
            this.tlpResultados.Controls.Add(this.label33, 0, 16);
            this.tlpResultados.Controls.Add(this.lblComprobanteElectronico, 1, 15);
            this.tlpResultados.Controls.Add(this.label31, 0, 15);
            this.tlpResultados.Controls.Add(this.lblFechaEmisionElectronico, 1, 14);
            this.tlpResultados.Controls.Add(this.label29, 0, 14);
            this.tlpResultados.Controls.Add(this.lblSistemaEmisionElectronica, 1, 13);
            this.tlpResultados.Controls.Add(this.label27, 0, 13);
            this.tlpResultados.Controls.Add(this.lblActividadEconomica, 1, 12);
            this.tlpResultados.Controls.Add(this.label25, 0, 12);
            this.tlpResultados.Controls.Add(this.lblSistemaContabilidad, 1, 11);
            this.tlpResultados.Controls.Add(this.label23, 0, 11);
            this.tlpResultados.Controls.Add(this.lblActividadComercioExterior, 1, 10);
            this.tlpResultados.Controls.Add(this.label21, 0, 10);
            this.tlpResultados.Controls.Add(this.lblSistemaEmisionComprobante, 1, 9);
            this.tlpResultados.Controls.Add(this.label19, 0, 9);
            this.tlpResultados.Controls.Add(this.lblDomicilioFiscal, 1, 8);
            this.tlpResultados.Controls.Add(this.label17, 0, 8);
            this.tlpResultados.Controls.Add(this.lblCondicionContribuyente, 1, 7);
            this.tlpResultados.Controls.Add(this.label15, 0, 7);
            this.tlpResultados.Controls.Add(this.lblEstadoContribuyente, 1, 6);
            this.tlpResultados.Controls.Add(this.label13, 0, 6);
            this.tlpResultados.Controls.Add(this.lblFechaInicioActividades, 1, 5);
            this.tlpResultados.Controls.Add(this.label11, 0, 5);
            this.tlpResultados.Controls.Add(this.lblFechaInscripcion, 1, 4);
            this.tlpResultados.Controls.Add(this.label9, 0, 4);
            this.tlpResultados.Controls.Add(this.lblNombreComercial, 1, 3);
            this.tlpResultados.Controls.Add(this.label7, 0, 3);
            this.tlpResultados.Controls.Add(this.lblTipoContribuyente, 1, 2);
            this.tlpResultados.Controls.Add(this.label5, 0, 2);
            this.tlpResultados.Controls.Add(this.lblRazonSocial, 1, 1);
            this.tlpResultados.Controls.Add(this.label3, 0, 1);
            this.tlpResultados.Controls.Add(this.lblNroRUC, 1, 0);
            this.tlpResultados.Controls.Add(this.label1, 0, 0);
            this.tlpResultados.Location = new System.Drawing.Point(0, 49);
            this.tlpResultados.Margin = new System.Windows.Forms.Padding(4);
            this.tlpResultados.Name = "tlpResultados";
            this.tlpResultados.RowCount = 18;
            this.tlpResultados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.110732F));
            this.tlpResultados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.621806F));
            this.tlpResultados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.579216F));
            this.tlpResultados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.579216F));
            this.tlpResultados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.579216F));
            this.tlpResultados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.579216F));
            this.tlpResultados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.579216F));
            this.tlpResultados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.579216F));
            this.tlpResultados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.579216F));
            this.tlpResultados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.579216F));
            this.tlpResultados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.579216F));
            this.tlpResultados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.579216F));
            this.tlpResultados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.579216F));
            this.tlpResultados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.579216F));
            this.tlpResultados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.579216F));
            this.tlpResultados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.579216F));
            this.tlpResultados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.579216F));
            this.tlpResultados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.579216F));
            this.tlpResultados.Size = new System.Drawing.Size(1547, 468);
            this.tlpResultados.TabIndex = 4;
            // 
            // lblPadrones
            // 
            this.lblPadrones.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblPadrones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPadrones.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPadrones.Location = new System.Drawing.Point(314, 440);
            this.lblPadrones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPadrones.Name = "lblPadrones";
            this.lblPadrones.Size = new System.Drawing.Size(1228, 27);
            this.lblPadrones.TabIndex = 35;
            this.lblPadrones.Text = "-";
            this.lblPadrones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label35
            // 
            this.label35.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label35.Font = new System.Drawing.Font("Georgia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(5, 440);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(300, 27);
            this.label35.TabIndex = 34;
            this.label35.Text = "Padrones:";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFechaAfiliacionPLE
            // 
            this.lblFechaAfiliacionPLE.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblFechaAfiliacionPLE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFechaAfiliacionPLE.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAfiliacionPLE.Location = new System.Drawing.Point(314, 414);
            this.lblFechaAfiliacionPLE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaAfiliacionPLE.Name = "lblFechaAfiliacionPLE";
            this.lblFechaAfiliacionPLE.Size = new System.Drawing.Size(1228, 25);
            this.lblFechaAfiliacionPLE.TabIndex = 33;
            this.lblFechaAfiliacionPLE.Text = "-";
            this.lblFechaAfiliacionPLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label33
            // 
            this.label33.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label33.Font = new System.Drawing.Font("Georgia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(5, 414);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(300, 25);
            this.label33.TabIndex = 32;
            this.label33.Text = "Afiliado al PLE desde:";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblComprobanteElectronico
            // 
            this.lblComprobanteElectronico.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblComprobanteElectronico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblComprobanteElectronico.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprobanteElectronico.Location = new System.Drawing.Point(314, 388);
            this.lblComprobanteElectronico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComprobanteElectronico.Name = "lblComprobanteElectronico";
            this.lblComprobanteElectronico.Size = new System.Drawing.Size(1228, 25);
            this.lblComprobanteElectronico.TabIndex = 31;
            this.lblComprobanteElectronico.Text = "-";
            this.lblComprobanteElectronico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label31
            // 
            this.label31.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Font = new System.Drawing.Font("Georgia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(5, 388);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(300, 25);
            this.label31.TabIndex = 30;
            this.label31.Text = "Comprobantes Electrónicos:";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFechaEmisionElectronico
            // 
            this.lblFechaEmisionElectronico.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblFechaEmisionElectronico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFechaEmisionElectronico.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEmisionElectronico.Location = new System.Drawing.Point(314, 362);
            this.lblFechaEmisionElectronico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaEmisionElectronico.Name = "lblFechaEmisionElectronico";
            this.lblFechaEmisionElectronico.Size = new System.Drawing.Size(1228, 25);
            this.lblFechaEmisionElectronico.TabIndex = 29;
            this.lblFechaEmisionElectronico.Text = "-";
            this.lblFechaEmisionElectronico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label29
            // 
            this.label29.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Font = new System.Drawing.Font("Georgia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(5, 362);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(300, 25);
            this.label29.TabIndex = 28;
            this.label29.Text = "Emisor electrónico desde:";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSistemaEmisionElectronica
            // 
            this.lblSistemaEmisionElectronica.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblSistemaEmisionElectronica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSistemaEmisionElectronica.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistemaEmisionElectronica.Location = new System.Drawing.Point(314, 336);
            this.lblSistemaEmisionElectronica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSistemaEmisionElectronica.Name = "lblSistemaEmisionElectronica";
            this.lblSistemaEmisionElectronica.Size = new System.Drawing.Size(1228, 25);
            this.lblSistemaEmisionElectronica.TabIndex = 27;
            this.lblSistemaEmisionElectronica.Text = "-";
            this.lblSistemaEmisionElectronica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label27
            // 
            this.label27.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Font = new System.Drawing.Font("Georgia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(5, 336);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(300, 25);
            this.label27.TabIndex = 26;
            this.label27.Text = "Sistema de Emisión Electrónica:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActividadEconomica
            // 
            this.lblActividadEconomica.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblActividadEconomica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActividadEconomica.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividadEconomica.Location = new System.Drawing.Point(314, 310);
            this.lblActividadEconomica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActividadEconomica.Name = "lblActividadEconomica";
            this.lblActividadEconomica.Size = new System.Drawing.Size(1228, 25);
            this.lblActividadEconomica.TabIndex = 25;
            this.lblActividadEconomica.Text = "-";
            this.lblActividadEconomica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            this.label25.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("Georgia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(5, 310);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(300, 25);
            this.label25.TabIndex = 24;
            this.label25.Text = "Actividad Económica:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSistemaContabilidad
            // 
            this.lblSistemaContabilidad.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblSistemaContabilidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSistemaContabilidad.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistemaContabilidad.Location = new System.Drawing.Point(314, 284);
            this.lblSistemaContabilidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSistemaContabilidad.Name = "lblSistemaContabilidad";
            this.lblSistemaContabilidad.Size = new System.Drawing.Size(1228, 25);
            this.lblSistemaContabilidad.TabIndex = 23;
            this.lblSistemaContabilidad.Text = "-";
            this.lblSistemaContabilidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            this.label23.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Font = new System.Drawing.Font("Georgia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(5, 284);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(300, 25);
            this.label23.TabIndex = 22;
            this.label23.Text = "Sistema Contabilidad:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActividadComercioExterior
            // 
            this.lblActividadComercioExterior.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblActividadComercioExterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActividadComercioExterior.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividadComercioExterior.Location = new System.Drawing.Point(314, 258);
            this.lblActividadComercioExterior.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActividadComercioExterior.Name = "lblActividadComercioExterior";
            this.lblActividadComercioExterior.Size = new System.Drawing.Size(1228, 25);
            this.lblActividadComercioExterior.TabIndex = 21;
            this.lblActividadComercioExterior.Text = "-";
            this.lblActividadComercioExterior.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Georgia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(5, 258);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(300, 25);
            this.label21.TabIndex = 20;
            this.label21.Text = "Actividad Comercio Exterior:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSistemaEmisionComprobante
            // 
            this.lblSistemaEmisionComprobante.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblSistemaEmisionComprobante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSistemaEmisionComprobante.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistemaEmisionComprobante.Location = new System.Drawing.Point(314, 232);
            this.lblSistemaEmisionComprobante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSistemaEmisionComprobante.Name = "lblSistemaEmisionComprobante";
            this.lblSistemaEmisionComprobante.Size = new System.Drawing.Size(1228, 25);
            this.lblSistemaEmisionComprobante.TabIndex = 19;
            this.lblSistemaEmisionComprobante.Text = "-";
            this.lblSistemaEmisionComprobante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Georgia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(5, 232);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(300, 25);
            this.label19.TabIndex = 18;
            this.label19.Text = "Sistema Emisión de Comprobante:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDomicilioFiscal
            // 
            this.lblDomicilioFiscal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblDomicilioFiscal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDomicilioFiscal.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilioFiscal.Location = new System.Drawing.Point(314, 206);
            this.lblDomicilioFiscal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDomicilioFiscal.Name = "lblDomicilioFiscal";
            this.lblDomicilioFiscal.Size = new System.Drawing.Size(1228, 25);
            this.lblDomicilioFiscal.TabIndex = 17;
            this.lblDomicilioFiscal.Text = "-";
            this.lblDomicilioFiscal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Georgia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(5, 206);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(300, 25);
            this.label17.TabIndex = 16;
            this.label17.Text = "Domicilio Fiscal:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCondicionContribuyente
            // 
            this.lblCondicionContribuyente.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblCondicionContribuyente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCondicionContribuyente.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicionContribuyente.Location = new System.Drawing.Point(314, 180);
            this.lblCondicionContribuyente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCondicionContribuyente.Name = "lblCondicionContribuyente";
            this.lblCondicionContribuyente.Size = new System.Drawing.Size(1228, 25);
            this.lblCondicionContribuyente.TabIndex = 15;
            this.lblCondicionContribuyente.Text = "-";
            this.lblCondicionContribuyente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Georgia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(5, 180);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(300, 25);
            this.label15.TabIndex = 14;
            this.label15.Text = "Condición del Contribuyente:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEstadoContribuyente
            // 
            this.lblEstadoContribuyente.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblEstadoContribuyente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstadoContribuyente.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoContribuyente.Location = new System.Drawing.Point(314, 154);
            this.lblEstadoContribuyente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoContribuyente.Name = "lblEstadoContribuyente";
            this.lblEstadoContribuyente.Size = new System.Drawing.Size(1228, 25);
            this.lblEstadoContribuyente.TabIndex = 13;
            this.lblEstadoContribuyente.Text = "-";
            this.lblEstadoContribuyente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Georgia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 154);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(300, 25);
            this.label13.TabIndex = 12;
            this.label13.Text = "Estado del Contribuyente:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFechaInicioActividades
            // 
            this.lblFechaInicioActividades.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblFechaInicioActividades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFechaInicioActividades.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicioActividades.Location = new System.Drawing.Point(314, 128);
            this.lblFechaInicioActividades.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaInicioActividades.Name = "lblFechaInicioActividades";
            this.lblFechaInicioActividades.Size = new System.Drawing.Size(1228, 25);
            this.lblFechaInicioActividades.TabIndex = 11;
            this.lblFechaInicioActividades.Text = "-";
            this.lblFechaInicioActividades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Georgia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 128);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(300, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "Fecha de Inicio de Actividades:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFechaInscripcion
            // 
            this.lblFechaInscripcion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblFechaInscripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFechaInscripcion.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInscripcion.Location = new System.Drawing.Point(314, 102);
            this.lblFechaInscripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaInscripcion.Name = "lblFechaInscripcion";
            this.lblFechaInscripcion.Size = new System.Drawing.Size(1228, 25);
            this.lblFechaInscripcion.TabIndex = 9;
            this.lblFechaInscripcion.Text = "-";
            this.lblFechaInscripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Georgia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 102);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(300, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fecha de Inscripción:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombreComercial
            // 
            this.lblNombreComercial.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblNombreComercial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreComercial.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreComercial.Location = new System.Drawing.Point(314, 76);
            this.lblNombreComercial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreComercial.Name = "lblNombreComercial";
            this.lblNombreComercial.Size = new System.Drawing.Size(1228, 25);
            this.lblNombreComercial.TabIndex = 7;
            this.lblNombreComercial.Text = "-";
            this.lblNombreComercial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Georgia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(300, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre Comercial:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTipoContribuyente
            // 
            this.lblTipoContribuyente.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTipoContribuyente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTipoContribuyente.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoContribuyente.Location = new System.Drawing.Point(314, 50);
            this.lblTipoContribuyente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoContribuyente.Name = "lblTipoContribuyente";
            this.lblTipoContribuyente.Size = new System.Drawing.Size(1228, 25);
            this.lblTipoContribuyente.TabIndex = 5;
            this.lblTipoContribuyente.Text = "-";
            this.lblTipoContribuyente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Georgia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo Contribuyente:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblRazonSocial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRazonSocial.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(314, 24);
            this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(1228, 25);
            this.lblRazonSocial.TabIndex = 3;
            this.lblRazonSocial.Text = "-";
            this.lblRazonSocial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Georgia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Razón Social:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNroRUC
            // 
            this.lblNroRUC.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblNroRUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNroRUC.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroRUC.Location = new System.Drawing.Point(314, 1);
            this.lblNroRUC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroRUC.Name = "lblNroRUC";
            this.lblNroRUC.Size = new System.Drawing.Size(1228, 22);
            this.lblNroRUC.TabIndex = 1;
            this.lblNroRUC.Text = "-";
            this.lblNroRUC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Georgia", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de RUC:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle2
            // 
            this.lblTitle2.BackColor = System.Drawing.Color.SkyBlue;
            this.lblTitle2.Font = new System.Drawing.Font("Elephant", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Location = new System.Drawing.Point(0, 0);
            this.lblTitle2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(1547, 49);
            this.lblTitle2.TabIndex = 3;
            this.lblTitle2.Text = "Resultados de la Búsqueda";
            this.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1579, 887);
            this.Controls.Add(this.paResultadosBusqueda);
            this.Controls.Add(this.paCriteriosBusqueda);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Consulta RUC";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.paCriteriosBusqueda.ResumeLayout(false);
            this.paCriteriosBusqueda.PerformLayout();
            this.paResultadosBusqueda.ResumeLayout(false);
            this.tlpResultados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel paCriteriosBusqueda;
        private System.Windows.Forms.Panel paResultadosBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbRUC;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.TableLayoutPanel tlpResultados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPadrones;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label lblFechaAfiliacionPLE;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lblComprobanteElectronico;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lblFechaEmisionElectronico;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblSistemaEmisionElectronica;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblActividadEconomica;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblSistemaContabilidad;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblActividadComercioExterior;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblSistemaEmisionComprobante;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblDomicilioFiscal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblCondicionContribuyente;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblEstadoContribuyente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblFechaInicioActividades;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblFechaInscripcion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNombreComercial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTipoContribuyente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNroRUC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblTitle1;
    }
}

