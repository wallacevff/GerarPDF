namespace GerarHtml.Models
{
    public class Portifolio
    {
        public string? Apresentacao { set; get; } = String.Empty;
        public IEnumerable<PortifolioItem>? Itens { set; get; } = Enumerable.Empty<PortifolioItem>();
        public string? Documento { get; set; } = String.Empty;
    }
}
