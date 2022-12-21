using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace FileInfoViewer
{
    public class ImageLoader
    {
        public List<ImageInfo> LoadImageInfo(List<string> paths)
        {
            List<ImageInfo> result = new List<ImageInfo>();
            foreach (string path in paths)
            {
                using (Image image = Image.FromFile(path))
                {
                    FileInfo fileInfo = new FileInfo(path);
                    ImageInfo imageInfo = new ImageInfo()
                    {
                        Name = fileInfo.Name,
                        Extension = fileInfo.Extension,
                        Length = fileInfo.Length,
                        Width = image.Width,
                        Height = image.Height,
                        ColorDepth = Image.GetPixelFormatSize(image.PixelFormat)
                    };
                    result.Add(imageInfo);
                }
            }
            return result;
        }
    }
}
