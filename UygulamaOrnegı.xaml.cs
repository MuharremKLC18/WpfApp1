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
    /// Interaction logic for UygulamaOrnegı.xaml
    /// </summary>
    public partial class UygulamaOrnegı : Window
    {
        String oyun;
        public UygulamaOrnegı()
        {
            InitializeComponent();
            Title = "Kaçan Buton Oyunu";
         //deneme
                       
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            KaçanButon K1 = new KaçanButon();

            K1.Show();

          

            
        }
       
    }
}
