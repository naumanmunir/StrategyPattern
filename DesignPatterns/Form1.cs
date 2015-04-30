using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatterns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Duck mallard = new MallardDuck();

            
            mallard.PerformFly();
            //textBox1.Text = mallard.PerformQuack();
            textBox1.AppendText(Convert.ToString(mallard.PerformQuack()).ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
