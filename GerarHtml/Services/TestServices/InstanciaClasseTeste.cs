using GerarHtml.Models;

namespace GerarHtml.Services
{
    public class InstanciaClasseTeste
    {
        public PropostaComercialViewModel PropostaComercial { get; set; }
        public InstanciaClasseTeste()
        {
            PropostaComercial = new PropostaComercialViewModel
            {
                Key = "PropostaComercial",
                NumeroDoDocumento = 1234,
                ValorDoServico = new decimal(100.99),
                ItemDesconto = new decimal(200.99),
                ValorDoDesconto = new decimal(1.99),
                ValorTotal = new decimal(1000.00),
                Vendedor = new Vendedor
                {
                    Nome = "Wallace Vidal Vendedor"
                },
                Integrador = new Integrador
                {
                    Codigo = 12,
                    Nome = "Teste Integrador",
                    Email = "integrador@teste.com.br",
                    Documento = "Doc Integrador",
                    EnderecoPorExtenso = "Endereço de teste, 01"
                },
                Comprador = new Comprador
                {
                    Nome = "Comprador Teste",
                    EnderecoPorExtenso = "Rua Zacarias de Alvarenga, 07, Vila Iara, São Gonçalo - RJ",
                    Documento = "21.715.430-1"
                },
                Itens = new List<Produto>
                    {
                        new Produto
                        {
                            Descricao = "Produto 1",
                            Quantidade = 1,
                            Componentes = new List<Produto>
                            {
                                new Produto{ Descricao = "Componente 1", Quantidade = 2},
                                new Produto{ Descricao = "Componente 2", Quantidade = 3},
                            }
                        }
                    },

                Portifolio = new Portifolio
                {
                    Apresentacao = "Apresentacao Teste Portifólio",
                    Itens = new List<PortifolioItem>
                        {
                            new PortifolioItem
                            {
                                Titulo = "Titulo do Item 1",
                                Url = "https://cdn-icons-png.flaticon.com/512/102/102348.png?w=740&t=st=1680195968~exp=1680196568~hmac=960361284ed5658d7edda327d40bf5dc507a604c24702e270a0dc4192ff96624",
                                Subtitulo = "Subtitulo qualquer 1"
                            },
                            new PortifolioItem
                            {
                                Titulo = "Titulo do Item 2",
                                Url = "https://cdn-icons-png.flaticon.com/512/102/102348.png?w=740&t=st=1680195968~exp=1680196568~hmac=960361284ed5658d7edda327d40bf5dc507a604c24702e270a0dc4192ff96624",
                                Subtitulo = "Subtitulo qualquer 2"
                            },
                            new PortifolioItem
                            {
                                Titulo = "Titulo do Item 3",
                                Url = "https://cdn-icons-png.flaticon.com/512/102/102348.png?w=740&t=st=1680195968~exp=1680196568~hmac=960361284ed5658d7edda327d40bf5dc507a604c24702e270a0dc4192ff96624",
                                Subtitulo = "Subtitulo qualquer 3"
                            }
                        },

                },
                Labels = new Labels
                {
                    Garantia = "18 dias dasdddddddddasdsadsadsadsaiduahsdiusahdiuqhawiudhaiudhiuqwhdiuqwhdiuqwhduiqwhdiuqwhdiuqhwiudhqwiudhqwiudhqwiudhqwiudhasiudghauysgdquywdhgqwdhasd",
                    TituloDaAssinatura = "WallVff",
                    SubtituloDaAssinatura = "SubAssinatura",
                    Cidade = "São Gonçalo",
                    Rodape = "Rodapé de Teste",
                    DadosDaEmpresa = "Empresa de teste",
                    EnderecoDaEmpresa = "Rua teste",
                    Site = "wwww"
                }
            };

        }
    }
}
