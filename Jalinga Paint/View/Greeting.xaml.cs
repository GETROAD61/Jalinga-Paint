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
using System.Windows.Threading;

namespace Jalinga_Paint.View
{
    /// <summary>
    /// Логика взаимодействия для Greeting.xaml
    /// </summary>
    public partial class Greeting : Page
    {
        //Таймер
        DispatcherTimer dt = new DispatcherTimer();

        public Greeting()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dt.Interval = TimeSpan.FromSeconds(5);
            dt.Tick += Dt_Tick;
            dt.Start();
        }

        private void Dt_Tick(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Auth());
            dt.Stop();
        }
    }
}
