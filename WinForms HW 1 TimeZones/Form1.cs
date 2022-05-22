using WinForms_HW_1_TimeZones.Properties;

namespace WinForms_HW_1_TimeZones
{
    public partial class Form1 : Form
    {
        enum Choices { Baku = 4, London = 1 }
        public DateTime CurrentTimeZone;
        
        public Form1()
        {
            InitializeComponent();
            TimerExample();
            ChangeDesign(Choices.Baku);
        }


        void ChangeDesign(Choices choice)
        {
            CurrentTimeZone = DateTime.UtcNow.AddHours((int)choice);

            switch (choice)
            {
                case Choices.Baku:
                    BackgroundImage = Resources.Baku;
                    break;
                case Choices.London:
                    BackgroundImage = Resources.London;
                    break;
                default:
                    break;
            }

            BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void TimerExample()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
            => lbl_Time.Text = CurrentTimeZone.AddSeconds(1).ToLongTimeString();

        private void btn_London_Click(object sender, EventArgs e)
            => ChangeDesign(Choices.London);

        private void btn_Baku_Click(object sender, EventArgs e)
            => ChangeDesign(Choices.Baku);
    }
}