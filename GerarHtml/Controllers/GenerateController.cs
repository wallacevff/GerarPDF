using GerarHtml.Models;
using Microsoft.AspNetCore.Mvc;
using GerarHtml.Services;

namespace GerarHtml.Controllers
{
    [ApiController]
    public class GenerateController : ControllerBase
    {

        internal readonly UnityOfWork _unityOfWork;

        public GenerateController(UnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }
        [HttpGet("htmlTest")]
        public async Task<ActionResult> GetHtmlTest()
        {
            PropostaComercialViewModel propostaView = new InstanciaClasseTeste().PropostaComercial;
            string? result = await _unityOfWork.TemplateService.Parse(propostaView);
            GC.Collect();
            return new ContentResult()
            {
                ContentType = "text/html",
                Content = result,
            };

        }

        [HttpGet("pdfTest")]
        public async Task<ActionResult?> GetPdfTest()
        {
            var result = await _unityOfWork.TemplateService.Parse(
                    new InstanciaClasseTeste().PropostaComercial
                );
            return await _unityOfWork.PupperteerService.GeneratePdfFileStream(result);
        }

        [HttpGet("htmlUsingJson")]
        public async Task<ActionResult> GetHtml([FromBody] PropostaComercialViewModel propostaComercialViewModel)
        {
            var result = await _unityOfWork.TemplateService.Parse(propostaComercialViewModel);
            GC.Collect();
            return new ContentResult()
            {
                ContentType = "text/html",
                Content = result,
            };

        }


        [HttpPost("pdfUsingJson")]
        public async Task<ActionResult?> GetPdf([FromBody] PropostaComercialViewModel propostaComercialViewModel)
        {
            var result = await _unityOfWork.TemplateService.Parse(
                    propostaComercialViewModel
                );
            FileStreamResult? fileStreamResult = await _unityOfWork.PupperteerService.GeneratePdfFileStream(result);
            GC.Collect();
            return fileStreamResult;

        }
        [HttpPost("pdfFromHTML")]
        public async Task<ActionResult?> GetPdfFromHtml([FromBody] Data htmlString)
        {
            var steamPdf = await _unityOfWork.PupperteerService.GeneratePdfFileStream(htmlString.Html);
            //_unityOfWork.PupperteerService.Engine.Browser?.Process.Close();
            //_unityOfWork.PupperteerService.Engine.Browser?.CloseAsync();
            GC.Collect();
            return steamPdf;
        }
    }
}
