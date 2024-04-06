using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing;
using System.Drawing.Imaging;

namespace Webcam
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice VideoDevices;
        public Form1()
        {
            InitializeComponent();
            getallcameralist();
        }

        void getallcameralist()     // получаем все доступные камеры на компьютере
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Devices in CaptureDevice)
            {
                comboBox_cameralist.Items.Add(Devices.Name);
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                VideoDevices = new VideoCaptureDevice(CaptureDevice[comboBox_cameralist.SelectedIndex].MonikerString);
                VideoDevices.NewFrame += new NewFrameEventHandler(NewVideoFrame);
                VideoDevices.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewVideoFrame(Object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btn_capture_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Сохранить изображение как";
            sfd.Filter = "Image files(*.jpg, *.png) | *.jpg; *.png";
            ImageFormat imageformat = ImageFormat.Png;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        imageformat = ImageFormat.Jpeg; break;
                    case ".bmp":
                        imageformat = ImageFormat.Bmp; break;
                }
            }
            pictureBox2.Image.Save(sfd.FileName, imageformat);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (VideoDevices.IsRunning == true)
            {
                VideoDevices.Stop();
            }
            Application.Exit(null);
        }
    }
}
