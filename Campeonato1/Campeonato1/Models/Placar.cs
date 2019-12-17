using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Campeonato1.Models
{
    public class Placar
    {
        public int PlacarId { get; set; }
        public virtual Jogador jogador { get; set; }
        
        [Required(ErrorMessage ="Campo obrigatorio não preenchido")]
        public int JogadorId {get; set; }

        [Required(ErrorMessage ="Campo obrigatório não prenchido")]
        [Range(0,999999)]
        public float total { get; set; }


        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Campo obrigatório não prenchido")]
        public DateTime data { get; set; }
    }
}
