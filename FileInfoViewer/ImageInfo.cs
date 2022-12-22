namespace FileInfoViewer
{
    /// <summary>
    /// Содержит информацию об изображении
    /// </summary>
    public class ImageInfo
    {
        /// <summary>
        /// Имя файла
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Расширение файла, включая префикс "."
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// Размер файла в байтах
        /// </summary>
        public long Length { get; set; }

        /// <summary>
        /// Ширина изображения в пикселях
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Высота изображения в пикселях
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Глубина цвета
        /// </summary>
        public int ColorDepth { get; set; }
    }
}
