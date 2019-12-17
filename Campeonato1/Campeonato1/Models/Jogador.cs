using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Campeonato1.Models
{
    public class Jogador
    {
        public int JogadorId { get; set; }
        [Required(ErrorMessage = "Campo obrigatorio não preenchido")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo obrigatorio não preenchido")]

        public int idade { get; set; }
        [Required(ErrorMessage = "Campo obrigatorio não preenchido")]
        public string nacionalidade { get; set; }

    }
}
