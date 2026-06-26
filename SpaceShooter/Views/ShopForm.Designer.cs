namespace SpaceShooter.Views
{
    partial class ShopForm
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
            nameLabel = new Label();
            PreviosButton = new Button();
            NextButton = new Button();
            pictureShip = new PictureBox();
            Speedlabel = new Label();
            damagelabel = new Label();
            progressBarSpeed = new ProgressBar();
            buyOrSelectButton = new Button();
            label4 = new Label();
            progressBarDamage = new ProgressBar();
            amountLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureShip).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = Color.Blue;
            nameLabel.Location = new Point(113, 124);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(63, 24);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PreviosButton
            // 
            PreviosButton.BackColor = Color.Transparent;
            PreviosButton.FlatAppearance.BorderSize = 0;
            PreviosButton.FlatStyle = FlatStyle.Flat;
            PreviosButton.Font = new Font("Showcard Gothic", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PreviosButton.ForeColor = Color.Lime;
            PreviosButton.Location = new Point(0, 236);
            PreviosButton.Name = "PreviosButton";
            PreviosButton.Size = new Size(94, 142);
            PreviosButton.TabIndex = 1;
            PreviosButton.Text = "<";
            PreviosButton.UseVisualStyleBackColor = false;
            PreviosButton.Click += PreviosButton_Click;
            // 
            // NextButton
            // 
            NextButton.BackColor = Color.Transparent;
            NextButton.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            NextButton.FlatAppearance.BorderSize = 0;
            NextButton.FlatStyle = FlatStyle.Flat;
            NextButton.Font = new Font("Showcard Gothic", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NextButton.ForeColor = Color.Lime;
            NextButton.Location = new Point(333, 236);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(94, 141);
            NextButton.TabIndex = 2;
            NextButton.Text = ">";
            NextButton.UseVisualStyleBackColor = false;
            NextButton.Click += button2_Click;
            // 
            // pictureShip
            // 
            pictureShip.BackColor = Color.Transparent;
            pictureShip.Location = new Point(90, 151);
            pictureShip.Name = "pictureShip";
            pictureShip.Size = new Size(227, 289);
            pictureShip.SizeMode = PictureBoxSizeMode.Zoom;
            pictureShip.TabIndex = 3;
            pictureShip.TabStop = false;
            // 
            // Speedlabel
            // 
            Speedlabel.AutoSize = true;
            Speedlabel.BackColor = Color.Transparent;
            Speedlabel.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Speedlabel.ForeColor = Color.FromArgb(0, 192, 192);
            Speedlabel.Location = new Point(54, 517);
            Speedlabel.Name = "Speedlabel";
            Speedlabel.Size = new Size(122, 35);
            Speedlabel.TabIndex = 4;
            Speedlabel.Text = "Speed:";
            Speedlabel.Click += label2_Click;
            // 
            // damagelabel
            // 
            damagelabel.AutoSize = true;
            damagelabel.BackColor = Color.Transparent;
            damagelabel.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            damagelabel.ForeColor = Color.FromArgb(0, 192, 192);
            damagelabel.Location = new Point(37, 558);
            damagelabel.Name = "damagelabel";
            damagelabel.Size = new Size(149, 35);
            damagelabel.TabIndex = 5;
            damagelabel.Text = "Damage:";
            // 
            // progressBarSpeed
            // 
            progressBarSpeed.ForeColor = Color.Lime;
            progressBarSpeed.Location = new Point(192, 517);
            progressBarSpeed.Name = "progressBarSpeed";
            progressBarSpeed.Size = new Size(184, 35);
            progressBarSpeed.TabIndex = 6;
            // 
            // buyOrSelectButton
            // 
            buyOrSelectButton.BackColor = Color.Black;
            buyOrSelectButton.Font = new Font("Stencil", 31.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buyOrSelectButton.ForeColor = Color.Gold;
            buyOrSelectButton.Location = new Point(54, 599);
            buyOrSelectButton.Name = "buyOrSelectButton";
            buyOrSelectButton.Size = new Size(313, 94);
            buyOrSelectButton.TabIndex = 8;
            buyOrSelectButton.Text = "button3";
            buyOrSelectButton.UseVisualStyleBackColor = false;
            buyOrSelectButton.Click += buyOrSelectButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Yellow;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(61, 35);
            label4.TabIndex = 9;
            label4.Text = "💰:";
            // 
            // progressBarDamage
            // 
            progressBarDamage.ForeColor = Color.Red;
            progressBarDamage.Location = new Point(192, 558);
            progressBarDamage.Name = "progressBarDamage";
            progressBarDamage.Size = new Size(184, 35);
            progressBarDamage.TabIndex = 11;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.BackColor = Color.Transparent;
            amountLabel.Font = new Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amountLabel.ForeColor = Color.Gold;
            amountLabel.Location = new Point(68, 9);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(99, 39);
            amountLabel.TabIndex = 13;
            amountLabel.Text = "label2";
            // 
            // ShopForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroundShop1;
            ClientSize = new Size(428, 722);
            Controls.Add(amountLabel);
            Controls.Add(progressBarDamage);
            Controls.Add(label4);
            Controls.Add(buyOrSelectButton);
            Controls.Add(progressBarSpeed);
            Controls.Add(damagelabel);
            Controls.Add(Speedlabel);
            Controls.Add(pictureShip);
            Controls.Add(NextButton);
            Controls.Add(PreviosButton);
            Controls.Add(nameLabel);
            Name = "ShopForm";
            Text = "ShopForm";
            Load += ShopForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureShip).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Button PreviosButton;
        private Button NextButton;
        private PictureBox pictureShip;
        private Label Speedlabel;
        private Label damagelabel;
        private ProgressBar progressBarSpeed;
        private Button buyOrSelectButton;
        private Label label4;
        private ProgressBar progressBarDamage;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ShopForm_Load(object sender, EventArgs e)
        {

        }
        private Label amountLabel;
    }
}