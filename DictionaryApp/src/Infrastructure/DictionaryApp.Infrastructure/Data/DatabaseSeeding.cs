using DictionaryApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp.Infrastructure.Data
{
    public static class DatabaseSeeding
    {
        public static void SeedDatabase(DictionaryAppDbContext dbContext)
        {
            SeedUserIfNotExists(dbContext);
            SeedAuthorIfNotExists(dbContext);
            SeedCategoryIfNotExists(dbContext);
            SeedContentIfNotExists(dbContext); 
        }

        private static void SeedUserIfNotExists(DictionaryAppDbContext dbContext)
        {
            if (!dbContext.Users.Any())
            {
                var users = new List<User>()
                {
                    new() {Name="Alp", Surname="Arslan", Email="alparslan@gmail.com", Username="alparslan", Password ="alp123", Role="admin"},
                    new() {Name="Erkan", Surname="Yıldırım", Email="erkan@gmail.com", Username="erkan", Password ="erkan123", Role="admin"},
                };
                dbContext.Users.AddRange(users);
                dbContext.SaveChanges();
            }
        }

        private static void SeedAuthorIfNotExists(DictionaryAppDbContext dbContext)
        {
            if (!dbContext.Authors.Any())
            {
                var authors = new List<Author>()
                {
                    new() { Name = "Mehmet", Surname = "Kılınç",Bio = "24 yaşındayım ve Gaziantepliyim...", Email="mehmetkilinc2734@gmail.com",
                            ImageUrl = "http://c12.incisozluk.com.tr/res/incisozluk//11501/2/1899542_o9c96.jpg"},
                    new() { Name = "Ahmet", Surname = "Karaca",Bio = "24 yaşındayım ve İzmirliyim...", Email="ahmet@gmail.com",
                            ImageUrl = "http://c12.incisozluk.com.tr/res/incisozluk//11501/2/1899542_o9c96.jpg"},
                    new() { Name = "Ozan", Surname = "Demir",Bio = "24 yaşındayım ve İstanbulluyum...", Email="ozan@gmail.com",
                            ImageUrl = "http://c12.incisozluk.com.tr/res/incisozluk//11501/2/1899542_o9c96.jpg"},
                };

                dbContext.Authors.AddRange(authors);
                dbContext.SaveChanges();
            }
        }

        private static void SeedCategoryIfNotExists(DictionaryAppDbContext dbContext)
        {
            if (!dbContext.Categories.Any())
            {
                var categories = new List<Category>()
                {
                    new() { CategoryName = "Sağlık", Description = " Bu Sağlık Kategorisidir."},
                    new() { CategoryName = "Ekonomi", Description = " Bu Ekonomi Kategorisidir."},
                    new() { CategoryName = "Spor", Description = " Bu Spor Kategorisidir."}
                };

                dbContext.Categories.AddRange(categories);
                dbContext.SaveChanges();
            }
        }

        private static void SeedContentIfNotExists(DictionaryAppDbContext dbContext)
        {
            if (!dbContext.Contents.Any())
            {
                var contents = new List<Content>()
                {
                    new() {Title = "Sağlıklı Yaşam Rehberi", Body = " Bu içerikte sağlıklı yaşam ile ilgili bilgiler verilmektedir.", CategoryId = 1, AuthorId = 1},
                    new() {Title = "Ekonomik Özgürlük", Body = " Bu içerikte ekonomik özgürlük ile ilgili bilgiler verilmektedir.", CategoryId = 2, AuthorId =2},
                    new() {Title = "Sporun Faydaları", Body = " Bu içerikte sporun faydaları ile ilgili bilgiler verilmektedir.", CategoryId = 3, AuthorId = 3}
                };

                dbContext.Contents.AddRange(contents);
                dbContext.SaveChanges();
            }
        }
    }
}
