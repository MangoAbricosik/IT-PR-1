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
  public partial class Form6 : Form
  {
    public Form6()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      button4.Show();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      button2.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      button1.Hide();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      button5.Hide();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      button1.Hide();
    }

    private void Form6_Load(object sender, EventArgs e)
    {
      button2.Hide();
      button4.Hide();
    }
  }
}
