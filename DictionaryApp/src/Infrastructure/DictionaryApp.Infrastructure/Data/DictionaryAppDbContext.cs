using DictionaryApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.Infrastructure.Data
{
    public class DictionaryAppDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<User> Users { get; set; }

        public DictionaryAppDbContext(DbContextOptions<DictionaryAppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // For Author
            modelBuilder.Entity<Author>().HasKey(a => a.Id);
            modelBuilder.Entity<Author>().Property(a => a.Name).IsRequired().HasMaxLength(25);
            modelBuilder.Entity<Author>().Property(a => a.Surname).IsRequired().HasMaxLength(25);
            modelBuilder.Entity<Author>().Property(a => a.Email).HasMaxLength(50);
            modelBuilder.Entity<Author>().Property(a => a.Bio).HasMaxLength(500);
            modelBuilder.Entity<Author>().Property(a => a.ImageUrl).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Author>().HasMany(a => a.Contents).WithOne(c => c.Author).HasForeignKey(c => c.AuthorId);

            // For Category
            modelBuilder.Entity<Category>().HasKey(c => c.Id);
            modelBuilder.Entity<Category>().Property(c => c.CategoryName).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<Category>().Property(c => c.Description).HasMaxLength(500);
            modelBuilder.Entity<Category>().HasMany(c => c.Contents).WithOne(c => c.Category).HasForeignKey(c => c.CategoryId);

            // For Content
            modelBuilder.Entity<Content>().HasKey(c => c.Id);
            modelBuilder.Entity<Content>().Property(c => c.Title).IsRequired().HasMaxLength(75);
            modelBuilder.Entity<Content>().Property(c => c.Body).IsRequired();

            // For User
            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<User>().Property(u => u.Name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<User>().Property(u => u.Surname).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<User>().Property(u => u.Email).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<User>().Property(u => u.Username).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<User>().Property(u => u.Password).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<User>().Property(u => u.Role).IsRequired();
        }
    }
}
