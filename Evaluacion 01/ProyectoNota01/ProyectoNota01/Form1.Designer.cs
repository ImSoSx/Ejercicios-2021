
namespace ProyectoNota01
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_CantidadPasajes = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_TotalPago = new System.Windows.Forms.Label();
            this.lbl_ValorPasaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_Origen = new System.Windows.Forms.ComboBox();
            this.cbx_Destino = new System.Windows.Forms.ComboBox();
            this.cbx_TipoBus = new System.Windows.Forms.ComboBox();
            this.txt_CantPasajeros = new System.Windows.Forms.TextBox();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Resumen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_CantidadPasajes);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_TotalPago);
            this.groupBox1.Controls.Add(this.lbl_ValorPasaje);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado";
            // 
            // lbl_CantidadPasajes
            // 
            this.lbl_CantidadPasajes.AutoSize = true;
            this.lbl_CantidadPasajes.Location = new System.Drawing.Point(115, 46);
            this.lbl_CantidadPasajes.Name = "lbl_CantidadPasajes";
            this.lbl_CantidadPasajes.Size = new System.Drawing.Size(38, 15);
            this.lbl_CantidadPasajes.TabIndex = 5;
            this.lbl_CantidadPasajes.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cantidad Pasajes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total a Pagar:";
            // 
            // lbl_TotalPago
            // 
            this.lbl_TotalPago.AutoSize = true;
            this.lbl_TotalPago.Location = new System.Drawing.Point(115, 72);
            this.lbl_TotalPago.Name = "lbl_TotalPago";
            this.lbl_TotalPago.Size = new System.Drawing.Size(38, 15);
            this.lbl_TotalPago.TabIndex = 2;
            this.lbl_TotalPago.Text = "label3";
            this.lbl_TotalPago.Visible = false;
            // 
            // lbl_ValorPasaje
            // 
            this.lbl_ValorPasaje.AutoSize = true;
            this.lbl_ValorPasaje.Location = new System.Drawing.Point(115, 19);
            this.lbl_ValorPasaje.Name = "lbl_ValorPasaje";
            this.lbl_ValorPasaje.Size = new System.Drawing.Size(38, 15);
            this.lbl_ValorPasaje.TabIndex = 1;
            this.lbl_ValorPasaje.Text = "label2";
            this.lbl_ValorPasaje.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor del Pasaje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Origen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destino:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tipo de Bus:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "N° de pasajeros";
            // 
            // cbx_Origen
            // 
            this.cbx_Origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Origen.FormattingEnabled = true;
            this.cbx_Origen.Location = new System.Drawing.Point(137, 15);
            this.cbx_Origen.Name = "cbx_Origen";
            this.cbx_Origen.Size = new System.Drawing.Size(121, 23);
            this.cbx_Origen.TabIndex = 5;
            this.cbx_Origen.SelectedIndexChanged += new System.EventHandler(this.cbx_Origen_SelectedIndexChanged);
            // 
            // cbx_Destino
            // 
            this.cbx_Destino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Destino.FormattingEnabled = true;
            this.cbx_Destino.Location = new System.Drawing.Point(137, 55);
            this.cbx_Destino.Name = "cbx_Destino";
            this.cbx_Destino.Size = new System.Drawing.Size(121, 23);
            this.cbx_Destino.TabIndex = 6;
            this.cbx_Destino.SelectedIndexChanged += new System.EventHandler(this.cbx_Destino_SelectedIndexChanged);
            // 
            // cbx_TipoBus
            // 
            this.cbx_TipoBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_TipoBus.FormattingEnabled = true;
            this.cbx_TipoBus.Location = new System.Drawing.Point(137, 95);
            this.cbx_TipoBus.Name = "cbx_TipoBus";
            this.cbx_TipoBus.Size = new System.Drawing.Size(121, 23);
            this.cbx_TipoBus.TabIndex = 7;
            this.cbx_TipoBus.SelectedIndexChanged += new System.EventHandler(this.cbx_TipoBus_SelectedIndexChanged);
            // 
            // txt_CantPasajeros
            // 
            this.txt_CantPasajeros.Location = new System.Drawing.Point(137, 135);
            this.txt_CantPasajeros.Name = "txt_CantPasajeros";
            this.txt_CantPasajeros.Size = new System.Drawing.Size(100, 23);
            this.txt_CantPasajeros.TabIndex = 8;
            this.txt_CantPasajeros.TextChanged += new System.EventHandler(this.txt_CantPasajeros_TextChanged);
            this.txt_CantPasajeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CantPasajeros_KeyPress);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(270, 135);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_Nuevo.TabIndex = 9;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Resumen
            // 
            this.btn_Resumen.Location = new System.Drawing.Point(158, 302);
            this.btn_Resumen.Name = "btn_Resumen";
            this.btn_Resumen.Size = new System.Drawing.Size(136, 23);
            this.btn_Resumen.TabIndex = 10;
            this.btn_Resumen.Text = "Resumen de ventas";
            this.btn_Resumen.UseVisualStyleBackColor = true;
            this.btn_Resumen.Click += new System.EventHandler(this.btn_Resumen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::ProyectoNota01.Properties.Resources.semicama;
            this.pictureBox1.Location = new System.Drawing.Point(388, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(270, 165);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 12;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(804, 454);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Resumen);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.txt_CantPasajeros);
            this.Controls.Add(this.cbx_TipoBus);
            this.Controls.Add(this.cbx_Destino);
            this.Controls.Add(this.cbx_Origen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(820, 490);
            this.MinimumSize = new System.Drawing.Size(820, 490);
            this.Name = "Form1";
            this.Text = "Evaluacion 01";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_TotalPago;
        private System.Windows.Forms.Label lbl_ValorPasaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_Origen;
        private System.Windows.Forms.ComboBox cbx_Destino;
        private System.Windows.Forms.ComboBox cbx_TipoBus;
        private System.Windows.Forms.TextBox txt_CantPasajeros;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Resumen;
        private System.Windows.Forms.Label lbl_CantidadPasajes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Agregar;
    }
}

