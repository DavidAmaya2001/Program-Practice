namespace ConexionSQL
{
    partial class frmViaje
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
            this.dgvViajes = new System.Windows.Forms.DataGridView();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViajes
            // 
            this.dgvViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajes.Location = new System.Drawing.Point(26, 144);
            this.dgvViajes.Name = "dgvViajes";
            this.dgvViajes.Size = new System.Drawing.Size(628, 272);
            this.dgvViajes.TabIndex = 0;
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Location = new System.Drawing.Point(251, 71);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(302, 21);
            this.cmbBuscar.TabIndex = 1;
            this.cmbBuscar.SelectionChangeCommitted += new System.EventHandler(this.filtrarViaje);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione Destino";
            // 
            // frmViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBuscar);
            this.Controls.Add(this.dgvViajes);
            this.Name = "frmViaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viajes";
            this.Load += new System.EventHandler(this.frmViaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViajes;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.Label label1;
    }
}