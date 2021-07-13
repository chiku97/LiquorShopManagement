
namespace WinFormsApp1
{
    partial class SallerForm
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
            this.sallerAge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sellerDataGrid = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.sellerPasswoed = new System.Windows.Forms.TextBox();
            this.sallerPhone = new System.Windows.Forms.TextBox();
            this.sallername = new System.Windows.Forms.TextBox();
            this.sallerid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.sallerAge);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.sellerDataGrid);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.sellerPasswoed);
            this.panel1.Controls.Add(this.sallerPhone);
            this.panel1.Controls.Add(this.sallername);
            this.panel1.Controls.Add(this.sallerid);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(222, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 564);
            this.panel1.TabIndex = 1;
            // 
            // sallerAge
            // 
            this.sallerAge.Location = new System.Drawing.Point(210, 280);
            this.sallerAge.Name = "sallerAge";
            this.sallerAge.Size = new System.Drawing.Size(187, 27);
            this.sallerAge.TabIndex = 25;
            
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Saller Age";
            // 
            // sellerDataGrid
            // 
            this.sellerDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sellerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellerDataGrid.Location = new System.Drawing.Point(430, 174);
            this.sellerDataGrid.Name = "sellerDataGrid";
            this.sellerDataGrid.RowHeadersWidth = 51;
            this.sellerDataGrid.RowTemplate.Height = 29;
            this.sellerDataGrid.Size = new System.Drawing.Size(557, 375);
            this.sellerDataGrid.TabIndex = 19;
            this.sellerDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sellerDataGrid_CellContentClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(294, 445);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(94, 29);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(173, 445);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(94, 29);
            this.buttonEdit.TabIndex = 17;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(49, 445);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 29);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // sellerPasswoed
            // 
            this.sellerPasswoed.Location = new System.Drawing.Point(210, 376);
            this.sellerPasswoed.Name = "sellerPasswoed";
            this.sellerPasswoed.Size = new System.Drawing.Size(187, 27);
            this.sellerPasswoed.TabIndex = 15;
            // 
            // sallerPhone
            // 
            this.sallerPhone.Location = new System.Drawing.Point(210, 328);
            this.sallerPhone.Name = "sallerPhone";
            this.sallerPhone.Size = new System.Drawing.Size(187, 27);
            this.sallerPhone.TabIndex = 14;
            // 
            // sallername
            // 
            this.sallername.Location = new System.Drawing.Point(210, 232);
            this.sallername.Name = "sallername";
            this.sallername.Size = new System.Drawing.Size(187, 27);
            this.sallername.TabIndex = 12;
            // 
            // sallerid
            // 
            this.sallerid.Location = new System.Drawing.Point(210, 188);
            this.sallerid.Name = "sallerid";
            this.sallerid.Size = new System.Drawing.Size(187, 27);
            this.sallerid.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Saller Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Saller Name";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(58, 191);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(65, 20);
            this.Id.TabIndex = 5;
            this.Id.Text = "Saller ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(414, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manage Sallers";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(1216, -1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 27);
            this.button4.TabIndex = 4;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(55, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "Products";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Selling";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SallerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 655);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SallerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SallerForm";
            this.Load += new System.EventHandler(this.SallerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellerDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox sallerAge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView sellerDataGrid;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox sallerPhone;
        private System.Windows.Forms.TextBox sallername;
        private System.Windows.Forms.TextBox sallerid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox sellerPasswoed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}