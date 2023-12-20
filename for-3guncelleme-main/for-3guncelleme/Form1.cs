using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_3guncelleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lbSayilar.Items.Clear();

            int baslangıc =Convert.ToInt32(txtSayi1.Text);
            int bitis = Convert.ToInt32(txtSayi2.Text);

            for(int i = baslangıc; i <= bitis; i++)
            {
                lbSayilar.Items.Add(i);
            }
        }
    }
}
