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
  public partial class Form7 : Form
  {
    public Form7()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      label3.Hide();
      label4.Hide();
      label2.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      label1.Hide();
      label2.Hide();
      label4.Show();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      label1.Show();
      label2.Show();
      label3.Hide();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      label2.Hide();
      label4.Hide();
    }
  }
}
