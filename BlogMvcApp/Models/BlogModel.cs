using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogModel
    {
        public int Id { get; set; }
        public string Baslık { get; set; }
        public string Acıklama { get; set; }
      
        public DateTime EklemeTarihi { get; set; }
        public bool Onay { get; set; }
        public bool Anasayfa { get; set; }

    }
}