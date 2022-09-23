using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Exportacao.Models
{
    [Table("Movimentacao")]
    public class Movimentacao
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Tipo")]
        [Display(Name = "Tipo")]
        public string Tipo { get; set; }


        [Column("Inicio")]
        [Display(Name = "Inicio")]
        [RegularExpression(@"^[0-9]{2}[/][0-9]{2}[/][0-9]{4}[ ][0-9]{2}[:][0-9]{2}$", ErrorMessage = "Formato Inválido!")]
        public string Inicio { get; set; }

        [Column("Fim")]
        [Display(Name = "Fim")]
        [RegularExpression(@"^[0-9]{2}[/][0-9]{2}[/][0-9]{4}[ ][0-9]{2}[:][0-9]{2}$", ErrorMessage = "Formato Inválido!")]
        public string Fim { get; set; }
    }
}
