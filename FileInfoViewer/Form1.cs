using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileInfoViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Изображения|*.bmp;*.jpg;*.png;*.gif|Все файлы|*.*";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Image image = Image.FromFile(dialog.FileName);
                Console.WriteLine($"Имя: {Path.GetFileName(dialog.FileName)}");
                Console.WriteLine($"Разрешение: {image.Width}x{image.Height}");
                Console.WriteLine($"Размер: {new FileInfo(dialog.FileName).Length} байт");
            }
        }
    }
}
