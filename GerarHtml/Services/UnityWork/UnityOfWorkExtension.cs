using GerarHtml.Services.RazorLight;
//using GerarHtml.Services.DinkToPdf;
using GerarHtml.Services.PuppeteerExt;
using GerarHtml.Services.Template;
namespace GerarHtml.Services.UnityWork
{
    public static class UnityOfWorkExtension
    {
        public static void AddUnityOfWork(this IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddRazorLight();
            services.AddSingleton<ITemplateService, TemplateService>();
           // service.AddDinkToPdf();
           // service.AddSingleton<IDinkToPdfService, DinkToPdfService>();
            services.AddPupperteer();
            services.AddSingleton<IPupperteerService, PupperteerService>();
            services.AddSingleton<UnityOfWork>();
    
        }
    }
}
