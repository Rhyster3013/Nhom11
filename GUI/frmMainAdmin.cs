using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Nhom11.GUI
{
    public partial class frmMainAdmin : Form
    {
        string name = "";
        public frmMainAdmin(string name)
        {
            InitializeComponent();
            this.Load += frmMainAdmin_Load;
            this.name = name;
        }

        private void frmMainAdmin_Load(object sender, EventArgs e)
        {
            txbWelcome.Text = name;
        }
    }
}
