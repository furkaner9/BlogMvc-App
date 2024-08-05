using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Baslık { get; set; }
        public string Acıklama { get; set; }
        public string Icerik { get; set; }
        public DateTime EklemeTarihi { get; set; }
        public bool Onay { get; set; }
        public bool Anasayfa { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}