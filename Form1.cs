using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompraOnline
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string nombre = textBox1.Text;
      Cliente cliente1 = new Cliente(nombre);
      double total = double.Parse(textBox2.Text);
      Compra compra1 = new Compra(cliente1, total);

      label3.Text = compra1.ProcesarPago();

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }
  }
}
