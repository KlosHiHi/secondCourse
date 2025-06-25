namespace Task3
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
            createMultiplicationTable = new Button();
            SuspendLayout();
            // 
            // createMultiplicationTable
            // 
            createMultiplicationTable.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            createMultiplicationTable.Location = new Point(120, 100);
            createMultiplicationTable.Name = "createMultiplicationTable";
            createMultiplicationTable.Size = new Size(350, 350);
            createMultiplicationTable.TabIndex = 0;
            createMultiplicationTable.Text = "Создать таблицу умножения";
            createMultiplicationTable.UseVisualStyleBackColor = true;
            createMultiplicationTable.Click += CreateMultiplicationTable_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(582, 553);
            Controls.Add(createMultiplicationTable);
            MaximumSize = new Size(600, 600);
            MinimumSize = new Size(600, 550);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Создание таблицы умножения";
            ResumeLayout(false);
        }

        #endregion

        private Button createMultiplicationTable;
    }
}
