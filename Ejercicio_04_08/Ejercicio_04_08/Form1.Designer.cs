
namespace Ejercicio_04_08
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
            this.ck_Clasico = new System.Windows.Forms.CheckBox();
            this.ck_SemiCama = new System.Windows.Forms.CheckBox();
            this.ck_Cama = new System.Windows.Forms.CheckBox();
            this.cb_Asientos = new System.Windows.Forms.ComboBox();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.n_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.txt_Total = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_Cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // ck_Clasico
            // 
            this.ck_Clasico.AutoSize = true;
            this.ck_Clasico.Location = new System.Drawing.Point(135, 116);
            this.ck_Clasico.Name = "ck_Clasico";
            this.ck_Clasico.Size = new System.Drawing.Size(64, 19);
            this.ck_Clasico.TabIndex = 0;
            this.ck_Clasico.Text = "Clasico";
            this.ck_Clasico.UseVisualStyleBackColor = true;
            this.ck_Clasico.CheckedChanged += new System.EventHandler(this.ck_Clasico_CheckedChanged);
            // 
            // ck_SemiCama
            // 
            this.ck_SemiCama.AutoSize = true;
            this.ck_SemiCama.Location = new System.Drawing.Point(261, 116);
            this.ck_SemiCama.Name = "ck_SemiCama";
            this.ck_SemiCama.Size = new System.Drawing.Size(88, 19);
            this.ck_SemiCama.TabIndex = 1;
            this.ck_SemiCama.Text = "Semi_Cama";
            this.ck_SemiCama.UseVisualStyleBackColor = true;
            this.ck_SemiCama.CheckedChanged += new System.EventHandler(this.ck_SemiCama_CheckedChanged);
            // 
            // ck_Cama
            // 
            this.ck_Cama.AutoSize = true;
            this.ck_Cama.Location = new System.Drawing.Point(403, 115);
            this.ck_Cama.Name = "ck_Cama";
            this.ck_Cama.Size = new System.Drawing.Size(57, 19);
            this.ck_Cama.TabIndex = 2;
            this.ck_Cama.Text = "Cama";
            this.ck_Cama.UseVisualStyleBackColor = true;
            this.ck_Cama.CheckedChanged += new System.EventHandler(this.ck_Cama_CheckedChanged);
            // 
            // cb_Asientos
            // 
            this.cb_Asientos.FormattingEnabled = true;
            this.cb_Asientos.Location = new System.Drawing.Point(135, 40);
            this.cb_Asientos.Name = "cb_Asientos";
            this.cb_Asientos.Size = new System.Drawing.Size(121, 23);
            this.cb_Asientos.TabIndex = 3;
            this.cb_Asientos.SelectedIndexChanged += new System.EventHandler(this.cb_Asientos_SelectedIndexChanged);
            // 
            // imagen
            // 
            this.imagen.Location = new System.Drawing.Point(521, 40);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(246, 204);
            this.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen.TabIndex = 4;
            this.imagen.TabStop = false;
            this.imagen.Visible = false;
            // 
            // n_Cantidad
            // 
            this.n_Cantidad.Location = new System.Drawing.Point(305, 206);
            this.n_Cantidad.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.n_Cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_Cantidad.Name = "n_Cantidad";
            this.n_Cantidad.Size = new System.Drawing.Size(120, 23);
            this.n_Cantidad.TabIndex = 5;
            this.n_Cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_Cantidad.ValueChanged += new System.EventHandler(this.n_Cantidad_ValueChanged);
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(117, 205);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(100, 23);
            this.txt_Total.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.n_Cantidad);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.cb_Asientos);
            this.Controls.Add(this.ck_Cama);
            this.Controls.Add(this.ck_SemiCama);
            this.Controls.Add(this.ck_Clasico);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_Cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ck_Clasico;
        private System.Windows.Forms.CheckBox ck_SemiCama;
        private System.Windows.Forms.CheckBox ck_Cama;
        private System.Windows.Forms.ComboBox cb_Asientos;
        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.NumericUpDown n_Cantidad;
        private System.Windows.Forms.TextBox txt_Total;
    }
}

