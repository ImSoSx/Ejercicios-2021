
namespace Ejercicio_04_20_BD
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Conectar_btn = new System.Windows.Forms.Button();
            this.Servidor_txt = new System.Windows.Forms.TextBox();
            this.Bd_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(297, 227);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Base de Datos";
            // 
            // Conectar_btn
            // 
            this.Conectar_btn.Location = new System.Drawing.Point(407, 184);
            this.Conectar_btn.Name = "Conectar_btn";
            this.Conectar_btn.Size = new System.Drawing.Size(75, 23);
            this.Conectar_btn.TabIndex = 3;
            this.Conectar_btn.Text = "Conectar";
            this.Conectar_btn.UseVisualStyleBackColor = true;
            this.Conectar_btn.Click += new System.EventHandler(this.Conectar_btn_Click);
            // 
            // Servidor_txt
            // 
            this.Servidor_txt.Location = new System.Drawing.Point(407, 56);
            this.Servidor_txt.Name = "Servidor_txt";
            this.Servidor_txt.Size = new System.Drawing.Size(100, 20);
            this.Servidor_txt.TabIndex = 4;
            // 
            // Bd_txt
            // 
            this.Bd_txt.Location = new System.Drawing.Point(407, 98);
            this.Bd_txt.Name = "Bd_txt";
            this.Bd_txt.Size = new System.Drawing.Size(100, 20);
            this.Bd_txt.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 251);
            this.Controls.Add(this.Bd_txt);
            this.Controls.Add(this.Servidor_txt);
            this.Controls.Add(this.Conectar_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Conectar_btn;
        private System.Windows.Forms.TextBox Servidor_txt;
        private System.Windows.Forms.TextBox Bd_txt;
    }
}

