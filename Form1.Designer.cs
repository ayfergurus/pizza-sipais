namespace PizzaSipariş
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
            this.gbIleriTarih = new System.Windows.Forms.GroupBox();
            this.btnIleriSiparis = new System.Windows.Forms.Button();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.gbIcecekler = new System.Windows.Forms.GroupBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.cbSoda = new System.Windows.Forms.CheckBox();
            this.cbAyran = new System.Windows.Forms.CheckBox();
            this.cbKola = new System.Windows.Forms.CheckBox();
            this.gbEkstraMalzeme = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.cbSalam = new System.Windows.Forms.CheckBox();
            this.cbPeynir = new System.Windows.Forms.CheckBox();
            this.cbSucuk = new System.Windows.Forms.CheckBox();
            this.btnHemenSiparis = new System.Windows.Forms.Button();
            this.cmbSecim = new System.Windows.Forms.ComboBox();
            this.cmbPizzalar = new System.Windows.Forms.ComboBox();
            this.gbIleriTarih.SuspendLayout();
            this.gbIcecekler.SuspendLayout();
            this.gbEkstraMalzeme.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbIleriTarih
            // 
            this.gbIleriTarih.Controls.Add(this.btnIleriSiparis);
            this.gbIleriTarih.Controls.Add(this.dtpTarih);
            this.gbIleriTarih.Location = new System.Drawing.Point(326, 40);
            this.gbIleriTarih.Name = "gbIleriTarih";
            this.gbIleriTarih.Size = new System.Drawing.Size(151, 163);
            this.gbIleriTarih.TabIndex = 9;
            this.gbIleriTarih.TabStop = false;
            this.gbIleriTarih.Text = "İleri Tarih";
            this.gbIleriTarih.Visible = false;
            // 
            // btnIleriSiparis
            // 
            this.btnIleriSiparis.Location = new System.Drawing.Point(23, 43);
            this.btnIleriSiparis.Name = "btnIleriSiparis";
            this.btnIleriSiparis.Size = new System.Drawing.Size(112, 62);
            this.btnIleriSiparis.TabIndex = 1;
            this.btnIleriSiparis.Text = "İleri tarihe Sipariş ver";
            this.btnIleriSiparis.UseVisualStyleBackColor = true;
            this.btnIleriSiparis.Click += new System.EventHandler(this.btnIleriSiparis_Click);
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTarih.Location = new System.Drawing.Point(23, 17);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(112, 20);
            this.dtpTarih.TabIndex = 0;
            // 
            // gbIcecekler
            // 
            this.gbIcecekler.Controls.Add(this.checkBox12);
            this.gbIcecekler.Controls.Add(this.checkBox11);
            this.gbIcecekler.Controls.Add(this.checkBox10);
            this.gbIcecekler.Controls.Add(this.cbSoda);
            this.gbIcecekler.Controls.Add(this.cbAyran);
            this.gbIcecekler.Controls.Add(this.cbKola);
            this.gbIcecekler.Location = new System.Drawing.Point(169, 39);
            this.gbIcecekler.Name = "gbIcecekler";
            this.gbIcecekler.Size = new System.Drawing.Size(151, 163);
            this.gbIcecekler.TabIndex = 10;
            this.gbIcecekler.TabStop = false;
            this.gbIcecekler.Text = "İçecekler";
            this.gbIcecekler.Visible = false;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(6, 134);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(80, 17);
            this.checkBox12.TabIndex = 0;
            this.checkBox12.Text = "checkBox1";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(6, 111);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(80, 17);
            this.checkBox11.TabIndex = 0;
            this.checkBox11.Text = "checkBox1";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(6, 88);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(80, 17);
            this.checkBox10.TabIndex = 0;
            this.checkBox10.Text = "checkBox1";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // cbSoda
            // 
            this.cbSoda.AutoSize = true;
            this.cbSoda.Location = new System.Drawing.Point(6, 65);
            this.cbSoda.Name = "cbSoda";
            this.cbSoda.Size = new System.Drawing.Size(82, 17);
            this.cbSoda.TabIndex = 0;
            this.cbSoda.Text = "Soda 1.5TL";
            this.cbSoda.UseVisualStyleBackColor = true;
            this.cbSoda.CheckedChanged += new System.EventHandler(this.cbSucuk_CheckedChanged);
            // 
            // cbAyran
            // 
            this.cbAyran.AutoSize = true;
            this.cbAyran.Location = new System.Drawing.Point(6, 42);
            this.cbAyran.Name = "cbAyran";
            this.cbAyran.Size = new System.Drawing.Size(84, 17);
            this.cbAyran.TabIndex = 0;
            this.cbAyran.Text = "Ayran 2.5TL";
            this.cbAyran.UseVisualStyleBackColor = true;
            this.cbAyran.CheckedChanged += new System.EventHandler(this.cbSucuk_CheckedChanged);
            // 
            // cbKola
            // 
            this.cbKola.AutoSize = true;
            this.cbKola.Location = new System.Drawing.Point(6, 19);
            this.cbKola.Name = "cbKola";
            this.cbKola.Size = new System.Drawing.Size(69, 17);
            this.cbKola.TabIndex = 0;
            this.cbKola.Text = "Kola 3TL";
            this.cbKola.UseVisualStyleBackColor = true;
            this.cbKola.CheckedChanged += new System.EventHandler(this.cbSucuk_CheckedChanged);
            // 
            // gbEkstraMalzeme
            // 
            this.gbEkstraMalzeme.Controls.Add(this.checkBox6);
            this.gbEkstraMalzeme.Controls.Add(this.checkBox5);
            this.gbEkstraMalzeme.Controls.Add(this.checkBox4);
            this.gbEkstraMalzeme.Controls.Add(this.cbSalam);
            this.gbEkstraMalzeme.Controls.Add(this.cbPeynir);
            this.gbEkstraMalzeme.Controls.Add(this.cbSucuk);
            this.gbEkstraMalzeme.Location = new System.Drawing.Point(12, 39);
            this.gbEkstraMalzeme.Name = "gbEkstraMalzeme";
            this.gbEkstraMalzeme.Size = new System.Drawing.Size(151, 163);
            this.gbEkstraMalzeme.TabIndex = 8;
            this.gbEkstraMalzeme.TabStop = false;
            this.gbEkstraMalzeme.Text = "Ekstra Malzemeler";
            this.gbEkstraMalzeme.Visible = false;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(7, 135);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(80, 17);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "checkBox1";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(7, 112);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(80, 17);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "checkBox1";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(7, 89);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "checkBox1";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // cbSalam
            // 
            this.cbSalam.AutoSize = true;
            this.cbSalam.Location = new System.Drawing.Point(7, 66);
            this.cbSalam.Name = "cbSalam";
            this.cbSalam.Size = new System.Drawing.Size(110, 17);
            this.cbSalam.TabIndex = 0;
            this.cbSalam.Text = "Ekstra Salam 3TL";
            this.cbSalam.UseVisualStyleBackColor = true;
            this.cbSalam.CheckedChanged += new System.EventHandler(this.cbSucuk_CheckedChanged);
            // 
            // cbPeynir
            // 
            this.cbPeynir.AutoSize = true;
            this.cbPeynir.Location = new System.Drawing.Point(7, 43);
            this.cbPeynir.Name = "cbPeynir";
            this.cbPeynir.Size = new System.Drawing.Size(110, 17);
            this.cbPeynir.TabIndex = 0;
            this.cbPeynir.Text = "Ekstra Peynir 2TL";
            this.cbPeynir.UseVisualStyleBackColor = true;
            this.cbPeynir.CheckedChanged += new System.EventHandler(this.cbSucuk_CheckedChanged);
            // 
            // cbSucuk
            // 
            this.cbSucuk.AutoSize = true;
            this.cbSucuk.Location = new System.Drawing.Point(7, 20);
            this.cbSucuk.Name = "cbSucuk";
            this.cbSucuk.Size = new System.Drawing.Size(112, 17);
            this.cbSucuk.TabIndex = 0;
            this.cbSucuk.Text = "Ekstra Sucuk 4TL";
            this.cbSucuk.UseVisualStyleBackColor = true;
            this.cbSucuk.CheckedChanged += new System.EventHandler(this.cbSucuk_CheckedChanged);
            // 
            // btnHemenSiparis
            // 
            this.btnHemenSiparis.Location = new System.Drawing.Point(349, 11);
            this.btnHemenSiparis.Name = "btnHemenSiparis";
            this.btnHemenSiparis.Size = new System.Drawing.Size(128, 23);
            this.btnHemenSiparis.TabIndex = 7;
            this.btnHemenSiparis.Text = "Hemen Sipariş Ver";
            this.btnHemenSiparis.UseVisualStyleBackColor = true;
            this.btnHemenSiparis.Visible = false;
            this.btnHemenSiparis.Click += new System.EventHandler(this.btnHemenSiparis_Click);
            // 
            // cmbSecim
            // 
            this.cmbSecim.FormattingEnabled = true;
            this.cmbSecim.Items.AddRange(new object[] {
            "Hemen Sipariş",
            "İleri Bir Tarihe Sipariş"});
            this.cmbSecim.Location = new System.Drawing.Point(221, 11);
            this.cmbSecim.Name = "cmbSecim";
            this.cmbSecim.Size = new System.Drawing.Size(121, 21);
            this.cmbSecim.TabIndex = 6;
            this.cmbSecim.SelectedIndexChanged += new System.EventHandler(this.cmbSecim_SelectedIndexChanged);
            // 
            // cmbPizzalar
            // 
            this.cmbPizzalar.FormattingEnabled = true;
            this.cmbPizzalar.Location = new System.Drawing.Point(12, 11);
            this.cmbPizzalar.Name = "cmbPizzalar";
            this.cmbPizzalar.Size = new System.Drawing.Size(203, 21);
            this.cmbPizzalar.TabIndex = 5;
            this.cmbPizzalar.SelectedIndexChanged += new System.EventHandler(this.cmbPizzalar_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 221);
            this.Controls.Add(this.gbIleriTarih);
            this.Controls.Add(this.gbIcecekler);
            this.Controls.Add(this.gbEkstraMalzeme);
            this.Controls.Add(this.btnHemenSiparis);
            this.Controls.Add(this.cmbSecim);
            this.Controls.Add(this.cmbPizzalar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbIleriTarih.ResumeLayout(false);
            this.gbIcecekler.ResumeLayout(false);
            this.gbIcecekler.PerformLayout();
            this.gbEkstraMalzeme.ResumeLayout(false);
            this.gbEkstraMalzeme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIleriTarih;
        private System.Windows.Forms.Button btnIleriSiparis;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.GroupBox gbIcecekler;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox cbSoda;
        private System.Windows.Forms.CheckBox cbAyran;
        private System.Windows.Forms.CheckBox cbKola;
        private System.Windows.Forms.GroupBox gbEkstraMalzeme;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox cbSalam;
        private System.Windows.Forms.CheckBox cbPeynir;
        private System.Windows.Forms.CheckBox cbSucuk;
        private System.Windows.Forms.Button btnHemenSiparis;
        private System.Windows.Forms.ComboBox cmbSecim;
        private System.Windows.Forms.ComboBox cmbPizzalar;
    }
}

