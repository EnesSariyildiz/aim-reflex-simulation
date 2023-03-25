using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aim_reflex_simulation
{
    public partial class FrmChapterOne : Form
    {
        public FrmChapterOne()
        {
            InitializeComponent();
            pictureBoxLeft.Visible = false;
            pictureBoxRight.Visible = false;
            pictureBoxCenter.Visible = false;
            // Uygulama calistigi zaman pictureBox'larimizin gözükmemesini istedigimiz icin
            // visible ozelliklerini false yapiyoruz, o yuzden formun load'ina yaziyoruz.
        }

        int counter1,totalCounter;
        // Global olarak int veri tipinde bir değişken tanımlıyoruz.

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter1++;
            // Sayacı bir bir artırıyoruz.

            LblDeneme.Text = counter1.ToString();
            // Sayacı label1 adlı değişkene yazdırıyoruz. Sadece ekranda programcı görecek o yüzden program çalışırken
            // visible özelliğini false yapıyoruz.

            switch (LblDeneme.Text)
            {
                case "4":
                    LblInform.Text = " ";
                    // Sayac 4 oldugu zaman ekrandan Shooter Ready ? textini kaldiriyor.
                    break;
                case "6":
                    pictureBoxLeft.Visible = true;
                    // Sayac 6 oldugu zaman pictureBox'in visible özelliğini true yapiyor.
                    break;
                case "9":
                    pictureBoxLeft.Visible = false;
                    // Sayac 9 oldugu zaman pictureBoxLeft'in visible'ini false yapiyor.
                    break;
                case "12":
                    pictureBoxCenter.Visible = true;
                    // Sayac 12 oldugu zaman pictureBoxCenter'in visible'ini true yapiyor.
                    break;
                case "15":
                    pictureBoxCenter.Visible = false;
                    // Sayac 15 oldugu zaman pictureBoxCenter'in visible'ini false yapiyor.
                    break;
                case "18":
                    pictureBoxRight.Visible = true;
                    // Sayac 18 oldugu zaman pictureBoxRight'in visible ozelligini true yapiyor.
                    break;
                case "21":
                    pictureBoxRight.Visible = false;
                    // Sayac 21 oldugu zaman pictureBoxRight'in visible ozelligini false yapiyor.
                    break;
                default:
                    break;
            }

            if (counter1 == 21)
            {
                counter1 = 2;
                // Sayac 21 oldugu zaman sayaci 2'dan baslatiyoruz.

                totalCounter++;
                // counter1, bir dongu tamamladigi zaman totalCounteri bir artiriyor.

                if (totalCounter==2)
                {
                    timer1.Stop();
                    // totalCounter degiskenimiz toplamda 2 oldugu zaman programi durduruyor.
                    // Cünkü bu bolumun sadece 2 defa tekrarlanmasini istiyoruz.

                    LblInform.Text = " Congratulations, you have completed part 1. ";
                    // Bolum sonunda ekranda tebrik mesaji cikiyor.
                }

            }


        }

        string shooterReady = "Shooter Ready ?";
        
        // Global olarak string veri tipinde degiskenimizi tanimliyoruz.

        private void BtnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            // Timer'i baslatiyoruz.


            LblInform.Text = shooterReady;
            // Aticiya hazir olup olmadigini bildiriyoruz.
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            // Stop butonuna tıklandığı zaman timer'ı durduruyoruz.

        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            pictureBoxLeft.Visible = false;
            pictureBoxRight.Visible = false;
            pictureBoxCenter.Visible = false;
            // Bu butona tiklandigi zaman restart olacagi icin kısaca default ozelliklerine geri dönmesi gerekiyor 
            // o yuzden butun ozellikleri sifirliyoruz.

            counter1 = 0;
            // Sayacin degerini 0 olarak belirliyoruz.

            timer1.Stop();
            // Timer1'i durduruyoruz.

            LblInform.Text = " ";
            // Kullanici ekranina bos deger yazdiriyoruz.
        }

        private void chapter1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmChapterTwo newForm = new FrmChapterTwo();
            // FrmChapterTwo formundan bir nesne turetiyoruz ve newForm degiskenine atama yapiyoruz.

            this.Hide();
            // Bu formu gizliyoruz.

            newForm.Show();
            // Yeni formu gosteriyoruz.
        }

        private void chapter1ToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void FrmChapterOne_Load(object sender, EventArgs e)
        {

        }
    }
}
