﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Inlock.Codefirst_Manha.Domains
{
    [Table("Usuario")]
    [Index(nameof(Email), IsUnique=true)]//Cria um indice unico para
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; }

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage ="Email obrigatorio")]
        public string Email { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Senha obrigatorio")]
        [StringLength(20, MinimumLength =6, ErrorMessage ="Senha deve conter de 6 a 20 caracteres")]
        public string Senha { get; set; }


        //Referencia da chave estrangeira (Tabela de estudio)

        [Required(ErrorMessage ="Tipo de usuario obrigatorio")]
        public Guid IdTipoUsuario { get; set; }

        [ForeignKey("IdTipoUsuario")]
        public TipoUsuario tipoUsuario { get; set; }
    }
}
 