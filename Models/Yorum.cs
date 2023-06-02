using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Yorum
    {
        public int Id { get; set; }
        public string Acıklama { get; set; }
        public string KullanıcıId { get; set; }
        public DateTime Tarih { get; set; }
        public float Puan { get; set; }
        public int MakaleId { get; set; }
        public virtual Makale Makale { get; set; }
        

    }
}