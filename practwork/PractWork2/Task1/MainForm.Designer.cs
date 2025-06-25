namespace Task1
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
            label1 = new Label();
            label2 = new Label();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            registrationButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 28);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 130);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 28);
            label2.TabIndex = 1;
            label2.Text = "Пароль";
            // 
            // loginTextBox
            // 
            LoginTextBox.Location = new Point(33, 60);
            LoginTextBox.Margin = new Padding(4);
            LoginTextBox.Name = "loginTextBox";
            LoginTextBox.Size = new Size(528, 34);
            LoginTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            PasswordTextBox.Location = new Point(35, 162);
            PasswordTextBox.Margin = new Padding(4);
            PasswordTextBox.Name = "passwordTextBox";
            PasswordTextBox.Size = new Size(526, 34);
            PasswordTextBox.TabIndex = 3;
            // 
            // registrationButton
            // 
            registrationButton.BackColor = SystemColors.ButtonHighlight;
            registrationButton.Location = new Point(330, 296);
            registrationButton.Margin = new Padding(4);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(231, 41);
            registrationButton.TabIndex = 4;
            registrationButton.Text = "Зарегистрироваться";
            registrationButton.UseVisualStyleBackColor = false;
            registrationButton.Click += RegistrationButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(594, 361);
            Controls.Add(registrationButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            MaximumSize = new Size(612, 408);
            MinimumSize = new Size(612, 408);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Button registrationButton;
    }
}
