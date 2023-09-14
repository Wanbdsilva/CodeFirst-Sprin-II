using System;
using System.Collections.Generic;

namespace WebApi.Inlock_games_dbFirst_manha.Domains;

public partial class Estudio
{
    public Guid IdEstudio { get; set; } = Guid.NewGuid();

    public string Nome { get; set; } = null!;

    public virtual ICollection<Jogo> Jogos { get; set; } = new List<Jogo>();
}
