
namespace Fraccionamientos.Formularios
{
    partial class Pago_Proveedores
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
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.btnImagen = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.dtpHoraTransaccion = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaTransaccion = new System.Windows.Forms.DateTimePicker();
            this.pbDocumento = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgwPagos = new System.Windows.Forms.DataGridView();
            this.txtCve = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblFraccionamiento = new System.Windows.Forms.Label();
            this.txtFrac = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbProveedor
            // 
            this.cbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(175, 9);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(718, 28);
            this.cbProveedor.TabIndex = 228;
            this.cbProveedor.SelectedIndexChanged += new System.EventHandler(this.cbProveedor_SelectedIndexChanged);
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(753, 358);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(126, 23);
            this.btnImagen.TabIndex = 225;
            this.btnImagen.Text = "Buscar Documento";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 381);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 24);
            this.label10.TabIndex = 224;
            this.label10.Text = "Observaciones:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(99, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 220;
            this.label7.Text = "Importe:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 24);
            this.label6.TabIndex = 219;
            this.label6.Text = "Hora Pago:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 24);
            this.label5.TabIndex = 218;
            this.label5.Text = "Fecha Pago";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 214;
            this.label1.Text = "Proveedor";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(198, 387);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(671, 76);
            this.txtObservaciones.TabIndex = 212;
            // 
            // txtImporte
            // 
            this.txtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.Location = new System.Drawing.Point(208, 222);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(111, 29);
            this.txtImporte.TabIndex = 210;
            this.txtImporte.Text = "$0.00";
            // 
            // dtpHoraTransaccion
            // 
            this.dtpHoraTransaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraTransaccion.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraTransaccion.Location = new System.Drawing.Point(208, 170);
            this.dtpHoraTransaccion.Name = "dtpHoraTransaccion";
            this.dtpHoraTransaccion.Size = new System.Drawing.Size(111, 29);
            this.dtpHoraTransaccion.TabIndex = 209;
            // 
            // dtpFechaTransaccion
            // 
            this.dtpFechaTransaccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaTransaccion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaTransaccion.Location = new System.Drawing.Point(208, 114);
            this.dtpFechaTransaccion.Name = "dtpFechaTransaccion";
            this.dtpFechaTransaccion.Size = new System.Drawing.Size(111, 29);
            this.dtpFechaTransaccion.TabIndex = 208;
            // 
            // pbDocumento
            // 
            this.pbDocumento.BackColor = System.Drawing.Color.MidnightBlue;
            this.pbDocumento.Location = new System.Drawing.Point(399, 43);
            this.pbDocumento.Name = "pbDocumento";
            this.pbDocumento.Size = new System.Drawing.Size(352, 333);
            this.pbDocumento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDocumento.TabIndex = 211;
            this.pbDocumento.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Fraccionamientos.Properties.Resources.delete_remove_close_icon_181533;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1032, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 47);
            this.button1.TabIndex = 233;
            this.button1.Text = "    Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(1032, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 47);
            this.button2.TabIndex = 232;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEditar.Location = new System.Drawing.Point(1032, 216);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(114, 47);
            this.btnEditar.TabIndex = 231;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnGuardar.Location = new System.Drawing.Point(1032, 132);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 47);
            this.btnGuardar.TabIndex = 230;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNuevo.Location = new System.Drawing.Point(1032, 55);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(114, 47);
            this.btnNuevo.TabIndex = 229;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgwPagos
            // 
            this.dgwPagos.AllowUserToAddRows = false;
            this.dgwPagos.AllowUserToDeleteRows = false;
            this.dgwPagos.AllowUserToOrderColumns = true;
            this.dgwPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPagos.Location = new System.Drawing.Point(198, 465);
            this.dgwPagos.Name = "dgwPagos";
            this.dgwPagos.ReadOnly = true;
            this.dgwPagos.Size = new System.Drawing.Size(671, 190);
            this.dgwPagos.TabIndex = 234;
            this.dgwPagos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwPagos_CellMouseClick);
            this.dgwPagos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgwPagos_KeyDown);
            this.dgwPagos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgwPagos_KeyUp);
            // 
            // txtCve
            // 
            this.txtCve.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCve.Location = new System.Drawing.Point(12, 12);
            this.txtCve.Name = "txtCve";
            this.txtCve.Size = new System.Drawing.Size(18, 20);
            this.txtCve.TabIndex = 235;
            this.txtCve.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotal.Location = new System.Drawing.Point(427, 658);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 25);
            this.lblTotal.TabIndex = 237;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(203, 659);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 25);
            this.label11.TabIndex = 236;
            this.label11.Text = "TOTAL PAGADO:";
            // 
            // lblFraccionamiento
            // 
            this.lblFraccionamiento.AutoSize = true;
            this.lblFraccionamiento.Location = new System.Drawing.Point(916, 16);
            this.lblFraccionamiento.Name = "lblFraccionamiento";
            this.lblFraccionamiento.Size = new System.Drawing.Size(35, 13);
            this.lblFraccionamiento.TabIndex = 243;
            this.lblFraccionamiento.Text = "label1";
            // 
            // txtFrac
            // 
            this.txtFrac.Location = new System.Drawing.Point(1120, 13);
            this.txtFrac.Name = "txtFrac";
            this.txtFrac.Size = new System.Drawing.Size(46, 20);
            this.txtFrac.TabIndex = 242;
            this.txtFrac.Visible = false;
            // 
            // Pago_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 708);
            this.Controls.Add(this.lblFraccionamiento);
            this.Controls.Add(this.txtFrac);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCve);
            this.Controls.Add(this.dgwPagos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.cbProveedor);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.pbDocumento);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.dtpHoraTransaccion);
            this.Controls.Add(this.dtpFechaTransaccion);
            this.Name = "Pago_Proveedores";
            this.Text = "Pago_Proveedores";
            this.Load += new System.EventHandler(this.Pago_Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.PictureBox pbDocumento;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.DateTimePicker dtpHoraTransaccion;
        private System.Windows.Forms.DateTimePicker dtpFechaTransaccion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgwPagos;
        internal System.Windows.Forms.TextBox txtCve;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label lblFraccionamiento;
        public System.Windows.Forms.TextBox txtFrac;
    }
}