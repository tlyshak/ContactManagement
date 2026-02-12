using System;
using System.Drawing;
using System.IO;

namespace ContactManagement.WinForms.Helpers
{
    public static class ImageHelper
    {
        public static Image LoadAvatar(string relativePath)
        {
            if (string.IsNullOrWhiteSpace(relativePath))
                return null;

            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var fullPath = Path.Combine(baseDir, relativePath);

            if (!File.Exists(fullPath))
                return null;

            using (var img = Image.FromFile(fullPath))
            {
                return (Image)img.Clone();
            }
        }
    }
}
