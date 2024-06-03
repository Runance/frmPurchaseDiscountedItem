using Itemnamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace frmPurchaseDiscountedItem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DiscountedItem cs;
        private void button1_Click(object sender, EventArgs e)
        {
            cs = new DiscountedItem(textBox1.Text, Convert.ToDouble(textBox3.Text), Convert.ToInt16(textBox4.Text), Convert.ToDouble(textBox2.Text));
            label5.Text = cs.getTotalPrice().ToString();

        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            cs.setPayment(Convert.ToDouble(textBox5.Text));
            label7.Text = cs.getChange().ToString();
        }
    }
    
}
