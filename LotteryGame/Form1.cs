namespace LotteryGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            Animation.Start();
        }

        private void Animation_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            progressBar1.Value += 1;
            label1.Text = $"{progressBar1.Value.ToString()}%";
            if (progressBar1.Value == 100)
            {
                Animation.Stop();
                HideAnimation.Start();
            }
        }

        private void HideAnimation_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 1;
            if (this.Opacity == 0)
            {
                HideAnimation.Stop();
                Stage stage = new Stage();
                stage.Show();
                this.Hide();
            }
        }
    }
}