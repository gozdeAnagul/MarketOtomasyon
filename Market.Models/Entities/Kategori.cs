﻿using Market.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Models.Entities
{
    [Table("Kategoriler")]
    public class Kategori : BaseEntity<int>
    {
        //public Kategori()
        //{
        //    Id = Guid.NewGuid();
        //}

        [StringLength(50)]
        [Required]
        public string KategoriAdi { get; set; }

        [StringLength(50)]
        public string Aciklama { get; set; }

        [Required]
        public double Kdv { get; set; }

        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;

        public Guid? UstKategoriId { get; set; }

        [ForeignKey("UstKategoriId")]
        public virtual Kategori UstKategori { get; set; }

        public virtual ICollection<Kategori> Kategoriler { get; set; } = new HashSet<Kategori>();
        public virtual ICollection<Urun> Urunler { get; set; } = new HashSet<Urun>();


    }
}
