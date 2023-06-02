using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Blog.Models
{
    public class DataInitializer :DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {

            var kategori = new List<Kategori>()
            {
                new Kategori(){KategoriAd="English"},
                new Kategori(){KategoriAd="C#"},
                new Kategori(){KategoriAd="PHP"}
            };
            foreach (var item in kategori)
            {
                context.Kategoris.Add(item);
            }
            context.SaveChanges();
            var makale = new List<Makale>
            {
                new Makale() {Baslik="IELTS Nedir? Nasıl Hazırlanılır?",
                    Acıklama="İngilizce açılımı “International English Language Testing System” olan IELTS, dünyada 135 ülkede yaklaşık 8000 kurum tarafından tanınan uluslararası bir İngilizce dil becerileri ölçüm sınavıdır. ELTS, genel anlamda katılımcıların İngilizce’de hem yazılı hem sözlü dil becerilerini ölçtüğü ve her bölüm ayrı ayrı puanlandığı için, sınavda yer alan her bölüme oldukça titiz ve dikkatli bir hazırlık süreci geçirmek çok önemlidir.",
                    YayinTarih=Convert.ToDateTime("2023-04-29"),Goruntulenme=0,Onay=true,KategoriId=1,KullanıcıAd="Hilal Depe"},
                new Makale() {Baslik="C# dilininin tasarımındaki başlıca hedefler",
                    Acıklama="Basit, modern, her tür kullanım amacına uygun ve nesne yönelimli bir dil olması,Güçlü tipleme kontrolü, dizin sınırları kontrolü ve tanımlanmış değişkenlerin kullanım tespiti gibi özellikler barındırması,Programcı portatifliğine sahip olması,Sunucu ve gömülü sistemler için tasarlanmış olması,C, C++ ve Java dilini kullananların rahatlıkla alışabilecekleri şekilde tasarlanmış olması.",
                    YayinTarih=Convert.ToDateTime("2023-05-12"),Goruntulenme=0,Onay=true,KategoriId=2,KullanıcıAd="Hilal Depe"},
                new Makale() {Baslik="PHP Neden Kullanılmalıdır?",
                    Acıklama="Günümüzde web sitelerini daha dinamik bir görünüme kavuşturmak amacıyla etkin bir biçimde kullanılan PHP, Arayüz tasarımı ( Front-End) ,HTML, CSS, JavaScript dillerinin veritabanına bağlanması ve çalışır hale gelmesi, Yönetici arayüz aracılığı sayesinde web sitelerinin daha dinamik bir hale dönüştürülmesini mümkün kılmaktadır.",
                    YayinTarih=Convert.ToDateTime("2023-04-29"),Goruntulenme=0,Onay=true,KategoriId=3,KullanıcıAd="Hilal Depe"}
            };
            foreach (var item in makale)
            {
                context.Makales.Add(item);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}