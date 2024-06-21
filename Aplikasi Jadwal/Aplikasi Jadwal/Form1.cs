using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Jadwal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadScheduleFromFile();
            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            SaveScheduleToFile();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var tambahacaraForm = new Tambahacara())
            {
                if (tambahacaraForm.ShowDialog() == DialogResult.OK)
                {
                    listBoxJadwal.Items.Add(tambahacaraForm.Jadwal);
                    listBoxKeterangan.Items.Add(tambahacaraForm.Keterangan);
                    listBoxTanggal.Items.Add(tambahacaraForm.Tanggal);
                    listBoxHari.Items.Add(tambahacaraForm.Hari);
                    listBoxwaktu.Items.Add(tambahacaraForm.waktu);
                }
            }
        }

                private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxJadwal.SelectedIndex;

            if (selectedIndex != -1)
            {
                listBoxJadwal.Items.RemoveAt(selectedIndex);
                listBoxKeterangan.Items.RemoveAt(selectedIndex);
                listBoxTanggal.Items.RemoveAt(selectedIndex);
                listBoxHari.Items.RemoveAt(selectedIndex);
                listBoxwaktu.Items.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Pilih jadwal yang ingin dihapus.");
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void txtJadwal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void SaveScheduleToFile()
        {
            using (StreamWriter writer = new StreamWriter("jadwal.txt"))
            {
                for (int i = 0; i < listBoxKeterangan.Items.Count; i++)
                {
                    string jadwal = listBoxJadwal.Items[i].ToString();
                    string keterangan = listBoxKeterangan.Items[i].ToString();
                    string tanggal = listBoxTanggal.Items[i].ToString();
                    string hari = listBoxHari.Items[i].ToString();
                    string waktu = listBoxwaktu.Items[i].ToString();
                    writer.WriteLine($"{jadwal};{keterangan};{tanggal};{hari};{waktu}");
                }
            }
        }

        // Membaca jadwal dari file
        private void LoadScheduleFromFile()
        {
            if (File.Exists("jadwal.txt"))
            {
                using (StreamReader reader = new StreamReader("jadwal.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(';');
                        if (parts.Length == 5)
                        {
                            listBoxJadwal.Items.Add(parts[0]);
                            listBoxKeterangan.Items.Add(parts[1]);
                            listBoxTanggal.Items.Add(parts[2]);
                            listBoxHari.Items.Add(parts[3]);
                            listBoxwaktu.Items.Add(parts[4]);
                        }
                    }
                }
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            Tambahacara Tambahacara = new Tambahacara();
            Tambahacara.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            int selectedIndex = listBoxJadwal.SelectedIndex;

            if (selectedIndex != -1)
            {
                using (var editForm = new Tambahacara())
                {
                    // Set initial values for editing
                    editForm.SetInitialValues(
                        listBoxJadwal.Items[selectedIndex].ToString(),
                        listBoxKeterangan.Items[selectedIndex].ToString(),
                        listBoxTanggal.Items[selectedIndex].ToString(),
                        listBoxHari.Items[selectedIndex].ToString(),
                        listBoxwaktu.Items[selectedIndex].ToString()
                    );

                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        // Update items in listboxes with edited values
                        listBoxJadwal.Items[selectedIndex] = editForm.Jadwal;
                        listBoxKeterangan.Items[selectedIndex] = editForm.Keterangan;
                        listBoxTanggal.Items[selectedIndex] = editForm.Tanggal;
                        listBoxHari.Items[selectedIndex] = editForm.Hari;
                        listBoxwaktu.Items[selectedIndex] = editForm.waktu;
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih jadwal yang ingin diedit.");
            }
        }
    }
    
}