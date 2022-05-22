namespace WinForms_HW_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void lbl_Moving_MouseHover(object sender, EventArgs e)
        {
            
            if (sender is Label lbl)
            {
                int emptyGap = 50;
                lbl.Location = new Point
                    (Random.Shared.Next(Width - lbl.Width - emptyGap),
                    Random.Shared.Next(Height - lbl.Height - emptyGap));
                Text = lbl.Location.ToString();
            }

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
            => Text = e.Location.ToString(); 
    }
}