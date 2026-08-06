using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace ImgToIcon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Arrastra imágenes sobre este .exe o pásalas como argumentos.");
               Console.ReadLine();
                return; 
            }

            var inputs = args.Where(File.Exists).ToArray();
            if (inputs.Length == 0) { Console.WriteLine("Arrastra imágenes válidas sobre este .exe."); return; }

            var exeDir = AppDomain.CurrentDomain.BaseDirectory;
            Array.ForEach(inputs, p =>
            {
                var fileName = Path.GetFileNameWithoutExtension(p) + ".ico";
                var outPath = Path.Combine(exeDir, fileName);
                ConvertToIco(p, outPath);
            });

        }

        static void ConvertToIco(string inputPath, string outputPath)
        {
            var original = new Bitmap(inputPath);
            var resized = new Bitmap(256, 256);
            var g = Graphics.FromImage(resized);

            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.DrawImage(original, new Rectangle(0, 0, 256, 256));

            var pngStream = new MemoryStream();
            resized.Save(pngStream, ImageFormat.Png);
            byte[] pngBytes = pngStream.ToArray();

            var fs = new FileStream(outputPath, FileMode.Create, FileAccess.Write, FileShare.None);
            var bw = new BinaryWriter(fs);

            // ICONDIR Header (6 bytes)
            bw.Write((short)0);  // Reserved
            bw.Write((short)1);  // Type: 1 = Icon
            bw.Write((short)1);  // Count: 1 image

            // ICONDIRENTRY (16 bytes)
            bw.Write((byte)0);   // Width: 0 = 256px
            bw.Write((byte)0);   // Height: 0 = 256px
            bw.Write((byte)0);   // Color count: 0 = >=256
            bw.Write((byte)0);   // Reserved
            bw.Write((short)1);  // Color planes
            bw.Write((short)32); // Bits per pixel
            bw.Write(pngBytes.Length); // Size of PNG data
            bw.Write(22);        // Offset to image data (6 + 16)

            // PNG Data
            bw.Write(pngBytes);
            bw.Flush();
        }
    }
}
