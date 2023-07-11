using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Drawing;
using ZXing.QrCode;

namespace Clase_asp_net.Tags
{
    [HtmlTargetElement("codigoqr")]
    public class CodigoQRTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var contenido = context.AllAttributes["contenido"].Value.ToString();
            var ancho = context.AllAttributes["ancho"].Value.ToString();
            var alto = context.AllAttributes["alto"].Value.ToString();
            var writerDatosPixel = new ZXing.BarcodeWriterPixelData {
                Format = ZXing.BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions {
                    Height = int.Parse(alto),
                    Width = int.Parse(ancho),
                    Margin = 0
                }
            };
            var datosPixel = writerDatosPixel.Write(contenido);
            using (var bitmap = new Bitmap(datosPixel.Width, datosPixel.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb)) {
                using (var memoryStream = new MemoryStream()) {
                    var datosBitmap = bitmap.LockBits(
                        new Rectangle(0, 0, datosPixel.Width, datosPixel.Height),
                            System.Drawing.Imaging.ImageLockMode.WriteOnly,
                            System.Drawing.Imaging.PixelFormat.Format32bppRgb
                    );
                    try
                    {
                        System.Runtime.InteropServices.Marshal.Copy(datosPixel.Pixels, 0, datosBitmap.Scan0, datosPixel.Pixels.Length);
                    }
                    finally {
                        bitmap.UnlockBits(datosBitmap);
                    }
                    bitmap.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                    output.TagName = "img";// <img>
                    output.Attributes.Clear();
                    output.Attributes.Add("width", int.Parse(ancho));// <img width = >
                    output.Attributes.Add("height", int.Parse(alto));// <img width =  height = >
                    output.Attributes.Add("src", string.Format("data:image/png;base64,{0}", Convert.ToBase64String(memoryStream.ToArray())));
                }
            }
        }
    }
}
