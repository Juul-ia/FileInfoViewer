using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FileInfoViewer
{
    public partial class Form1 : Form
    {
        private List<ImageInfo> imageInfos = new List<ImageInfo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadImageInfos()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Изображения|*.bmp;*.jpg;*.png;*.gif|Все файлы|*.*";
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<ImageInfo> infos = new ImageLoader().LoadImageInfo(new List<string>(dialog.FileNames));
                    imageInfos.Clear();
                    imageInfos.AddRange(infos);
                }
                catch (FileNotFoundException exception)
                {
                    MessageBox.Show($"Не удаётся найти файл {exception.FileName}");
                }
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            LoadImageInfos();
            ImageInfo imgInfo = imageInfos.Find(i => i.Extension.ToLower() == ".bmp");
            if (imgInfo != null)
            {
                lblBmpName.Text = imgInfo.Name;
                lblBmpSize.Text = imgInfo.Length.ToString();
                lblBmpRect.Text = imgInfo.Width.ToString()+"*"+ imgInfo.Height.ToString();
                lblBmpColors.Text = imgInfo.ColorDepth.ToString();
            }
            imgInfo = imageInfos.Find(i => i.Extension.ToLower() == ".png");
            if (imgInfo != null)
            {
                lblPngName.Text = imgInfo.Name;
                lblPngSize.Text = imgInfo.Length.ToString();
                lblPngRect.Text = imgInfo.Width.ToString() + "*" + imgInfo.Height.ToString();
                lblPngColors.Text = imgInfo.ColorDepth.ToString();
            }
            imgInfo = imageInfos.Find(i => i.Extension.ToLower() == ".jpg");
            if (imgInfo != null)
            {
                lblJpgName.Text = imgInfo.Name;
                lblJpgSize.Text = imgInfo.Length.ToString();
                lblJpgRect.Text = imgInfo.Width.ToString() + "*" + imgInfo.Height.ToString();
                lblJpgColors.Text = imgInfo.ColorDepth.ToString();
            }
            imgInfo = imageInfos.Find(i => i.Extension.ToLower() == ".gif");
            if (imgInfo != null)
            {
                lblGifName.Text = imgInfo.Name;
                lblGifSize.Text = imgInfo.Length.ToString();
                lblGifRect.Text = imgInfo.Width.ToString() + "*" + imgInfo.Height.ToString();
                lblGifColors.Text = imgInfo.ColorDepth.ToString();
            }
        }
    }
}
