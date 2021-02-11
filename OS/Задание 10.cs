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
  public partial class Form10 : Form
  {
    public Form10()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      textBox1.Text = "*****";
    }

    private void button2_Click(object sender, EventArgs e)
    {
      textBox1.Text = "+++++";
    }

    private void button3_Click(object sender, EventArgs e)
    {
      textBox1.Text = "00000";
    }

    private void Form10_Load(object sender, EventArgs e)
    {
      textBox1.Text = "Готов к работе";
      BackColor = Color.Sienna;
    }
  }
}
