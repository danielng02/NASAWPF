using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace NASAWPF
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            string startDate = Convert.ToDateTime(DatePickStart.Text).ToString("yyyy-MM-dd");
            string endDate = Convert.ToDateTime(DatePickEnd.Text).ToString("yyyy-MM-dd");
            string JSON = String.Format("https://api.nasa.gov/neo/rest/v1/feed?start_date={0}&end_date={1}&api_key=fDYUz8mf87gs1b8txmdHol2s7eTlQLJeL9PfnGql", startDate, endDate);
            label01.Content = JSON;

            AsteroidCollection ast = JsonConvert.DeserializeObject<AsteroidCollection>(JSON);
        }
    }
}
