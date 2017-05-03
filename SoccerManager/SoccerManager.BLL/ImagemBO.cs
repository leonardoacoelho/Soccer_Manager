using OnBase;
using SoccerManager.DAL;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace SoccerManager.BLL
{
    public class ImagemBO : BaseLogic<Imagem, ImagemDAO>
    {
        public static byte[] ImageToBytes(Image imagem)
        {
            if (imagem != null)
                using (var ms = new MemoryStream())
                {
                    imagem.Save(ms, ImageFormat.Jpeg);

                    return ms.ToArray();
                }
            else
                return null;
        }

        public static Image ByteToImage(byte[] bytes)
        {
            if (bytes != null)
            {
                using (var ms = new MemoryStream(bytes))
                {
                    return Image.FromStream(ms);
                }
            }
            else
                return null;
        }
    }
}
