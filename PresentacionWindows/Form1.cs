using LogicaNegocio;
using ModeloDominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionWindows
{
    public partial class Form1 : Form
    {
        private Conversor conversor;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// conversor es un conversor no vacío
        /// </summary>
        /// <param name="c"></param>
        public Form1(Conversor c)
        {
            InitializeComponent();
            this.conversor = c;
        }
        /// <summary>
        /// divisa es no nula
        /// </summary>
        /// <param name="d"></param>
        public void anadirDivisaALista(Divisa d)
        {
            this.ListaDivisaOrigen.Items.Add(d.Nombre);
            this.ListaDivisaDestino.Items.Add(d.Nombre);
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Calcula la conversión si la cantidad es positiva y las divisas existen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            String cantidad = textBoxCantidad.Text;
            double quantity = 0;
            if(double.TryParse(cantidad,out quantity) &&
                this.ListaDivisaDestino.SelectedIndex > -1 &&
                this.ListaDivisaOrigen.SelectedIndex > -1 &&
                this.conversor.ExisteDivisa(this.ListaDivisaOrigen.SelectedItem.ToString()) &&
                this.conversor.ExisteDivisa(this.ListaDivisaDestino.SelectedItem.ToString())){
                double cant = double.Parse(cantidad);
                Divisa divorigen = this.conversor.GetDivisa(this.ListaDivisaOrigen.SelectedItem.ToString());
                Divisa divdestino = this.conversor.GetDivisa(this.ListaDivisaDestino.SelectedItem.ToString());
                this.textBoxResultado.Text = this.conversor.Convertir(divorigen, divdestino, cant).ToString();
            }
            else
            {
                MessageBox.Show("Algún dato no es válido.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// añade la nueva divisa, si no existe ya ni es nula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if(this.textBoxNuevaDivisa.Text != null && !this.conversor.ExisteDivisa(this.textBoxNuevaDivisa.Text))
            {
                Divisa d = new Divisa(this.textBoxNuevaDivisa.Text, 11);
                this.anadirDivisaALista(d);
                this.conversor.AnadirDivisa(d);
            }
            else
            {
                MessageBox.Show("Cuidado, el nombre de la divisa no es el adecuado");
            }
        }
    }
}
