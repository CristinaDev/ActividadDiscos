using ActividadDiscos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ActividadDiscos.DataAccessLayer
{
    public class DiscosDAL : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Disco> Discos { get; set; }
        public DbSet<Interprete> Interpretes { get; set; }
        public DbSet<Puntuacion> Puntuaciones { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<UsuarioGrupo> UsuariosGrupos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Disco>().ToTable("Disco");
            modelBuilder.Entity<Interprete>().ToTable("Interprete");
            modelBuilder.Entity<Puntuacion>().ToTable("Puntuacion");
            modelBuilder.Entity<Usuario>().ToTable("Usuarios");
            modelBuilder.Entity<Grupo>().ToTable("Grupos");
            modelBuilder.Entity<UsuarioGrupo>().ToTable("UsuariosGrupos");

            base.OnModelCreating(modelBuilder);
        }
    }
}