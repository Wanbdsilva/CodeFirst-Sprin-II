using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Inlock.Codefirst_Manha.Domains
{
    [Table("TipoUsuario")]
    public class TipoUsuario
    {
        [Key]
        public Guid IdTipoUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage ="Titulo do usuario obrigatorio!")]
        public string Titulo { get; set; }
    }
}
