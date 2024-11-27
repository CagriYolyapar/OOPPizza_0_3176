using OOPPizza_0.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPizza_0.Models
{
    public class Siparis : BaseEntity
    {
        public Siparis(string ad)
        {
            Ad = ad;
            Malzemeleri = new List<EkstraMalzeme>();
        }

        public int Adet { get; set; }

        public List<EkstraMalzeme> Malzemeleri { get; set; }

        public Boyut Buyuklugu { get; set; }

        public Pizza SecilenPizza { get; set; }

        public Icecek Icecek { get; set; }

        public void TutarHesapla()
        {
            Fiyat = SecilenPizza.Fiyat;
            
            if(Icecek != null) Fiyat += Icecek.Fiyat;

            switch (Buyuklugu)
            {
                case Boyut.Buyuk:
                    Fiyat += 2;
                    break;
                case Boyut.Orta:
                    Fiyat += 1;
                    break;
                
            }

            foreach (EkstraMalzeme item in Malzemeleri)
            {
                Fiyat += item.Fiyat;
            }

            Fiyat *= Adet;

            



        }

        public override string ToString()
        {
            string sonuc = $"{Ad} ismine, {SecilenPizza.Ad}, {Buyuklugu}, Adet: {Adet}, Fiyatı: {Fiyat:C2} ";

            if (Icecek != null) sonuc += $"İcecek: {Icecek.Ad} ";

            if(Malzemeleri.Count > 0)
            {
                sonuc += $"Malzemeleri: (";
                foreach (EkstraMalzeme item in Malzemeleri)
                {
                    sonuc += $"{item.Ad},";
                }
                sonuc = sonuc.TrimEnd(',');
                sonuc += ")";
            }

            return sonuc;

            
        }
    }
}
