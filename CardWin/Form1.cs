using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntrans_Click(object sender, EventArgs e)
        {
            int no = int.Parse(txtcard.Text);
            int cv = int.Parse(txtccv.Text);
            double amt = double.Parse(txtamt.Text);

            try
            {
                ServiceReference1.CardClient cc = new ServiceReference1.CardClient();
                var c = cc.Authenticate(no, cv);
                var d = cc.DateCheck(no, DateTime.Now);
                var f = cc.Trans(no, amt);
                if (c == true && d == true)
                {

                    MessageBox.Show("Your Balance = " + f);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
