using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatiiTVA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            //calcul pret cu tva , tva si coeficient tva
            calcul c = new calcul();
            c.pret = 200.0f;
            c.cotatva = 19.0f;
            c.calcularetva(c.pret, c.cotatva);
            c.calcularepretcutva(c.pret, c.tva);
            c.calculcoeficienttva(c.cotatva);
            c.calcultvadinpretcutva(c.pretcutva, c.coeficienttva);
            this.textBox1.Text += "\r\n calculare tva \r\n";
            this.textBox1.Text += "pret = "+ c.pret;
            this.textBox1.Text += "\r\n";
            this.textBox1.Text += "cota tva % = " + c.cotatva;
            this.textBox1.Text += "\r\n";
            this.textBox1.Text += "tva  = " + c.tva;
            this.textBox1.Text += "\r\n";
            this.textBox1.Text += "pret cu tva  = " + c.pretcutva;
            this.textBox1.Text += "\r\n";
            this.textBox1.Text += "coeficient tva = " + c.coeficienttva;
            this.textBox1.Text += "\r\n";
            this.textBox1.Text += "tva din pret cu tva = " + c.tvadinpretcutva;
            this.textBox1.Text += "\r\n";
          
            
            //calcul extragere tva din tva cu pret
            calcul d = new calcul();
            d.cotatva = 19.0f;
            d.pretcutva = 238.0f;
            d.calculcoeficienttva(d.cotatva);
            d.calcultvadinpretcutva(d.pretcutva, d.coeficienttva);
            this.textBox2.Text += "\r\n calculare extragere tva din tv a + pret \r\n";
            this.textBox2.Text += "cota tva % = " + d.cotatva;
            this.textBox2.Text += "\r\n";
            this.textBox2.Text += "pret cu tva = " + d.pretcutva;
            this.textBox2.Text += "\r\n";
            this.textBox2.Text += "coeficient tva = " +d.coeficienttva;
            this.textBox2.Text += "\r\n";
            this.textBox2.Text += "tva din pret cu tva = " + d.tvadinpretcutva;
            this.textBox2.Text += "\r\n";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //calcul pret cu tva , tva si coeficient tva
            calcul a = new calcul();
            a.pret = (float)Convert.ToDouble(txtpretA.Text);
            a.cotatva = (float)Convert.ToDouble(txtcotatvaA.Text); 
            a.calcularetva(a.pret, a.cotatva);
            a.calcularepretcutva(a.pret, a.tva);
            a.calculcoeficienttva(a.cotatva);
            a.calcultvadinpretcutva(a.pretcutva, a.coeficienttva);
            txttvaA.Text = a.tva.ToString();
            txtpretcutvaA.Text = a.pretcutva.ToString();
            txtcoeftvaA.Text = a.coeficienttva.ToString();
            tvadinpretcutvaA.Text = a.tvadinpretcutva.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //calcul extragere tva din tva cu pret
            calcul b = new calcul();
            b.cotatva = (float)Convert.ToDouble(txtcotatvaB.Text);
            b.pretcutva = (float)Convert.ToDouble(txtpretcutvaB.Text);
            b.calculcoeficienttva(b.cotatva);
            b.calcultvadinpretcutva(b.pretcutva, b.coeficienttva);
            txtcoeftvaB.Text = b.coeficienttva.ToString();
            tvadinpretcutvaB.Text = b.tvadinpretcutva.ToString();
        }
    }
}
