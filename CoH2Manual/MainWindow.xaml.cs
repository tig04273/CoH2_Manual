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

namespace CoH2Manual
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //WindowStyle = WindowStyle.None;
            //AllowsTransparency = true;
            this.SizeToContent = SizeToContent.Manual;
            InitializeComponent();
        }

        private void Sov_Button_Click(object sender, RoutedEventArgs e)
        {
            //Window soviet_Form = new SovietForm();
            //soviet_Form.Show();
            Frame_CoH2Manual.Source = new Uri("Soviet\\SovietMain.xaml", UriKind.Relative);
            
        }

        private void USA_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ENG_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GER_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OKW_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Translate_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
