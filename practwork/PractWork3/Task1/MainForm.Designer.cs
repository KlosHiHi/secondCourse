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
            DocumentTextBox = new TextBox();
            CreateFileButton = new Button();
            TaskQuantityNumericUpDown = new NumericUpDown();
            label1 = new Label();
            CreateNewFileButton = new Button();
            DocumentSaveFileDialog = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)TaskQuantityNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // DocumentTextBox
            // 
            DocumentTextBox.BackColor = Color.SeaShell;
            DocumentTextBox.Location = new Point(19, 22);
            DocumentTextBox.Margin = new Padding(4, 6, 4, 6);
            DocumentTextBox.Multiline = true;
            DocumentTextBox.Name = "DocumentTextBox";
            DocumentTextBox.Size = new Size(974, 366);
            DocumentTextBox.TabIndex = 0;
            // 
            // CreateFileButton
            // 
            CreateFileButton.BackColor = Color.Peru;
            CreateFileButton.FlatStyle = FlatStyle.Popup;
            CreateFileButton.Location = new Point(652, 621);
            CreateFileButton.Margin = new Padding(4, 6, 4, 6);
            CreateFileButton.Name = "CreateFileButton";
            CreateFileButton.Size = new Size(331, 41);
            CreateFileButton.TabIndex = 2;
            CreateFileButton.Text = "Создать документ по шаблону";
            CreateFileButton.UseVisualStyleBackColor = false;
            CreateFileButton.Click += CreateFileButton_Click;
            // 
            // TaskQuantityNumericUpDown
            // 
            TaskQuantityNumericUpDown.BackColor = Color.SeaShell;
            TaskQuantityNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            TaskQuantityNumericUpDown.Location = new Point(228, 402);
            TaskQuantityNumericUpDown.Margin = new Padding(4, 6, 4, 6);
            TaskQuantityNumericUpDown.Name = "TaskQuantityNumericUpDown";
            TaskQuantityNumericUpDown.Size = new Size(114, 34);
            TaskQuantityNumericUpDown.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 402);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(201, 28);
            label1.TabIndex = 4;
            label1.Text = "Количество заданий";
            // 
            // CreateNewFileButton
            // 
            CreateNewFileButton.BackColor = Color.Peru;
            CreateNewFileButton.FlatStyle = FlatStyle.Popup;
            CreateNewFileButton.Location = new Point(652, 566);
            CreateNewFileButton.Margin = new Padding(4, 6, 4, 6);
            CreateNewFileButton.Name = "CreateNewFileButton";
            CreateNewFileButton.Size = new Size(331, 43);
            CreateNewFileButton.TabIndex = 5;
            CreateNewFileButton.Text = "Создать новый документ";
            CreateNewFileButton.UseVisualStyleBackColor = false;
            CreateNewFileButton.Click += CreateNewFileButton_Click;
            // 
            // DocumentSaveFileDialog
            // 
            DocumentSaveFileDialog.Filter = "Документ Word|*.docx|Документ PDF|*.pdf";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1006, 677);
            Controls.Add(CreateNewFileButton);
            Controls.Add(label1);
            Controls.Add(TaskQuantityNumericUpDown);
            Controls.Add(CreateFileButton);
            Controls.Add(DocumentTextBox);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 6, 4, 6);
            MaximumSize = new Size(1024, 724);
            MinimumSize = new Size(1024, 724);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Создание документа";
            ((System.ComponentModel.ISupportInitialize)TaskQuantityNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DocumentTextBox;
        private Button CreateFileButton;
        private NumericUpDown TaskQuantityNumericUpDown;
        private Label label1;
        private Button CreateNewFileButton;
        public SaveFileDialog DocumentSaveFileDialog;
    }
}
