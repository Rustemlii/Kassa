namespace Kassa2024
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnKodSiyahisi = new Button();
            btnElaveEt = new Button();
            btnGeriSil = new Button();
            groupBox1 = new GroupBox();
            textBoxOdenishEt = new TextBox();
            btnCCC = new Button();
            btnNomre_0 = new Button();
            btnBack = new Button();
            btnNomre_9 = new Button();
            btnNomre_8 = new Button();
            btnNomre_7 = new Button();
            btnEnter = new Button();
            btnNomre_3 = new Button();
            btnNomre_2 = new Button();
            btnVergul = new Button();
            btnNomre_6 = new Button();
            btnNomre_5 = new Button();
            btnNomre_4 = new Button();
            btnNomre_1 = new Button();
            button2 = new Button();
            textBoxMehsulKodu = new TextBox();
            labelMehsulKoduuu = new Label();
            label1UmumiMebleg = new Label();
            labelOdenilenMebleg = new Label();
            labelQaytarilanmebleg = new Label();
            labelUmumiManat = new Label();
            labelOdenilenManat = new Label();
            labelQaytarilanManat = new Label();
            dataGridView1 = new DataGridView();
            MalKod = new DataGridViewTextBoxColumn();
            MalAdi = new DataGridViewTextBoxColumn();
            MalSayi = new DataGridViewTextBoxColumn();
            SatisQiymeti = new DataGridViewTextBoxColumn();
            MalinToplamQiymeti = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            numericUpDown1 = new NumericUpDown();
            labelSay = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnKodSiyahisi
            // 
            btnKodSiyahisi.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnKodSiyahisi.Location = new Point(314, 91);
            btnKodSiyahisi.Name = "btnKodSiyahisi";
            btnKodSiyahisi.Size = new Size(153, 39);
            btnKodSiyahisi.TabIndex = 0;
            btnKodSiyahisi.Text = "Kod Siyahısı";
            btnKodSiyahisi.UseVisualStyleBackColor = true;
            btnKodSiyahisi.Click += btnKodSiyahisi_Click;
            // 
            // btnElaveEt
            // 
            btnElaveEt.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnElaveEt.Location = new Point(314, 136);
            btnElaveEt.Name = "btnElaveEt";
            btnElaveEt.Size = new Size(153, 39);
            btnElaveEt.TabIndex = 0;
            btnElaveEt.Text = "Əlavə et";
            btnElaveEt.UseVisualStyleBackColor = true;
            btnElaveEt.Click += btnElaveEt_Click;
            btnElaveEt.MouseLeave += btnElaveEt_MouseLeave;
            btnElaveEt.MouseMove += btnElaveEt_MouseMove;
            // 
            // btnGeriSil
            // 
            btnGeriSil.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnGeriSil.Location = new Point(314, 181);
            btnGeriSil.Name = "btnGeriSil";
            btnGeriSil.Size = new Size(153, 37);
            btnGeriSil.TabIndex = 2;
            btnGeriSil.Text = "Geri Sil";
            btnGeriSil.UseVisualStyleBackColor = true;
            btnGeriSil.Click += btnGeriSil_Click;
            btnGeriSil.MouseLeave += btnGeriSil_MouseLeave;
            btnGeriSil.MouseMove += btnGeriSil_MouseMove;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxOdenishEt);
            groupBox1.Controls.Add(btnCCC);
            groupBox1.Controls.Add(btnNomre_0);
            groupBox1.Controls.Add(btnBack);
            groupBox1.Controls.Add(btnNomre_9);
            groupBox1.Controls.Add(btnNomre_8);
            groupBox1.Controls.Add(btnNomre_7);
            groupBox1.Controls.Add(btnEnter);
            groupBox1.Controls.Add(btnNomre_3);
            groupBox1.Controls.Add(btnNomre_2);
            groupBox1.Controls.Add(btnVergul);
            groupBox1.Controls.Add(btnNomre_6);
            groupBox1.Controls.Add(btnNomre_5);
            groupBox1.Controls.Add(btnNomre_4);
            groupBox1.Controls.Add(btnNomre_1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(48, 270);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 326);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ödəniş et";
            // 
            // textBoxOdenishEt
            // 
            textBoxOdenishEt.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxOdenishEt.ImeMode = ImeMode.NoControl;
            textBoxOdenishEt.Location = new Point(59, 64);
            textBoxOdenishEt.MaxLength = 5;
            textBoxOdenishEt.Name = "textBoxOdenishEt";
            textBoxOdenishEt.PlaceholderText = "0 Azn";
            textBoxOdenishEt.Size = new Size(286, 47);
            textBoxOdenishEt.TabIndex = 0;
            textBoxOdenishEt.TextAlign = HorizontalAlignment.Center;
            textBoxOdenishEt.TextChanged += textBoxOdenishEt_TextChanged;
            // 
            // btnCCC
            // 
            btnCCC.Location = new Point(280, 279);
            btnCCC.Name = "btnCCC";
            btnCCC.Size = new Size(65, 41);
            btnCCC.TabIndex = 2;
            btnCCC.Text = "C";
            btnCCC.UseVisualStyleBackColor = true;
            btnCCC.Click += btnCCC_Click;
            // 
            // btnNomre_0
            // 
            btnNomre_0.Location = new Point(133, 279);
            btnNomre_0.Name = "btnNomre_0";
            btnNomre_0.Size = new Size(61, 41);
            btnNomre_0.TabIndex = 2;
            btnNomre_0.Text = "0";
            btnNomre_0.UseVisualStyleBackColor = true;
            btnNomre_0.Click += btnNomre_0_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnBack.Location = new Point(280, 232);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(65, 41);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNomre_9
            // 
            btnNomre_9.Location = new Point(200, 232);
            btnNomre_9.Name = "btnNomre_9";
            btnNomre_9.Size = new Size(61, 41);
            btnNomre_9.TabIndex = 2;
            btnNomre_9.Text = "9";
            btnNomre_9.UseVisualStyleBackColor = true;
            btnNomre_9.Click += btnNomre_9_Click;
            // 
            // btnNomre_8
            // 
            btnNomre_8.Location = new Point(133, 232);
            btnNomre_8.Name = "btnNomre_8";
            btnNomre_8.Size = new Size(61, 41);
            btnNomre_8.TabIndex = 2;
            btnNomre_8.Text = "8";
            btnNomre_8.UseVisualStyleBackColor = true;
            btnNomre_8.Click += btnNomre_8_Click;
            // 
            // btnNomre_7
            // 
            btnNomre_7.Location = new Point(59, 232);
            btnNomre_7.Name = "btnNomre_7";
            btnNomre_7.Size = new Size(61, 41);
            btnNomre_7.TabIndex = 2;
            btnNomre_7.Text = "7";
            btnNomre_7.UseVisualStyleBackColor = true;
            btnNomre_7.Click += btnNomre_7_Click;
            // 
            // btnEnter
            // 
            btnEnter.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEnter.Location = new Point(280, 138);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(65, 41);
            btnEnter.TabIndex = 2;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnNomre_3
            // 
            btnNomre_3.Location = new Point(200, 138);
            btnNomre_3.Name = "btnNomre_3";
            btnNomre_3.Size = new Size(61, 41);
            btnNomre_3.TabIndex = 2;
            btnNomre_3.Text = "3";
            btnNomre_3.UseVisualStyleBackColor = true;
            btnNomre_3.Click += btnNomre_3_Click;
            // 
            // btnNomre_2
            // 
            btnNomre_2.Location = new Point(133, 138);
            btnNomre_2.Name = "btnNomre_2";
            btnNomre_2.Size = new Size(61, 41);
            btnNomre_2.TabIndex = 2;
            btnNomre_2.Text = "2";
            btnNomre_2.UseVisualStyleBackColor = true;
            btnNomre_2.Click += btnNomre_2_Click;
            // 
            // btnVergul
            // 
            btnVergul.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnVergul.Location = new Point(280, 185);
            btnVergul.Name = "btnVergul";
            btnVergul.Size = new Size(65, 41);
            btnVergul.TabIndex = 2;
            btnVergul.Text = ",";
            btnVergul.UseVisualStyleBackColor = true;
            btnVergul.Click += btnVergul_Click;
            // 
            // btnNomre_6
            // 
            btnNomre_6.Location = new Point(200, 186);
            btnNomre_6.Name = "btnNomre_6";
            btnNomre_6.Size = new Size(61, 40);
            btnNomre_6.TabIndex = 2;
            btnNomre_6.Text = "6";
            btnNomre_6.UseVisualStyleBackColor = true;
            btnNomre_6.Click += btnNomre_6_Click;
            // 
            // btnNomre_5
            // 
            btnNomre_5.Location = new Point(133, 185);
            btnNomre_5.Name = "btnNomre_5";
            btnNomre_5.Size = new Size(61, 41);
            btnNomre_5.TabIndex = 2;
            btnNomre_5.Text = "5";
            btnNomre_5.UseVisualStyleBackColor = true;
            btnNomre_5.Click += btnNomre_5_Click;
            // 
            // btnNomre_4
            // 
            btnNomre_4.Location = new Point(59, 185);
            btnNomre_4.Name = "btnNomre_4";
            btnNomre_4.Size = new Size(61, 41);
            btnNomre_4.TabIndex = 2;
            btnNomre_4.Text = "4";
            btnNomre_4.UseVisualStyleBackColor = true;
            btnNomre_4.Click += btnNomre_4_Click;
            // 
            // btnNomre_1
            // 
            btnNomre_1.Location = new Point(59, 138);
            btnNomre_1.Name = "btnNomre_1";
            btnNomre_1.Size = new Size(61, 41);
            btnNomre_1.TabIndex = 2;
            btnNomre_1.Text = "1";
            btnNomre_1.UseVisualStyleBackColor = true;
            btnNomre_1.Click += btnNomre_1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(841, 201);
            button2.Name = "button2";
            button2.Size = new Size(279, 47);
            button2.TabIndex = 2;
            button2.Text = "Sistemi sıfırla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button2.MouseLeave += button2_MouseLeave;
            button2.MouseHover += button2_MouseHover;
            button2.MouseMove += button2_MouseMove;
            // 
            // textBoxMehsulKodu
            // 
            textBoxMehsulKodu.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxMehsulKodu.Location = new Point(133, 94);
            textBoxMehsulKodu.Name = "textBoxMehsulKodu";
            textBoxMehsulKodu.Size = new Size(151, 43);
            textBoxMehsulKodu.TabIndex = 0;
            textBoxMehsulKodu.TextChanged += textBoxMehsulKodu_TextChanged;
            // 
            // labelMehsulKoduuu
            // 
            labelMehsulKoduuu.AutoSize = true;
            labelMehsulKoduuu.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelMehsulKoduuu.Location = new Point(133, 53);
            labelMehsulKoduuu.Name = "labelMehsulKoduuu";
            labelMehsulKoduuu.Size = new Size(151, 31);
            labelMehsulKoduuu.TabIndex = 4;
            labelMehsulKoduuu.Text = "Məhsul kodu";
            // 
            // label1UmumiMebleg
            // 
            label1UmumiMebleg.AutoSize = true;
            label1UmumiMebleg.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1UmumiMebleg.Location = new Point(822, 53);
            label1UmumiMebleg.Name = "label1UmumiMebleg";
            label1UmumiMebleg.Size = new Size(192, 31);
            label1UmumiMebleg.TabIndex = 5;
            label1UmumiMebleg.Text = "Ümumi məbləğ :";
            // 
            // labelOdenilenMebleg
            // 
            labelOdenilenMebleg.AutoSize = true;
            labelOdenilenMebleg.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelOdenilenMebleg.Location = new Point(805, 94);
            labelOdenilenMebleg.Name = "labelOdenilenMebleg";
            labelOdenilenMebleg.Size = new Size(209, 31);
            labelOdenilenMebleg.TabIndex = 6;
            labelOdenilenMebleg.Text = "Ödənilən məbləğ :";
            // 
            // labelQaytarilanmebleg
            // 
            labelQaytarilanmebleg.AutoSize = true;
            labelQaytarilanmebleg.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelQaytarilanmebleg.Location = new Point(785, 136);
            labelQaytarilanmebleg.Name = "labelQaytarilanmebleg";
            labelQaytarilanmebleg.Size = new Size(229, 31);
            labelQaytarilanmebleg.TabIndex = 7;
            labelQaytarilanmebleg.Text = "Qaytarılan məbləğ :";
            // 
            // labelUmumiManat
            // 
            labelUmumiManat.AutoSize = true;
            labelUmumiManat.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelUmumiManat.Location = new Point(1048, 53);
            labelUmumiManat.Name = "labelUmumiManat";
            labelUmumiManat.Size = new Size(74, 31);
            labelUmumiManat.TabIndex = 8;
            labelUmumiManat.Text = "0 Azn";
            // 
            // labelOdenilenManat
            // 
            labelOdenilenManat.AutoSize = true;
            labelOdenilenManat.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelOdenilenManat.Location = new Point(1048, 94);
            labelOdenilenManat.Name = "labelOdenilenManat";
            labelOdenilenManat.Size = new Size(74, 31);
            labelOdenilenManat.TabIndex = 9;
            labelOdenilenManat.Text = "0 Azn";
            // 
            // labelQaytarilanManat
            // 
            labelQaytarilanManat.AutoSize = true;
            labelQaytarilanManat.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelQaytarilanManat.Location = new Point(1048, 139);
            labelQaytarilanManat.Name = "labelQaytarilanManat";
            labelQaytarilanManat.Size = new Size(74, 31);
            labelQaytarilanManat.TabIndex = 10;
            labelQaytarilanManat.Text = "0 Azn";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MalKod, MalAdi, MalSayi, SatisQiymeti, MalinToplamQiymeti });
            dataGridView1.Location = new Point(595, 280);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(643, 316);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MalKod
            // 
            MalKod.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            MalKod.DataPropertyName = "MalKod";
            MalKod.FillWeight = 116.149734F;
            MalKod.HeaderText = "Malın Kodu";
            MalKod.MinimumWidth = 6;
            MalKod.Name = "MalKod";
            MalKod.Width = 118;
            // 
            // MalAdi
            // 
            MalAdi.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            MalAdi.DataPropertyName = "MalAdi";
            MalAdi.FillWeight = 116.149734F;
            MalAdi.HeaderText = "Malın Adı";
            MalAdi.MinimumWidth = 6;
            MalAdi.Name = "MalAdi";
            MalAdi.Width = 118;
            // 
            // MalSayi
            // 
            MalSayi.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            MalSayi.DataPropertyName = "MalSayi";
            MalSayi.FillWeight = 116.149734F;
            MalSayi.HeaderText = "Sayı";
            MalSayi.MinimumWidth = 6;
            MalSayi.Name = "MalSayi";
            MalSayi.Width = 118;
            // 
            // SatisQiymeti
            // 
            SatisQiymeti.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SatisQiymeti.DataPropertyName = "SatisQiymeti";
            SatisQiymeti.FillWeight = 116.149734F;
            SatisQiymeti.HeaderText = "Satış Qiyməti";
            SatisQiymeti.MinimumWidth = 6;
            SatisQiymeti.Name = "SatisQiymeti";
            SatisQiymeti.Width = 119;
            // 
            // MalinToplamQiymeti
            // 
            MalinToplamQiymeti.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            MalinToplamQiymeti.DataPropertyName = "MalinToplamQiymeti";
            MalinToplamQiymeti.FillWeight = 116.149734F;
            MalinToplamQiymeti.HeaderText = "Toplam Qiymet";
            MalinToplamQiymeti.MinimumWidth = 6;
            MalinToplamQiymeti.Name = "MalinToplamQiymeti";
            MalinToplamQiymeti.Width = 118;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Cornsilk;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(512, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(133, 181);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.ReadOnly = true;
            numericUpDown1.Size = new Size(150, 38);
            numericUpDown1.TabIndex = 13;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // labelSay
            // 
            labelSay.AutoSize = true;
            labelSay.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelSay.Location = new Point(133, 144);
            labelSay.Name = "labelSay";
            labelSay.Size = new Size(52, 31);
            labelSay.TabIndex = 4;
            labelSay.Text = "Say";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(1241, 608);
            Controls.Add(numericUpDown1);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(labelQaytarilanManat);
            Controls.Add(labelOdenilenManat);
            Controls.Add(labelUmumiManat);
            Controls.Add(labelQaytarilanmebleg);
            Controls.Add(labelOdenilenMebleg);
            Controls.Add(label1UmumiMebleg);
            Controls.Add(labelSay);
            Controls.Add(labelMehsulKoduuu);
            Controls.Add(textBoxMehsulKodu);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(btnGeriSil);
            Controls.Add(btnElaveEt);
            Controls.Add(btnKodSiyahisi);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kassa";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKodSiyahisi;
        private Button btnElaveEt;
        private Button btnGeriSil;
        private GroupBox groupBox1;
        private Button btnCCC;
        private Button btnNomre_0;
        private Button btnBack;
        private Button btnNomre_9;
        private Button btnNomre_8;
        private Button btnNomre_7;
        private Button btnEnter;
        private Button btnNomre_3;
        private Button btnNomre_2;
        private Button btnVergul;
        private Button btnNomre_6;
        private Button btnNomre_5;
        private Button btnNomre_4;
        private Button btnNomre_1;
        private Button button2;
        private TextBox textBoxOdenishEt;
        private TextBox textBoxMehsulKodu;
        private Label labelMehsulKoduuu;
        private Label label1UmumiMebleg;
        private Label labelOdenilenMebleg;
        private Label labelQaytarilanmebleg;
        private Label labelUmumiManat;
        private Label labelOdenilenManat;
        private Label labelQaytarilanManat;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private NumericUpDown numericUpDown1;
        private Label labelSay;
        private DataGridViewTextBoxColumn MalKod;
        private DataGridViewTextBoxColumn MalAdi;
        private DataGridViewTextBoxColumn MalSayi;
        private DataGridViewTextBoxColumn SatisQiymeti;
        private DataGridViewTextBoxColumn MalinToplamQiymeti;
    }
}