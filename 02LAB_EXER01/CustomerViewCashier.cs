using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02LAB_EXER01
{
    public partial class CustomerViewCashier : Form
    {
        public CustomerViewCashier()
        {
            InitializeComponent();
        }

        private void CustomerViewCashier_Load(object sender, EventArgs e)
        {

        }
        public void setEli(String msg)
        {
            label2.Text = msg;
        }
    }
}
