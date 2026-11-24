namespace Calculadora
{
    partial class Form1
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
            this.interfaz = new System.Windows.Forms.Button();
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // interfaz
            // 
            this.interfaz.BackColor = System.Drawing.Color.MistyRose;
            this.interfaz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.interfaz.Location = new System.Drawing.Point(154, 42);
            this.interfaz.Name = "interfaz";
            this.interfaz.Size = new System.Drawing.Size(360, 430);
            this.interfaz.TabIndex = 0;
            this.interfaz.UseVisualStyleBackColor = false;
            // 
            // txtPantalla
            // 
            this.txtPantalla.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPantalla.Location = new System.Drawing.Point(226, 115);
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.ReadOnly = true;
            this.txtPantalla.Size = new System.Drawing.Size(237, 51);
            this.txtPantalla.TabIndex = 2;
            this.txtPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Calculadora";
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(189, 387);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(58, 47);
            this.btn0.TabIndex = 4;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(189, 325);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(58, 47);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(272, 325);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(58, 47);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(352, 325);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(58, 47);
            this.btn3.TabIndex = 7;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(189, 257);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(58, 47);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(189, 188);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(58, 47);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(272, 257);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(58, 47);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(272, 188);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(58, 47);
            this.btn8.TabIndex = 11;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(352, 257);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(58, 47);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(352, 188);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(58, 47);
            this.btn9.TabIndex = 13;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(435, 188);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(58, 33);
            this.btnSuma.TabIndex = 14;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(435, 339);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(58, 33);
            this.btnDividir.TabIndex = 15;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(435, 289);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(58, 33);
            this.btnMultiplicar.TabIndex = 16;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.Location = new System.Drawing.Point(435, 241);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(58, 33);
            this.btnRestar.TabIndex = 17;
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnIgual.Location = new System.Drawing.Point(272, 387);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(141, 40);
            this.btnIgual.TabIndex = 18;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnLimpiar.Location = new System.Drawing.Point(435, 387);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(58, 40);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "AC";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPantalla);
            this.Controls.Add(this.interfaz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button interfaz;
        private System.Windows.Forms.TextBox txtPantalla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

