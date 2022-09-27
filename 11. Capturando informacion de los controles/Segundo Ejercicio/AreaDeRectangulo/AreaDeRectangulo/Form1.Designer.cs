namespace AreaDeRectangulo
{
    partial class frmPrincipal
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
            this.txtNum1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.NumericUpDown();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.picture2 = new System.Windows.Forms.PictureBox();
            this.picture3 = new System.Windows.Forms.PictureBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(54, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la base:";
            // 
            // txtNum1
            // 
            this.txtNum1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNum1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNum1.Location = new System.Drawing.Point(216, 65);
            this.txtNum1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(120, 23);
            this.txtNum1.TabIndex = 1;
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(447, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese la altura:";
            // 
            // txtNum2
            // 
            this.txtNum2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNum2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNum2.Location = new System.Drawing.Point(610, 65);
            this.txtNum2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(120, 23);
            this.txtNum2.TabIndex = 3;
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculo
            // 
            this.btnCalculo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculo.Location = new System.Drawing.Point(220, 162);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(116, 32);
            this.btnCalculo.TabIndex = 4;
            this.btnCalculo.Text = "Calcular area";
            this.btnCalculo.UseVisualStyleBackColor = false;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(447, 162);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 32);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblResult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResult.Location = new System.Drawing.Point(409, 284);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(283, 78);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = ">";
            // 
            // picture1
            // 
            this.picture1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picture1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture1.Location = new System.Drawing.Point(186, 265);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(119, 117);
            this.picture1.TabIndex = 7;
            this.picture1.TabStop = false;
            // 
            // picture2
            // 
            this.picture2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picture2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture2.Location = new System.Drawing.Point(158, 265);
            this.picture2.Name = "picture2";
            this.picture2.Size = new System.Drawing.Size(178, 117);
            this.picture2.TabIndex = 8;
            this.picture2.TabStop = false;
            this.picture2.Visible = false;
            this.picture2.Click += new System.EventHandler(this.picture2_Click);
            // 
            // picture3
            // 
            this.picture3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picture3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture3.Location = new System.Drawing.Point(200, 257);
            this.picture3.Name = "picture3";
            this.picture3.Size = new System.Drawing.Size(98, 136);
            this.picture3.TabIndex = 9;
            this.picture3.TabStop = false;
            this.picture3.Visible = false;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBase.Location = new System.Drawing.Point(232, 407);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(36, 17);
            this.lblBase.TabIndex = 10;
            this.lblBase.Text = "Base";
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblaltura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblaltura.Location = new System.Drawing.Point(104, 315);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(46, 17);
            this.lblaltura.TabIndex = 11;
            this.lblaltura.Text = "Altura";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.picture3);
            this.Controls.Add(this.picture2);
            this.Controls.Add(this.picture1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculador de Area";
            ((System.ComponentModel.ISupportInitialize)(this.txtNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown txtNum1;
        private Label label2;
        private NumericUpDown txtNum2;
        private Button btnCalculo;
        private Button btnClear;
        private Label lblResult;
        private PictureBox picture1;
        private PictureBox picture2;
        private PictureBox picture3;
        private Label lblBase;
        private Label lblaltura;
    }
}