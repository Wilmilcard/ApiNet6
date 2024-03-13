using Bogus;
using Domain.Models;
using Domain.seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain.DB
{
    public class ApiNet6Context : DbContext
    {
        public ApiNet6Context(DbContextOptions<ApiNet6Context> options) : base(options) { }

        public DbSet<Alquiler> Alquiler { get; set; }
        public DbSet<AlquilerDet> AlquilerDets { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Director> Director { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Juego> Juego { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Plataforma> Plataforma { get; set; }
        public DbSet<PlataformaJuego> PlataformaJuego { get; set; }
        public DbSet<Protagonista> Protagonista { get; set; }
        public DbSet<ProtagonistaJuego> ProtagonistaJuego { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Sesion> Sesions { get; set; }
        public DbSet<LogLogin> LogLogin { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
