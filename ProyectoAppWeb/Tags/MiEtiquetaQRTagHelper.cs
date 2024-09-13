using Microsoft.AspNetCore.Razor.TagHelpers;

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
            // Genera la imagen (datos) ... middleware // EF
        }
    }
}
