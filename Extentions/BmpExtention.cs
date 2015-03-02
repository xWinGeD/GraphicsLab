using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lab.Extentions
{
    static class BmpExtention
    {

        static public void SaveToFile(this Bitmap bmp, string filename)
        {
            var guid = Guid.NewGuid();

            var currentDerictory = Directory.GetCurrentDirectory();
            var fullDirectory = Path.Combine(currentDerictory, "test");

            if (!Directory.Exists(fullDirectory))
            {
                Directory.CreateDirectory(fullDirectory);
            }

            var fullName = Path.Combine(fullDirectory + @"\" + guid + filename + ".bmp");

            bmp.Save(fullName);
        }
    }
}
