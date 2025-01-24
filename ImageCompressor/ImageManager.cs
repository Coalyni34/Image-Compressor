
namespace ImageCompressor
{
    class ImageManager
    {
        //This is an image which you want to convert
        public Image ImageSource { get; set; }
        //This is an image in binary code
        public byte[,] pixelColorData { get; set; }

        public Image ConvertDataToImage(byte[,] colorData, Color foreground, Color background)
        {
            Bitmap result_bitmap = new Bitmap(colorData.GetLength(0), colorData.GetLength(1));
            using (Graphics graphics = Graphics.FromImage(result_bitmap))
            {
                for (int x = 0; x < result_bitmap.Width; x++)
                {
                    for (int y = 0; y < result_bitmap.Height; y++)
                    {
                        if (colorData[x, y] != 0)
                        {
                            result_bitmap.SetPixel(x, y, foreground);                            
                        }
                        else 
                        {                            
                            result_bitmap.SetPixel(x, y, background);
                        }
                    }
                }
            }
            Image result_image = result_bitmap;
            return result_image;
        }

        public byte[,] ConvertImageToData(Image image, short Rbrightness, short Gbrightness, short Bbrightness)
        {
            Bitmap bitmap = new Bitmap(image);
            pixelColorData = new byte[image.Width, image.Height];
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    if (bitmap.GetPixel(x, y).A != 0)
                    {
                        if (bitmap.GetPixel(x, y).R >= Rbrightness || bitmap.GetPixel(x, y).G >= Gbrightness || bitmap.GetPixel(x, y).B >= Bbrightness)
                        {
                            pixelColorData[x, y] = 1;
                        }
                        else
                        {
                            pixelColorData[x, y] = 0;
                        }
                    }
                }
            }
            return pixelColorData;
        }
    }
}
