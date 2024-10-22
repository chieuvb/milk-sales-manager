using milk_sales_manager.Properties;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace milk_sales_manager.modules
{
    internal class ImageProcess
    {
        readonly string sourceFolder = @"C:\Vinamilk manage\image\";

        public ImageProcess(bool isProduct, Dictionary<string, Image> cacheImage)
        {
            if (!cacheImage.ContainsKey("no-image"))
                cacheImage.Add("no-image", Resources.icons8_no_image_96);

            if (isProduct)
                sourceFolder += "products\\";
            else
                sourceFolder += "employees\\";

            if (!Directory.Exists(sourceFolder))
                Directory.CreateDirectory(sourceFolder);
        }

        public Image LoadImageToPictureBox()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files(*.png; *.jpg)|*.png; *.jpg;"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                return Image.FromFile(imagePath);
            }
            else
            {
                return Resources.icons8_no_image_96;
            }
        }

        public void LoadAndCacheImage(string key, Dictionary<string, Image> cacheImage)
        {
            string imagePath = sourceFolder + key + ".png";

            if (cacheImage.ContainsKey(key))
                return;

            if (File.Exists(imagePath))
            {
                using (Image image = Image.FromFile(imagePath))
                {
                    using (MemoryStream mem = new MemoryStream())
                    {
                        image.Save(mem, image.RawFormat);

                        if (cacheImage.TryGetValue(key, out Image existingImage))
                        {
                            existingImage.Dispose();
                            cacheImage[key] = Image.FromStream(mem);
                        }
                        else
                            cacheImage.Add(key, Image.FromStream(mem));
                    }
                }
            }
        }

        public string SaveAndCacheImage(string key, Image image, Dictionary<string, Image> cacheImage)
        {
            Image imageToSave = image;

            string destinationFile = sourceFolder + key + ".png";

            if (imageToSave != null && imageToSave.Width >= 128 && !File.Exists(destinationFile))
            {
                using (imageToSave)
                {
                    imageToSave.Save(destinationFile, System.Drawing.Imaging.ImageFormat.Png);

                    LoadAndCacheImage(key, cacheImage);
                }

                return key;
            }
            else if (File.Exists(destinationFile))
            {
                UpdateImage(key, image, cacheImage);
                return key;
            }
            else
                return "no-image";
        }

        public void UpdateImage(string key, Image image, Dictionary<string, Image> cacheImage)
        {
            string sourceFile = sourceFolder + key + ".png";

            if (File.Exists(sourceFile))
                File.Delete(sourceFile);

            if (cacheImage.ContainsKey(key))
                cacheImage.Remove(key);

            SaveAndCacheImage(key, image, cacheImage);
        }

        public void DeleteImage(string key, Dictionary<string, Image> cacheImage)
        {
            string sourceFile = sourceFolder + key + ".png";

            if (File.Exists(sourceFile))
                File.Delete(sourceFile);

            if (cacheImage.ContainsKey(key))
                cacheImage.Remove(key);
        }
    }
}
