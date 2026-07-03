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
            ((System.ComponentModel.ISupportInitialize)pictureHeart3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureHeart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureHeart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureHeart4).BeginInit();
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
            waveLabel.Location = new Point(131, 87);
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
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 603);
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
        private PictureBox pictureHeart4;
    }
}