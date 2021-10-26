using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace NDP_ÖDEV2_SORU2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void matris_yazdırma_click(object sender, EventArgs e)
        {
            try
            {
                if (textBox13.Text == "")  //dosya adı girilmediyse çalışır.
                {

                    MessageBox.Show("oluşturulacak dosyanın adını giriniz");
                }
                else
                {
                    Directory.CreateDirectory("C:\\Dosyalar\\" + textBox13.Text); //dosya oluşturur.
                    MessageBox.Show("dosya başarıyla oluşturuldu.");
                    StreamWriter yaz = new StreamWriter(@"C:\Dosyalar\metinbelgesi.txt");
                    yaz.WriteLine(richTextBox1.Text);//dosyaya yazar.
                    yaz.Close(); //dosyayı kapattım.
                }
            }
            catch (Exception)
            {
                MessageBox.Show("dosyaya kayıt edilemedi.");
            }

        }

        private void matris_toplama(object sender, EventArgs e)
        {
            int m1, m2, m3, m4;
            int s1, s2, s3, s4;
            m1 = Convert.ToInt32(textBox1.Text);  //textboxtan girilen değerleri int değişkenlere atadım.
            m2 = Convert.ToInt32(textBox2.Text);
            m3 = Convert.ToInt32(textBox3.Text);
            m4 = Convert.ToInt32(textBox4.Text);
            s1 = Convert.ToInt32(textBox5.Text);
            s2 = Convert.ToInt32(textBox6.Text);
            s3 = Convert.ToInt32(textBox7.Text);
            s4 = Convert.ToInt32(textBox8.Text);
            textBox9.Text = (m1 + s1).ToString(); //sonuç matrisine yazdırdım.
            textBox10.Text = (m2 + s2).ToString();
            textBox11.Text = (m3 + s3).ToString();
            textBox12.Text = (m4 + s4).ToString();
            StreamWriter yaz = new StreamWriter(@"C:\Dosyalar\metinbelgesi.txt");
            yaz.WriteLine(textBox9.Text); //sonuç matrisini dosyaya kaydettim.
            yaz.WriteLine(textBox10.Text);
            yaz.WriteLine(textBox11.Text);
            yaz.WriteLine(textBox12.Text);
            yaz.Close(); //dosyayı kapattım.

        }

        private void matris_carpma(object sender, EventArgs e)
        {
            int m1, m2, m3, m4;
            int s1, s2, s3, s4;
            m1 = Convert.ToInt32(textBox1.Text); //textboxtan girilen değerleri int değişkenlere atadım.
            m2 = Convert.ToInt32(textBox2.Text);
            m3 = Convert.ToInt32(textBox3.Text);
            m4 = Convert.ToInt32(textBox4.Text);
            s1 = Convert.ToInt32(textBox5.Text);
            s2 = Convert.ToInt32(textBox6.Text);
            s3 = Convert.ToInt32(textBox7.Text);
            s4 = Convert.ToInt32(textBox8.Text);
            textBox9.Text = (m1 * s1) + (m2 * s3).ToString();  //çarpım sonucunu sonuç matrisine yazdırdım.
            textBox10.Text = (m1 * s2) + (m2 + s4).ToString();
            textBox11.Text = (m3 * s1) + (m4 * s3).ToString();
            textBox12.Text = (m3 * s2) + (m4 * s4).ToString();
            StreamWriter yaz = new StreamWriter(@"C:\Dosyalar\metinbelgesi.txt"); //dosyaya yazdırdım.
            yaz.WriteLine(textBox9.Text); //sonucu dosyaya yazdırdım.
            yaz.WriteLine(textBox10.Text);
            yaz.WriteLine(textBox11.Text);
            yaz.WriteLine(textBox12.Text);
            yaz.Close(); //dosyayı kapattım.
        }

        private void matris_okuma(object sender, EventArgs e)
        {
            try
            {
                StreamReader oku = new StreamReader(@"C:\Dosyalar\metinbelgesi.txt");//dosyadaki verileri okudum.
                richTextBox1.Text = oku.ReadToEnd();//okunan verileri richtextboxa yazdırdım.
                oku.Close(); //dosyadan okuma modunu kapattım.

            }
            catch (Exception)
            {
                MessageBox.Show("dosya okunamadı.");
            }
        }
        private void matris_tersi_alma(object sender, EventArgs e)
        {
            int m1, m2, m3, m4;
            m1 = Convert.ToInt32(textBox1.Text); //textboxtan girilen değerleri int değişkene atadım.
            m2 = Convert.ToInt32(textBox2.Text);
            m3 = Convert.ToInt32(textBox3.Text);
            m4 = Convert.ToInt32(textBox4.Text);
            textBox9.Text = (m4 / (m1 * m4 - m2 * m3)).ToString(); //girilen matrisin tersini sonuç matrisine yazdırdım.
            textBox10.Text = (-m2 / (m1 * m4 - m2 * m3)).ToString();
            textBox11.Text = (-m3 / (m1 * m4 - m2 * m3)).ToString();
            textBox12.Text = (m1 / (m1 * m4 - m2 * m3)).ToString();
            StreamWriter yaz = new StreamWriter(@"C:\Dosyalar\metinbelgesi.txt");
            yaz.WriteLine(textBox9.Text); //sonucu dosyaya yazdırdım.
            yaz.WriteLine(textBox10.Text);
            yaz.WriteLine(textBox11.Text);
            yaz.WriteLine(textBox12.Text);
            yaz.Close(); //dosyayı kapattım.
        }

        private void matris_izi(object sender, EventArgs e)
        {
            int m1, m2, m3, m4;
            m1 = Convert.ToInt32(textBox1.Text);//textboxtan girilen değerleri int değişkene atadım.
            m2 = Convert.ToInt32(textBox2.Text);
            m3 = Convert.ToInt32(textBox3.Text);
            m4 = Convert.ToInt32(textBox4.Text);

            richTextBox1.Text = (m1 + m4).ToString(); //sonucu yazdırdım.
            StreamWriter yaz = new StreamWriter(@"C:\Dosyalar\metinbelgesi.txt");
            yaz.WriteLine(textBox9.Text); //sonucu dosyaya kaydettim.
            yaz.Close(); //dosyanın yaz modunu kapattım.
        }

        private void matris_transpoze(object sender, EventArgs e)
        {
            int m1, m2, m3, m4;
            m1 = Convert.ToInt32(textBox1.Text); //textboxlardan girilen değerleri int değişkenlere atadım.
            m2 = Convert.ToInt32(textBox2.Text);
            m3 = Convert.ToInt32(textBox3.Text);
            m4 = Convert.ToInt32(textBox4.Text);
            textBox9.Text = m1.ToString(); //sonucu textboxlara yazdırdım.
            textBox10.Text = m3.ToString();
            textBox11.Text = m2.ToString();
            textBox12.Text = m4.ToString();
            StreamWriter yaz = new StreamWriter(@"C:\Dosyalar\metinbelgesi.txt");
            yaz.WriteLine(textBox9.Text);//sonucu dosyaya kaydettim.
            yaz.WriteLine(textBox10.Text);
            yaz.WriteLine(textBox11.Text);
            yaz.WriteLine(textBox12.Text);
            yaz.Close(); //dosyanın yaz modunu kapattım.
        }
    }
}
