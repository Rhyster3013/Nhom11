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
using System.Xml.Linq;

namespace Nhom11.GUI
{
    public partial class frmSelling : Form
    {
        funcSelling func;
        Thread frmmainnv;

        string name;
        int? authority;

        #region form load

        public frmSelling(string hoten, int? chucvu)
        {
            InitializeComponent();
            func = new funcSelling(this);
            name = hoten;
            authority = chucvu;
        }

        private void frmSelling_Load(object sender, EventArgs e)
        {
            func.loadFrm();
        }

        private void frmSelling_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn đóng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.No)
                e.Cancel = true;
        }

        private void cbbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            func.priceOut();
            func.priceTotal();
            func.btnEnable();
        }

        private void txbBill_TextChanged(object sender, EventArgs e)
        {
            func.btnEnable();
            func.checkBill(txbBill.Text.ToString());
        }
        #endregion


        #region check int 

        private void txbQuantity_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(txbQuantity.Text, out float value))
            {
                func.priceTotal();
                func.btnEnable();
            }
            else
            {
                txbQuantity.Clear();
            }
        }
        private void txbQuantity_Enter(object sender, EventArgs e)
        {
            if (txbQuantity.Text == "0")
                txbQuantity.Clear();
        }
        private void txbQuantity_Leave(object sender, EventArgs e)
        {
            if (txbQuantity.Text == "")
            {
                txbQuantity.Text = "0";
            }
        }

        #endregion

        #region button click

        #endregion

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

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbBill.Text == "" || txbQuantity.Text == "")
                throw new Exception("Nhập thiếu Mã hoặc Số lượng");
            else if (txbBill.TextLength < 2)
                throw new Exception("Nhập Mã phải 3 ký tự");
            else
            {
                func.addProduct();
            }
            //try
            //{
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProduct.RowCount == 1)
                    throw new Exception("Hóa đơn chưa có sản phẩm");
                else
                {
                    func.payment(name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
