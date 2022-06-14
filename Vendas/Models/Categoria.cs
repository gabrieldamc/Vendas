namespace Vendas.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public string Descricao { get; set; }

        //Relacionamento de Categoria para Lanche (uma categoria tem muitos lanches)
        public List<Lanche> Lanches { get; set; }

    }
}
