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
                    List<ImageInfo> infos = new ImageLoader().LoadImageInfos(new List<string>(dialog.FileNames));
                    imageInfos.Clear();
                    imageInfos.AddRange(infos);
                }
                catch (FileNotFoundException exception)
                {
                    MessageBox.Show($"Не удаётся найти файл {exception.FileName}");
                }
            }
        }
    }
}
