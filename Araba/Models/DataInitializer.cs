using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Araba.Models
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var sehirler = new List<Sehir>()
            {
                new Sehir() {SehirAd="İstanbul"},
                new Sehir() {SehirAd="Ankara"},
                new Sehir() {SehirAd="İzmir"},
                new Sehir() {SehirAd="Şanlıurfa"}
            };
            foreach (var item in sehirler)
            {
                context.Sehirs.Add(item);
            }
            context.SaveChanges();
            var durum = new List<Durum>()
            {
                new Durum() {DurumAd="Kiralık"},
                new Durum() {DurumAd="Satılık"}
            };
            foreach (var item in durum)
            {
                context.Durums.Add(item);
            }
            context.SaveChanges();
            var marka = new List<Marka>()
            {
                new Marka() {MarkaAd="Audi"},
                new Marka() {MarkaAd="Mercedes"}
            };
            foreach (var item in marka)
            {
                context.Markas.Add(item);
            }
            context.SaveChanges();
            var model = new List<Model>()
            {
                new Model() {ModelAd="A5 Sportback 1.4 TFSI Sport ", MarkaId=1},
                new Model() {ModelAd="E250 CDI AMG " , MarkaId=2}
            };
            foreach (var item in model)
            {
                context.Models.Add(item);
            }
            context.SaveChanges();
            var ilan = new List<Ilan>()
            {
                new Ilan() {MarkaId=1, Aciklama="Deri döşeme ve yedek anahtar mevcuttur", IlanNo=126, Fiyat=522000, Tarih="01/06/2021", Kilometre=101000, ModelYili=2017, YakitTuru="Benzin", VitesTuru="Yarı Otomatik", DurumId=2, ModelId=1, SehirId=1, Telefon="4356987776" },
                new Ilan() {MarkaId=2, Aciklama="Otomatik park sistemi mevcuttur", IlanNo=147, Fiyat=629000, Tarih="03/05/2021", Kilometre=68000, ModelYili=2013, YakitTuru="Dizel", VitesTuru="Otomatik", DurumId=2, ModelId=2, SehirId=2, Telefon="7896523569" }
            };
            foreach (var item in ilan)
            {
                context.Ilans.Add(item);
            }
            context.SaveChanges();
            var resim = new List<Resim>()
            {
                new Resim() {ResimAd="audi-a5-sportback.png", IlanId=1 },
                new Resim() {ResimAd="a5-on.jpg", IlanId=1 },
                new Resim() {ResimAd="a5-arka.jpg" , IlanId=1 },

                new Resim() {ResimAd="mercedes-benz-e250.jpg", IlanId=2 },
                new Resim() {ResimAd="e250-arka.jpg", IlanId=2 }
            };
            foreach (var item in resim)
            {
                context.Resims.Add(item);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}