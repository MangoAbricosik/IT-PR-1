using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS
{
  public partial class Form12 : Form
  {
    public Form12()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      label1.Text = textBox1.Text;
    }

    private void Form12_Click(object sender, EventArgs e)
    {
      label1.Text = "Начало работы";
      textBox1.Text = "";
      BackColor = Color.Peru;
    }
  }
}
