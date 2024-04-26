namespace GerarHtml.Models
{
    public class Produto
    {
        public string? Descricao { set; get; } = String.Empty;
        public int? Quantidade { set; get; }
        public IEnumerable<Produto>? Componentes { get; set; } = Enumerable.Empty<Produto>();
    }
}
