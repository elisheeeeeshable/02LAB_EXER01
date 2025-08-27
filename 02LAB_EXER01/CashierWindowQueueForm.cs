using System;
using System.Collections;
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
    public partial class CashierWindowQueueForm: Form
    {
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public CustomerViewCashier view;
        public CashierWindowQueueForm()
        {
            view = new CustomerViewCashier();
            InitializeComponent();
            listCashierQueue.View = View.List;
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;
            timer.Start();
        }
        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                var msg = CashierClass.CashierQueue.Dequeue();
                DisplayCashierQueue(CashierClass.CashierQueue);
                view.setEli(msg);
                view.Show();
                
            }
            else
            {
                MessageBox.Show("No more students in queue!");
            }
        }
    }
}
