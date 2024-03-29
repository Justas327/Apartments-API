﻿using System;
using System.Collections.Generic;
using Apartments_API.DTO;

namespace Apartments_API.Models
{
    public partial class Butas
    {
        public Butas()
        {
            Darbas = new HashSet<Darbas>();
            NuomosLaikotarpis = new HashSet<NuomosLaikotarpis>();
            Privalumas = new HashSet<Privalumas>();
            Reitingas = new HashSet<Reitingas>();
            Skundas = new HashSet<Skundas>();
            Busena = 1;
            PridejimoData = DateTime.UtcNow;
        }
        public Butas(ApartmentCreateDto apartmentCreateDto)
        {
            Darbas = new HashSet<Darbas>();
            NuomosLaikotarpis = new HashSet<NuomosLaikotarpis>();
            Privalumas = new HashSet<Privalumas>();
            Reitingas = new HashSet<Reitingas>();
            Skundas = new HashSet<Skundas>();

            Adresas = apartmentCreateDto.Adresas;
            Aprašas = apartmentCreateDto.Aprašas;
            Dydis = apartmentCreateDto.Dydis;
            FkSavininkasidIsNaudotojas = apartmentCreateDto.FkSavininkasidIsNaudotojas;
            KainaUzNakti = apartmentCreateDto.KainaUzNakti;
            KambaruSkaicius = apartmentCreateDto.KambaruSkaicius;
            Miestas = apartmentCreateDto.Miestas;
            NuotraukaUrl = apartmentCreateDto.NuotraukaUrl;
            Pavadinimas = apartmentCreateDto.Pavadinimas;
            Šalis = apartmentCreateDto.Šalis;
            Busena = 1;
            PridejimoData = DateTime.UtcNow;
        }

        public int? Dydis { get; set; }
        public int? KambaruSkaicius { get; set; }
        public DateTime? PridejimoData { get; set; }
        public decimal? KainaUzNakti { get; set; }
        public string Adresas { get; set; }
        public string NuotraukaUrl { get; set; }
        public string Aprašas { get; set; }
        public string Pavadinimas { get; set; }
        public string Miestas { get; set; }
        public string Šalis { get; set; }
        public int? Busena { get; set; }
        public int IdButas { get; set; }
        public int FkSavininkasidIsNaudotojas { get; set; }

        public virtual ButoBusena BusenaNavigation { get; set; }
        public virtual Savininkas FkSavininkasidIsNaudotojasNavigation { get; set; }
        public virtual ICollection<Darbas> Darbas { get; set; }
        public virtual ICollection<NuomosLaikotarpis> NuomosLaikotarpis { get; set; }
        public virtual ICollection<Privalumas> Privalumas { get; set; }
        public virtual ICollection<Reitingas> Reitingas { get; set; }
        public virtual ICollection<Skundas> Skundas { get; set; }
    }
}
