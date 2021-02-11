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
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      BackColor = Color.Aquamarine;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      BackColor = Color.Brown;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      BackColor = Color.DarkOrange;
    }

    private void button4_Click(object sender, EventArgs e)
    {
      BackColor = Color.DarkViolet;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      BackColor = Color.LightGoldenrodYellow;
    }
  }
}
