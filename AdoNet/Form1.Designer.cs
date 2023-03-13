namespace AdoNet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgwProducts = new DataGridView();
            lblName = new Label();
            lblunitPrice = new Label();
            lblStockAmount = new Label();
            tbxName = new TextBox();
            tbxUnitPrice = new TextBox();
            tbxStockAmount = new TextBox();
            gbxAdd = new GroupBox();
            btnAdd = new Button();
            gbxUpdate = new GroupBox();
            btnUpdate = new Button();
            tbxNameUpdate = new TextBox();
            tbxStockAmountUpdate = new TextBox();
            lblNameUpdate = new Label();
            tbxUnitPriceUpdate = new TextBox();
            lblUnitPriceUpdate = new Label();
            lblStockAmountUpdate = new Label();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwProducts).BeginInit();
            gbxAdd.SuspendLayout();
            gbxUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // dgwProducts
            // 
            dgwProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProducts.Location = new Point(12, 41);
            dgwProducts.Name = "dgwProducts";
            dgwProducts.RowTemplate.Height = 25;
            dgwProducts.Size = new Size(660, 130);
            dgwProducts.TabIndex = 0;
            dgwProducts.CellClick += dgwProducts_CellClick;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(35, 37);
            lblName.Name = "lblName";
            lblName.Size = new Size(38, 14);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblunitPrice
            // 
            lblunitPrice.AutoSize = true;
            lblunitPrice.Location = new Point(35, 71);
            lblunitPrice.Name = "lblunitPrice";
            lblunitPrice.Size = new Size(59, 14);
            lblunitPrice.TabIndex = 2;
            lblunitPrice.Text = "Unit Price";
            // 
            // lblStockAmount
            // 
            lblStockAmount.AutoSize = true;
            lblStockAmount.Location = new Point(35, 102);
            lblStockAmount.Name = "lblStockAmount";
            lblStockAmount.Size = new Size(86, 14);
            lblStockAmount.TabIndex = 3;
            lblStockAmount.Text = "Stock Amount";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(127, 37);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(147, 22);
            tbxName.TabIndex = 4;
            // 
            // tbxUnitPrice
            // 
            tbxUnitPrice.Location = new Point(127, 71);
            tbxUnitPrice.Name = "tbxUnitPrice";
            tbxUnitPrice.Size = new Size(147, 22);
            tbxUnitPrice.TabIndex = 5;
            // 
            // tbxStockAmount
            // 
            tbxStockAmount.Location = new Point(127, 102);
            tbxStockAmount.Name = "tbxStockAmount";
            tbxStockAmount.Size = new Size(147, 22);
            tbxStockAmount.TabIndex = 6;
            // 
            // gbxAdd
            // 
            gbxAdd.Controls.Add(btnAdd);
            gbxAdd.Controls.Add(tbxName);
            gbxAdd.Controls.Add(tbxStockAmount);
            gbxAdd.Controls.Add(lblName);
            gbxAdd.Controls.Add(tbxUnitPrice);
            gbxAdd.Controls.Add(lblunitPrice);
            gbxAdd.Controls.Add(lblStockAmount);
            gbxAdd.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbxAdd.Location = new Point(12, 193);
            gbxAdd.Name = "gbxAdd";
            gbxAdd.Size = new Size(327, 159);
            gbxAdd.TabIndex = 7;
            gbxAdd.TabStop = false;
            gbxAdd.Text = "Add a product";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(162, 130);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // gbxUpdate
            // 
            gbxUpdate.Controls.Add(btnUpdate);
            gbxUpdate.Controls.Add(tbxNameUpdate);
            gbxUpdate.Controls.Add(tbxStockAmountUpdate);
            gbxUpdate.Controls.Add(lblNameUpdate);
            gbxUpdate.Controls.Add(tbxUnitPriceUpdate);
            gbxUpdate.Controls.Add(lblUnitPriceUpdate);
            gbxUpdate.Controls.Add(lblStockAmountUpdate);
            gbxUpdate.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbxUpdate.Location = new Point(345, 193);
            gbxUpdate.Name = "gbxUpdate";
            gbxUpdate.Size = new Size(327, 159);
            gbxUpdate.TabIndex = 8;
            gbxUpdate.TabStop = false;
            gbxUpdate.Text = "Update a product";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(162, 130);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tbxNameUpdate
            // 
            tbxNameUpdate.Location = new Point(127, 37);
            tbxNameUpdate.Name = "tbxNameUpdate";
            tbxNameUpdate.Size = new Size(147, 22);
            tbxNameUpdate.TabIndex = 4;
            // 
            // tbxStockAmountUpdate
            // 
            tbxStockAmountUpdate.Location = new Point(127, 102);
            tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
            tbxStockAmountUpdate.Size = new Size(147, 22);
            tbxStockAmountUpdate.TabIndex = 6;
            // 
            // lblNameUpdate
            // 
            lblNameUpdate.AutoSize = true;
            lblNameUpdate.Location = new Point(35, 37);
            lblNameUpdate.Name = "lblNameUpdate";
            lblNameUpdate.Size = new Size(38, 14);
            lblNameUpdate.TabIndex = 1;
            lblNameUpdate.Text = "Name";
            // 
            // tbxUnitPriceUpdate
            // 
            tbxUnitPriceUpdate.Location = new Point(127, 71);
            tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            tbxUnitPriceUpdate.Size = new Size(147, 22);
            tbxUnitPriceUpdate.TabIndex = 5;
            // 
            // lblUnitPriceUpdate
            // 
            lblUnitPriceUpdate.AutoSize = true;
            lblUnitPriceUpdate.Location = new Point(35, 71);
            lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            lblUnitPriceUpdate.Size = new Size(59, 14);
            lblUnitPriceUpdate.TabIndex = 2;
            lblUnitPriceUpdate.Text = "Unit Price";
            // 
            // lblStockAmountUpdate
            // 
            lblStockAmountUpdate.AutoSize = true;
            lblStockAmountUpdate.Location = new Point(35, 102);
            lblStockAmountUpdate.Name = "lblStockAmountUpdate";
            lblStockAmountUpdate.Size = new Size(86, 14);
            lblStockAmountUpdate.TabIndex = 3;
            lblStockAmountUpdate.Text = "Stock Amount";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(560, 9);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 26);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 364);
            Controls.Add(btnDelete);
            Controls.Add(gbxUpdate);
            Controls.Add(gbxAdd);
            Controls.Add(dgwProducts);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwProducts).EndInit();
            gbxAdd.ResumeLayout(false);
            gbxAdd.PerformLayout();
            gbxUpdate.ResumeLayout(false);
            gbxUpdate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwProducts;
        private Label lblName;
        private Label lblunitPrice;
        private Label lblStockAmount;
        private TextBox tbxName;
        private TextBox tbxUnitPrice;
        private TextBox tbxStockAmount;
        private GroupBox gbxAdd;
        private Button btnAdd;
        private GroupBox gbxUpdate;
        private Button btnUpdate;
        private TextBox tbxNameUpdate;
        private TextBox tbxStockAmountUpdate;
        private Label lblNameUpdate;
        private TextBox tbxUnitPriceUpdate;
        private Label lblUnitPriceUpdate;
        private Label lblStockAmountUpdate;
        private Button btnDelete;
    }
}