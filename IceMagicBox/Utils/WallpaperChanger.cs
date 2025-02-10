using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace IceMagicBox.Utils
{
    public class WallpaperChanger
    {
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
