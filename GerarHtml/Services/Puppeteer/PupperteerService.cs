using PuppeteerSharp.Media;
using PuppeteerSharp;
using Microsoft.AspNetCore.Mvc;

namespace GerarHtml.Services;

public class PupperteerService : IPupperteerService
{
    private readonly PuppeteerEngineProvider _puppeteerEngineProvider;
    private MemoryStream MemoryStream;

    public PupperteerService(PuppeteerEngineProvider puppeteerEngineProvider)
    {
        _puppeteerEngineProvider = puppeteerEngineProvider;
    }

    public async Task<FileStreamResult?> GeneratePdfFile(string? htmlString)
    {
        await _puppeteerEngineProvider.BrowseInstance();
        if (_puppeteerEngineProvider.Page is not null && htmlString is not null)
        {
            await _puppeteerEngineProvider.Page.SetContentAsync(htmlString);
            await _puppeteerEngineProvider.Page.EvaluateExpressionHandleAsync("document.fonts.ready");
            byte[]? pdfBytes = await _puppeteerEngineProvider.Page.PdfDataAsync(new PdfOptions()
            {
                Format = PaperFormat.A4,
                PrintBackground = true,
                DisplayHeaderFooter = false,
                Landscape = false,
                HeaderTemplate = "<span></span>",
                FooterTemplate = "<span></span>",
                Width = "8.27in",
                Height = "11.69in",
                MarginOptions = new MarginOptions()
                {
                    Top = ".4in",
                    Right = ".4in",
                    Bottom = ".4in",
                    Left = ".4in"
                },
                Scale = 1,
                OmitBackground = false,
                PageRanges = "1-10000",
                PreferCSSPageSize = true,
            });
            // _puppeteerEngineProvider.Browser?.CloseAsync();
            // _puppeteerEngineProvider.Browser?.Dispose();
            // _puppeteerEngineProvider.BrowserFetcher?.Dispose();
            //_puppeteerEngineProvider.Page?.Dispose();
            //_puppeteerEngineProvider.Page = null;
            MemoryStream = new MemoryStream(pdfBytes);
            pdfBytes = null;
            return new FileStreamResult(MemoryStream, "application/pdf");
        }
        return null;
    }
    public PuppeteerEngineProvider Engine
    {
        get { return _puppeteerEngineProvider; }
    }

    public async Task<FileStreamResult?> GeneratePdfFileStream(string? htmlString)
    {
        var fileStreamResult = await GeneratePdfFile(htmlString);
        return fileStreamResult;
    }
}
