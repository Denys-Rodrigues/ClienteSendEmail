using System.ComponentModel.DataAnnotations;

namespace ClienteSendEmail.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Email { get; set; }

        public string Logradouro { get; set; }

        public int NumeroCasa { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }
    }
}
