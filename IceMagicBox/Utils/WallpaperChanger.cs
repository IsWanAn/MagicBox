using Microsoft.Win32;
using System.Resources;
using System.Runtime.InteropServices;

namespace IceMagicBox.Utils
{
    public class WallpaperChanger
    {

        private  static readonly string BgPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Wallpaper");

        private const int SPI_SETDESKWALLPAPER = 0x0014;
        private const int SPIF_UPDATEINIFILE = 0x01;
        private const int SPIF_SENDCHANGE = 0x02;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        public static void SetWallpaper(Image bitmap)
        {
            string path = System.IO.Path.GetTempPath() + "Wallpaper.bmp";
            bitmap.Save(path, System.Drawing.Imaging.ImageFormat.Bmp);
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDCHANGE);
        }


        public static void AddWallPapers(List<string> fileNames) {

            if (!Directory.Exists(BgPath))
            {
                Directory.CreateDirectory(BgPath);
            }

            foreach (var fileName in fileNames)
            {
                var imagePath = Path.Combine(BgPath, Path.GetFileName(fileName));
                Image img = Image.FromFile(fileName);
                img.Save(imagePath);
            }
        }

        public static List<(Image,string)> GetWallPapers() {

            List<(Image, string)> images = new List<(Image, string)>();

            string path = "Wallpaper";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            // 获取所有图像文件（支持常见格式）
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".bmp", ".gif", ".tiff" };
            string[] files = Directory.GetFiles(path)
                                      .Where(f => imageExtensions.Contains(Path.GetExtension(f).ToLower()))
                                      .ToArray();

            if (files.Length == 0)
            {
                return images;
            }
            foreach (var item in files)
            {
                images.Add((Image.FromFile(item), item));
            }
            return images;
        }


        
        public static void RemoveWallPaper(string fileName) {

            File.Delete(fileName);
        }
    }


    //public class WallpaperManager
    //{
    //    private const int SPI_SETDESKWALLPAPER = 0x0014;
    //    private const int SPIF_UPDATEINIFILE = 0x01;
    //    private const int SPIF_SENDCHANGE = 0x02;

    //    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    //    private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

    //    public static void SetWallpaper(Bitmap bitmap, WallpaperStyle style)
    //    {
    //        string path = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "Wallpaper.bmp");
    //        bitmap.Save(path, System.Drawing.Imaging.ImageFormat.Bmp);

    //        SetWallpaperStyle(style);
    //        SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDCHANGE);
    //    }

    //    private static void SetWallpaperStyle(WallpaperStyle style)
    //    {
    //        using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true))
    //        {
    //            if (key == null)
    //                throw new InvalidOperationException("Failed to open registry key for wallpaper settings.");

    //            switch (style)
    //            {
    //                case WallpaperStyle.Fill:
    //                    key.SetValue("WallpaperStyle", "10");
    //                    key.SetValue("TileWallpaper", "0");
    //                    break;

    //                case WallpaperStyle.Fit:
    //                    key.SetValue("WallpaperStyle", "6");
    //                    key.SetValue("TileWallpaper", "0");
    //                    break;

    //                case WallpaperStyle.Stretch:
    //                    key.SetValue("WallpaperStyle", "2");
    //                    key.SetValue("TileWallpaper", "0");
    //                    break;

    //                case WallpaperStyle.Tile:
    //                    key.SetValue("WallpaperStyle", "0");
    //                    key.SetValue("TileWallpaper", "1");
    //                    break;

    //                case WallpaperStyle.Center:
    //                    key.SetValue("WallpaperStyle", "0");
    //                    key.SetValue("TileWallpaper", "0");
    //                    break;

    //                case WallpaperStyle.Span: // Span works only for multiple monitors
    //                    key.SetValue("WallpaperStyle", "22");
    //                    key.SetValue("TileWallpaper", "0");
    //                    break;
    //            }
    //        }
    //    }
    //}

    public enum WallpaperStyle
    {
        Fill,
        Fit,
        Stretch,
        Tile,
        Center,
        Span
    }

}
