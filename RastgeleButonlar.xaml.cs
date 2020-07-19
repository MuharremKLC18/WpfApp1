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
    /// Interaction logic for RastgeleButonlar.xaml
    /// </summary>
    public partial class RastgeleButonlar : Window
    {


        int toplam = 0;
        public RastgeleButonlar()
        {

            InitializeComponent();
            Random rnd = new Random();
           
            for (int i = 0; i < 20; i++)
            {
                Button butonlar = new Button();
                butonlar.Content = rnd.Next(1, 50);
                // butonlar.Margin = new Thickness(i*-80,0,80, 0); //sol üste nasıl gidecek 
                butonlar.Width = 50;
                butonlar.Height = 50;
                butonlar.Click += Butonlar_Click;
                Alan1.Children.Add(butonlar); // bu önceden grid di biz bunu Stack panel yaptık ( stack panal oluşturulan butonlara margin vermesende sıralı olarak alt alta atar 
                                              //butonları stack panel de yan yana dizmek için orientatiın.horizontal kullanacağız.
                                              // ama stack yetersiz kalıyor butonlar dışa taşıyor 
                                              // WrapPanel kullanacağız stack panle yerinede
              
                butonlar.Background = Brushes.DarkCyan;
               
            }

        }

        private void Butonlar_Click(object sender, RoutedEventArgs e)
        {
            Button buton = (Button)sender;
            toplam += Convert.ToInt32(buton.Content);
            buton.Visibility = Visibility.Hidden;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(toplam.ToString());
        }
    }


   
}

