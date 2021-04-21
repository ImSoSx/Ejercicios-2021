using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EjercicioNota_01
{
    public partial class FormPizza : Form
    {
        int valorextra = 0;
        int total = 0;
        int extratotalP = 0; 
        int extratotalT = 0;
        int valorfinal = 0;
        String descripcion = "";
        //listas
        private List<Extras> ListaExtras = new List<Extras>();
        private List<Extras> ListaExtras2 = new List<Extras>();
        private List<Pizza> ListaPizzas = new List<Pizza>();
        private List<Tacos> ListaTacos = new List<Tacos>();
        public FormPizza()
        {
            InitializeComponent();
            //Centrar ventana
            CenterToScreen();
            //vista tabla tacos
            listView2.View = View.Details;
            listView2.Columns.Add("Tipo", 50, HorizontalAlignment.Left);
            listView2.Columns.Add("Relleno", 70, HorizontalAlignment.Left);
            listView2.Columns.Add("Extras", 200, HorizontalAlignment.Left);
            listView2.Columns.Add("Cant", 45, HorizontalAlignment.Left);
            listView2.Columns.Add("Precio", 70, HorizontalAlignment.Left);
            listView2.Columns.Add("P.Ex", 70, HorizontalAlignment.Left);
            //Rellenar ComboBox
            cbx_Tacos.Items.Add("Mixto");
            cbx_Tacos.Items.Add("Pollo");
            cbx_Tacos.Items.Add("Atun");
            cbx_Tacos.SelectedIndex = 0;
            //desactivar extras
            ckbx_Pollo1.Enabled = false;
            ckbx_Atun1.Enabled = false;
            ckbx_Vacuno1.Enabled = false;
            ckbx_Bebida1.Enabled = false;
            //Vista de tabla Pizza
            listView1.View = View.Details;
            listView1.Columns.Add("Tipo", 35, HorizontalAlignment.Left);
            listView1.Columns.Add("Masa", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Tamaño", 70, HorizontalAlignment.Left);
            listView1.Columns.Add("Extras", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Precio", 70, HorizontalAlignment.Left);
            listView1.Columns.Add("Cant", 45, HorizontalAlignment.Left);
            listView1.Columns.Add("P.Ex", 45, HorizontalAlignment.Left);

            //Rellenar ComboBox Tamaño
            cbx_Pizza.Items.Add("Individual");
            cbx_Pizza.Items.Add("Mediana");
            cbx_Pizza.Items.Add("Familiar");
            cbx_Pizza.SelectedIndex = 0;
            //Rellenar ComboBox Tipo masa
            cbx_TipoPizza.Items.Add("Masa a La Piedra");
            cbx_TipoPizza.Items.Add("Masa normal");
            cbx_TipoPizza.SelectedIndex = 0;
            //Desactivar Extras
            ckbx_Pollo.Enabled = false;
            ckbx_Atun.Enabled = false;
            ckbx_Vacuno.Enabled = false;
            ckbx_Bebida.Enabled = false;
            ckbx_Camarones.Enabled = false;
            ckbx_Queso.Enabled = false;
            ckbx_Jamon.Enabled = false;
            //Dar valor default a cajas de texto
            txt_ValorTaco.Text = "3000";
            txt_ValorFinal.Text = "0";
            txt_valortacosF.Text = "0";
            txt_valorExtraT.Text = "0";
            txt_ValorExtra.Text = "0";
            txt_Valor.Text = "3000";
            txt_ValorPizzas.Text = "0";
        }

        private void FormPizza_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #region PIZZA
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            //Limpiar variables
            ListaExtras.Clear();
            descripcion = "";
            total = 0;
            valorextra = 0;

            listView1.Items.Clear();
            //

            //Validar Checkbox de Extras
            if (ckbx_Pollo.Checked.Equals(true))
            {
                //Si checkbox esta activado
                descripcion = descripcion + ckbx_Pollo.Text;
                Extras ext = new Extras();
                ext.Tipo = "Extra";
                ext.Nombre = ckbx_Pollo.Text.ToString();
                ext.Precio = ext.Precios(ext.Nombre);
                ext.Cantidad = (int)num_Cantidad.Value;
                ListaExtras.Add(ext);
            }
            if (ckbx_Atun.Checked.Equals(true))
            {
                //Si checkbox esta activado
                descripcion = descripcion + " " + ckbx_Atun.Text;
                Extras ext = new Extras();
                ext.Tipo = "Extra";
                ext.Nombre = ckbx_Atun.Text.ToString();
                ext.Precio = ext.Precios(ext.Nombre);
                ext.Cantidad = (int)num_Cantidad.Value;
                ListaExtras.Add(ext);
            }
            if (ckbx_Vacuno.Checked.Equals(true))
            {
                //Si checkbox esta activado
                descripcion = descripcion + " " + ckbx_Vacuno.Text;
                Extras ext = new Extras();
                ext.Tipo = "Extra";
                ext.Nombre = ckbx_Vacuno.Text.ToString();
                ext.Precio = ext.Precios(ext.Nombre);
                ext.Cantidad = (int)num_Cantidad.Value;
                ListaExtras.Add(ext);
            }
            if (ckbx_Bebida.Checked.Equals(true))
            {
                //Si checkbox esta activado
                descripcion = descripcion + " " + ckbx_Bebida.Text;
                Extras ext = new Extras();
                ext.Tipo = "Extra";
                ext.Nombre = ckbx_Bebida.Text.ToString();
                ext.Precio = ext.Precios(ext.Nombre);
                ext.Cantidad = (int)num_Cantidad.Value;
                ListaExtras.Add(ext);
            }
            if (ckbx_Camarones.Checked.Equals(true))
            {
                //Si checkbox esta activado
                descripcion = descripcion + " " + ckbx_Camarones.Text;
                Extras ext = new Extras();
                ext.Tipo = "Extra";
                ext.Nombre = ckbx_Camarones.Text.ToString();
                ext.Precio = ext.Precios(ext.Nombre);
                ext.Cantidad = (int)num_Cantidad.Value;
                ListaExtras.Add(ext);
            }
            if (ckbx_Queso.Checked.Equals(true))
            {
                //Si checkbox esta activado
                descripcion = descripcion + " " + ckbx_Queso.Text;
                Extras ext = new Extras();
                ext.Tipo = "Extra";
                ext.Nombre = ckbx_Queso.Text.ToString();
                ext.Precio = ext.Precios(ext.Nombre);
                ext.Cantidad = (int)num_Cantidad.Value;
                ListaExtras.Add(ext);
            }
            if (ckbx_Jamon.Checked.Equals(true))
            {
                //Si checkbox esta activado
                descripcion = descripcion + " " + ckbx_Jamon.Text;
                Extras ext = new Extras();
                ext.Tipo = "Extra";
                ext.Nombre = ckbx_Jamon.Text.ToString();
                ext.Precio = ext.Precios(ext.Nombre);
                ext.Cantidad = (int)num_Cantidad.Value;
                ListaExtras.Add(ext);
            }
            //Enviar datos a la lista

            foreach (Extras ext in ListaExtras)
            {
                extratotalP = extratotalP + ext.CalcularSubtotal();
                valorextra = valorextra + ext.CalcularSubtotal();
                txt_ValorExtra.Text = extratotalP.ToString();
            }
            Pizza pzz = new Pizza();
            pzz.Tipo = "Pizza";
            pzz.TipoMasa = cbx_TipoPizza.Text;
            pzz.Extras = descripcion;
            pzz.Size = cbx_Pizza.Text;
            pzz.ValorExtras = valorextra;
            pzz.Cantidad = (int)num_Cantidad.Value;
            pzz.Precio = pzz.Precios(pzz.Size) * pzz.Cantidad;
            ListaPizzas.Add(pzz);
            foreach (Pizza pizza in ListaPizzas)
            {
                ListViewItem item = new ListViewItem();
                item = listView1.Items.Add(pizza.Tipo.ToString());
                item.SubItems.Add(pizza.TipoMasa.ToString());
                item.SubItems.Add(pizza.Size.ToString());
                item.SubItems.Add(pizza.Extras);
                item.SubItems.Add(pizza.Precio.ToString());
                item.SubItems.Add(pizza.Cantidad.ToString());
                item.SubItems.Add(pizza.ValorExtras.ToString());
                total = total + pizza.Precio;
                txt_ValorPizzas.Text = total.ToString();
            }
            valorfinal = Int32.Parse(txt_valortacosF.Text) + Int32.Parse(txt_ValorPizzas.Text) + Int32.Parse(txt_ValorExtra.Text) + Int32.Parse(txt_valorExtraT.Text);
            txt_ValorFinal.Text = valorfinal.ToString();
            num_Cantidad.Value = 1;
            ckbx_HabilitarExtras.Checked = false;

        }

        private void ckbx_HabilitarExtras_CheckedChanged(object sender, EventArgs e)
        {

            //Habilitar Extras
            if (ckbx_HabilitarExtras.Checked == true)
            {
                ckbx_Pollo.Enabled = true;
                ckbx_Atun.Enabled = true;
                ckbx_Vacuno.Enabled = true;
                ckbx_Bebida.Enabled = true;
                ckbx_Camarones.Enabled = true;
                ckbx_Queso.Enabled = true;
                ckbx_Jamon.Enabled = true;
                num_Cantidad.Enabled = false;
            }
            else
            {
                ckbx_Pollo.Checked = false;
                ckbx_Atun.Checked = false;
                ckbx_Vacuno.Checked = false;
                ckbx_Bebida.Checked = false;
                ckbx_Camarones.Checked = false;
                ckbx_Queso.Checked = false;
                ckbx_Jamon.Checked = false;
                ckbx_Pollo.Enabled = false;
                ckbx_Atun.Enabled = false;
                ckbx_Vacuno.Enabled = false;
                ckbx_Bebida.Enabled = false;
                ckbx_Camarones.Enabled = false;
                ckbx_Queso.Enabled = false;
                ckbx_Jamon.Enabled = false;
                num_Cantidad.Enabled = true;
            }
        }

        private void num_Cantidad_ValueChanged(object sender, EventArgs e)
        {
            if (num_Cantidad.Value > 1)
            {
                cbx_Pizza.Enabled = false;
            }
            else
            {
                cbx_Pizza.Enabled = true;
            }
            if (cbx_Pizza.Text == "")
            {

            }
            else
            {
                //Crear Entidad Taco
                Pizza pizza = new Pizza();
                pizza.Size = cbx_Pizza.Text.ToString();
                pizza.Precio = pizza.Precios(pizza.Size);
                txt_Valor.Text = (pizza.Precio * num_Cantidad.Value).ToString();
            }
        }

        private void ckbx_Pollo_CheckedChanged(object sender, EventArgs e)
        {
            Extras extra = new Extras();
            extra.Nombre = ckbx_Pollo.Text;
            if (ckbx_Pollo.Checked.Equals(true))
            {

                txt_Valor.Text = (Int32.Parse(txt_Valor.Text) + extra.Precios(extra.Nombre) * num_Cantidad.Value).ToString();
            }
            else
            {
                txt_Valor.Text = (Int32.Parse(txt_Valor.Text) - extra.Precios(extra.Nombre) * num_Cantidad.Value).ToString();
            }

        }

        private void ckbx_Atun_CheckedChanged(object sender, EventArgs e)
        {
            Extras extra = new Extras();
            extra.Nombre = ckbx_Atun.Text;
            if (ckbx_Atun.Checked.Equals(true))
            {
                txt_Valor.Text = (Int32.Parse(txt_Valor.Text) + (extra.Precios(extra.Nombre) * num_Cantidad.Value)).ToString();
            }
            else
            {
                txt_Valor.Text = (Int32.Parse(txt_Valor.Text) - extra.Precios(extra.Nombre) * num_Cantidad.Value).ToString();
            }
        }

        private void ckbx_Vacuno_CheckedChanged(object sender, EventArgs e)
        {
            Extras extra = new Extras();
            extra.Nombre = ckbx_Vacuno.Text;
            if (ckbx_Vacuno.Checked.Equals(true))
            {
                txt_Valor.Text = (Int32.Parse(txt_Valor.Text) + extra.Precios(extra.Nombre) * num_Cantidad.Value).ToString();
            }
            else
            {
                txt_Valor.Text = (Int32.Parse(txt_Valor.Text) - extra.Precios(extra.Nombre) * num_Cantidad.Value).ToString();
            }
        }

        private void ckbx_Bebida_CheckedChanged(object sender, EventArgs e)
        {
            Extras extra = new Extras();
            extra.Nombre = ckbx_Bebida.Text;
            if (ckbx_Bebida.Checked.Equals(true))
            {
                txt_Valor.Text = (Int32.Parse(txt_Valor.Text) + extra.Precios(extra.Nombre) * num_Cantidad.Value).ToString();
            }
            else
            {
                txt_Valor.Text = (Int32.Parse(txt_Valor.Text) - extra.Precios(extra.Nombre) * num_Cantidad.Value).ToString();
            }
        }
        private void ckbx_Camaron_CheckedChanged(object sender, EventArgs e)
        {
            Extras extra = new Extras();
            extra.Nombre = ckbx_Camarones.Text;
            if (ckbx_Camarones.Checked.Equals(true))
            {
                txt_Valor.Text = (Int32.Parse(txt_Valor.Text) + extra.Precios(extra.Nombre) * num_Cantidad.Value).ToString();
            }
            else
            {
                txt_Valor.Text = (Int32.Parse(txt_Valor.Text) - extra.Precios(extra.Nombre) * num_Cantidad.Value).ToString();
            }
        }

        private void ckbx_Queso_CheckedChanged(object sender, EventArgs e)
        {
            Extras extra = new Extras();
            extra.Nombre = ckbx_Queso.Text;
            if (ckbx_Queso.Checked.Equals(true))
            {
                txt_Valor.Text = (Int32.Parse(txt_Valor.Text) + extra.Precios(extra.Nombre) * num_Cantidad.Value).ToString();
            }
            else
            {
                txt_Valor.Text = (Int32.Parse(txt_Valor.Text) - extra.Precios(extra.Nombre) * num_Cantidad.Value).ToString();
            }
        }

        private void ckbx_Jamon_CheckedChanged(object sender, EventArgs e)
        {
            Extras extra = new Extras();
            extra.Nombre = ckbx_Jamon.Text;
            if (ckbx_Jamon.Checked.Equals(true))
            {
                txt_Valor.Text = (Int32.Parse(txt_Valor.Text) + extra.Precios(extra.Nombre) * num_Cantidad.Value).ToString();
            }
            else
            {
                txt_Valor.Text = (Int32.Parse(txt_Valor.Text) - extra.Precios(extra.Nombre) * num_Cantidad.Value).ToString();
            }
        }

        //
        #endregion
        //
        //
        #region tacos
        private void btn_agregartaco_Click(object sender, EventArgs e)
        {
            //Limpiar variables
            ListaExtras2.Clear();
            descripcion = "";
            total = 0;
            valorextra = 0;
            txt_ValorFinal.Text = "0";

            listView2.Items.Clear();
            //

            //Validar Checkbox de Extras
            if (ckbx_Pollo1.Checked.Equals(true))
            {
                //Si checkbox esta activado
                descripcion = descripcion + ckbx_Pollo1.Text;
                Extras ext = new Extras();
                ext.Tipo = "Extra";
                ext.Nombre = ckbx_Pollo1.Text.ToString();
                ext.Precio = ext.Precios(ext.Nombre);
                ext.Cantidad = (int)num_CantidadTacos.Value;
                ListaExtras2.Add(ext);
            }
            if (ckbx_Atun1.Checked.Equals(true))
            {
                //Si checkbox esta activado
                descripcion = descripcion + " " + ckbx_Atun1.Text;
                Extras ext = new Extras();
                ext.Tipo = "Extra";
                ext.Nombre = ckbx_Atun1.Text.ToString();
                ext.Precio = ext.Precios(ext.Nombre);
                ext.Cantidad = (int)num_CantidadTacos.Value;
                ListaExtras2.Add(ext);
            }
            if (ckbx_Vacuno1.Checked.Equals(true))
            {
                //Si checkbox esta activado
                descripcion = descripcion + " " + ckbx_Vacuno1.Text;
                Extras ext = new Extras();
                ext.Tipo = "Extra";
                ext.Nombre = ckbx_Vacuno1.Text.ToString();
                ext.Precio = ext.Precios(ext.Nombre);
                ext.Cantidad = (int)num_CantidadTacos.Value;
                ListaExtras2.Add(ext);
            }
            if (ckbx_Bebida1.Checked.Equals(true))
            {
                //Si checkbox esta activado
                descripcion = descripcion + " " + ckbx_Bebida1.Text;
                Extras ext = new Extras();
                ext.Tipo = "Extra";
                ext.Nombre = ckbx_Bebida1.Text.ToString();
                ext.Precio = ext.Precios(ext.Nombre);
                ext.Cantidad = (int)num_CantidadTacos.Value;
                ListaExtras2.Add(ext);
            }

            //Enviar datos a la lista

            foreach (Extras ext in ListaExtras2)
            {
                extratotalT = extratotalT + ext.CalcularSubtotal();
                valorextra = valorextra + ext.CalcularSubtotal();
                txt_valorExtraT.Text = extratotalT.ToString();
            }
            Tacos tac = new Tacos();
            tac.Tipo = "Tacos";
            tac.Relleno = cbx_Tacos.Text;
            tac.Extras = descripcion;
            tac.Cantidad = (int)num_CantidadTacos.Value;
            tac.Precio = tac.Precios(tac.Relleno) * (int)num_CantidadTacos.Value;
            tac.ValorExtras = valorextra;
            ListaTacos.Add(tac);
            foreach (Tacos taco in ListaTacos)
            {
                ListViewItem item = new ListViewItem();
                item = listView2.Items.Add(taco.Tipo.ToString());
                item.SubItems.Add(taco.Relleno);
                item.SubItems.Add(taco.Extras);
                item.SubItems.Add(taco.Cantidad.ToString());
                item.SubItems.Add(taco.Precio.ToString());
                item.SubItems.Add(taco.ValorExtras.ToString());
                total = total + taco.Precio;
                txt_valortacosF.Text = total.ToString();
            }
            valorfinal = Int32.Parse(txt_valortacosF.Text) + Int32.Parse(txt_ValorPizzas.Text) + Int32.Parse(txt_ValorExtra.Text) + Int32.Parse(txt_valorExtraT.Text);
            txt_ValorFinal.Text = valorfinal.ToString();
            num_CantidadTacos.Value = 1;
            ckbx_HabilitarExtras1.Checked = false;

        }

        private void ckbx_HabilitarExtras1_CheckedChanged(object sender, EventArgs e)
        {
            //Habilitar Extras
            if (ckbx_HabilitarExtras1.Checked == true)
            {
                ckbx_Pollo1.Enabled = true;
                ckbx_Atun1.Enabled = true;
                ckbx_Vacuno1.Enabled = true;
                ckbx_Bebida1.Enabled = true;
                num_CantidadTacos.Enabled = false;
            }
            else
            {
                ckbx_Pollo1.Checked = false;
                ckbx_Atun1.Checked = false;
                ckbx_Vacuno1.Checked = false;
                ckbx_Bebida1.Checked = false;
                ckbx_Pollo1.Enabled = false;
                ckbx_Atun1.Enabled = false;
                ckbx_Vacuno1.Enabled = false;
                ckbx_Bebida1.Enabled = false;
                num_CantidadTacos.Enabled = true;
            }
        }

        private void FormPizza_Load(object sender, EventArgs e)
        {

        }

        private void ckbx_Pollo1_CheckedChanged(object sender, EventArgs e)
        {
            Extras extra = new Extras();
            extra.Nombre = ckbx_Pollo.Text;
            if (ckbx_Pollo1.Checked.Equals(true))
            {
                txt_ValorTaco.Text = (Int32.Parse(txt_ValorTaco.Text) + (extra.Precios(extra.Nombre) * num_CantidadTacos.Value)).ToString();
            }
            else
            {
                txt_ValorTaco.Text = (Int32.Parse(txt_ValorTaco.Text) - (extra.Precios(extra.Nombre) * num_CantidadTacos.Value)).ToString();
            }
        }

        private void ckbx_Atun1_CheckedChanged(object sender, EventArgs e)
        {
            Extras extra = new Extras();
            extra.Nombre = ckbx_Atun.Text;
            if (ckbx_Atun1.Checked.Equals(true))
            {
                txt_ValorTaco.Text = (Int32.Parse(txt_ValorTaco.Text) + (extra.Precios(extra.Nombre) * num_CantidadTacos.Value)).ToString();
            }
            else
            {
                txt_ValorTaco.Text = (Int32.Parse(txt_ValorTaco.Text) - (extra.Precios(extra.Nombre) * num_CantidadTacos.Value)).ToString();
            }
        }

        private void ckbx_Vacuno1_CheckedChanged(object sender, EventArgs e)
        {
            Extras extra = new Extras();
            extra.Nombre = ckbx_Vacuno.Text;
            if (ckbx_Vacuno1.Checked.Equals(true))
            {
                txt_ValorTaco.Text = (Int32.Parse(txt_ValorTaco.Text) + (extra.Precios(extra.Nombre) * num_CantidadTacos.Value)).ToString();
            }
            else
            {
                txt_ValorTaco.Text = (Int32.Parse(txt_ValorTaco.Text) - (extra.Precios(extra.Nombre) * num_CantidadTacos.Value)).ToString();
            }
        }

        private void ckbx_Bebida1_CheckedChanged(object sender, EventArgs e)
        {
            Extras extra = new Extras();
            extra.Nombre = ckbx_Bebida.Text;
            if (ckbx_Bebida1.Checked.Equals(true))
            {
                txt_ValorTaco.Text = (Int32.Parse(txt_ValorTaco.Text) + (extra.Precios(extra.Nombre) * num_CantidadTacos.Value)).ToString();
            }
            else
            {
                txt_ValorTaco.Text = (Int32.Parse(txt_ValorTaco.Text) - (extra.Precios(extra.Nombre) * num_CantidadTacos.Value)).ToString();
            }
        }

        private void num_CantidadTacos_ValueChanged(object sender, EventArgs e)
        {
            if (cbx_Tacos.Text == "")
            {

            }
            else
            {
                //Crear Entidad Taco
                Tacos tacos = new Tacos();
                tacos.Relleno = cbx_Tacos.Text.ToString();
                tacos.Precio = tacos.Precios(tacos.Relleno);
                txt_ValorTaco.Text = (tacos.Precio * num_CantidadTacos.Value).ToString();
            }
        }
        #endregion
        private void btn_Listar_Click(object sender, EventArgs e)
        {
            //Limpiar listado
            listView1.Items.Clear();
            listView2.Items.Clear();
            //Limpiar Listas
            ListaExtras.Clear();
            ListaExtras2.Clear();
            ListaTacos.Clear();
            ListaPizzas.Clear();
            extratotalP = 0;
            //Dar valor default a cajas de texto
            txt_ValorTaco.Text = "3000";
            txt_ValorFinal.Text = "0";
            txt_valortacosF.Text = "0";
            txt_valorExtraT.Text = "0";
            txt_ValorExtra.Text = "0";
            txt_Valor.Text = "3000";
            txt_ValorPizzas.Text = "0";

        }
        private void btn_pagar_Click(object sender, EventArgs e)
        {
            if (txt_ValorFinal.Text == "0")
            {
                MessageBox.Show("Carro vacio, porfavor agrege algo a la lista e intente nuevamente");
            }
            else
            {
                int f = Int32.Parse(txt_ValorFinal.Text);
                int iva = (int)(f * 0.19);
                MessageBox.Show("Total Compra: $" + txt_ValorFinal.Text + 
                    "\nIVA: $" + iva + 
                    "\nTotal a Pagar: \n$" + (f + iva));
            }
            //Limpiar listado
            listView1.Items.Clear();
            listView2.Items.Clear();
            //Limpiar Listas
            ListaExtras.Clear();
            ListaExtras2.Clear();
            ListaTacos.Clear();
            ListaPizzas.Clear();
            extratotalP = 0;
            //Dar valor default a cajas de texto
            txt_ValorTaco.Text = "3000";
            txt_ValorFinal.Text = "0";
            txt_valortacosF.Text = "0";
            txt_valorExtraT.Text = "0";
            txt_ValorExtra.Text = "0";
            txt_Valor.Text = "3000";
            txt_ValorPizzas.Text = "0";
            num_Cantidad.Value = 1;
            num_CantidadTacos.Value = 1;
            ckbx_HabilitarExtras.Checked = false;
            ckbx_HabilitarExtras1.Checked = false;
        }

        private void cbx_Pizza_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}