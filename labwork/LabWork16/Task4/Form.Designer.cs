namespace Task4
{
    partial class Form
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
            firstButton = new Button();
            fourthButton = new Button();
            fifthButton = new Button();
            sixthButton = new Button();
            seventhButton = new Button();
            eightButton = new Button();
            ninthButton = new Button();
            nullButton = new Button();
            thirdButton = new Button();
            secondButton = new Button();
            numberTextBox = new TextBox();
            clearButton = new Button();
            SuspendLayout();
            // 
            // firstButton
            // 
            firstButton.Location = new Point(12, 85);
            firstButton.Name = "firstButton";
            firstButton.Size = new Size(75, 23);
            firstButton.TabIndex = 0;
            firstButton.Text = "1";
            firstButton.UseVisualStyleBackColor = true;
            firstButton.Click += DigitButton_Click;
            // 
            // fourthButton
            // 
            fourthButton.Location = new Point(12, 114);
            fourthButton.Name = "fourthButton";
            fourthButton.Size = new Size(75, 23);
            fourthButton.TabIndex = 1;
            fourthButton.Text = "4";
            fourthButton.UseVisualStyleBackColor = true;
            fourthButton.Click += DigitButton_Click;
            // 
            // fifthButton
            // 
            fifthButton.Location = new Point(93, 114);
            fifthButton.Name = "fifthButton";
            fifthButton.Size = new Size(75, 23);
            fifthButton.TabIndex = 2;
            fifthButton.Text = "5";
            fifthButton.UseVisualStyleBackColor = true;
            fifthButton.Click += DigitButton_Click;
            // 
            // sixthButton
            // 
            sixthButton.Location = new Point(174, 114);
            sixthButton.Name = "sixthButton";
            sixthButton.Size = new Size(75, 23);
            sixthButton.TabIndex = 3;
            sixthButton.Text = "6";
            sixthButton.UseVisualStyleBackColor = true;
            sixthButton.Click += DigitButton_Click;
            // 
            // seventhButton
            // 
            seventhButton.Location = new Point(12, 143);
            seventhButton.Name = "seventhButton";
            seventhButton.Size = new Size(75, 23);
            seventhButton.TabIndex = 4;
            seventhButton.Text = "7";
            seventhButton.UseVisualStyleBackColor = true;
            seventhButton.Click += DigitButton_Click;
            // 
            // eightButton
            // 
            eightButton.Location = new Point(93, 143);
            eightButton.Name = "eightButton";
            eightButton.Size = new Size(75, 23);
            eightButton.TabIndex = 5;
            eightButton.Text = "8";
            eightButton.UseVisualStyleBackColor = true;
            eightButton.Click += DigitButton_Click;
            // 
            // ninthButton
            // 
            ninthButton.Location = new Point(174, 143);
            ninthButton.Name = "ninthButton";
            ninthButton.Size = new Size(75, 23);
            ninthButton.TabIndex = 6;
            ninthButton.Text = "9";
            ninthButton.UseVisualStyleBackColor = true;
            ninthButton.Click += DigitButton_Click;
            // 
            // nullButton
            // 
            nullButton.Location = new Point(93, 172);
            nullButton.Name = "nullButton";
            nullButton.Size = new Size(75, 23);
            nullButton.TabIndex = 8;
            nullButton.Text = "0";
            nullButton.UseVisualStyleBackColor = true;
            nullButton.Click += DigitButton_Click;
            // 
            // thirdButton
            // 
            thirdButton.Location = new Point(174, 85);
            thirdButton.Name = "thirdButton";
            thirdButton.Size = new Size(75, 23);
            thirdButton.TabIndex = 8;
            thirdButton.Text = "3";
            thirdButton.UseVisualStyleBackColor = true;
            thirdButton.Click += DigitButton_Click;
            // 
            // secondButton
            // 
            secondButton.Location = new Point(93, 85);
            secondButton.Name = "secondButton";
            secondButton.Size = new Size(75, 23);
            secondButton.TabIndex = 9;
            secondButton.Text = "2";
            secondButton.UseVisualStyleBackColor = true;
            secondButton.Click += DigitButton_Click;
            // 
            // numberTextBox
            // 
            numberTextBox.Location = new Point(12, 27);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(237, 23);
            numberTextBox.TabIndex = 10;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(174, 210);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 11;
            clearButton.Text = "Очистить";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButton_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 245);
            Controls.Add(clearButton);
            Controls.Add(numberTextBox);
            Controls.Add(secondButton);
            Controls.Add(thirdButton);
            Controls.Add(nullButton);
            Controls.Add(ninthButton);
            Controls.Add(eightButton);
            Controls.Add(seventhButton);
            Controls.Add(sixthButton);
            Controls.Add(fifthButton);
            Controls.Add(fourthButton);
            Controls.Add(firstButton);
            MaximumSize = new Size(278, 284);
            MinimumSize = new Size(278, 284);
            Name = "Form";
            Text = "Телефон";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button firstButton;
        private Button fourthButton;
        private Button fifthButton;
        private Button sixthButton;
        private Button seventhButton;
        private Button eightButton;
        private Button ninthButton;
        private Button nullButton;
        private Button thirdButton;
        private Button secondButton;
        private TextBox numberTextBox;
        private Button clearButton;
    }
}
