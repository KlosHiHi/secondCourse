namespace Task3
{
    partial class TextForm
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
            MainTextBox = new TextBox();
            ToChangeFormButton = new Button();
            SuspendLayout();
            // 
            // MainTextBox
            // 
            MainTextBox.Location = new Point(12, 25);
            MainTextBox.Multiline = true;
            MainTextBox.Name = "MainTextBox";
            MainTextBox.Size = new Size(495, 138);
            MainTextBox.TabIndex = 0;
            // 
            // ToChangeFormButton
            // 
            ToChangeFormButton.Location = new Point(432, 182);
            ToChangeFormButton.Name = "ToChangeFormButton";
            ToChangeFormButton.Size = new Size(75, 23);
            ToChangeFormButton.TabIndex = 1;
            ToChangeFormButton.Text = "Замена";
            ToChangeFormButton.UseVisualStyleBackColor = true;
            ToChangeFormButton.Click += OpenChangeFormButton_Click;
            // 
            // TextForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 217);
            Controls.Add(ToChangeFormButton);
            Controls.Add(MainTextBox);
            MaximumSize = new Size(535, 256);
            MinimumSize = new Size(535, 256);
            Name = "TextForm";
            Text = "Текст";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MainTextBox;
        private Button ToChangeFormButton;
    }
}
