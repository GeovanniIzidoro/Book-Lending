using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace EmprestimosDeLivros.Models
{
    public class EmprestimosModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Digite o nome do Recebedor!")]
        public string Recebedor { get; set; }

        [Required(ErrorMessage = "Digite o nome do Fornecedor!")]
        public string Fornecedor { get; set; }

        [Required(ErrorMessage = "Digite o nome do Livro!")]
        public String LivroEmprestado { get; set; }
        public DateTime dataUltimaAtualizacao { get; set; }
    }
}
