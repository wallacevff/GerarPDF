namespace GerarHtml.Models
{
    public class Integrador
    {
        public int? Codigo { set; get; }
        public string? Nome { set; get; } = String.Empty;
        public string? Email { set; get; } = String.Empty;
        public string? Documento { set; get; } = String.Empty;
        public string? EnderecoPorExtenso { get; set; } = String.Empty;
    }
}
