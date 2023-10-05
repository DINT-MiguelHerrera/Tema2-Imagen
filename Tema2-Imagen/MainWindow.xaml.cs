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

namespace Tema2_Imagen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void botonOpacidadAlta_Checked(object sender, RoutedEventArgs e)
        {
            
            imagen.Opacity = 1;
            
        }

        private void botonOpacidadMedia_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = 0.6;
            
        }

        private void botonOpacidaBaja_Checked(object sender, RoutedEventArgs e)
        {
           imagen.Opacity = 0.3;
            
        }

        private void botonAjusteRelleno_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.Fill;
        }

        private void botonAjusteUniforme_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.Uniform;
        }

        private void botonAjusteRellenoUniforme_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.UniformToFill;
        }

        private void botonAjusteSinAjuste_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.None;
        }
    }
}
