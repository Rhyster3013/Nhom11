using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom11.GUI
{
    public partial class frmMainNV : Form
    {
        Thread frmmainnv;

        string name = "";
        int? authority = 0;

        public frmMainNV(string name, int? authority)
        {
            InitializeComponent();
            this.Load += frmMainNV_Load;
            this.name = name;
            this.authority = authority;
        }

        private void frmMainNV_Load(object sender, EventArgs e)
        {
            txbName.Text = name;
            if(authority == 2)
            {
                txbJob.Text = "Thu ngân";
            }
            if (authority == 3)
            {
                txbJob.Text = "Kế toán";
            }
        }

        // Mở form bán hàng Selling
        private void bánHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmmainnv = new Thread(openfrmSelling);
            frmmainnv.SetApartmentState(ApartmentState.STA);
            frmmainnv.Start();
        }
        private void openfrmSelling(Object obj)
        {
            Application.Run(new frmSelling(name, authority));
        }

        //Mở form Product
        private void linhKiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmmainnv = new Thread(openfrmProduct);
            frmmainnv.SetApartmentState(ApartmentState.STA);
            frmmainnv.Start();
        }
        private void openfrmProduct(Object obj)
        {
            Application.Run(new frmProduct(name, authority));
        }
    }
}
