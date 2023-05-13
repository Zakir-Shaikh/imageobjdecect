using Alturos.Yolo;
using Alturos.Yolo.Model;
using System.Drawing.Imaging;
using System.IO;

namespace imageobjdecect
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "image files|*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picimage.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btndetect_Click(object sender, EventArgs e)
        {
            var configurationDetector = new YoloConfigurationDetector();
            var config = configurationDetector.Detect();

            var yolo = new YoloWrapper(config);
            var memoryStream = new MemoryStream();
            picimage.Image.Save(memoryStream, ImageFormat.Png);
            var _items = yolo.Detect(memoryStream.ToArray()).ToList();
        }
        void AddDetailsToPictireBox(PictureBox pictureBoxToRender, List<YoloItem> items)
        {
            var img = pictureBoxToRender.Image;

            var font = new Font("Arial", 50, FontStyle.Bold);
            var brush = new SolidBrush(Color.LightGreen);

            var graphics = Graphics.FromImage(img);
            foreach (var item in items)
            {
                var x = item.X;
                var y = item.Y;
                var width = item.Width;
                var height = item.Height;

                var rect = new Rectangle(x, y, width, height);
                var pen = new Pen(Color.LightGreen, 6);

                var point = new Point(x, y);

                graphics.DrawRectangle(pen, rect);
                graphics.DrawString(item.Type, Font, brush, point);
            }
            pictureBoxToRender.Image = img;

        }

    }
}