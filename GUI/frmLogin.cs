using DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Nhom11.GUI
{
    public partial class frmLogin : Form
    {
        ProductModel context;
        public frmLogin()
        {
            InitializeComponent();
            context = new ProductModel();
            this.Load += frmLogin_Load;
        }

        #region form load


        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txbName_Enter(object sender, EventArgs e)
        {
            if (txbName.Text == "Tên tài khoản")
            {
                txbName.Clear();
            }
        }

        private void txbPassword_Enter(object sender, EventArgs e)
        {
            if (txbPassword.Text == "Mật khẩu")
            {
                txbPassword.Clear();
                if (ckbShowPass.Checked == true)
                    txbPassword.PasswordChar = '\0';
                else
                    txbPassword.PasswordChar = '*';

            }
        }

        private void txbName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbName.Text))
            {
                txbName.Text = "Tên tài khoản";
            }
        }

        private void txbPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbPassword.Text))
            {
                txbPassword.Text = "Mật khẩu";
                txbPassword.PasswordChar = '\0'; // Trở về kiểu hiển thị văn bản bình thường
            }
        }

        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbShowPass.Checked == true || txbPassword.Text == "Mật khẩu")
                txbPassword.PasswordChar = '\0'; // Trở về kiểu hiển thị văn bản bình thường
            else if (ckbShowPass.Checked == false)
                txbPassword.PasswordChar = '*';
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else if (result == DialogResult.No)
            { e.Cancel = true; }
        }


        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string tendangnhap = txbName.Text;
            string matkhau = txbPassword.Text;
            Account kiemtratk = context.Accounts.SingleOrDefault(kt => kt.AccountName == tendangnhap);
            if (kiemtratk == null)//Trường hợp không tìm thấy tài khoản
            {
                errCheckInput.SetError(txbName, "Không tìm thấy tài khoản!");
                DialogResult ketQua = MessageBox.Show("Vui lòng kiểm tra tên đăng nhập!", "Thông báo", MessageBoxButtons.OK);
                if (ketQua == DialogResult.OK)
                    errCheckInput.Clear();
                txbName.Text = txbPassword.Text = "";
            }
            else if (tendangnhap != kiemtratk.AccountName)//Trường hợp nhập sai tên đăng nhập
            {
                errCheckInput.SetError(txbName, "Không tìm thấy tài khoản!");
                DialogResult ketQua = MessageBox.Show("Vui lòng kiểm tra tên đăng nhập!", "Thông báo", MessageBoxButtons.OK);
                if (ketQua == DialogResult.OK)
                    errCheckInput.Clear();
                txbName.Text = txbPassword.Text = "";
            }
            else
            {
                if (matkhau == kiemtratk.Password)//Trường hợp đúng thông tin đăng nhập 
                {
                    if (kiemtratk.Authority == 1)
                    {
                        MessageBox.Show("Đăng nhập thành công!\n\nChào mừng " + kiemtratk.Employee.Name, "Thông báo", MessageBoxButtons.OK);
                        frmMainAdmin ne = new frmMainAdmin(kiemtratk.Employee.Name);
                        this.Hide();
                        ne.ShowDialog();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thành công!\n\nChào mừng " + kiemtratk.Employee.Name, "Thông báo", MessageBoxButtons.OK);
                        frmMainNV ne = new frmMainNV(kiemtratk.Employee.Name, kiemtratk.Authority);
                        this.Hide();
                        ne.ShowDialog();
                        this.Dispose();
                    }
                }
                else//Trường hợp sai mật khẩu
                {
                    errCheckInput.SetError(txbPassword, "Mật khẩu không đúng!");
                    DialogResult ketQua = MessageBox.Show("Vui lòng kiểm tra mật khẩu!", "Thông báo", MessageBoxButtons.OK);
                    if (ketQua == DialogResult.OK)
                        errCheckInput.Clear();
                    txbPassword.Text = "";
                }

            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.Handled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Tên đăng nhập không được chứa khoảng trắng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = txbName.Text != "Tên tài khoản" 
                            && txbPassword.Text != "Mật khẩu";      
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = txbName.Text != "Tên tài khoản"
                            && txbPassword.Text != "Mật khẩu";
        }
    }
}
