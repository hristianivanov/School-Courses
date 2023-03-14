namespace Clothes
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
            components = new System.ComponentModel.Container();
            richTextBox1 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            jeansToolStripMenuItem = new ToolStripMenuItem();
            shirtsToolStripMenuItem = new ToolStripMenuItem();
            sweatshirtsToolStripMenuItem = new ToolStripMenuItem();
            shoesToolStripMenuItem = new ToolStripMenuItem();
            dressesToolStripMenuItem = new ToolStripMenuItem();
            underwearToolStripMenuItem = new ToolStripMenuItem();
            accessoriesToolStripMenuItem = new ToolStripMenuItem();
            promotionToolStripMenuItem = new ToolStripMenuItem();
            onSaleToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            showAllToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            dateToolStripMenuItem = new ToolStripMenuItem();
            chooseToolStripMenuItem = new ToolStripMenuItem();
            showToolStripMenuItem = new ToolStripMenuItem();
            productPriceToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.ScrollBar;
            richTextBox1.ForeColor = SystemColors.ActiveCaptionText;
            richTextBox1.Location = new Point(533, 131);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(433, 419);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { categoryToolStripMenuItem, promotionToolStripMenuItem, usersToolStripMenuItem, dateToolStripMenuItem, showToolStripMenuItem, resetToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1039, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { jeansToolStripMenuItem, shirtsToolStripMenuItem, sweatshirtsToolStripMenuItem, shoesToolStripMenuItem, dressesToolStripMenuItem, underwearToolStripMenuItem, accessoriesToolStripMenuItem });
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(83, 24);
            categoryToolStripMenuItem.Text = "Category";
            // 
            // jeansToolStripMenuItem
            // 
            jeansToolStripMenuItem.Name = "jeansToolStripMenuItem";
            jeansToolStripMenuItem.Size = new Size(168, 26);
            jeansToolStripMenuItem.Text = "Jeans";
            jeansToolStripMenuItem.Click += jeansToolStripMenuItem_Click;
            // 
            // shirtsToolStripMenuItem
            // 
            shirtsToolStripMenuItem.Name = "shirtsToolStripMenuItem";
            shirtsToolStripMenuItem.Size = new Size(168, 26);
            shirtsToolStripMenuItem.Text = "Shirts";
            shirtsToolStripMenuItem.Click += shirtsToolStripMenuItem_Click;
            // 
            // sweatshirtsToolStripMenuItem
            // 
            sweatshirtsToolStripMenuItem.Name = "sweatshirtsToolStripMenuItem";
            sweatshirtsToolStripMenuItem.Size = new Size(168, 26);
            sweatshirtsToolStripMenuItem.Text = "Sweatshirts";
            sweatshirtsToolStripMenuItem.Click += sweatshirtsToolStripMenuItem_Click;
            // 
            // shoesToolStripMenuItem
            // 
            shoesToolStripMenuItem.Name = "shoesToolStripMenuItem";
            shoesToolStripMenuItem.Size = new Size(168, 26);
            shoesToolStripMenuItem.Text = "Shoes";
            shoesToolStripMenuItem.Click += shoesToolStripMenuItem_Click;
            // 
            // dressesToolStripMenuItem
            // 
            dressesToolStripMenuItem.Name = "dressesToolStripMenuItem";
            dressesToolStripMenuItem.Size = new Size(168, 26);
            dressesToolStripMenuItem.Text = "Dresses";
            dressesToolStripMenuItem.Click += dressesToolStripMenuItem_Click;
            // 
            // underwearToolStripMenuItem
            // 
            underwearToolStripMenuItem.Name = "underwearToolStripMenuItem";
            underwearToolStripMenuItem.Size = new Size(168, 26);
            underwearToolStripMenuItem.Text = "Underwear";
            underwearToolStripMenuItem.Click += underwearToolStripMenuItem_Click;
            // 
            // accessoriesToolStripMenuItem
            // 
            accessoriesToolStripMenuItem.Name = "accessoriesToolStripMenuItem";
            accessoriesToolStripMenuItem.Size = new Size(168, 26);
            accessoriesToolStripMenuItem.Text = "Accessories";
            accessoriesToolStripMenuItem.Click += accessoriesToolStripMenuItem_Click;
            // 
            // promotionToolStripMenuItem
            // 
            promotionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { onSaleToolStripMenuItem, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4 });
            promotionToolStripMenuItem.Name = "promotionToolStripMenuItem";
            promotionToolStripMenuItem.Size = new Size(93, 24);
            promotionToolStripMenuItem.Text = "Promotion";
            // 
            // onSaleToolStripMenuItem
            // 
            onSaleToolStripMenuItem.Name = "onSaleToolStripMenuItem";
            onSaleToolStripMenuItem.Size = new Size(120, 26);
            onSaleToolStripMenuItem.Text = "25%";
            onSaleToolStripMenuItem.Click += onSaleToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(120, 26);
            toolStripMenuItem2.Text = "50%";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(120, 26);
            toolStripMenuItem3.Text = "60%";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(120, 26);
            toolStripMenuItem4.Text = "70%";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showAllToolStripMenuItem, searchToolStripMenuItem });
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(58, 24);
            usersToolStripMenuItem.Text = "Users";
            // 
            // showAllToolStripMenuItem
            // 
            showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            showAllToolStripMenuItem.Size = new Size(224, 26);
            showAllToolStripMenuItem.Text = "Show All";
            showAllToolStripMenuItem.Click += showAllToolStripMenuItem_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(224, 26);
            searchToolStripMenuItem.Text = "Search";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // dateToolStripMenuItem
            // 
            dateToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chooseToolStripMenuItem });
            dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            dateToolStripMenuItem.Size = new Size(55, 24);
            dateToolStripMenuItem.Text = "Date";
            // 
            // chooseToolStripMenuItem
            // 
            chooseToolStripMenuItem.Name = "chooseToolStripMenuItem";
            chooseToolStripMenuItem.Size = new Size(141, 26);
            chooseToolStripMenuItem.Text = "Choose";
            chooseToolStripMenuItem.Click += chooseToolStripMenuItem_Click;
            // 
            // showToolStripMenuItem
            // 
            showToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productPriceToolStripMenuItem });
            showToolStripMenuItem.Name = "showToolStripMenuItem";
            showToolStripMenuItem.Size = new Size(59, 24);
            showToolStripMenuItem.Text = "Show";
            // 
            // productPriceToolStripMenuItem
            // 
            productPriceToolStripMenuItem.Name = "productPriceToolStripMenuItem";
            productPriceToolStripMenuItem.Size = new Size(209, 26);
            productPriceToolStripMenuItem.Text = "Product  --> Price";
            productPriceToolStripMenuItem.Click += productPriceToolStripMenuItem_Click;
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(59, 24);
            resetToolStripMenuItem.Text = "Reset";
            resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(479, 61);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(261, 27);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(76, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 27);
            textBox1.TabIndex = 4;
            textBox1.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(414, 419);
            dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1039, 582);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Clothes";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem jeansToolStripMenuItem;
        private ToolStripMenuItem shirtsToolStripMenuItem;
        private ToolStripMenuItem sweatshirtsToolStripMenuItem;
        private ToolStripMenuItem shoesToolStripMenuItem;
        private ToolStripMenuItem dressesToolStripMenuItem;
        private ToolStripMenuItem underwearToolStripMenuItem;
        private ToolStripMenuItem accessoriesToolStripMenuItem;
        private ToolStripMenuItem promotionToolStripMenuItem;
        private ToolStripMenuItem onSaleToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem showAllToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem dateToolStripMenuItem;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private ToolStripMenuItem showToolStripMenuItem;
        private ToolStripMenuItem productPriceToolStripMenuItem;
        private DataGridView dataGridView1;
        private ToolStripMenuItem chooseToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
    }
}