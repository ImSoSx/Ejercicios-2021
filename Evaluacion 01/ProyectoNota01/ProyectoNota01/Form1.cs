using System;
using System.Windows.Forms;

namespace ProyectoNota01
{
    public partial class Form1 : Form
    {
        public int precioPasaje = 0;
        public int precioFinal = 0;
        private Resultados res = new Resultados();
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            //Agregar items a combobox
            //origen
            cbx_Origen.Items.Add("Arica");
            cbx_Origen.Items.Add("Santiago");
            cbx_Origen.Items.Add("Concepcion");
            cbx_Origen.Items.Add("Pto. Montt");
            //Buses
            cbx_TipoBus.Items.Add("Clasico");
            cbx_TipoBus.Items.Add("SemiCama");
            cbx_TipoBus.Items.Add("Cama");
            //Seleccionar primer item de combobox
            cbx_Origen.SelectedIndex = 0;
            cbx_Destino.SelectedIndex = 0;
            cbx_TipoBus.SelectedIndex = 0;
            //Valor default n
            txt_CantPasajeros.Text = "1";
            lbl_CantidadPasajes.Visible = false;

        }

        private void btn_Resumen_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(res);
            form.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txt_CantPasajeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (Char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                if (e.KeyChar == (int)Keys.Enter)
                {
                    if (cbx_Origen.Text == "Pto. Montt" && cbx_Destino.Text == "Arica" || cbx_Origen.Text == "Arica" && cbx_Destino.Text == "Pto. Montt")
                    {
                        //
                    }
                    else if (txt_CantPasajeros.Text == "")
                    {
                        MessageBox.Show("Porfavor ingrese cantidad de pasajes a comprar");
                    }
                    else if (txt_CantPasajeros.Text == "0")
                    {
                        MessageBox.Show("La cantidad debe ser mayor a 0");
                    }
                    else
                    {
                        Ciudades c = new Ciudades();
                        c.Origen = cbx_Origen.SelectedItem.ToString();
                        c.Destino = cbx_Destino.SelectedItem.ToString();
                        precioPasaje = c.CalculoDestino(c.Origen, c.Destino);
                        Buses b = new Buses();
                        b.Tipo = cbx_TipoBus.SelectedItem.ToString();
                        b.PrecioPasaje = precioPasaje;
                        precioFinal = b.CalculoBus(b.Tipo, b.PrecioPasaje);
                        lbl_ValorPasaje.Visible = true;
                        lbl_ValorPasaje.Text = (precioFinal).ToString();
                        lbl_CantidadPasajes.Text = txt_CantPasajeros.Text;
                        lbl_CantidadPasajes.Visible = true;
                        lbl_TotalPago.Visible = true;
                        lbl_TotalPago.Text = (precioFinal * Int64.Parse(txt_CantPasajeros.Text)).ToString();
                        MessageBox.Show("Origen: " + c.Origen
                            + "\nDestino: " + c.Destino
                            + "\nAsiento: " + b.Tipo
                            + "\nPrecio pasaje normal: $" + precioPasaje
                            + "\nPrecio pasaje + valor asiento: $" + precioFinal
                            + "\nCantidad Pasajes: " + txt_CantPasajeros.Text
                            + "\nTotal a Pagar: $" + lbl_TotalPago.Text);
                    }

                    if (cbx_Origen.SelectedItem.Equals("Arica"))
                    {
                        if (cbx_Origen.Text == "Arica" && cbx_Destino.Text == "Pto. Montt")
                        {

                            MessageBox.Show("Viajes de arica a pto.montt y viceversa no disponibles");
                        }
                        else
                        {
                            res.totalArica = res.totalArica + Int64.Parse(lbl_TotalPago.Text);
                            res.pasajeArica = res.pasajeArica + Int64.Parse(txt_CantPasajeros.Text);
                        }
                    }
                    else if (cbx_Origen.SelectedItem.Equals("Concepcion"))
                    {
                        res.totalConce = res.totalConce + Int64.Parse(lbl_TotalPago.Text);
                        res.pasajeConce = res.pasajeConce + Int64.Parse(txt_CantPasajeros.Text);
                    }
                    else if (cbx_Origen.SelectedItem.Equals("Santiago"))
                    {
                        res.pasajeSantiago = res.pasajeSantiago + Int64.Parse(txt_CantPasajeros.Text);
                        res.totalSantiago = res.totalSantiago + Int64.Parse(lbl_TotalPago.Text);
                    }
                    else if (cbx_Origen.SelectedItem.Equals("Pto. Montt"))
                    {
                        if (cbx_Origen.Text == "Pto. Montt" && cbx_Destino.Text == "Arica")
                        {
                            MessageBox.Show("Viajes de Pto. Montt a Arica y viceversa no disponibles");
                        }
                        else
                        {
                            res.pasajePtoMontt = res.pasajePtoMontt + Int64.Parse(txt_CantPasajeros.Text);
                            res.totalPtoMontt = res.totalPtoMontt + Int64.Parse(lbl_TotalPago.Text);
                        }
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }

        }

        private void cbx_TipoBus_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Codigo
            if (cbx_TipoBus.SelectedItem.Equals("Clasico"))
            {
                pictureBox1.Image = Properties.Resources.clasico;
            }
            else if (cbx_TipoBus.SelectedItem.Equals("SemiCama"))
            {
                pictureBox1.Image = Properties.Resources.semicama;
            }
            else if (cbx_TipoBus.SelectedItem.Equals("Cama"))
            {
                pictureBox1.Image = Properties.Resources.cama;
            }

        }

