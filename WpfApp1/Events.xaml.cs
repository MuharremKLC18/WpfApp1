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
        public Events()
        {
            InitializeComponent();

        }

        private void Msg(object sender, RoutedEventArgs e) // botunların eventlerine tıklandığında (şimşek işaretine tıklayıp hepsine Msg yazarsan (sen ne tanımlarsan ) hepsinde aynı mesaj yazar
        {
            Button btn = (Button)sender; // sender object tipindedir hangi nesneye tıkladığını gösterir.
            MessageBox.Show(btn.Content.ToString());

            btn.Visibility = Visibility.Hidden; // tıkladığın butonu kaybet (gizle)
           

        }


    }
}
