namespace ColorChanger
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
            this.clearButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.blackButton = new System.Windows.Forms.Button();
            this.goldButton = new System.Windows.Forms.Button();
            this.limeButton = new System.Windows.Forms.Button();
            this.cyanButton = new System.Windows.Forms.Button();
            this.plate = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clearButton.Location = new System.Drawing.Point(474, 48);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(79, 209);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.Location = new System.Drawing.Point(376, 91);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(75, 37);
            this.redButton.TabIndex = 2;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // blackButton
            // 
            this.blackButton.BackColor = System.Drawing.Color.Black;
            this.blackButton.Location = new System.Drawing.Point(376, 48);
            this.blackButton.Name = "blackButton";
            this.blackButton.Size = new System.Drawing.Size(75, 37);
            this.blackButton.TabIndex = 6;
            this.blackButton.UseVisualStyleBackColor = false;
            this.blackButton.Click += new System.EventHandler(this.blackButton_Click);
            // 
            // goldButton
            // 
            this.goldButton.BackColor = System.Drawing.Color.Gold;
            this.goldButton.Location = new System.Drawing.Point(376, 134);
            this.goldButton.Name = "goldButton";
            this.goldButton.Size = new System.Drawing.Size(75, 37);
            this.goldButton.TabIndex = 7;
            this.goldButton.UseVisualStyleBackColor = false;
            this.goldButton.Click += new System.EventHandler(this.goldButton_Click);
            // 
            // limeButton
            // 
            this.limeButton.BackColor = System.Drawing.Color.Lime;
            this.limeButton.Location = new System.Drawing.Point(376, 177);
            this.limeButton.Name = "limeButton";
            this.limeButton.Size = new System.Drawing.Size(75, 37);
            this.limeButton.TabIndex = 8;
            this.limeButton.UseVisualStyleBackColor = false;
            this.limeButton.Click += new System.EventHandler(this.limeButton_Click);
            // 
            // cyanButton
            // 
            this.cyanButton.BackColor = System.Drawing.Color.Cyan;
            this.cyanButton.Location = new System.Drawing.Point(376, 220);
            this.cyanButton.Name = "cyanButton";
            this.cyanButton.Size = new System.Drawing.Size(75, 37);
            this.cyanButton.TabIndex = 9;
            this.cyanButton.UseVisualStyleBackColor = false;
            this.cyanButton.Click += new System.EventHandler(this.cyanButton_Click);
            // 
            // plate
            // 
            this.plate.BackColor = System.Drawing.SystemColors.MenuBar;
            this.plate.Location = new System.Drawing.Point(78, 48);
            this.plate.Name = "plate";
            this.plate.Size = new System.Drawing.Size(206, 209);
            this.plate.TabIndex = 10;
            this.plate.Text = "";
            this.plate.TextChanged += new System.EventHandler(this.plate_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 352);
            this.Controls.Add(this.plate);
            this.Controls.Add(this.cyanButton);
            this.Controls.Add(this.limeButton);
            this.Controls.Add(this.goldButton);
            this.Controls.Add(this.blackButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.clearButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button clearButton;
        private Button redButton;
        private Button blackButton;
        private Button goldButton;
        private Button limeButton;
        private Button cyanButton;
        private RichTextBox plate;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}