using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    internal class ImageSQL
    {
        
        public byte[] ImageToStream(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m,System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }

        public byte[] PathToStream(string path)
        {
            MemoryStream m = new MemoryStream();
            Image img = Image.FromFile(path);
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
    }
}
