using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace szamolo
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
        int kattok = 0;
        
        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            kattok++;
            lb_1.Content = kattok;
            btn_1.Height += 5;
            btn_1.Width += 5;
            btn_1.FontSize += 1;
            if (kattok == 69)
            {
                btn_1.Content = 69;
                btn_2.Content = 69;
            }
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            kattok = 0;
            lb_1.Content = "";
            btn_1.Height = 100;
            btn_1.Width = 200;
            btn_1.FontSize = 30;
            btn_1.Content = "Kattints ide!";
            btn_2.Content = "Törlés";
        }

        private void btn_be_Click(object sender, RoutedEventArgs e)
        {
            string nev = tb_1.Text;
            lb_2.Content = $"Üdvözöllek kedves {nev}";
            tb_1.Text = "";
            btn_be.IsEnabled = false;
        }
    }
}