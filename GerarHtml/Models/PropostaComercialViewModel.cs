using GerarHtml.Services.Template;

namespace GerarHtml.Models;

public class PropostaComercialViewModel : ITemplate
{
    public string Key { get; set; } = String.Empty;
    public string? LogoUrl { get; set; } = String.Empty;
    public int NumeroDoDocumento { get; set; }
    public Vendedor? Vendedor { get; set; }
    public Integrador? Integrador { get; set; }
    public Comprador? Comprador { get; set; }
    public IEnumerable<Produto>? Itens { get; set; } = Enumerable.Empty<Produto>();
    public Portifolio? Portifolio { get; set; }
    public bool DestacarValorDoServico { get; set; }
    public Decimal? ValorDoServico { get; set; }
    public Decimal? ItemDesconto { get; set; }
    public Decimal? ValorDoDesconto { get; set; }
    public Decimal? ValorTotal { get; set; }
    public Labels? Labels { get; set; }
}









