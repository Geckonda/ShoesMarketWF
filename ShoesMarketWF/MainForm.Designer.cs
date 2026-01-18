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
            infoFlowPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowPanel
            // 
            flowPanel.AutoScroll = true;
            flowPanel.Dock = DockStyle.Bottom;
            flowPanel.Location = new Point(0, 261);
            flowPanel.Margin = new Padding(4);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(984, 500);
            flowPanel.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new Point(10, 0);
            welcomeLabel.Margin = new Padding(4, 0, 4, 0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(197, 23);
            welcomeLabel.TabIndex = 1;
            welcomeLabel.Text = "Добро пожаловать, гость!";
            // 
            // backToAuthBtn
            // 
            backToAuthBtn.Location = new Point(828, 3);
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
            infoFlowPanel.FlowDirection = FlowDirection.TopDown;
            infoFlowPanel.Location = new Point(0, 12);
            infoFlowPanel.Name = "infoFlowPanel";
            infoFlowPanel.Size = new Size(984, 242);
            infoFlowPanel.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(welcomeLabel);
            panel1.Controls.Add(backToAuthBtn);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(981, 46);
            panel1.TabIndex = 0;
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "MainForm";
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
    }
}