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
  public partial class Form14 : Form
  {
    public Form14()
    {
      InitializeComponent();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      button3.Text = "1";
    }

    private void button6_Click(object sender, EventArgs e)
    {
      button6.Text = "Мина!";
      BackColor = Color.Red;
    }

    private void button9_Click(object sender, EventArgs e)
    {
      button9.Text = "1";
    }

    private void button2_Click(object sender, EventArgs e)
    {
      button2.Text = "1";
    }

    private void button5_Click(object sender, EventArgs e)
    {
      button5.Text = "1";
    }

    private void button8_Click(object sender, EventArgs e)
    {
      button8.Text = "1";
    }

    private void button1_Click(object sender, EventArgs e)
    {
      button1.Text = "Мина!";
      BackColor = Color.Red;
    }

    private void button4_Click(object sender, EventArgs e)
    {
      button4.Text = "1";
    }

    private void button7_Click(object sender, EventArgs e)
    {
      button7.Text = "0";
    }
  }
}
