using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Events.xaml
    /// </summary>
    public partial class Events : Window
    {
        int Toplam = 0;
        public Events()
        {
            InitializeComponent();

            

            Random rnd = new Random();
            //Buton1.Content = rnd.Next(10, 30);
            //Buton2.Content = rnd.Next(31, 60);
            //Buton3.Content = rnd.Next(61, 100);

            foreach (UIElement item in grd.Children) //gride isim veriyoruz grid içindeki butonlar children grd.Children diye ulaşırız
            {
                if (item is Button) // is tip tespiti için kullanılır  burda grid içindeki tipler butonsa işlem yapacak
                {
                    Button btn = (Button)item;
                    if (btn.Tag !=null && btn.Tag.ToString()=="1") // tag atamadığımız butonlar null olduğu için gösterecek bişey olmadığından hata verir null yapacağız. 
                    {
                        btn.Content = rnd.Next(10, 100);
                    }

                    //if (btn.Name !="ButonSonuc")
                    //{
                    //    btn.Content = rnd.Next(10, 100);
                    //}

                   
                }
                
            }

        }



        private void Msg(object sender, RoutedEventArgs e) // botunların eventlerine tıklandığında (şimşek işaretine tıklayıp hepsine Msg yazarsan (sen ne tanımlarsan ) hepsinde aynı mesaj yazar
        {
            

            Button buton = (Button)sender; // sender object tipindedir hangi nesneye tıkladığını gösterir.
            //MessageBox.Show(btn.Content.ToString());
            if (buton.Name=="ButonSonuc")
            {
                MessageBox.Show($"İşlemin Sonucu :{Toplam} ");
            }
            else
            {
                Toplam += Convert.ToInt32(buton.Content); // castinglerde hata yaşarsak (Toplam+=(int)buton.Content; Convert.Toınt32(buton.Content); yazacağız
                buton.Visibility = Visibility.Hidden; // tıkladığın butonu kaybet (gizle)
            }

            


           



        }

       
    }
}
