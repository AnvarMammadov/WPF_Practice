using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Practice
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

        private void button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var button = (Button)sender;

            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Random random = new Random();
                byte rgbNum1 = Convert.ToByte(random.Next(0, 255));
                byte rgbNum2 = Convert.ToByte(random.Next(0, 255));
                byte rgbNum3 = Convert.ToByte(random.Next(0, 255));

                button.Background = new SolidColorBrush(GetColor(rgbNum1, rgbNum2, rgbNum3));
                MessageBox.Show($"{button.Name}'s Background Color : rgb( {rgbNum1} , {rgbNum2} , {rgbNum3} )", "Button Information",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (e.RightButton == MouseButtonState.Pressed)
            {
                this.Title = $"{button.Content}";
                var stackPanel = (StackPanel)button.Parent;
                stackPanel.Children.Remove(button);
            }
        }

        private Color GetColor(byte rgbNum1, byte rgbNum2, byte rgbNum3)
        {
            return Color.FromRgb(rgbNum1, rgbNum2, rgbNum3);
        }
    }
}
