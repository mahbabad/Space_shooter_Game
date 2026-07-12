namespace SpaceShooter.Views
{
    partial class BulletShopForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            CoinLabel = new Label();
            BackButton = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Location = new Point(12, 80);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(404, 897);
            flowLayoutPanel1.TabIndex = 0;
            //flowLayoutPanel1.Paint += this.flowLayoutPanel1_Paint;
            // 
            // CoinLabel
            // 
            CoinLabel.AutoSize = true;
            CoinLabel.Location = new Point(27, 18);
            CoinLabel.Name = "CoinLabel";
            CoinLabel.Size = new Size(50, 20);
            CoinLabel.TabIndex = 0;
            CoinLabel.Text = "label1";
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Transparent;
            BackButton.BackgroundImageLayout = ImageLayout.Zoom;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatAppearance.MouseDownBackColor = Color.Silver;
            BackButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.ForeColor = Color.Coral;
            BackButton.Location = new Point(317, 14);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(99, 40);
            BackButton.TabIndex = 1;
            BackButton.Text = "Back>";
            BackButton.UseVisualStyleBackColor = false;
            // 
            // BulletShopForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroundShop1;
            ClientSize = new Size(428, 1009);
            Controls.Add(BackButton);
            Controls.Add(CoinLabel);
            Controls.Add(flowLayoutPanel1);
            Name = "BulletShopForm";
            Text = "BulletForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label CoinLabel;
        private Button BackButton;
    }
}