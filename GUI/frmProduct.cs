using Nhom11.Funtion;
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
    public partial class frmProduct : Form
    {
        funcProducts func;
        Thread frmmainnv;

        string name;
        int? authority;


        public frmProduct(string hoten, int? chucvu)
        {
            InitializeComponent();
            func = new funcProducts(this);
            name = hoten;
            authority = chucvu;
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            func.loadFrm();
            txbPriceIn.Text = "0";
            txbQuantity.Text = "0";
        }

        private void frmProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn đóng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.No)
                e.Cancel = true;
        }

        #region check int 
        private void txbQuantity_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(txbQuantity.Text, out float value))
            {
            }
            else
            {
                txbQuantity.Clear();
            }
        }
        private void txbQuantity_Enter(object sender, EventArgs e)
        {
            if(txbQuantity.Text == "0")
            txbQuantity.Clear();
        }
        private void txbQuantity_Leave(object sender, EventArgs e)
        {
            if (txbQuantity.Text == "")
            {
                txbQuantity.Text = "0";
            }
        }

        private void txbPriceIn_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(txbPriceIn.Text, out float value))
            {
            }
            else
            {
                txbPriceIn.Clear();
            }
            func.priceOut();
        }
        private void txbPriceIn_Leave(object sender, EventArgs e)
        {
            if (txbPriceIn.Text == "")
            {
                txbPriceIn.Text = "0";
            }
            func.priceOut();
        }
        private void txbPriceIn_Enter(object sender, EventArgs e)
        {
            if (txbQuantity.Text == "0")
                txbPriceIn.Clear();
            func.priceOut();
        }

        #endregion

        #region click

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            func.cellclick();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            func.clearFrm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbName.Text == "" || txbID.Text == "")
                    throw new Exception("Nhập thiếu Mã hoặc tên");
                else if (txbName.TextLength < 3)
                    throw new Exception("Nhập Tên trên 3 ký tự");
                else if (txbID.TextLength < 2)
                    throw new Exception("Nhập Mã phải 3 ký tự");
                else
                {
                    func.addProduct();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa " + txbName.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
                func.delSP();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mànHìnhChínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmmainnv = new Thread(openMain);
            frmmainnv.SetApartmentState(ApartmentState.STA);
            frmmainnv.Start();

        }

        private void openMain(Object obj)
        {
            Application.Run(new frmMainNV(name, authority));
        }

        #endregion

        #region check text box

        private void txbID_TextChanged(object sender, EventArgs e)
        {
            if (txbID.TextLength > 6)
            {
                txbID.Clear();
                MessageBox.Show("Không nhập mã quá 6 ký tự", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            func.btnEnable();
        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {
            if (txbName.TextLength > 30)
            {
                txbName.Clear();
                MessageBox.Show("Không nhập Tên quá 30 ký tự", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        #region find

        private void tstxbFIndName_Enter(object sender, EventArgs e)
        {
            if (tstxbFIndName.Text == "Theo tên")
            {
                tstxbFIndName.Clear();
            }
        }

        private void tstxbFIndName_TextChanged(object sender, EventArgs e)
        {
            if (tstxbFIndName.Text == "")
                func.loadFrm();
            else
                func.search(tstxbFIndName.Text);
        }

        private void tstxbFIndName_Leave(object sender, EventArgs e)
        {
            if (tstxbFIndName.Text == "")
            {
                tstxbFIndName.Text = "Theo tên";
            }
        }

        private void tlsbbFindType_SelectedIndexChanged(object sender, EventArgs e)
        {
            func.searchType(tlsbbFindType.ComboBox.SelectedValue.ToString());
        }

        private void tscbbFindProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            func.searchProv(tscbbFindProvider.ComboBox.SelectedValue.ToString());
        }

        #endregion

    }
}
