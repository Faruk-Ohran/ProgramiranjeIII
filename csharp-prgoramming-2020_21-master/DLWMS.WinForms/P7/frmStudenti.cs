using DLWMS.WinForms.IspisIB150051;
using DLWMS.WinForms.P10;
using DLWMS.WinForms.P11;
using DLWMS.WinForms.P5;
using DLWMS.WinForms.P9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DLWMS.WinForms.P7
{
    public partial class frmStudenti : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza; //new KonekcijaNaBazu();

        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudenti_Load(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentima();
            CustomDateFormat();
        }

        private void CustomDateFormat()
        {
            dtpOd.Format = DateTimePickerFormat.Custom;
            dtpOd.CustomFormat = "ddd dd MMM yyyy";
            dtpDo.Format = DateTimePickerFormat.Custom;
            dtpDo.CustomFormat = "ddd dd MMM yyyy";
        }

        private void UcitajPodatkeOStudentima(List<Student> studenti = null)
        {
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = studenti ?? _baza.Studenti.ToList();  //InMemoryDB.Studenti;
        }

        private void PrikaziFormu(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var student = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
            Form form = null;
            if (student != null)
            {
                if (e.ColumnIndex == 6) 
                    form = new frmStudentiPredmeti(student);
                else
                    form = new frmNoviStudent(student);
                PrikaziFormu(form);
                UcitajPodatkeOStudentima();
            }
        }

        private void cbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrirajPodatkeOStudentima();
        }

        private void cbOcjena_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrirajPodatkeOStudentima();
        }

        private void FiltrirajPodatkeOStudentima()
        {
            if (ValidanUnos())
            {
                dgvStudenti.DataSource = null;
                var studenti = _baza.Studenti.ToList();
                int ocjena = Int32.Parse(cbOcjena.SelectedItem.ToString());
                string op = cbOperator.SelectedItem.ToString();
                DateTime _od = dtpOd.Value;
                DateTime _do = dtpDo.Value;

                var filtriraniStudentiPoDatumu = _baza.StudentiPredmeti.Where(x => x.Datum >= _od && x.Datum <= _do).ToList();

                var filtriraniStudentiPoOcjeniIDatumu = FiltrirajPoOcjeni(filtriraniStudentiPoDatumu, op, ocjena);

                var studentiIds = filtriraniStudentiPoOcjeniIDatumu.Select(x => x.Student.Id).ToList();
                
                var filtriraniStudenti = studenti.Where(x => studentiIds.Contains(x.Id)).ToList();

                dgvStudenti.DataSource = filtriraniStudenti;

                lblBrojStudenata.Text = filtriraniStudenti.Count().ToString();
                if (filtriraniStudenti.Count == 0)
                {
                    lblProsjecnaOcjena.Text = "0";
                }
                else
                {
                    lblProsjecnaOcjena.Text = filtriraniStudentiPoOcjeniIDatumu.ToList().Average(x => x.Ocjena).ToString();
                }
            }
        }

        private List<StudentiPredmeti> FiltrirajPoOcjeni(List<StudentiPredmeti> studenti, string op, int ocjena)
        {
            switch (op)
            {
                case "<":
                    studenti = studenti.Where(x => x.Ocjena < ocjena).ToList();
                    break;
                case ">":
                    studenti = studenti.Where(x => x.Ocjena > ocjena).ToList();
                    break;
                case "<=":
                    studenti = studenti.Where(x => x.Ocjena <= ocjena).ToList();
                    break;
                case ">=":
                    studenti = studenti.Where(x => x.Ocjena >= ocjena).ToList();
                    break;
                case "=":
                    studenti = studenti.Where(x => x.Ocjena == ocjena).ToList();
                    break;
                default:
                    break;
            }

            return studenti;
        }

        private bool ValidanUnos()
        {
            return Validator.ValidirajKontrolu(cbOperator, errCbOperator, "Morate odabrati operator!")
                && Validator.ValidirajKontrolu(cbOcjena, errCbOcjena, "Morate odabrati ocjenu!");
        }

        private void btnCovid_Click(object sender, EventArgs e)
        {
            frmCovidTest frmCovidTest = new frmCovidTest();
            frmCovidTest.ShowDialog();
        }
    }
}