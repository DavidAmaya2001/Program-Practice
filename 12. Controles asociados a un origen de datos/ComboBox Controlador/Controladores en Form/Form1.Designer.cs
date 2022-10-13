namespace Controladores_en_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPersonas = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.btnValue = new System.Windows.Forms.Button();
            this.lblMostrarValue = new System.Windows.Forms.Label();
            this.btnValores = new System.Windows.Forms.Button();
            this.lblValores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(167, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personas";
            // 
            // cmbPersonas
            // 
            this.cmbPersonas.FormattingEnabled = true;
            this.cmbPersonas.Location = new System.Drawing.Point(60, 115);
            this.cmbPersonas.Name = "cmbPersonas";
            this.cmbPersonas.Size = new System.Drawing.Size(311, 23);
            this.cmbPersonas.TabIndex = 1;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(60, 186);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMostrar.Location = new System.Drawing.Point(183, 299);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(0, 20);
            this.lblMostrar.TabIndex = 3;
            // 
            // btnValue
            // 
            this.btnValue.Location = new System.Drawing.Point(152, 186);
            this.btnValue.Name = "btnValue";
            this.btnValue.Size = new System.Drawing.Size(102, 23);
            this.btnValue.TabIndex = 4;
            this.btnValue.Text = "Mostrar Value";
            this.btnValue.UseVisualStyleBackColor = true;
            this.btnValue.Click += new System.EventHandler(this.btnValue_Click);
            // 
            // lblMostrarValue
            // 
            this.lblMostrarValue.AutoSize = true;
            this.lblMostrarValue.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMostrarValue.Location = new System.Drawing.Point(108, 299);
            this.lblMostrarValue.Name = "lblMostrarValue";
            this.lblMostrarValue.Size = new System.Drawing.Size(0, 20);
            this.lblMostrarValue.TabIndex = 5;
            // 
            // btnValores
            // 
            this.btnValores.Location = new System.Drawing.Point(269, 186);
            this.btnValores.Name = "btnValores";
            this.btnValores.Size = new System.Drawing.Size(102, 23);
            this.btnValores.TabIndex = 6;
            this.btnValores.Text = "Mostrar Valores";
            this.btnValores.UseVisualStyleBackColor = true;
            this.btnValores.Click += new System.EventHandler(this.btnValores_Click);
            // 
            // lblValores
            // 
            this.lblValores.AutoSize = true;
            this.lblValores.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValores.Location = new System.Drawing.Point(183, 371);
            this.lblValores.Name = "lblValores";
            this.lblValores.Size = new System.Drawing.Size(0, 20);
            this.lblValores.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.lblValores);
            this.Controls.Add(this.btnValores);
            this.Controls.Add(this.lblMostrarValue);
            this.Controls.Add(this.btnValue);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.cmbPersonas);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cmbPersonas;
        private Button btnMostrar;
        private Label lblMostrar;
        private Button btnValue;
        private Label lblMostrarValue;
        private Button btnValores;
        private Label lblValores;
    }
}