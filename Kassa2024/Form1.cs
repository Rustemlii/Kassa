
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using System.Numerics;
using QRCoder;


namespace Kassa2024
{
    public partial class Form1 : Form
    {
        //Mal silindikce qr code bir evvelki qrcoda cevrile bilirmi???
        // Her geri sil basilanda odenilen mebleg geri qaytsn------------------------------Hell eledim..
        // textbox uzunlugu..--------------------------------------------------------------Hell eledim..
        // rowslari silerken umumi manatinda silinmesi-------------------------------------hell olundu..
        // qrcode--------------------------------------------------------------------------hell eledim..
        // geri sil basdiqda ferqli mehsul kodlarinda iwlemir------------------------------Hell eledim..
        //reqemler duzgun iwlemir ","-e gore ----------------------------------------------Hell eledim..

        Product p = new Product();
        decimal qiymet;
        decimal FaktikiQiymet;
        int index;
        decimal odenilen = 0;
        decimal qaytarilan = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnKodSiyahisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"100-{p.Name[0]}\n101-{p.Name[1]}\n102-{p.Name[2]}", "Melumat", MessageBoxButtons.OK);
        }

        private void btnElaveEt_Click(object sender, EventArgs e)
        {
            if (textBoxMehsulKodu.Text == p.Id[0] && numericUpDown1.Value != 0)
            {
                //= -den sonraki qiymeti ona gore yaziriqki evvelki qiymet deyeri == -den sonraki qiymetin icerisinde olur.....
                FaktikiQiymet = numericUpDown1.Value * p.Price[0];
                qiymet = qiymet + (numericUpDown1.Value * p.Price[0]);
                dataGridView1.Rows.Add(p.Id[0], p.Name[0], numericUpDown1.Value, p.Price[0] + " " + "Azn", FaktikiQiymet + " " + "Azn");

                //muwteri qabaqcadan pul oduyerse eger hemin puldan elave olunacaq mallar cixilsin
                if (qaytarilan != 0)
                {


                    qaytarilan = qaytarilan - (numericUpDown1.Value * p.Price[0]);
                    labelQaytarilanManat.Text = qaytarilan.ToString() + " " + "Azn";
                }


                labelUmumiManat.Text = qiymet.ToString() + " " + "Azn";


            }
            else if (textBoxMehsulKodu.Text == p.Id[1] && numericUpDown1.Value != 0)
            {
                FaktikiQiymet = numericUpDown1.Value * p.Price[1];
                qiymet = qiymet + (numericUpDown1.Value * p.Price[1]);
                dataGridView1.Rows.Add(p.Id[1], p.Name[1], numericUpDown1.Value, p.Price[1] + " " + "Azn", FaktikiQiymet + " " + "Azn");

                //muwteri qabaqcadan pul oduyerse eger hemin puldan elave olunacaq mallar cixilsin
                if (qaytarilan != 0)
                {
                    qaytarilan = qaytarilan - FaktikiQiymet;
                    labelQaytarilanManat.Text = qaytarilan.ToString() + " " + "Azn";

                }



                labelUmumiManat.Text = qiymet.ToString() + " " + "Azn";

            }
            else if (textBoxMehsulKodu.Text == p.Id[2] && numericUpDown1.Value != 0)
            {
                FaktikiQiymet = numericUpDown1.Value * p.Price[2];
                qiymet = qiymet + (numericUpDown1.Value * p.Price[2]);
                dataGridView1.Rows.Add(p.Id[2], p.Name[2], numericUpDown1.Value, p.Price[2] + " " + "Azn", FaktikiQiymet + " " + "Azn");

                //muwteri qabaqcadan pul oduyerse eger hemin puldan elave olunacaq mallar cixilsin
                if (qaytarilan != 0)
                {
                    qaytarilan = qaytarilan - FaktikiQiymet;
                    labelQaytarilanManat.Text = qaytarilan.ToString() + " " + "Azn";

                }


                labelUmumiManat.Text = qiymet.ToString() + " " + "Azn";

            }
            else if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Xahish olunur mehsulun sayini qeyd edin", "Melumat", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Xahish edirik mehsulun kodunu duzgun qeyd edin...", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            index = dataGridView1.Rows.Count - 2; // datagriddeki sonuncu elave olunan malin qrcodunu gotursun deye bunu yaziriq..count 1 oldugunnan
                                                  // ( Malkodu,MalAdi... 1 bunu goturur) -2 yaziriqki 1 olaraq ilk elave etdiyimiz mali gotursun..
                                                  // datagrid[1,index] burdaki 1 ise dataqriddeki Maladini goturmeyinnen oteridir...

            QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
            QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(dataGridView1[1, index].Value.ToString(), QRCodeGenerator.ECCLevel.Q);
            QRCode qRCode = new QRCode(qRCodeData);
            Bitmap qrCodeImage = qRCode.GetGraphic(20);
            pictureBox1.Image = qrCodeImage;

            numericUpDown1.Value = 0; // Her mal elave olunduqda numeric avtomatik Sifirlansin...
            textBoxMehsulKodu.Clear();

        }

        private void textBoxMehsulKodu_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBoxMehsulKodu.Text))
            {
                try
                {
                    Convert.ToInt32(textBoxMehsulKodu.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("Xahis edirik Mehsul kodunu duzgun yazin.", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxMehsulKodu.Clear();

                }
            }

        }

        private void btnNomre_1_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            textBoxOdenishEt.Text += btn.Text;

        }

        private void btnNomre_2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBoxOdenishEt.Text += btn.Text;
        }

        private void btnNomre_3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBoxOdenishEt.Text += btn.Text;
        }

        private void btnNomre_4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBoxOdenishEt.Text += btn.Text;
        }

        private void btnNomre_5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBoxOdenishEt.Text += btn.Text;
        }

        private void btnNomre_6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBoxOdenishEt.Text += btn.Text;
        }

        private void btnNomre_7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBoxOdenishEt.Text += btn.Text;
        }

        private void btnNomre_8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBoxOdenishEt.Text += btn.Text;
        }

        private void btnNomre_9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBoxOdenishEt.Text += btn.Text;
        }

        private void btnNomre_0_Click(object sender, EventArgs e)
        {
            if (textBoxOdenishEt.Text != "0")
            {
                Button btn = (Button)sender;
                textBoxOdenishEt.Text += btn.Text;
            }
            else
            {
                MessageBox.Show("Reqemleri duzgun yazin", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxOdenishEt.Clear();
            }
        }

        private void btnVergul_Click(object sender, EventArgs e)
        {
            if (!textBoxOdenishEt.Text.Contains(","))
            {
                textBoxOdenishEt.Text += ",";
            }
            else
            {
                MessageBox.Show("Reqemleri duzgun yazin", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxOdenishEt.Clear();
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (textBoxOdenishEt.Text != string.Empty)
            {
                textBoxOdenishEt.Text = textBoxOdenishEt.Text.Remove(textBoxOdenishEt.Text.Length - 1);
            }

        }

        private void btnCCC_Click(object sender, EventArgs e)
        {
            textBoxOdenishEt.Clear();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            qaytarilan = Convert.ToDecimal(textBoxOdenishEt.Text);


            if (!string.IsNullOrEmpty(labelUmumiManat.Text))
            {
                odenilen = odenilen + qaytarilan;
                labelOdenilenManat.Text = odenilen.ToString() + " " + "Azn";
                qaytarilan = odenilen - qiymet;
                labelQaytarilanManat.Text = qaytarilan.ToString() + " " + "Azn";
            }
            else 
            {
                MessageBox.Show("Mebleg yeterli deyil", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelOdenilenManat.Text = "0 Azn";
            }

            textBoxOdenishEt.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            odenilen = 0;
            qaytarilan = 0;
            qiymet = 0; //-- sifirliyan zaman evvelki qiymeti yaddawinda saxlamasin deye yazilir..
            textBoxOdenishEt.Clear();
            labelOdenilenManat.Text = "0 Azn";
            labelUmumiManat.Text = "0 Azn";
            labelQaytarilanManat.Text = "0 Azn";
            dataGridView1.Rows.Clear();
            numericUpDown1.Value = 0;
            textBoxMehsulKodu.Clear();
            pictureBox1.Image = null;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxOdenishEt_TextChanged(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(textBoxOdenishEt.Text))
            {

                try
                {
                    Convert.ToDecimal(textBoxOdenishEt.Text);

                }
                catch (Exception)
                {
                    MessageBox.Show("Xahis edirik reqemleri duzgun yazin.", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxOdenishEt.Clear();
                }
            }
            //Textboxda yazi limitinin qurulmasi...
            int a = textBoxOdenishEt.TextLength;
            if (a >= 7)
            {
                MessageBox.Show("Xahis edirik yazi limitini kecmeyin..", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxOdenishEt.Clear();
            }


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGeriSil_Click(object sender, EventArgs e)
        {

            index = dataGridView1.Rows.Count - 2; // sonuncu indexi gotrur..Cunki datagridview countu 1-den hesablayir ve
                                                  // icerisinde olan rowlarin sayindan 2 cixir index 0-dan hesablandigi ucun -2 yaziriqki
                                                  // saylar ust uste duwsun


            if (index >= 0)
            {
                if (dataGridView1[0, index].Value == p.Id[0])  // 0-ci index yeni mal kodu----index ise secilen malkodunun en son elave olunmuw kodu
                {
                    qiymet = qiymet - (p.Price[0] * (Convert.ToDecimal(dataGridView1[2, index].Value)));//--2-ci index yeni Say olan yer,index ise secilen sayin sonda elave olunmuw setirdeki sayi
                    labelUmumiManat.Text = qiymet.ToString() + " " + "Azn";
                    dataGridView1.Rows.RemoveAt(index);//-- obwi setiri silmek ucun

                    qaytarilan = odenilen - qiymet;  //--yeni mal her silinende qaytarilan labela pul geri qaytsin deye yaziriq....
                    labelQaytarilanManat.Text = qaytarilan.ToString() + " " + "Azn";

                }
                else if (dataGridView1[0, index].Value == p.Id[1])
                {
                    qiymet = qiymet - (p.Price[1] * (Convert.ToDecimal(dataGridView1[2, index].Value)));
                    labelUmumiManat.Text = qiymet.ToString() + " " + "Azn";
                    dataGridView1.Rows.RemoveAt(index);

                    qaytarilan = odenilen - qiymet;
                    labelQaytarilanManat.Text = qaytarilan.ToString() + " " + "Azn";
                }
                else if (dataGridView1[0, index].Value == p.Id[2])
                {
                    qiymet = qiymet - (p.Price[2] * (Convert.ToDecimal(dataGridView1[2, index].Value)));
                    labelUmumiManat.Text = qiymet.ToString() + " " + "Azn";
                    dataGridView1.Rows.RemoveAt(index);

                    qaytarilan = odenilen - qiymet;
                    labelQaytarilanManat.Text = qaytarilan.ToString() + " " + "Azn";
                }

                if (index == 0)
                {
                    pictureBox1.Image = null; // index 0 olarsa qrcode silinsin...
                }
            }
            else
            {
                MessageBox.Show("Silinecek mal yoxdur", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            if (qiymet == 0)// muwterinin odediyi pul sisteme vurular sora imtina etse almaqdan neyise
                            // geri sil tamamile sifirlananda metnler beraber olsun
            {
                labelQaytarilanManat.Text = labelOdenilenManat.Text;
            }











        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {


        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }

        private void btnElaveEt_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnElaveEt_MouseLeave(object sender, EventArgs e)
        {
            btnElaveEt.BackColor = Color.White;
        }

        private void btnGeriSil_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnGeriSil_MouseLeave(object sender, EventArgs e)
        {
            btnGeriSil.BackColor = System.Drawing.Color.White;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        private void btnElaveEt_MouseMove(object sender, MouseEventArgs e)
        {
            btnElaveEt.BackColor = Color.Green;
        }

        private void btnGeriSil_MouseMove(object sender, MouseEventArgs e)
        {
            btnGeriSil.BackColor = Color.Red;
        }

        private void labelOdenilenManat_Click(object sender, EventArgs e)
        {

        }
    }

}