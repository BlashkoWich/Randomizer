namespace RandomizerJB
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
            this.StartNumber = new System.Windows.Forms.RichTextBox();
            this.StartNumberTitle = new System.Windows.Forms.Label();
            this.EndNumber = new System.Windows.Forms.RichTextBox();
            this.MaxNumberTitle = new System.Windows.Forms.Label();
            this.ResultText = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.FibonacciCheckBox = new System.Windows.Forms.CheckBox();
            this.MiddleSquareCheckBox = new System.Windows.Forms.CheckBox();
            this.LinearCongruentialCheckBox = new System.Windows.Forms.CheckBox();
            this.ResultCountLabel = new System.Windows.Forms.Label();
            this.ResultCountInput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // StartNumber
            // 
            this.StartNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.StartNumber.Location = new System.Drawing.Point(12, 26);
            this.StartNumber.Name = "StartNumber";
            this.StartNumber.Size = new System.Drawing.Size(226, 59);
            this.StartNumber.TabIndex = 0;
            this.StartNumber.Text = "";
            this.StartNumber.UseWaitCursor = true;
            this.StartNumber.TextChanged += new System.EventHandler(this.StartNumber_TextChanged);
            // 
            // StartNumberTitle
            // 
            this.StartNumberTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.StartNumberTitle.Location = new System.Drawing.Point(13, 0);
            this.StartNumberTitle.Name = "StartNumberTitle";
            this.StartNumberTitle.Size = new System.Drawing.Size(294, 26);
            this.StartNumberTitle.TabIndex = 1;
            this.StartNumberTitle.Text = "Введите стартовое число";
            // 
            // EndNumber
            // 
            this.EndNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.EndNumber.Location = new System.Drawing.Point(13, 143);
            this.EndNumber.Name = "EndNumber";
            this.EndNumber.Size = new System.Drawing.Size(226, 59);
            this.EndNumber.TabIndex = 2;
            this.EndNumber.Text = "";
            this.EndNumber.UseWaitCursor = true;
            this.EndNumber.TextChanged += new System.EventHandler(this.EndNumber_TextChanged);
            // 
            // MaxNumberTitle
            // 
            this.MaxNumberTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.MaxNumberTitle.Location = new System.Drawing.Point(12, 114);
            this.MaxNumberTitle.Name = "MaxNumberTitle";
            this.MaxNumberTitle.Size = new System.Drawing.Size(295, 26);
            this.MaxNumberTitle.TabIndex = 3;
            this.MaxNumberTitle.Text = "Введите максимальное число";
            // 
            // ResultText
            // 
            this.ResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.ResultText.Location = new System.Drawing.Point(48, 507);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(129, 591);
            this.ResultText.TabIndex = 4;
            this.ResultText.Text = "12341432";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.GenerateButton.Location = new System.Drawing.Point(11, 433);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(183, 55);
            this.GenerateButton.TabIndex = 5;
            this.GenerateButton.Text = "Генерация";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // FibonacciCheckBox
            // 
            this.FibonacciCheckBox.Checked = true;
            this.FibonacciCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FibonacciCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.FibonacciCheckBox.Location = new System.Drawing.Point(13, 224);
            this.FibonacciCheckBox.Name = "FibonacciCheckBox";
            this.FibonacciCheckBox.Size = new System.Drawing.Size(153, 36);
            this.FibonacciCheckBox.TabIndex = 6;
            this.FibonacciCheckBox.Text = "Fibonacci";
            this.FibonacciCheckBox.Click += new System.EventHandler(this.FibonacciCheckBox_CheckedChanged);
            // 
            // MiddleSquareCheckBox
            // 
            this.MiddleSquareCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.MiddleSquareCheckBox.Location = new System.Drawing.Point(13, 266);
            this.MiddleSquareCheckBox.Name = "MiddleSquareCheckBox";
            this.MiddleSquareCheckBox.Size = new System.Drawing.Size(153, 36);
            this.MiddleSquareCheckBox.TabIndex = 7;
            this.MiddleSquareCheckBox.Text = "MiddleSquare";
            this.MiddleSquareCheckBox.UseVisualStyleBackColor = true;
            this.MiddleSquareCheckBox.Click += new System.EventHandler(this.MiddleSquareCheckBox_CheckedChanged);
            // 
            // LinearCongruentialCheckBox
            // 
            this.LinearCongruentialCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.LinearCongruentialCheckBox.Location = new System.Drawing.Point(13, 307);
            this.LinearCongruentialCheckBox.Name = "LinearCongruentialCheckBox";
            this.LinearCongruentialCheckBox.Size = new System.Drawing.Size(191, 36);
            this.LinearCongruentialCheckBox.TabIndex = 8;
            this.LinearCongruentialCheckBox.Text = "LinearCongruential";
            this.LinearCongruentialCheckBox.UseVisualStyleBackColor = true;
            this.LinearCongruentialCheckBox.Click += new System.EventHandler(this.LinearCongruentialCheckBox_CheckedChanged);
            // 
            // ResultCountLabel
            // 
            this.ResultCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.ResultCountLabel.Location = new System.Drawing.Point(13, 346);
            this.ResultCountLabel.Name = "ResultCountLabel";
            this.ResultCountLabel.Size = new System.Drawing.Size(227, 23);
            this.ResultCountLabel.TabIndex = 9;
            this.ResultCountLabel.Text = "Количество генераций";
            // 
            // ResultCountInput
            // 
            this.ResultCountInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.ResultCountInput.Location = new System.Drawing.Point(13, 372);
            this.ResultCountInput.Name = "ResultCountInput";
            this.ResultCountInput.Size = new System.Drawing.Size(226, 39);
            this.ResultCountInput.TabIndex = 10;
            this.ResultCountInput.Text = "";
            this.ResultCountInput.UseWaitCursor = true;
            this.ResultCountInput.TextChanged += new System.EventHandler(this.ResultCountInput_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(254, 608);
            this.Controls.Add(this.ResultCountInput);
            this.Controls.Add(this.ResultCountLabel);
            this.Controls.Add(this.LinearCongruentialCheckBox);
            this.Controls.Add(this.MiddleSquareCheckBox);
            this.Controls.Add(this.FibonacciCheckBox);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.MaxNumberTitle);
            this.Controls.Add(this.EndNumber);
            this.Controls.Add(this.StartNumberTitle);
            this.Controls.Add(this.StartNumber);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label ResultCountLabel;
        private System.Windows.Forms.RichTextBox ResultCountInput;

        private System.Windows.Forms.CheckBox MiddleSquareCheckBox;
        private System.Windows.Forms.CheckBox LinearCongruentialCheckBox;

        private System.Windows.Forms.CheckBox FibonacciCheckBox;

        private System.Windows.Forms.Button GenerateButton;

        private System.Windows.Forms.Label ResultText;

        private System.Windows.Forms.RichTextBox EndNumber;
        private System.Windows.Forms.Label MaxNumberTitle;

        private System.Windows.Forms.Label StartNumberTitle;

        private System.Windows.Forms.RichTextBox StartNumber;

        #endregion
    }
}