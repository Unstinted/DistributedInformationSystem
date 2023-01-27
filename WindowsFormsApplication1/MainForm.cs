using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        NewDiscount formDiscount;

        public Form1()
        {
            InitializeComponent();
        }

        private void newDiscountMenuItem_Click(object sender, EventArgs e)
        {
            if (formDiscount == null || formDiscount.IsDisposed)
            {
                formDiscount = new NewDiscount();
            }
            formDiscount.IsMdiContainer = true;
            formDiscount.MdiParent = this;
            formDiscount.Show();



        }
    }
}
