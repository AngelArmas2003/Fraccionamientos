
namespace Fraccionamientos.Formularios
{
    partial class Recibos_de_Luz
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
            this.btnImagen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImpo_depto = new System.Windows.Forms.TextBox();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dgwRecibos = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpfinal = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaLimite = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeptos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImporteRecibo = new System.Windows.Forms.TextBox();
            this.RbInactivo = new System.Windows.Forms.RadioButton();
            this.RbPagado = new System.Windows.Forms.RadioButton();
            this.gbPagado = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pbDocumento = new System.Windows.Forms.PictureBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.lblFraccionamiento = new System.Windows.Forms.Label();
            this.txtFrac = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRecibos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbPagado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDocumento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(57, 434);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(141, 37);
            this.btnImagen.TabIndex = 25;
            this.btnImagen.Text = "Buscar Documento";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(491, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 24);
            this.label7.TabIndex = 217;
            this.label7.Text = "Importe por Departamento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(604, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 211;
            this.label1.Text = "Fecha Limite Pago:";
            // 
            // txtImpo_depto
            // 
            this.txtImpo_depto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpo_depto.Location = new System.Drawing.Point(811, 376);
            this.txtImpo_depto.Name = "txtImpo_depto";
            this.txtImpo_depto.Size = new System.Drawing.Size(111, 29);
            this.txtImpo_depto.TabIndex = 210;
            this.txtImpo_depto.Text = "$0.00";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(119, 35);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(111, 29);
            this.dtpInicio.TabIndex = 208;
            // 
            // dgwRecibos
            // 
            this.dgwRecibos.AllowUserToAddRows = false;
            this.dgwRecibos.AllowUserToDeleteRows = false;
            this.dgwRecibos.AllowUserToOrderColumns = true;
            this.dgwRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRecibos.Location = new System.Drawing.Point(12, 483);
            this.dgwRecibos.Name = "dgwRecibos";
            this.dgwRecibos.ReadOnly = true;
            this.dgwRecibos.Size = new System.Drawing.Size(1026, 139);
            this.dgwRecibos.TabIndex = 219;
            this.dgwRecibos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwRecibos_CellContentClick);
            this.dgwRecibos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwRecibos_CellMouseClick);
            this.dgwRecibos.CellToolTipTextChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwRecibos_CellToolTipTextChanged);
            this.dgwRecibos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgwRecibos_KeyDown);
            this.dgwRecibos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgwRecibos_KeyUp);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(992, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 47);
            this.button2.TabIndex = 223;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEditar.Location = new System.Drawing.Point(992, 220);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(114, 47);
            this.btnEditar.TabIndex = 222;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnGuardar.Location = new System.Drawing.Point(992, 136);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 47);
            this.btnGuardar.TabIndex = 221;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNuevo.Location = new System.Drawing.Point(992, 59);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(114, 47);
            this.btnNuevo.TabIndex = 220;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 226;
            this.label6.Text = "Inicio:";
            // 
            // dtpfinal
            // 
            this.dtpfinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfinal.Location = new System.Drawing.Point(119, 85);
            this.dtpfinal.Name = "dtpfinal";
            this.dtpfinal.Size = new System.Drawing.Size(111, 29);
            this.dtpfinal.TabIndex = 225;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 24);
            this.label8.TabIndex = 227;
            this.label8.Text = "Final:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpfinal);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtpInicio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(651, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 144);
            this.groupBox1.TabIndex = 228;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Periodo";
            // 
            // dtpFechaLimite
            // 
            this.dtpFechaLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaLimite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLimite.Location = new System.Drawing.Point(822, 45);
            this.dtpFechaLimite.Name = "dtpFechaLimite";
            this.dtpFechaLimite.Size = new System.Drawing.Size(111, 29);
            this.dtpFechaLimite.TabIndex = 228;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(548, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 24);
            this.label2.TabIndex = 229;
            this.label2.Text = "Total Departamentos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDeptos
            // 
            this.txtDeptos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeptos.Location = new System.Drawing.Point(811, 275);
            this.txtDeptos.Name = "txtDeptos";
            this.txtDeptos.Size = new System.Drawing.Size(111, 29);
            this.txtDeptos.TabIndex = 230;
            this.txtDeptos.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(598, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 24);
            this.label3.TabIndex = 232;
            this.label3.Text = "Importe Recibo";
            // 
            // txtImporteRecibo
            // 
            this.txtImporteRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporteRecibo.Location = new System.Drawing.Point(811, 323);
            this.txtImporteRecibo.Name = "txtImporteRecibo";
            this.txtImporteRecibo.Size = new System.Drawing.Size(111, 29);
            this.txtImporteRecibo.TabIndex = 231;
            this.txtImporteRecibo.Text = "$0.00";
            this.txtImporteRecibo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporteRecibo_KeyPress);
            // 
            // RbInactivo
            // 
            this.RbInactivo.AutoSize = true;
            this.RbInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbInactivo.Location = new System.Drawing.Point(103, 16);
            this.RbInactivo.Name = "RbInactivo";
            this.RbInactivo.Size = new System.Drawing.Size(52, 24);
            this.RbInactivo.TabIndex = 234;
            this.RbInactivo.Text = "NO";
            this.RbInactivo.UseVisualStyleBackColor = true;
            // 
            // RbPagado
            // 
            this.RbPagado.AutoSize = true;
            this.RbPagado.Checked = true;
            this.RbPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbPagado.Location = new System.Drawing.Point(38, 15);
            this.RbPagado.Name = "RbPagado";
            this.RbPagado.Size = new System.Drawing.Size(45, 24);
            this.RbPagado.TabIndex = 233;
            this.RbPagado.TabStop = true;
            this.RbPagado.Text = "SI";
            this.RbPagado.UseVisualStyleBackColor = true;
            // 
            // gbPagado
            // 
            this.gbPagado.Controls.Add(this.RbInactivo);
            this.gbPagado.Controls.Add(this.RbPagado);
            this.gbPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPagado.Location = new System.Drawing.Point(274, 434);
            this.gbPagado.Name = "gbPagado";
            this.gbPagado.Size = new System.Drawing.Size(191, 47);
            this.gbPagado.TabIndex = 235;
            this.gbPagado.TabStop = false;
            this.gbPagado.Text = "PAGADO";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Fraccionamientos.Properties.Resources.delete_remove_close_icon_181533;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(992, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 47);
            this.button1.TabIndex = 224;
            this.button1.Text = "    Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbDocumento
            // 
            this.pbDocumento.BackColor = System.Drawing.Color.MidnightBlue;
            this.pbDocumento.Location = new System.Drawing.Point(57, -2);
            this.pbDocumento.Name = "pbDocumento";
            this.pbDocumento.Size = new System.Drawing.Size(408, 434);
            this.pbDocumento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDocumento.TabIndex = 0;
            this.pbDocumento.TabStop = false;
            // 
            // txtid
            // 
            this.txtid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtid.Location = new System.Drawing.Point(12, 12);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(18, 20);
            this.txtid.TabIndex = 236;
            this.txtid.Visible = false;
            // 
            // button4
            // 
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(851, 440);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 41);
            this.button4.TabIndex = 248;
            this.button4.Text = "Envio de Recibo";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblFraccionamiento
            // 
            this.lblFraccionamiento.AutoSize = true;
            this.lblFraccionamiento.Location = new System.Drawing.Point(819, 12);
            this.lblFraccionamiento.Name = "lblFraccionamiento";
            this.lblFraccionamiento.Size = new System.Drawing.Size(35, 13);
            this.lblFraccionamiento.TabIndex = 250;
            this.lblFraccionamiento.Text = "label1";
            // 
            // txtFrac
            // 
            this.txtFrac.Location = new System.Drawing.Point(1023, 9);
            this.txtFrac.Name = "txtFrac";
            this.txtFrac.Size = new System.Drawing.Size(46, 20);
            this.txtFrac.TabIndex = 249;
            this.txtFrac.Visible = false;
            // 
            // Recibos_de_Luz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 679);
            this.Controls.Add(this.lblFraccionamiento);
            this.Controls.Add(this.txtFrac);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.gbPagado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtImporteRecibo);
            this.Controls.Add(this.txtDeptos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaLimite);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgwRecibos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImpo_depto);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.pbDocumento);
            this.Name = "Recibos_de_Luz";
            this.Text = "Recibos_de_Luz";
            this.Load += new System.EventHandler(this.Recibos_de_Luz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRecibos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbPagado.ResumeLayout(false);
            this.gbPagado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDocumento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDocumento;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImpo_depto;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DataGridView dgwRecibos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpfinal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaLimite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDeptos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtImporteRecibo;
        private System.Windows.Forms.RadioButton RbInactivo;
        private System.Windows.Forms.RadioButton RbPagado;
        private System.Windows.Forms.GroupBox gbPagado;
        internal System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.Label lblFraccionamiento;
        public System.Windows.Forms.TextBox txtFrac;
    }
}