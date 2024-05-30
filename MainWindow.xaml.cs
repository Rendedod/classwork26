using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace classwork26
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ((Slider)sender).SelectionEnd = e.NewValue;
            progres.Value = e.NewValue;
        }

        private void Fix(object sender, MouseButtonEventArgs e)
        {
            double minimazedProgres;
            double maximazedProgres;

            try
            {
                minimazedProgres = Convert.ToDouble(minimazedProgressBar.Text);
            }
            catch
            {
                minimazedProgressBar.Text = "0";
                minimazedProgres = 0;
            }

            try
            {
                maximazedProgres = Convert.ToDouble(maximazedProgressBar.Text);
            }
            catch
            {
                maximazedProgressBar.Text = "100";
                maximazedProgres = 100;
            }

            progres.Minimum = minimazedProgres;
            progres.Maximum = maximazedProgres;
        }

        private void SliderValueChangedOpasity(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ((Slider)sender).SelectionEnd = e.NewValue;
            double opacity = e.NewValue / 100;
            fixAll.Opacity = (float)opacity;
        }
    }
}
