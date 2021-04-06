
namespace Ejercicio1Clase1
{
    partial class Calculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.btn_suma = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_resta = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(126, 9);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(207, 23);
            this.txtNumero1.TabIndex = 2;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(126, 47);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(207, 23);
            this.txtNumero2.TabIndex = 3;
            // 
            // btn_suma
            // 
            this.btn_suma.Location = new System.Drawing.Point(126, 76);
            this.btn_suma.Name = "btn_suma";
            this.btn_suma.Size = new System.Drawing.Size(86, 23);
            this.btn_suma.TabIndex = 4;
            this.btn_suma.Text = "Suma";
            this.btn_suma.UseVisualStyleBackColor = true;
            this.btn_suma.Click += new System.EventHandler(this.btn_suma_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.Location = new System.Drawing.Point(236, 76);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(97, 23);
            this.btn_multi.TabIndex = 5;
            this.btn_multi.Text = "Multiplicacion";
            this.btn_multi.UseVisualStyleBackColor = true;
            this.btn_multi.Click += new System.EventHandler(this.btn_multi_Click);
            // 
            // btn_resta
            // 
            this.btn_resta.Location = new System.Drawing.Point(126, 105);
            this.btn_resta.Name = "btn_resta";
            this.btn_resta.Size = new System.Drawing.Size(86, 23);
            this.btn_resta.TabIndex = 6;
            this.btn_resta.Text = "Resta";
            this.btn_resta.UseVisualStyleBackColor = true;
            this.btn_resta.Click += new System.EventHandler(this.btn_resta_Click);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(236, 105);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(97, 23);
            this.btn_div.TabIndex = 7;
            this.btn_div.Text = "Division";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // Calculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 142);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_resta);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.btn_suma);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Calculo";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button btn_suma;
        private System.Windows.Forms.Button btn_multi;
        private System.Windows.Forms.Button btn_resta;
        private System.Windows.Forms.Button btn_div;
    }
}