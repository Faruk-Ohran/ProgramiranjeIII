
namespace DLWMS.WinForms.IspisIB150051
{
    partial class frmCovidTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbStudent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDatumTestiranja = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRezultatTesta = new System.Windows.Forms.ComboBox();
            this.checkbNalazDostavljen = new System.Windows.Forms.CheckBox();
            this.btnDodajTest = new System.Windows.Forms.Button();
            this.dgvRezultatiCovidTestiranja = new System.Windows.Forms.DataGridView();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rezultat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NalazDostavljen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBrojtestova = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBrojTestova = new System.Windows.Forms.TextBox();
            this.btnGenerisi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnObrisiTestove = new System.Windows.Forms.Button();
            this.btnPrintaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezultatiCovidTestiranja)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student:";
            // 
            // cbStudent
            // 
            this.cbStudent.FormattingEnabled = true;
            this.cbStudent.Location = new System.Drawing.Point(15, 25);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(121, 21);
            this.cbStudent.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum testiranja:";
            // 
            // dtpDatumTestiranja
            // 
            this.dtpDatumTestiranja.Location = new System.Drawing.Point(159, 25);
            this.dtpDatumTestiranja.Name = "dtpDatumTestiranja";
            this.dtpDatumTestiranja.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumTestiranja.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rezultat testa:";
            // 
            // cbRezultatTesta
            // 
            this.cbRezultatTesta.FormattingEnabled = true;
            this.cbRezultatTesta.Items.AddRange(new object[] {
            "Pozitivan",
            "Negativan"});
            this.cbRezultatTesta.Location = new System.Drawing.Point(380, 23);
            this.cbRezultatTesta.Name = "cbRezultatTesta";
            this.cbRezultatTesta.Size = new System.Drawing.Size(121, 21);
            this.cbRezultatTesta.TabIndex = 5;
            this.cbRezultatTesta.Text = "Negativan";
            // 
            // checkbNalazDostavljen
            // 
            this.checkbNalazDostavljen.AutoSize = true;
            this.checkbNalazDostavljen.Location = new System.Drawing.Point(517, 26);
            this.checkbNalazDostavljen.Name = "checkbNalazDostavljen";
            this.checkbNalazDostavljen.Size = new System.Drawing.Size(104, 17);
            this.checkbNalazDostavljen.TabIndex = 6;
            this.checkbNalazDostavljen.Text = "Nalaz dostavljen";
            this.checkbNalazDostavljen.UseVisualStyleBackColor = true;
            // 
            // btnDodajTest
            // 
            this.btnDodajTest.Location = new System.Drawing.Point(663, 25);
            this.btnDodajTest.Name = "btnDodajTest";
            this.btnDodajTest.Size = new System.Drawing.Size(75, 23);
            this.btnDodajTest.TabIndex = 7;
            this.btnDodajTest.Text = "Dodaj";
            this.btnDodajTest.UseVisualStyleBackColor = true;
            this.btnDodajTest.Click += new System.EventHandler(this.btnDodajTest_Click);
            // 
            // dgvRezultatiCovidTestiranja
            // 
            this.dgvRezultatiCovidTestiranja.AllowUserToAddRows = false;
            this.dgvRezultatiCovidTestiranja.AllowUserToDeleteRows = false;
            this.dgvRezultatiCovidTestiranja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezultatiCovidTestiranja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Datum,
            this.Rezultat,
            this.NalazDostavljen});
            this.dgvRezultatiCovidTestiranja.Location = new System.Drawing.Point(15, 64);
            this.dgvRezultatiCovidTestiranja.Name = "dgvRezultatiCovidTestiranja";
            this.dgvRezultatiCovidTestiranja.ReadOnly = true;
            this.dgvRezultatiCovidTestiranja.Size = new System.Drawing.Size(723, 232);
            this.dgvRezultatiCovidTestiranja.TabIndex = 8;
            // 
            // Student
            // 
            this.Student.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Student.DataPropertyName = "Student";
            this.Student.HeaderText = "Student";
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Rezultat
            // 
            this.Rezultat.DataPropertyName = "Rezultat";
            this.Rezultat.HeaderText = "Rezultat";
            this.Rezultat.Name = "Rezultat";
            this.Rezultat.ReadOnly = true;
            // 
            // NalazDostavljen
            // 
            this.NalazDostavljen.DataPropertyName = "NalazDostavljen";
            this.NalazDostavljen.HeaderText = "NalazDostavljen";
            this.NalazDostavljen.Name = "NalazDostavljen";
            this.NalazDostavljen.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Broj testova:";
            // 
            // lblBrojtestova
            // 
            this.lblBrojtestova.AutoSize = true;
            this.lblBrojtestova.Location = new System.Drawing.Point(85, 308);
            this.lblBrojtestova.Name = "lblBrojtestova";
            this.lblBrojtestova.Size = new System.Drawing.Size(0, 13);
            this.lblBrojtestova.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerisi);
            this.groupBox1.Controls.Add(this.txtBrojTestova);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(113, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generisanje testova:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Broj testova:";
            // 
            // txtBrojTestova
            // 
            this.txtBrojTestova.Location = new System.Drawing.Point(79, 25);
            this.txtBrojTestova.Name = "txtBrojTestova";
            this.txtBrojTestova.Size = new System.Drawing.Size(100, 20);
            this.txtBrojTestova.TabIndex = 1;
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.Location = new System.Drawing.Point(199, 21);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(75, 23);
            this.btnGenerisi.TabIndex = 2;
            this.btnGenerisi.Text = "Generisi";
            this.btnGenerisi.UseVisualStyleBackColor = true;
            this.btnGenerisi.Click += new System.EventHandler(this.btnGenerisi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnObrisiTestove);
            this.groupBox2.Location = new System.Drawing.Point(421, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brisanje testova:";
            // 
            // btnObrisiTestove
            // 
            this.btnObrisiTestove.Location = new System.Drawing.Point(6, 36);
            this.btnObrisiTestove.Name = "btnObrisiTestove";
            this.btnObrisiTestove.Size = new System.Drawing.Size(188, 23);
            this.btnObrisiTestove.TabIndex = 0;
            this.btnObrisiTestove.Text = "OBRISI TESTOVE";
            this.btnObrisiTestove.UseVisualStyleBackColor = true;
            this.btnObrisiTestove.Click += new System.EventHandler(this.btnObrisiTestove_Click);
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(663, 345);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(75, 23);
            this.btnPrintaj.TabIndex = 13;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // frmCovidTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBrojtestova);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvRezultatiCovidTestiranja);
            this.Controls.Add(this.btnDodajTest);
            this.Controls.Add(this.checkbNalazDostavljen);
            this.Controls.Add(this.cbRezultatTesta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDatumTestiranja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbStudent);
            this.Controls.Add(this.label1);
            this.Name = "frmCovidTest";
            this.Text = "frmCovidTest";
            this.Load += new System.EventHandler(this.frmCovidTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezultatiCovidTestiranja)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDatumTestiranja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbRezultatTesta;
        private System.Windows.Forms.CheckBox checkbNalazDostavljen;
        private System.Windows.Forms.Button btnDodajTest;
        private System.Windows.Forms.DataGridView dgvRezultatiCovidTestiranja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rezultat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NalazDostavljen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBrojtestova;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerisi;
        private System.Windows.Forms.TextBox txtBrojTestova;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnObrisiTestove;
        private System.Windows.Forms.Button btnPrintaj;
    }
}