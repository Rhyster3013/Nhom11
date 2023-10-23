namespace Nhom11.GUI
{
    partial class frmSelling
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelling));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbID = new System.Windows.Forms.ComboBox();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsmMain = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mànHìnhChínhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tstxbFIndName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tlsbbFindType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tscbbFindProvider = new System.Windows.Forms.ToolStripComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txbPriceOut = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbTotalPayment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txbEmployee = new System.Windows.Forms.TextBox();
            this.txbBill = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.tsmMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 62);
            this.label2.TabIndex = 4;
            this.label2.Text = "HÓA ĐƠN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(25, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên linh kiện:";
            // 
            // txbQuantity
            // 
            this.txbQuantity.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbQuantity.Location = new System.Drawing.Point(804, 167);
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Size = new System.Drawing.Size(234, 34);
            this.txbQuantity.TabIndex = 3;
            this.txbQuantity.TextChanged += new System.EventHandler(this.txbQuantity_TextChanged);
            this.txbQuantity.Enter += new System.EventHandler(this.txbQuantity_Enter);
            this.txbQuantity.Leave += new System.EventHandler(this.txbQuantity_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(664, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số lượng:";
            // 
            // cbbID
            // 
            this.cbbID.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbID.FormattingEnabled = true;
            this.cbbID.Location = new System.Drawing.Point(227, 169);
            this.cbbID.Name = "cbbID";
            this.cbbID.Size = new System.Drawing.Size(359, 34);
            this.cbbID.TabIndex = 2;
            this.cbbID.SelectedIndexChanged += new System.EventHandler(this.cbbID_SelectedIndexChanged);
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbTotalPrice.Location = new System.Drawing.Point(1373, 174);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(221, 34);
            this.txbTotalPrice.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(1240, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 27);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tổng giá:";
            // 
            // dgvProduct
            // 
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column2,
            this.Column8,
            this.Column7,
            this.Column1});
            this.dgvProduct.Location = new System.Drawing.Point(30, 351);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(1001, 392);
            this.dgvProduct.TabIndex = 23;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã Hóa đơn";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 400;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Số lượng";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Giá bán";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tổng giá";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // tsmMain
            // 
            this.tsmMain.BackColor = System.Drawing.Color.LightCoral;
            this.tsmMain.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsmMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsmMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.tstxbFIndName,
            this.toolStripLabel3,
            this.tlsbbFindType,
            this.toolStripLabel1,
            this.tscbbFindProvider});
            this.tsmMain.Location = new System.Drawing.Point(0, 0);
            this.tsmMain.Name = "tsmMain";
            this.tsmMain.Size = new System.Drawing.Size(1637, 45);
            this.tsmMain.TabIndex = 24;
            this.tsmMain.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mànHìnhChínhToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(192, 42);
            this.toolStripDropDownButton1.Text = "Chức năng";
            // 
            // mànHìnhChínhToolStripMenuItem
            // 
            this.mànHìnhChínhToolStripMenuItem.Name = "mànHìnhChínhToolStripMenuItem";
            this.mànHìnhChínhToolStripMenuItem.Size = new System.Drawing.Size(331, 42);
            this.mànHìnhChínhToolStripMenuItem.Text = "Màn hình chính";
            this.mànHìnhChínhToolStripMenuItem.Click += new System.EventHandler(this.mànHìnhChínhToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(331, 42);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(159, 42);
            this.toolStripLabel2.Text = "Tìm kiếm:";
            // 
            // tstxbFIndName
            // 
            this.tstxbFIndName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tstxbFIndName.Name = "tstxbFIndName";
            this.tstxbFIndName.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tstxbFIndName.Size = new System.Drawing.Size(230, 45);
            this.tstxbFIndName.Text = "Theo tên";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.toolStripLabel3.Size = new System.Drawing.Size(176, 42);
            this.toolStripLabel3.Text = "Theo loại:";
            // 
            // tlsbbFindType
            // 
            this.tlsbbFindType.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tlsbbFindType.Name = "tlsbbFindType";
            this.tlsbbFindType.Size = new System.Drawing.Size(250, 45);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.toolStripLabel1.Size = new System.Drawing.Size(199, 42);
            this.toolStripLabel1.Text = "Theo hãng:";
            // 
            // tscbbFindProvider
            // 
            this.tscbbFindProvider.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tscbbFindProvider.Name = "tscbbFindProvider";
            this.tscbbFindProvider.Size = new System.Drawing.Size(250, 45);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Aquamarine;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(78, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(210, 56);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "THÊM";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpd
            // 
            this.btnUpd.BackColor = System.Drawing.Color.SkyBlue;
            this.btnUpd.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpd.Image = ((System.Drawing.Image)(resources.GetObject("btnUpd.Image")));
            this.btnUpd.Location = new System.Drawing.Point(500, 280);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpd.Size = new System.Drawing.Size(210, 56);
            this.btnUpd.TabIndex = 26;
            this.btnUpd.Text = "SỬA";
            this.btnUpd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpd.UseVisualStyleBackColor = false;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Tomato;
            this.btnDel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.Location = new System.Drawing.Point(903, 280);
            this.btnDel.Name = "btnDel";
            this.btnDel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDel.Size = new System.Drawing.Size(210, 56);
            this.btnDel.TabIndex = 27;
            this.btnDel.Text = "XÓA";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(1380, 280);
            this.btnClear.Name = "btnClear";
            this.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClear.Size = new System.Drawing.Size(214, 56);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "LÀM MỚI";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // txbPriceOut
            // 
            this.txbPriceOut.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbPriceOut.Location = new System.Drawing.Point(227, 236);
            this.txbPriceOut.Name = "txbPriceOut";
            this.txbPriceOut.ReadOnly = true;
            this.txbPriceOut.Size = new System.Drawing.Size(234, 34);
            this.txbPriceOut.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(86, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 27);
            this.label7.TabIndex = 29;
            this.label7.Text = "Giá bán:";
            // 
            // txbTotalPayment
            // 
            this.txbTotalPayment.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbTotalPayment.Location = new System.Drawing.Point(39, 106);
            this.txbTotalPayment.Name = "txbTotalPayment";
            this.txbTotalPayment.ReadOnly = true;
            this.txbTotalPayment.Size = new System.Drawing.Size(330, 34);
            this.txbTotalPayment.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(34, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 27);
            this.label4.TabIndex = 32;
            this.label4.Text = "Thành tiền:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnPay);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbEmployee);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbTotalPayment);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1045, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 388);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(392, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 27);
            this.label8.TabIndex = 35;
            this.label8.Text = "VNĐ";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Yellow;
            this.btnPay.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.Location = new System.Drawing.Point(246, 160);
            this.btnPay.Name = "btnPay";
            this.btnPay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPay.Size = new System.Drawing.Size(303, 163);
            this.btnPay.TabIndex = 34;
            this.btnPay.Text = "THANH TOÁN";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(34, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 27);
            this.label5.TabIndex = 34;
            this.label5.Text = "Nhân viên:";
            // 
            // txbEmployee
            // 
            this.txbEmployee.BackColor = System.Drawing.SystemColors.Info;
            this.txbEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbEmployee.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbEmployee.Location = new System.Drawing.Point(173, 350);
            this.txbEmployee.Name = "txbEmployee";
            this.txbEmployee.ReadOnly = true;
            this.txbEmployee.Size = new System.Drawing.Size(221, 27);
            this.txbEmployee.TabIndex = 33;
            // 
            // txbBill
            // 
            this.txbBill.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbBill.Location = new System.Drawing.Point(291, 72);
            this.txbBill.Name = "txbBill";
            this.txbBill.Size = new System.Drawing.Size(234, 62);
            this.txbBill.TabIndex = 1;
            this.txbBill.TextChanged += new System.EventHandler(this.txbBill_TextChanged);
            // 
            // frmSelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1637, 755);
            this.Controls.Add(this.txbBill);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txbPriceOut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tsmMain);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.txbTotalPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbID);
            this.Controls.Add(this.txbQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "frmSelling";
            this.Text = "HÓA ĐƠN THANH TOÁN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSelling_FormClosing);
            this.Load += new System.EventHandler(this.frmSelling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.tsmMain.ResumeLayout(false);
            this.tsmMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txbQuantity;
        public System.Windows.Forms.ComboBox cbbID;
        public System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem mànHìnhChínhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        public System.Windows.Forms.ToolStrip tsmMain;
        public System.Windows.Forms.ToolStripTextBox tstxbFIndName;
        public System.Windows.Forms.DataGridView dgvProduct;
        public System.Windows.Forms.ToolStripComboBox tscbbFindProvider;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        public System.Windows.Forms.ToolStripComboBox tlsbbFindType;
        public System.Windows.Forms.Button btnUpd;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnDel;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.TextBox txbPriceOut;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txbTotalPayment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txbEmployee;
        public System.Windows.Forms.TextBox txbBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}