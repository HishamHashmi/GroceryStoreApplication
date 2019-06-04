namespace GS
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.pName = new System.Windows.Forms.TextBox();
            this.pPrice = new System.Windows.Forms.TextBox();
            this.pQty = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cpy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.categry = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groceryStroreDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groceryStroreDatabaseDataSet = new GS.GroceryStroreDatabaseDataSet();
            this.tableAdapterManager1 = new GS.GroceryStroreDatabaseDataSetTableAdapters.TableAdapterManager();
            this.productsTableAdapter1 = new GS.GroceryStroreDatabaseDataSetTableAdapters.ProductsTableAdapter();
            this.SearchMenu = new System.Windows.Forms.Label();
            this.SearchResults = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceryStroreDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceryStroreDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 729);
            this.panel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 318);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 40);
            this.button4.TabIndex = 0;
            this.button4.Text = "Sales";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 40);
            this.button3.TabIndex = 0;
            this.button3.Text = "View Products";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 40);
            this.button2.TabIndex = 0;
            this.button2.Text = "Delete Products";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Products";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(157, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1193, 15);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1193, 15);
            this.panel3.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Gray;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(332, 445);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(87, 37);
            this.SearchButton.TabIndex = 26;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // pName
            // 
            this.pName.Location = new System.Drawing.Point(352, 279);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(218, 20);
            this.pName.TabIndex = 25;
            // 
            // pPrice
            // 
            this.pPrice.Location = new System.Drawing.Point(352, 318);
            this.pPrice.Name = "pPrice";
            this.pPrice.Size = new System.Drawing.Size(218, 20);
            this.pPrice.TabIndex = 24;
            // 
            // pQty
            // 
            this.pQty.Location = new System.Drawing.Point(526, 357);
            this.pQty.Name = "pQty";
            this.pQty.Size = new System.Drawing.Size(44, 20);
            this.pQty.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(352, 242);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(481, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Qty:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(281, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Product Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(655, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(648, 527);
            this.dataGridView1.TabIndex = 29;
            // 
            // Cpy
            // 
            this.Cpy.Location = new System.Drawing.Point(352, 397);
            this.Cpy.Name = "Cpy";
            this.Cpy.Size = new System.Drawing.Size(218, 20);
            this.Cpy.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(242, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "Company:";
            // 
            // categry
            // 
            this.categry.Location = new System.Drawing.Point(352, 357);
            this.categry.Name = "categry";
            this.categry.Size = new System.Drawing.Size(109, 20);
            this.categry.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(249, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "Category:";
            // 
            // groceryStroreDatabaseDataSetBindingSource
            // 
            this.groceryStroreDatabaseDataSetBindingSource.DataSource = this.groceryStroreDatabaseDataSet;
            this.groceryStroreDatabaseDataSetBindingSource.Position = 0;
            // 
            // groceryStroreDatabaseDataSet
            // 
            this.groceryStroreDatabaseDataSet.DataSetName = "GroceryStroreDatabaseDataSet";
            this.groceryStroreDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.ProductsTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = GS.GroceryStroreDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // SearchMenu
            // 
            this.SearchMenu.AutoSize = true;
            this.SearchMenu.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMenu.Location = new System.Drawing.Point(279, 176);
            this.SearchMenu.Name = "SearchMenu";
            this.SearchMenu.Size = new System.Drawing.Size(222, 32);
            this.SearchMenu.TabIndex = 34;
            this.SearchMenu.Text = "Product Search:";
            // 
            // SearchResults
            // 
            this.SearchResults.AutoSize = true;
            this.SearchResults.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchResults.Location = new System.Drawing.Point(911, 108);
            this.SearchResults.Name = "SearchResults";
            this.SearchResults.Size = new System.Drawing.Size(192, 28);
            this.SearchResults.TabIndex = 35;
            this.SearchResults.Text = "Product Details:";
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Gray;
            this.Reset.FlatAppearance.BorderSize = 0;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.ForeColor = System.Drawing.Color.White;
            this.Reset.Location = new System.Drawing.Point(444, 445);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(87, 37);
            this.Reset.TabIndex = 36;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 134);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 40);
            this.button5.TabIndex = 1;
            this.button5.Text = "Home";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.SearchResults);
            this.Controls.Add(this.SearchMenu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.categry);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cpy);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.pName);
            this.Controls.Add(this.pPrice);
            this.Controls.Add(this.pQty);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceryStroreDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceryStroreDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox pName;
        private System.Windows.Forms.TextBox pPrice;
        private System.Windows.Forms.TextBox pQty;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource groceryStroreDatabaseDataSetBindingSource;
        private GroceryStroreDatabaseDataSet groceryStroreDatabaseDataSet;
        private GroceryStroreDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private GroceryStroreDatabaseDataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Cpy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox categry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SearchMenu;
        private System.Windows.Forms.Label SearchResults;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button button5;
    }
}

