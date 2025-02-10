using System;
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
    }
}
