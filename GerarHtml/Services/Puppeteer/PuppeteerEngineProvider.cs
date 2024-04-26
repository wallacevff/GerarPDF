using PuppeteerSharp;
using PuppeteerSharp.Media;

namespace GerarHtml.Services;

public class PuppeteerEngineProvider
{
    public IBrowser? Browser { get; set; }
    public IBrowserFetcher BrowserFetcher { get; set; }
    public IPage? Page { get; set; } = null;

    public PuppeteerEngineProvider()
    {
        BrowserFetcher = new BrowserFetcher();
    }
    public async Task BrowseInstance()
    {
        try
        {
            await LoadPage();
        }
        catch
        {
            await BrowserFetcher.DownloadAsync();
            await LoadPage();
        }

    }
    private async Task LoadPage()
    {
        if (Page is null)
        {
            Browser = await Puppeteer.LaunchAsync(
                new LaunchOptions
                {
                    Args = new string[] {
                        "--no-sandbox",
                        //"--disable-setuid-sandbox",
                        "--single-process",
                        //"--ignore-certificate-errors",
                       // "--no-zygote"
                    },
                    Headless = true
                }
            );

            Page = await Browser.NewPageAsync();
        }

    }
}

