using BLL;
using DAL.Model;
using Nhom11.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom11.Funtion
{
    public class funcSelling
    {
        frmSelling main;

        private readonly bllBill bllB = new bllBill();
        private readonly bllBillDetail bllBD = new bllBillDetail();

        private readonly bllProduct bllP = new bllProduct();
        private readonly bllType bllT = new bllType();
        private readonly bllProvider bllProv = new bllProvider();
        private readonly bllEmployee bllEm = new bllEmployee();

        Bill bill = new Bill();
        public funcSelling(frmSelling f)
        {
            main = f;
        }


        #region load form

        public void getList(List<BillDetail> list)
        {
            main.dgvProduct.Rows.Clear();

            foreach (var item in list)
            {
                int index = main.dgvProduct.Rows.Add();

                main.dgvProduct.Rows[index].Cells[0].Value = item.BillID;
                main.dgvProduct.Rows[index].Cells[1].Value = item.Product.Name;
                main.dgvProduct.Rows[index].Cells[2].Value = item.Quantity;
                main.dgvProduct.Rows[index].Cells[3].Value = item.PricePerItem;
                main.dgvProduct.Rows[index].Cells[4].Value = item.TotalPricePerItem;
            }
        }

        public void getcbbID(List<Product> list)
        {
            main.cbbID.DataSource = list;
            main.cbbID.DisplayMember = "Name";
            main.cbbID.ValueMember = "ProductID";
        }

        public void getcbbType(List<ProductType> list)
        {
            main.tlsbbFindType.ComboBox.DataSource = list;
            main.tlsbbFindType.ComboBox.DisplayMember = "TypeName";
            main.tlsbbFindType.ComboBox.ValueMember = "TypeID";
        }

        public void getcbbProvider(List<Provider> list)
        {
            main.tscbbFindProvider.ComboBox.DataSource = list;
            main.tscbbFindProvider.ComboBox.DisplayMember = "ProviderName";
            main.tscbbFindProvider.ComboBox.ValueMember = "ProviderID";
        }

        public void clearFrm()
        {
            main.tstxbFIndName.Clear();
            main.txbBill.Clear();
            main.txbQuantity.Clear();

            btnEnable();
        }

        public void priceOut()
        {
            ProductModel model = new ProductModel();
            if (main.cbbID.SelectedItem == null || main.cbbID.SelectedValue == null)
            {
                main.txbPriceOut.Text = "0";
            }
            else
            {
                Product p = bllP.findID(main.cbbID.SelectedValue.ToString(), model);
                if (p != null && p.PriceOut != null)
                {
                    main.txbPriceOut.Text = p.PriceOut.ToString();
                }
                else
                {
                    // Xử lý khi giá trị không hợp lệ
                    // Ở đây bạn có thể đặt một giá trị mặc định hoặc hiển thị một thông báo lỗi
                }
            }
        }

        public void priceTotal()
        {
            if (main.txbPriceOut.Text == "0" || main.txbQuantity.Text == "0" || main.txbQuantity.Text == "")
            {
                main.txbTotalPrice.Text = "0";
            }
            else
            {
                if (int.TryParse(main.txbPriceOut.Text, out int price) && int.TryParse(main.txbQuantity.Text, out int quantity))
                {
                    main.txbTotalPrice.Text = (price * quantity).ToString();
                }
                else
                {
                    // Xử lý khi chuỗi không hợp lệ
                    // Ở đây bạn có thể gán một giá trị mặc định hoặc thông báo lỗi
                }
            }
        }

        public void loadFrm()
        {
            var listP = bllP.GetList();
            var listT = bllT.GetAll();
            var listProv = bllProv.GetAll();

            getcbbType(listT);
            getcbbProvider(listProv);
            getcbbID(listP);

            //priceOut();
            //priceTotal();

            main.txbQuantity.Text = "0";
            main.cbbID.SelectedIndex = 0;
            main.txbTotalPayment.Text = "0";

            btnEnable();
        }

        public void btnEnable()
        {
            ProductModel ctx = new ProductModel();
            if (main.txbBill.Text == "")
            {
                main.btnAdd.Enabled = false;
                main.btnUpd.Enabled = false;
                main.btnDel.Enabled = false;
            }
            else if (main.txbQuantity.Text == "" || main.txbQuantity.Text == "0")
            {
                main.btnDel.Enabled = true;
            }
            else if (bllBD.findID(main.cbbID.SelectedValue.ToString(), ctx) == null)
            {
                main.btnAdd.Enabled = true;
                main.btnUpd.Enabled = false;
                main.btnDel.Enabled = false;
            }
            else if (bllBD.findID(main.cbbID.SelectedValue.ToString(), ctx) != null)
            {
                main.btnAdd.Enabled = false;
                main.btnUpd.Enabled = true;
                main.btnDel.Enabled = true;
            }
        }

        public void cellclick()
        {
            if (main.dgvProduct.CurrentRow.Index == main.dgvProduct.RowCount - 1)
            {
                clearFrm();
            }
            else
            {
                ProductModel ctx = new ProductModel();
                var timkiem = bllP.findID(main.dgvProduct.CurrentRow.Cells[0].Value.ToString(), ctx);

                main.txbBill.Text = main.dgvProduct.CurrentRow.Cells[0].Value.ToString();
                main.cbbID.Text = main.dgvProduct.CurrentRow.Cells[1].Value.ToString();
                main.txbQuantity.Text = main.dgvProduct.CurrentRow.Cells[2].Value.ToString();
                priceOut();
                priceTotal();
            }
        }

        public void checkBill(string id)
        {
            bill.BillID = id;
        }

        #endregion

        #region add upd del

        public void addProduct()
        {
            ProductModel ctx = new ProductModel();
            BillDetail p = new BillDetail();

            bill.BillID = main.txbBill.Text.ToString();

            p.BillID = main.txbBill.Text.ToString();
            p.ProductID = main.cbbID.SelectedValue.ToString();
            if (int.TryParse(main.txbQuantity.Text, out int quantity))
            {
                p.Quantity = quantity;
            }
            if (int.TryParse(main.txbPriceOut.Text, out int priceout))
            {
                p.PricePerItem = priceout;
            }
            if (int.TryParse(main.txbTotalPrice.Text, out int pricein))
            {
                p.TotalPricePerItem = pricein;
            }

            if (bllP.findID(main.cbbID.SelectedValue.ToString(), ctx) != null)
            {
                bllBD.Add(p, ctx);
                MessageBox.Show("Cập nhật thành công", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                bllBD.Add(p, ctx);
                MessageBox.Show("Thêm thành công", "THÔNG BÁO", MessageBoxButtons.OK);
            }

            loadFrm();
        }

        public void payment(string employee)
        {
            ProductModel ctx = new ProductModel();

            bill.BillID = main.txbBill.Text.ToString();
            bill.Date = DateTime.Now;

            Employee e = bllEm.findName(employee, ctx);
            bill.EmployeeID = e.EmployeeID;

            if (int.TryParse(main.txbTotalPayment.Text, out int total))
            {
                bill.TotalPayment = total;
            }

            if (bllB.findID(main.cbbID.SelectedValue.ToString(), ctx) != null)
            {
                bllB.Add(bill, ctx);
                MessageBox.Show("Cập nhật hóa đơn thành công", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                bllB.Add(bill, ctx);
                MessageBox.Show("Thanh toán thành công", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }

        #endregion
    }
}
