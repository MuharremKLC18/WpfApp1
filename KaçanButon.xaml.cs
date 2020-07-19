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
    /// Interaction logic for KaçanButon.xaml
    /// </summary>
    public partial class KaçanButon : Window
    {
        public KaçanButon()
        {
            InitializeComponent();
            //MessageBox.Show(this.Width.ToString());
            //MessageBox.Show(this.Height.ToString());
            KacanButon1.MouseMove += KacanButon1_MouseMove;
        }

        int Puan = 0;
       
        
        private void KacanButon1_MouseMove(object sender, MouseEventArgs e)
        {

            Random rnd1 = new Random();
            //KacanButon1.Margin=new Thickness(this.Width.ToString(),);

            //KacanButon1.Margin = new Thickness(rnd1.Next(200), rnd1.Next(200), rnd1.Next(200), rnd1.Next(200));

            KacanButon1.Margin = new Thickness(rnd1.Next((int)(grdıcerık.ColumnDefinitions[0].ActualWidth-KacanButon1.Width)), rnd1.Next((int)(grdıcerık.ActualHeight-KacanButon1.Height)), 0, 0);


            Puan ++ ; // ++ olursa +1 +1 artar istediğin sayıda artırırsan +=; yapacaksın 
            KacanButon1.Content = "Skor : " + Puan;

            //SonKonum = KacanButon1.Margin=(X ,Y);

            ////if () 
            ////{

            ////}

            




        }

     

        private void Lbl1_SizeChanged_1(object sender, SizeChangedEventArgs e)
        {
            //lbl1.Content = "Height:" + this.Height.ToString() + "\nMaxHeight:" + this.MaxHeight + "\nActual Height:" + this.ActualHeight + "\nRender Size Width:" + this.RenderSize.Width + "\nRender:" + this.RenderSize.Width + "\nRender Size Height:" + this.RenderSize.Height + "\nBorderWidth:" + SystemParameters.BorderWidth + "\nCaption Height:" + SystemParameters.CaptionHeight;
           ;
            Puan ++; 
            lbl1.Content = "Skor : "  +Puan;
            Title = "Kaçan Buton Oyunu";

        }

        private void KacanButon1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
