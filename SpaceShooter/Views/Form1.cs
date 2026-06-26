namespace SpaceShooter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
            MainForm();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public void MainForm()
        {

            try
            {
                int width = Properties.Resources.background2.Width + 50;
                int height = Properties.Resources.background2.Height + 200;

                ClientSize = new Size(width, height);

                BackgroundImage = Properties.Resources.background2;
                BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "ERROR: backgound not found!");
                Size = new Size(600, 800);
                BackColor = Color.Red;
            }

            DoubleBuffered = true;
        }
    }
}
