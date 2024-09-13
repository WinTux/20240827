using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ProyectoAppWeb.Tags
{
    [HtmlTargetElement("codigoqr")]
    public class MiEtiquetaQRTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var contenido = context.AllAttributes["contenido"].Value.ToString();
            var ancho = context.AllAttributes["ancho"].Value.ToString();
            var alto = context.AllAttributes["alto"].Value.ToString();
            var codigoBarrasDatosPixeles = new ZXing.BarcodeWriterPixelData { 
                Format = ZXing.BarcodeFormat.QR_CODE,
                Options = new ZXing.Common.EncodingOptions { 
                    Height = int.Parse(alto),
                    Width = int.Parse(ancho),
                    Margin = 0
                }
            };
            var datosPixeles = codigoBarrasDatosPixeles.Write(contenido);

            using (var bitmap = new Bitmap(datosPixeles.Width, datosPixeles.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb)) {
                using (var memoriaStream = new MemoryStream()) {
                    var datosBitmap = bitmap.LockBits(new Rectangle(0,0, datosPixeles.Width, datosPixeles.Height), System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
                    try
                    {
                        Marshal.Copy(datosPixeles.Pixels, 0, datosBitmap.Scan0, datosPixeles.Pixels.Length);
                    }
                    finally { 
                        bitmap.UnlockBits(datosBitmap);
                    }
                    bitmap.Save(memoriaStream,ImageFormat.Png);
                    output.TagName = "img"; // <img >
                    output.Attributes.Clear();
                    output.Attributes.Add("width", ancho); // <img width="200">
                    output.Attributes.Add("height", alto); // <img width="200" height="200">
                    output.Attributes.Add("src", String.Format("data:image/png;base64,{0}", Convert.ToBase64String(memoriaStream.ToArray()))); // <img width="200">
                }
            
            }
        }
    }
}
