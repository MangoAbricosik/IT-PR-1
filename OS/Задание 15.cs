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
  public partial class Form15 : Form
  {
    public Form15()
    {
      InitializeComponent();
    }
    int qew, qwer;

    private void button2_Click(object sender, EventArgs e)
    {
      button1.Location = new Point(300, 100);
      button1.Size = new Size(300, 50);
    }

    private void button3_Click(object sender, EventArgs e)
    {
      button2.Location = new Point(200, 400);
      button2.Size = new Size(50, 50);
    }

    private void button4_Click(object sender, EventArgs e)
    {
      button3.Location = new Point(50, 50);
      button3.Size = new Size(500, 300);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      button4.Location = new Point(300,150);
      button4.Size = new Size(100,100);
    }
  }
}
