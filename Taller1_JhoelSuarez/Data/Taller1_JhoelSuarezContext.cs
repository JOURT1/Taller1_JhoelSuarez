using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Taller1_JhoelSuarez.Models;

namespace Taller1_JhoelSuarez.Data
{
    public class Taller1_JhoelSuarezContext : DbContext
    {
        public Taller1_JhoelSuarezContext (DbContextOptions<Taller1_JhoelSuarezContext> options)
            : base(options)
        {
        }

        public DbSet<Taller1_JhoelSuarez.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<Taller1_JhoelSuarez.Models.Estadio> Estadio { get; set; } = default!;
        public DbSet<Taller1_JhoelSuarez.Models.Jugador> Jugador { get; set; } = default!;
    }
}
