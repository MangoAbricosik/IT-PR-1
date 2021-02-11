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
  public partial class Form11 : Form
  {
    public Form11()
    {
      InitializeComponent();
    }

    private void textBox1_Click(object sender, EventArgs e)
    {
      textBox1.Text = "Окно номер 1";
    } 
    private void Form11_Resize(object sender, EventArgs e)
    {
      textBox1.Text = "";
      textBox2.Text = "";
      textBox3.Text = "";
      textBox4.Text = "";
    }

    private void textBox2_Click(object sender, EventArgs e)
    {
      textBox2.Text = "Окно номер 2";
    }

    private void textBox3_Click(object sender, EventArgs e)
    {
      textBox3.Text = "Окно номер 3";
    }

    private void textBox4_Click(object sender, EventArgs e)
    {
      textBox4.Text = "Окно номер 4";
    }
  }
}
