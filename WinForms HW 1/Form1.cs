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
            int emptyGap = 50;
            if (sender is Label lbl)
                lbl.Location = new Point
                    (Random.Shared.Next(Width - lbl.Width - emptyGap),
                    Random.Shared.Next(Height - lbl.Height - emptyGap));


        }

    }
}