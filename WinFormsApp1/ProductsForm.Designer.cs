
namespace WinFormsApp1
{
    partial class ProductsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.productquantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxsize = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.listBoxViewCategory = new System.Windows.Forms.ListBox();
            this.productDGV = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.sellingprice = new System.Windows.Forms.TextBox();
            this.costprice = new System.Windows.Forms.TextBox();
            this.productname = new System.Windows.Forms.TextBox();
            this.productid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.productquantity);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.listBoxsize);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.listBoxViewCategory);
            this.panel1.Controls.Add(this.productDGV);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.listBoxCategory);
            this.panel1.Controls.Add(this.sellingprice);
            this.panel1.Controls.Add(this.costprice);
            this.panel1.Controls.Add(this.productname);
            this.panel1.Controls.Add(this.productid);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(274, 81);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 705);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // productquantity
            // 
            this.productquantity.Location = new System.Drawing.Point(251, 289);
            this.productquantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productquantity.Name = "productquantity";
            this.productquantity.Size = new System.Drawing.Size(233, 31);
            this.productquantity.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 289);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Quantity";
            // 
            // listBoxsize
            // 
            this.listBoxsize.FormattingEnabled = true;
            this.listBoxsize.ItemHeight = 25;
            this.listBoxsize.Items.AddRange(new object[] {
            "Select Quantity",
            "150ml",
            "300ml",
            "500ml",
            "750ML",
            "1000ML"});
            this.listBoxsize.Location = new System.Drawing.Point(251, 339);
            this.listBoxsize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxsize.Name = "listBoxsize";
            this.listBoxsize.Size = new System.Drawing.Size(233, 29);
            this.listBoxsize.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(550, 182);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "View Product";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(1056, 174);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(118, 36);
            this.buttonRefresh.TabIndex = 21;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // listBoxViewCategory
            // 
            this.listBoxViewCategory.FormattingEnabled = true;
            this.listBoxViewCategory.ItemHeight = 25;
            this.listBoxViewCategory.Items.AddRange(new object[] {
            "Select Category",
            "Beer",
            "Wine",
            "Rum",
            "Vodka"});
            this.listBoxViewCategory.Location = new System.Drawing.Point(746, 180);
            this.listBoxViewCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxViewCategory.Name = "listBoxViewCategory";
            this.listBoxViewCategory.Size = new System.Drawing.Size(233, 29);
            this.listBoxViewCategory.TabIndex = 20;
            // 
            // productDGV
            // 
            this.productDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDGV.Location = new System.Drawing.Point(538, 218);
            this.productDGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productDGV.Name = "productDGV";
            this.productDGV.RowHeadersWidth = 51;
            this.productDGV.RowTemplate.Height = 29;
            this.productDGV.Size = new System.Drawing.Size(696, 469);
            this.productDGV.TabIndex = 19;
            this.productDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(368, 556);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(118, 36);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(216, 556);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(118, 36);
            this.buttonEdit.TabIndex = 17;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(61, 556);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(118, 36);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.ItemHeight = 25;
            this.listBoxCategory.Items.AddRange(new object[] {
            "Select Category",
            "Beer",
            "Wine",
            "Rum",
            "Vodka"});
            this.listBoxCategory.Location = new System.Drawing.Point(251, 504);
            this.listBoxCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(233, 29);
            this.listBoxCategory.TabIndex = 16;
            this.listBoxCategory.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // sellingprice
            // 
            this.sellingprice.Location = new System.Drawing.Point(251, 444);
            this.sellingprice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sellingprice.Name = "sellingprice";
            this.sellingprice.Size = new System.Drawing.Size(233, 31);
            this.sellingprice.TabIndex = 15;
            // 
            // costprice
            // 
            this.costprice.Location = new System.Drawing.Point(251, 390);
            this.costprice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.costprice.Name = "costprice";
            this.costprice.Size = new System.Drawing.Size(233, 31);
            this.costprice.TabIndex = 14;
            // 
            // productname
            // 
            this.productname.Location = new System.Drawing.Point(251, 229);
            this.productname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(233, 31);
            this.productname.TabIndex = 12;
            // 
            // productid
            // 
            this.productid.Location = new System.Drawing.Point(251, 174);
            this.productid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productid.Name = "productid";
            this.productid.Size = new System.Drawing.Size(233, 31);
            this.productid.TabIndex = 11;
            this.productid.TextChanged += new System.EventHandler(this.productid_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 504);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 448);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Selling Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 394);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cost Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 344);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Product Name";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(61, 178);
            this.Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(97, 25);
            this.Id.TabIndex = 5;
            this.Id.Text = "Product ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(518, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manage Products\r\n";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 236);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Selling";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(69, 335);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "Products";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(1518, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 34);
            this.button4.TabIndex = 3;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 819);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBoxCategory;
        private System.Windows.Forms.TextBox sellingprice;
        private System.Windows.Forms.TextBox costprice;
        private System.Windows.Forms.TextBox productname;
        private System.Windows.Forms.TextBox productid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ListBox listBoxViewCategory;
        private System.Windows.Forms.DataGridView productDGV;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBoxsize;
        private System.Windows.Forms.TextBox productquantity;
    }
}