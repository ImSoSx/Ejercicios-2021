
namespace Ejercicio_25_03
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
            this.label1 = new System.Windows.Forms.Label();
            this.numeroUno_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numeroDos_txt = new System.Windows.Forms.TextBox();
            this.suma_btn = new System.Windows.Forms.Button();
            this.siguiente_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            // 
            // numeroUno_txt
            // 
            this.numeroUno_txt.Location = new System.Drawing.Point(137, 32);
            this.numeroUno_txt.Name = "numeroUno_txt";
            this.numeroUno_txt.Size = new System.Drawing.Size(100, 20);
            this.numeroUno_txt.TabIndex = 1;
            this.numeroUno_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeroUno_txt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero 2";
            // 
            // numeroDos_txt
            // 
            this.numeroDos_txt.Location = new System.Drawing.Point(137, 80);
            this.numeroDos_txt.Name = "numeroDos_txt";
            this.numeroDos_txt.Size = new System.Drawing.Size(100, 20);
            this.numeroDos_txt.TabIndex = 3;
            this.numeroDos_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeroDos_txt_KeyPress);
            // 
            // suma_btn
            // 
            this.suma_btn.Location = new System.Drawing.Point(137, 126);
            this.suma_btn.Name = "suma_btn";
            this.suma_btn.Size = new System.Drawing.Size(75, 23);
            this.suma_btn.TabIndex = 4;
            this.suma_btn.Text = "Suma";
            this.suma_btn.UseVisualStyleBackColor = true;
            this.suma_btn.Click += new System.EventHandler(this.suma_btn_Click);
            // 
            // siguiente_btn
            // 
            this.siguiente_btn.Location = new System.Drawing.Point(253, 164);
            this.siguiente_btn.Name = "siguiente_btn";
            this.siguiente_btn.Size = new System.Drawing.Size(75, 23);
            this.siguiente_btn.TabIndex = 5;
            this.siguiente_btn.Text = "Siguiente";
            this.siguiente_btn.UseVisualStyleBackColor = true;
            this.siguiente_btn.Click += new System.EventHandler(this.siguiente_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 199);
            this.Controls.Add(this.siguiente_btn);
            this.Controls.Add(this.suma_btn);
            this.Controls.Add(this.numeroDos_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numeroUno_txt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numeroUno_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numeroDos_txt;
        private System.Windows.Forms.Button suma_btn;
        private System.Windows.Forms.Button siguiente_btn;
    }
}

