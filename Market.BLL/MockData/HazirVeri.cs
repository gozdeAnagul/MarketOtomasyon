using Market.BLL.Repository;
using Market.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.BLL.HazırVeri
{
    public class HazirVeri
    {

        public void VeriUret()
        {
            if (new KategoriRepo().GetAll().Any()  || new UrunRepo().GetAll().Any() )
            {
                return;
            }

            KategoriUret();
            UrunUret();
        }
        private void UrunUret()
        {
            Random rnd = new Random();
            Urun urun = null;
            try
            {
                for (int i=0;i<9;i++)
                {
                    switch (i)
                    {
                        case 0:
                            urun = new Urun()
                            {
                                KategoriId = 1,
                                UrunAdi = "Gofret",
                                Aciklama = "Çikolatalı",
                                KoliIciAdet = 20,
                                Kdv = (decimal)0.10,
                                KoliBarkod = Convert.ToString(rnd.Next(1000000, 9999999)),
                                UrunBarkod = Convert.ToString(rnd.Next(10000000, 99999999)),
                                AlisFiyat = 0.5m,
                            };
                            break;
                        case 1:
                            urun = new Urun()
                            {
                                KategoriId = 1,
                                UrunAdi = "Albeni",
                                Aciklama = "Çikolatalı",
                                KoliIciAdet = 40,
                                Kdv = (decimal)0.09,
                                KoliBarkod = Convert.ToString(rnd.Next(1000000, 9999999)),
                                UrunBarkod = Convert.ToString(rnd.Next(10000000, 99999999)),
                                AlisFiyat = 1m,
                            };
                            break;
                        case 2:
                            urun = new Urun()
                            {
                                KategoriId = 1,
                                UrunAdi = "Tutku",
                                Aciklama = "Çikolatalı",
                                KoliIciAdet = 20,
                                Kdv = (decimal)0.15,
                                KoliBarkod = Convert.ToString(rnd.Next(1000000, 9999999)),
                                UrunBarkod = Convert.ToString(rnd.Next(10000000, 99999999)),
                                AlisFiyat = 1.5m,
                            };
                            break;
                        case 3:
                            urun = new Urun()
                            {
                                KategoriId = 3,
                                UrunAdi = "Sarj Kablosu",
                                Aciklama = "Samsung-Iphone",
                                KoliIciAdet = 40,
                                Kdv = (decimal)0.11,
                                KoliBarkod = Convert.ToString(rnd.Next(1000000, 9999999)),
                                UrunBarkod = Convert.ToString(rnd.Next(10000000, 99999999)),
                                AlisFiyat = 10m,
                            };
                            break;
                        case 4:
                            urun = new Urun()
                            {
                                KategoriId = 3,
                                UrunAdi = "Priz",
                                Aciklama = "3 Lü-5 li",
                                KoliIciAdet = 20,
                                Kdv = (decimal)0.10,
                                KoliBarkod = Convert.ToString(rnd.Next(1000000, 9999999)),
                                UrunBarkod = Convert.ToString(rnd.Next(10000000, 99999999)),
                                AlisFiyat = 8m,
                            };
                            break;
                        case 5:
                            urun = new Urun()
                            {
                                KategoriId = 2,
                                UrunAdi = "Bulaşık Süngeri",
                                Aciklama = "5 Paket",
                                KoliIciAdet = 20,
                                Kdv = (decimal)0.10,
                                KoliBarkod = Convert.ToString(rnd.Next(1000000, 9999999)),
                                UrunBarkod = Convert.ToString(rnd.Next(10000000, 99999999)),
                                AlisFiyat = 0.5m,
                            };
                            break;
                        case 6:
                            urun = new Urun()
                            {
                                KategoriId = 2,
                                UrunAdi = "Temizlik Bezi",
                                Aciklama = "Sarı Renkli",
                                KoliIciAdet = 20,
                                Kdv = (decimal)0.10,
                                KoliBarkod = Convert.ToString(rnd.Next(1000000, 9999999)),
                                UrunBarkod = Convert.ToString(rnd.Next(10000000, 99999999)),
                                AlisFiyat = 1m,
                            };
                            break;
                        case 7:
                            urun = new Urun()
                            {
                                KategoriId = 4,
                                UrunAdi = "Su",
                                Aciklama = "0,5 litre",
                                KoliIciAdet = 20,
                                Kdv = (decimal)0.10,
                                KoliBarkod = Convert.ToString(rnd.Next(1000000, 9999999)),
                                UrunBarkod = Convert.ToString(rnd.Next(10000000, 99999999)),
                                AlisFiyat = 0.3m,
                            };
                            break;
                        case 8:
                            urun = new Urun()
                            {
                                KategoriId = 4,
                                UrunAdi = "Su 1litre",
                                Aciklama = "1 litre",
                                KoliIciAdet = 20,
                                Kdv = (decimal)0.10,
                                KoliBarkod = Convert.ToString(rnd.Next(1000000, 9999999)),
                                UrunBarkod = Convert.ToString(rnd.Next(10000000, 99999999)),
                                AlisFiyat = 1m,
                            };
                            break;
                        //case 9:
                        //    urun = new Urun()
                        //    {
                        //        KategoriId = 5,
                        //        UrunAdi = "Büyük",
                        //        Aciklama = " ",
                        //        KoliIciAdet = 20,
                        //        Kdv = 0,
                        //        KoliBarkod = Convert.ToString(rnd.Next(1000000, 9999999)),
                        //        UrunBarkod = Convert.ToString(rnd.Next(10000000, 99999999)),
                        //        AlisFiyat = (decimal)(0.29),
                        //    };
                        //    break;
                        //case 10:
                        //    urun = new Urun()
                        //    {
                        //        KategoriId = 5,
                        //        UrunAdi = "Küçük",
                        //        Aciklama = " ",
                        //        KoliIciAdet = 20,
                        //        Kdv = 0,
                        //        KoliBarkod = Convert.ToString(rnd.Next(1000000, 9999999)),
                        //        UrunBarkod = Convert.ToString(rnd.Next(10000000, 99999999)),
                        //        AlisFiyat = (decimal)(0.19),
                        //    };
                        //    break;
                        default:
                            break;
                    }
                    new UrunRepo().Insert(urun);
                }
            }
            catch (Exception ex)
            {
                throw ex ;
               
            }
        }

        private void KategoriUret()
        {
            Kategori kategori = null;
            try
            {
                for (int i = 0; i < 4; i++)
                {
                    switch (i)
                    {
                        case 0:
                            kategori = new Kategori()
                            {
                                KategoriAdi = "Çikolatalı Ürünler",
                                Aciklama = "Çikolatalı Ürünler"
                            };
                            break;
                        case 1:
                            kategori = new Kategori()
                            {
                                KategoriAdi = "Temizlik Ürünleri",
                                Aciklama = "dgbvsdfvsıd"
                            };
                            break;
                        case 2:
                            kategori = new Kategori()
                            {
                                KategoriAdi = "Elektronik",
                                Aciklama = "elektronik ürünleri"
                            };
                            break;
                        case 3:
                            kategori = new Kategori()
                            {
                                KategoriAdi = "İçecekler",
                                Aciklama = "Gazlı Gazsız İçecekler"
                            };
                            break;
                        //case 4:
                        //    kategori = new Kategori()
                        //    {
                        //        KategoriAdi = "Poşet",
                        //        Aciklama = "Büyük - Küçük Boy"
                        //    };
                        //    break;
                        default:
                            break;
                    }
                    new KategoriRepo().Insert(kategori);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
