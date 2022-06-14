using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vendas.Models
{    
    public class Lanche
    {
        [Key]        
        public int LancheId { get; set; }
        [StringLength(80,MinimumLength =10, ErrorMessage = "O tamanho máximo é 80 caracteres")]
        [Required(ErrorMessage = "Informe o nome do lanche deve ser informado")]
        [Display(Name = "Nome do Lanche")]
        public string Nome { get; set; }
        [StringLength(200, MinimumLength = 10, ErrorMessage = "minimo de 10 maximo de 200")]
        [Required(ErrorMessage = "Descrição deve ter no mínimo 10 caracteres")]
        [Display(Name = "Descrição do Lanche")]
        public string DescricaoCurta { get; set; }
        [StringLength(200, MinimumLength = 20, ErrorMessage = "minimo de 20 maximo de 200")]
        [Required(ErrorMessage = "Descrição deve ter no mínimo 20 caracteres")]
        [Display(Name = "Descrição detalhada do Lanche")]
        public string DescricaoDetalhada { get; set; }
        [Required(ErrorMessage = "Informe o preço")]
        [Display(Name = "Preço")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1,999.99,ErrorMessage ="Preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }
        [StringLength(200, ErrorMessage = "maximo de 200 caract")]       
        [Display(Name = "Caminho imagem")]
        public string ImagemUrl { get; set; }
        [StringLength(200, ErrorMessage = "maximo de 200 caract")]
        [Display(Name = "Caminho imagem miniatura")]
        public string ImagemThumbnailUrl { get; set; }
        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }
        [Display(Name = "Em estoque?")]
        public bool EmEstoque { get; set; }

        //Relacionamento de Lanche para Categoria
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
