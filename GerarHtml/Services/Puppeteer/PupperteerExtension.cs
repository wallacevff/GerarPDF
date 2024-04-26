namespace GerarHtml.Services.PuppeteerExt;

public static class PupperteerExtension
{
    public static void AddPupperteer(this IServiceCollection services)
    {
        PuppeteerEngineProvider puppeteerEngine = new PuppeteerEngineProvider();
        services.AddSingleton(puppeteerEngine);
    }
}
