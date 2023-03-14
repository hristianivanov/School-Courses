namespace StudentsCounter
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
            this.girlsradioButton1 = new System.Windows.Forms.RadioButton();
            this.boysradioButton2 = new System.Windows.Forms.RadioButton();
            this.allradioButton3 = new System.Windows.Forms.RadioButton();
            this.EightAcheckBox1 = new System.Windows.Forms.CheckBox();
            this.EightBcheckBox2 = new System.Windows.Forms.CheckBox();
            this.EightCcheckBox3 = new System.Windows.Forms.CheckBox();
            this.ShowButton1 = new System.Windows.Forms.Button();
            this.EightAGirlsTextBox = new System.Windows.Forms.TextBox();
            this.EightABoysTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EightBBoysTextBox = new System.Windows.Forms.TextBox();
            this.EightBGirlsTextBox = new System.Windows.Forms.TextBox();
            this.EightCBoysTextBox = new System.Windows.Forms.TextBox();
            this.EightCGirlsTextBox = new System.Windows.Forms.TextBox();
            this.CountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // girlsradioButton1
            // 
            this.girlsradioButton1.AutoSize = true;
            this.girlsradioButton1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.girlsradioButton1.Location = new System.Drawing.Point(40, 40);
            this.girlsradioButton1.Name = "girlsradioButton1";
            this.girlsradioButton1.Size = new System.Drawing.Size(67, 29);
            this.girlsradioButton1.TabIndex = 0;
            this.girlsradioButton1.TabStop = true;
            this.girlsradioButton1.Text = "Girls";
            this.girlsradioButton1.UseVisualStyleBackColor = true;
            this.girlsradioButton1.CheckedChanged += new System.EventHandler(this.girlsradioButton1_CheckedChanged);
            // 
            // boysradioButton2
            // 
            this.boysradioButton2.AutoSize = true;
            this.boysradioButton2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boysradioButton2.Location = new System.Drawing.Point(205, 40);
            this.boysradioButton2.Name = "boysradioButton2";
            this.boysradioButton2.Size = new System.Drawing.Size(71, 29);
            this.boysradioButton2.TabIndex = 1;
            this.boysradioButton2.TabStop = true;
            this.boysradioButton2.Text = "Boys";
            this.boysradioButton2.UseVisualStyleBackColor = true;
            this.boysradioButton2.CheckedChanged += new System.EventHandler(this.boysradioButton2_CheckedChanged);
            // 
            // allradioButton3
            // 
            this.allradioButton3.AutoSize = true;
            this.allradioButton3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.allradioButton3.Location = new System.Drawing.Point(401, 40);
            this.allradioButton3.Name = "allradioButton3";
            this.allradioButton3.Size = new System.Drawing.Size(53, 29);
            this.allradioButton3.TabIndex = 2;
            this.allradioButton3.TabStop = true;
            this.allradioButton3.Text = "All";
            this.allradioButton3.UseVisualStyleBackColor = true;
            // 
            // EightAcheckBox1
            // 
            this.EightAcheckBox1.AutoSize = true;
            this.EightAcheckBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EightAcheckBox1.Location = new System.Drawing.Point(40, 113);
            this.EightAcheckBox1.Name = "EightAcheckBox1";
            this.EightAcheckBox1.Size = new System.Drawing.Size(57, 27);
            this.EightAcheckBox1.TabIndex = 3;
            this.EightAcheckBox1.Text = "8 A";
            this.EightAcheckBox1.UseVisualStyleBackColor = true;
            this.EightAcheckBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // EightBcheckBox2
            // 
            this.EightBcheckBox2.AutoSize = true;
            this.EightBcheckBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EightBcheckBox2.Location = new System.Drawing.Point(41, 156);
            this.EightBcheckBox2.Name = "EightBcheckBox2";
            this.EightBcheckBox2.Size = new System.Drawing.Size(56, 27);
            this.EightBcheckBox2.TabIndex = 4;
            this.EightBcheckBox2.Text = "8 B";
            this.EightBcheckBox2.UseVisualStyleBackColor = true;
            this.EightBcheckBox2.CheckedChanged += new System.EventHandler(this.EightBcheckBox2_CheckedChanged);
            // 
            // EightCcheckBox3
            // 
            this.EightCcheckBox3.AutoSize = true;
            this.EightCcheckBox3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EightCcheckBox3.Location = new System.Drawing.Point(41, 201);
            this.EightCcheckBox3.Name = "EightCcheckBox3";
            this.EightCcheckBox3.Size = new System.Drawing.Size(57, 27);
            this.EightCcheckBox3.TabIndex = 5;
            this.EightCcheckBox3.Text = "8 C";
            this.EightCcheckBox3.UseVisualStyleBackColor = true;
            this.EightCcheckBox3.CheckedChanged += new System.EventHandler(this.EightCcheckBox3_CheckedChanged);
            // 
            // ShowButton1
            // 
            this.ShowButton1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowButton1.Location = new System.Drawing.Point(40, 259);
            this.ShowButton1.Name = "ShowButton1";
            this.ShowButton1.Size = new System.Drawing.Size(94, 29);
            this.ShowButton1.TabIndex = 6;
            this.ShowButton1.Text = "Show";
            this.ShowButton1.UseVisualStyleBackColor = true;
            this.ShowButton1.Click += new System.EventHandler(this.ShowButton1_Click);
            // 
            // EightAGirlsTextBox
            // 
            this.EightAGirlsTextBox.Location = new System.Drawing.Point(136, 113);
            this.EightAGirlsTextBox.Name = "EightAGirlsTextBox";
            this.EightAGirlsTextBox.Size = new System.Drawing.Size(84, 27);
            this.EightAGirlsTextBox.TabIndex = 7;
            // 
            // EightABoysTextBox
            // 
            this.EightABoysTextBox.Location = new System.Drawing.Point(226, 113);
            this.EightABoysTextBox.Name = "EightABoysTextBox";
            this.EightABoysTextBox.Size = new System.Drawing.Size(84, 27);
            this.EightABoysTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(136, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Girls";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(226, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Boys";
            // 
            // EightBBoysTextBox
            // 
            this.EightBBoysTextBox.Location = new System.Drawing.Point(226, 156);
            this.EightBBoysTextBox.Name = "EightBBoysTextBox";
            this.EightBBoysTextBox.Size = new System.Drawing.Size(84, 27);
            this.EightBBoysTextBox.TabIndex = 16;
            // 
            // EightBGirlsTextBox
            // 
            this.EightBGirlsTextBox.Location = new System.Drawing.Point(136, 156);
            this.EightBGirlsTextBox.Name = "EightBGirlsTextBox";
            this.EightBGirlsTextBox.Size = new System.Drawing.Size(84, 27);
            this.EightBGirlsTextBox.TabIndex = 15;
            // 
            // EightCBoysTextBox
            // 
            this.EightCBoysTextBox.Location = new System.Drawing.Point(226, 201);
            this.EightCBoysTextBox.Name = "EightCBoysTextBox";
            this.EightCBoysTextBox.Size = new System.Drawing.Size(84, 27);
            this.EightCBoysTextBox.TabIndex = 18;
            // 
            // EightCGirlsTextBox
            // 
            this.EightCGirlsTextBox.Location = new System.Drawing.Point(136, 201);
            this.EightCGirlsTextBox.Name = "EightCGirlsTextBox";
            this.EightCGirlsTextBox.Size = new System.Drawing.Size(84, 27);
            this.EightCGirlsTextBox.TabIndex = 17;
            // 
            // CountLabel
            // 
            this.CountLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CountLabel.Location = new System.Drawing.Point(182, 262);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(128, 29);
            this.CountLabel.TabIndex = 19;
            this.CountLabel.Text = "Count: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 367);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.EightCBoysTextBox);
            this.Controls.Add(this.EightCGirlsTextBox);
            this.Controls.Add(this.EightBBoysTextBox);
            this.Controls.Add(this.EightBGirlsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EightABoysTextBox);
            this.Controls.Add(this.EightAGirlsTextBox);
            this.Controls.Add(this.ShowButton1);
            this.Controls.Add(this.EightCcheckBox3);
            this.Controls.Add(this.EightBcheckBox2);
            this.Controls.Add(this.EightAcheckBox1);
            this.Controls.Add(this.allradioButton3);
            this.Controls.Add(this.boysradioButton2);
            this.Controls.Add(this.girlsradioButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton girlsradioButton1;
        private RadioButton boysradioButton2;
        private RadioButton allradioButton3;
        private CheckBox EightAcheckBox1;
        private CheckBox EightBcheckBox2;
        private CheckBox EightCcheckBox3;
        private Button ShowButton1;
        private TextBox EightAGirlsTextBox;
        private TextBox EightABoysTextBox;
        private Label label1;
        private Label label2;
        private TextBox EightBBoysTextBox;
        private TextBox EightBGirlsTextBox;
        private TextBox EightCBoysTextBox;
        private TextBox EightCGirlsTextBox;
        private Label CountLabel;
    }
}