namespace Task5
{
    partial class ReplaceForm
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
            SearchTextBox = new TextBox();
            ReplaceTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ReplaceButton = new Button();
            SuspendLayout();
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(14, 41);
            SearchTextBox.Margin = new Padding(3, 4, 3, 4);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(525, 27);
            SearchTextBox.TabIndex = 0;
            // 
            // ReplaceTextBox
            // 
            ReplaceTextBox.Location = new Point(14, 119);
            ReplaceTextBox.Margin = new Padding(3, 4, 3, 4);
            ReplaceTextBox.Name = "ReplaceTextBox";
            ReplaceTextBox.Size = new Size(525, 27);
            ReplaceTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 2;
            label1.Text = "Поиск";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 95);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 3;
            label2.Text = "Замена";
            // 
            // ReplaceButton
            // 
            ReplaceButton.Location = new Point(453, 172);
            ReplaceButton.Margin = new Padding(3, 4, 3, 4);
            ReplaceButton.Name = "ReplaceButton";
            ReplaceButton.Size = new Size(86, 31);
            ReplaceButton.TabIndex = 4;
            ReplaceButton.Text = "Заменить";
            ReplaceButton.UseVisualStyleBackColor = true;
            ReplaceButton.Click += ReplaceButton_Click;
            // 
            // ReplaceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 217);
            Controls.Add(ReplaceButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ReplaceTextBox);
            Controls.Add(SearchTextBox);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(571, 264);
            MinimumSize = new Size(571, 264);
            Name = "ReplaceForm";
            Text = "Поиск и Замена";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SearchTextBox;
        private TextBox ReplaceTextBox;
        private Label label1;
        private Label label2;
        private Button ReplaceButton;
    }
}