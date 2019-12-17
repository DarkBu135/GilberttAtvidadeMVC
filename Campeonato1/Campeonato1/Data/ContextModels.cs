using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Campeonato1.Models;


namespace Campeonato1.Data
{
    public class ContextModels : DbContext
    {
        public ContextModels(DbContextOptions<ContextModels> options) : base(options)
        {

        }

        public DbSet<Jogador> jogadores { get; set; }
        public DbSet<Placar> placares { get; set; }

    }
}
