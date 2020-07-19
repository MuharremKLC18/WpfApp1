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
    /// Interaction logic for GridÖrnek.xaml
    /// </summary>
    public partial class GridÖrnek : Window
    {
        public GridÖrnek()
        {
            InitializeComponent();
            for (int i = 0; i < grd.RowDefinitions.Count; i++) // grd(Grid ismi).RowDefinitions.Count;  Satır sayısını bilmiyorsan yaz
            {
               
                for (int j = 0; j < grd.ColumnDefinitions.Count; j++) // grd.ColumnDefinitions.Count; Sütun sayısını bilmiyorsan yaz
                {
                    Button btn = new Button();
                    btn.Width = 200;
                    btn.Height = 200;
                    Grid.SetRow(btn, i);
                    Grid.SetColumn(btn, j);
                    grd.Children.Add(btn);
                }
            }
        }
    }
}
