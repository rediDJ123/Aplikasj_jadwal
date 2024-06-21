namespace Aplikasi_Jadwal
{
    partial class Tambahacara
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
            this.txtJadwal = new System.Windows.Forms.TextBox();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerwaktu = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBoxHari = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtJadwal
            // 
            this.txtJadwal.Location = new System.Drawing.Point(108, 71);
            this.txtJadwal.Name = "txtJadwal";
            this.txtJadwal.Size = new System.Drawing.Size(173, 20);
            this.txtJadwal.TabIndex = 5;
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Location = new System.Drawing.Point(109, 97);
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(172, 20);
            this.txtKeterangan.TabIndex = 6;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(108, 121);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker.TabIndex = 15;
            // 
            // dateTimePickerwaktu
            // 
            this.dateTimePickerwaktu.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerwaktu.Location = new System.Drawing.Point(256, 121);
            this.dateTimePickerwaktu.Name = "dateTimePickerwaktu";
            this.dateTimePickerwaktu.Size = new System.Drawing.Size(79, 20);
            this.dateTimePickerwaktu.TabIndex = 33;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(152, 149);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 36);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Tambah";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(122, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 20);
            this.label14.TabIndex = 35;
            this.label14.Text = "Masukan Jadwal";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(45, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 18);
            this.label15.TabIndex = 36;
            this.label15.Text = "Acara";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(19, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 18);
            this.label16.TabIndex = 37;
            this.label16.Text = "Keterangan";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(56, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 18);
            this.label18.TabIndex = 38;
            this.label18.Text = "Hari";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(-5, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 18);
            this.label17.TabIndex = 39;
            this.label17.Text = "Tanggal/Waktu";
            // 
            // comboBoxHari
            // 
            this.comboBoxHari.FormattingEnabled = true;
            this.comboBoxHari.Location = new System.Drawing.Point(109, 45);
            this.comboBoxHari.Name = "comboBoxHari";
            this.comboBoxHari.Size = new System.Drawing.Size(172, 21);
            this.comboBoxHari.TabIndex = 40;
            this.comboBoxHari.SelectedIndexChanged += new System.EventHandler(this.comboBoxHari_SelectedIndexChanged);
            // 
            // Tambahacara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(381, 225);
            this.Controls.Add(this.comboBoxHari);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateTimePickerwaktu);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.txtJadwal);
            this.Name = "Tambahacara";
            this.Text = "Tambahacara";
            this.Load += new System.EventHandler(this.JadwalMatkul_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtJadwal;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DateTimePicker dateTimePickerwaktu;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBoxHari;
    }
}