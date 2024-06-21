using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Jadwal
{
    public partial class Tambahacara : Form
    {
        // Existing code omitted for brevity

        // Properties to store edited values
        public string Jadwal { get; private set; }
        public string Keterangan { get; private set; }
        public string Tanggal { get; private set; }
        public string Hari { get; private set; }
        public string waktu { get; private set; }

        // Method to set initial values for editing
       
        public Tambahacara()
        {
            InitializeComponent();
            comboBoxHari.Items.AddRange(new string[] { "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu" });
        }
        private void JadwalMatkul_Load(object sender, EventArgs e)
        {

        }
        public void SetInitialValues(string jadwal, string keterangan, string tanggal, string hari, string waktu)
        {
            txtJadwal.Text = jadwal;
            txtKeterangan.Text = keterangan;
            dateTimePicker.Value = DateTime.Parse(tanggal);
            comboBoxHari.SelectedItem = hari;
            dateTimePickerwaktu.Value = DateTime.Parse(waktu);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtJadwal.Text) &&
                !string.IsNullOrWhiteSpace(dateTimePicker.Text) &&
                !string.IsNullOrWhiteSpace(txtKeterangan.Text) &&
                !string.IsNullOrWhiteSpace(dateTimePickerwaktu.Text) &&
                comboBoxHari.SelectedItem != null)
            {
                // Update properties with edited values
                Jadwal = txtJadwal.Text;
                Keterangan = txtKeterangan.Text;
                Tanggal = dateTimePicker.Value.ToShortDateString();
                Hari = comboBoxHari.SelectedItem.ToString();
                waktu = dateTimePickerwaktu.Value.ToShortTimeString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Masukkan semua informasi jadwal.");
            }
        }

    


    private void label16_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxHari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
