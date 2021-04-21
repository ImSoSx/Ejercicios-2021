
namespace EjercicioNota_01
{
    partial class FormPizza
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
            this.btn_agregartaco = new System.Windows.Forms.Button();
            this.ckbx_Bebida = new System.Windows.Forms.CheckBox();
            this.ckbx_Vacuno = new System.Windows.Forms.CheckBox();
            this.ckbx_Atun = new System.Windows.Forms.CheckBox();
            this.ckbx_Pollo = new System.Windows.Forms.CheckBox();
            this.txt_ValorFinal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ValorExtra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.ckbx_HabilitarExtras = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.num_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.btn_Listar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_Pizza = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_TipoPizza = new System.Windows.Forms.ComboBox();
            this.ckbx_Bebida1 = new System.Windows.Forms.CheckBox();
            this.ckbx_Vacuno1 = new System.Windows.Forms.CheckBox();
            this.ckbx_Atun1 = new System.Windows.Forms.CheckBox();
            this.ckbx_Pollo1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ValorTaco = new System.Windows.Forms.TextBox();
            this.ckbx_HabilitarExtras1 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.num_CantidadTacos = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.cbx_Tacos = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.txt_valortacosF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_valorExtraT = new System.Windows.Forms.TextBox();
            this.txt_ValorPizzas = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.ckbx_Camarones = new System.Windows.Forms.CheckBox();
            this.ckbx_Queso = new System.Windows.Forms.CheckBox();
            this.ckbx_Jamon = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_Cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_CantidadTacos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_agregartaco
            // 
            this.btn_agregartaco.Location = new System.Drawing.Point(83, 323);
            this.btn_agregartaco.Name = "btn_agregartaco";
            this.btn_agregartaco.Size = new System.Drawing.Size(75, 23);
            this.btn_agregartaco.TabIndex = 0;
            this.btn_agregartaco.Text = "Agregar";
            this.btn_agregartaco.UseVisualStyleBackColor = true;
            this.btn_agregartaco.Click += new System.EventHandler(this.btn_agregartaco_Click);
            // 
            // ckbx_Bebida
            // 
            this.ckbx_Bebida.AutoSize = true;
            this.ckbx_Bebida.Location = new System.Drawing.Point(670, 255);
            this.ckbx_Bebida.Name = "ckbx_Bebida";
            this.ckbx_Bebida.Size = new System.Drawing.Size(103, 19);
            this.ckbx_Bebida.TabIndex = 41;
            this.ckbx_Bebida.Text = "Lata de Bebida";
            this.ckbx_Bebida.UseVisualStyleBackColor = true;
            this.ckbx_Bebida.CheckedChanged += new System.EventHandler(this.ckbx_Bebida_CheckedChanged);
            // 
            // ckbx_Vacuno
            // 
            this.ckbx_Vacuno.AutoSize = true;
            this.ckbx_Vacuno.Location = new System.Drawing.Point(670, 230);
            this.ckbx_Vacuno.Name = "ckbx_Vacuno";
            this.ckbx_Vacuno.Size = new System.Drawing.Size(65, 19);
            this.ckbx_Vacuno.TabIndex = 40;
            this.ckbx_Vacuno.Text = "Vacuno";
            this.ckbx_Vacuno.UseVisualStyleBackColor = true;
            this.ckbx_Vacuno.CheckedChanged += new System.EventHandler(this.ckbx_Vacuno_CheckedChanged);
            // 
            // ckbx_Atun
            // 
            this.ckbx_Atun.AutoSize = true;
            this.ckbx_Atun.Location = new System.Drawing.Point(670, 205);
            this.ckbx_Atun.Name = "ckbx_Atun";
            this.ckbx_Atun.Size = new System.Drawing.Size(52, 19);
            this.ckbx_Atun.TabIndex = 39;
            this.ckbx_Atun.Text = "Atun";
            this.ckbx_Atun.UseVisualStyleBackColor = true;
            this.ckbx_Atun.CheckedChanged += new System.EventHandler(this.ckbx_Atun_CheckedChanged);
            // 
            // ckbx_Pollo
            // 
            this.ckbx_Pollo.AutoSize = true;
            this.ckbx_Pollo.Location = new System.Drawing.Point(670, 180);
            this.ckbx_Pollo.Name = "ckbx_Pollo";
            this.ckbx_Pollo.Size = new System.Drawing.Size(53, 19);
            this.ckbx_Pollo.TabIndex = 38;
            this.ckbx_Pollo.Text = "Pollo";
            this.ckbx_Pollo.UseVisualStyleBackColor = true;
            this.ckbx_Pollo.CheckedChanged += new System.EventHandler(this.ckbx_Pollo_CheckedChanged);
            // 
            // txt_ValorFinal
            // 
            this.txt_ValorFinal.Enabled = false;
            this.txt_ValorFinal.Location = new System.Drawing.Point(481, 467);
            this.txt_ValorFinal.Name = "txt_ValorFinal";
            this.txt_ValorFinal.Size = new System.Drawing.Size(100, 23);
            this.txt_ValorFinal.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 36;
            this.label5.Text = "Total a Pagar:";
            // 
            // txt_ValorExtra
            // 
            this.txt_ValorExtra.Enabled = false;
            this.txt_ValorExtra.Location = new System.Drawing.Point(921, 461);
            this.txt_ValorExtra.Name = "txt_ValorExtra";
            this.txt_ValorExtra.Size = new System.Drawing.Size(100, 23);
            this.txt_ValorExtra.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(850, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Valor Extra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(670, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Valor:";
            // 
            // txt_Valor
            // 
            this.txt_Valor.Enabled = false;
            this.txt_Valor.Location = new System.Drawing.Point(743, 299);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(120, 23);
            this.txt_Valor.TabIndex = 32;
            // 
            // ckbx_HabilitarExtras
            // 
            this.ckbx_HabilitarExtras.AutoSize = true;
            this.ckbx_HabilitarExtras.Location = new System.Drawing.Point(639, 155);
            this.ckbx_HabilitarExtras.Name = "ckbx_HabilitarExtras";
            this.ckbx_HabilitarExtras.Size = new System.Drawing.Size(57, 19);
            this.ckbx_HabilitarExtras.TabIndex = 31;
            this.ckbx_HabilitarExtras.Text = "Extras";
            this.ckbx_HabilitarExtras.UseVisualStyleBackColor = true;
            this.ckbx_HabilitarExtras.CheckedChanged += new System.EventHandler(this.ckbx_HabilitarExtras_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(639, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Cantidad";
            // 
            // num_Cantidad
            // 
            this.num_Cantidad.Location = new System.Drawing.Point(713, 124);
            this.num_Cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Cantidad.Name = "num_Cantidad";
            this.num_Cantidad.Size = new System.Drawing.Size(120, 23);
            this.num_Cantidad.TabIndex = 29;
            this.num_Cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Cantidad.ValueChanged += new System.EventHandler(this.num_Cantidad_ValueChanged);
            // 
            // btn_Listar
            // 
            this.btn_Listar.Location = new System.Drawing.Point(489, 323);
            this.btn_Listar.Name = "btn_Listar";
            this.btn_Listar.Size = new System.Drawing.Size(82, 23);
            this.btn_Listar.TabIndex = 28;
            this.btn_Listar.Text = "Limpiar";
            this.btn_Listar.UseVisualStyleBackColor = true;
            this.btn_Listar.Click += new System.EventHandler(this.btn_Listar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(764, 328);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 27;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(639, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tamaño";
            // 
            // cbx_Pizza
            // 
            this.cbx_Pizza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Pizza.FormattingEnabled = true;
            this.cbx_Pizza.Location = new System.Drawing.Point(712, 89);
            this.cbx_Pizza.Name = "cbx_Pizza";
            this.cbx_Pizza.Size = new System.Drawing.Size(121, 23);
            this.cbx_Pizza.TabIndex = 25;
            this.cbx_Pizza.SelectedIndexChanged += new System.EventHandler(this.cbx_Pizza_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(548, 352);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(611, 97);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(639, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 47;
            this.label6.Text = "Tipo";
            // 
            // cbx_TipoPizza
            // 
            this.cbx_TipoPizza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_TipoPizza.FormattingEnabled = true;
            this.cbx_TipoPizza.Location = new System.Drawing.Point(712, 60);
            this.cbx_TipoPizza.Name = "cbx_TipoPizza";
            this.cbx_TipoPizza.Size = new System.Drawing.Size(121, 23);
            this.cbx_TipoPizza.TabIndex = 46;
            // 
            // ckbx_Bebida1
            // 
            this.ckbx_Bebida1.AutoSize = true;
            this.ckbx_Bebida1.Location = new System.Drawing.Point(192, 230);
            this.ckbx_Bebida1.Name = "ckbx_Bebida1";
            this.ckbx_Bebida1.Size = new System.Drawing.Size(103, 19);
            this.ckbx_Bebida1.TabIndex = 58;
            this.ckbx_Bebida1.Text = "Lata de Bebida";
            this.ckbx_Bebida1.UseVisualStyleBackColor = true;
            this.ckbx_Bebida1.CheckedChanged += new System.EventHandler(this.ckbx_Bebida1_CheckedChanged);
            // 
            // ckbx_Vacuno1
            // 
            this.ckbx_Vacuno1.AutoSize = true;
            this.ckbx_Vacuno1.Location = new System.Drawing.Point(192, 205);
            this.ckbx_Vacuno1.Name = "ckbx_Vacuno1";
            this.ckbx_Vacuno1.Size = new System.Drawing.Size(65, 19);
            this.ckbx_Vacuno1.TabIndex = 57;
            this.ckbx_Vacuno1.Text = "Vacuno";
            this.ckbx_Vacuno1.UseVisualStyleBackColor = true;
            this.ckbx_Vacuno1.CheckedChanged += new System.EventHandler(this.ckbx_Vacuno1_CheckedChanged);
            // 
            // ckbx_Atun1
            // 
            this.ckbx_Atun1.AutoSize = true;
            this.ckbx_Atun1.Location = new System.Drawing.Point(192, 180);
            this.ckbx_Atun1.Name = "ckbx_Atun1";
            this.ckbx_Atun1.Size = new System.Drawing.Size(52, 19);
            this.ckbx_Atun1.TabIndex = 56;
            this.ckbx_Atun1.Text = "Atun";
            this.ckbx_Atun1.UseVisualStyleBackColor = true;
            this.ckbx_Atun1.CheckedChanged += new System.EventHandler(this.ckbx_Atun1_CheckedChanged);
            // 
            // ckbx_Pollo1
            // 
            this.ckbx_Pollo1.AutoSize = true;
            this.ckbx_Pollo1.Location = new System.Drawing.Point(192, 155);
            this.ckbx_Pollo1.Name = "ckbx_Pollo1";
            this.ckbx_Pollo1.Size = new System.Drawing.Size(53, 19);
            this.ckbx_Pollo1.TabIndex = 55;
            this.ckbx_Pollo1.Text = "Pollo";
            this.ckbx_Pollo1.UseVisualStyleBackColor = true;
            this.ckbx_Pollo1.CheckedChanged += new System.EventHandler(this.ckbx_Pollo1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 54;
            this.label8.Text = "Valor:";
            // 
            // txt_ValorTaco
            // 
            this.txt_ValorTaco.Enabled = false;
            this.txt_ValorTaco.Location = new System.Drawing.Point(235, 256);
            this.txt_ValorTaco.Name = "txt_ValorTaco";
            this.txt_ValorTaco.Size = new System.Drawing.Size(120, 23);
            this.txt_ValorTaco.TabIndex = 53;
            // 
            // ckbx_HabilitarExtras1
            // 
            this.ckbx_HabilitarExtras1.AutoSize = true;
            this.ckbx_HabilitarExtras1.Location = new System.Drawing.Point(161, 130);
            this.ckbx_HabilitarExtras1.Name = "ckbx_HabilitarExtras1";
            this.ckbx_HabilitarExtras1.Size = new System.Drawing.Size(57, 19);
            this.ckbx_HabilitarExtras1.TabIndex = 52;
            this.ckbx_HabilitarExtras1.Text = "Extras";
            this.ckbx_HabilitarExtras1.UseVisualStyleBackColor = true;
            this.ckbx_HabilitarExtras1.CheckedChanged += new System.EventHandler(this.ckbx_HabilitarExtras1_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 51;
            this.label9.Text = "Cantidad";
            // 
            // num_CantidadTacos
            // 
            this.num_CantidadTacos.Location = new System.Drawing.Point(235, 86);
            this.num_CantidadTacos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_CantidadTacos.Name = "num_CantidadTacos";
            this.num_CantidadTacos.Size = new System.Drawing.Size(120, 23);
            this.num_CantidadTacos.TabIndex = 50;
            this.num_CantidadTacos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_CantidadTacos.ValueChanged += new System.EventHandler(this.num_CantidadTacos_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(161, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 49;
            this.label10.Text = "Relleno:";
            // 
            // cbx_Tacos
            // 
            this.cbx_Tacos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Tacos.FormattingEnabled = true;
            this.cbx_Tacos.Location = new System.Drawing.Point(235, 57);
            this.cbx_Tacos.Name = "cbx_Tacos";
            this.cbx_Tacos.Size = new System.Drawing.Size(121, 23);
            this.cbx_Tacos.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(743, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 15);
            this.label11.TabIndex = 61;
            this.label11.Text = "Pizza";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(265, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 15);
            this.label12.TabIndex = 62;
            this.label12.Text = "Tacos";
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(32, 352);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(473, 97);
            this.listView2.TabIndex = 63;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // txt_valortacosF
            // 
            this.txt_valortacosF.Enabled = false;
            this.txt_valortacosF.Location = new System.Drawing.Point(83, 461);
            this.txt_valortacosF.Name = "txt_valortacosF";
            this.txt_valortacosF.Size = new System.Drawing.Size(120, 23);
            this.txt_valortacosF.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 65;
            this.label7.Text = "Sub-Tacos:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(209, 464);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 15);
            this.label13.TabIndex = 66;
            this.label13.Text = "Sub-Extra:";
            // 
            // txt_valorExtraT
            // 
            this.txt_valorExtraT.Enabled = false;
            this.txt_valorExtraT.Location = new System.Drawing.Point(294, 461);
            this.txt_valorExtraT.Name = "txt_valorExtraT";
            this.txt_valorExtraT.Size = new System.Drawing.Size(100, 23);
            this.txt_valorExtraT.TabIndex = 67;
            // 
            // txt_ValorPizzas
            // 
            this.txt_ValorPizzas.Enabled = false;
            this.txt_ValorPizzas.Location = new System.Drawing.Point(702, 461);
            this.txt_ValorPizzas.Name = "txt_ValorPizzas";
            this.txt_ValorPizzas.Size = new System.Drawing.Size(100, 23);
            this.txt_ValorPizzas.TabIndex = 68;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(617, 467);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 15);
            this.label14.TabIndex = 69;
            this.label14.Text = "Valor Pizzas:";
            // 
            // btn_pagar
            // 
            this.btn_pagar.Location = new System.Drawing.Point(494, 251);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(75, 23);
            this.btn_pagar.TabIndex = 70;
            this.btn_pagar.Text = "Pagar";
            this.btn_pagar.UseVisualStyleBackColor = true;
            this.btn_pagar.Click += new System.EventHandler(this.btn_pagar_Click);
            // 
            // ckbx_Camarones
            // 
            this.ckbx_Camarones.AutoSize = true;
            this.ckbx_Camarones.Location = new System.Drawing.Point(780, 180);
            this.ckbx_Camarones.Name = "ckbx_Camarones";
            this.ckbx_Camarones.Size = new System.Drawing.Size(86, 19);
            this.ckbx_Camarones.TabIndex = 71;
            this.ckbx_Camarones.Text = "Camarones";
            this.ckbx_Camarones.UseVisualStyleBackColor = true;
            this.ckbx_Camarones.CheckedChanged += new System.EventHandler(this.ckbx_Camaron_CheckedChanged);
            // 
            // ckbx_Queso
            // 
            this.ckbx_Queso.AutoSize = true;
            this.ckbx_Queso.Location = new System.Drawing.Point(780, 205);
            this.ckbx_Queso.Name = "ckbx_Queso";
            this.ckbx_Queso.Size = new System.Drawing.Size(60, 19);
            this.ckbx_Queso.TabIndex = 72;
            this.ckbx_Queso.Text = "Queso";
            this.ckbx_Queso.UseVisualStyleBackColor = true;
            this.ckbx_Queso.CheckedChanged += new System.EventHandler(this.ckbx_Queso_CheckedChanged);
            // 
            // ckbx_Jamon
            // 
            this.ckbx_Jamon.AutoSize = true;
            this.ckbx_Jamon.Location = new System.Drawing.Point(780, 230);
            this.ckbx_Jamon.Name = "ckbx_Jamon";
            this.ckbx_Jamon.Size = new System.Drawing.Size(61, 19);
            this.ckbx_Jamon.TabIndex = 73;
            this.ckbx_Jamon.Text = "Jamon";
            this.ckbx_Jamon.UseVisualStyleBackColor = true;
            this.ckbx_Jamon.CheckedChanged += new System.EventHandler(this.ckbx_Jamon_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(429, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(130, 24);
            this.label16.TabIndex = 75;
            this.label16.Text = "TacosPizza";
            // 
            // FormPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 496);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ckbx_Jamon);
            this.Controls.Add(this.ckbx_Queso);
            this.Controls.Add(this.ckbx_Camarones);
            this.Controls.Add(this.btn_pagar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_ValorPizzas);
            this.Controls.Add(this.txt_valorExtraT);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_valortacosF);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ckbx_Bebida1);
            this.Controls.Add(this.ckbx_Vacuno1);
            this.Controls.Add(this.ckbx_Atun1);
            this.Controls.Add(this.ckbx_Pollo1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_ValorTaco);
            this.Controls.Add(this.ckbx_HabilitarExtras1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.num_CantidadTacos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbx_Tacos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbx_TipoPizza);
            this.Controls.Add(this.ckbx_Bebida);
            this.Controls.Add(this.ckbx_Vacuno);
            this.Controls.Add(this.ckbx_Atun);
            this.Controls.Add(this.ckbx_Pollo);
            this.Controls.Add(this.txt_ValorFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ValorExtra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.ckbx_HabilitarExtras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_Cantidad);
            this.Controls.Add(this.btn_Listar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_Pizza);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_agregartaco);
            this.Name = "FormPizza";
            this.Text = "TacosPizza - Pizza";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPizza_FormClosed);
            this.Load += new System.EventHandler(this.FormPizza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_Cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_CantidadTacos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_agregartaco;
        private System.Windows.Forms.CheckBox ckbx_Bebida;
        private System.Windows.Forms.CheckBox ckbx_Vacuno;
        private System.Windows.Forms.CheckBox ckbx_Atun;
        private System.Windows.Forms.CheckBox ckbx_Pollo;
        private System.Windows.Forms.TextBox txt_ValorFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ValorExtra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.CheckBox ckbx_HabilitarExtras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_Cantidad;
        private System.Windows.Forms.Button btn_Listar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_Pizza;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_TipoPizza;
        private System.Windows.Forms.CheckBox ckbx_Bebida1;
        private System.Windows.Forms.CheckBox ckbx_Vacuno1;
        private System.Windows.Forms.CheckBox ckbx_Atun1;
        private System.Windows.Forms.CheckBox ckbx_Pollo1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ValorTaco;
        private System.Windows.Forms.CheckBox ckbx_HabilitarExtras1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown num_CantidadTacos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbx_Tacos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TextBox txt_valortacosF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_valorExtraT;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_ValorPizzas;
        private System.Windows.Forms.Button btn_pagar;
        private System.Windows.Forms.CheckBox ckbx_Camarones;
        private System.Windows.Forms.CheckBox ckbx_Queso;
        private System.Windows.Forms.CheckBox ckbx_Jamon;
        private System.Windows.Forms.Label label16;
    }
}