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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        Window2 w;
        public Window3()
        {
            InitializeComponent();
        }
        public Window3(Window2 w)
        {
            InitializeComponent();
            this.w = w;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           w.Title = txtBaslik.Text;
            
        }
    }
}