        private void cbx_Destino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbx_Origen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Origen.SelectedItem.Equals("Arica"))
            {
                cbx_Destino.Items.Clear(); //Eliminar todos los items del combobox
                cbx_Destino.Items.Add("Santiago");
                cbx_Destino.Items.Add("Concepcion");
                cbx_Destino.Items.Add("Pto. Montt");
                cbx_Destino.SelectedIndex = 0; //Seleccionar automaticamente el primer item del combobox
            }
            else if (cbx_Origen.SelectedItem.Equals("Santiago"))
            {
                cbx_Destino.Items.Clear();
                cbx_Destino.Items.Add("Arica");
                cbx_Destino.Items.Add("Concepcion");
                cbx_Destino.Items.Add("Pto. Montt");
                cbx_Destino.SelectedIndex = 0; //Seleccionar automaticamente el primer item del combobox
            }
            else if (cbx_Origen.SelectedItem.Equals("Concepcion"))
            {
                cbx_Destino.Items.Clear();
                cbx_Destino.Items.Add("Arica");
                cbx_Destino.Items.Add("Santiago");
                cbx_Destino.Items.Add("Pto. Montt");
                cbx_Destino.SelectedIndex = 0; //Seleccionar automaticamente el primer item del combobox
            }
            else if (cbx_Origen.SelectedItem.Equals("Pto. Montt"))
            {
                cbx_Destino.Items.Clear();
                cbx_Destino.Items.Add("Concepcion");
                cbx_Destino.Items.Add("Santiago");
                cbx_Destino.Items.Add("Arica");
                cbx_Destino.SelectedIndex = 0; //Seleccionar automaticamente el primer item del combobox
            }
            Ciudades c = new Ciudades();
            c.Origen = cbx_Origen.SelectedItem.ToString();
            c.Destino = cbx_Destino.SelectedItem.ToString();
            precioPasaje = c.CalculoDestino(c.Origen, c.Destino);
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            txt_CantPasajeros.Text = "1";
            precioPasaje = 0;
            precioFinal = 0;
            lbl_TotalPago.Text = "";
            lbl_ValorPasaje.Text = "";
            lbl_CantidadPasajes.Text = "";
        }

        private void txt_CantPasajeros_TextChanged(object sender, EventArgs e)
        {
            if (txt_CantPasajeros.Text == "")
            {
                MessageBox.Show("Ingrese un valor entre 1 y 100");
                txt_CantPasajeros.Text = "1";
            }
            else if (Int64.Parse(txt_CantPasajeros.Text) > 100)
            {
                MessageBox.Show("El valor maximo es 100");
                txt_CantPasajeros.Text = "100";
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (cbx_Origen.Text == "Pto. Montt" && cbx_Destino.Text == "Arica" || cbx_Origen.Text == "Arica" && cbx_Destino.Text == "Pto. Montt")
            {
                //
            }
            else if (txt_CantPasajeros.Text == "")
            {
                MessageBox.Show("Porfavor ingrese cantidad de pasajes a comprar");
            }
            else if (txt_CantPasajeros.Text == "0")
            {
                MessageBox.Show("La cantidad debe ser mayor a 0");
            }
            else
            {
                Ciudades c = new Ciudades();
                c.Origen = cbx_Origen.SelectedItem.ToString();
                c.Destino = cbx_Destino.SelectedItem.ToString();
                precioPasaje = c.CalculoDestino(c.Origen, c.Destino);
                Buses b = new Buses();
                b.Tipo = cbx_TipoBus.SelectedItem.ToString();
                b.PrecioPasaje = precioPasaje;
                precioFinal = b.CalculoBus(b.Tipo, b.PrecioPasaje);
                lbl_ValorPasaje.Visible = true;
                lbl_ValorPasaje.Text = (precioFinal).ToString();
                lbl_CantidadPasajes.Text = txt_CantPasajeros.Text;
                lbl_CantidadPasajes.Visible = true;
                lbl_TotalPago.Visible = true;
                lbl_TotalPago.Text = (precioFinal * Int64.Parse(txt_CantPasajeros.Text)).ToString();
                MessageBox.Show("Origen: " + c.Origen
                    + "\nDestino: " + c.Destino
                    + "\nAsiento: " + b.Tipo
                    + "\nPrecio pasaje normal: $" + precioPasaje
                    + "\nPrecio pasaje + valor asiento: $" + precioFinal
                    + "\nCantidad Pasajes: " + txt_CantPasajeros.Text
                    + "\nTotal a Pagar: $" + lbl_TotalPago.Text);
            }

            if (cbx_Origen.SelectedItem.Equals("Arica"))
            {
                if (cbx_Origen.Text == "Arica" && cbx_Destino.Text == "Pto. Montt")
                {
                    MessageBox.Show("Viajes de Pto. Montt a Arica y viceversa no disponibles");
                }
                else
                {
                    res.totalArica = res.totalArica + Int64.Parse(lbl_TotalPago.Text);
                    res.pasajeArica = res.pasajeArica + Int64.Parse(txt_CantPasajeros.Text);
                }
            }
            else if (cbx_Origen.SelectedItem.Equals("Concepcion"))
            {
                res.totalConce = res.totalConce + Int64.Parse(lbl_TotalPago.Text);
                res.pasajeConce = res.pasajeConce + Int64.Parse(txt_CantPasajeros.Text);
            }
            else if (cbx_Origen.SelectedItem.Equals("Santiago"))
            {
                res.pasajeSantiago = res.pasajeSantiago + Int64.Parse(txt_CantPasajeros.Text);
                res.totalSantiago = res.totalSantiago + Int64.Parse(lbl_TotalPago.Text);
            }
            else if (cbx_Origen.SelectedItem.Equals("Pto. Montt"))
            {
                if (cbx_Origen.Text == "Pto. Montt" && cbx_Destino.Text == "Arica")
                {
                    MessageBox.Show("Viajes de Pto. Montt a Arica y viceversa no disponibles");
                }
                else
                {
                    res.pasajePtoMontt = res.pasajePtoMontt + Int64.Parse(txt_CantPasajeros.Text);
                    res.totalPtoMontt = res.totalPtoMontt + Int64.Parse(lbl_TotalPago.Text);
                }
            }
        }
    }
}
