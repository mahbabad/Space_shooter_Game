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
            EndPanel = new Panel();
            label1 = new Label();
            coinAmoutLabel = new Label();
            button2 = new Button();
            button1 = new Button();
            labelcoin = new Label();
            labelscore = new Label();
            sLabel = new Label();
            HighAmountScoreabel = new Label();
            HighScoreLabel = new Label();
            FirstPanel = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            LostPanel = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureHeart3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureHeart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureHeart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureHeart4).BeginInit();
            pausePanel.SuspendLayout();
            EndPanel.SuspendLayout();
            FirstPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            LostPanel.SuspendLayout();
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
            // EndPanel
            // 
            EndPanel.BackColor = Color.Gray;
            EndPanel.Controls.Add(label1);
            EndPanel.Controls.Add(coinAmoutLabel);
            EndPanel.Controls.Add(button2);
            EndPanel.Controls.Add(button1);
            EndPanel.Controls.Add(labelcoin);
            EndPanel.Controls.Add(labelscore);
            EndPanel.Controls.Add(sLabel);
            EndPanel.Controls.Add(HighAmountScoreabel);
            EndPanel.Controls.Add(HighScoreLabel);
            EndPanel.Location = new Point(44, 166);
            EndPanel.Name = "EndPanel";
            EndPanel.Size = new Size(326, 262);
            EndPanel.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(64, 6);
            label1.Name = "label1";
            label1.Size = new Size(209, 41);
            label1.TabIndex = 8;
            label1.Text = "🌟You Win\U0001f947";
            // 
            // coinAmoutLabel
            // 
            coinAmoutLabel.AutoSize = true;
            coinAmoutLabel.BackColor = Color.Transparent;
            coinAmoutLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            coinAmoutLabel.ForeColor = Color.Gold;
            coinAmoutLabel.Location = new Point(192, 105);
            coinAmoutLabel.Name = "coinAmoutLabel";
            coinAmoutLabel.Size = new Size(49, 28);
            coinAmoutLabel.TabIndex = 7;
            coinAmoutLabel.Text = "coin";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.menu;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(169, 147);
            button2.Name = "button2";
            button2.Size = new Size(100, 80);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.exit;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(64, 147);
            button1.Name = "button1";
            button1.Size = new Size(94, 80);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // labelcoin
            // 
            labelcoin.AutoSize = true;
            labelcoin.BackColor = Color.Transparent;
            labelcoin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelcoin.ForeColor = Color.Gold;
            labelcoin.Location = new Point(75, 105);
            labelcoin.Name = "labelcoin";
            labelcoin.Size = new Size(83, 28);
            labelcoin.TabIndex = 4;
            labelcoin.Text = "💰Coin:";
            labelcoin.Click += label1_Click_1;
            // 
            // labelscore
            // 
            labelscore.AutoSize = true;
            labelscore.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelscore.ForeColor = Color.FromArgb(64, 64, 64);
            labelscore.Location = new Point(192, 77);
            labelscore.Name = "labelscore";
            labelscore.Size = new Size(58, 28);
            labelscore.TabIndex = 3;
            labelscore.Text = "score";
            // 
            // sLabel
            // 
            sLabel.AutoSize = true;
            sLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sLabel.ForeColor = Color.FromArgb(64, 64, 64);
            sLabel.Location = new Point(66, 77);
            sLabel.Name = "sLabel";
            sLabel.Size = new Size(92, 28);
            sLabel.TabIndex = 2;
            sLabel.Text = "🏆Score:";
            // 
            // HighAmountScoreabel
            // 
            HighAmountScoreabel.AutoSize = true;
            HighAmountScoreabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HighAmountScoreabel.Location = new Point(180, 47);
            HighAmountScoreabel.Name = "HighAmountScoreabel";
            HighAmountScoreabel.Size = new Size(102, 28);
            HighAmountScoreabel.TabIndex = 1;
            HighAmountScoreabel.Text = "high score";
            HighAmountScoreabel.Click += HighAmountScoreabel_Click;
            // 
            // HighScoreLabel
            // 
            HighScoreLabel.AutoSize = true;
            HighScoreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HighScoreLabel.ForeColor = Color.Blue;
            HighScoreLabel.Location = new Point(41, 46);
            HighScoreLabel.Name = "HighScoreLabel";
            HighScoreLabel.Size = new Size(133, 28);
            HighScoreLabel.TabIndex = 0;
            HighScoreLabel.Text = "💥high score:";
            // 
            // FirstPanel
            // 
            FirstPanel.BackColor = Color.Gray;
            FirstPanel.Controls.Add(label2);
            FirstPanel.Controls.Add(pictureBox1);
            FirstPanel.Controls.Add(button4);
            FirstPanel.Controls.Add(button3);
            FirstPanel.Location = new Point(36, 196);
            FirstPanel.Name = "FirstPanel";
            FirstPanel.Size = new Size(343, 229);
            FirstPanel.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 119);
            label2.Name = "label2";
            label2.Size = new Size(235, 50);
            label2.TabIndex = 3;
            label2.Text = "Do you need an extra heart?\r\n   you must pay 50 coins!";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Full_Heart;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(99, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 94);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(188, 172);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 1;
            button4.Text = "No";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Lime;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(40, 172);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 0;
            button3.Text = "Yes";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // LostPanel
            // 
            LostPanel.BackColor = Color.Gray;
            LostPanel.Controls.Add(label3);
            LostPanel.Controls.Add(label4);
            LostPanel.Controls.Add(label5);
            LostPanel.Controls.Add(label6);
            LostPanel.Controls.Add(label7);
            LostPanel.Controls.Add(label8);
            LostPanel.Controls.Add(label9);
            LostPanel.Controls.Add(button7);
            LostPanel.Controls.Add(button6);
            LostPanel.Controls.Add(button5);
            LostPanel.Location = new Point(36, 166);
            LostPanel.Name = "LostPanel";
            LostPanel.Size = new Size(343, 285);
            LostPanel.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(68, 8);
            label3.Name = "label3";
            label3.Size = new Size(205, 41);
            label3.TabIndex = 15;
            label3.Text = "☠️You lost☠";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(196, 107);
            label4.Name = "label4";
            label4.Size = new Size(49, 28);
            label4.TabIndex = 14;
            label4.Text = "coin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(79, 107);
            label5.Name = "label5";
            label5.Size = new Size(83, 28);
            label5.TabIndex = 13;
            label5.Text = "💰Coin:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(196, 79);
            label6.Name = "label6";
            label6.Size = new Size(58, 28);
            label6.TabIndex = 12;
            label6.Text = "score";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(70, 79);
            label7.Name = "label7";
            label7.Size = new Size(92, 28);
            label7.TabIndex = 11;
            label7.Text = "🏆Score:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(184, 49);
            label8.Name = "label8";
            label8.Size = new Size(102, 28);
            label8.TabIndex = 10;
            label8.Text = "high score";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(45, 48);
            label9.Name = "label9";
            label9.Size = new Size(133, 28);
            label9.TabIndex = 9;
            label9.Text = "💥high score:";
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.BackgroundImage = Properties.Resources.exit;
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(8, 157);
            button7.Name = "button7";
            button7.Size = new Size(110, 101);
            button7.TabIndex = 2;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.BackgroundImage = Properties.Resources.menu;
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(116, 158);
            button6.Name = "button6";
            button6.Size = new Size(110, 101);
            button6.TabIndex = 1;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.BackgroundImage = Properties.Resources.daste;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(228, 158);
            button5.Name = "button5";
            button5.Size = new Size(110, 101);
            button5.TabIndex = 0;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 723);
            Controls.Add(LostPanel);
            Controls.Add(FirstPanel);
            Controls.Add(EndPanel);
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
            EndPanel.ResumeLayout(false);
            EndPanel.PerformLayout();
            FirstPanel.ResumeLayout(false);
            FirstPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            LostPanel.ResumeLayout(false);
            LostPanel.PerformLayout();
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
        private Panel EndPanel;
        private Label labelscore;
        private Label sLabel;
        private Label HighAmountScoreabel;
        private Label HighScoreLabel;
        private Label labelcoin;
        private Button button2;
        private Button button1;
        private Label coinAmoutLabel;
        private Label label1;
        private Panel FirstPanel;
        private Button button4;
        private Button button3;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel LostPanel;
        private Button button5;
        private Button button7;
        private Button button6;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}