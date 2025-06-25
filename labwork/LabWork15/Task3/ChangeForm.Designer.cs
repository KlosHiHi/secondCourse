namespace Task3
{
    partial class ChangeForm
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
            ChangeTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ChangeButton = new Button();
            SuspendLayout();
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(12, 37);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(460, 23);
            SearchTextBox.TabIndex = 0;
            // 
            // ChangeTextBox
            // 
            ChangeTextBox.Location = new Point(12, 93);
            ChangeTextBox.Name = "ChangeTextBox";
            ChangeTextBox.Size = new Size(460, 23);
            ChangeTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Поиск";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 3;
            label2.Text = "Замена";
            // 
            // ChangeButton
            // 
            ChangeButton.Location = new Point(397, 152);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(75, 23);
            ChangeButton.TabIndex = 4;
            ChangeButton.Text = "Заменить";
            ChangeButton.UseVisualStyleBackColor = true;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // ChangeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 187);
            Controls.Add(ChangeButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ChangeTextBox);
            Controls.Add(SearchTextBox);
            MaximumSize = new Size(500, 226);
            MinimumSize = new Size(500, 226);
            Name = "ChangeForm";
            Text = "Поиск и Замена";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SearchTextBox;
        private TextBox ChangeTextBox;
        private Label label1;
        private Label label2;
        private Button ChangeButton;
    }
}