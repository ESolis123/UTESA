
namespace Compilador
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
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAnalizadorLexico = new System.Windows.Forms.Label();
            this.txtAnalizadorSintactico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnalizadorSintactico = new System.Windows.Forms.Button();
            this.txtTabladeSimbolos = new System.Windows.Forms.TextBox();
            this.btnTabladeSimbolos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(46, 75);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(275, 181);
            this.txtTexto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // lbAnalizadorLexico
            // 
            this.lbAnalizadorLexico.AutoSize = true;
            this.lbAnalizadorLexico.Location = new System.Drawing.Point(347, 32);
            this.lbAnalizadorLexico.Name = "lbAnalizadorLexico";
            this.lbAnalizadorLexico.Size = new System.Drawing.Size(185, 13);
            this.lbAnalizadorLexico.TabIndex = 1;
            this.lbAnalizadorLexico.Text = "Analizador Lexico | Tabla de Simbolos";
            // 
            // txtAnalizadorSintactico
            // 
            this.txtAnalizadorSintactico.Location = new System.Drawing.Point(46, 327);
            this.txtAnalizadorSintactico.Multiline = true;
            this.txtAnalizadorSintactico.Name = "txtAnalizadorSintactico";
            this.txtAnalizadorSintactico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnalizadorSintactico.Size = new System.Drawing.Size(614, 91);
            this.txtAnalizadorSintactico.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Analizador Sintactico";
            // 
            // btnAnalizadorSintactico
            // 
            this.btnAnalizadorSintactico.Location = new System.Drawing.Point(538, 284);
            this.btnAnalizadorSintactico.Name = "btnAnalizadorSintactico";
            this.btnAnalizadorSintactico.Size = new System.Drawing.Size(122, 37);
            this.btnAnalizadorSintactico.TabIndex = 2;
            this.btnAnalizadorSintactico.Text = "Analizar";
            this.btnAnalizadorSintactico.UseVisualStyleBackColor = true;
            this.btnAnalizadorSintactico.Click += new System.EventHandler(this.btnAnalizadorSintactico_Click);
            // 
            // txtTabladeSimbolos
            // 
            this.txtTabladeSimbolos.Location = new System.Drawing.Point(350, 75);
            this.txtTabladeSimbolos.Multiline = true;
            this.txtTabladeSimbolos.Name = "txtTabladeSimbolos";
            this.txtTabladeSimbolos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTabladeSimbolos.Size = new System.Drawing.Size(310, 181);
            this.txtTabladeSimbolos.TabIndex = 0;
            // 
            // btnTabladeSimbolos
            // 
            this.btnTabladeSimbolos.Location = new System.Drawing.Point(538, 20);
            this.btnTabladeSimbolos.Name = "btnTabladeSimbolos";
            this.btnTabladeSimbolos.Size = new System.Drawing.Size(122, 37);
            this.btnTabladeSimbolos.TabIndex = 2;
            this.btnTabladeSimbolos.Text = "Analizar";
            this.btnTabladeSimbolos.UseVisualStyleBackColor = true;
            this.btnTabladeSimbolos.Click += new System.EventHandler(this.btnTabladeSimbolos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTabladeSimbolos);
            this.Controls.Add(this.btnAnalizadorSintactico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAnalizadorLexico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTabladeSimbolos);
            this.Controls.Add(this.txtAnalizadorSintactico);
            this.Controls.Add(this.txtTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAnalizadorLexico;
        private System.Windows.Forms.TextBox txtAnalizadorSintactico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnalizadorSintactico;
        private System.Windows.Forms.TextBox txtTabladeSimbolos;
        private System.Windows.Forms.Button btnTabladeSimbolos;
    }
}

