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
            resetBtn = new Button();
            sortComboBox = new ComboBox();
            filterComboBox = new ComboBox();
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
            searchTextBox.Size = new Size(200, 29);
            searchTextBox.TabIndex = 1;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(4, 67);
            resetBtn.Margin = new Padding(4, 5, 4, 5);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(96, 35);
            resetBtn.TabIndex = 3;
            resetBtn.Text = "Сброс";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // sortComboBox
            // 
            sortComboBox.DisplayMember = "Все";
            sortComboBox.FormattingEnabled = true;
            sortComboBox.Items.AddRange(new object[] { "Все", "По убыванию", "По возрастанию" });
            sortComboBox.Location = new Point(211, 28);
            sortComboBox.Name = "sortComboBox";
            sortComboBox.Size = new Size(180, 31);
            sortComboBox.TabIndex = 4;
            sortComboBox.ValueMember = "Все";
            sortComboBox.SelectedIndexChanged += sortComboBox_TextChanged;
            // 
            // filterComboBox
            // 
            filterComboBox.DisplayMember = "Все";
            filterComboBox.FormattingEnabled = true;
            filterComboBox.Location = new Point(397, 28);
            filterComboBox.Name = "filterComboBox";
            filterComboBox.Size = new Size(180, 31);
            filterComboBox.TabIndex = 5;
            filterComboBox.ValueMember = "Все";
            filterComboBox.TextChanged += filterComboBox_TextChanged;
            // 
            // FiltersControl
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            Controls.Add(filterComboBox);
            Controls.Add(sortComboBox);
            Controls.Add(resetBtn);
            Controls.Add(searchTextBox);
            Controls.Add(label1);
            Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FiltersControl";
            Size = new Size(583, 109);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox searchTextBox;
        private Button resetBtn;
        private ComboBox sortComboBox;
        private ComboBox filterComboBox;
    }
}
