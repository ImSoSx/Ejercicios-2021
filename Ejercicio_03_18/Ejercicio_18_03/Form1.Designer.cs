
namespace Ejercicio_18_03
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
            this.txt_Arancel = new System.Windows.Forms.TextBox();
            this.txt_Promedio = new System.Windows.Forms.TextBox();
            this.txt_Descuento = new System.Windows.Forms.TextBox();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_Carrera = new System.Windows.Forms.ComboBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Arancel
            // 
            this.txt_Arancel.Location = new System.Drawing.Point(108, 63);
            this.txt_Arancel.Name = "txt_Arancel";
            this.txt_Arancel.Size = new System.Drawing.Size(240, 23);
            this.txt_Arancel.TabIndex = 1;
            // 
            // txt_Promedio
            // 
            this.txt_Promedio.Location = new System.Drawing.Point(108, 103);
            this.txt_Promedio.Name = "txt_Promedio";
            this.txt_Promedio.Size = new System.Drawing.Size(240, 23);
            this.txt_Promedio.TabIndex = 2;
            this.txt_Promedio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Promedio_KeyPress);
            // 
            // txt_Descuento
            // 
            this.txt_Descuento.Location = new System.Drawing.Point(108, 143);
            this.txt_Descuento.Name = "txt_Descuento";
            this.txt_Descuento.Size = new System.Drawing.Size(240, 23);
            this.txt_Descuento.TabIndex = 3;
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(108, 183);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(240, 23);
            this.txt_Total.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Carrera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Arancel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Promedio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descuento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total a Pagar";
            // 
            // cbx_Carrera
            // 
            this.cbx_Carrera.FormattingEnabled = true;
            this.cbx_Carrera.Location = new System.Drawing.Point(108, 23);
            this.cbx_Carrera.Name = "cbx_Carrera";
            this.cbx_Carrera.Size = new System.Drawing.Size(240, 23);
            this.cbx_Carrera.TabIndex = 10;
            this.cbx_Carrera.SelectedIndexChanged += new System.EventHandler(this.cbx_Carrera_SelectedIndexChanged);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(147, 226);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 11;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.cbx_Carrera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.txt_Descuento);
            this.Controls.Add(this.txt_Promedio);
            this.Controls.Add(this.txt_Arancel);
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Arancel;
        private System.Windows.Forms.TextBox txt_Promedio;
        private System.Windows.Forms.TextBox txt_Descuento;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_Carrera;
        private System.Windows.Forms.Button btn_Calcular;
    }
}

