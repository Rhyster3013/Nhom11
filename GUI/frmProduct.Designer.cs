namespace Nhom11.GUI
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.label2 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.cbbProvider = new System.Windows.Forms.ComboBox();
            this.txbPriveOut = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbPriceIn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.txbQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.tsmMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(558, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(536, 62);
            this.label2.TabIndex = 4;
            this.label2.Text = "THÔNG TIN LINH KIỆN";
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbName.Location = new System.Drawing.Point(197, 230);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(478, 34);
            this.txbName.TabIndex = 3;
            this.txbName.TextChanged += new System.EventHandler(this.txbName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(25, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên linh kiện:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(718, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "Loại linh kiện:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(718, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nhà cung ứng:";
            // 
            // cbbType
            // 
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(903, 172);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(267, 34);
            this.cbbType.TabIndex = 4;
            // 
            // cbbProvider
            // 
            this.cbbProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProvider.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbProvider.FormattingEnabled = true;
            this.cbbProvider.Location = new System.Drawing.Point(903, 238);
            this.cbbProvider.Name = "cbbProvider";
            this.cbbProvider.Size = new System.Drawing.Size(267, 34);
            this.cbbProvider.TabIndex = 5;
            // 
            // txbPriveOut
            // 
            this.txbPriveOut.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbPriveOut.Location = new System.Drawing.Point(1373, 236);
            this.txbPriveOut.Name = "txbPriveOut";
            this.txbPriveOut.ReadOnly = true;
            this.txbPriveOut.Size = new System.Drawing.Size(221, 34);
            this.txbPriveOut.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(1257, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 27);
            this.label7.TabIndex = 21;
            this.label7.Text = "Giá bán:";
            // 
            // txbPriceIn
            // 
            this.txbPriceIn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbPriceIn.Location = new System.Drawing.Point(1373, 174);
            this.txbPriceIn.Name = "txbPriceIn";
            this.txbPriceIn.Size = new System.Drawing.Size(221, 34);
            this.txbPriceIn.TabIndex = 6;
            this.txbPriceIn.TextChanged += new System.EventHandler(this.txbPriceIn_TextChanged);
            this.txbPriceIn.Enter += new System.EventHandler(this.txbPriceIn_Enter);
            this.txbPriceIn.Leave += new System.EventHandler(this.txbPriceIn_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(1257, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 27);
            this.label6.TabIndex = 19;
            this.label6.Text = "Giá mua:";
            // 
            // dgvProduct
            // 
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvProduct.Location = new System.Drawing.Point(30, 351);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(1763, 392);
            this.dgvProduct.TabIndex = 23;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 350;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Loại";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nhà cung ứng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 250;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ngày nhập";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Giá mua";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Giá bán";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Số lượng";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
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
            this.tsmMain.Size = new System.Drawing.Size(1805, 45);
            this.tsmMain.TabIndex = 24;
            this.tsmMain.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mànHìnhChínhToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(212, 42);
            this.toolStripDropDownButton1.Text = "Chức năng";
            // 
            // mànHìnhChínhToolStripMenuItem
            // 
            this.mànHìnhChínhToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mànHìnhChínhToolStripMenuItem.Image")));
            this.mànHìnhChínhToolStripMenuItem.Name = "mànHìnhChínhToolStripMenuItem";
            this.mànHìnhChínhToolStripMenuItem.Size = new System.Drawing.Size(331, 42);
            this.mànHìnhChínhToolStripMenuItem.Text = "Màn hình chính";
            this.mànHìnhChínhToolStripMenuItem.Click += new System.EventHandler(this.mànHìnhChínhToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoátToolStripMenuItem.Image")));
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
            this.toolStripLabel2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel2.Image")));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(179, 42);
            this.toolStripLabel2.Text = "Tìm kiếm:";
            // 
            // tstxbFIndName
            // 
            this.tstxbFIndName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tstxbFIndName.Name = "tstxbFIndName";
            this.tstxbFIndName.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tstxbFIndName.Size = new System.Drawing.Size(240, 45);
            this.tstxbFIndName.Text = "Theo tên";
            this.tstxbFIndName.Enter += new System.EventHandler(this.tstxbFIndName_Enter);
            this.tstxbFIndName.Leave += new System.EventHandler(this.tstxbFIndName_Leave);
            this.tstxbFIndName.TextChanged += new System.EventHandler(this.tstxbFIndName_TextChanged);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel3.Image")));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.toolStripLabel3.Size = new System.Drawing.Size(196, 42);
            this.toolStripLabel3.Text = "Theo loại:";
            // 
            // tlsbbFindType
            // 
            this.tlsbbFindType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tlsbbFindType.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tlsbbFindType.Name = "tlsbbFindType";
            this.tlsbbFindType.Size = new System.Drawing.Size(250, 45);
            this.tlsbbFindType.SelectedIndexChanged += new System.EventHandler(this.tlsbbFindType_SelectedIndexChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.toolStripLabel1.Size = new System.Drawing.Size(219, 42);
            this.toolStripLabel1.Text = "Theo hãng:";
            // 
            // tscbbFindProvider
            // 
            this.tscbbFindProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbbFindProvider.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tscbbFindProvider.Name = "tscbbFindProvider";
            this.tscbbFindProvider.Size = new System.Drawing.Size(250, 45);
            this.tscbbFindProvider.SelectedIndexChanged += new System.EventHandler(this.tscbbFindProvider_SelectedIndexChanged);
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
            this.btnUpd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
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
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(25, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã linh kiện:";
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbID.Location = new System.Drawing.Point(197, 169);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(137, 34);
            this.txbID.TabIndex = 1;
            this.txbID.TextChanged += new System.EventHandler(this.txbID_TextChanged);
            // 
            // txbQuantity
            // 
            this.txbQuantity.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbQuantity.Location = new System.Drawing.Point(538, 170);
            this.txbQuantity.Name = "txbQuantity";
            this.txbQuantity.Size = new System.Drawing.Size(137, 34);
            this.txbQuantity.TabIndex = 2;
            this.txbQuantity.TextChanged += new System.EventHandler(this.txbQuantity_TextChanged);
            this.txbQuantity.Enter += new System.EventHandler(this.txbQuantity_Enter);
            this.txbQuantity.Leave += new System.EventHandler(this.txbQuantity_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(409, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 27);
            this.label8.TabIndex = 29;
            this.label8.Text = "Số lượng:";
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1805, 755);
            this.Controls.Add(this.txbQuantity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tsmMain);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.txbPriveOut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbPriceIn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbProvider);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ THÔNG TIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProduct_FormClosing);
            this.Load += new System.EventHandler(this.frmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.tsmMain.ResumeLayout(false);
            this.tsmMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txbName;
        public System.Windows.Forms.ComboBox cbbType;
        public System.Windows.Forms.ComboBox cbbProvider;
        public System.Windows.Forms.TextBox txbPriveOut;
        public System.Windows.Forms.TextBox txbPriceIn;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem mànHìnhChínhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        public System.Windows.Forms.ToolStrip tsmMain;
        public System.Windows.Forms.ToolStripTextBox tstxbFIndName;
        public System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        public System.Windows.Forms.ToolStripComboBox tscbbFindProvider;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        public System.Windows.Forms.ToolStripComboBox tlsbbFindType;
        public System.Windows.Forms.Button btnUpd;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnDel;
        public System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txbID;
        public System.Windows.Forms.TextBox txbQuantity;
        private System.Windows.Forms.Label label8;
    }
}