using System;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace WpfApp1
{



    // skor 50 ye geldi bi tane bonus butonu çıktı ona tıkladı puanı aldı buton kayboldu.


    /// <summary>
    /// Interaction logic for KaçanButon.xaml
    /// </summary>
    #region Tanımlamalar
       
    public partial class KaçanButon : Window
    {
        Oyuncu o;
        int sure = 3;
        DispatcherTimer timer = new DispatcherTimer();


        public KaçanButon()
        {
            InitializeComponent();
            //MessageBox.Show(this.Width.ToString());
            //MessageBox.Show(this.Height.ToString());
            KacanButon1.MouseMove += KacanButon1_MouseMove;

        }

        int Puan = 0;
        #endregion


        #region Constructorlar

        private void KacanButon1_MouseMove(object sender, MouseEventArgs e)
        {

            Random rnd1 = new Random();
            //KacanButon1.Margin=new Thickness(this.Width.ToString(),);

            //KacanButon1.Margin = new Thickness(rnd1.Next(200), rnd1.Next(200), rnd1.Next(200), rnd1.Next(200));

            KacanButon1.Margin = new Thickness(rnd1.Next((int)(grdıcerık.ColumnDefinitions[0].ActualWidth - KacanButon1.Width)), rnd1.Next((int)(grdıcerık.ActualHeight - KacanButon1.Height)), 0, 0);


            Puan++;
            KacanButon1.Content = Puan;
            lbl1.Content = Puan;


            //SonKonum = KacanButon1.Margin=(X ,Y);

            ////if () 
            ////{

            ////}


        }




        private void Lbl1_SizeChanged_1(object sender, SizeChangedEventArgs e)
        {
            //lbl1.Content = "Height:" + this.Height.ToString() + "\nMaxHeight:" + this.MaxHeight + "\nActual Height:" + this.ActualHeight + "\nRender Size Width:" + this.RenderSize.Width + "\nRender:" + this.RenderSize.Width + "\nRender Size Height:" + this.RenderSize.Height + "\nBorderWidth:" + SystemParameters.BorderWidth + "\nCaption Height:" + SystemParameters.CaptionHeight;
            ;
            Puan++; // ++ olursa +1 +1 artar istediğin sayıda artırırsan +=; yapacaksın 
            KacanButon1.Content = Puan;

            Title = "Kaçan Buton Oyunu";

        }

        #endregion

        #region KAÇAN BUTON
        public KaçanButon(Oyuncu o)
        {

            InitializeComponent();
            this.o = o;
            lblAdSoyad.Content = $"{o.Ad} {o.Soyad}";
            timer.Tick += Timer_Tick;
            OyunuBaslat();



        }
        #endregion


        #region Timer Click İventi
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (sure == 0)
            {
                SkorKaydet(Puan, DateTime.Now, o);
                timer.Stop();
                KacanButon1.Visibility = Visibility.Hidden;
                MessageBoxResult cevap = MessageBox.Show($"Oyun Bitti Kanka Bidaha Kapışalım mı?\n Puanın{Puan}\nYeniden Başlamak İstermisin?", "Oyun Bitti", MessageBoxButton.YesNo);
                if (cevap == MessageBoxResult.Yes)
                {

                    OyunuBaslat();

                }
                else
                {
                    MessageBox.Show("OYUN BİTTİ KAYBOL");
                    Application.Current.Shutdown();
                }
            }
            else
            {
                Sayac.Content = sure;
                sure--;

            }




        } 
        #endregion
        #region Oyunu Başlat Klası

        public void OyunuBaslat()
        {
            sure = 3;
            Puan = 0;
            KacanButon1.Visibility = Visibility.Visible;
            lbl1.Content = Puan;
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
            this.WindowState = WindowState.Maximized;
         

        }
        #endregion

        #region Skor Kayıt
        void SkorKaydet(int puan, DateTime Tarih, Oyuncu o)
        {
            File.AppendAllText(@"D:\Skorlar.txt", $"{o.Ad} {o.Soyad} İsimli Oyuncu {Tarih} Tarihinde {Puan} Puan Aldı.\n\r");
        }
        #endregion

        private void BtnSkorGoster_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(File.ReadAllText(@"D:\Skorlar.txt"));
        }
    }
}
