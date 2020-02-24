using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace Card_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string imgpath = ""; 
        BitmapImage bmp;
        public MainWindow()
        {
            InitializeComponent();
            System.Windows.Controls.Image dynamicImage = new System.Windows.Controls.Image();
           
        }

        private void OKbtn_Click(object sender, RoutedEventArgs e)
        {
            imgpath = imagepath.Text;
            showImage(imgpath);
        }
        void showImage(string imagepath)
        {
            this.imgpath = imagepath;
            bmp = new BitmapImage();
            bmp.BeginInit();
            bmp.UriSource = new Uri(imgpath);
            bmp.EndInit();
            // Set Image.Source  
            imageprew.Source = bmp;
        }
    }
}
