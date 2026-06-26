namespace SpaceShooter.Views
{
    partial class MainMenuForm
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
            labelWelcome = new Label();
            buttonPlay = new Button();
            buttonShop = new Button();
            buttonOption = new Button();
            buttonAbout = new Button();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.BackColor = Color.Transparent;
            labelWelcome.Font = new Font("Forte", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWelcome.ForeColor = Color.Cyan;
            labelWelcome.Location = new Point(75, 189);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(271, 123);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Welcome To \r\n    \U0001f6f8Space\r\n        Shooter🚀";
            labelWelcome.Click += labelWelcome_Click;
            // 
            // buttonPlay
            // 
            buttonPlay.BackColor = Color.DarkOliveGreen;
            buttonPlay.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPlay.ForeColor = Color.Black;
            buttonPlay.Location = new Point(99, 33);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(220, 80);
            buttonPlay.TabIndex = 1;
            buttonPlay.Text = "Play";
            buttonPlay.UseVisualStyleBackColor = false;
            // 
            // buttonShop
            // 
            buttonShop.BackColor = Color.Gold;
            buttonShop.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonShop.Location = new Point(99, 168);
            buttonShop.Name = "buttonShop";
            buttonShop.Size = new Size(220, 80);
            buttonShop.TabIndex = 2;
            buttonShop.Text = "Shop";
            buttonShop.UseVisualStyleBackColor = false;
            // 
            // buttonOption
            // 
            buttonOption.BackColor = Color.CadetBlue;
            buttonOption.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOption.Location = new Point(99, 294);
            buttonOption.Name = "buttonOption";
            buttonOption.Size = new Size(220, 80);
            buttonOption.TabIndex = 3;
            buttonOption.Text = "Options";
            buttonOption.UseVisualStyleBackColor = false;
            // 
            // buttonAbout
            // 
            buttonAbout.AllowDrop = true;
            buttonAbout.BackColor = Color.IndianRed;
            buttonAbout.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAbout.Location = new Point(99, 422);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(220, 80);
            buttonAbout.TabIndex = 4;
            buttonAbout.Text = "About";
            buttonAbout.UseVisualStyleBackColor = false;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 710);
            Controls.Add(buttonAbout);
            Controls.Add(buttonOption);
            Controls.Add(buttonShop);
            Controls.Add(buttonPlay);
            Controls.Add(labelWelcome);
            Name = "MainMenuForm";
            Text = "MainMenuForm";
            Load += MainMenuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcome;
        private Button buttonPlay;
        private Button buttonShop;
        private Button buttonOption;
        private Button buttonAbout;
    }
}