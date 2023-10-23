using BLL;
using Nhom11.GUI;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

namespace Nhom11.Funtion
{
    public class funcProducts
    {
        frmProduct main;

        private readonly bllProduct bllP = new bllProduct();
        private readonly bllType bllT = new bllType();
        private readonly bllProvider bllProv = new bllProvider();

        public funcProducts(frmProduct f)
        {
            main = f;
        }

        #region load form

        public void getList(List<Product> list)
        {
            main.dgvProduct.Rows.Clear();

            foreach (var item in list)
            {
                int index = main.dgvProduct.Rows.Add();

                main.dgvProduct.Rows[index].Cells[0].Value = item.ProductID;
                main.dgvProduct.Rows[index].Cells[1].Value = item.Name;
                main.dgvProduct.Rows[index].Cells[2].Value = item.ProductType.TypeName;
                main.dgvProduct.Rows[index].Cells[3].Value = item.Provider.ProviderName;
                main.dgvProduct.Rows[index].Cells[4].Value = item.Date;
                main.dgvProduct.Rows[index].Cells[5].Value = item.PriceIn;
                main.dgvProduct.Rows[index].Cells[6].Value = item.PriceOut;
                main.dgvProduct.Rows[index].Cells[7].Value = item.Quantity;
            }
        }

        public void getcbbType(List<ProductType> list)
        {
            main.cbbType.DataSource = list;
            main.cbbType.DisplayMember = "TypeName";
            main.cbbType.ValueMember = "TypeID";

            main.tlsbbFindType.ComboBox.DataSource = list;
            main.tlsbbFindType.ComboBox.DisplayMember = "TypeName";
            main.tlsbbFindType.ComboBox.ValueMember = "TypeID";
        }

        public void getcbbProvider(List<Provider> list)
        {
            main.cbbProvider.DataSource = list;
            main.cbbProvider.DisplayMember = "ProviderName";
            main.cbbProvider.ValueMember = "ProviderID";

            main.tscbbFindProvider.ComboBox.DataSource = list;
            main.tscbbFindProvider.ComboBox.DisplayMember = "ProviderName";
            main.tscbbFindProvider.ComboBox.ValueMember = "ProviderID";
        }

        public void clearFrm()
        {
            main.tstxbFIndName.Clear();
            main.txbID.Clear();
            main.txbName.Clear();
            main.txbPriceIn.Clear();
            main.txbPriveOut.Clear();
            main.txbQuantity.Clear();

            btnEnable();
        }

        public void priceOut()
        {
            if (!string.IsNullOrEmpty(main.txbPriceIn.Text))
            {
                if (int.TryParse(main.txbPriceIn.Text, out int result))
                {
                    main.txbPriveOut.Text = (result*2).ToString();
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

            getList(listP);
            priceOut();

            btnEnable();
        }

        public void btnEnable()
        {
            ProductModel ctx = new ProductModel();
            if (main.txbID.Text == "" || main.txbName.Text == "" || main.txbPriceIn.Text == "" || main.txbQuantity.Text == "")
            {
                main.btnAdd.Enabled = false;
                main.btnDel.Enabled = false;
                main.btnUpd.Enabled = false;
            }
            else if (bllP.findID(main.txbID.Text, ctx) == null )
            {
                main.btnAdd.Enabled = true;
                main.btnUpd.Enabled = false;
                main.btnDel.Enabled = false;
            }
            else if (bllP.findID(main.txbID.Text, ctx) != null)
            {
                main.btnAdd.Enabled = false;
                main.btnUpd.Enabled = true;
                main.btnDel.Enabled = true;
            }
        }

        #endregion

        #region click

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

                main.txbID.Text = main.dgvProduct.CurrentRow.Cells[0].Value.ToString();
                main.txbName.Text = main.dgvProduct.CurrentRow.Cells[1].Value.ToString();
                main.cbbType.Text = main.dgvProduct.CurrentRow.Cells[2].Value.ToString();
                main.cbbProvider.Text = main.dgvProduct.CurrentRow.Cells[3].Value.ToString();
                main.txbPriceIn.Text = main.dgvProduct.CurrentRow.Cells[5].Value.ToString();
                priceOut();
                main.txbQuantity.Text = main.dgvProduct.CurrentRow.Cells[7].Value.ToString();
            }
        }

        public void addProduct()
        {
            ProductModel ctx = new ProductModel();
            Product p = new Product();

            p.ProductID = main.txbID.Text.ToString();
            p.Name = main.txbName.Text.ToString();
            p.TypeID = main.cbbType.SelectedValue.ToString();
            p.ProviderID = main.cbbProvider.SelectedValue.ToString();
            p.Date = DateTime.Now;
            if (int.TryParse(main.txbPriceIn.Text, out int pricein))
            {
                p.PriceIn = pricein;
            }
            if (int.TryParse(main.txbPriveOut.Text, out int priceout))
            {
                p.PriceOut = priceout;
            }
            if (int.TryParse(main.txbQuantity.Text, out int quantity))
            {
                p.Quantity = quantity;
            }

            if (bllP.findID(main.txbID.Text, ctx) != null)
            {
                bllP.Add(p, ctx);
                MessageBox.Show("Cập nhật thành công", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                bllP.Add(p, ctx);
                MessageBox.Show("Thêm thành công", "THÔNG BÁO", MessageBoxButtons.OK);
            }

            loadFrm();
        }

        public void search(string s)
        {
            ProductModel model = new ProductModel();

            var listSearch = bllP.findName(s, model);
            getList(listSearch);
        }

        public void searchType(string s)
        {
            ProductModel model = new ProductModel();

            var listSearch = bllP.findType(s, model);
            getList(listSearch);
        }

        public void searchProv(string s)
        {
            ProductModel model = new ProductModel();

            var listSearch = bllP.findProv(s, model);
            getList(listSearch);
        }

        public void delSP()
        {
            ProductModel ctx = new ProductModel();
            Product s = bllP.findID(main.txbID.Text, ctx);
            if (s != null)
            {
                bllP.Del(s, ctx);
                MessageBox.Show("Đã xóa sản phẩm");
                loadFrm();
            }
            else
            {
                MessageBox.Show("Sản phẩm cần xóa không tồn tại");
            }
        }


        #endregion
    }
}
