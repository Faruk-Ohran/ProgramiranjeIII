using DLWMS.WinForms.P7;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DLWMS.WinForms.IspisIB150051
{
    [Table("StudentiCovidTestovi")]
    public class StudentiCovidTestovi
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public DateTime Datum { get; set; }
        public string Rezultat { get; set; }
        public bool NalazDostavljen { get; set; }
    }
}