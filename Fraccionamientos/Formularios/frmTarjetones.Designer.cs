
namespace Fraccionamientos.Formularios
{
    partial class frmTarjetones
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbTarjeton = new System.Windows.Forms.RadioButton();
            this.rbpizarron = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.rbLuz = new System.Windows.Forms.RadioButton();
            this.gbBimestre = new System.Windows.Forms.GroupBox();
            this.cbBimestre = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbAño = new System.Windows.Forms.ComboBox();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.rbManto = new System.Windows.Forms.RadioButton();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lblFraccionamiento = new System.Windows.Forms.Label();
            this.txtFrac = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.gbBimestre.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGray;
            this.groupBox3.Controls.Add(this.lblFraccionamiento);
            this.groupBox3.Controls.Add(this.txtFrac);
            this.groupBox3.Controls.Add(this.rbTarjeton);
            this.groupBox3.Controls.Add(this.rbpizarron);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.rbLuz);
            this.groupBox3.Controls.Add(this.gbBimestre);
            this.groupBox3.Controls.Add(this.btnEditar);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cbAño);
            this.groupBox3.Controls.Add(this.cbMes);
            this.groupBox3.Controls.Add(this.radioButton7);
            this.groupBox3.Controls.Add(this.rbManto);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, -2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 681);
            this.groupBox3.TabIndex = 177;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // rbTarjeton
            // 
            this.rbTarjeton.AutoSize = true;
            this.rbTarjeton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTarjeton.ForeColor = System.Drawing.Color.Blue;
            this.rbTarjeton.Location = new System.Drawing.Point(21, 254);
            this.rbTarjeton.Name = "rbTarjeton";
            this.rbTarjeton.Size = new System.Drawing.Size(171, 21);
            this.rbTarjeton.TabIndex = 273;
            this.rbTarjeton.TabStop = true;
            this.rbTarjeton.Text = "ULTIMO TARJETON";
            this.rbTarjeton.UseVisualStyleBackColor = true;
            // 
            // rbpizarron
            // 
            this.rbpizarron.AutoSize = true;
            this.rbpizarron.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbpizarron.ForeColor = System.Drawing.Color.Blue;
            this.rbpizarron.Location = new System.Drawing.Point(18, 99);
            this.rbpizarron.Name = "rbpizarron";
            this.rbpizarron.Size = new System.Drawing.Size(184, 21);
            this.rbpizarron.TabIndex = 272;
            this.rbpizarron.TabStop = true;
            this.rbpizarron.Text = "REPORTE PIZARRON";
            this.rbpizarron.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Fraccionamientos.Properties.Resources.delete_remove_close_icon_181533;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(193, 634);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 47);
            this.button2.TabIndex = 261;
            this.button2.Text = "    Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbLuz
            // 
            this.rbLuz.AutoSize = true;
            this.rbLuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLuz.ForeColor = System.Drawing.Color.Blue;
            this.rbLuz.Location = new System.Drawing.Point(16, 60);
            this.rbLuz.Name = "rbLuz";
            this.rbLuz.Size = new System.Drawing.Size(233, 21);
            this.rbLuz.TabIndex = 270;
            this.rbLuz.TabStop = true;
            this.rbLuz.Text = "PENDIENTES PAGO DE LUZ";
            this.rbLuz.UseVisualStyleBackColor = true;
            this.rbLuz.CheckedChanged += new System.EventHandler(this.rbLuz_CheckedChanged);
            // 
            // gbBimestre
            // 
            this.gbBimestre.Controls.Add(this.cbBimestre);
            this.gbBimestre.Location = new System.Drawing.Point(24, 200);
            this.gbBimestre.Name = "gbBimestre";
            this.gbBimestre.Size = new System.Drawing.Size(247, 54);
            this.gbBimestre.TabIndex = 269;
            this.gbBimestre.TabStop = false;
            this.gbBimestre.Text = "Bimestre";
            this.gbBimestre.Visible = false;
            // 
            // cbBimestre
            // 
            this.cbBimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBimestre.FormattingEnabled = true;
            this.cbBimestre.Location = new System.Drawing.Point(-6, 20);
            this.cbBimestre.Name = "cbBimestre";
            this.cbBimestre.Size = new System.Drawing.Size(227, 28);
            this.cbBimestre.TabIndex = 213;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(229, 136);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(78, 35);
            this.btnEditar.TabIndex = 268;
            this.btnEditar.Text = "Generar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 267;
            this.label4.Text = "Año:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 24);
            this.label8.TabIndex = 266;
            this.label8.Text = "Mes:";
            // 
            // cbAño
            // 
            this.cbAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAño.FormattingEnabled = true;
            this.cbAño.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032"});
            this.cbAño.Location = new System.Drawing.Point(81, 123);
            this.cbAño.Name = "cbAño";
            this.cbAño.Size = new System.Drawing.Size(121, 28);
            this.cbAño.TabIndex = 265;
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
            this.cbMes.Location = new System.Drawing.Point(81, 154);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(121, 28);
            this.cbMes.TabIndex = 264;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton7.Location = new System.Drawing.Point(21, 652);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(126, 21);
            this.radioButton7.TabIndex = 260;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "PAGO TOTAL";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // rbManto
            // 
            this.rbManto.AutoSize = true;
            this.rbManto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbManto.ForeColor = System.Drawing.Color.Blue;
            this.rbManto.Location = new System.Drawing.Point(16, 21);
            this.rbManto.Name = "rbManto";
            this.rbManto.Size = new System.Drawing.Size(255, 21);
            this.rbManto.TabIndex = 0;
            this.rbManto.TabStop = true;
            this.rbManto.Text = "PENDIENTES MANTENIMIENTO";
            this.rbManto.UseVisualStyleBackColor = true;
            this.rbManto.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Location = new System.Drawing.Point(322, 12);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.Size = new System.Drawing.Size(817, 659);
            this.crystalReportViewer2.TabIndex = 262;
            // 
            // lblFraccionamiento
            // 
            this.lblFraccionamiento.AutoSize = true;
            this.lblFraccionamiento.Location = new System.Drawing.Point(25, 588);
            this.lblFraccionamiento.Name = "lblFraccionamiento";
            this.lblFraccionamiento.Size = new System.Drawing.Size(57, 20);
            this.lblFraccionamiento.TabIndex = 275;
            this.lblFraccionamiento.Text = "label1";
            // 
            // txtFrac
            // 
            this.txtFrac.Location = new System.Drawing.Point(229, 585);
            this.txtFrac.Name = "txtFrac";
            this.txtFrac.Size = new System.Drawing.Size(46, 26);
            this.txtFrac.TabIndex = 274;
            this.txtFrac.Visible = false;
            // 
            // frmTarjetones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 683);
            this.Controls.Add(this.crystalReportViewer2);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmTarjetones";
            this.Text = "frmTarjetones";
            this.Load += new System.EventHandler(this.frmTarjetones_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbBimestre.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbManto;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbAño;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.RadioButton rbLuz;
        private System.Windows.Forms.GroupBox gbBimestre;
        private System.Windows.Forms.ComboBox cbBimestre;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private System.Windows.Forms.RadioButton rbpizarron;
        private System.Windows.Forms.RadioButton rbTarjeton;
        public System.Windows.Forms.Label lblFraccionamiento;
        public System.Windows.Forms.TextBox txtFrac;
    }
}