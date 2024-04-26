using Microsoft.AspNetCore.Mvc;

namespace GerarHtml.Services
{
    public interface IPupperteerService
    {
        public Task<FileStreamResult?> GeneratePdfFileStream(string? htmlString);
        public PuppeteerEngineProvider Engine { get; }
    }
}
