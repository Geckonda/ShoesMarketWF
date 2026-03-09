namespace ShoesMarketWF
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            flowPanel = new FlowLayoutPanel();
            welcomeLabel = new Label();
            backToAuthBtn = new Button();
            infoFlowPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            orderBtn = new Button();
            addBtn = new Button();
            infoFlowPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowPanel
            // 
            flowPanel.AutoScroll = true;
            flowPanel.Dock = DockStyle.Bottom;
            flowPanel.Location = new Point(0, 192);
            flowPanel.Margin = new Padding(4);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(984, 569);
            flowPanel.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new Point(4, 6);
            welcomeLabel.Margin = new Padding(4, 0, 4, 0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(197, 23);
            welcomeLabel.TabIndex = 1;
            welcomeLabel.Text = "Добро пожаловать, гость!";
            // 
            // backToAuthBtn
            // 
            backToAuthBtn.Location = new Point(819, 6);
            backToAuthBtn.Name = "backToAuthBtn";
            backToAuthBtn.Size = new Size(150, 40);
            backToAuthBtn.TabIndex = 2;
            backToAuthBtn.Text = "Авторизация";
            backToAuthBtn.UseVisualStyleBackColor = true;
            backToAuthBtn.Click += backToAuthBtn_Click;
            // 
            // infoFlowPanel
            // 
            infoFlowPanel.Controls.Add(panel1);
            infoFlowPanel.Dock = DockStyle.Top;
            infoFlowPanel.FlowDirection = FlowDirection.TopDown;
            infoFlowPanel.Location = new Point(0, 0);
            infoFlowPanel.Name = "infoFlowPanel";
            infoFlowPanel.Size = new Size(984, 191);
            infoFlowPanel.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(addBtn);
            panel1.Controls.Add(welcomeLabel);
            panel1.Controls.Add(orderBtn);
            panel1.Controls.Add(backToAuthBtn);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(981, 46);
            panel1.TabIndex = 0;
            // 
            // orderBtn
            // 
            orderBtn.Location = new Point(725, 6);
            orderBtn.Name = "orderBtn";
            orderBtn.Size = new Size(88, 40);
            orderBtn.TabIndex = 3;
            orderBtn.Text = "Заказы";
            orderBtn.UseVisualStyleBackColor = true;
            orderBtn.Visible = false;
            // 
            // addBrttn
            // 
            addBtn.Location = new Point(563, 6);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(156, 40);
            addBtn.TabIndex = 4;
            addBtn.Text = "Добавить товар";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(984, 761);
            Controls.Add(infoFlowPanel);
            Controls.Add(flowPanel);
            Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная";
            infoFlowPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowPanel;
        private Label welcomeLabel;
        private Button backToAuthBtn;
        private FlowLayoutPanel infoFlowPanel;
        private Panel panel1;
        private Button orderBtn;
        private Button addBtn;
    }
}