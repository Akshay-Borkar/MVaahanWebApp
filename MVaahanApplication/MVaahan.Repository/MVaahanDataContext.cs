using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Text;
using MVaahan.DomainEntities.Admin;

namespace MVaahan.Repository
{
    public class MVaahanDataContext: DbContext
    {
        private string _connectionString;
        public MVaahanDataContext(string connectionString) {
            _connectionString = connectionString;
        }
        public MVaahanDataContext(DbContextOptions<MVaahanDataContext> options) : base(options)
        {

        }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseMySql(_connectionString);
        }

        protected void OnMedelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.City).HasColumnType("longtext");

                entity.Property(e => e.Country).HasColumnType("longtext");

                entity.Property(e => e.Gender).HasColumnType("longtext");

                entity.Property(e => e.State).HasColumnType("longtext");

                entity.Property(e => e.UserName).HasColumnType("longtext");
            });
        }
    }
}
