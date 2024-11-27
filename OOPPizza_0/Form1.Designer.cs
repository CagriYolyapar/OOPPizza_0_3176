namespace OOPPizza_0
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
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.cmbPizzalar = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbBuyuk = new System.Windows.Forms.RadioButton();
            this.rdbOrta = new System.Windows.Forms.RadioButton();
            this.rdbKucuk = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCiro = new System.Windows.Forms.Button();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.cmbIcecekler = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(65, 62);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(121, 22);
            this.txtIsim.TabIndex = 0;
            // 
            // cmbPizzalar
            // 
            this.cmbPizzalar.FormattingEnabled = true;
            this.cmbPizzalar.Location = new System.Drawing.Point(65, 133);
            this.cmbPizzalar.Name = "cmbPizzalar";
            this.cmbPizzalar.Size = new System.Drawing.Size(121, 24);
            this.cmbPizzalar.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(53, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 170);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdbBuyuk
            // 
            this.rdbBuyuk.AutoSize = true;
            this.rdbBuyuk.Location = new System.Drawing.Point(65, 184);
            this.rdbBuyuk.Name = "rdbBuyuk";
            this.rdbBuyuk.Size = new System.Drawing.Size(92, 20);
            this.rdbBuyuk.TabIndex = 3;
            this.rdbBuyuk.Text = "Buyuk Boy";
            this.rdbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rdbOrta
            // 
            this.rdbOrta.AutoSize = true;
            this.rdbOrta.Location = new System.Drawing.Point(65, 225);
            this.rdbOrta.Name = "rdbOrta";
            this.rdbOrta.Size = new System.Drawing.Size(80, 20);
            this.rdbOrta.TabIndex = 3;
            this.rdbOrta.Text = "Orta Boy";
            this.rdbOrta.UseVisualStyleBackColor = true;
            // 
            // rdbKucuk
            // 
            this.rdbKucuk.AutoSize = true;
            this.rdbKucuk.Checked = true;
            this.rdbKucuk.Location = new System.Drawing.Point(65, 264);
            this.rdbKucuk.Name = "rdbKucuk";
            this.rdbKucuk.Size = new System.Drawing.Size(91, 20);
            this.rdbKucuk.TabIndex = 3;
            this.rdbKucuk.TabStop = true;
            this.rdbKucuk.Text = "Kucuk Boy";
            this.rdbKucuk.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(42, 43);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Tag = "0.80";
            this.checkBox1.Text = "Sucuk";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(42, 93);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(70, 20);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Tag = "0.60";
            this.checkBox2.Text = "Mantar";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(200, 43);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(68, 20);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Tag = "0.85";
            this.checkBox3.Text = "Salam";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(200, 93);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(65, 20);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Tag = "0.90";
            this.checkBox4.Text = "Zeytin";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(334, 43);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(63, 20);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Tag = "0.50";
            this.checkBox5.Text = "Sosis";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.ItemHeight = 16;
            this.lstSiparisler.Location = new System.Drawing.Point(405, 43);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(631, 308);
            this.lstSiparisler.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(591, 455);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(108, 38);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnCiro
            // 
            this.btnCiro.Location = new System.Drawing.Point(888, 455);
            this.btnCiro.Name = "btnCiro";
            this.btnCiro.Size = new System.Drawing.Size(88, 38);
            this.btnCiro.TabIndex = 5;
            this.btnCiro.Text = "Ciro";
            this.btnCiro.UseVisualStyleBackColor = true;
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(253, 73);
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(120, 22);
            this.nmrAdet.TabIndex = 6;
            this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAciklama
            // 
            this.lblAciklama.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAciklama.Location = new System.Drawing.Point(53, 567);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(449, 148);
            this.lblAciklama.TabIndex = 1;
            // 
            // cmbIcecekler
            // 
            this.cmbIcecekler.FormattingEnabled = true;
            this.cmbIcecekler.Location = new System.Drawing.Point(252, 133);
            this.cmbIcecekler.Name = "cmbIcecekler";
            this.cmbIcecekler.Size = new System.Drawing.Size(121, 24);
            this.cmbIcecekler.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 724);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.btnCiro);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstSiparisler);
            this.Controls.Add(this.rdbKucuk);
            this.Controls.Add(this.rdbOrta);
            this.Controls.Add(this.rdbBuyuk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbIcecekler);
            this.Controls.Add(this.cmbPizzalar);
            this.Controls.Add(this.txtIsim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.ComboBox cmbPizzalar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbBuyuk;
        private System.Windows.Forms.RadioButton rdbOrta;
        private System.Windows.Forms.RadioButton rdbKucuk;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCiro;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.ComboBox cmbIcecekler;
    }
}

