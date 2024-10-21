using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>

    {
        protected override void Seed(BlogContext context)
        {
            List<Category> Kategory = new List<Category>()
            {

                new Category() { KategoriAdi = "C#" },
                new Category() { KategoriAdi = "Asp.nt Mvc" },
                new Category() { KategoriAdi = "Asp.net web form" },
                new Category() { KategoriAdi = "Windows form" },
            };

            foreach (var item in Kategory) { 
            
            context.Kategoriler.Add(item);
            
            }
            context.SaveChanges();


            List<Blog> bloglar = new List<Blog>()
            {
                new Blog() { Baslık = "C# Delegets Hakkında", Acıklama = "C# Delegets Hakkında yapılanlarda sonra yapılmış olu yamlaıdhlxodhoclhvojxpka ", EklemeTarihi = DateTime.Now.AddDays(-10), Anasayfa = true, Onay = true, Icerik = "C# Delegets HakkındaC# Delegets Hakkında", CategoryId = 1 },
                new Blog() { Baslık = ".net  Hakkında", Acıklama = "C# Delegets Hakkında yapılanlarda sonra yapılmış olu yamlaıdhlxodhoclhvojxpka ", EklemeTarihi = DateTime.Now.AddDays(-10), Anasayfa = false, Onay = true, Icerik = "C# Delegets HakkındaC# Delegets Hakkında", CategoryId = 2 },
                new Blog() { Baslık = " Mezuniyet Hakkında", Acıklama = "C# Delegets Hakkında yapılanlarda sonra yapılmış olu yamlaıdhlxodhoclhvojxpka " , EklemeTarihi = DateTime.Now.AddDays(-10), Anasayfa = true, Onay = true, Icerik = "C# Delegets HakkındaC# Delegets Hakkında", CategoryId = 1 },
                new Blog() { Baslık = "İş bulabilme  Hakkında", Acıklama = "C# Delegets Hakkında yapılanlarda sonra yapılmış olu yamlaıdhlxodhoclhvojxpka ", EklemeTarihi = DateTime.Now.AddDays(-10), Anasayfa = true, Onay = true, Icerik = "C# Delegets HakkındaC# Delegets Hakkında", CategoryId = 2 },
                new Blog() { Baslık = "C# Delegets Hakkında", Acıklama = "C# Delegets Hakkında yapılanlarda sonra yapılmış olu yamlaıdhlxodhoclhvojxpka ", EklemeTarihi = DateTime.Now.AddDays(-10), Anasayfa = false, Onay = true, Icerik = "C# Delegets HakkındaC# Delegets Hakkında", CategoryId = 1 }, };
                

            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }

    }
}