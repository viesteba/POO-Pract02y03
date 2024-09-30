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
        public Form1(Conversor c)
        {
            InitializeComponent();
            this.conversor = c;
        }
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
    }
}
