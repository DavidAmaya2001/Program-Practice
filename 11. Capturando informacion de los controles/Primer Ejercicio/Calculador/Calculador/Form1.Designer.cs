namespace Calculador
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.NumericUpDown();
            this.txtnum2 = new System.Windows.Forms.NumericUpDown();
            this.txtnum3 = new System.Windows.Forms.NumericUpDown();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnclean = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtnum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnum3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(54, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el numero 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(54, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese el numero 3";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(304, 53);
            this.txtnum1.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(184, 23);
            this.txtnum1.TabIndex = 3;
            this.txtnum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(304, 133);
            this.txtnum2.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(184, 23);
            this.txtnum2.TabIndex = 4;
            this.txtnum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnum3
            // 
            this.txtnum3.Location = new System.Drawing.Point(304, 224);
            this.txtnum3.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtnum3.Name = "txtnum3";
            this.txtnum3.Size = new System.Drawing.Size(184, 23);
            this.txtnum3.TabIndex = 5;
            this.txtnum3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncalcular.Location = new System.Drawing.Point(140, 328);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(85, 34);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnclean
            // 
            this.btnclean.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnclean.Location = new System.Drawing.Point(355, 328);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(85, 34);
            this.btnclean.TabIndex = 7;
            this.btnclean.Text = "Limpiar";
            this.btnclean.UseVisualStyleBackColor = true;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(121, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "No se podra calcular si el valor de alguno es 0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 442);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnclean);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtnum3);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculador";
            ((System.ComponentModel.ISupportInitialize)(this.txtnum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnum3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown txtnum1;
        private NumericUpDown txtnum2;
        private NumericUpDown txtnum3;
        private Button btncalcular;
        private Button btnclean;
        private Label label4;
    }
}