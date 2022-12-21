using FileInfoViewer;
using NUnit.Framework;

namespace FileInfoViewerTest
{
    public class ImageLoaderTest
    {

        [Test]
        public void Test1()
        {
            string Pictures = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName + "\\Pictures";
            string OnePict = Pictures + "\\Девушка.jpg";
            List < ImageInfo > Info = new ImageLoader().LoadImageInfo(new List<string>() { OnePict });
            Assert.AreEqual(1, Info.Count);
            ImageInfo imageInfo = Info[0];
            Assert.IsNotNull(imageInfo);
            Assert.AreEqual("Девушка.jpg", imageInfo.Name);
            Assert.AreEqual(".jpg", imageInfo.Extension);
            Assert.AreEqual(362269, imageInfo.Length);
            Assert.AreEqual(1080, imageInfo.Width);
            Assert.AreEqual(1074, imageInfo.Height);
            Assert.AreEqual(24, imageInfo.ColorDepth);
        }
        [Test]
        public void Test2()
        {
            string Pictures = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName + "\\Pictures";
            string TwoPict = Pictures + "\\Книга.bmp";
            List<ImageInfo> Info = new ImageLoader().LoadImageInfo(new List<string>() { TwoPict });
            Assert.AreEqual(1, Info.Count);
            ImageInfo imageInfo = Info[0];
            Assert.IsNotNull(imageInfo);
            Assert.AreEqual("Книга.bmp", imageInfo.Name);
            Assert.AreEqual(".bmp", imageInfo.Extension);
            Assert.AreEqual(2412054, imageInfo.Length);
            Assert.AreEqual(804, imageInfo.Width);
            Assert.AreEqual(1000, imageInfo.Height);
            Assert.AreEqual(24, imageInfo.ColorDepth);
        }
        [Test]
        public void Test3()
        {
            string Pictures = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName + "\\Pictures";
            string ThreePict = Pictures + "\\Шар.gif";
            List<ImageInfo> Info = new ImageLoader().LoadImageInfo(new List<string>() { ThreePict });
            Assert.AreEqual(1, Info.Count);
            ImageInfo imageInfo = Info[0];
            Assert.IsNotNull(imageInfo);
            Assert.AreEqual("Шар.gif", imageInfo.Name);
            Assert.AreEqual(".gif", imageInfo.Extension);
            Assert.AreEqual(1877613, imageInfo.Length);
            Assert.AreEqual(600, imageInfo.Width);
            Assert.AreEqual(600, imageInfo.Height);
            Assert.AreEqual(32, imageInfo.ColorDepth);
        }
        [Test]
        public void Test4()
        {
            string Pictures = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName + "\\Pictures";
            string ThreePict = Pictures + "\\Цветы и кофе.png";
            List<ImageInfo> Info = new ImageLoader().LoadImageInfo(new List<string>() { ThreePict });
            Assert.AreEqual(1, Info.Count);
            ImageInfo imageInfo = Info[0];
            Assert.IsNotNull(imageInfo);
            Assert.AreEqual("Цветы и кофе.png", imageInfo.Name);
            Assert.AreEqual(".png", imageInfo.Extension);
            Assert.AreEqual(1469995, imageInfo.Length);
            Assert.AreEqual(804, imageInfo.Width);
            Assert.AreEqual(1000, imageInfo.Height);
            Assert.AreEqual(24, imageInfo.ColorDepth);
        }
}