using DLWMS.WinForms.P10;
using DLWMS.WinForms.P11;
using DLWMS.WinForms.P7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DLWMS.WinForms.IspisIB150051
{
    public partial class frmCovidTest : Form
    {
        KonekcijaNaBazu _db = DLWMSdb.Baza;

        public frmCovidTest()
        {
            InitializeComponent();
            dgvRezultatiCovidTestiranja.AutoGenerateColumns = false;
        }

        private void frmCovidTest_Load(object sender, EventArgs e)
        {
            UcitajStudenteComboBox();
            CustomDateFormat();
            UcitajRezulateCovidTestiranja();
        }

        private void UcitajRezulateCovidTestiranja()
        {
            dgvRezultatiCovidTestiranja.DataSource = null;
            var studentiTestovi = _db.StudentiCovidTestovi.ToList();
            dgvRezultatiCovidTestiranja.DataSource = studentiTestovi;
            if (studentiTestovi.Count == 0)
            {
                lblBrojtestova.Text = "0";
            }
            else
            {
                lblBrojtestova.Text = studentiTestovi.Count.ToString();
            }
        }

        private void UcitajStudenteComboBox()
        {
            cbStudent.Items.AddRange(_db.Studenti.ToArray());
            cbStudent.SelectedItem = cbStudent.Items[0];
        }

        private void CustomDateFormat()
        {
            dtpDatumTestiranja.Format = DateTimePickerFormat.Custom;
            dtpDatumTestiranja.CustomFormat = "ddd dd MMM yyyy";
        }

        private void btnDodajTest_Click(object sender, EventArgs e)
        {
            if (TestDodanNaOdabraniDatum(cbStudent.SelectedItem as Student, dtpDatumTestiranja.Value))
            {
                MessageBox.Show("Test na odabrani datum je vec dodan!");
            }
            else
            {
                var noviTest = new StudentiCovidTestovi
                {
                    Student = cbStudent.SelectedItem as Student,
                    Datum = dtpDatumTestiranja.Value,
                    Rezultat = cbRezultatTesta.SelectedItem.ToString(),
                    NalazDostavljen = checkbNalazDostavljen.Checked
                };

                _db.StudentiCovidTestovi.Add(noviTest);
                _db.SaveChanges();
                MessageBox.Show("Test uspjesno dodan!");
                UcitajRezulateCovidTestiranja();
            }
        }

        private bool TestDodanNaOdabraniDatum(Student student, DateTime dateTime)
        {
            var studentiTestovi = _db.StudentiCovidTestovi.ToList();
            foreach (var studentTest in studentiTestovi)
            {
                if (studentTest.Student.Id == student.Id && studentTest.Datum.Date == dateTime.Date)
                {
                    return true;
                }
            }

            return false;
        }

        private void btnObrisiTestove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Jeste li sigurni da zelite obrisati sve zapise?", "Odaberite", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var studentiTestovi = _db.StudentiCovidTestovi.ToList();
                _db.StudentiCovidTestovi.RemoveRange(studentiTestovi);
                _db.SaveChanges();
                UcitajRezulateCovidTestiranja();
                MessageBox.Show("Uspjesno ste obrisali sve zapise!");
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            Printaj();
        }

        private void Printaj()
        {
            
        }

        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            var studenti = _db.Studenti.ToList();
            var brojTestova = Int32.Parse(txtBrojTestova.Text);

            if (brojTestova >= studenti.Count)
            {
                brojTestova = studenti.Count;
            }

            for (int i = 0; i <= brojTestova; i++)
            {
                GenerisiTest();
            }

            UcitajRezulateCovidTestiranja();
        }

        private void GenerisiTest()
        {
            var studenti = _db.Studenti.ToList();
            var rezultat = new List<string>() { "Pozitivan", "Negativan" };
            var nalazDostavljen = new List<bool>() { true, false };
            Random random = new Random();
            int randomStudent = random.Next(studenti.Count);
            int randomStudentRezultat = random.Next(rezultat.Count);
            int randomStudentNalaz = random.Next(nalazDostavljen.Count);

            var noviTest = new StudentiCovidTestovi
            {
                Student = studenti.ToArray()[randomStudent],
                Datum = DateTime.Now,
                Rezultat = rezultat.ToArray()[randomStudentRezultat],
                NalazDostavljen = nalazDostavljen.ToArray()[randomStudentNalaz]
            };

            if (!TestDodanNaOdabraniDatum(noviTest.Student, noviTest.Datum))
            {
                _db.StudentiCovidTestovi.Add(noviTest);
                _db.SaveChanges();
            }
        }
    }
}