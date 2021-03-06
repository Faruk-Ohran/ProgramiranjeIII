using DLWMS.WinForms.P11;
using DLWMS.WinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.P7
{
    [Table("Studenti")]
    public class Student
    {
        public int Id { get; set; }
        public string Indeks { get; set; }
        public string Email { get; set; }
        //public Image Slika { get; set; }
        public byte[] Slika { get; set; }

        public int GodinaStudija { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }     
        public bool Aktivan { get; set; }
        //[NotMapped]
        public virtual Spol Spol { get; set; }
        public List<PolozeniPredmet> PolozeniPredmeti { get; set; }

        public virtual ICollection<Uloga> Uloge { get; set; }


        public Student()
        {
            PolozeniPredmeti = new List<PolozeniPredmet>();
            Uloge = new HashSet<Uloga>();
        }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
