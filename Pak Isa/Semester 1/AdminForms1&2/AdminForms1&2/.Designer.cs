namespace AdminForms1_2
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numberLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.ComboBox();
            this.fullNameText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(20, 15);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(122, 30);
            this.numberLabel.TabIndex = 0;
            this.numberLabel.Text = "Pembeli #1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.label3.Location = new System.Drawing.Point(20, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Lengkap";
            // 
            // titleBox
            // 
            this.titleBox.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.titleBox.FormattingEnabled = true;
            this.titleBox.Location = new System.Drawing.Point(162, 67);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(291, 33);
            this.titleBox.TabIndex = 3;
            this.titleBox.Text = "Pilih Titel";
            // 
            // fullNameText
            // 
            this.fullNameText.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.fullNameText.Location = new System.Drawing.Point(162, 106);
            this.fullNameText.Name = "fullNameText";
            this.fullNameText.Size = new System.Drawing.Size(529, 31);
            this.fullNameText.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(157, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(526, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Isi Nama Sesuai KTP /  Paspor / SIM (tanpa tanda baca dan gelar)";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fullNameText);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberLabel);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(704, 180);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox titleBox;
        private System.Windows.Forms.TextBox fullNameText;
        private System.Windows.Forms.Label label4;
    }
}
