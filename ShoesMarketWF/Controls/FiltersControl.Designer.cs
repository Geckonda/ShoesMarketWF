namespace ShoesMarketWF.Controls
{
    partial class FiltersControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            searchTextBox = new TextBox();
            searchBtn = new Button();
            resetBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 23);
            label1.TabIndex = 0;
            label1.Text = "Поиск по названию";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(4, 28);
            searchTextBox.Margin = new Padding(4, 5, 4, 5);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(350, 29);
            searchTextBox.TabIndex = 1;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(4, 72);
            searchBtn.Margin = new Padding(4, 5, 4, 5);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(96, 35);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "Поиск";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(108, 72);
            resetBtn.Margin = new Padding(4, 5, 4, 5);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(96, 35);
            resetBtn.TabIndex = 3;
            resetBtn.Text = "Сброс";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // FiltersControl
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            Controls.Add(resetBtn);
            Controls.Add(searchBtn);
            Controls.Add(searchTextBox);
            Controls.Add(label1);
            Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FiltersControl";
            Size = new Size(583, 119);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox searchTextBox;
        private Button searchBtn;
        private Button resetBtn;
    }
}
