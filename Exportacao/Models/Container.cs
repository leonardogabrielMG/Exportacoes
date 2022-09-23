using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exportacao.Models
{
    [Table("Container")]
    public class Container
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Cliente")]
        [Display(Name = "Cliente")]
        public string Cliente { get; set; }


        [Column("Numero")]
        [Display(Name = "Numero")]
        [RegularExpression(@"^[A-Z]{4}[0-9]{7}$", ErrorMessage = "Formato Inválido!")]
        public string Numero { get; set; }

        [Column("Tipo")]
        [Display(Name = "Tipo")]
        public string Tipo { get; set; }

        [Column("Status")]
        [Display(Name = "Status")]
        public string Status { get; set; }

        [Column("Categoria")]
        [Display(Name = "Categoria")]
        public string Categoria { get; set; }

    }
}
