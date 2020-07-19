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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button btn = new Button();
            btn.Margin = new Thickness(100, 50, 0, 0); // ekranda duracağı yer
            btn.Name = "btnBizimButon";
            btn.Content="Merhaaba Wpf" ;//Button içine yazı yazmak için.
            btn.Width = 200; // boyutlar
            btn.Height = 50; // boyutlar
            btn.Click += Btn_Click; // eylem çalıştırma btn.Click+= yaz Tab'a bas eylem menüsünü aç
            btn.MouseMove += Btn_MouseMove; // tıklamadan üzerine fare geldiğinde mesaj kutusu açılsın 
            grd.Children.Add(btn);

            


        }

        private void Btn_MouseMove(object sender, MouseEventArgs e) // tıklamadan fare butonun üstüne geldiğinde mesaj kutusu açılacak 
        {
            Deneme.Content = "kanka aferin";
        }

        private void Btn_Click(object sender, RoutedEventArgs e) // eylem menüsü btn için 
        {
            //throw new NotImplementedException(); // bunu sil mesaj yazmadığın için hata verir bu otomatik gelir.
            MessageBox.Show("Burda yeni eylemler öğren sadece mesaj gösterme ");
        }

        private void Kanka_Click(object sender, RoutedEventArgs e) // eylem (ivent) tıklandığında açılacak (ekranda görünecek mesaj) 
        {
            MessageBox.Show("ne yaptın şefim");
        }

       
    }
}
