
namespace Ejercicio_06_04
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
            this.pic_Asiento = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_ValorDestino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_Asiento = new System.Windows.Forms.ComboBox();
            this.txt_ValorAsiento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.cbx_Origen = new System.Windows.Forms.ComboBox();
            this.cbx_Destino = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Asiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Asiento
            // 
            this.pic_Asiento.ImageLocation = "";
            this.pic_Asiento.Location = new System.Drawing.Point(431, 172);
            this.pic_Asiento.Name = "pic_Asiento";
            this.pic_Asiento.Size = new System.Drawing.Size(312, 224);
            this.pic_Asiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Asiento.TabIndex = 0;
            this.pic_Asiento.TabStop = false;
            this.pic_Asiento.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(549, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(194, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // txt_ValorDestino
            // 
            this.txt_ValorDestino.Location = new System.Drawing.Point(221, 150);
            this.txt_ValorDestino.Name = "txt_ValorDestino";
            this.txt_ValorDestino.Size = new System.Drawing.Size(100, 23);
            this.txt_ValorDestino.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor";
            // 
            // cbx_Asiento
            // 
            this.cbx_Asiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Asiento.FormattingEnabled = true;
            this.cbx_Asiento.Location = new System.Drawing.Point(225, 220);
            this.cbx_Asiento.Name = "cbx_Asiento";
            this.cbx_Asiento.Size = new System.Drawing.Size(121, 23);
            this.cbx_Asiento.TabIndex = 8;
            this.cbx_Asiento.SelectedIndexChanged += new System.EventHandler(this.cbx_Asiento_SelectedIndexChanged);
            // 
            // txt_ValorAsiento
            // 
            this.txt_ValorAsiento.Location = new System.Drawing.Point(225, 270);
            this.txt_ValorAsiento.Name = "txt_ValorAsiento";
            this.txt_ValorAsiento.Size = new System.Drawing.Size(100, 23);
            this.txt_ValorAsiento.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Asiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total a pagar";
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(225, 320);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(100, 23);
            this.txt_Total.TabIndex = 13;
            // 
            // cbx_Origen
            // 
            this.cbx_Origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Origen.FormattingEnabled = true;
            this.cbx_Origen.Location = new System.Drawing.Point(221, 50);
            this.cbx_Origen.Name = "cbx_Origen";
            this.cbx_Origen.Size = new System.Drawing.Size(121, 23);
            this.cbx_Origen.TabIndex = 14;
            this.cbx_Origen.SelectedIndexChanged += new System.EventHandler(this.cbx_Origen_SelectedIndexChanged);
            // 
            // cbx_Destino
            // 
            this.cbx_Destino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Destino.FormattingEnabled = true;
            this.cbx_Destino.Location = new System.Drawing.Point(221, 100);
            this.cbx_Destino.Name = "cbx_Destino";
            this.cbx_Destino.Size = new System.Drawing.Size(121, 23);
            this.cbx_Destino.TabIndex = 15;
            this.cbx_Destino.SelectedIndexChanged += new System.EventHandler(this.cbx_Destino_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbx_Destino);
            this.Controls.Add(this.cbx_Origen);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ValorAsiento);
            this.Controls.Add(this.cbx_Asiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ValorDestino);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pic_Asiento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Asiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Asiento;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_ValorDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_Asiento;
        private System.Windows.Forms.TextBox txt_ValorAsiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.ComboBox cbx_Origen;
        private System.Windows.Forms.ComboBox cbx_Destino;
    }
}

