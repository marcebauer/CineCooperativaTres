using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CooperativaTres.Models;

namespace CooperativaTres.Context
{
    public class CineDatabaseContext : DbContext
    {
        public CineDatabaseContext(DbContextOptions<CineDatabaseContext> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Funcion> Funciones { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Asiento> Asientos { get; set; }
        public DbSet<Entrada> Entradas { get; set; }
    }
}
