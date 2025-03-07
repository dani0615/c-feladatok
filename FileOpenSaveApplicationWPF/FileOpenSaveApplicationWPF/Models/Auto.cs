﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOpenSaveApplicationWPF.Models
{
    class Auto
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Tipus { get; set; }
        public string Szin { get; set; }
        public int Evjarat { get; set; }
        public DateOnly Muszaki { get; set; }
        public bool Aktiv { get; set; }
        
       


        public Auto (string sor)
        {
            string[] adatok = sor.Split(';');
            Id = int.Parse(adatok[0]);
            Marka = adatok[1];
            Tipus = adatok[2];
            Szin = adatok[3];
            Evjarat = int.Parse(adatok[4]);
            Muszaki = DateOnly.Parse(adatok[5]);
            Aktiv = bool.Parse(adatok[6]);
           
        }
        public override string ToString()
        {
            return $"{Id}: ; {Marka}: ; {Tipus}: ";
        }
    }
}
