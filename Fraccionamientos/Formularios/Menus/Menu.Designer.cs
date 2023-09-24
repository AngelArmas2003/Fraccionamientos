
namespace Fraccionamientos.Formularios.Menus
{
    partial class Menu
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.aportacionesPropietariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adeudosPropietariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoProoveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reciboLuzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtFrac = new System.Windows.Forms.TextBox();
            this.lblFraccionamiento = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aportacionesPropietariosToolStripMenuItem,
            this.adeudosPropietariosToolStripMenuItem,
            this.pagoProoveedoresToolStripMenuItem,
            this.reciboLuzToolStripMenuItem,
            this.reporesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1090, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // aportacionesPropietariosToolStripMenuItem
            // 
            this.aportacionesPropietariosToolStripMenuItem.Name = "aportacionesPropietariosToolStripMenuItem";
            this.aportacionesPropietariosToolStripMenuItem.Size = new System.Drawing.Size(155, 20);
            this.aportacionesPropietariosToolStripMenuItem.Text = "Aportaciones Propietarios";
            this.aportacionesPropietariosToolStripMenuItem.Click += new System.EventHandler(this.aportacionesPropietariosToolStripMenuItem_Click);
            // 
            // adeudosPropietariosToolStripMenuItem
            // 
            this.adeudosPropietariosToolStripMenuItem.Name = "adeudosPropietariosToolStripMenuItem";
            this.adeudosPropietariosToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.adeudosPropietariosToolStripMenuItem.Text = "Adeudos Propietarios";
            this.adeudosPropietariosToolStripMenuItem.Click += new System.EventHandler(this.adeudosPropietariosToolStripMenuItem_Click);
            // 
            // pagoProoveedoresToolStripMenuItem
            // 
            this.pagoProoveedoresToolStripMenuItem.Name = "pagoProoveedoresToolStripMenuItem";
            this.pagoProoveedoresToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.pagoProoveedoresToolStripMenuItem.Text = "Pago Provedores";
            this.pagoProoveedoresToolStripMenuItem.Click += new System.EventHandler(this.pagoProoveedoresToolStripMenuItem_Click);
            // 
            // reciboLuzToolStripMenuItem
            // 
            this.reciboLuzToolStripMenuItem.Name = "reciboLuzToolStripMenuItem";
            this.reciboLuzToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.reciboLuzToolStripMenuItem.Text = "Recibo Luz";
            this.reciboLuzToolStripMenuItem.Click += new System.EventHandler(this.reciboLuzToolStripMenuItem_Click);
            // 
            // reporesToolStripMenuItem
            // 
            this.reporesToolStripMenuItem.Name = "reporesToolStripMenuItem";
            this.reporesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.reporesToolStripMenuItem.Text = "Repores";
            this.reporesToolStripMenuItem.Click += new System.EventHandler(this.reporesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1090, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // txtFrac
            // 
            this.txtFrac.Location = new System.Drawing.Point(1032, 3);
            this.txtFrac.Name = "txtFrac";
            this.txtFrac.Size = new System.Drawing.Size(46, 20);
            this.txtFrac.TabIndex = 4;
            this.txtFrac.Visible = false;
            this.txtFrac.TextChanged += new System.EventHandler(this.txtFrac_TextChanged);
            // 
            // lblFraccionamiento
            // 
            this.lblFraccionamiento.AutoSize = true;
            this.lblFraccionamiento.Location = new System.Drawing.Point(828, 6);
            this.lblFraccionamiento.Name = "lblFraccionamiento";
            this.lblFraccionamiento.Size = new System.Drawing.Size(35, 13);
            this.lblFraccionamiento.TabIndex = 6;
            this.lblFraccionamiento.Text = "label1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 453);
            this.Controls.Add(this.lblFraccionamiento);
            this.Controls.Add(this.txtFrac);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem aportacionesPropietariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adeudosPropietariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagoProoveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reciboLuzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporesToolStripMenuItem;
        public System.Windows.Forms.TextBox txtFrac;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        public System.Windows.Forms.Label lblFraccionamiento;
    }
}



