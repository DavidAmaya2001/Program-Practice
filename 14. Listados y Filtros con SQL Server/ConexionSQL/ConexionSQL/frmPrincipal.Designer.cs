namespace ConexionSQL
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lugarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMarca,
            this.itemEmpleado,
            this.itemCliente,
            this.tipoUsuarioToolStripMenuItem,
            this.busToolStripMenuItem,
            this.viajeToolStripMenuItem,
            this.lugarToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // itemMarca
            // 
            this.itemMarca.Name = "itemMarca";
            this.itemMarca.Size = new System.Drawing.Size(180, 22);
            this.itemMarca.Text = "Marca";
            this.itemMarca.Click += new System.EventHandler(this.itemMarca_Click);
            // 
            // itemEmpleado
            // 
            this.itemEmpleado.Name = "itemEmpleado";
            this.itemEmpleado.Size = new System.Drawing.Size(180, 22);
            this.itemEmpleado.Text = "Empleado";
            this.itemEmpleado.Click += new System.EventHandler(this.itemEmpleado_Click);
            // 
            // itemCliente
            // 
            this.itemCliente.Name = "itemCliente";
            this.itemCliente.Size = new System.Drawing.Size(180, 22);
            this.itemCliente.Text = "Cliente";
            this.itemCliente.Click += new System.EventHandler(this.itemCliente_Click);
            // 
            // tipoUsuarioToolStripMenuItem
            // 
            this.tipoUsuarioToolStripMenuItem.Name = "tipoUsuarioToolStripMenuItem";
            this.tipoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipoUsuarioToolStripMenuItem.Text = "Tipo Usuario";
            this.tipoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.tipoUsuarioToolStripMenuItem_Click);
            // 
            // busToolStripMenuItem
            // 
            this.busToolStripMenuItem.Name = "busToolStripMenuItem";
            this.busToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.busToolStripMenuItem.Text = "Bus";
            this.busToolStripMenuItem.Click += new System.EventHandler(this.busToolStripMenuItem_Click);
            // 
            // viajeToolStripMenuItem
            // 
            this.viajeToolStripMenuItem.Name = "viajeToolStripMenuItem";
            this.viajeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viajeToolStripMenuItem.Text = "Viaje";
            this.viajeToolStripMenuItem.Click += new System.EventHandler(this.viajeToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // lugarToolStripMenuItem
            // 
            this.lugarToolStripMenuItem.Name = "lugarToolStripMenuItem";
            this.lugarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lugarToolStripMenuItem.Text = "Lugar";
            this.lugarToolStripMenuItem.Click += new System.EventHandler(this.lugarToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 551);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Pantalla Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemMarca;
        private System.Windows.Forms.ToolStripMenuItem itemEmpleado;
        private System.Windows.Forms.ToolStripMenuItem itemCliente;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lugarToolStripMenuItem;
    }
}