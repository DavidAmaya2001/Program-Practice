namespace Mensaje_de_edades
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.NumericUpDown();
            this.btnDeterminar = new System.Windows.Forms.Button();
            this.lbltext = new System.Windows.Forms.Label();
            this.errorDato = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDato)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(101, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la edad:";
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEdad.Location = new System.Drawing.Point(291, 84);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(228, 23);
            this.txtEdad.TabIndex = 1;
            this.txtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDeterminar
            // 
            this.btnDeterminar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDeterminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeterminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeterminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeterminar.Location = new System.Drawing.Point(175, 154);
            this.btnDeterminar.Name = "btnDeterminar";
            this.btnDeterminar.Size = new System.Drawing.Size(95, 35);
            this.btnDeterminar.TabIndex = 2;
            this.btnDeterminar.Text = "Determinar";
            this.btnDeterminar.UseVisualStyleBackColor = false;
            this.btnDeterminar.Click += new System.EventHandler(this.btnDeterminar_Click);
            // 
            // lbltext
            // 
            this.lbltext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltext.Location = new System.Drawing.Point(101, 315);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(448, 85);
            this.lbltext.TabIndex = 3;
            this.lbltext.Text = ">";
            // 
            // errorDato
            // 
            this.errorDato.ContainerControl = this;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(382, 154);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 35);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbltext);
            this.Controls.Add(this.btnDeterminar);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mayor o Menor de Edad";
            ((System.ComponentModel.ISupportInitialize)(this.txtEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown txtEdad;
        private Button btnDeterminar;
        private Label lbltext;
        private ErrorProvider errorDato;
        private Button btnClear;
    }
}