namespace PlaceLabel
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics g;
        public Form1()
        {
            InitializeComponent();

            bitmap = new Bitmap(Width, Height);
            g = Graphics.FromImage(bitmap);
            this.BackgroundImage = bitmap;
        }

        int index = 0;
        bool startPaint = false;
        Point startPoint;
        int width = default;
        int height = default;
        Pen pen = new Pen(Color.Orange, 5);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            startPaint = true; 
            startPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (width < 20 || height < 20) MessageBox.Show("Height or Width can't be lower than minimal value...");
            else
            {
               int[] colorValues = { Random.Shared.Next(255), Random.Shared.Next(255), Random.Shared.Next(255) };
               Label label = new Label() {
                   AutoSize = false,
                   BackColor = Color.FromArgb(colorValues[0], colorValues[1], colorValues[2]),
                   ForeColor = Color.FromArgb(colorValues[1], colorValues[2], colorValues[0]),
                   Location = new Point(startPoint.X, startPoint.Y),
                   Width = width,
                   Height = height,
                   Font = new Font("Consolas", index < 10 ? 20f : 10f, FontStyle.Bold),
                   Text = index++.ToString()
            };
                label.MouseClick += label_Click;
                label.MouseDoubleClick += label_MouseDoubleClick;
                Controls.Add(label);
                
            }

            startPaint = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPaint) { 
                width = e.X - startPoint.X;    
                height = e.Y - startPoint.Y;    
                this.Refresh();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (startPaint)
                g.DrawRectangle(pen, startPoint.X, startPoint.Y, width, height);
            else
                g.Clear(Color.White);
        }

        private void label_Click(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Label lbl = sender as Label;
                this.Text = $"Label {lbl.Text}[W:{lbl.Width.ToString()} H:{lbl.Height.ToString()}]";
            }
        }

        private void label_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Controls.Remove(sender as Label);
        }
    }
}