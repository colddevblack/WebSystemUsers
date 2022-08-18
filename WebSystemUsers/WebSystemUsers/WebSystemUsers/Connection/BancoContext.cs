using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WebSystemUsers.Models;
using Microsoft.EntityFrameworkCore;using DbContext = Microsoft.EntityFrameworkCore.DbContext;
using System.Reflection.Metadata;

namespace WebSystemUsers.Connection
{
    public class BancoContext : DbContext
    {

        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<UsuarioModel> userdb { get; set; }
        public DbSet<TipoModel> tipodb { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<UsuarioModel>()
                 .HasOne(p => p.tipomodel)
                 .WithMany(b => b.usuarios)
                 .HasForeignKey(p => p.tiposid);



        }
    }
}