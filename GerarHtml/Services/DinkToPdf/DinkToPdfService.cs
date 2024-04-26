using DinkToPdf;

namespace GerarHtml.Services.DinkToPdf;

public class DinkToPdfService : IDinkToPdfService
{
    private readonly DinkToPdfEngineProvider _engineProvider;

    public DinkToPdfService(DinkToPdfEngineProvider engineProvider)
    {
        _engineProvider = engineProvider;
    }



    public byte[] ConvertToPdf(string htmlContent)
    {

        var doc = new HtmlToPdfDocument()
        {
            GlobalSettings = {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                //Outline = false
               // Margins = new MarginSettings() { Top = 10, Bottom = 10, Left = 10, Right = 10 },
                // Out = @"test.pdf",
            },
            Objects =
                {
                    new ObjectSettings
                    {
                        HtmlContent = htmlContent,
                        WebSettings = new WebSettings(),
                        UseLocalLinks = true,
                       // IncludeInOutline = false,
                        

                    },
                }
        };
        //Console.WriteLine(converter.Convert(doc)); 
        byte[] pdf = _engineProvider.Converter.Convert(doc);
        return pdf;
    }

}
