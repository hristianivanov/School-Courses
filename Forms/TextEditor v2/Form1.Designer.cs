namespace TextEditor_v2
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
            this.resetButton = new System.Windows.Forms.Button();
            this.moveUpRight = new System.Windows.Forms.Button();
            this.changeTextButton = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.RichTextBox();
            this.MoveToCenter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(19, 398);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(56, 30);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // moveUpRight
            // 
            this.moveUpRight.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moveUpRight.Location = new System.Drawing.Point(434, 391);
            this.moveUpRight.Name = "moveUpRight";
            this.moveUpRight.Size = new System.Drawing.Size(141, 37);
            this.moveUpRight.TabIndex = 6;
            this.moveUpRight.Text = "UpRight";
            this.moveUpRight.UseVisualStyleBackColor = true;
            this.moveUpRight.Click += new System.EventHandler(this.moveUpRight_Click);
            // 
            // changeTextButton
            // 
            this.changeTextButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeTextButton.Location = new System.Drawing.Point(140, 391);
            this.changeTextButton.Name = "changeTextButton";
            this.changeTextButton.Size = new System.Drawing.Size(141, 37);
            this.changeTextButton.TabIndex = 5;
            this.changeTextButton.Text = "Change Text";
            this.changeTextButton.UseVisualStyleBackColor = true;
            this.changeTextButton.Click += new System.EventHandler(this.changeTextButton_Click);
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text.ForeColor = System.Drawing.SystemColors.MenuText;
            this.text.Location = new System.Drawing.Point(267, 1);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(242, 51);
            this.text.TabIndex = 4;
            this.text.Text = " Hello World";
            // 
            // MoveToCenter
            // 
            this.MoveToCenter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoveToCenter.Location = new System.Drawing.Point(287, 391);
            this.MoveToCenter.Name = "MoveToCenter";
            this.MoveToCenter.Size = new System.Drawing.Size(141, 37);
            this.MoveToCenter.TabIndex = 8;
            this.MoveToCenter.Text = "Center";
            this.MoveToCenter.UseVisualStyleBackColor = true;
            this.MoveToCenter.Click += new System.EventHandler(this.MoveToCenter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MoveToCenter);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.moveUpRight);
            this.Controls.Add(this.changeTextButton);
            this.Controls.Add(this.text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button resetButton;
        private Button moveUpRight;
        private Button changeTextButton;
        private RichTextBox text;
        private Button MoveToCenter;
    }
}