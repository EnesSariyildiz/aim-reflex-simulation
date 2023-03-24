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

        int sayac1;
        // Global olarak int veri tipinde bir değişken tanımlıyoruz.
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac1++;
            // Sayacı bir bir artırıyoruz.

            LblDeneme.Text = sayac1.ToString();
            // Sayacı label1 adlı değişkene yazdırıyoruz. Sadece ekranda programcı görecek o yüzden program çalışırken
            // visible özelliğini false yapıyoruz.
           
            switch (LblDeneme.Text)
            {
                case "10":
                    pictureBoxLeft.Visible = true;
                    // Sayac 10 oldugu zaman pictureBox'in visible özelliğini true yapıyoruz.
                    break;
                case "17":
                    pictureBoxLeft.Visible = false;
                    // Sayac 17 oldugu zaman pictureBoxLeft'in visible'ini false yapiyoruz.
                    break;
                case "20":
                    pictureBoxCenter.Visible = true;
                    // Sayac 20 oldugu zaman pictureBoxCenter'in visible'ini true yapiyoruz.
                    break;
                case "27":
                    pictureBoxCenter.Visible = false;
                    // Sayac 20 oldugu zaman pictureBoxCenter'in visible'ini false yapiyoruz.
                    break;
                case"30":
                    pictureBoxRight.Visible=true; 
                    // Sayac 30 oldugu zaman pictureBoxRight'in visible ozelligini true yapiyoruz.
                    break;
                case "37":
                    pictureBoxRight.Visible = false;
                    // Sayac 30 oldugu zaman pictureBoxRight'in visible ozelligini false yapiyoruz.
                    break;
                default:
                    break;
            }
            if (sayac1==37)
            {
                sayac1 = 4;
                // Sayac 40 oldugu zaman sayaci 0'dan baslatiyoruz.
                
            }


        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
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
            sayac1 = 0;
            // Sayacin degerini 0 olarak belirliyoruz.
            timer1.Stop();
            // Timer1'i durduruyoruz.
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
