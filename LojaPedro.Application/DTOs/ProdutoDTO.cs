using LojaPedro.Domain;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaPedro.Application.DTOs
{
    public class ProdutoDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Descrição é obrigatório")]
        [MinLength(5)]
        [MaxLength(200)]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Preço é obrigatório")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [DataType(DataType.Currency)]
        [DisplayName("Preço")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Estoque é obrigatório")]
        [Range(1,9999)]
        public int Estoque { get; set; }

        [MaxLength(250)]
        public string Imagem { get; set; }

        [DisplayName("Categoria")]
        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }
    }
}
