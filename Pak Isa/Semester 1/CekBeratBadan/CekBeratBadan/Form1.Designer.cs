namespace CekBeratBadan
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTinggi = new System.Windows.Forms.Label();
            this.txtTinggi = new System.Windows.Forms.TextBox();
            this.btnCek = new System.Windows.Forms.Button();
            this.lblBerat = new System.Windows.Forms.Label();
            this.txtBerat = new System.Windows.Forms.TextBox();
            this.lblHasil = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTinggi
            // 
            this.lblTinggi.AutoSize = true;
            this.lblTinggi.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinggi.Location = new System.Drawing.Point(45, 293);
            this.lblTinggi.Name = "lblTinggi";
            this.lblTinggi.Size = new System.Drawing.Size(154, 25);
            this.lblTinggi.TabIndex = 0;
            this.lblTinggi.Text = "Tinggi Badan (cm)";
            // 
            // txtTinggi
            // 
            this.txtTinggi.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinggi.Location = new System.Drawing.Point(228, 293);
            this.txtTinggi.Name = "txtTinggi";
            this.txtTinggi.Size = new System.Drawing.Size(283, 31);
            this.txtTinggi.TabIndex = 1;
            // 
            // btnCek
            // 
            this.btnCek.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCek.Location = new System.Drawing.Point(389, 377);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(122, 41);
            this.btnCek.TabIndex = 2;
            this.btnCek.Text = "Cek Status\r\n";
            this.btnCek.UseVisualStyleBackColor = true;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // lblBerat
            // 
            this.lblBerat.AutoSize = true;
            this.lblBerat.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBerat.Location = new System.Drawing.Point(45, 340);
            this.lblBerat.Name = "lblBerat";
            this.lblBerat.Size = new System.Drawing.Size(141, 25);
            this.lblBerat.TabIndex = 3;
            this.lblBerat.Text = "Berat Badan (kg)";
            // 
            // txtBerat
            // 
            this.txtBerat.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBerat.Location = new System.Drawing.Point(228, 340);
            this.txtBerat.Name = "txtBerat";
            this.txtBerat.Size = new System.Drawing.Size(283, 31);
            this.txtBerat.TabIndex = 4;
            // 
            // lblHasil
            // 
            this.lblHasil.BackColor = System.Drawing.Color.White;
            this.lblHasil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHasil.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasil.Location = new System.Drawing.Point(50, 421);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(461, 166);
            this.lblHasil.TabIndex = 5;
            this.lblHasil.Text = "Hasil Akhir :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CekBeratBadan.Properties.Resources.berat_badan;
            this.pictureBox1.Location = new System.Drawing.Point(156, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(583, 596);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.txtBerat);
            this.Controls.Add(this.lblBerat);
            this.Controls.Add(this.btnCek);
            this.Controls.Add(this.txtTinggi);
            this.Controls.Add(this.lblTinggi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CekBeratBadanMu!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTinggi;
        private System.Windows.Forms.TextBox txtTinggi;
        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.Label lblBerat;
        private System.Windows.Forms.TextBox txtBerat;
        private System.Windows.Forms.Label lblHasil;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

