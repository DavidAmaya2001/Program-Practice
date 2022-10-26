namespace ConexionSQL
{
    partial class Lugar
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
            this.dgvListadoLugar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoLugar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListadoLugar
            // 
            this.dgvListadoLugar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoLugar.Location = new System.Drawing.Point(73, 98);
            this.dgvListadoLugar.Name = "dgvListadoLugar";
            this.dgvListadoLugar.Size = new System.Drawing.Size(652, 318);
            this.dgvListadoLugar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de ID, Lugar y Descripción";
            // 
            // Lugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListadoLugar);
            this.Name = "Lugar";
            this.Text = "Lugar";
            this.Load += new System.EventHandler(this.Lugar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoLugar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoLugar;
        private System.Windows.Forms.Label label1;
    }
}