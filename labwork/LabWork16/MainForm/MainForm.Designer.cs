namespace MainForm
{
    partial class MainForm
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
            OpenReplaceFormButton = new Button();
            SuspendLayout();
            // 
            // MainTextBox
            // 
            MainTextBox.Location = new Point(14, 16);
            MainTextBox.Margin = new Padding(3, 4, 3, 4);
            MainTextBox.Multiline = true;
            MainTextBox.Name = "MainTextBox";
            MainTextBox.Size = new Size(793, 365);
            MainTextBox.TabIndex = 0;
            // 
            // OpenReplaceFormButton
            // 
            OpenReplaceFormButton.Location = new Point(721, 389);
            OpenReplaceFormButton.Margin = new Padding(3, 4, 3, 4);
            OpenReplaceFormButton.Name = "OpenReplaceFormButton";
            OpenReplaceFormButton.Size = new Size(86, 31);
            OpenReplaceFormButton.TabIndex = 1;
            OpenReplaceFormButton.Text = "Замена";
            OpenReplaceFormButton.UseVisualStyleBackColor = true;
            OpenReplaceFormButton.Click += OpenReplaceFormButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 423);
            Controls.Add(OpenReplaceFormButton);
            Controls.Add(MainTextBox);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(836, 470);
            MinimumSize = new Size(836, 470);
            Name = "MainForm";
            Text = "Главная";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MainTextBox;
        private Button OpenReplaceFormButton;
    }
}
