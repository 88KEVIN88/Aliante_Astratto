using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aliante_Astratto
{
    public partial class Form1 : Form
    {
        public Aliante aliante;
        public Form1()
        {
            InitializeComponent();
            aliante = new Aliante();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (aliante.Componenti.Count < 1)
            {
                MessageBox.Show("Inserire almeno un elemento per poter ottenere i costi.");
                return;
            }

            listView1.Items.Add($"Il prezzo dei componenti sommato è: {aliante.Price()}");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Add(aliante.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(textBox11.Text, out int index) || index < 0 || textBox11.Text == "0" || String.IsNullOrEmpty(textBox11.Text) || index - 1 > aliante.Componenti.Count)
            {
                MessageBox.Show("Inserire un indice valido.");
                return;
            }

            aliante.Remove(index - 1);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Fusoliera fusoliera = new Fusoliera(double.Parse(textBox1.Text), textBox2.Text);
            aliante.Add(fusoliera);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Ala ala = new Ala(double.Parse(textBox3.Text), double.Parse(textBox4.Text));
            aliante.Add(ala);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Coda coda = new Coda(double.Parse(textBox5.Text));
            aliante.Add(coda);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Cerchione cerchione = new Cerchione(double.Parse(textBox6.Text), textBox7.Text);
            Gomma gomma = new Gomma(double.Parse(textBox8.Text), double.Parse(textBox9.Text), double.Parse(textBox10.Text));
            Ruota ruota = new Ruota(cerchione, gomma);
            aliante.Add(ruota);
        }
    }
}
