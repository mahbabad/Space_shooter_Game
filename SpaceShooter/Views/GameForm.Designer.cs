namespace SpaceShooter.Views
{
    partial class GameForm
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
            pictureHeart3 = new PictureBox();
            pictureHeart1 = new PictureBox();
            pictureHeart2 = new PictureBox();
            waveLabel = new Label();
            coinLabel = new Label();
            scoreLabel = new Label();
            pictureHeart4 = new PictureBox();
            pauseButton = new Button();
            pausePanel = new Panel();
            exitButton = new Button();
            resumeButton = new Button();
            menuButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureHeart3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureHeart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureHeart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureHeart4).BeginInit();
            pausePanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureHeart3
            // 
            pictureHeart3.BackColor = Color.Transparent;
            pictureHeart3.Image = Properties.Resources.Full_Heart;
            pictureHeart3.Location = new Point(293, -1);
            pictureHeart3.Name = "pictureHeart3";
            pictureHeart3.Size = new Size(40, 40);
            pictureHeart3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureHeart3.TabIndex = 0;
            pictureHeart3.TabStop = false;
            // 
            // pictureHeart1
            // 
            pictureHeart1.BackColor = Color.Transparent;
            pictureHeart1.Image = Properties.Resources.Full_Heart;
            pictureHeart1.Location = new Point(372, 0);
            pictureHeart1.Name = "pictureHeart1";
            pictureHeart1.Size = new Size(40, 40);
            pictureHeart1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureHeart1.TabIndex = 1;
            pictureHeart1.TabStop = false;
            // 
            // pictureHeart2
            // 
            pictureHeart2.BackColor = Color.Transparent;
            pictureHeart2.Image = Properties.Resources.Full_Heart;
            pictureHeart2.Location = new Point(333, 0);
            pictureHeart2.Name = "pictureHeart2";
            pictureHeart2.Size = new Size(40, 40);
            pictureHeart2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureHeart2.TabIndex = 2;
            pictureHeart2.TabStop = false;
            // 
            // waveLabel
            // 
            waveLabel.AutoSize = true;
            waveLabel.BackColor = Color.Transparent;
            waveLabel.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            waveLabel.ForeColor = Color.FromArgb(255, 192, 255);
            waveLabel.Location = new Point(115, 97);
            waveLabel.Name = "waveLabel";
            waveLabel.Size = new Size(126, 35);
            waveLabel.TabIndex = 3;
            waveLabel.Text = "wave 1";
            waveLabel.Click += label1_Click;
            // 
            // coinLabel
            // 
            coinLabel.AutoSize = true;
            coinLabel.BackColor = Color.Transparent;
            coinLabel.ForeColor = Color.Gold;
            coinLabel.Location = new Point(-1, 0);
            coinLabel.Name = "coinLabel";
            coinLabel.Size = new Size(63, 20);
            coinLabel.TabIndex = 4;
            coinLabel.Text = "\U0001fa99Coin:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.BackColor = Color.Transparent;
            scoreLabel.ForeColor = SystemColors.ActiveCaption;
            scoreLabel.Location = new Point(-1, 20);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(70, 20);
            scoreLabel.TabIndex = 5;
            scoreLabel.Text = "🏆Score:";
            // 
            // pictureHeart4
            // 
            pictureHeart4.BackColor = Color.Transparent;
            pictureHeart4.Image = Properties.Resources.Full_Heart;
            pictureHeart4.Location = new Point(255, 0);
            pictureHeart4.Name = "pictureHeart4";
            pictureHeart4.Size = new Size(40, 40);
            pictureHeart4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureHeart4.TabIndex = 6;
            pictureHeart4.TabStop = false;
            // 
            // pauseButton
            // 
            pauseButton.BackColor = Color.Transparent;
            pauseButton.BackgroundImage = Properties.Resources.resume;
            pauseButton.BackgroundImageLayout = ImageLayout.Zoom;
            pauseButton.FlatAppearance.BorderSize = 0;
            pauseButton.FlatAppearance.MouseDownBackColor = Color.Teal;
            pauseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 64);
            pauseButton.FlatStyle = FlatStyle.Flat;
            pauseButton.ForeColor = Color.BurlyWood;
            pauseButton.Location = new Point(352, 46);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(60, 58);
            pauseButton.TabIndex = 7;
            pauseButton.UseVisualStyleBackColor = false;
            pauseButton.Click += button1_Click;
            // 
            // pausePanel
            // 
            pausePanel.BackColor = Color.Gray;
            pausePanel.Controls.Add(exitButton);
            pausePanel.Controls.Add(resumeButton);
            pausePanel.Controls.Add(menuButton);
            pausePanel.Location = new Point(67, 204);
            pausePanel.Name = "pausePanel";
            pausePanel.Size = new Size(285, 162);
            pausePanel.TabIndex = 8;
            pausePanel.Paint += panel1_Paint_1;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Transparent;
            exitButton.BackgroundImage = Properties.Resources.exit;
            exitButton.BackgroundImageLayout = ImageLayout.Zoom;
            exitButton.FlatAppearance.BorderColor = Color.SpringGreen;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatAppearance.MouseDownBackColor = Color.Teal;
            exitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 64);
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("B Nazanin", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 178);
            exitButton.ForeColor = Color.Lime;
            exitButton.Location = new Point(3, 42);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 77);
            exitButton.TabIndex = 11;
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // resumeButton
            // 
            resumeButton.BackColor = Color.Transparent;
            resumeButton.BackgroundImage = Properties.Resources.Pause;
            resumeButton.BackgroundImageLayout = ImageLayout.Zoom;
            resumeButton.FlatAppearance.BorderColor = Color.SpringGreen;
            resumeButton.FlatAppearance.BorderSize = 0;
            resumeButton.FlatAppearance.MouseDownBackColor = Color.Teal;
            resumeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 64);
            resumeButton.FlatStyle = FlatStyle.Flat;
            resumeButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resumeButton.ForeColor = Color.Lime;
            resumeButton.Location = new Point(204, 42);
            resumeButton.Name = "resumeButton";
            resumeButton.Size = new Size(78, 77);
            resumeButton.TabIndex = 9;
            resumeButton.TextAlign = ContentAlignment.BottomCenter;
            resumeButton.UseVisualStyleBackColor = false;
            resumeButton.Click += resumeButton_Click;
            // 
            // menuButton
            // 
            menuButton.BackColor = Color.Transparent;
            menuButton.BackgroundImage = Properties.Resources.menu;
            menuButton.BackgroundImageLayout = ImageLayout.Zoom;
            menuButton.FlatAppearance.BorderColor = Color.SpringGreen;
            menuButton.FlatAppearance.BorderSize = 0;
            menuButton.FlatAppearance.MouseDownBackColor = Color.Teal;
            menuButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 64);
            menuButton.FlatStyle = FlatStyle.Flat;
            menuButton.Font = new Font("B Nazanin", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 178);
            menuButton.ForeColor = Color.Lime;
            menuButton.Location = new Point(95, 42);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(94, 77);
            menuButton.TabIndex = 10;
            menuButton.UseVisualStyleBackColor = false;
            menuButton.Click += menuButton_Click;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 603);
            Controls.Add(pausePanel);
            Controls.Add(pauseButton);
            Controls.Add(coinLabel);
            Controls.Add(scoreLabel);
            Controls.Add(pictureHeart4);
            Controls.Add(waveLabel);
            Controls.Add(pictureHeart3);
            Controls.Add(pictureHeart1);
            Controls.Add(pictureHeart2);
            Name = "GameForm";
            Text = "GameForm";
            ((System.ComponentModel.ISupportInitialize)pictureHeart3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureHeart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureHeart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureHeart4).EndInit();
            pausePanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureHeart3;
        private PictureBox pictureHeart1;
        private PictureBox pictureHeart2;
        private Label waveLabel;
        private Label coinLabel;
        private Label scoreLabel;
        private Label error;
        private PictureBox pictureHeart4;
        private Button pauseButton;
        private Panel pausePanel;
        private Button resumeButton;
        private Button menuButton;
        private Button exitButton;
    }
}