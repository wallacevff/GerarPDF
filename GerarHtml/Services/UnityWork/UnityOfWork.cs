using GerarHtml.Services.DinkToPdf;
using GerarHtml.Services.Template;

namespace GerarHtml.Services
{
    public class UnityOfWork
    {
        internal readonly ITemplateService _templateService;
       // internal readonly IDinkToPdfService _dinkToPdfService;
        internal readonly IPupperteerService _pupperteerService;

        public UnityOfWork(ITemplateService templateService, IPupperteerService pupperteerService)
        {
            _templateService = templateService;
          //  _dinkToPdfService = dinkToPdfService;
            _pupperteerService = pupperteerService;
        }

        public ITemplateService TemplateService
        {
            get { return _templateService; }
        }

     //   public IDinkToPdfService DinkToPdfService
     //   {
     //       get { return _dinkToPdfService; }
     //   }
        public IPupperteerService PupperteerService
        {
            get { return _pupperteerService; }
        }
    }
}
