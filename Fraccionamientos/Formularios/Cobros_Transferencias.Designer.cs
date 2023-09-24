
namespace Fraccionamientos.Formularios
{
    partial class Cobros_Transferencias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbMovimiento = new System.Windows.Forms.ComboBox();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.cbAño = new System.Windows.Forms.ComboBox();
            this.dtpFechaTransaccion = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraTransaccion = new System.Windows.Forms.DateTimePicker();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.dgwCobros = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnImagen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.RbInactivo = new System.Windows.Forms.RadioButton();
            this.RbActivo = new System.Windows.Forms.RadioButton();
            this.CbPropietarios = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbDocumento = new System.Windows.Forms.PictureBox();
            this.txtCve = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCorreo = new System.Windows.Forms.Button();
            this.btnTarjeton = new System.Windows.Forms.Button();
            this.txtTarjeton = new System.Windows.Forms.TextBox();
            this.cbBimestre = new System.Windows.Forms.ComboBox();
            this.gbBimestre = new System.Windows.Forms.GroupBox();
            this.lblFraccionamiento = new System.Windows.Forms.Label();
            this.txtFrac = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCobros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDocumento)).BeginInit();
            this.gbBimestre.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMovimiento
            // 
            this.cbMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMovimiento.FormattingEnabled = true;
            this.cbMovimiento.Location = new System.Drawing.Point(214, 96);
            this.cbMovimiento.Name = "cbMovimiento";
            this.cbMovimiento.Size = new System.Drawing.Size(396, 28);
            this.cbMovimiento.TabIndex = 1;
            this.cbMovimiento.SelectedIndexChanged += new System.EventHandler(this.cbMovimiento_SelectedIndexChanged);
            // 
            // cbMes
            // 
            this.cbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.cbMes.Location = new System.Drawing.Point(214, 199);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(121, 28);
            this.cbMes.TabIndex = 2;
            this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
            // 
            // cbAño
            // 
            this.cbAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAño.FormattingEnabled = true;
            this.cbAño.Location = new System.Drawing.Point(214, 148);
            this.cbAño.Name = "cbAño";
            this.cbAño.Size = new System.Drawing.Size(121, 28);
            this.cbAño.TabIndex = 3;
            this.cbAño.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
            this.cbAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAño_KeyPress);
            // 
            // dtpFechaTransaccion
            // 
            this.dtpFechaTransaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaTransaccion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaTransaccion.Location = new System.Drawing.Point(214, 249);
            this.dtpFechaTransaccion.Name = "dtpFechaTransaccion";
            this.dtpFechaTransaccion.Size = new System.Drawing.Size(111, 29);
            this.dtpFechaTransaccion.TabIndex = 4;
            // 
            // dtpHoraTransaccion
            // 
            this.dtpHoraTransaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraTransaccion.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraTransaccion.Location = new System.Drawing.Point(214, 303);
            this.dtpHoraTransaccion.Name = "dtpHoraTransaccion";
            this.dtpHoraTransaccion.Size = new System.Drawing.Size(111, 29);
            this.dtpHoraTransaccion.TabIndex = 5;
            // 
            // txtImporte
            // 
            this.txtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.Location = new System.Drawing.Point(214, 345);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(111, 29);
            this.txtImporte.TabIndex = 6;
            this.txtImporte.Text = "$0.00";
            this.txtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(214, 402);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(486, 64);
            this.txtObservaciones.TabIndex = 8;
            // 
            // dgwCobros
            // 
            this.dgwCobros.AllowUserToAddRows = false;
            this.dgwCobros.AllowUserToDeleteRows = false;
            this.dgwCobros.AllowUserToOrderColumns = true;
            this.dgwCobros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCobros.Location = new System.Drawing.Point(12, 475);
            this.dgwCobros.Name = "dgwCobros";
            this.dgwCobros.ReadOnly = true;
            this.dgwCobros.Size = new System.Drawing.Size(1026, 190);
            this.dgwCobros.TabIndex = 9;
            this.dgwCobros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCobros_CellContentClick);
            this.dgwCobros.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwCobros_CellMouseClick);
            this.dgwCobros.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgwCobros_KeyDown);
            this.dgwCobros.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgwCobros_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Clave Propietario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Movimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Año:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fecha Transaccion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Hora Transaccion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Importe:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(720, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Imagen Comprobante Trasnferencia o Deposito";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(865, 402);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(173, 23);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(79, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 22);
            this.label9.TabIndex = 20;
            this.label9.Text = "PROPIETARIO";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(217, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(393, 29);
            this.txtNombre.TabIndex = 19;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(51, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "Observaciones:";
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(773, 369);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(126, 23);
            this.btnImagen.TabIndex = 24;
            this.btnImagen.Text = "Buscar Documento";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Fraccionamientos.Properties.Resources.delete_remove_close_icon_181533;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1052, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 47);
            this.button1.TabIndex = 161;
            this.button1.Text = "    Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(1052, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 47);
            this.button2.TabIndex = 160;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEditar.Location = new System.Drawing.Point(1052, 285);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(114, 47);
            this.btnEditar.TabIndex = 159;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnGuardar.Location = new System.Drawing.Point(1052, 201);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 47);
            this.btnGuardar.TabIndex = 158;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNuevo.Location = new System.Drawing.Point(1052, 124);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(114, 47);
            this.btnNuevo.TabIndex = 157;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // RbInactivo
            // 
            this.RbInactivo.AutoSize = true;
            this.RbInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbInactivo.Location = new System.Drawing.Point(856, 441);
            this.RbInactivo.Name = "RbInactivo";
            this.RbInactivo.Size = new System.Drawing.Size(90, 24);
            this.RbInactivo.TabIndex = 203;
            this.RbInactivo.Text = "Inactivo";
            this.RbInactivo.UseVisualStyleBackColor = true;
            // 
            // RbActivo
            // 
            this.RbActivo.AutoSize = true;
            this.RbActivo.Checked = true;
            this.RbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbActivo.Location = new System.Drawing.Point(773, 441);
            this.RbActivo.Name = "RbActivo";
            this.RbActivo.Size = new System.Drawing.Size(76, 24);
            this.RbActivo.TabIndex = 202;
            this.RbActivo.TabStop = true;
            this.RbActivo.Text = "Activo";
            this.RbActivo.UseVisualStyleBackColor = true;
            // 
            // CbPropietarios
            // 
            this.CbPropietarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbPropietarios.FormattingEnabled = true;
            this.CbPropietarios.Location = new System.Drawing.Point(217, 9);
            this.CbPropietarios.Name = "CbPropietarios";
            this.CbPropietarios.Size = new System.Drawing.Size(155, 28);
            this.CbPropietarios.TabIndex = 204;
            this.CbPropietarios.SelectedIndexChanged += new System.EventHandler(this.CbPropietarios_SelectedIndexChanged);
            this.CbPropietarios.SelectedValueChanged += new System.EventHandler(this.CbPropietarios_SelectedValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox2.Image = global::Fraccionamientos.Properties.Resources.titulo;
            this.pictureBox2.Location = new System.Drawing.Point(987, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(206, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 206;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox1.Image = global::Fraccionamientos.Properties.Resources.Terramar_Andaman_;
            this.pictureBox1.Location = new System.Drawing.Point(886, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 205;
            this.pictureBox1.TabStop = false;
            // 
            // pbDocumento
            // 
            this.pbDocumento.BackColor = System.Drawing.Color.MidnightBlue;
            this.pbDocumento.Location = new System.Drawing.Point(701, 112);
            this.pbDocumento.Name = "pbDocumento";
            this.pbDocumento.Size = new System.Drawing.Size(287, 251);
            this.pbDocumento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDocumento.TabIndex = 7;
            this.pbDocumento.TabStop = false;
            // 
            // txtCve
            // 
            this.txtCve.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCve.Location = new System.Drawing.Point(12, 12);
            this.txtCve.Name = "txtCve";
            this.txtCve.Size = new System.Drawing.Size(18, 20);
            this.txtCve.TabIndex = 207;
            this.txtCve.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 668);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(246, 25);
            this.label11.TabIndex = 208;
            this.label11.Text = "APORTACION  TOTAL:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotal.Location = new System.Drawing.Point(270, 667);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 25);
            this.lblTotal.TabIndex = 209;
            // 
            // btnCorreo
            // 
            this.btnCorreo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCorreo.Enabled = false;
            this.btnCorreo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCorreo.Location = new System.Drawing.Point(744, 667);
            this.btnCorreo.Name = "btnCorreo";
            this.btnCorreo.Size = new System.Drawing.Size(136, 45);
            this.btnCorreo.TabIndex = 210;
            this.btnCorreo.Text = "Enviar Reporte Propietario";
            this.btnCorreo.UseVisualStyleBackColor = false;
            this.btnCorreo.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnTarjeton
            // 
            this.btnTarjeton.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTarjeton.Enabled = false;
            this.btnTarjeton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnTarjeton.Location = new System.Drawing.Point(886, 668);
            this.btnTarjeton.Name = "btnTarjeton";
            this.btnTarjeton.Size = new System.Drawing.Size(136, 45);
            this.btnTarjeton.TabIndex = 211;
            this.btnTarjeton.Text = "Envia Tarjetón";
            this.btnTarjeton.UseVisualStyleBackColor = false;
            this.btnTarjeton.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // txtTarjeton
            // 
            this.txtTarjeton.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTarjeton.Location = new System.Drawing.Point(39, 12);
            this.txtTarjeton.Name = "txtTarjeton";
            this.txtTarjeton.Size = new System.Drawing.Size(66, 20);
            this.txtTarjeton.TabIndex = 212;
            this.txtTarjeton.Visible = false;
            // 
            // cbBimestre
            // 
            this.cbBimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBimestre.FormattingEnabled = true;
            this.cbBimestre.Location = new System.Drawing.Point(6, 19);
            this.cbBimestre.Name = "cbBimestre";
            this.cbBimestre.Size = new System.Drawing.Size(227, 28);
            this.cbBimestre.TabIndex = 213;
            // 
            // gbBimestre
            // 
            this.gbBimestre.Controls.Add(this.cbBimestre);
            this.gbBimestre.Location = new System.Drawing.Point(370, 130);
            this.gbBimestre.Name = "gbBimestre";
            this.gbBimestre.Size = new System.Drawing.Size(247, 54);
            this.gbBimestre.TabIndex = 214;
            this.gbBimestre.TabStop = false;
            this.gbBimestre.Text = "Bimestre";
            this.gbBimestre.Visible = false;
            // 
            // lblFraccionamiento
            // 
            this.lblFraccionamiento.AutoSize = true;
            this.lblFraccionamiento.Location = new System.Drawing.Point(582, 12);
            this.lblFraccionamiento.Name = "lblFraccionamiento";
            this.lblFraccionamiento.Size = new System.Drawing.Size(35, 13);
            this.lblFraccionamiento.TabIndex = 216;
            this.lblFraccionamiento.Text = "label1";
            // 
            // txtFrac
            // 
            this.txtFrac.Location = new System.Drawing.Point(786, 9);
            this.txtFrac.Name = "txtFrac";
            this.txtFrac.Size = new System.Drawing.Size(46, 20);
            this.txtFrac.TabIndex = 215;
            this.txtFrac.Visible = false;
            // 
            // Cobros_Transferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1193, 749);
            this.ControlBox = false;
            this.Controls.Add(this.lblFraccionamiento);
            this.Controls.Add(this.txtFrac);
            this.Controls.Add(this.gbBimestre);
            this.Controls.Add(this.txtTarjeton);
            this.Controls.Add(this.btnTarjeton);
            this.Controls.Add(this.btnCorreo);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCve);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CbPropietarios);
            this.Controls.Add(this.RbInactivo);
            this.Controls.Add(this.RbActivo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwCobros);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.pbDocumento);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.dtpHoraTransaccion);
            this.Controls.Add(this.dtpFechaTransaccion);
            this.Controls.Add(this.cbAño);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.cbMovimiento);
            this.Name = "Cobros_Transferencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobros_Transferencias";
            this.Load += new System.EventHandler(this.Pagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCobros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDocumento)).EndInit();
            this.gbBimestre.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbMovimiento;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.ComboBox cbAño;
        private System.Windows.Forms.DateTimePicker dtpFechaTransaccion;
        private System.Windows.Forms.DateTimePicker dtpHoraTransaccion;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.PictureBox pbDocumento;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.DataGridView dgwCobros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.RadioButton RbInactivo;
        private System.Windows.Forms.RadioButton RbActivo;
        private System.Windows.Forms.ComboBox CbPropietarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        internal System.Windows.Forms.TextBox txtCve;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCorreo;
        private System.Windows.Forms.Button btnTarjeton;
        internal System.Windows.Forms.TextBox txtTarjeton;
        private System.Windows.Forms.ComboBox cbBimestre;
        private System.Windows.Forms.GroupBox gbBimestre;
        public System.Windows.Forms.Label lblFraccionamiento;
        public System.Windows.Forms.TextBox txtFrac;
    }
}