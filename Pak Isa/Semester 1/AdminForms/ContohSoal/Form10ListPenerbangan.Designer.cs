namespace ContohSoal
{
    partial class Form10ListPenerbangan
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
            this.timeCheck1 = new System.Windows.Forms.CheckBox();
            this.applyBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sortBox = new System.Windows.Forms.ComboBox();
            this.timeCheck4 = new System.Windows.Forms.CheckBox();
            this.timeCheck3 = new System.Windows.Forms.CheckBox();
            this.timeCheck2 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.departureLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dataGridPenerbangan = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodePenerbangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maskapai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraTujuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaPerTiket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeliTiket = new System.Windows.Forms.DataGridViewButtonColumn();
            this.passengerLabel = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPenerbangan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // timeCheck1
            // 
            this.timeCheck1.AutoSize = true;
            this.timeCheck1.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCheck1.Location = new System.Drawing.Point(23, 58);
            this.timeCheck1.Name = "timeCheck1";
            this.timeCheck1.Size = new System.Drawing.Size(128, 25);
            this.timeCheck1.TabIndex = 0;
            this.timeCheck1.Text = "08:00 - 10:00";
            this.timeCheck1.UseVisualStyleBackColor = true;
            // 
            // applyBtn
            // 
            this.applyBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.applyBtn.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyBtn.Location = new System.Drawing.Point(970, 155);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(132, 30);
            this.applyBtn.TabIndex = 1;
            this.applyBtn.Text = "Terapkan Filter";
            this.applyBtn.UseVisualStyleBackColor = false;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "List Jadwal Temu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.sortBox);
            this.groupBox1.Controls.Add(this.timeCheck4);
            this.groupBox1.Controls.Add(this.timeCheck3);
            this.groupBox1.Controls.Add(this.timeCheck2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.timeCheck1);
            this.groupBox1.Controls.Add(this.applyBtn);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1113, 197);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Urutkan Berdasarkan";
            // 
            // sortBox
            // 
            this.sortBox.FormattingEnabled = true;
            this.sortBox.Location = new System.Drawing.Point(22, 144);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(273, 29);
            this.sortBox.TabIndex = 12;
            // 
            // timeCheck4
            // 
            this.timeCheck4.AutoSize = true;
            this.timeCheck4.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCheck4.Location = new System.Drawing.Point(477, 58);
            this.timeCheck4.Name = "timeCheck4";
            this.timeCheck4.Size = new System.Drawing.Size(128, 25);
            this.timeCheck4.TabIndex = 11;
            this.timeCheck4.Text = "15:00 - 17:00";
            this.timeCheck4.UseVisualStyleBackColor = true;
            // 
            // timeCheck3
            // 
            this.timeCheck3.AutoSize = true;
            this.timeCheck3.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCheck3.Location = new System.Drawing.Point(316, 58);
            this.timeCheck3.Name = "timeCheck3";
            this.timeCheck3.Size = new System.Drawing.Size(128, 25);
            this.timeCheck3.TabIndex = 10;
            this.timeCheck3.Text = "13:00 - 15:00";
            this.timeCheck3.UseVisualStyleBackColor = true;
            // 
            // timeCheck2
            // 
            this.timeCheck2.AutoSize = true;
            this.timeCheck2.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCheck2.Location = new System.Drawing.Point(167, 58);
            this.timeCheck2.Name = "timeCheck2";
            this.timeCheck2.Size = new System.Drawing.Size(128, 25);
            this.timeCheck2.TabIndex = 9;
            this.timeCheck2.Text = "10:00 - 12:00";
            this.timeCheck2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Waktu Janji Temu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(414, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 38);
            this.label2.TabIndex = 6;
            // 
            // departureLabel
            // 
            this.departureLabel.AutoSize = true;
            this.departureLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureLabel.Location = new System.Drawing.Point(51, 72);
            this.departureLabel.Name = "departureLabel";
            this.departureLabel.Size = new System.Drawing.Size(164, 25);
            this.departureLabel.TabIndex = 7;
            this.departureLabel.Text = "Daftar Melalui Scan";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationLabel.Location = new System.Drawing.Point(282, 72);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(136, 25);
            this.destinationLabel.TabIndex = 8;
            this.destinationLabel.Text = "Tunggu Respon";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(496, 72);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(85, 25);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "Buat Janji";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ContohSoal.Properties.Resources.Cuplikan_layar_2026_08_28_214232;
            this.pictureBox2.Location = new System.Drawing.Point(226, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::ContohSoal.Properties.Resources._50954837_left_arrow;
            this.pictureBox7.Location = new System.Drawing.Point(16, 26);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(42, 43);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ContohSoal.Properties.Resources.Cuplikan_layar_2026_08_28_214232;
            this.pictureBox3.Location = new System.Drawing.Point(435, 73);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // dataGridPenerbangan
            // 
            this.dataGridPenerbangan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPenerbangan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.KodePenerbangan,
            this.Maskapai,
            this.BandaraKeberangkatan,
            this.BandaraTujuan,
            this.HargaPerTiket,
            this.Tanggal,
            this.Jam,
            this.BeliTiket});
            this.dataGridPenerbangan.Location = new System.Drawing.Point(12, 358);
            this.dataGridPenerbangan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridPenerbangan.Name = "dataGridPenerbangan";
            this.dataGridPenerbangan.RowHeadersWidth = 62;
            this.dataGridPenerbangan.Size = new System.Drawing.Size(1112, 397);
            this.dataGridPenerbangan.TabIndex = 14;
            this.dataGridPenerbangan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPenerbangan_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // KodePenerbangan
            // 
            this.KodePenerbangan.DataPropertyName = "KodePenerbangan";
            this.KodePenerbangan.HeaderText = "Kode Penerbangan";
            this.KodePenerbangan.MinimumWidth = 8;
            this.KodePenerbangan.Name = "KodePenerbangan";
            this.KodePenerbangan.Width = 150;
            // 
            // Maskapai
            // 
            this.Maskapai.DataPropertyName = "Maskapai";
            this.Maskapai.HeaderText = "Maskapai";
            this.Maskapai.MinimumWidth = 8;
            this.Maskapai.Name = "Maskapai";
            this.Maskapai.Width = 150;
            // 
            // BandaraKeberangkatan
            // 
            this.BandaraKeberangkatan.DataPropertyName = "BandaraKeberangkatan";
            this.BandaraKeberangkatan.HeaderText = "Bandara Keberangkatan";
            this.BandaraKeberangkatan.MinimumWidth = 8;
            this.BandaraKeberangkatan.Name = "BandaraKeberangkatan";
            this.BandaraKeberangkatan.Width = 150;
            // 
            // BandaraTujuan
            // 
            this.BandaraTujuan.DataPropertyName = "BandaraTujuan";
            this.BandaraTujuan.HeaderText = "Bandara Tujuan";
            this.BandaraTujuan.MinimumWidth = 8;
            this.BandaraTujuan.Name = "BandaraTujuan";
            this.BandaraTujuan.Width = 150;
            // 
            // HargaPerTiket
            // 
            this.HargaPerTiket.DataPropertyName = "HargaPerTiket";
            this.HargaPerTiket.HeaderText = "Harga";
            this.HargaPerTiket.MinimumWidth = 8;
            this.HargaPerTiket.Name = "HargaPerTiket";
            this.HargaPerTiket.Width = 150;
            // 
            // Tanggal
            // 
            this.Tanggal.DataPropertyName = "Tanggal";
            this.Tanggal.HeaderText = "Tanggal";
            this.Tanggal.MinimumWidth = 8;
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.Width = 150;
            // 
            // Jam
            // 
            this.Jam.DataPropertyName = "Jam";
            this.Jam.HeaderText = "Jam Berangkat";
            this.Jam.MinimumWidth = 8;
            this.Jam.Name = "Jam";
            this.Jam.Width = 150;
            // 
            // BeliTiket
            // 
            this.BeliTiket.DataPropertyName = "BeliTiket";
            this.BeliTiket.HeaderText = "";
            this.BeliTiket.MinimumWidth = 8;
            this.BeliTiket.Name = "BeliTiket";
            this.BeliTiket.Text = "Beli Tiket";
            this.BeliTiket.UseColumnTextForButtonValue = true;
            this.BeliTiket.Width = 150;
            // 
            // passengerLabel
            // 
            this.passengerLabel.AutoSize = true;
            this.passengerLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerLabel.Location = new System.Drawing.Point(661, 72);
            this.passengerLabel.Name = "passengerLabel";
            this.passengerLabel.Size = new System.Drawing.Size(85, 25);
            this.passengerLabel.TabIndex = 9;
            this.passengerLabel.Text = "Buat Janji";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ContohSoal.Properties.Resources.Cuplikan_layar_2026_08_28_214232;
            this.pictureBox4.Location = new System.Drawing.Point(600, 73);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // Form10ListPenerbangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1137, 769);
            this.Controls.Add(this.dataGridPenerbangan);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.passengerLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.departureLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form10ListPenerbangan";
            this.Text = "S";
            this.Load += new System.EventHandler(this.Form10ListPenerbangan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPenerbangan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox timeCheck1;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label departureLabel;
        private System.Windows.Forms.CheckBox timeCheck4;
        private System.Windows.Forms.CheckBox timeCheck3;
        private System.Windows.Forms.CheckBox timeCheck2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sortBox;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dataGridPenerbangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodePenerbangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maskapai;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandaraKeberangkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandaraTujuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaPerTiket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jam;
        private System.Windows.Forms.DataGridViewButtonColumn BeliTiket;
        private System.Windows.Forms.Label passengerLabel;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}