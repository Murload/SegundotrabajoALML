namespace Trabajo_2
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
            this.lblrespuestas = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linksalir = new System.Windows.Forms.LinkLabel();
            this.btnfactorial = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.btnpunto = new System.Windows.Forms.Button();
            this.btnpor = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnprocentaje = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnmas = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnmenos = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.txtnumeros = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblrespuestas
            // 
            this.lblrespuestas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblrespuestas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrespuestas.Location = new System.Drawing.Point(135, 91);
            this.lblrespuestas.Name = "lblrespuestas";
            this.lblrespuestas.Size = new System.Drawing.Size(237, 24);
            this.lblrespuestas.TabIndex = 0;
            this.lblrespuestas.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblrespuestas.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.linksalir);
            this.groupBox1.Controls.Add(this.btnfactorial);
            this.groupBox1.Controls.Add(this.btnigual);
            this.groupBox1.Controls.Add(this.btnpunto);
            this.groupBox1.Controls.Add(this.btnpor);
            this.groupBox1.Controls.Add(this.btn0);
            this.groupBox1.Controls.Add(this.btnprocentaje);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Controls.Add(this.btnmas);
            this.groupBox1.Controls.Add(this.btn2);
            this.groupBox1.Controls.Add(this.btn3);
            this.groupBox1.Controls.Add(this.btn4);
            this.groupBox1.Controls.Add(this.btndividir);
            this.groupBox1.Controls.Add(this.btn5);
            this.groupBox1.Controls.Add(this.btn6);
            this.groupBox1.Controls.Add(this.btn9);
            this.groupBox1.Controls.Add(this.btnmenos);
            this.groupBox1.Controls.Add(this.btn8);
            this.groupBox1.Controls.Add(this.btn7);
            this.groupBox1.Controls.Add(this.lblrespuestas);
            this.groupBox1.Controls.Add(this.txtnumeros);
            this.groupBox1.Location = new System.Drawing.Point(27, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 466);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculadora";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 38);
            this.button1.TabIndex = 26;
            this.button1.Text = "CE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // linksalir
            // 
            this.linksalir.AutoSize = true;
            this.linksalir.LinkColor = System.Drawing.Color.Black;
            this.linksalir.Location = new System.Drawing.Point(172, 436);
            this.linksalir.Name = "linksalir";
            this.linksalir.Size = new System.Drawing.Size(27, 13);
            this.linksalir.TabIndex = 25;
            this.linksalir.TabStop = true;
            this.linksalir.Text = "Salir";
            this.linksalir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnfactorial
            // 
            this.btnfactorial.Location = new System.Drawing.Point(286, 371);
            this.btnfactorial.Name = "btnfactorial";
            this.btnfactorial.Size = new System.Drawing.Size(41, 38);
            this.btnfactorial.TabIndex = 24;
            this.btnfactorial.Text = "!";
            this.btnfactorial.UseVisualStyleBackColor = true;
            this.btnfactorial.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnigual
            // 
            this.btnigual.Location = new System.Drawing.Point(43, 91);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(75, 47);
            this.btnigual.TabIndex = 23;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = true;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // btnpunto
            // 
            this.btnpunto.Location = new System.Drawing.Point(205, 362);
            this.btnpunto.Name = "btnpunto";
            this.btnpunto.Size = new System.Drawing.Size(75, 47);
            this.btnpunto.TabIndex = 22;
            this.btnpunto.Text = ".";
            this.btnpunto.UseVisualStyleBackColor = true;
            // 
            // btnpor
            // 
            this.btnpor.Location = new System.Drawing.Point(286, 278);
            this.btnpor.Name = "btnpor";
            this.btnpor.Size = new System.Drawing.Size(41, 38);
            this.btnpor.TabIndex = 21;
            this.btnpor.Text = "*";
            this.btnpor.UseVisualStyleBackColor = true;
            this.btnpor.Click += new System.EventHandler(this.btnpor_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(124, 362);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 47);
            this.btn0.TabIndex = 20;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnprocentaje
            // 
            this.btnprocentaje.Location = new System.Drawing.Point(43, 362);
            this.btnprocentaje.Name = "btnprocentaje";
            this.btnprocentaje.Size = new System.Drawing.Size(75, 47);
            this.btnprocentaje.TabIndex = 19;
            this.btnprocentaje.Text = "%";
            this.btnprocentaje.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(205, 294);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 47);
            this.btn1.TabIndex = 18;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnmas
            // 
            this.btnmas.Location = new System.Drawing.Point(286, 190);
            this.btnmas.Name = "btnmas";
            this.btnmas.Size = new System.Drawing.Size(41, 38);
            this.btnmas.TabIndex = 17;
            this.btnmas.Text = "+";
            this.btnmas.UseVisualStyleBackColor = true;
            this.btnmas.Click += new System.EventHandler(this.btnmas_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(124, 294);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 47);
            this.btn2.TabIndex = 16;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(43, 294);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 47);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(205, 226);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 47);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btndividir
            // 
            this.btndividir.Location = new System.Drawing.Point(286, 322);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(41, 38);
            this.btndividir.TabIndex = 13;
            this.btndividir.Text = "/";
            this.btndividir.UseVisualStyleBackColor = true;
            this.btndividir.Click += new System.EventHandler(this.btndividir_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(124, 226);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 47);
            this.btn5.TabIndex = 12;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(43, 226);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 47);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(205, 158);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 47);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnmenos
            // 
            this.btnmenos.Location = new System.Drawing.Point(286, 234);
            this.btnmenos.Name = "btnmenos";
            this.btnmenos.Size = new System.Drawing.Size(41, 38);
            this.btnmenos.TabIndex = 9;
            this.btnmenos.Text = "-";
            this.btnmenos.UseVisualStyleBackColor = true;
            this.btnmenos.Click += new System.EventHandler(this.btnmenos_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(124, 158);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 47);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(43, 158);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 47);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // txtnumeros
            // 
            this.txtnumeros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumeros.Location = new System.Drawing.Point(34, 47);
            this.txtnumeros.Multiline = true;
            this.txtnumeros.Name = "txtnumeros";
            this.txtnumeros.Size = new System.Drawing.Size(338, 25);
            this.txtnumeros.TabIndex = 4;
            this.txtnumeros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 527);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblrespuestas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnumeros;
        private System.Windows.Forms.Button btnfactorial;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.Button btnpunto;
        private System.Windows.Forms.Button btnpor;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnprocentaje;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnmas;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btndividir;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnmenos;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.LinkLabel linksalir;
        private System.Windows.Forms.Button button1;
    }
}

