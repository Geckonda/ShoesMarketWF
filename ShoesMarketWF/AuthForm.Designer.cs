namespace ShoesMarketWF
{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            loginInput = new TextBox();
            label1 = new Label();
            authBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            passwordInput = new TextBox();
            asGuestBtn = new Button();
            errorMessageLabel = new Label();
            SuspendLayout();
            // 
            // loginInput
            // 
            loginInput.Location = new Point(89, 141);
            loginInput.Name = "loginInput";
            loginInput.Size = new Size(207, 29);
            loginInput.TabIndex = 0;
            loginInput.Text = "94d5ous@gmail.com";
            loginInput.TextChanged += inputsChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(116, 75);
            label1.Name = "label1";
            label1.Size = new Size(143, 27);
            label1.TabIndex = 1;
            label1.Text = "Авторизация";
            // 
            // authBtn
            // 
            authBtn.Location = new Point(135, 255);
            authBtn.Name = "authBtn";
            authBtn.Size = new Size(100, 40);
            authBtn.TabIndex = 2;
            authBtn.Text = "Войти";
            authBtn.UseVisualStyleBackColor = true;
            authBtn.Click += authBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 117);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 3;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 196);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 4;
            label3.Text = "Пароль";
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(89, 220);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '*';
            passwordInput.Size = new Size(207, 29);
            passwordInput.TabIndex = 5;
            passwordInput.Text = "uzWC67";
            passwordInput.TextChanged += inputsChanged;
            // 
            // asGuestBtn
            // 
            asGuestBtn.Location = new Point(222, 12);
            asGuestBtn.Name = "asGuestBtn";
            asGuestBtn.Size = new Size(150, 40);
            asGuestBtn.TabIndex = 6;
            asGuestBtn.Text = "Войти как гость";
            asGuestBtn.UseVisualStyleBackColor = true;
            asGuestBtn.Click += asGuestBtn_Click;
            // 
            // errorMessageLabel
            // 
            errorMessageLabel.BackColor = SystemColors.ActiveCaptionText;
            errorMessageLabel.ForeColor = Color.Red;
            errorMessageLabel.Location = new Point(12, 331);
            errorMessageLabel.Name = "errorMessageLabel";
            errorMessageLabel.Size = new Size(360, 21);
            errorMessageLabel.TabIndex = 7;
            errorMessageLabel.Text = "Ошибка";
            errorMessageLabel.TextAlign = ContentAlignment.MiddleCenter;
            errorMessageLabel.Visible = false;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(384, 361);
            Controls.Add(errorMessageLabel);
            Controls.Add(asGuestBtn);
            Controls.Add(passwordInput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(authBtn);
            Controls.Add(label1);
            Controls.Add(loginInput);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginInput;
        private Label label1;
        private Button authBtn;
        private Label label2;
        private Label label3;
        private TextBox passwordInput;
        private Button asGuestBtn;
        private Label errorMessageLabel;
    }
}