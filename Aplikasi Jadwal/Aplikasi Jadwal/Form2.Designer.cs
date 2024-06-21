namespace Aplikasi_Jadwal
{
    partial class edit
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
            this.comboBoxHari = new System.Windows.Forms.ComboBox();
            this.txtJadwalEdit = new System.Windows.Forms.TextBox();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerwaktu = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxHari
            // 
            this.comboBoxHari.FormattingEnabled = true;
            this.comboBoxHari.Location = new System.Drawing.Point(99, 69);
            this.comboBoxHari.Name = "comboBoxHari";
            this.comboBoxHari.Size = new System.Drawing.Size(172, 21);
            this.comboBoxHari.TabIndex = 41;
            this.comboBoxHari.SelectedIndexChanged += new System.EventHandler(this.comboBoxHari_SelectedIndexChanged);
            // 
            // txtJadwalEdit
            // 
            this.txtJadwalEdit.Location = new System.Drawing.Point(98, 96);
            this.txtJadwalEdit.Name = "txtJadwalEdit";
            this.txtJadwalEdit.Size = new System.Drawing.Size(173, 20);
            this.txtJadwalEdit.TabIndex = 42;
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Location = new System.Drawing.Point(99, 122);
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(172, 20);
            this.txtKeterangan.TabIndex = 43;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(99, 148);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker.TabIndex = 44;
            // 
            // dateTimePickerwaktu
            // 
            this.dateTimePickerwaktu.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerwaktu.Location = new System.Drawing.Point(247, 148);
            this.dateTimePickerwaktu.Name = "dateTimePickerwaktu";
            this.dateTimePickerwaktu.Size = new System.Drawing.Size(79, 20);
            this.dateTimePickerwaktu.TabIndex = 45;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(133, 174);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 36);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Tambah";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 256);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateTimePickerwaktu);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.txtJadwalEdit);
            this.Controls.Add(this.comboBoxHari);
            this.Name = "edit";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxHari;
        private System.Windows.Forms.TextBox txtJadwalEdit;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DateTimePicker dateTimePickerwaktu;
        private System.Windows.Forms.Button btnSave;
    }
}