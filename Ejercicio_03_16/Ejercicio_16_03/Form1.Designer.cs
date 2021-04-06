
namespace Ejercicio1Clase1
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
            this.lbl_txt = new System.Windows.Forms.Label();
            this.btn_txt = new System.Windows.Forms.Button();
            this.btn_sgt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_txt
            // 
            this.lbl_txt.AutoSize = true;
            this.lbl_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_txt.Location = new System.Drawing.Point(21, 9);
            this.lbl_txt.Name = "lbl_txt";
            this.lbl_txt.Size = new System.Drawing.Size(197, 21);
            this.lbl_txt.TabIndex = 0;
            this.lbl_txt.Text = "Programacion Avanzada";
            this.lbl_txt.Visible = false;
            // 
            // btn_txt
            // 
            this.btn_txt.Location = new System.Drawing.Point(21, 45);
            this.btn_txt.Name = "btn_txt";
            this.btn_txt.Size = new System.Drawing.Size(197, 38);
            this.btn_txt.TabIndex = 1;
            this.btn_txt.Text = "Mostrar/Ocultar";
            this.btn_txt.UseVisualStyleBackColor = true;
            this.btn_txt.Click += new System.EventHandler(this.btn_txt_Click);
            // 
            // btn_sgt
            // 
            this.btn_sgt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sgt.Location = new System.Drawing.Point(240, 109);
            this.btn_sgt.Name = "btn_sgt";
            this.btn_sgt.Size = new System.Drawing.Size(110, 32);
            this.btn_sgt.TabIndex = 2;
            this.btn_sgt.Text = "Siguiente";
            this.btn_sgt.UseVisualStyleBackColor = true;
            this.btn_sgt.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 142);
            this.Controls.Add(this.btn_sgt);
            this.Controls.Add(this.btn_txt);
            this.Controls.Add(this.lbl_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_txt;
        private System.Windows.Forms.Button btn_txt;
        private System.Windows.Forms.Button btn_sgt;
    }
}

