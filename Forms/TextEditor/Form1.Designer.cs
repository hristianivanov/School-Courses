namespace TextEditor
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
            this.text = new System.Windows.Forms.RichTextBox();
            this.changeColorButton = new System.Windows.Forms.Button();
            this.ChangePosstion = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text.ForeColor = System.Drawing.SystemColors.MenuText;
            this.text.Location = new System.Drawing.Point(260, 22);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(242, 51);
            this.text.TabIndex = 0;
            this.text.Text = " Hello World";
            this.text.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // changeColorButton
            // 
            this.changeColorButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeColorButton.Location = new System.Drawing.Point(141, 142);
            this.changeColorButton.Name = "changeColorButton";
            this.changeColorButton.Size = new System.Drawing.Size(141, 37);
            this.changeColorButton.TabIndex = 1;
            this.changeColorButton.Text = "Change Color";
            this.changeColorButton.UseVisualStyleBackColor = true;
            this.changeColorButton.Click += new System.EventHandler(this.changeColorButton_Click);
            // 
            // ChangePosstion
            // 
            this.ChangePosstion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangePosstion.Location = new System.Drawing.Point(465, 142);
            this.ChangePosstion.Name = "ChangePosstion";
            this.ChangePosstion.Size = new System.Drawing.Size(141, 37);
            this.ChangePosstion.TabIndex = 2;
            this.ChangePosstion.Text = "Change Possition";
            this.ChangePosstion.UseVisualStyleBackColor = true;
            this.ChangePosstion.Click += new System.EventHandler(this.ChangePosstion_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(12, 408);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(56, 30);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.ChangePosstion);
            this.Controls.Add(this.changeColorButton);
            this.Controls.Add(this.text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox text;
        private Button changeColorButton;
        private Button ChangePosstion;
        private Button resetButton;
    }
}