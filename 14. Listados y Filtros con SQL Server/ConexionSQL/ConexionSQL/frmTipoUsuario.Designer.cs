namespace ConexionSQL
{
    partial class frmTipoUsuario
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
            this.dgvTipoUsuario = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipoUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTipoUsuario
            // 
            this.dgvTipoUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoUsuario.Location = new System.Drawing.Point(101, 147);
            this.dgvTipoUsuario.Name = "dgvTipoUsuario";
            this.dgvTipoUsuario.Size = new System.Drawing.Size(484, 272);
            this.dgvTipoUsuario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del tipo de Usuario";
            // 
            // txtTipoUsuario
            // 
            this.txtTipoUsuario.Location = new System.Drawing.Point(292, 87);
            this.txtTipoUsuario.Name = "txtTipoUsuario";
            this.txtTipoUsuario.Size = new System.Drawing.Size(259, 20);
            this.txtTipoUsuario.TabIndex = 2;
            this.txtTipoUsuario.TextChanged += new System.EventHandler(this.filtrarTipoUsuario);
            // 
            // frmTipoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.txtTipoUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTipoUsuario);
            this.Name = "frmTipoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo Usuario";
            this.Load += new System.EventHandler(this.frmTipoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTipoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTipoUsuario;
    }
}